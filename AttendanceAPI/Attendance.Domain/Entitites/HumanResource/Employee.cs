using Attendance.Domain.BaseEntities;
using Attendance.Domain.Entitites.Organization;

namespace Attendance.Domain.Entitites.HumanResource
{
    public class Employee : BaseCodeName
    {
        public int PlantId { get; set; }
        public virtual Plant? Plant { get; set; }
        public int CompanyId { get; set; }
        public virtual Company? Company { get; set; }
        public string? Image { get; set; }

        // Additional properties to complete Employee data
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Address { get; set; }
        public string? Position { get; set; }
        public DateTime JoinDate { get; set; } = default!;
        public int IJoinDate { get; set; }
        /// <summary>
        /// EndDate digunakan untuk karyawan yang status adalah probation ataupun kontrak
        /// </summary>
        public DateTime? EndDate { get; set; }
        public int? IEndDate { get; set; }
        public DateTime? ResignationDate { get; set; }
        public int? IResignationDate { get; set; }
    }
}
