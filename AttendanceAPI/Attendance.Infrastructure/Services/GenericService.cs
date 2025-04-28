using Attendance.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Attendance.Infrastructure.Services;
public class GenericService<T> : IGenericService<T> where T : class
{
    private readonly AttendanceDBContext _context;
    private readonly DbSet<T> _dbSet;

    public GenericService(AttendanceDBContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public IQueryable<T> GetAll() => _dbSet.AsNoTracking();

    public async Task<T?> GetByIdAsync(object id) => await _dbSet.FindAsync(id);

    public async Task<T> AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<bool> UpdateAsync(T entity)
    {
        _dbSet.Update(entity);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> DeleteAsync(object id)
    {
        var data = await GetByIdAsync(id);
        if (data is null) return false;
        _dbSet.Remove(data);
        return await _context.SaveChangesAsync() > 0;
    }
}
