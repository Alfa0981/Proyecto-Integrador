using BE;
using BLL;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Integrador
{
    public partial class FormRegistrarCliente : Form, IIdiomaObserver
    {

        BLL.Cliente gestorCliente = new BLL.Cliente();
        BE.Cliente cliente;

        public FormRegistrarCliente()
        {
            InitializeComponent();
            IdiomaManager.Instance.Suscribir(this);
            ActualizarIdioma(IdiomaManager.Instance.IdiomaActual);
        }

        private void FormRegistrarCliente_Load(object sender, EventArgs e)
        {
            listar();
            modificarBtn.Hide();
            eliminarBtn.Hide();
            button1.Enabled = false;
            eliminarBtn.Enabled = false;
            modificarBtn.Enabled = false;
            if (SessionManager.GetInstance.Usuario.Perfil.TienePermiso(TipoPermiso.CRUDClientes) ||
                SessionManager.GetInstance.Usuario.Perfil.TienePermiso(TipoPermiso.AdminPatente))
            {
                button1.Enabled = true;
                eliminarBtn.Enabled = true;
                modificarBtn.Enabled = true;
            }
        }

        private void listar()
        {
            dataGridView1.DataSource = gestorCliente.buscarTodos();
            dataGridView1.Columns["Activo"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (validarInputs())
            {
                BE.Cliente cliente = new BE.Cliente();
                cliente.Dni = dniTxt.Text;
                cliente.Email = emailTxt.Text;
                string direccion = UserEncryption.EncryptData(direccionTxt.Text);
                cliente.Direccion = direccion;
                cliente.Nombre = nombreTxt.Text;
                cliente.Apellido = apellidoTxt.Text;
                cliente.Telefono = telefonoTxt.Text;

                try
                {
                    gestorCliente.crear(cliente);
                    CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("CargaConExito"), IdiomaManager.Instance.ObtenerMensaje(""), "OK");
                    listar();
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(ex.Message, IdiomaManager.Instance.ObtenerMensaje(""), "OK");
                }
            }
        }

        private bool validarInputs()
        {
            if (string.IsNullOrEmpty(nombreTxt.Text)||
                string.IsNullOrEmpty(apellidoTxt.Text) ||
                string.IsNullOrEmpty(dniTxt.Text) ||
                string.IsNullOrEmpty(emailTxt.Text) ||
                string.IsNullOrEmpty(telefonoTxt.Text) ||
                string.IsNullOrEmpty(direccionTxt.Text))
            {
                CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("FaltanCamposException"), IdiomaManager.Instance.ObtenerMensaje(""), "OK");
                return false;
            }
            return true;
        }

        private void nombreTxt_Enter(object sender, EventArgs e)
        {
            label1.Hide();
        }

        public void ActualizarIdioma(Idioma nuevoIdioma)
        {
            label1.Text = IdiomaManager.Instance.ObtenerMensaje("Nombre");
            label2.Text = IdiomaManager.Instance.ObtenerMensaje("Apellido");
            dniLbl.Text = IdiomaManager.Instance.ObtenerMensaje("Dni");
            emailLbl.Text = IdiomaManager.Instance.ObtenerMensaje("Email");
            telefonoLbl.Text = IdiomaManager.Instance.ObtenerMensaje("Telefono");
            direccionLbl.Text = IdiomaManager.Instance.ObtenerMensaje("Direccion");
            button1.Text = IdiomaManager.Instance.ObtenerMensaje("Cargar");
            modificarBtn.Text = IdiomaManager.Instance.ObtenerMensaje("Modificar");
            eliminarBtn.Text = IdiomaManager.Instance.ObtenerMensaje("Eliminar");
            this.Text = IdiomaManager.Instance.ObtenerMensaje("FormRegistrarCliente");
        }

        private void apellidoTxt_Enter(object sender, EventArgs e)
        {
            label2.Hide();
        }

        private void apellidoTxt_Leave(object sender, EventArgs e)
        {
            if (apellidoTxt.Text == "")
            {
                label2.Show();
            }
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
                label1.Show();
            }
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            gestorCliente.eliminar(cliente);
            listar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cliente = (BE.Cliente)dataGridView1.CurrentRow.DataBoundItem;
            label1.Hide();
            label2.Hide();
            dniLbl.Hide();
            emailLbl.Hide();
            direccionLbl.Hide();
            telefonoLbl.Hide();

            nombreTxt.Text = cliente.Nombre;
            apellidoTxt.Text = cliente.Apellido;
            dniTxt.Text = cliente.Dni;
            emailTxt.Text = cliente.Email;
            direccionTxt.Text = cliente.Direccion;
            telefonoTxt.Text = cliente.Telefono;

            cliente.Direccion = UserEncryption.EncryptData(cliente.Direccion);

            eliminarBtn.Show();
            modificarBtn.Show();
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            if (validarInputs())
            {
                cliente.Dni = dniTxt.Text;
                cliente.Email = emailTxt.Text;
                string direccion = UserEncryption.EncryptData(direccionTxt.Text);
                cliente.Direccion = direccion;
                cliente.Nombre = nombreTxt.Text;
                cliente.Apellido = apellidoTxt.Text;
                cliente.Telefono = telefonoTxt.Text;

                gestorCliente.modificar(cliente);
                CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("ModificadoConExito"), IdiomaManager.Instance.ObtenerMensaje(""), "OK");
                listar();
            }
        }
    }
}
