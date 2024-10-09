using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BitacoraCambios
    {
        DAL.MpBitacoraCambios mpBitacoraCambios = new DAL.MpBitacoraCambios();
        BLL.Producto gestorProducto = new BLL.Producto();

        public void modificarProducto(BE.BitacoraCambios cambio)
        {
            gestorProducto.modificarProducto(cambio.Producto);
            mpBitacoraCambios.eliminarUltimaFila(cambio);
            mpBitacoraCambios.updateUltimafila(cambio);
        }

        public List<BE.BitacoraCambios> obtenerTodos()
        {
            return mpBitacoraCambios.obtenerTodos();
        }
    }
}
