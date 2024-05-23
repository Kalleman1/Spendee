using SpendeeClient.Models;

namespace SpendeeClient.Interfaces
{
    public interface IExpenseService
    {
        Task<List<Expense>> GetExpenses(int userId);
        Task<Expense> AddExpense(Expense expense);
    }
}
