namespace Dominio.Entities;

    public class UsuariosRoles
    {
        public int UsuarioId { get; set; }
        public Usuario Usuarios { get; set; }
        public int RolId { get; set; }
        public Rol Rol { get; set; }
    }
