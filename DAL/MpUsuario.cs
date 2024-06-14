using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MpUsuario
    {
        Acceso acceso = new Acceso();

        public void crear(Usuario usuario)
        {
            SqlParameter[] sqlParameters = new SqlParameter[8];

            sqlParameters[0] = new SqlParameter("@Dni", usuario.Dni );
            sqlParameters[1] = new SqlParameter("@Apellido", usuario.Apellido);
            sqlParameters[2] = new SqlParameter("@Nombre", usuario.Nombre);
            sqlParameters[3] = new SqlParameter("@Usuario", usuario.User);
            sqlParameters[4] = new SqlParameter("@Pass", usuario.Pass);
            sqlParameters[5] = new SqlParameter("@RolId", usuario.Rol.Id);
            sqlParameters[6] = new SqlParameter("@Email", usuario.Email);
            sqlParameters[7] = new SqlParameter("@Idioma", usuario.Idioma.ToString());

            acceso.escribir(queries.UsuarioQuery.Insertar, sqlParameters);
        }

        public Usuario buscarPorUsername (string username)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Usuario", username);

            DataTable tabla = acceso.leer(queries.UsuarioQuery.BuscarUsername, sqlParameters);
            if (tabla.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                return ConvertirDataRowAUsuario(tabla.Rows[0]);

            }
        }

        public List<Usuario> buscarTodos()
        {
            DataTable tabla = acceso.leer(queries.UsuarioQuery.SeleccionarTodos, null);
            List<Usuario> usuarios = new List<Usuario>();

            foreach (DataRow row in tabla.Rows)
            {
                usuarios.Add(ConvertirDataRowAUsuario(row));
            }
            return usuarios;
        }

        public List<Rol> buscarTodosRoles()
        {
            DataTable tabla = acceso.leer(queries.UsuarioQuery.SeleccionarTodosRoles, null);
            List<Rol> roles = new List<Rol>();

            foreach (DataRow row in tabla.Rows)
            {
                roles.Add(ConvertirDataRowARol(row));
            }
            return roles;
        }

        public void modificarUsuario (Usuario usuario)
        {
            SqlParameter[] sqlParameters = new SqlParameter[10];

            sqlParameters[0] = new SqlParameter("@Dni", usuario.Dni);
            sqlParameters[1] = new SqlParameter("@Apellido", usuario.Apellido);
            sqlParameters[2] = new SqlParameter("@Nombre", usuario.Nombre);
            sqlParameters[3] = new SqlParameter("@Usuario", usuario.User);
            sqlParameters[4] = new SqlParameter("@Pass", usuario.Pass);
            sqlParameters[5] = new SqlParameter("@RolId", usuario.Rol.Id);
            sqlParameters[6] = new SqlParameter("@Email", usuario.Email);
            sqlParameters[7] = new SqlParameter("@Activo", usuario.Activo ? 1 : 0);
            sqlParameters[8] = new SqlParameter("@Bloqueo", usuario.Bloqueo ? 1 : 0);
            sqlParameters[9] = new SqlParameter("@Idioma", usuario.Idioma.ToString());

            acceso.escribir(queries.UsuarioQuery.ModificarUsuario, sqlParameters);

        }

        private Rol ConvertirDataRowARol(DataRow row)
        {
            Rol rol = new Rol()
            {
                Id = Convert.ToInt32(row["id"]),
                Nombre = row["nombre"].ToString()
            };

            return rol;
        }

        private Usuario ConvertirDataRowAUsuario(DataRow row)
        {
            Usuario usuario = new Usuario
            {
                Id = Convert.ToInt32(row["id"]),
                Dni = row["dni"].ToString(),
                Apellido = row["apellido"].ToString(),
                Nombre = row["nombre"].ToString(),
                User = row["usuario"].ToString(),
                Pass = row["pass"].ToString(),
                Rol = new Rol
                {
                    Id = Convert.ToInt32(row["rol_id"]),
                    Nombre = row["rol_nombre"].ToString() 
                },
                Email = row["email"].ToString(),
                Bloqueo = Convert.ToBoolean(row["bloqueo"]),
                Activo = Convert.ToBoolean(row["activo"]),
                Idioma = Enum.TryParse(row["idioma"].ToString(), out Idioma idioma) ? idioma : Idioma.Spanish
            };

            return usuario;
        }

        public Usuario buscarPorDni(string dni)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Dni", dni);

            DataTable tabla = acceso.leer(queries.UsuarioQuery.BuscarDni, sqlParameters);
            if (tabla.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                return ConvertirDataRowAUsuario(tabla.Rows[0]);

            }
        }
    }
}
