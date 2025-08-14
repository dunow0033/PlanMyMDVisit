using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using planMyMDVisit.Data;
using planMyMDVisit.Models.Domain;
using planMyMDVisit.Models.ViewModels;

namespace planMyMDVisit.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AccountController(UserManager<User> userManager,
            SignInManager<User> signInManager,
            IHttpContextAccessor httpContextAccessor)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    UserName = registerViewModel.UserName,
                    Email = registerViewModel.Email,
                    FirstName = registerViewModel.Firstname,
                    LastName = registerViewModel.Lastname,
                    DoctorOrPatient = registerViewModel.DoctorOrPatient
                };

                var identityResult = await userManager.CreateAsync(user, registerViewModel.Password);

                if (identityResult.Succeeded)
                {
                    var roleIdentityResult = await userManager.AddToRoleAsync(user, "User");

                    if(registerViewModel.DoctorOrPatient.ToLower() == "patient")
                    {
                        var patient = new Patient
                        {
                            Id = Guid.NewGuid(),
                            UserId = user.Id
                        };

                        var dbContext = HttpContext.RequestServices.GetRequiredService<PlanMyMDVisitContext>();
                        dbContext.Patients.Add(patient);
                        await dbContext.SaveChangesAsync();
                    }

                    //if (roleIdentityResult.Succeeded)
                    //{
                        //return RedirectToAction("Register");
                        await signInManager.SignInAsync(user, isPersistent: false);

                        return RedirectToAction("Show", "Patients");
                    //}
                }
                else
                {
                    foreach (var error in identityResult.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }

            return View(registerViewModel);
        }


        [HttpGet]
        public IActionResult Login()
        {
            var model = new LoginViewModel { };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            //var httpContext = _httpContextAccessor.HttpContext;

            //foreach (var claim in httpContext.User.Claims)
            //{
            //    Console.WriteLine($"{claim.Type} = {claim.Value}");
            //}

            var user = await userManager.FindByNameAsync(loginViewModel.UserName);
            //var user = await userManager.Users.Include(u => u.Patient)
            //    .FirstOrDefaultAsync(u => );

            if (await userManager.IsInRoleAsync(user, "Admin"))
            {
                return RedirectToAction("Show", "Admin");
            }

            if (user == null)
            {
                // User not found
                ModelState.AddModelError(string.Empty, "Invalid username.");
                return View(loginViewModel);
            }

            var signInResult = await signInManager.PasswordSignInAsync(
                loginViewModel.UserName, 
                loginViewModel.Password, false, false);

            if (user != null && !signInResult.Succeeded)
            {
                //checking for incorrect password
                ModelState.AddModelError(string.Empty, "Invalid password.");
                return View(loginViewModel);
            }

            if (signInResult != null && signInResult.Succeeded)
            {
                return RedirectToAction("Show", "Patients");
            }

            // Show errors
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
