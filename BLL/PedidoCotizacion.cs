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
        BLL.GestionEventos gestorEventos = new BLL.GestionEventos();

        public void persistirPedidosCotizacion (List<BE.PedidoCotizacion> pedidosCotizacion)
        {
            mpPedidoCotizacion.persistirPedidosCotizacion(pedidosCotizacion);
            gestorEventos.persistirEvento("Orden Compra creado", BE.Modulos.Compras.ToString(), 1);
            DV.Instance.Generar();
        }
    }
}
