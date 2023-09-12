using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Persistence.Data.Configurations;
public class UserConfiguration : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        
        builder.ToTable("usuario");        
        builder.HasKey(X => X.Id);
        builder.Property(x => x.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)            
            .IsRequired()
            .HasColumnName("idPk")
            .HasColumnType("INT");


        builder.Property(x => x.Username)
            .IsRequired()
            .HasColumnName("username")
            .HasMaxLength(50);

        builder.Property(x => x.Password)
            .IsRequired()
            .HasColumnName("password")
            .HasMaxLength(100);

        builder.Property(x => x.Email)
            .IsRequired()
            .HasColumnName("email")
            .HasMaxLength(100);    

        builder.HasIndex(p => new{
            p.Username,p.Email
        })
        .HasDatabaseName("IX_Username_Email")
        .IsUnique();
        
        builder.HasMany(x => x.Roles)
            .WithMany(x => x.Usuarios)
            .UsingEntity<UsuariosRoles>(
                t => t.HasOne(j => j.Rol)
                    .WithMany(t => t.UsuariosRoles)
                    .HasForeignKey(j => j.RolId),
                t => t.HasOne(j => j.Usuarios)
                    .WithMany(t => t.UsuariosRoles)
                    .HasForeignKey(j => j.UsuarioId),                
                t => {
                    
                    t.ToTable("rolUser");
                    t.Property(j => j.RolId)
                        .HasColumnName("rolIdPk")
                        .IsRequired()
                        .HasColumnType("INT");
                    t.Property(j => j.UsuarioId)
                        .HasColumnName("userIdPk")
                        .IsRequired()
                        .HasColumnType("INT");                    
                    t.HasKey(j => new {j.RolId, j.UsuarioId});
                }
            );
                
            
    }
}