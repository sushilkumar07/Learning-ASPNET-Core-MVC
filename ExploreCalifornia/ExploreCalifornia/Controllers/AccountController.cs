using ExploreCalifornia.Models.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;

namespace ExploreCalifornia.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        public AccountController(SignInManager<IdentityUser> signInManager
            , UserManager<IdentityUser> userManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
        }
        public IActionResult Register()
        {
            return View(new RegisterViewModel());
        }
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        [Route("Account/Login")]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel, string returnUrl = null)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var result = await _signInManager.PasswordSignInAsync(
                loginViewModel.EmailAddress, loginViewModel.Password,
                loginViewModel.RememberMe, false
                );
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Login Error!!");
                return View();
            }
            if (string.IsNullOrWhiteSpace(returnUrl))
            {
                return RedirectToAction("Index", "Home");
            }

            return Redirect(returnUrl);
        }
        [HttpPost]
        public async Task<IActionResult> Logout(string returnUrl = null)
        {
            await _signInManager.SignOutAsync();
            if (string.IsNullOrWhiteSpace(returnUrl))
            {
                return RedirectToAction("Index", "Home");
            }
            return Redirect(returnUrl);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registration)
        {
            if (!ModelState.IsValid)
                return View(registration);

            var newUser = new IdentityUser
            {
                Email = registration.EmailAddress,
                UserName = registration.EmailAddress,
            };

            var result = await _userManager.CreateAsync(newUser, registration.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors.Select(x => x.Description))
                {
                    ModelState.AddModelError("", error);
                }
                return View();
            }
            return RedirectToAction("Login");
        }
    }
}
