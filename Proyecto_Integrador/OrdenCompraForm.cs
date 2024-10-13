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
    public partial class OrdenCompraForm : Form
    {
        BLL.Producto gestorProducto = new BLL.Producto();
        BLL.OrdenCompra gestorOrdenCompra = new BLL.OrdenCompra();
        List<BE.Producto> productos;

        public OrdenCompraForm()
        {
            InitializeComponent();
            Inicializar();
            InicializarProductosSeleccionadosDataGrid();
        }

        private void Inicializar()
        {
            productos = gestorProducto.mostrarTodos();
            productosDataGrid.DataSource = productos;
            productosDataGrid.Columns["Activo"].Visible = false;
            productosDataGrid.Columns["Precio"].Visible = false;
            productosDataGrid.Columns["Id"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var producto = (BE.Producto)productosDataGrid.CurrentRow.DataBoundItem;
            var proveedor = (BE.Proveedor)proveedorCombo.SelectedItem;

            if (producto != null && proveedor != null)
            {
                foreach (DataGridViewRow row in productosSeleccionadosDataGrid.Rows)
                {
                    if (row.Cells["NombreProducto"].Value.ToString() == producto.Nombre)
                    {
                        MessageBox.Show("El producto ya está en la lista.");
                        return;
                    }
                }

                producto.Precio = (int) precioUnitarioNumeric.Value;
                int cantidad = (int)numericUpDown1.Value;
                double subtotal = producto.Precio * cantidad;

                productosSeleccionadosDataGrid.Rows.Add(producto.Nombre, producto.Precio, cantidad, subtotal, producto.Id);

                proveedorCombo.Enabled = false;

                productosDataGrid.DataSource = productos.Where(p => p.Proveedores.Any(pr => pr.Id == proveedor.Id)).ToList();
            }
            else
            {
                MessageBox.Show("Faltan completar campos.");
                return;
            }
        }

        private void productosDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (proveedorCombo.Enabled)
            {
                var producto = (BE.Producto)productosDataGrid.CurrentRow.DataBoundItem;
                proveedorCombo.DataSource = producto.Proveedores;
                proveedorCombo.SelectedIndex = -1;
            }
        }

        private void InicializarProductosSeleccionadosDataGrid()
        {
            productosSeleccionadosDataGrid.Columns.Clear();
            productosSeleccionadosDataGrid.Columns.Add("NombreProducto", "Nombre del Producto");
            productosSeleccionadosDataGrid.Columns.Add("PrecioUnitario", "Precio Unitario");
            productosSeleccionadosDataGrid.Columns.Add("Cantidad", "Cantidad");
            productosSeleccionadosDataGrid.Columns.Add("Subtotal", "Subtotal");
            productosSeleccionadosDataGrid.Columns.Add("IdProducto", "IdProducto");
            productosSeleccionadosDataGrid.Columns["IdProducto"].Visible = false;
        }

        private void removerBtn_Click(object sender, EventArgs e)
        {
            if (productosSeleccionadosDataGrid.SelectedRows.Count > 0)
            {
                productosSeleccionadosDataGrid.Rows.RemoveAt(productosSeleccionadosDataGrid.SelectedRows[0].Index);
            }
        }

        private void notificarBtn_Click(object sender, EventArgs e)
        {
            OrdenCompra orden = new OrdenCompra
            {
                FechaEmitida = DateTime.Now,
                Productos = new List<Producto>(),
                Proveedor = (Proveedor)proveedorCombo.SelectedItem
            };
            double totalGasto = 0;

            foreach (DataGridViewRow row in productosSeleccionadosDataGrid.Rows)
            {
                Producto producto = new Producto
                {
                    Id = int.Parse(row.Cells["IdProducto"].Value.ToString()),
                    Nombre = row.Cells["NombreProducto"].Value.ToString(),
                    Precio = Convert.ToDouble(row.Cells["PrecioUnitario"].Value),
                    Stock = int.Parse(row.Cells["Cantidad"].Value.ToString())
                };

                double subtotal = producto.Precio * producto.Stock;
                totalGasto += subtotal;
                orden.Productos.Add(producto);
            }
            orden.Total = totalGasto;

            try
            {
                orden.Id = gestorOrdenCompra.persistirOrden(orden);
                Form pagarProveedor = new PagarProveedorForm(orden);
                pagarProveedor.MdiParent = this.MdiParent;
                pagarProveedor.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error: " + ex.Message);
            }
        }
    }
}
