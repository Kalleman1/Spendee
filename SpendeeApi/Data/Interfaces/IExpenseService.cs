namespace SpendeeApi.Data.Interfaces
{
    public interface IExpenseService
    {
        Task CreateExpenseAsync(Expense expense);
    }
}
