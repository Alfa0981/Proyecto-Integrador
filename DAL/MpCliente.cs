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
    public class MpCliente
    {
        Acceso acceso = new Acceso();

        public void crear(Cliente cliente)
        {
            SqlParameter[] sqlParameters = new SqlParameter[6];

            sqlParameters[0] = new SqlParameter("@Dni", cliente.Dni);
            sqlParameters[1] = new SqlParameter("@Apellido", cliente.Apellido);
            sqlParameters[2] = new SqlParameter("@Nombre", cliente.Nombre);
            sqlParameters[3] = new SqlParameter("@Direccion", cliente.Direccion);
            sqlParameters[4] = new SqlParameter("@Telefono", cliente.Telefono);
            sqlParameters[5] = new SqlParameter("@Email", cliente.Email);

            acceso.escribir(queries.ClienteQuery.Insertar, sqlParameters);
        }

        public Cliente buscarPorId(int id)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Id", id);

            DataTable tabla = acceso.leer(queries.ClienteQuery.BuscarPorId, sqlParameters);
            if (tabla.Rows.Count == 0)
            {
                throw new Exception("No existe el cliente con el id: " + id);
            }
            else
            {
                return ConvertirDataRowACliente(tabla.Rows[0]);

            }
        }

        private Cliente ConvertirDataRowACliente(DataRow row)
        {
            Cliente cliente = new Cliente
            {
                Id = Convert.ToInt32(row["id"]),
                Dni = row["dni"].ToString(),
                Apellido = row["apellido"].ToString(),
                Nombre = row["nombre"].ToString(),
                Email = row["email"].ToString(),
                Direccion = row["direccion"].ToString(),
                Telefono = row["telefono"].ToString()
            };

            return cliente;
        }

        public Cliente buscarPorDni(string dni)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@Dni", dni);

            DataTable tabla = acceso.leer(queries.ClienteQuery.BuscarPorDni, sqlParameters);
            if (tabla.Rows.Count == 0)
            {
               return null;
            }
            else
            {
                return ConvertirDataRowACliente(tabla.Rows[0]);

            }
        }

        public List<Cliente> buscarTodos()
        {
            DataTable tabla = acceso.leer(queries.ClienteQuery.SeleccionarTodos, null);
            List<Cliente> clientes = new List<Cliente>();

            foreach (DataRow row in tabla.Rows)
            {
                clientes.Add(ConvertirDataRowACliente(row));
            }
            return clientes;
        }

        public void modificar(Cliente cliente)
        {
            SqlParameter[] sqlParameters = new SqlParameter[8];

            sqlParameters[0] = new SqlParameter("@Dni", cliente.Dni);
            sqlParameters[1] = new SqlParameter("@Apellido", cliente.Apellido);
            sqlParameters[2] = new SqlParameter("@Nombre", cliente.Nombre);
            sqlParameters[3] = new SqlParameter("@Direccion", cliente.Direccion);
            sqlParameters[4] = new SqlParameter("@Telefono", cliente.Telefono);
            sqlParameters[5] = new SqlParameter("@Email", cliente.Email);
            sqlParameters[6] = new SqlParameter("@Activo", cliente.Activo);
            sqlParameters[7] = new SqlParameter("@Id", cliente.Id);

            acceso.escribir(queries.ClienteQuery.Actualizar, sqlParameters);
        }
    }
}
