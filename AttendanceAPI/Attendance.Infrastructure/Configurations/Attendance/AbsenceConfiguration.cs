using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Attendance.Domain.Entitites.Attendance;

namespace Attendance.Infrastructure.Configurations.Attendance
{
    public class AbsenceConfiguration : IEntityTypeConfiguration<Absence>
    {
        public void Configure(EntityTypeBuilder<Absence> builder)
        {
            builder.ToTable("Absence", "Attendance");
            builder.HasKey(x => x.Id);
        }
    }
}