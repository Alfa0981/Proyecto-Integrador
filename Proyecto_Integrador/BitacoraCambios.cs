using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Integrador
{
    public partial class BitacoraCambios : Form
    {
        BLL.BitacoraCambios gestorCambios = new BLL.BitacoraCambios();
        List<BE.BitacoraCambios> cambios = new List<BE.BitacoraCambios>();

        public BitacoraCambios()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            cambios = gestorCambios.obtenerTodos();
            listar(cambios.Where(e => e.Fecha >= DateTime.Now.AddMonths(-1)).ToList());

            flagFiltrarFechaCheck.Checked = false;
            fechasGroup.Visible = false;

            codProdTxt.Text = string.Empty;
            nombreTxt.Text = string.Empty;

        }

        private void listar(List<BE.BitacoraCambios> cambios)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = cambios;
            dataGridView1.Columns["Id"].Visible = false;
        }

        private void filtrarBtn_Click(object sender, EventArgs e)
        {
            string codProd = codProdTxt.Text;
            string nombre = nombreTxt.Text;
            DateTime? fechaInicio = fechaInicioPicker.Value;
            DateTime? fechaFin = fechaFinPicker.Value;
            bool filtrarPorFecha = flagFiltrarFechaCheck.Checked;

            var cambiosFiltrados = cambios.Where(ca =>
                (string.IsNullOrEmpty(nombre) || ca.Nombre == nombre) &&
                (string.IsNullOrEmpty(codProd) || ca.Producto.Id.ToString() == codProd) &&
                (!filtrarPorFecha ||
                    ((fechaInicio.HasValue && ca.Fecha >= fechaInicio.Value.Date) &&
                     (fechaFin.HasValue && ca.Fecha <= fechaFin.Value.Date)))
            ).ToList();

            listar(cambiosFiltrados);
        }

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void codProdTxt_Enter(object sender, EventArgs e)
        {
            codProdLbl.Hide();
        }

        private void codProdTxt_Leave(object sender, EventArgs e)
        {
            if (codProdTxt.Text == "")
            {
                codProdLbl.Show();
            }
        }

        private void nombreTxt_Enter(object sender, EventArgs e)
        {
            nombreLbl.Hide();
        }

        private void nombreTxt_Leave(object sender, EventArgs e)
        {
            if (nombreTxt.Text == "")
            {
                nombreLbl.Show();
            }
        }

        private void flagFiltrarFechaCheck_CheckedChanged(object sender, EventArgs e)
        {
            fechasGroup.Visible = flagFiltrarFechaCheck.Checked;
        }

        private void fechaInicioPicker_ValueChanged(object sender, EventArgs e)
        {
            if (fechaInicioPicker.Value > fechaFinPicker.Value)
            {
                fechaFinPicker.Value = fechaInicioPicker.Value;
            }
        }

        private void fechaFinPicker_ValueChanged(object sender, EventArgs e)
        {
            if (fechaFinPicker.Value < fechaInicioPicker.Value)
            {
                fechaInicioPicker.Value = fechaFinPicker.Value;
            }
        }

        private void activarBtn_Click(object sender, EventArgs e)
        {
            BE.BitacoraCambios cambio = (BE.BitacoraCambios)dataGridView1.CurrentRow.DataBoundItem;
            cambio.Producto.Stock = cambio.Stock;
            if (cambio.Activo)
            {
                MessageBox.Show("No es posible activar un producto ya activo");
                return;
            }
            gestorCambios.modificarProducto(cambio);
            Inicializar();
        }
    }
}
