using BE;
using DAL.queries;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MpProducto
    {
        Acceso acceso = new Acceso();

        public List<Producto> buscarTodos()
        {
            DataTable tabla = acceso.leer(queries.ProductoQuery.SeleccionarTodos, null);
            Dictionary<int, Producto> productosDict = new Dictionary<int, Producto>();

            foreach (DataRow row in tabla.Rows)
            {
                int productoId = Convert.ToInt32(row["id"]);

                if (!productosDict.ContainsKey(productoId))
                {
                    Producto producto = ConvertirDataRowAProducto(row);
                    productosDict[productoId] = producto;
                }

                Proveedor proveedor = ConvertirDataRowAProveedor(row);
                if (proveedor != null && proveedor.Id > 0)
                {
                    productosDict[productoId].Proveedores.Add(proveedor);
                }
            }
            return productosDict.Values.ToList();
        }

        private Proveedor ConvertirDataRowAProveedor(DataRow row)
        {
            if (row["ProveedorId"] == DBNull.Value)
                return null;

            return new Proveedor
            {
                Id = Convert.ToInt32(row["ProveedorId"]),
                Nombre = row["ProveedorNombre"].ToString(),
                Dni = row["dni"].ToString(),
                Direccion = row["direccion"].ToString(),
                Telefono = row["telefono"].ToString(),
                Email = row["email"].ToString(),
                Activo = Convert.ToBoolean(row["activo"])
            };
        }

        public void crear(Producto producto)
        {
            SqlParameter[] sqlParameters = new SqlParameter[3];

            sqlParameters[0] = new SqlParameter("@Nombre", producto.Nombre);
            sqlParameters[1] = new SqlParameter("@Stock", producto.Stock);
            sqlParameters[2] = new SqlParameter("@Precio", producto.Precio);

            acceso.escribir(ProductoQuery.Insertar, sqlParameters);
        }

        public void modificar(Producto producto)
        {
            SqlParameter[] sqlParameters = new SqlParameter[5];

            sqlParameters[0] = new SqlParameter("@Id", producto.Id);
            sqlParameters[1] = new SqlParameter("@Nombre", producto.Nombre);
            sqlParameters[2] = new SqlParameter("@Stock", producto.Stock);
            sqlParameters[3] = new SqlParameter("@Precio", producto.Precio);
            sqlParameters[4] = new SqlParameter("@Activo", producto.Activo);

            acceso.escribir(ProductoQuery.Modificar, sqlParameters);
        }

        private Producto ConvertirDataRowAProducto(DataRow row)
        {
            return new Producto
            {
                Id = Convert.ToInt32(row["id"]),
                Nombre = row["nombre"].ToString(),
                Stock = Convert.ToInt32(row["stock"]),
                Precio = Convert.ToDouble(row["precio"]),
                Proveedores = new List<Proveedor>() 
            };
        }
    }
}
