using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using _2.Models;
using _2.ViewModels;
using _2.Controllers;
using Microsoft.AspNetCore.Authentication;

namespace UserIdentityApp.Controllers
{
    public class AccountController : Controller
    {

        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;
        private SignInManager<AppUser> _signInManager;

        public AccountController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _signInManager = signInManager;

        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        [CheckAuthenticated]
        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        [CheckAuthenticated]
        public async Task<IActionResult> Login(LoginViewModel user)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(user.Email, user.Password, user.RememberMe, false);
                if (result.Succeeded)
                {
                    if (user != null)
                    {
                        var authproperties = new AuthenticationProperties();
                        authproperties.IsPersistent = user.RememberMe;
                    }
                    return RedirectToAction("Index", "Home");

                }
                ModelState.AddModelError(string.Empty, "Geçersiz Kullanıcı girişi");
            }

            return View(user);
        }

        [CheckAuthenticated]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [CheckAuthenticated]
        public async Task<IActionResult> Create(CreateViewModel model)
        {

            if (ModelState.IsValid)
            {
                var user = new AppUser { UserName = model.Email, Email = model.Email, FullName = model.FullName };
                IdentityResult result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: true);
                    return RedirectToAction("Index", "Home");
                }
                foreach (IdentityError err in result.Errors)
                {
                    ModelState.AddModelError("", err.Description);
                }
                ModelState.AddModelError(string.Empty, "Geçersiz Kullanıcı girişi");
            }
            return View(model);
        }


    }
}