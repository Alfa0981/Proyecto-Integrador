using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Factura
    {
		private Carrito carrito;
		private Cliente cliente;
		private int id;
		private double precio;
		private DateTime fecha;

		public DateTime Fecha
		{
			get { return fecha; }
			set { fecha = value; }
		}


		public double Precio
		{
			get { return precio; }
			set { precio = value; }
		}


		public int Id
		{
			get { return id; }
			set { id = value; }
		}


		public Cliente Cliente
		{
			get { return cliente; }
			set { cliente = value; }
		}


		public Carrito Carrito
		{
			get { return carrito; }
			set { carrito = value; }
		}

	}
}
