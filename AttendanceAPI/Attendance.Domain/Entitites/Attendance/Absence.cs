using Attendance.Domain.BaseEntities;
using Attendance.Domain.Entitites.HumanResource;

namespace Attendance.Domain.Entitites.Attendance
{
    public class Absence : BaseDomainDetail
    {
        public int EmployeeId { get; set; }
        public virtual Employee? Employee { get; set; }
        public DateTime Date { get; set; }
        public string? Reason { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}