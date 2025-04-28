using Attendance.Domain.Entitites.Identity;

namespace Attendance.Application.Interfaces.Identity
{
    public interface IAuthService
    {
        Task<string> LoginAsync(string username, string password);
        Task<bool> RegisterAsync(ApplicationUser user, string password, int employeeId, string role);
    }

}