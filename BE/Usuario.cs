using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Usuario
    {
		private int id;
		private string dni;
		private string apellido;
		private string nombre;
		private string user;
		private string pass;
		private string email;
		private bool bloqueo; //por defecto 0
		private bool activo; //por defecto 1
		private Idioma idioma;
		private Perfil perfil;

		public Perfil Perfil
		{
			get { return perfil; }
			set { perfil = value; }
		}


		public Idioma Idioma
		{
			get { return idioma; }
			set { idioma = value; }
		}


		public Usuario(string user, string pass)
		{
			this.user = user;
			this.pass = pass;
		}

		public Usuario()
		{
			this.Bloqueo = false;
			this.Activo = true;
		}

		public bool Activo
		{
			get { return activo; }
			set { activo = value; }
		}


		public bool Bloqueo
		{
			get { return bloqueo; }
			set { bloqueo = value; }
		}

		public string Email
		{
			get { return email; }
			set { email = value; }
		}

		public string Pass
		{
			get { return pass; }
			set { pass = value; }
		}

		public string User
		{
			get { return user; }
			set { user = value; }
		}

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		public string Apellido
		{
			get { return apellido; }
			set { apellido = value; }
		}

		public string Dni
		{
			get { return dni; }
			set { dni = value; }
		}

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

        public override string ToString()
        {
            return user;
        }
    }
}
