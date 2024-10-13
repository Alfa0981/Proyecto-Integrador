using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ProductoReposicion
    {
		private int faltantes;
		private Producto producto;
		private OrdenCompra ordenAsociada;

		public OrdenCompra OrdenAsociada
		{
			get { return ordenAsociada; }
			set { ordenAsociada = value; }
		}


		public Producto Producto
		{
			get { return producto; }
			set { producto = value; }
		}


		public int Faltantes
		{
			get { return faltantes; }
			set { faltantes = value; }
		}

	}
}
