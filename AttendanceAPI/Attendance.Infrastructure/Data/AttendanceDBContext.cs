using Attendance.Domain.Entitites.Attendance;
using Attendance.Domain.Entitites.HumanResource;
using Attendance.Domain.Entitites.Identity;
using Attendance.Domain.Entitites.Organization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class AttendanceDBContext : IdentityDbContext<ApplicationUser>
{
    public AttendanceDBContext(DbContextOptions<AttendanceDBContext> options) : base(options) { }

    public DbSet<Employee> Employees { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<Plant> Plants { get; set; }
    public DbSet<Absence> Absences { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        // Apply all configurations
        builder.ApplyConfigurationsFromAssembly(typeof(AttendanceDBContext).Assembly);

        // Optionally rename other Identity tables
        builder.Entity<IdentityRole>().ToTable("ApplicationRoles", "Identity");
        builder.Entity<IdentityUserRole<string>>().ToTable("ApplicationUserRoles", "Identity");
        builder.Entity<IdentityUserClaim<string>>().ToTable("ApplicationUserClaims", "Identity");
        builder.Entity<IdentityUserLogin<string>>().ToTable("ApplicationUserLogins", "Identity");
        builder.Entity<IdentityRoleClaim<string>>().ToTable("ApplicationRoleClaims", "Identity");
        builder.Entity<IdentityUserToken<string>>().ToTable("ApplicationUserTokens", "Identity");
    }
}