using Microsoft.AspNetCore.Mvc;
using SpendeeApi.Data.Interfaces;

namespace SpendeeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ILogger<UsersController> _logger;

        public UsersController(IUserService userService, ILogger<UsersController> logger)
        {
            _userService = userService;
            _logger = logger;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register (User user)
        {
            await _userService.RegisterUserAsync(user);
            return Ok(new {user.Id, user.Name, user.Email});
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] User loginUser)
        {
            try
            {
                var user = await _userService.AuthenticateUserAsync(loginUser.Email, loginUser.Password);

                if (user == null)
                {
                    return Unauthorized("Your login information was incorrect.");
                }

                return Ok(new { user.Id, user.Name, user.Email });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while logging in user.");
                return StatusCode(500, "Internal server error");
            }
        }

    }
}
