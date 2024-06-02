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
        string messageBox;
        string nameForm;
        string camposException;
        string clavesException;

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
                               messageBox,
                               nameForm,
                               "OK");

                e.Cancel = true;
                isClosingByMe = false;
            } 
        }

        private void cambiarBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(contraTxt.Text) || string.IsNullOrEmpty(contraX2Txt.Text)) 
            {
                MessageBox.Show(camposException);
            }else if(contraTxt.Text != contraX2Txt.Text)
            {
                MessageBox.Show(clavesException);
            }else 
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
            switch (nuevoIdioma)
            {
                case BE.Idioma.Spanish:
                    label1.Text = "Contraseña";
                    label2.Text = "Repita Contraseña";
                    cambiarBtn.Text = "Cambiar";
                    camposException = "Faltan completar campos";
                    messageBox = "No puede cerrar el formulario durante esta operacion";
                    nameForm = "Cerrar";
                    clavesException = "Las claves son distintas";
                    break;
                case BE.Idioma.English:
                    label1.Text = "Password";
                    label2.Text = "Repeat Password";
                    cambiarBtn.Text = "Change";
                    camposException = "There are missing fields";
                    messageBox = "It is impossible to close the form during this operation";
                    nameForm = "Close";
                    clavesException = "The passwords are different";
                    break;
            }
        }
    }
}
