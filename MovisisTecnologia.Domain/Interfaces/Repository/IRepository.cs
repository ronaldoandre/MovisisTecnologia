using MovisisTecnologia.Domain.Models;

namespace MovisisTecnologia.Domain.Interfaces.Repository;
public interface IRepository<T> where T : BaseModel
{
    Task<T> InsertAsync (T item);
    Task DeleteAsync (int id);
    Task<T> SelectByIdAsync (int id);
    Task<T> UpdateAsync (T item);
    Task<List<T>> SelectByNameAsync (string name);
}