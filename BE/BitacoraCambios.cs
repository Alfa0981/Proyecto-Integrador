using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BitacoraCambios
    {
		private int id;
		private Producto producto;
		private string nombre;
		private DateTime fecha;
		private TimeSpan hora;
		private int stock;
		private bool activo;

        public BitacoraCambios()
        {
            
        }

        public BitacoraCambios(int id, Producto producto, string nombre, DateTime fecha, int stock, TimeSpan hora, bool act)
        {
			this.id = id;
            this.producto = producto;
            this.nombre = nombre;
            this.fecha = fecha;
            this.stock = stock;
            this.hora = hora;
            this.activo = act;
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public bool Activo
		{
			get { return activo; }
			set { activo = value; }
		}

		public TimeSpan Hora
		{
			get { return hora; }
			set { hora = value; }
		}

		public DateTime Fecha
		{
			get { return fecha; }
			set { fecha = value; }
		}

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		public Producto Producto
		{
			get { return producto; }
			set { producto = value; }
		}

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

	}
}
