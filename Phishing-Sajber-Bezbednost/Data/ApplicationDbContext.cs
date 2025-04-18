using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Phishing_Sajber_Bezbednost.Data.Models;

namespace Phishing_Sajber_Bezbednost.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<UserCredentials> UserCredentials { get; set; }
    }
}