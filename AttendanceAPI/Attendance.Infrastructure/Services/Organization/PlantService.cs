using Attendance.Application.Interfaces.Organization;
using Attendance.Domain.Entitites.Organization;

namespace Attendance.Infrastructure.Services.Organization
{
    public class PlantService : GenericService<Plant>, IPlantService
    {
        private readonly AttendanceDBContext _context;

        public PlantService(AttendanceDBContext context) : base(context)
        {
            _context = context;
        }
    }
}
