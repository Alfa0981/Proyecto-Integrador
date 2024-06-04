using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class CarritoProducto
    {
		private int id;
		private Carrito carrito;
		private Producto producto;
		private int cantidad;

		public int Cantidad
		{
			get { return cantidad; }
			set { cantidad = value; }
		}


		public Producto Producto
		{
			get { return producto; }
			set { producto = value; }
		}


		public Carrito Carrito
		{
			get { return carrito; }
			set { carrito = value; }
		}


		public int Id
		{
			get { return id; }
			set { id = value; }
		}

	}
}
