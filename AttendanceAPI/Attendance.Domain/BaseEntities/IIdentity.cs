namespace Attendance.Domain.BaseEntities;

public interface IIdentityInt
{
    public int Id { get; set; }
}

public interface IIdentityGuid
{
    public Guid Id { get; set; }
}