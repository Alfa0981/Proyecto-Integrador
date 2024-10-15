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
    public class MpProveedor
    {
        Acceso acceso = new Acceso();

        public List<BE.Proveedor> obtenerTodos()
        {
            List<BE.Proveedor> proveedores = new List<BE.Proveedor>();

            DataTable table = acceso.leer(queries.ProveedorQuery.ObtenerTodos, null);

            Dictionary<int, BE.Proveedor> dictProveedores = new Dictionary<int, BE.Proveedor>();

            foreach (DataRow row in table.Rows)
            {
                int proveedorId = Convert.ToInt32(row["ProveedorId"]);

                if (!dictProveedores.ContainsKey(proveedorId))
                {
                    BE.Proveedor proveedor = new BE.Proveedor
                    {
                        Id = proveedorId,
                        Nombre = row["ProveedorNombre"].ToString(),
                        Email = row["Email"].ToString(),
                        Telefono = row["Telefono"].ToString(),
                        Direccion = row["Direccion"].ToString(),
                        Dni = row["Dni"].ToString(),
                        NumeroCuenta = row["NumeroCuenta"].ToString(),
                        Productos = new List<BE.Producto>() 
                    };

                    dictProveedores.Add(proveedorId, proveedor);
                }

                BE.Producto producto = new BE.Producto
                {
                    Id = Convert.ToInt32(row["ProductoId"]),
                    Nombre = row["ProductoNombre"].ToString(),
                    Stock = Convert.ToInt32(row["Stock"])
                };

                dictProveedores[proveedorId].Productos.Add(producto);
            }

            proveedores = dictProveedores.Values.ToList();

            return proveedores;
        }

        public void CrearProveedor(BE.Proveedor proveedor)
        {
            SqlParameter[] parametrosProveedor = new SqlParameter[]
            {
                new SqlParameter("@Nombre", proveedor.Nombre),
                new SqlParameter("@Email", proveedor.Email),
                new SqlParameter("@Telefono", proveedor.Telefono),
                new SqlParameter("@Direccion", proveedor.Direccion),
                new SqlParameter("@Dni", proveedor.Dni),
                new SqlParameter("@NumeroCuenta", proveedor.NumeroCuenta),
            };

            int idProveedor = Convert.ToInt32(acceso.leer(queries.ProveedorQuery.InsertarProveedor, parametrosProveedor).Rows[0][0]);

            foreach (BE.Producto producto in proveedor.Productos)
            {
                SqlParameter[] parametrosProveedorProducto = new SqlParameter[]
                {
                    new SqlParameter("@ProveedorId", idProveedor),
                    new SqlParameter("@ProductoId", producto.Id)
                };

                acceso.escribir(queries.ProveedorQuery.InsertarProveedorProducto, parametrosProveedorProducto);
            }
        }

        public void modificar(Proveedor proveedor)
        {

            acceso.comenzarTransaccion();

            try
            {
                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                    new SqlParameter("@Dni", proveedor.Dni),
                    new SqlParameter("@Nombre", proveedor.Nombre),
                    new SqlParameter("@Direccion", proveedor.Direccion),
                    new SqlParameter("@Telefono", proveedor.Telefono),
                    new SqlParameter("@Email", proveedor.Email),
                    new SqlParameter("@Activo", proveedor.Activo),
                    new SqlParameter("@Id", proveedor.Id),
                    new SqlParameter("@NumeroCuenta", proveedor.NumeroCuenta),
                };

                acceso.escribir(queries.ProveedorQuery.Actualizar, sqlParameters);

                SqlParameter[] sqlParametersEliminar = new SqlParameter[]
                {
                    new SqlParameter("@ProveedorId", proveedor.Id)
                };
                acceso.escribir(queries.ProveedorQuery.EliminarPorProveedor, sqlParametersEliminar);

                foreach (var producto in proveedor.Productos)
                {
                    SqlParameter[] sqlParametersInsertar = new SqlParameter[]
                    {
                        new SqlParameter("@ProveedorId", proveedor.Id),
                        new SqlParameter("@ProductoId", producto.Id)
                    };

                    acceso.escribir(queries.ProveedorQuery.InsertarProveedorProducto, sqlParametersInsertar);
                }

                acceso.confirmarTransaccion();
            }
            catch (Exception ex)
            {
                acceso.revertirTransaccion();
            }
        }

        public BE.Proveedor buscarPorDni(Proveedor proveedor)
        {
            Proveedor proveedorEncontrado = null;

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Dni", proveedor.Dni),
            };

            DataTable table = acceso.leer(queries.ProveedorQuery.BuscarPorDni, sqlParameters);

            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];

                proveedorEncontrado = new Proveedor
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Nombre = row["Nombre"].ToString(),
                    Email = row["Email"].ToString(),
                    Telefono = row["Telefono"].ToString(),
                    Direccion = row["Direccion"].ToString(),
                    Dni = row["Dni"].ToString(),
                };
            }

            return proveedorEncontrado;
        }
    }
}
