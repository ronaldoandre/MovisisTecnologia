using Microsoft.EntityFrameworkCore;
using MovisisTecnologia.Data.Mapping;
using MovisisTecnologia.Domain.Models;

namespace MovisisTecnologia.Data.Context;
public class MovisisTecnologiaContext : DbContext
{
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Cidade> Cidades { get; set; }


    public MovisisTecnologiaContext(DbContextOptions<MovisisTecnologiaContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Cliente>(new ClienteMap().Configure);
        modelBuilder.Entity<Cidade>(new CidadeMap().Configure);
    }
}