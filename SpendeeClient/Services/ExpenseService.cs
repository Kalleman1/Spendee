using SpendeeClient.Interfaces;
using SpendeeClient.Models;
using System.Net.Http.Json;

namespace SpendeeClient.Services
{
    public class ExpenseService : IExpenseService
    {
        private readonly HttpClient _httpClient;

        public ExpenseService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Expense>> GetExpenses(int userId)
        {
            return await _httpClient.GetFromJsonAsync<List<Expense>>($"api/expenses/{userId}");
        }

        public async Task<Expense> AddExpense(Expense expense)
        {
            var response = await _httpClient.PostAsJsonAsync("api/expenses", expense);
            return await response.Content.ReadFromJsonAsync<Expense>();
        }
    }
}
