using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class DescEvento
    {
		private Modulos modulos;
		private string descripcion;

		public string Descripcion
		{
			get { return descripcion; }
			set { descripcion = value; }
		}


		public Modulos Modulo
		{
			get { return modulos; }
			set { modulos = value; }
		}
	}
}
