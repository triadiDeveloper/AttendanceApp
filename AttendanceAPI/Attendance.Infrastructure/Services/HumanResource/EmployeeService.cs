using Attendance.Application.Interfaces.HumanResource;
using Attendance.Domain.Entitites.HumanResource;

namespace Attendance.Infrastructure.Services.HumanResource
{
    public class EmployeeService : GenericService<Employee>, IEmployeeService
    {
        private readonly AttendanceDBContext _context;

        public EmployeeService(AttendanceDBContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable<Employee> GetByPlantId(int plantId)
        {
            return _context.Employees.Where(e => e.PlantId == plantId);
        }
    }

}