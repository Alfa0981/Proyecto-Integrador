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

        public void crear(BE.Factura factura)
        {
            mpFactura.crear(factura);
        }
    }
}
