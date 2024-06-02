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
    public partial class FormCambiarIdioma : Form
    {
        BLL.Usuario gestorUsuario = new BLL.Usuario();

        public FormCambiarIdioma()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var idiomaNuevo = (Idioma)comboBox1.SelectedValue;
            IdiomaManager.Instance.IdiomaActual = idiomaNuevo;
            gestorUsuario.cambiarIdioma(SessionManager.GetInstance.Usuario, idiomaNuevo);
        }

        private void FormCambiarIdioma_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(Idioma));
        }
    }
}
