using SpendeeApi.Data.Interfaces;

namespace SpendeeApi.Data.Services
{
    public class ExpenseService : IExpenseService
    {
        private readonly IRepository<Expense> _expenseRepository;

        public ExpenseService(IRepository<Expense> expenseRepository)
        {
            _expenseRepository = expenseRepository;
        }

        public async Task CreateExpenseAsync(Expense expense)
        {
            await _expenseRepository.AddAsync(expense);
        }
    }
}
