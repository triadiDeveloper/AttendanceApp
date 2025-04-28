using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Attendance.API.Configuration
{
    public class SwaggerSchemaFilter : IDocumentFilter
    {
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            var allowedNamespacePrefix = "Attendance."; // ✅ hanya schema dari project kamu
            var toRemove = context.SchemaRepository.Schemas
                .Where(x => !x.Key.StartsWith(allowedNamespacePrefix) &&
                            !x.Key.StartsWith("ResponseModel") &&
                            !x.Key.StartsWith("RegisterRequest") &&
                            !x.Key.StartsWith("LoginRequest"))
                .Select(x => x.Key)
                .ToList();

            foreach (var item in toRemove)
            {
                context.SchemaRepository.Schemas.Remove(item);
            }
        }
    }
}