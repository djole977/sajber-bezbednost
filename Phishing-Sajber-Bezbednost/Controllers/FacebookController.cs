using Microsoft.AspNetCore.Mvc;
using Phishing_Sajber_Bezbednost.DTOs;
using Phishing_Sajber_Bezbednost.Models;

namespace Phishing_Sajber_Bezbednost.Controllers
{
    public class FacebookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Login(FacebookLoginDto credentials)
        {

            return Ok();
        }
    }
}
