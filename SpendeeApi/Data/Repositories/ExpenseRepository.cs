using SpendeeApi.Data.Interfaces;

namespace SpendeeApi.Data.Repositories
{
    public class ExpenseRepository : IRepository<Expense>
    {
        private readonly SpendeeDbContext _context;

        public ExpenseRepository(SpendeeDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Expense expense)
        {
            await _context.Expenses.AddAsync(expense);
            await _context.SaveChangesAsync();
        }


        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Expense>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Expense> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Expense> GetFirstOrDefaultAsync(Func<Expense, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Expense entity)
        {
            throw new NotImplementedException();
        }
    }
}
