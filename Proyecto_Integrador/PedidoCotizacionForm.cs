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

        public PedidoCotizacionForm()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            productosCombo.DataSource = gestorProducto.mostrarTodos();
            productosCombo.DisplayMember = "Nombre";
            productosCombo.SelectedIndex = -1;
        }

        private void proveedoresListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void seleccionarBtn_Click(object sender, EventArgs e)
        {

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
    }
}
