﻿namespace Attendance.Domain.BaseEntities;

public interface IAuditable
{
    string? CreatedUser { get; set; }
    DateTime? CreatedDate { get; set; }
    string? ModifiedUser { get; set; }
    DateTime? ModifiedDate { get; set; }
}
public interface INotAuditable
{

}
