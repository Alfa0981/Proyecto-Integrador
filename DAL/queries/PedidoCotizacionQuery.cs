using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.queries
{
    public class PedidoCotizacionQuery
    {
        public const string InsertarPedidoCotizacion = @"insert into PedidoCotizacion (proveedorId) values (@ProveedorId);
                                                            SELECT SCOPE_IDENTITY();";
        public const string InsertarPedidoCotizacionProducto = "insert into PedidoCotizacionProducto (ProductoId, PedidoCotizacionId) values (@ProductoId, @PedidoCotizacionId)";
    }
}
