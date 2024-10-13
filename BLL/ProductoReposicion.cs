using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductoReposicion
    {
        MpProductoReposicion mpProductoReposicion = new MpProductoReposicion();

        public void insertarRegistro(BE.ProductoReposicion productoReposicion)
        {
            mpProductoReposicion.insertarProductoReposicion(productoReposicion);
        }
    }
}
