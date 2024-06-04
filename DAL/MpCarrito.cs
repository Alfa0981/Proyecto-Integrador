using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MpCarrito
    {
        Acceso acceso = new Acceso();

        public int Crear(Carrito carrito)
        {
            try
            {
                acceso.comenzarTransaccion();

                SqlParameter[] parametrosCarrito = new SqlParameter[]
                {
                    new SqlParameter("@ClienteId", carrito.Cliente.Id),
                    new SqlParameter("@PrecioFinal", carrito.PrecioFinal)
                };

                string queryCarrito = queries.CarritoQuery.InsertarCarrito;

                int carritoId = Convert.ToInt32(acceso.leer(queryCarrito, parametrosCarrito).Rows[0][0]);

                string queryProducto = queries.CarritoQuery.InsertarCarritoProd;

                foreach (var carritoProducto in carrito.Productos)
                {
                    SqlParameter[] parametrosProducto = new SqlParameter[]
                    {
                        new SqlParameter("@CarritoId", carritoId),
                        new SqlParameter("@ProductoId", carritoProducto.Producto.Id),
                        new SqlParameter("@Cantidad", carritoProducto.Cantidad)
                    };

                    acceso.escribir(queryProducto, parametrosProducto);
                }

                acceso.confirmarTransaccion();
                return carritoId;
            }
            catch (Exception)
            {
                acceso.revertirTransaccion();
                throw;
            }
        }
    }
}
