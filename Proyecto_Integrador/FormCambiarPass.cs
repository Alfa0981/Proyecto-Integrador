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
    public partial class FormCambiarPass : Form, IIdiomaObserver
    {

        Usuario gestorUsuario = new Usuario();
        bool isClosingByMe;

        public FormCambiarPass()
        {
            InitializeComponent();
            this.FormClosing += FormCambiarPass_FormClosing1;
            IdiomaManager.Instance.Suscribir(this);
            ActualizarIdioma(IdiomaManager.Instance.IdiomaActual);
        }

        private void FormCambiarPass_FormClosing1(object sender, FormClosingEventArgs e)
        {
            if (!isClosingByMe)
            {
               
                CustomMessageBox.Show(
                               IdiomaManager.Instance.ObtenerMensaje("FormNotClosable"),
                               IdiomaManager.Instance.ObtenerMensaje(""),
                               "OK");

                e.Cancel = true;
                isClosingByMe = false;
            } 
        }

        private void cambiarBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(contraTxt.Text) || string.IsNullOrEmpty(contraX2Txt.Text)) 
            {
                CustomMessageBox.Show(
                               IdiomaManager.Instance.ObtenerMensaje("FaltanCamposException"),
                               IdiomaManager.Instance.ObtenerMensaje(""),
                               "OK");
            }
            else if(contraTxt.Text != contraX2Txt.Text)
            {
                CustomMessageBox.Show(
                               IdiomaManager.Instance.ObtenerMensaje("ClavesDistintasException"),
                               IdiomaManager.Instance.ObtenerMensaje(""),
                               "OK");
            }
            else 
            {
                gestorUsuario.cambiarContra(SessionManager.GetInstance.Usuario, contraTxt.Text);
                isClosingByMe = true;
                this.Close();
            }
        }

        private void contraTxt_Enter(object sender, EventArgs e)
        {
            label1.Hide();
        }

        private void contraTxt_Leave(object sender, EventArgs e)
        {
            if (contraTxt.Text == "")
            {
                label1.Show();
            }
        }

        private void contraX2Txt_Enter(object sender, EventArgs e)
        {
            label2.Hide();
        }

        private void contraX2Txt_Leave(object sender, EventArgs e)
        {
            if (contraX2Txt.Text == "")
            {
                label2.Show();
            }
        }

        public void ActualizarIdioma(BE.Idioma nuevoIdioma)
        {
            label1.Text = IdiomaManager.Instance.ObtenerMensaje("Contraseña");
            label2.Text = IdiomaManager.Instance.ObtenerMensaje("RepitaContraseña");
            cambiarBtn.Text = IdiomaManager.Instance.ObtenerMensaje("Cambiar");
        }
    }
}
