using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;
using BE;
using System.Reflection.Emit;

namespace Proyecto_Integrador
{
    public partial class MdiContainer : Form, IIdiomaObserver
    {

        string message;
        string ok;
        string cancel;
        string nameForm;

        public MdiContainer()
        {
            InitializeComponent();
            IdiomaManager.Instance.Suscribir(this);
            ActualizarIdioma(IdiomaManager.Instance.IdiomaActual);
        }


        private void MdiContainer_Load(object sender, EventArgs e)
        {
            InicializarAplicacion();
        }

        private void InicializarAplicacion()
        {
            this.Hide();
            Form login = new Login();
            login.ShowDialog();

            Form main = new Main();
            main.MdiParent = this;
            main.Show();
            this.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = CustomMessageBox.Show(
                                message,
                                nameForm,
                                ok,
                                cancel);

            if (result == DialogResult.OK)
            {
                foreach (Form childForm in this.MdiChildren)
                {
                    childForm.Close();
                }
                SessionManager.Logout();
                InicializarAplicacion(); 
            }
        }

        private void gestionarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form gestionarUsuarios = new FormGestionarUsuario();
            gestionarUsuarios.MdiParent = this;
            gestionarUsuarios.Show();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cambiarPass = new FormCambiarPass();
            cambiarPass.ShowDialog();
        }

        private void cambiarIdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cambiarIdioma = new FormCambiarIdioma();
            cambiarIdioma.MdiParent = this;
            cambiarIdioma.Show();
        }

        public void ActualizarIdioma(Idioma nuevoIdioma)
        {
            switch (nuevoIdioma)
            {
                case Idioma.Spanish:
                    ajustesToolStripMenuItem.Text = "Ajustes";
                    productosToolStripMenuItem.Text = "Productos";
                    clientesToolStripMenuItem.Text = "Clientes";
                    ayudaToolStripMenuItem.Text = "Ayuda";
                    adminToolStripMenuItem.Text = "Admin";
                    logoutToolStripMenuItem.Text = "Salir";
                    cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
                    cambiarIdiomaToolStripMenuItem.Text = "Cambiar Idioma";
                    seleccionarProducToolStripMenuItem.Text = "Seleccionar Producto";
                    registrarClienteToolStripMenuItem.Text = "Registrar Cliente";
                    gestionarUsuariosToolStripMenuItem.Text = "Gestionar Usuarios";
                    message = "Esta seguro que desea cerrar la sesion?";
                    nameForm = "Cerrar Sesion";
                    ok = "Aceptar";
                    cancel = "Cancelar";
                    break;

                case Idioma.English:
                    ajustesToolStripMenuItem.Text = "Settings";
                    productosToolStripMenuItem.Text = "Products";
                    clientesToolStripMenuItem.Text = "Customers";
                    ayudaToolStripMenuItem.Text = "Help";
                    adminToolStripMenuItem.Text = "Admin";
                    logoutToolStripMenuItem.Text = "Logout";
                    cambiarContraseñaToolStripMenuItem.Text = "Change Password";
                    cambiarIdiomaToolStripMenuItem.Text = "Cahnge Language";
                    seleccionarProducToolStripMenuItem.Text = "Select Product";
                    registrarClienteToolStripMenuItem.Text = "Register Client";
                    gestionarUsuariosToolStripMenuItem.Text = "Manage Users";
                    message = "Are you sure you want to leave the current session?";
                    nameForm = "Logout";
                    ok = "Accept";
                    cancel = "Cancel";
                    break;
            }
        }
    }
}
