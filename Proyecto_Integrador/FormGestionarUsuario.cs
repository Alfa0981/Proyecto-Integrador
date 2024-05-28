using System;
using BE;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;

namespace Proyecto_Integrador
{
    public partial class FormGestionarUsuario : Form
    {

        BLL.Usuario gestorUsuario = new BLL.Usuario();
        Usuario usuario;

        public FormGestionarUsuario()
        {
            InitializeComponent();
        }

        private void cargarBtn_Click(object sender, EventArgs e)
        {
            if (validarInputs())
            {
                Usuario usuario = new Usuario();
                usuario.Nombre = nombreTxt.Text;
                usuario.Apellido = apellidoTxt.Text;
                usuario.Rol = (Rol)rolCmb.SelectedItem;
                usuario.Email = emailTxt.Text;
                usuario.Dni = dniTxt.Text;
                usuario.User = usuario.Nombre + usuario.Apellido;
                usuario.Pass = usuario.Dni + usuario.Apellido;

                gestorUsuario.cargarUsuario(usuario);
                listar();
                MessageBox.Show("Carga con exito.");

            }
        }

        private bool validarInputs()
        {
            if (string.IsNullOrWhiteSpace(nombreTxt.Text))
            {
                MessageBox.Show("El campo Nombre no puede estar vacío.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(apellidoTxt.Text))
            {
                MessageBox.Show("El campo Nombre no puede estar vacío.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(dniTxt.Text))
            {
                MessageBox.Show("El campo Nombre no puede estar vacío.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(emailTxt.Text))
            {
                MessageBox.Show("El campo Nombre no puede estar vacío.");
                return false;
            }

            return true;

        }

        private void FormGestionarUsuario_Load(object sender, EventArgs e)
        {

            modificarBtn.Hide();
            eliminarBtn.Hide();
            desbloquearBtn.Hide();
            listar();
            listarRoles();
            
        }

        private void listarRoles()
        {
            
            rolCmb.DataSource = gestorUsuario.mostrarTodosRoles();
        }

        private void listar()
        {
            var usuarios = gestorUsuario.mostrarTodos();
            dataGridView1.DataSource = usuarios;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Pass"].Visible = false;
            dataGridView1.Columns["User"].Visible = false;
            dataGridView1.Columns["Activo"].Visible = false;
        }

        private void desbloquearBtn_Click(object sender, EventArgs e)
        {
            if (usuario.Bloqueo)
            {
                gestorUsuario.desbloquearUsuario(usuario);
                listar();
                MessageBox.Show("Desbloqueado con exito.");
            }
            else
                MessageBox.Show("El usuario ya se encuentra desbloqueado");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            usuario = (Usuario)dataGridView1.CurrentRow.DataBoundItem;
            nombreLbl.Hide();
            apellidoLbl.Hide();
            dniLbl.Hide();  
            emailLbl.Hide();


            nombreTxt.Text = usuario.Nombre;
            apellidoTxt.Text = usuario.Apellido;
            dniTxt.Text = usuario.Dni;
            emailTxt.Text = usuario.Email;

            if (usuario.Bloqueo)
                desbloquearBtn.Visible = true;
            else
                desbloquearBtn.Visible = false;
            modificarBtn.Visible = true;
            eliminarBtn.Visible = true;
        }

        private void nombreTxt_Enter(object sender, EventArgs e)
        {
            nombreLbl.Hide();
        }

        private void nombreTxt_Leave(object sender, EventArgs e)
        {
            if (nombreTxt.Text == "")
            {
                nombreLbl.Show();
            }
        }

        private void apellidoTxt_Enter(object sender, EventArgs e)
        {
            apellidoLbl.Hide();
        }

        private void apellidoTxt_Leave(object sender, EventArgs e)
        {
            if (apellidoTxt.Text == "")
            {
                apellidoLbl.Show();
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

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            gestorUsuario.eliminar(usuario);
            listar();
            MessageBox.Show("Eliminado con exito.");
        }
    }
}
