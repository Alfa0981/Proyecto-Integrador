using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
