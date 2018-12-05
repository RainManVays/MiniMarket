using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using MiniMarket.Areas.Admin.Models;
using MiniMarket.Context;
using MiniMarket.Infrastructure;

namespace MiniMarket.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        UserContext _userContext;
        public AccountController(UserContext userContext)
        {
            _userContext = userContext;
        }

        [HttpGet]
        public ViewResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(Login loginData)
        {

            var user = _userContext.Users.FirstOrDefault(x => x.Login.Equals(loginData.UserName) && x.IsActive==true);
            if (user!= null)
            {
                if (user.Password.Equals(Crypto.GetStringSha1(loginData.Password)))
                {
                    user.AuthorizeCount = 0;
                    await _userContext.SaveChangesAsync();
                    await Authenticate(loginData.UserName, loginData.Password);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    if (user.AuthorizeCount >= 5)
                    {
                        user.IsActive = false;
                        ModelState.AddModelError("", "Your account was locked!");
                    }
                    else
                    {
                        user.AuthorizeCount++;
                    }
                    await _userContext.SaveChangesAsync();
                }
            }
            ModelState.AddModelError("", "Incorrect login or password");
            return View(loginData);
        }

        private async Task Authenticate(string userName,string password)
        {
            var claim = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType,userName)
            };
            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claim, "ApplicationCookie",
                                                ClaimsIdentity.DefaultNameClaimType,
                                                ClaimsIdentity.DefaultRoleClaimType);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }
    }
}