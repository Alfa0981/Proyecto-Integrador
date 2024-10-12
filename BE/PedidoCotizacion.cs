using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PedidoCotizacion
    {
        private int id;
        private Proveedor proveedor;
        private List<Producto> productos;
        private DateTime fechaEmision;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Proveedor Proveedor
        {
            get { return proveedor; }
            set { proveedor = value; }
        }

        public List<Producto> Productos
        {
            get { return productos; }
            set { productos = value; }
        }

        public DateTime FechaEmision
        {
            get { return fechaEmision; }
            set { fechaEmision = value; }
        }
    }
}
