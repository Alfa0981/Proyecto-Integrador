using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cliente
    {
		private string nombre;
		private string apellido;
		private string direccion;
		private string dni;
		private string telefono;
		private string email;
		private int id;
        private bool activo;

        public Cliente()
        {
            this.activo = true;
        }

		public bool Activo
		{
			get { return activo; }
			set { activo = value; }
		}


		public int Id
		{
			get { return id; }
			set { id = value; }
		}


		public string Email
		{
			get { return email; }
			set { email = value; }
		}


		public string Telefono
		{
			get { return telefono; }
			set { telefono = value; }
		}


		public string Dni
		{
			get { return dni; }
			set { dni = value; }
		}


		public string Direccion
		{
			get { return direccion; }
			set { direccion = value; }
		}


		public string Apellido
		{
			get { return apellido; }
			set { apellido = value; }
		}


		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

        public override string ToString()
        {
			return this.nombre + " " + this.apellido;
        }

    }
}
