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

namespace Proyecto_Integrador
{
    public partial class MdiContainer : Form
    {
        public MdiContainer()
        {
            InitializeComponent();
        }

        private void MdiContainer_Load(object sender, EventArgs e)
        {
            this.Hide();
            Form login = new Login();
            login.ShowDialog();
            Form main = new Main();
            main.MdiParent = this;
            main.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea cerrar la sesion?",
                "Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                SessionManager.Logout();
                Form loginForm = new Login();
                loginForm.ShowDialog();
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

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form login = new Login();
            login.ShowDialog();
        }
    }
}
