using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.queries
{
    internal class FacturaQuery
    {
        public const string SeleccionarTodos = @"SELECT f.* FROM Factura";
        public const string Insertar = @"
                                        INSERT INTO Factura (carrito_id, cliente_id, fecha, precio) 
                                        VALUES (@CarritoId, @ClienteId, @Fecha, @Precio);";
    }
}
