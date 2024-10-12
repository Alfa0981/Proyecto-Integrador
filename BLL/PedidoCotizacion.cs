using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PedidoCotizacion
    {

        MpPedidoCotizacion mpPedidoCotizacion = new MpPedidoCotizacion();

        public void persistirPedidosCotizacion (List<BE.PedidoCotizacion> pedidosCotizacion)
        {
            mpPedidoCotizacion.persistirPedidosCotizacion(pedidosCotizacion);
        }
    }
}
