using Attendance.Application.Interfaces;
using Attendance.Application.Interfaces.Attendance;
using Attendance.Application.Interfaces.HumanResource;
using Attendance.Application.Interfaces.Identity;
using Attendance.Application.Interfaces.Organization;
using Attendance.Domain.Entitites.Identity;
using Attendance.Infrastructure.Services;
using Attendance.Infrastructure.Services.Attendance;
using Attendance.Infrastructure.Services.HumanResource;
using Attendance.Infrastructure.Services.Identity;
using Attendance.Infrastructure.Services.Organization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Attendance.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            // DBContext
            services.AddDbContext<AttendanceDBContext>(options =>
                options.UseSqlServer(config.GetConnectionString("LOCAL")));

            // Generic Service
            services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));

            // Custom Services
            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
            })
           .AddEntityFrameworkStores<AttendanceDBContext>()
           .AddDefaultTokenProviders();

            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IAuthService, AuthService>();

            // Tambahkan service lain jika perlu
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<IPlantService, PlantService>();
            services.AddScoped<IAbsenceService, AbsenceService>();

            return services;
        }
    }
}