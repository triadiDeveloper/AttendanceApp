using Attendance.Application.Interfaces.Organization;
using Attendance.Domain.Entitites.Organization;

namespace Attendance.API.Controllers.Organization
{
    public class CompaniesController : GenericODataController<Company>
    {
        public CompaniesController(ICompanyService companyService) : base(companyService)
        {
        }
    }
}