using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Producto
    {
		private int id;
		private string nombre;
		private int stock;
		private DateTime fechaExp;
		private double precio;

		public double Precio
		{
			get { return precio; }
			set { precio = value; }
		}


		public DateTime FechaExp
		{
			get { return fechaExp; }
			set { fechaExp = value; }
		}


		public int Stock
		{
			get { return stock; }
			set { stock = value; }
		}


		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}


		public int Id
		{
			get { return id; }
			set { id = value; }
		}

	}
}
