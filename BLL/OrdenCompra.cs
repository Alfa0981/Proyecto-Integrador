using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrdenCompra
    {
        MpOrdenCompra mpOrdenCompra = new MpOrdenCompra();
        BLL.GestionEventos gestorEventos = new BLL.GestionEventos();

        public void persistirOrden(BE.OrdenCompra orden)
        {
            mpOrdenCompra.persistirOrden(orden);
            gestorEventos.persistirEvento("Orden Compra creado", BE.Modulos.Compras.ToString(), 1);
        }
    }
}
