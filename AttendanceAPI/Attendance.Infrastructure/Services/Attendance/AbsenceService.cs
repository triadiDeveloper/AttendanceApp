using Attendance.Application.Interfaces.Attendance;
using Attendance.Domain.Entitites.Attendance;

namespace Attendance.Infrastructure.Services.Attendance
{
    public class AbsenceService : GenericService<Absence>, IAbsenceService
    {
        private readonly AttendanceDBContext _context;

        public AbsenceService(AttendanceDBContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable<Absence> GetByEmployeeId(int employeeId)
        {
            return _context.Absences.Where(a => a.EmployeeId == employeeId);
        }
    }
}
