﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using Services;

namespace Proyecto_Integrador
{
    public partial class FormCambiarIdioma : Form, IIdiomaObserver
    {
        BLL.Usuario gestorUsuario = new BLL.Usuario();

        public FormCambiarIdioma()
        {
            InitializeComponent();
            IdiomaManager.Instance.Suscribir(this);
            ActualizarIdioma(IdiomaManager.Instance.IdiomaActual);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormCambiarIdioma_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(Idioma));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var idiomaNuevo = (Idioma)comboBox1.SelectedValue;
            IdiomaManager.Instance.IdiomaActual = idiomaNuevo;
            gestorUsuario.cambiarIdioma(SessionManager.GetInstance.Usuario, idiomaNuevo);
        }

        public void ActualizarIdioma(Idioma nuevoIdioma)
        {
            cambiarBtn.Text = IdiomaManager.Instance.ObtenerMensaje("Cambiar");
            label1.Text = IdiomaManager.Instance.ObtenerMensaje("ElegirIdioma");
            this.Text = IdiomaManager.Instance.ObtenerMensaje("FormCambiarIdioma");
        }
    }
}
