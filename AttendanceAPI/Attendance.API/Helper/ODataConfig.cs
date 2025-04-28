using Attendance.Domain.Entitites.Organization;
using Attendance.Domain.Entitites.Attendance;
using Attendance.Domain.Entitites.Identity;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using Microsoft.AspNetCore.Identity;
using Attendance.Domain.Entitites.HumanResource;

namespace Attendance.API.Helper
{
    public static class ODataConfig
    {
        public static IEdmModel GetEdmModel()
        {
            var builder = new ODataConventionModelBuilder();

            // Attendance
            builder.EntitySet<Absence>("Absences");

            // HumanResource
            builder.EntitySet<Employee>("Employees");

            // Organization
            builder.EntitySet<Company>("Companies");
            builder.EntitySet<Plant>("Plants");

            // Identity
            builder.EntitySet<ApplicationUser>("ApplicationUsers");
            builder.EntitySet<IdentityRole>("ApplicationRoles");

            return builder.GetEdmModel();
        }
    }
}
