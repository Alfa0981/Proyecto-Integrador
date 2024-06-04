using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class Carrito
    {
        MpCarrito mpCarrito = new MpCarrito();

        public int crearCarrito(BE.Carrito carritoProducto)
        {
            return mpCarrito.Crear(carritoProducto);
        }
    }
}
