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
        INSERT INTO OrdenCompra (ProveedorId, FechaEmitida, Total) 
        VALUES (@ProveedorId, @FechaEmitida, @Total);
        SELECT SCOPE_IDENTITY();";

        public const string InsertarOrdenCompraProducto = @"
        INSERT INTO OrdenCompraProducto (ProductoId, OrdenCompraId, Cantidad) 
        VALUES (@ProductoId, @OrdenCompraId, @Cantidad);";

        public const string ObtenerOrdenCompraPorId = @"
        SELECT oc.Id, oc.FechaEmitida, oc.FechaRecibido, oc.ProveedorId, p.Nombre AS NombreProveedor
        FROM OrdenCompra oc
        INNER JOIN Proveedor p ON oc.ProveedorId = p.Id
        WHERE oc.Id = @IdOrdenCompra";

        public const string ObtenerProductosPorOrdenCompra = @"
        SELECT ocp.ProductoId, pr.Nombre AS NombreProducto, ocp.Cantidad
        FROM OrdenCompraProducto ocp
        INNER JOIN Producto pr ON ocp.ProductoId = pr.Id
        WHERE ocp.OrdenCompraId = @IdOrdenCompra";

        public const string ActualizarOrden = @"
        UPDATE OrdenCompra SET FechaRecibido = @FechaRecibido WHERE id = @IdOrdenCompra;";
    }
}
