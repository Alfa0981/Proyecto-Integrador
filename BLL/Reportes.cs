using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Reportes
    {
        MpReportes mpReportes = new MpReportes();

        public Dictionary<BE.Cliente, BE.Producto> ObtenerReporte()
        {
            return mpReportes.ObtenerReporte();
        }
    }
}
