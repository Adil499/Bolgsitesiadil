using Bolgsitesi.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Bolgsitesi.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        [AllowAnonymous]
        [HttpGet]
        public IActionResult login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> login(Login loginModel)
        {
            var datavalue = c.logins.FirstOrDefault(x => x.kullanciadi == loginModel.kullanciadi
           && x.sifre == loginModel.sifre);
            if (datavalue != null)
            {
                var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, loginModel.kullanciadi)
            };

                var userIdentity = new ClaimsIdentity(claims, "Login");

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);

                //Just redirect to our index after logging in. 
                return RedirectToAction("home", "Home");
            }
            return View();
        }
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("login");
        }
    }
}
