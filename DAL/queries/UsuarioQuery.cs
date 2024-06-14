using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.queries
{
    public abstract class UsuarioQuery
    {
        public const string SeleccionarTodos = @"SELECT u.*, r.nombre as rol_nombre FROM Usuario u
                                 JOIN Rol r ON u.rol_id = r.id WHERE u.activo = 1";
        public const string Insertar = @"INSERT INTO Usuario (dni, apellido, nombre, usuario, pass, rol_id, email, idioma)
                                 VALUES (@Dni, @Apellido, @Nombre, @Usuario, @Pass, @RolId, @Email, @Idioma)";
        public const string BuscarUsername = @"SELECT u.*, r.nombre as rol_nombre FROM Usuario u
                                 JOIN Rol r ON u.rol_id = r.id WHERE u.usuario = @Usuario";
        public const string ModificarUsuario = @"UPDATE Usuario set bloqueo = @Bloqueo, idioma = @Idioma,
                                nombre = @Nombre, apellido = @Apellido,pass = @Pass, rol_id = @RolId,
                                email = @Email, activo = @Activo where usuario = @Usuario;";
        public const string SeleccionarTodosRoles = "SELECT * FROM ROL";
        public const string BuscarDni = @"SELECT u.*, r.nombre as rol_nombre FROM Usuario u
                                 JOIN Rol r ON u.rol_id = r.id WHERE u.dni = @Dni";
    }
}
