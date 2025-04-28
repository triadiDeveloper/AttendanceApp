using Attendance.Application.Interfaces;
using Attendance.Domain.Entitites.Attendance;

namespace Attendance.API.Controllers.Attendance
{
    public class AbsencesController : GenericODataController<Absence>
    {
        public AbsencesController(IGenericService<Absence> service) : base(service) { }
    }
}