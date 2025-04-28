using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.Authorization;

namespace Attendance.API.Controllers.Identity
{
    [Route("odata/[controller]")]
    [Authorize(Roles = "Admin")]
    public class RolesController : ODataController
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public RolesController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        [EnableQuery]
        [HttpGet]
        public IActionResult Get() => Ok(_roleManager.Roles);
    }
}
