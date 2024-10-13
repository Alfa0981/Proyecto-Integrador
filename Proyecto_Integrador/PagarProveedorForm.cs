using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Integrador
{
    public partial class PagarProveedorForm : Form
    {
        BE.OrdenCompra ordenCompra;

        public PagarProveedorForm(BE.OrdenCompra orden)
        {
            InitializeComponent();
            InicializarDataGrid();
            this.ordenCompra = orden;
            Inicializar();
        }

        private void Inicializar()
        {
            label2.Text = ordenCompra.Id.ToString();
            proveedorLbl.Text = ordenCompra.Proveedor.Nombre;
            foreach (var producto in ordenCompra.Productos)
            {
                dataGridView2.Rows.Add(producto.Nombre, producto.Precio, producto.Stock);
            }
            precioFinalLbl.Text = ordenCompra.Total.ToString();
        }

        private void generarVentaBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Validando el pago al proveedor...");
            MessageBox.Show("Pago validado con exito.");
        }

        private void InicializarDataGrid()
        {
            dataGridView2.Columns.Clear();
            dataGridView2.Columns.Add("NombreProducto", "Nombre del Producto");
            dataGridView2.Columns.Add("PrecioUnitario", "Precio Unitario");
            dataGridView2.Columns.Add("Cantidad", "Cantidad");
        }
    }
}
