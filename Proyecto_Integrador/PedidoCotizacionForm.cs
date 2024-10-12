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
    public partial class PedidoCotizacionForm : Form
    {
        BLL.Producto gestorProducto = new BLL.Producto();
        BLL.PedidoCotizacion gestorPedidos = new BLL.PedidoCotizacion();
        BE.Producto producto = new BE.Producto();
        List<BE.Producto> productosSeleccionados = new List<BE.Producto>();

        public PedidoCotizacionForm()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            productosDataGrid.DataSource = gestorProducto.mostrarTodos();
            productosDataGrid.Columns["Activo"].Visible = false;
            productosDataGrid.Columns["Precio"].Visible = false;
            productosDataGrid.Columns["Id"].Visible = false;
        }

        private void proveedoresListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void seleccionarBtn_Click(object sender, EventArgs e)
        {
            List<BE.Proveedor> proveedores = checkedListBox1.CheckedItems.Cast<BE.Proveedor>().ToList();

            if (proveedores.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un proveedor para dicho producto");
                return;
            }

            string proveedoresTexto = string.Join(", ", proveedores.Select(p => p.Nombre));
            string textoProductoProveedores = $"{producto.Nombre} : {proveedoresTexto}";

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString().StartsWith(producto.Nombre + " :"))
                {
                    listBox1.Items.RemoveAt(i);
                    break;
                }
            }

            listBox1.Items.Add(textoProductoProveedores);
            producto.Proveedores = proveedores;

            if (productosSeleccionados.Any(p => p.Nombre == producto.Nombre))
            {
                productosSeleccionados.RemoveAll(p => p.Nombre == producto.Nombre);
            }
            productosSeleccionados.Add(producto);
        }

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void registrarProveedoresBtn_Click(object sender, EventArgs e)
        {
            Form registrarProveedor = new RegistrarProveedorForm();
            registrarProveedor.MdiParent = this.MdiParent;
            registrarProveedor.Show();
        }

        private void proveedoresDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            checkedListBox1.Items.Clear();
            producto = (BE.Producto)productosDataGrid.CurrentRow.DataBoundItem;

            foreach (var proveedor in producto.Proveedores)
            {
                checkedListBox1.Items.Add(proveedor);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void notificarBtn_Click(object sender, EventArgs e)
        {
            if (productosSeleccionados.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un producto con proveedor");
                return;
            }

            List<PedidoCotizacion> pedidos = new List<PedidoCotizacion>();
            List<Proveedor> proveedores = new List<Proveedor>();

            foreach (var producto in productosSeleccionados)
            {
                foreach (var proveedor in producto.Proveedores)
                {
                    if (!proveedores.Contains(proveedor))
                        proveedores.Add(proveedor);

                    if (proveedor.Productos == null)
                    {
                        proveedor.Productos = new List<Producto>();
                    }

                    proveedor.Productos.Add(producto);                           
                }
            }

            foreach (var proveedor in proveedores)
            {
                PedidoCotizacion pedidoCotizacion = new PedidoCotizacion()
                {
                    Productos = proveedor.Productos,
                    Proveedor = proveedor,
                };

                pedidos.Add(pedidoCotizacion);
            }
            
            gestorPedidos.persistirPedidosCotizacion(pedidos);
        }
    }
}
