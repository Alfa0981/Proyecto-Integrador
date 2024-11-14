using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MpReportes
    {
        Acceso acceso = new Acceso();

        public Dictionary<BE.Cliente, BE.Producto> ObtenerReporte()
        {
            Dictionary<BE.Cliente, BE.Producto> reporte = new Dictionary<BE.Cliente, BE.Producto>();

            var result = acceso.leer(queries.ReporteQuery.MayoresCompradoresYProductos, null);

            foreach (DataRow row in result.Rows)
            {
                BE.Cliente cliente = new BE.Cliente()
                {
                    Id = (int)row["cliente_id"],
                    Nombre = row["nombre"].ToString(),
                    Apellido = row["apellido"].ToString(),
                };
                BE.Producto producto = new BE.Producto()
                {
                    Id = (int)row["producto_id"],
                    Nombre = row["producto_nombre"].ToString(),
                };
                reporte.Add(cliente, producto);
            }
            return reporte;
        }
    }
}
