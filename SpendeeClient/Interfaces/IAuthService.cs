using SpendeeApi.Models;
using SpendeeClient.Models;

namespace SpendeeClient.Interfaces
{
    public interface IAuthService
    {
        Task<Result<User>> Register(User user);
        Task<Result<User>> Login(User user);
    }
}
