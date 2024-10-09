using BE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MpBitacoraCambios
    {
        Acceso acceso = new Acceso();

        public void activarTrigger()
        {
            acceso.escribir(queries.BitacoraCambiosQuery.ActivarTrigger, null);
        }

        public void desactivarTrigger()
        {
            acceso.escribir(queries.BitacoraCambiosQuery.DesactivarTrigger, null);
        }

        public List<BE.BitacoraCambios> obtenerTodos()
        {
            DataTable table = acceso.leer(queries.BitacoraCambiosQuery.SeleccionarTodos, null);
            List<BitacoraCambios> cambios = new List<BitacoraCambios>();

            foreach (DataRow row in table.Rows)
            {
                Producto producto = new Producto
                {
                    Id = Convert.ToInt32(row["Cod_Prod"]),
                    Nombre = row["nombre"].ToString(),
                    Precio = Convert.ToInt32(row["precio"])
                };

                BitacoraCambios cambio = new BitacoraCambios
                {
                    Id = Convert.ToInt32(row["id"]),
                    Producto = producto,
                    Nombre = row["Nombre"].ToString(),
                    Fecha = Convert.ToDateTime(row["Fecha"]),
                    Hora = (TimeSpan)row["Hora"],
                    Stock = Convert.ToInt32(row["Stock"]),
                    Activo = Convert.ToBoolean(row["Act"])
                };

                cambios.Add(cambio);
            }

            return cambios;
        }

        public void activarYDesactivarRegistro(BitacoraCambios cambio)
        {
            SqlParameter[] parameters2 = new SqlParameter[]
            {
                new SqlParameter("@Cod_Prod", cambio.Producto.Id)
            };

            acceso.escribir(queries.BitacoraCambiosQuery.DesactivarRegistro, parameters2);

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", cambio.Id)
            };

            acceso.escribir(queries.BitacoraCambiosQuery.ActivarRegistro, parameters);
        }
    }
}
