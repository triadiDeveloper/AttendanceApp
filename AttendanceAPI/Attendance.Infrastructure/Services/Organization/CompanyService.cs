using Attendance.Application.Interfaces.Organization;
using Attendance.Domain.Entitites.Organization;

namespace Attendance.Infrastructure.Services.Organization
{
    public class CompanyService : GenericService<Company>, ICompanyService
    {
        private readonly AttendanceDBContext _context;

        public CompanyService(AttendanceDBContext context) : base(context)
        {
            _context = context;
        }
    }
}
