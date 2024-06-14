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

        public Carrito buscarPorId(int id)
        {
            SqlParameter[] carritoParametro = new SqlParameter[1];
            carritoParametro[0] = new SqlParameter("@CarritoId", id);

            DataTable carritoTable = acceso.leer(queries.CarritoQuery.BuscarPorId, carritoParametro);

            if (carritoTable.Rows.Count == 0)
            {
                return null;
            }

            Carrito carrito = ConvertirDataRowACarrito(carritoTable.Rows[0]);

            SqlParameter[] carritoProdParam = new SqlParameter[1];
            carritoProdParam[0] = new SqlParameter("@CarritoId", id);
            DataTable productosTable = acceso.leer(queries.CarritoQuery.BuscarProductosPorCarritoId, carritoProdParam);

            foreach (DataRow row in productosTable.Rows)
            {
                carrito.Productos.Add(ConvertirDataRowACarritoProducto(row));
            }

            return carrito;
        }

        private Carrito ConvertirDataRowACarrito(DataRow row)
        {
            return new Carrito
            {
                Id = Convert.ToInt32(row["id"]),
                Cliente = new Cliente
                {
                    Id = Convert.ToInt32(row["cliente_id"]),
                    Nombre = row["nombre"].ToString(),
                    Apellido = row["apellido"].ToString(),
                    Direccion = row["direccion"].ToString(),
                    Dni = row["dni"].ToString(),
                    Telefono = row["telefono"].ToString(),
                    Email = row["email"].ToString()
                },
                PrecioFinal = Convert.ToDouble(row["precioFinal"]),
                Productos = new List<CarritoProducto>()
            };
        }

        private CarritoProducto ConvertirDataRowACarritoProducto(DataRow row)
        {
            return new CarritoProducto
            {
                Id = Convert.ToInt32(row["car_prod_id"]),
                Carrito = new Carrito { Id = Convert.ToInt32(row["carrito_id"]) },
                Producto = new Producto
                {
                    Id = Convert.ToInt32(row["producto_id"]),
                    Nombre = row["nombre"].ToString(),
                    Precio = Convert.ToDouble(row["precio"]),
                    FechaExp = Convert.ToDateTime(row["fechaExp"]),
                    Stock = Convert.ToInt32(row["stock"])
                },
                Cantidad = Convert.ToInt32(row["cantidad"])
            };
        }
    }
}
