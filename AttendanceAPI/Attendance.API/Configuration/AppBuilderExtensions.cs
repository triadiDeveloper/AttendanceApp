using Attendance.API.Helper;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.OData;

namespace Attendance.API.Configuration
{
    public static class AppBuilderExtensions
    {
        public static IServiceCollection AddSwaggerWithJwt(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Attendance.API", Version = "v1" });

                var securityScheme = new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Description = "Masukkan token JWT Anda: Bearer {token}",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer",
                    BearerFormat = "JWT",
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                    }
                };

                c.AddSecurityDefinition("Bearer", securityScheme);
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    { securityScheme, Array.Empty<string>() }
                });
                c.DocumentFilter<SwaggerSchemaFilter>();
                c.OperationFilter<AddODataHeaderFilter>(); // 👇 kamu buat ini
            });

            return services;
        }

        public static IServiceCollection AddConfiguredOData(this IServiceCollection services)
        {
            services.AddControllers()
                .AddOData(opt => opt
                    .Select()
                    .Filter()
                    .OrderBy()
                    .Expand()
                    .Count()
                    .SetMaxTop(100)
                    .AddRouteComponents("odata", ODataConfig.GetEdmModel())
                    .EnableQueryFeatures());
            return services;
        }
    }
}