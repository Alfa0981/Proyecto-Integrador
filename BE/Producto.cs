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
		private double precio;
		private bool activo;
		private List<Proveedor> proveedores;

		public List<Proveedor> Proveedores
		{
			get { return proveedores; }
			set { proveedores = value; }
		}


		public override string ToString()
        {
            return id.ToString();
        }

        public Producto() { 
			this.activo = true;
		}

		public bool Activo
		{
			get { return activo; }
			set { activo = value; }
		}


		public double Precio
		{
			get { return precio; }
			set { precio = value; }
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
