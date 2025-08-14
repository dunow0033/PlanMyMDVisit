using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using planMyMDVisit.Models.Domain;
using planMyMDVisit.Models.ViewModels;
using planMyMDVisit.Repositories;
using planMyMDVisit.Utilities;

namespace planMyMDVisit.Controllers
{
    public class AdminController : Controller
    {
        private readonly IPatientRepository patientRepository;
        private readonly IUserRepository userRepository;
        private readonly IDoctorRepository doctorRepository;
        private readonly IHealthCareTeamRepository healthCareTeamRepository;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly SignInManager<User> signInManager;

        public AdminController(IPatientRepository patientRepository,
                IUserRepository userRepository,
                IDoctorRepository doctorRepository,
                IHealthCareTeamRepository healthCareTeamRepository,
                IHttpContextAccessor httpContextAccessor,
                SignInManager<User> signInManager)
        {
            this.patientRepository = patientRepository;
            this.userRepository = userRepository;
            this.doctorRepository = doctorRepository;
            this.healthCareTeamRepository = healthCareTeamRepository;
            this.httpContextAccessor = httpContextAccessor;
            this.signInManager = signInManager;
        }

            public IActionResult Index()
            {
                return View();
            }

            public async Task<IActionResult> Show()
            {
                var signInResult = await signInManager.PasswordSignInAsync("admin", "admin", false, false);

                //var allUsers = userRepository.GetAll();

                //var allDoctors = doctorRepository.GetAllDoctors();

                //var allPatients = await patientRepository.GetAllPatients();
                

                var viewModel = new AdminMainMenu
                {
                    Users = await userRepository.GetAll(),
                    //Users = await userRepository.GetAll(),
                    Patients = await patientRepository.GetAllPatients(),
                    Doctors = await doctorRepository.GetAllDoctors(),
                };

                return View(viewModel);
            }

        public IActionResult CreateUser()
        {
            return View();
        }

        //[HttpPost]
        //public async IActionResult Create(AdminCreateUserViewModel adminCreateUserViewModel)
        //{

        //    if (ModelState.IsValid)
        //    {
        //        var user = new User
        //        {
        //            UserName = adminCreateUserViewModel.UserName,
        //            Email = adminCreateUserViewModel.Email,
        //            FirstName = adminCreateUserViewModel.Firstname,
        //            LastName = adminCreateUserViewModel.Lastname,
        //            Admin = adminCreateUserViewModel.AdminOrRegularUser,
        //            DoctorOrPatient = adminCreateUserViewModel.DoctorOrPatient
        //        };

        //        var identityResult = await userManager.CreateAsync(user, registerViewModel.Password);
        //    }
        //}

        public async Task<IActionResult> FilterUsers(string type)
        {
            var model = new AdminMainMenu();

            if(type == "doctors")
            {
                model.Doctors = await doctorRepository.GetAllDoctors();
            }
            else if(type == "patients")
            {
                model.Patients = await patientRepository.GetAllPatients();
            }
            else
            {
                model.Users = await userRepository.GetAll();
            }

            return PartialView("_UserListPartial", model);
        }

        //[HttpGet]
        //public async Task<IActionResult> Patient(Guid id)
        //{
        //    var patient = await patientRepository.GetPatientById(id);

        //    return View("Patient/Profile", patient);
        //}

        //[HttpGet]
        //public async Task<IActionResult> ShowP(Guid id)
        //{
        //    var patient = await patientRepository.GetPatientById(id);

        //    return View("Patient/Profile", patient);
        //}

        [HttpGet]
        public async Task<IActionResult> FullProfile(Guid userId)
        {
            var user = await userRepository.GetUserById(userId);

            return View("User/Show", user);
        }

        [HttpGet]
        public async Task<IActionResult> EditUser(Guid id)
        {
            var userToEdit = await userRepository.GetUserById(id);
            if (userToEdit == null)
            {
                return NotFound();
            }

            var editUserViewModel = new EditUserViewModel
            {
                Id = userToEdit.Id,
                UserId = userToEdit.Id,
                FirstName = userToEdit.FirstName,
                LastName = userToEdit.LastName,
                UserName = userToEdit.UserName,
                Email = userToEdit.Email
            };

            ViewData["Name"] = $"Update {userToEdit.FullName}";
            return View("User/Edit", editUserViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> EditPatient(EditUserViewModel editUserViewModel)
        {
            //var patientToEdit = new EditUserViewModel
            //{
            //    Id = editUserViewModel.Id,
            //    FirstName = editUserViewModel.FirstName,
            //    LastName = editUserViewModel.LastName,
            //    UserName = editUserViewModel.UserName,
            //    Email = editUserViewModel.Email
            //};

            var updatedPatient = await patientRepository.UpdateAsync(editUserViewModel.Id, editUserViewModel, editUserViewModel.NewPassword);

            if (updatedPatient != null)
            {
                return RedirectToAction("Show");
            }

            ModelState.AddModelError("", "Update failed.");
            return View("User/Edit", editUserViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> EditPatientInfo(Guid patientId)
        {
            var patientToEdit = await patientRepository.GetPatientById(patientId);
            if (patientToEdit == null)
            {
                return NotFound();
            }

            var editUserViewModel = new EditUserViewModel
            {
                Id = patientToEdit.Id,
                UserId = patientToEdit.User.Id,
                FirstName = patientToEdit.User.FirstName,
                LastName = patientToEdit.User.LastName,
                UserName = patientToEdit.User.UserName,
                Email = patientToEdit.User.Email,
                Patient = patientToEdit
            };

            ViewData["Name"] = $"Update {patientToEdit.User.FullName}'s Information";
            return View("Patient/Edit", editUserViewModel);
        }

        //[HttpPost]
        //public async Task<IActionResult> EditPatientInfo(EditPatientInfoViewModel viewModel)
        //{
        //    var updatedPatient = await patientRepository.UpdatePatientInfoAsync(viewModel.Id, viewModel, viewModel.NewPassword);

        //    if (updatedPatient != null)
        //    {
        //        return RedirectToAction("Show");
        //    }

        //    ModelState.AddModelError("", "Update failed.");
        //    return View("Patient/Edit", viewModel);
        //}

        [HttpGet]
        public async Task<IActionResult> Doctor(Guid id)
        {
            var doctor = await doctorRepository.GetDoctorById(id);

            return View("../Doctors/Show", doctor);
        }

        [HttpGet]
        public async Task<IActionResult> UserProfile(Guid id)
        {
            var doctors = await doctorRepository.GetAllDoctors();
            var doctor = doctors.FirstOrDefault(d => d.Id == id);
            //planMyMDVisit.Doctors
            //.Include(d => d.User)
            //.FirstOrDefaultAsync(d => d.Id == id);

            if (doctor?.User == null)
            {
                return NotFound();
            }

            //var user = await userRepository.GetUserById(id);

            return View("User/Show", doctor.User);
        }

        [HttpPost]
        public async Task<IActionResult> DeletePatient(Guid id)
        {
            var deletePatient = await patientRepository.DeleteAsync(id);

            if(deletePatient != null)
            {
                TempData["Success"] = $"Patient {deletePatient.User.FullName()} was successfully deleted.";
                return RedirectToAction("Show");
            }

            TempData["Error"] = $"Error: Could not delete patient {deletePatient.User.FullName()}.";
            return RedirectToAction("Show");
        }

        [HttpGet]
        public async Task<IActionResult> EditHealthCareTeamInfo(Guid patientId)
        {
            var currentPatient = await patientRepository.GetPatientById(patientId);

            return View("HealthCareTeams/Edit", currentPatient);
        }
    }
}
