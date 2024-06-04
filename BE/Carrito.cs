using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Carrito
    {
		private int id;
		private List<CarritoProducto> productos;
		private Cliente cliente;
		private double precioFinal;

		public double PrecioFinal
		{
			get { return precioFinal; }
			set { precioFinal = value; }
		}


		public Cliente Cliente
		{
			get { return cliente; }
			set { cliente = value; }
		}


		public List<CarritoProducto> Productos
		{
			get { return productos; }
			set { productos = value; }
		}


		public int Id
		{
			get { return id; }
			set { id = value; }
		}

	}
}
