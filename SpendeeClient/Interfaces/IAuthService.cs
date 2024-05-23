using SpendeeClient.Models;

namespace SpendeeClient.Interfaces
{
    public interface IAuthService
    {
        Task<User> Register(User user);
        Task<User> Login(User user);
    }
}
