using Microsoft.EntityFrameworkCore;
using MovisisTecnologia.Data.Context;
using MovisisTecnologia.Domain.Interfaces.Repository;
using MovisisTecnologia.Domain.Models;

namespace MovisisTecnologia.Data.Repository;

public class CidadeRepository : BaseRepository<Cidade>, ICidadeRepository
{
    public CidadeRepository(MovisisTecnologiaContext context) : base(context)
    {
    }
    public override async Task<Cidade> SelectByIdAsync(int id)
    {
        return await _dataset.Include(c => c.Clientes).SingleOrDefaultAsync(p => p.Id.Equals(id));
    }
}