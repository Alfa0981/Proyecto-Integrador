using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MpDV
    {

        Acceso acceso = new Acceso();

        public void ActualizarDV(long DVH, long DVV)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@DVH", DVH),
                new SqlParameter("@DVV", DVV),
            };

            acceso.escribir(queries.DVquery.ActualizarDV, parametros);
        }

        public List<Dictionary<string, object>> ObtenerDatosTabla(string tabla)
        {
            List<Dictionary<string, object>> filas = new List<Dictionary<string, object>>();

            var dataTable = acceso.leer($"SELECT * FROM {tabla}", null);

            foreach (System.Data.DataRow row in dataTable.Rows)
            {
                Dictionary<string, object> fila = new Dictionary<string, object>();

                foreach (System.Data.DataColumn column in dataTable.Columns)
                {
                    fila.Add(column.ColumnName, row[column]);
                }

                filas.Add(fila);
            }

            return filas;
        }

        public (long DVH, long DVV) ObtenerDV()
        {
            var dataTable = acceso.leer(queries.DVquery.ObtenerDV, null);

            if (dataTable.Rows.Count > 0)
            {
                long DVH = Convert.ToInt64(dataTable.Rows[0]["DVH"]);
                long DVV = Convert.ToInt64(dataTable.Rows[0]["DVV"]);
                return (DVH, DVV);
            }

            throw new Exception($"No se encontró DV");
        }
    }
}
