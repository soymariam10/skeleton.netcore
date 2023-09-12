namespace Dominio.Entities;

    public class Rol : BaseEntityA
    {
        public string Descripcion { get; set; }
        public ICollection<Usuario>Usuarios { get; set; } = new HashSet<Usuario>();
        public ICollection<UsuariosRoles> UsuariosRoles { get; set; }
    }
