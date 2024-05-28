﻿using BLL;
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
    public partial class FormCambiarPass : Form
    {

        Usuario gestorUsuario = new Usuario();
        bool isClosingByMe;

        public FormCambiarPass()
        {
            InitializeComponent();
            this.FormClosing += FormCambiarPass_FormClosing1;
        }

        private void FormCambiarPass_FormClosing1(object sender, FormClosingEventArgs e)
        {
            if (!isClosingByMe)
            {
                MessageBox.Show("No puede cerrar el formulario durante esta operacion",
                "Cerrar", MessageBoxButtons.OK, MessageBoxIcon.Question);

                e.Cancel = true;
                isClosingByMe = false;
            } 
        }

        private void cambiarBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(contraTxt.Text) || string.IsNullOrEmpty(contraX2Txt.Text)) 
            {
                MessageBox.Show("Faltan completar campos");
            }else if(contraTxt.Text != contraX2Txt.Text)
            {
                MessageBox.Show("Las claves son distintas");
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
    }
}
