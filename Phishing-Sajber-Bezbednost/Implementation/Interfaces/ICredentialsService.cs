namespace Phishing_Sajber_Bezbednost.Implementation.Interfaces
{
    public interface ICredentialsService
    {
        Task CaptureUserCredentials(string email, string password, string service);
    }
}