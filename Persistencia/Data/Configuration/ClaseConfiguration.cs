using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

        public class ClaseConfiguration : IEntityTypeConfiguration<Clase>
        {
            public void Configure(EntityTypeBuilder<Clase>builder)
            {
            //aqui se aplican los metodos de cada entidad
                builder.ToTable("clase")
                //aqui se define la llave primaria
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);
                //se definen los metodos por cada atributo de la clase
                builder.Property(x => x.Id)
                .HasColumnName("Id")
                .HasColumnType("")
                .HasMaxLength(0)
                .IsRequired();

        
            }
        }
    
