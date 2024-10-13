using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.queries
{
    public class OrdenCompraQuery
    {
        public const string InsertarOrdenCompra = @"
        INSERT INTO OrdenCompra (ProveedorId, FechaEmitida) 
        VALUES (@ProveedorId, @FechaEmitida);
        SELECT SCOPE_IDENTITY();";

        public const string InsertarOrdenCompraProducto = @"
        INSERT INTO OrdenCompraProducto (ProductoId, OrdenCompraId, Cantidad) 
        VALUES (@ProductoId, @OrdenCompraId, @Cantidad);";
    }
}
