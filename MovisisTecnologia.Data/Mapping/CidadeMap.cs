using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovisisTecnologia.Domain.Models;

namespace MovisisTecnologia.Data.Mapping;

public class CidadeMap : IEntityTypeConfiguration<Cidade>
{
    public void Configure(EntityTypeBuilder<Cidade> builder)
    {
        builder.ToTable("CIDADE");

        builder.HasKey(p => p.Id);
        builder.Property(u => u.Id)
            .HasColumnName("ID");
        builder.Property(u => u.Nome)
            .HasColumnName("NOME")
            .IsRequired();
        builder.Property(u => u.UF)
            .HasColumnName("UF")
            .IsRequired()
            .HasMaxLength(2);
        builder.HasMany(x => x.Clientes)
            .WithOne(x => x.Cidade)
            .HasForeignKey(x => x.CidadeId);

    }
}