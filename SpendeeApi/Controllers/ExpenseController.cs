using Microsoft.AspNetCore.Mvc;
using SpendeeApi.Data.Interfaces;

namespace SpendeeApi.Controllers
{
    public class ExpenseController : ControllerBase
    {
        private readonly IExpenseService _expenseService;
        private readonly ILogger<ExpenseController> _logger;

        public ExpenseController(IExpenseService expenseService, ILogger<ExpenseController> logger)
        {
            _expenseService = expenseService;
            _logger = logger;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(Expense expense)
        {
            await _expenseService.CreateExpenseAsync(expense);
            return Ok(new {expense });
        }
    }
}
