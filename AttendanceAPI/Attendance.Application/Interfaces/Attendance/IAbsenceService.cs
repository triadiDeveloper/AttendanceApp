using Attendance.Domain.Entitites.Attendance;

namespace Attendance.Application.Interfaces.Attendance
{
    public interface IAbsenceService : IGenericService<Absence>
    {
        IQueryable<Absence> GetByEmployeeId(int employeeId);
    }
}
