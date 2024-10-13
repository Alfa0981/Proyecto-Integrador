using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MpProductoReposicion
    {
        Acceso acceso = new Acceso();

        public void insertarProductoReposicion(BE.ProductoReposicion productoReposicion)
        {
            SqlParameter[] productoReposicionParameter = new SqlParameter[]
            {
                new SqlParameter("@Faltantes", productoReposicion.Faltantes),
                new SqlParameter("@ProductoId", productoReposicion.Producto.Id),
                new SqlParameter("@OrdenCompraId", productoReposicion.OrdenAsociada.Id),
            };
            var query = queries.ProductoReposicionQuery.InsertarRegistro;
            acceso.escribir(query, productoReposicionParameter);
        }
    }
}
