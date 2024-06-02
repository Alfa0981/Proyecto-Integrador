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
            switch (nuevoIdioma)
            {
                case Idioma.Spanish:
                    label2.Text = "Comienza navegando por las opciones del menú para acceder a las funcionalidades que necesites, como registrar pedidos, gestionar inventario o generar informes. Si tienes alguna pregunta o necesitas ayuda, no dudes en contactar con el equipo de soporte.";
                    label1.Text = "Bienvenido!";
                    break;

                case Idioma.English:
                    label2.Text = "Start by browsing the menu options to access the features you need, such as registering orders, managing inventory or generating reports. If you have any questions or need help, do not hesitate to contact the support team.";
                    label1.Text = "Welcome!";
                    break;
            }
        }
    }
}
