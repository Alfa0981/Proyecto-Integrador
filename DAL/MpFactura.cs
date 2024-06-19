using BE;
using DAL.queries;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MpFactura
    {
        Acceso acceso = new Acceso();

        public void crear(Factura factura)
        {
            SqlParameter[] sqlParameters = new SqlParameter[4];

            sqlParameters[0] = new SqlParameter("@CarritoId", factura.Carrito.Id);
            sqlParameters[1] = new SqlParameter("@ClienteId", factura.Cliente.Id);
            sqlParameters[2] = new SqlParameter("@Precio", factura.Precio);
            sqlParameters[3] = new SqlParameter("@Fecha", factura.Fecha);

            acceso.escribir(FacturaQuery.Insertar, sqlParameters);
        }
    }
}
