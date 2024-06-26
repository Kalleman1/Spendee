﻿using SpendeeApi.Models;
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

        public async Task<Result<User>> Register(User user)
        {
            var response = await _httpClient.PostAsJsonAsync("api/users/register", user);
            if (response.IsSuccessStatusCode)
            {
                var registeredUser = await response.Content.ReadFromJsonAsync<User>();
                return Result<User>.Success(registeredUser);
            } 
            else
            {
                var errorMessage = await response.Content.ReadAsStringAsync();
                return Result<User>.Failure("An error occoured creating user");
            }
        }

        public async Task<Result<User>> Login(User user)
        {
            var response = await _httpClient.PostAsJsonAsync("api/users/login", user);
            if (response.IsSuccessStatusCode)
            {
                var loggedInUser = await response.Content.ReadFromJsonAsync<User>();
                return Result<User>.Success(loggedInUser);
            }
            else
            {
                var errorMessage = await response.Content.ReadAsStringAsync();
                return Result<User>.Failure("Invalid login attempt");
            }
        }
    }
}
