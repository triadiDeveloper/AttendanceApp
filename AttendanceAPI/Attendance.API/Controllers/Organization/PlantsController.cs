using Attendance.Application.Interfaces;
using Attendance.Domain.Entitites.Organization;

namespace Attendance.API.Controllers.Organization
{
    public class PlantsController : GenericODataController<Plant>
    {
        public PlantsController(IGenericService<Plant> service) : base(service)
        {
        }
    }
}
