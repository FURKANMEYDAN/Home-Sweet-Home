using _2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _2.ViewModels;
using Microsoft.Owin.Host.SystemWeb;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Web;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace _2.Controllers
{
    public class UsersController : Controller
    {
        
        private UserManager<AppUser> _userManager;
        private RoleManager<AppRole> _roleManager;
        private  SignInManager<AppUser> _signInManager;
        public UsersController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager,SignInManager<AppUser> signInManager)
        {

            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {

            return View(_userManager.Users);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index","Home");
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
            if(ModelState.IsValid){
                var result = await _signInManager.PasswordSignInAsync(user.Email,user.Password,user.RememberMe,false);
                if (result.Succeeded)
                {
                    if(user!=null){
                       var authproperties = new AuthenticationProperties();
                       authproperties.IsPersistent = user.RememberMe;
                    }
                    return RedirectToAction("Index","Home");
                
                }
                ModelState.AddModelError(string.Empty,"Geçersiz Kullanıcı girişi");
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
                    return RedirectToAction("Index");
                }
                foreach (IdentityError err in result.Errors)
                {
                    ModelState.AddModelError("", err.Description);
                }
                ModelState.AddModelError(string.Empty,"Geçersiz Kullanıcı girişi");
            }
            return View(model);
        }

        public async Task<IActionResult> Edit(string id)
        {

            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var user = await _userManager.FindByIdAsync(id);

            if (user != null)
            {
                ViewBag.Roles = await _roleManager.Roles.Select(i => i.Name).ToListAsync();
                return View(new EditViewModel
                {
                    Id = user.Id,
                    FullName = user.FullName,
                    Email = user.Email,
                    SelectedRoles = await _userManager.GetRolesAsync(user)
                });
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id, EditViewModel model)
        {

            if (id != model.Id)
            {
                return RedirectToAction("Index");
            }
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(model.Id);
                if (user != null)
                {
                    user.Email = model.Email;
                    user.FullName = model.FullName;
                    var result = await _userManager.UpdateAsync(user);
                    if (result.Succeeded && !string.IsNullOrEmpty(model.Password))
                    {
                        await _userManager.RemovePasswordAsync(user);
                        await _userManager.AddPasswordAsync(user, model.Password);
                    }
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                    foreach (IdentityError err in result.Errors)
                    {
                        ModelState.AddModelError("", err.Description);
                    }
                }
            }
            return View(model);
        }

        [HttpPost]

        public async Task<IActionResult> Delete(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user != null)
            {
                await _userManager.DeleteAsync(user);
            }
            return RedirectToAction("Index");
        }
    }
}