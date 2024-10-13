using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MpPedidoCotizacion
    {
        Acceso acceso = new Acceso();

        public void persistirPedidosCotizacion(List<BE.PedidoCotizacion> pedidosCotizacion)
        {
            acceso.comenzarTransaccion();
            try
            {
                foreach (var pedido in pedidosCotizacion)
                {
                    SqlParameter[] pedidoCotizacionParameter = new SqlParameter[]
                    {
                        new SqlParameter("@ProveedorId",pedido.Proveedor.Id)
                    };
                    int idPedido = Convert.ToInt32(acceso.leer(queries.PedidoCotizacionQuery.InsertarPedidoCotizacion, pedidoCotizacionParameter).Rows[0][0]);

                    foreach (var producto in pedido.Productos)
                    {
                        SqlParameter[] pedidoCotizacionProductoParameter = new SqlParameter[]
                        {
                            new SqlParameter("@ProductoId", producto.Id),
                            new SqlParameter("@PedidoCotizacionId", idPedido)
                        };

                        acceso.escribir(queries.PedidoCotizacionQuery.InsertarPedidoCotizacionProducto, pedidoCotizacionProductoParameter);
                    }
                }
                acceso.confirmarTransaccion();
            }
            catch (Exception ex)
            {
                acceso.revertirTransaccion();
                throw new Exception("Error al persistir el pedido de cotizacion", ex);
            }
        }
    }
}
