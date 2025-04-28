using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Attendance.Domain.Entitites.Identity;

namespace Attendance.Infrastructure.Configurations.Identity
{
    public class IdentityConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            // Table & schema
            builder.ToTable("ApplicationUsers", "Identity");

            // Primary key
            builder.HasKey(e => e.Id);

            // Properties (custom & inherited)
            builder.Property(e => e.UserName).HasMaxLength(256);
            builder.Property(e => e.NormalizedUserName).HasMaxLength(256);
            builder.Property(e => e.Email).HasMaxLength(256);
            builder.Property(e => e.NormalizedEmail).HasMaxLength(256);
            builder.Property(e => e.FullName).IsRequired().HasMaxLength(100); // Custom

            // Indexes
            builder.HasIndex(e => e.NormalizedUserName).HasDatabaseName("UserNameIndex").IsUnique();
            builder.HasIndex(e => e.NormalizedEmail).HasDatabaseName("EmailIndex");

            // Relationships and other configurations if needed (claims, logins, etc.)
        }
    }
}