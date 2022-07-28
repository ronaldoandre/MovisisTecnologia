using Microsoft.EntityFrameworkCore;
using MovisisTecnologia.Data.Context;
using MovisisTecnologia.Domain.Interfaces.Repository;
using MovisisTecnologia.Domain.Models;

namespace MovisisTecnologia.Data.Repository;

public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
{
    public ClienteRepository(MovisisTecnologiaContext context) : base(context)
    {
    }

    public override async Task<List<Cliente>> SelectByNameAsync(string name)
    {
        return await _dataset
            .Where(e => e.Nome.ToUpper().Contains(name.ToUpper()))
            .Include(e => e.Cidade)
            .ToListAsync();
    }
}