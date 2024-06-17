using System;
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
    public partial class Main : Form, IIdiomaObserver
    {
        public Main()
        {
            InitializeComponent();
            IdiomaManager.Instance.Suscribir(this);
            ActualizarIdioma(IdiomaManager.Instance.IdiomaActual);
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void ActualizarIdioma(Idioma nuevoIdioma)
        {
            label2.Text = IdiomaManager.Instance.ObtenerMensaje("MainMessage");
            label1.Text = IdiomaManager.Instance.ObtenerMensaje("Bienvenido");
        }
    }
}
