using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Factura
    {
        MpFactura mpFactura = new MpFactura();
        BLL.GestionEventos gestionEventos = new BLL.GestionEventos();

        public void crear(BE.Factura factura)
        {
            mpFactura.crear(factura);
            gestionEventos.persistirEvento("Venta generada", BE.Modulos.Ventas.ToString(), 1);
        }
    }
}
