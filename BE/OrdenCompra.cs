using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class OrdenCompra
    {
        private int id;
        private DateTime fechaEmitida;
        private DateTime fechaRecibido;
        private List<Producto> productos;
        private Proveedor proveedor;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime FechaEmitida
        {
            get { return fechaEmitida; }
            set { fechaEmitida = value; }
        }

        public DateTime FechaRecibido
        {
            get { return fechaRecibido; }
            set { fechaRecibido = value; }
        }

        public List<Producto> Productos
        {
            get { return productos; }
            set { productos = value; }
        }

        public Proveedor Proveedor
        {
            get { return proveedor; }
            set { proveedor = value; }
        }
    }
}
