namespace Attendance.Domain.BaseEntities;

public interface ISoftDeletable
{
    bool? IsDeleted { get; set; }
}

