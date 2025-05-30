﻿using IdentityChatEmailNight.Entities;
using IdentityChatEmailNight.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace IdentityChatEmailNight.Controllers
{
    [AllowAnonymous]
    public class LogInController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LogInController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult LogInUser()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogInUser(LoginViewModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, true);

            if (result.Succeeded)
                return RedirectToAction("ProfileDetail", "Profile");
            else
                return View();
        }

        public async Task<IActionResult> LogOutUser()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("LogInUser", "LogIn");
        }
    }
}
