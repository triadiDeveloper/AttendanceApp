using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Attendance.Domain.Entitites.HumanResource;

namespace Attendance.Infrastructure.Configurations.HumanResource
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee", "HumanResource");
            builder.HasKey(e => e.Id);
            builder.HasIndex(x => x.Code).IsUnique();
            builder.Property(e => e.Code).IsRequired().HasMaxLength(20);
            builder.Property(e => e.Name).IsRequired().HasMaxLength(250);
            builder.Property(x => x.JoinDate).HasColumnType("date");
            builder.Property(x => x.EndDate).HasColumnType("date");
            builder.Property(x => x.ResignationDate).HasColumnType("date");
            builder.Property(x => x.IJoinDate).HasComputedColumnSql("CAST(CONVERT(VARCHAR, [JoinDate], 112) AS INT)", stored: true);
            builder.Property(x => x.IEndDate).HasComputedColumnSql("CAST(CONVERT(VARCHAR, [EndDate], 112) AS INT)", stored: true);
            builder.Property(x => x.IResignationDate).HasComputedColumnSql("CAST(CONVERT(VARCHAR, [ResignationDate], 112) AS INT)", stored: true);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.IsActive).HasDefaultValue(true);
            builder.Property(x => x.CreatedDate).HasColumnType("datetime").HasDefaultValueSql("CAST(sysdatetimeoffset() AT TIME ZONE 'SE Asia Standard Time' AS DATETIME)");
            builder.Property(x => x.ModifiedDate).HasColumnType("datetime");
            builder.Property(x => x.Version).IsRowVersion();
        }
    }
}
