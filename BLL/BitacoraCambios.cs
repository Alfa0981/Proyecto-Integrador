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
            mpBitacoraCambios.desactivarTrigger();
            gestorProducto.modificarProducto(cambio.Producto);
            mpBitacoraCambios.activarYDesactivarRegistro(cambio);
            mpBitacoraCambios.activarTrigger();
        }

        public List<BE.BitacoraCambios> obtenerTodos()
        {
            return mpBitacoraCambios.obtenerTodos();
        }
    }
}
