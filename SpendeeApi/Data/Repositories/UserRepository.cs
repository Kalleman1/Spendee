using Microsoft.EntityFrameworkCore;
using SpendeeApi.Data.Interfaces;

namespace SpendeeApi.Data.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private readonly SpendeeDbContext _context;

        public UserRepository(SpendeeDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            IEnumerable<User> users = await _context.Users.ToListAsync();

            return users;
        }

        public async Task<User> GetByIdAsync(int id)
        {
            User user = await _context.Users.FindAsync(id);

            return user;
        }

        public async Task AddAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            User userToDelete = await _context.Users.FindAsync(id);
            _context.Users.Remove(userToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }

        public async Task<User> GetFirstOrDefaultAsync(Func<User, bool> predicate)
        {
            return await _context.Users.FirstOrDefaultAsync(u => predicate(u));
        }
    }
}
