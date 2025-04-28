using System.ComponentModel.DataAnnotations;

namespace Attendance.Domain.BaseEntities;

public interface INote
{
    [StringLength(2000)]
    public string? Note { get; set; }
}

