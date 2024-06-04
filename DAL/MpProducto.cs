using BE;
using System;
using System.Collections.Generic;
using System.Data;
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
