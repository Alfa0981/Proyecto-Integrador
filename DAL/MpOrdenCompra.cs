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
    public class MpOrdenCompra
    {
        Acceso acceso = new Acceso();

        public OrdenCompra buscarPorId(int idOrdenCompra)
        {
            OrdenCompra ordenCompra = null;
            try
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@IdOrdenCompra", idOrdenCompra)
                };

                DataTable tablaOrdenCompra = acceso.leer(queries.OrdenCompraQuery.ObtenerOrdenCompraPorId, parametros);
                if (tablaOrdenCompra.Rows.Count > 0)
                {
                    DataRow fila = tablaOrdenCompra.Rows[0];
                    ordenCompra = new OrdenCompra
                    {
                        Id = Convert.ToInt32(fila["Id"]),
                        FechaEmitida = Convert.ToDateTime(fila["FechaEmitida"]),
                        FechaRecibido = (fila["FechaRecibido"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(fila["FechaRecibido"])),
                        Proveedor = new Proveedor
                        {
                            Id = Convert.ToInt32(fila["ProveedorId"]),
                            Nombre = fila["NombreProveedor"].ToString()
                        },
                        Productos = new List<Producto>()
                    };

                    SqlParameter[] productoParams = new SqlParameter[]
                    {
                        new SqlParameter("@IdOrdenCompra", idOrdenCompra)
                    };

                    DataTable productosTabla = acceso.leer(queries.OrdenCompraQuery.ObtenerProductosPorOrdenCompra, productoParams);

                    foreach (DataRow productoFila in productosTabla.Rows)
                    {
                        Producto producto = new Producto
                        {
                            Id = Convert.ToInt32(productoFila["ProductoId"]),
                            Nombre = productoFila["NombreProducto"].ToString(),
                            Stock = Convert.ToInt32(productoFila["Cantidad"])
                        };
                        ordenCompra.Productos.Add(producto);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la busqueda de la orden de compra" + ex.Message);
            }

            return ordenCompra;
        }

        public void modificarOrden(OrdenCompra ordenCompra)
        {
            SqlParameter[] ordenCompraParameter = new SqlParameter[]
            {
                new SqlParameter("@FechaRecibido", ordenCompra.FechaRecibido),
                new SqlParameter("@IdOrdenCompra", ordenCompra.Id),
            };

            acceso.escribir(queries.OrdenCompraQuery.ActualizarOrden, ordenCompraParameter);
        }

        public int persistirOrden(OrdenCompra ordenCompra)
        {
            acceso.comenzarTransaccion();
            try
            {
                SqlParameter[] ordenCompraParameter = new SqlParameter[]
                {
                    new SqlParameter("@ProveedorId", ordenCompra.Proveedor.Id),
                    new SqlParameter("@FechaEmitida", ordenCompra.FechaEmitida),
                    new SqlParameter("@Total", ordenCompra.Total),
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
                return idOrdenCompra;
            }
            catch (Exception ex)
            {
                acceso.revertirTransaccion();
                throw new Exception("Error al persistir la Orden de Compra", ex);
            }
        }
    }
}
