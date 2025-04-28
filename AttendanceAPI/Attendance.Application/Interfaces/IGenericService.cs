namespace Attendance.Application.Interfaces;

public interface IGenericService<T> where T : class
{
    IQueryable<T> GetAll();
    Task<T?> GetByIdAsync(object id);
    Task<T> AddAsync(T entity);
    Task<bool> UpdateAsync(T entity);
    Task<bool> DeleteAsync(object id);
}