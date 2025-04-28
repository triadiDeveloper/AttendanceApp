using Attendance.Application.Interfaces;
using Attendance.Domain.Entitites.HumanResource;

namespace Attendance.API.Controllers.HumanResource
{
    public class EmployeesController : GenericODataController<Employee>
    {
        public EmployeesController(IGenericService<Employee> service) : base(service)
        {
        }
    }
}