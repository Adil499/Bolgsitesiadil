using Bolgsitesi.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Bolgsitesi.Controllers
{

    public class SignupController : Controller
    {
        Context c = new Context();
        [HttpGet]
        public IActionResult signup()
        {
            return View();
        }
        [HttpPost]
        public IActionResult signup(Models.Signup k)
        {
            c.signups.Add(k);
            c.SaveChanges();
            return View();

        }
    }
}
