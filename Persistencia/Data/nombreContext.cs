using Microsoft.EntityFrameworkCore;

namespace Persistencia.Data;

    public class nombreContext :DbContext
    {
        //cambiar el nombre de la clase segun corresponda el proyecto y modificar la clase
        public nombreContext(DbContextOptions<nombreContext>options) : base(options)
        {
        }
        //aqui se relacionan las entidades con la base de datos, relacionar todas las entidades
        public DbSet <Clase> Clases { get; set; }
    }
