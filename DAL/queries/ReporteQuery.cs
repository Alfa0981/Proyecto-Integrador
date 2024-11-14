using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.queries
{
    public class ReporteQuery
    {
        public const string MayoresCompradoresYProductos = @"
            WITH ComprasUltimoMes AS (
            SELECT f.cliente_id, SUM(f.precio) AS TotalGastado
            FROM Factura f
            WHERE f.fecha >= DATEADD(MONTH, -1, GETDATE())  
            GROUP BY f.cliente_id
        ),
        PromedioGasto AS (
            SELECT AVG(TotalGastado) AS Promedio
            FROM ComprasUltimoMes
        ),
        ClientesVIP AS (
            SELECT c.cliente_id
            FROM ComprasUltimoMes c
            CROSS JOIN PromedioGasto p
            WHERE c.TotalGastado > p.Promedio
        ),
        ProductosFrecuentes AS (
            SELECT cp.producto_id, f.cliente_id, COUNT(cp.producto_id) AS FrecuenciaCompra
            FROM Factura f
            JOIN Carrito c ON f.carrito_id = c.id
            JOIN CarritoProducto cp ON c.id = cp.carrito_id
            WHERE f.cliente_id IN (SELECT cliente_id FROM ClientesVIP)
            AND f.fecha >= DATEADD(MONTH, -1, GETDATE())  
            GROUP BY cp.producto_id, f.cliente_id
        )
        SELECT Top 10 pf.cliente_id, pf.producto_id, pf.FrecuenciaCompra, pr.nombre as producto_nombre, cli.nombre, cli.apellido 
        FROM ProductosFrecuentes pf
        JOIN Cliente cli ON pf.cliente_id = cli.id 
        JOIN Producto pr ON pf.producto_id = pr.id
        where pf.FrecuenciaCompra >1
        ORDER BY pf.FrecuenciaCompra DESC;";
    }
}
