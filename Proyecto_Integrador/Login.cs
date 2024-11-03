using BE;
using BLL;
using Services;
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
    public partial class Login : Form, IIdiomaObserver
    {
        BLL.Usuario gestorUsuario;
        bool isClosingByMe;

        public Login()
        {
            InitializeComponent();
            gestorUsuario = new BLL.Usuario();
            this.FormClosing += LoginForm_FormClosing;
            IdiomaManager.Instance.Suscribir(this);
            ActualizarIdioma(IdiomaManager.Instance.IdiomaActual);
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isClosingByMe)
            {
                Application.Exit();
            }
        }

        private void ingeresarBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usuarioTxt.Text) || string.IsNullOrEmpty(contraTxt.Text))
            {
                CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("FaltanCamposException"), IdiomaManager.Instance.ObtenerMensaje(""), "OK");
            }
            else
            {
                string user = usuarioTxt.Text;
                string pass = contraTxt.Text;

                BE.Usuario usuario = new BE.Usuario(user, pass);

                try
                {
                    bool primerLogin = gestorUsuario.login(usuario);
                    IdiomaManager.Instance.Inicializar(SessionManager.GetInstance.Usuario);
                    if (primerLogin)
                    {
                        this.Hide();
                        Form cambiarPass = new FormCambiarPass();
                        cambiarPass.ShowDialog();
                    }
                    isClosingByMe = true;
                    this.Close();                   
                }
                catch(IntegrityException ex)
                {
                    isClosingByMe = true;
                    this.Close();
                    if (SessionManager.GetInstance.Usuario.Perfil.TienePermiso(TipoPermiso.AdminPatente))
                    {
                        Form reparacionDB = new ReparacionDB();
                        reparacionDB.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("El sistema no se encuentra disponible de momento. Contacte a un administrador para obtener mas ayuda.");
                        Application.Exit();
                    }
                }
                catch(Exception ex)
                {
                    CustomMessageBox.Show(ex.Message, IdiomaManager.Instance.ObtenerMensaje(""), "OK");
                }
            }            
        }

        private void usuarioTxt_Enter(object sender, EventArgs e)
        {
            label1.Hide();
        }

        private void usuarioTxt_Leave(object sender, EventArgs e)
        {
            if (usuarioTxt.Text == "")
            {
                label1.Show();
            }
        }

        private void contraTxt_Enter(object sender, EventArgs e)
        {
            label2.Hide();
        }

        private void contraTxt_Leave(object sender, EventArgs e)
        {
            if (usuarioTxt.Text == "")
            {
                label2.Show();
            }
        }

        public void ActualizarIdioma(Idioma nuevoIdioma)
        {
            label1.Text = IdiomaManager.Instance.ObtenerMensaje("Usuario");
            label2.Text = IdiomaManager.Instance.ObtenerMensaje("Contraseña");
            ingeresarBtn.Text = IdiomaManager.Instance.ObtenerMensaje("Ingresar");
        }
    }
}
