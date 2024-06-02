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
    public partial class FormGenerarFactura : Form, IIdiomaObserver
    {
        public FormGenerarFactura()
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
                    carritoIdTxt.Text = "Carrito Id";
                    cobrarVentaBtn.Text = "Cobrar Venta";
                    
                    break;
                case Idioma.English:
                    carritoIdTxt.Text = "Cart Id";
                    cobrarVentaBtn.Text = "Pay Sale";
                    
                    break;
            }
        }

        private void cobrarVentaBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
