using planMyMDVisit.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using planMyMDVisit.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace planMyMDVisit.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public AccountController(UserManager<User> userManager,
            SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
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

                    if (roleIdentityResult.Succeeded)
                    {
                        //return RedirectToAction("Register");
                        await signInManager.SignInAsync(user, isPersistent: false);

                        return RedirectToAction("Show", "Patients");
                    }
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

            var user = await userManager.FindByNameAsync(loginViewModel.UserName);
            //var user = await userManager.Users.Include(u => u.Patient)
            //    .FirstOrDefaultAsync(u => );

            if (user == null)
            {
                // User not found
                ModelState.AddModelError(string.Empty, "Invalid username.");
                return View(loginViewModel);
            }

            var signInResult = await signInManager.PasswordSignInAsync(loginViewModel.UserName,
                loginViewModel.Password, false, false);

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
