using Attendance.Domain.Entitites.HumanResource;

namespace Attendance.Application.Interfaces.HumanResource
{
    public interface IEmployeeService : IGenericService<Employee>
    {
        IQueryable<Employee> GetByPlantId(int plantId);
    }

}