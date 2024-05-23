﻿using SpendeeApi.Data.Interfaces;

namespace SpendeeApi.Data.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;

        public async Task<User> AuthenticateUserAsync(string email, string password)
        {
            var user = await _userRepository.GetFirstOrDefaultAsync(u => u.Email == email && u.Password == password);
            return user;
        }

        public async Task DeleteUserAsync(int id)
        {
            await _userRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            IEnumerable<User> users = await _userRepository.GetAllAsync();
            return users;
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            User user = await _userRepository.GetByIdAsync(id);
            return user;
        }

        public async Task RegisterUserAsync(User user)
        {
            await _userRepository.AddAsync(user);
        }

        public async Task UpdateUserAsync(User user)
        {
            await _userRepository.UpdateAsync(user);
        }
    }
}
