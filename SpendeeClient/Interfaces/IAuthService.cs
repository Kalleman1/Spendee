using SpendeeApi.Models;
using SpendeeClient.Models;

namespace SpendeeClient.Interfaces
{
    public interface IAuthService
    {
        Task<User> Register(User user);
        Task<Result<User>> Login(User user);
    }
}
