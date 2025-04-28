using Attendance.Domain.Entitites.Identity;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace Attendance.API.Controllers.Identity
{
    [Route("odata/[controller]")]
    [Authorize(Roles = "Admin")]
    public class UsersController : ODataController
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UsersController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [EnableQuery]
        [HttpGet]
        public IActionResult Get() => Ok(_userManager.Users);
    }
}
