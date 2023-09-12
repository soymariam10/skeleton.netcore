using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

public class RolConfiguration : IEntityTypeConfiguration<Rol>
{
    public void Configure(EntityTypeBuilder<Rol> builder)
    {
        builder.ToTable("Rol");
            
        builder.HasKey(p=>p.Id);

        builder.Property(p=>p.Id)
            .IsRequired()
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasMaxLength(200)
            .HasColumnName("id")
            .HasColumnType("INT");

        builder.Property(x=>x.Descripcion)
            .HasColumnName("descripcion")
            .HasMaxLength(100)
            .IsRequired();
    }
}
