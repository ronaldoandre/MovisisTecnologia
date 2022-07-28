using Microsoft.EntityFrameworkCore;
using MovisisTecnologia.Data.Context;
using MovisisTecnologia.Domain.Interfaces.Repository;
using MovisisTecnologia.Domain.Models;

namespace MovisisTecnologia.Data.Repository;

public class BaseRepository<T> : IRepository<T> where T : BaseModel
{
    protected readonly MovisisTecnologiaContext _context;
    protected DbSet<T> _dataset;
    public BaseRepository(MovisisTecnologiaContext context)
    {
        _context = context;
        _dataset = _context.Set<T>();
    }
    public async Task DeleteAsync(int id)
    {
        var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));
        _dataset.Remove(result);
        await _context.SaveChangesAsync();
    }

    public async Task<T> InsertAsync(T item)
    {
        _dataset.Add(item);
        await _context.SaveChangesAsync();
        return item;
    }

    public virtual async Task<T> SelectByIdAsync(int id)
    {
        return await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));
    }

    public async Task<T> UpdateAsync(T item)
    {
        var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(item.Id));
        _context.Entry(result).CurrentValues.SetValues(item);
        _context.Update(result);
        await _context.SaveChangesAsync();
        return item;
    }

    public virtual async Task<List<T>> SelectByNameAsync(string name)
    {
        return await _dataset
            .Where(e => e.Nome.ToUpper().Contains(name.ToUpper()))
            .ToListAsync();
    }
}