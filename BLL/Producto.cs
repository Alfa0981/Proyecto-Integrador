using DAL;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Producto
    {
        MpProducto mpProducto = new MpProducto();
        BLL.GestionEventos gestionEventos = new BLL.GestionEventos();

        public List<BE.Producto> mostrarTodos()
        {
            return mpProducto.buscarTodos();
        }

        public void modificarProducto(BE.Producto producto)
        {
            mpProducto.modificar(producto);
            gestionEventos.persistirEvento("Producto actualizado", BE.Modulos.Productos.ToString(), 3);
        }

        public void ActualizarStock(BE.Carrito carrito)
        {
            foreach (var carritoProducto in carrito.Productos)
            {
                var producto = carritoProducto.Producto;
                producto.Stock -= carritoProducto.Cantidad;

                if (producto.Stock < 0)
                {
                    throw new Exception(IdiomaManager.Instance.ObtenerMensaje("InsuficienteStockException") + " " + producto.Nombre);
                }

                mpProducto.modificar(producto);
                gestionEventos.persistirEvento("Producto actualizado", BE.Modulos.Productos.ToString(), 3);
            }
        }

        public void crearProducto (BE.Producto producto)
        {
            mpProducto.crear(producto);
            gestionEventos.persistirEvento("Producto agregado", BE.Modulos.Productos.ToString(), 4);
        }

        public void actualizarStockPorId(BE.Producto producto)
        {
            mpProducto.modificarStock(producto);
            gestionEventos.persistirEvento("Producto actualizado", BE.Modulos.Productos.ToString(), 3);
        }
    }
}
