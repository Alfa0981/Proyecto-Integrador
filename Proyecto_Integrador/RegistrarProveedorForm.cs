using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Integrador
{
    public partial class RegistrarProveedorForm : Form
    {

        BLL.Producto gestorProducto = new BLL.Producto();
        BLL.Proveedor gestorProveedor = new BLL.Proveedor();
        List<BE.Producto> productos = new List<BE.Producto>();
        BE.Proveedor proveedor = new BE.Proveedor();

        public RegistrarProveedorForm()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            listar();
            productosCombo.DataSource = gestorProducto.mostrarTodos();
            productosCombo.DisplayMember = "Nombre";
            productosCombo.SelectedIndex = -1;


            listBox1.DisplayMember = "Nombre";

            modificarBtn.Hide();
            eliminarBtn.Hide();
        }

        private void listar()
        {
            dataGridView1.DataSource = gestorProveedor.obtenerTodos();
            dataGridView1.Columns["Activo"].Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (productosCombo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }
            var producto = (BE.Producto)productosCombo.SelectedItem;
            if (productos.Any(p => p.Nombre == producto.Nombre))
            {
                MessageBox.Show("El item ya se encuentra asociado");
                return;
            }
            productos.Add(producto);
            listBox1.Items.Add(productosCombo.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validarInputs())
            {
                BE.Proveedor proveedor = new BE.Proveedor();
                proveedor.Dni = dniTxt.Text;
                proveedor.Email = emailTxt.Text;
                proveedor.Direccion = direccionTxt.Text;
                proveedor.Nombre = nombreTxt.Text;
                proveedor.Telefono = telefonoTxt.Text;
                proveedor.Productos = productos;

                gestorProveedor.insertarProveedor(proveedor);
                listar();
            }
        }

        private bool validarInputs()
        {
            if (string.IsNullOrEmpty(nombreTxt.Text) ||
                string.IsNullOrEmpty(dniTxt.Text) ||
                string.IsNullOrEmpty(emailTxt.Text) ||
                string.IsNullOrEmpty(telefonoTxt.Text) ||
                string.IsNullOrEmpty(direccionTxt.Text) ||
                productos.Count == 0)
            {
                CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("FaltanCamposException"), IdiomaManager.Instance.ObtenerMensaje(""), "OK");
                return false;
            }
            return true;
        }

        private void dniTxt_Enter(object sender, EventArgs e)
        {
            dniLbl.Hide();
        }

        private void dniTxt_Leave(object sender, EventArgs e)
        {
            if (dniTxt.Text == "")
            {
                dniLbl.Show();
            }
        }

        private void emailTxt_Enter(object sender, EventArgs e)
        {
            emailLbl.Hide();
        }

        private void emailTxt_Leave(object sender, EventArgs e)
        {
            if (emailTxt.Text == "")
            {
                emailLbl.Show();
            }
        }

        private void telefonoTxt_Enter(object sender, EventArgs e)
        {
            telefonoLbl.Hide();
        }

        private void telefonoTxt_Leave(object sender, EventArgs e)
        {
            if (telefonoTxt.Text == "")
            {
                telefonoLbl.Show();
            }
        }

        private void direccionTxt_Enter(object sender, EventArgs e)
        {
            direccionLbl.Hide();
        }

        private void direccionTxt_Leave(object sender, EventArgs e)
        {
            if (direccionTxt.Text == "")
            {
                direccionLbl.Show();
            }
        }

        private void nombreTxt_Leave(object sender, EventArgs e)
        {
            if (nombreTxt.Text == "")
            {
                nombreLbl.Show();
            }
        }

        private void nombreTxt_Enter(object sender, EventArgs e)
        {
            nombreLbl.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            proveedor = (BE.Proveedor)dataGridView1.CurrentRow.DataBoundItem;
            nombreLbl.Hide();
            dniLbl.Hide();
            emailLbl.Hide();
            direccionLbl.Hide();
            telefonoLbl.Hide();

            nombreTxt.Text = proveedor.Nombre;
            dniTxt.Text = proveedor.Dni;
            emailTxt.Text = proveedor.Email;
            direccionTxt.Text = proveedor.Direccion;
            telefonoTxt.Text = proveedor.Telefono;
            productos = proveedor.Productos;

            listBox1.Items.Clear();
            foreach (var producto in proveedor.Productos)
            {
                listBox1.Items.Add(producto);
            }
            
            
            eliminarBtn.Show();
            modificarBtn.Show();
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            if (validarInputs())
            {
                proveedor.Dni = dniTxt.Text;
                proveedor.Email = emailTxt.Text;
                proveedor.Direccion = direccionTxt.Text;
                proveedor.Nombre = nombreTxt.Text;
                proveedor.Telefono = telefonoTxt.Text;
                proveedor.Productos = listBox1.Items.Cast<BE.Producto>().ToList();

                gestorProveedor.modificar(proveedor);
                listar();
            }
        }

        private void removerProductoBtn_Click(object sender, EventArgs e)
        {
            var producto = listBox1.SelectedItem as BE.Producto;
            if (producto != null)
            {
                productos.Remove(producto);
                listBox1.Items.Remove(producto);
            }
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            gestorProveedor.eliminar(proveedor);
            listar();
        }
    }
}
