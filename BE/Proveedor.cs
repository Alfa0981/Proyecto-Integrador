using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Proveedor
    {
        private int id;
        private string nombre;
        private string email;
        private string telefono;
        private string direccion;
        private string dni;
        private List<Producto> productos;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
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

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public List<Producto> Productos
        {
            get { return productos; }
            set { productos = value; }
        }
    }

}
