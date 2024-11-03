using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.queries
{
    public class DVquery
    {

        public const string ActualizarDV = "UPDATE DV SET DVH = @DVH, DVV = @DVV";

        public const string ObtenerDV = "SELECT DVH, DVV FROM DV";
    }
}
