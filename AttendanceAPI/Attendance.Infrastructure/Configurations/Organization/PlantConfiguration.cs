using Attendance.Domain.Entitites.Organization;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Attendance.Infrastructure.Configurations.Organization
{
    public class PlantConfiguration : IEntityTypeConfiguration<Plant>
    {
        public void Configure(EntityTypeBuilder<Plant> builder)
        {
            builder.ToTable("Plant", "Organization");
            builder.HasKey(e => e.Id);
            builder.HasIndex(x => x.Code).IsUnique();
            builder.Property(e => e.Code).IsRequired().HasMaxLength(20);
            builder.Property(e => e.Name).IsRequired().HasMaxLength(250);
        }
    }
}