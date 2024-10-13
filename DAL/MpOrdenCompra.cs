using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MpOrdenCompra
    {
        Acceso acceso = new Acceso();

        public void persistirOrden(OrdenCompra ordenCompra)
        {
            acceso.comenzarTransaccion();
            try
            {
                SqlParameter[] ordenCompraParameter = new SqlParameter[]
                {
                    new SqlParameter("@ProveedorId", ordenCompra.Proveedor.Id),
                    new SqlParameter("@FechaEmitida", ordenCompra.FechaEmitida),
                };

                int idOrdenCompra = Convert.ToInt32(acceso.leer(queries.OrdenCompraQuery.InsertarOrdenCompra, ordenCompraParameter).Rows[0][0]);

                foreach (var producto in ordenCompra.Productos)
                {
                    SqlParameter[] ordenCompraProductoParameter = new SqlParameter[]
                    {
                        new SqlParameter("@ProductoId", producto.Id),
                        new SqlParameter("@OrdenCompraId", idOrdenCompra),
                        new SqlParameter("@Cantidad", producto.Stock)
                    };

                    acceso.escribir(queries.OrdenCompraQuery.InsertarOrdenCompraProducto, ordenCompraProductoParameter);
                }

                acceso.confirmarTransaccion();
            }
            catch (Exception ex)
            {
                acceso.revertirTransaccion();
                throw new Exception("Error al persistir la Orden de Compra", ex);
            }
        }
    }
}
