using Attendance.API.Helper;
using Attendance.Application.DTOs.Identity;
using Attendance.Application.Interfaces.Identity;
using Attendance.Domain.Entitites.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Routing.Controllers;

namespace Attendance.API.Controllers.Identity
{
    [ApiController]
    [Route("odata/[controller]")]
    public class AuthController : ODataController
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest model)
        {
            try
            {
                var token = await _authService.LoginAsync(model.Username, model.Password);
                return Ok(new
                {
                    Data = new { token },
                    Status = ResponseHelper.Success()
                });
            }
            catch (UnauthorizedAccessException)
            {
                return Unauthorized(new { Status = ResponseHelper.Error("U005") });
            }
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest model)
        {
            var user = new ApplicationUser
            {
                UserName = model.Username,
                FullName = model.FullName
            };

            var result = await _authService.RegisterAsync(user, model.Password, model.EmployeeId, model.Role ?? "User");
            return result ? Ok() : BadRequest();
        }
    }
}
