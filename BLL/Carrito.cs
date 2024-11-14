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

        public BE.Carrito buscarPorId(int id)
        {
            return mpCarrito.buscarPorId(id);
        }

        public int crearCarrito(BE.Carrito carritoProducto)
        {
            int id = mpCarrito.Crear(carritoProducto);
            DV.Instance.Generar();
            return id;
        }
    }
}
