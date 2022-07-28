using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovisisTecnologia.Domain.Models;

namespace MovisisTecnologia.Data.Mapping;

public class ClienteMap : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("CLIENTE");

        builder.HasKey(p => p.Id);
        builder.Property(u => u.Id)
            .HasColumnName("ID");
        builder.Property(u => u.Nome)
            .HasColumnName("NOME")
            .IsRequired();
        builder.Property(u => u.Apelido)
            .HasColumnName("APELIDO")
            .IsRequired();
        builder.Property(u => u.DataNascimento)
            .HasColumnName("DATA_NASCIMENTO")
            .IsRequired();
        builder.Property(u => u.Telefone)
            .HasColumnName("TELEFONE")
            .IsRequired()
            .HasMaxLength(15);
        builder.HasOne(x => x.Cidade)
            .WithMany(x => x.Clientes)
            .HasForeignKey(x => x.CidadeId);
        builder.Property(u => u.CidadeId)
            .HasColumnName("ID_CLIENTE");

    }
}
