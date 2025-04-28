namespace Attendance.Application.Settings
{
    public class JwtSettings
    {
        public string Secret { get; set; } = default!;
        public string ValidIssuer { get; set; } = default!;
        public string ValidAudience { get; set; } = default!;
        public int tokenExpirationInMinutes { get; set; }
        public int refreshTokenExpirationInDays { get; set; }
    }
}
