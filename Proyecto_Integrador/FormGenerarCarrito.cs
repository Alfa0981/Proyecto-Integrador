using BE;
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
    public partial class FormGenerarCarrito : Form, IIdiomaObserver
    {
        public FormGenerarCarrito()
        {
            InitializeComponent();
            IdiomaManager.Instance.Suscribir(this);
            ActualizarIdioma(IdiomaManager.Instance.IdiomaActual);
        }

        public void ActualizarIdioma(Idioma nuevoIdioma)
        {
            switch (nuevoIdioma)
            {
                case Idioma.Spanish:
                    resumenLbl.Text = "Resumen";
                    label1.Text = "Total a Pagar:";
                    registarClienteBtn.Text = "Registrar Cliente";
                    generarCarritoBtn.Text = "Generar Carrito";
                    break;
                case Idioma.English:
                    resumenLbl.Text = "Summary";
                    label1.Text = "Total to pay:";
                    registarClienteBtn.Text = "Register Cliente";
                    generarCarritoBtn.Text = "Generate Cart";
                    break;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void registarClienteBtn_Click(object sender, EventArgs e)
        {

        }

        private void generarCarritoBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
