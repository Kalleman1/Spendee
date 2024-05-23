using Microsoft.AspNetCore.Mvc;
using SpendeeApi.Data.Interfaces;

namespace SpendeeApi.Controllers
{
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
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
            User user = await _userService.AuthenticateUserAsync(loginUser.Email, loginUser.Password);

            if (user == null)
            {
                return Unauthorized("Your login information was incorrect.");
            }

            return Ok(new {user.Id, user.Name, user.Email});
        }

    }
}
