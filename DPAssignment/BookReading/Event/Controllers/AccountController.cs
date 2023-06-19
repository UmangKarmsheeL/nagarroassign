using Event.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly ILogger<AccountController> logger;

        public SignInManager<IdentityUser> SignInManager { get; }

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, ILogger<AccountController> logger)
        {
            this.userManager = userManager;
            SignInManager = signInManager;
            this.logger = logger;
        }

        [HttpGet]
        public IActionResult Register()
        {
            logger.LogInformation("Registered Called");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            
            var existingUser = await userManager.FindByEmailAsync(registerViewModel.Email);
            var existingUserName = await userManager.FindByNameAsync(registerViewModel.Username);

            if (existingUser != null || existingUserName != null || registerViewModel.Email == null || registerViewModel.Username == null || registerViewModel.Password==null)
            {
                ViewData["LoginFlag"] = "Email or UserName already Registered";
                ModelState.AddModelError(string.Empty, "A user with this email or username already exists.");
                return View(registerViewModel);
            }

            var identityUser = new IdentityUser
            {
                UserName = registerViewModel.Username,
                Email = registerViewModel.Email
            };

            var identityResult = await userManager.CreateAsync(identityUser, registerViewModel.Password);

            if (identityResult.Succeeded)
            {
                var roleIdentityResult = await userManager.AddToRoleAsync(identityUser, "User");
                if (roleIdentityResult.Succeeded)
                {
                    logger.LogInformation("User Registered");
                    return RedirectToAction("Login");
                }
            }

            foreach (var error in identityResult.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            return View(registerViewModel);
        }

        [HttpGet]
        public IActionResult Login()
        {
            logger.LogInformation("Login Called");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            
            if (ModelState.IsValid)
            {
                var signResult = await SignInManager.PasswordSignInAsync(loginViewModel.Username,
                                loginViewModel.Passowrd, false, false);

                if (signResult.Succeeded)
                {
                    logger.LogInformation("User LoggedIn");
                    return RedirectToAction("List", "Event");
                }

                ViewData["LoginFlag"] = "Invalid UserName or Password";
               

                return View();
            }


            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            logger.LogInformation("User LoggedOut");
            await SignInManager.SignOutAsync();
            return RedirectToAction("List", "Event");
        }
    }
}
