using Attendance.Domain.Entitites.HumanResource;
using Microsoft.AspNetCore.Identity;

namespace Attendance.Domain.Entitites.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public int EmployeeId { get; set; }
        public virtual Employee? Employee { get; set; }
        public string FullName { get; set; } = string.Empty;
    }
}
