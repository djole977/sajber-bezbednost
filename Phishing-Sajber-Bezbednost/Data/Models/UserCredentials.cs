namespace Phishing_Sajber_Bezbednost.Data.Models
{
    public class UserCredentials : BaseModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Service { get; set; }
    }
}