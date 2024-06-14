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
            List<Producto> productos = new List<Producto>();

            foreach (DataRow row in tabla.Rows)
            {
                productos.Add(ConvertirDataRowAProducto(row));
            }
            return productos;
        }

        public void crear(Producto producto)
        {
            SqlParameter[] sqlParameters = new SqlParameter[4];

            sqlParameters[0] = new SqlParameter("@Nombre", producto.Nombre);
            sqlParameters[1] = new SqlParameter("@Stock", producto.Stock);
            sqlParameters[2] = new SqlParameter("@FechaExp", producto.FechaExp);
            sqlParameters[3] = new SqlParameter("@Precio", producto.Precio);

            acceso.escribir(ProductoQuery.Insertar, sqlParameters);
        }

        public void modificar(Producto producto)
        {
            SqlParameter[] sqlParameters = new SqlParameter[5];

            sqlParameters[0] = new SqlParameter("@Id", producto.Id);
            sqlParameters[1] = new SqlParameter("@Nombre", producto.Nombre);
            sqlParameters[2] = new SqlParameter("@Stock", producto.Stock);
            sqlParameters[3] = new SqlParameter("@FechaExp", producto.FechaExp);
            sqlParameters[4] = new SqlParameter("@Precio", producto.Precio);

            acceso.escribir(ProductoQuery.Modificar, sqlParameters);
        }

        private Producto ConvertirDataRowAProducto(DataRow row)
        {
            Producto producto = new Producto
            {
                Id = Convert.ToInt32(row["id"]),
                Nombre = row["nombre"].ToString(),
                Stock = Convert.ToInt32(row["stock"]),
                FechaExp = Convert.ToDateTime(row["fechaExp"]),
                Precio = Convert.ToDouble(row["precio"])
            };

            return producto;
        }
    }
}
