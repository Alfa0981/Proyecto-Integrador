using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL.queries
{
    public abstract class CarritoQuery
    {
        public const string InsertarCarrito = @"
                    INSERT INTO Carrito (cliente_id, precioFinal) 
                    VALUES (@ClienteId, @PrecioFinal);
                    SELECT SCOPE_IDENTITY();";
        public const string InsertarCarritoProd = @"
                        INSERT INTO CarritoProducto (carrito_id, producto_id, cantidad) 
                        VALUES (@CarritoId, @ProductoId, @Cantidad);";
        public const string BuscarPorId = @"
                                            SELECT cart.*, cli.* FROM Carrito cart 
                                            JOIN Cliente cli ON cart.cliente_id = cli.id
                                            WHERE cart.id = @CarritoId";

        public const string BuscarProductosPorCarritoId = @"
                                        SELECT cp.car_prod_id, cp.carrito_id, cp.producto_id, 
                                        cp.cantidad, p.nombre, p.precio, p.stock
                                        FROM CarritoProducto cp
                                        INNER JOIN Producto p ON cp.producto_id = p.id
                                        WHERE cp.carrito_id = @CarritoId";
    }
}
