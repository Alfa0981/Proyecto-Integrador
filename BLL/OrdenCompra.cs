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

        public BE.OrdenCompra buscarPorId(int idOrdenCompra)
        {
            return mpOrdenCompra.buscarPorId(idOrdenCompra);
        }

        public int persistirOrden(BE.OrdenCompra orden)
        {
            int id = mpOrdenCompra.persistirOrden(orden);
            gestorEventos.persistirEvento("Orden Compra creado", BE.Modulos.Compras.ToString(), 1);
            return id;
        }

        public void recibirOrden(BE.OrdenCompra ordenCompra)
        {
            ordenCompra.FechaRecibido = DateTime.Now;
            mpOrdenCompra.modificarOrden(ordenCompra);
            gestorEventos.persistirEvento("Orden Compra recibida", BE.Modulos.Compras.ToString(), 1);
        }
    }
}
