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
    public partial class FormSeleccionarProducto : Form, IIdiomaObserver
    {
        public FormSeleccionarProducto()
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
                    label2.Text = "Productos";
                    seleccionarBtn.Text = "Añadir al Carrito";
                    generarCarritoBtn.Text = "Ir al carrito";
                    break;
                case Idioma.English:
                    label2.Text = "Products";
                    seleccionarBtn.Text = "Add to Cart";
                    generarCarritoBtn.Text = "Go to Cart";
                    break;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void seleccionarBtn_Click(object sender, EventArgs e)
        {
           
        }
    }
}
