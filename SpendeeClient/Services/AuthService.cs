using SpendeeClient.Interfaces;
using SpendeeClient.Models;
using System.Net.Http.Json;

namespace SpendeeClient.Services
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;

        public AuthService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<User> Register(User user)
        {
            var response = await _httpClient.PostAsJsonAsync("api/users/register", user);
            return await response.Content.ReadFromJsonAsync<User>();
        }

        public async Task<User> Login(User user)
        {
            var response = await _httpClient.PostAsJsonAsync("api/users/login", user);
            return await response.Content.ReadFromJsonAsync<User>();
        }
    }
}
