using BE;
using BLL;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Integrador
{
    public partial class BitacoraEventos : Form
    {
        BLL.GestionEventos gestionEventos = new BLL.GestionEventos();
        BLL.Usuario gestionUsuario = new BLL.Usuario();
        List<Evento> events = new List<Evento>();

        public BitacoraEventos()
        {
            InitializeComponent();
            inicializar();
        }

        private void inicializar()
        {
            events = gestionEventos.obtenerEventos();
            listar(events.Where(e => e.Fecha >= DateTime.Now.AddDays(-3)).ToList());
            dataGridView1.Columns["Id"].Visible = false;

            userCombo.DataSource = null;
            userCombo.DataSource = gestionUsuario.mostrarTodos();
            userCombo.DisplayMember = "User";
            userCombo.SelectedIndex = -1;

            nombreTxt.Text = events[0].Usuario.Nombre;
            apellidoTxt.Text = events[0].Usuario.Apellido;

            flagFiltrarFechaCheck.Checked = false;
            fechasGroup.Visible = false;

            moduloCombo.DataSource = Enum.GetValues(typeof(Modulos));
            moduloCombo.SelectedIndex = -1;

            descripcionCombo.DataSource = null;
            descripcionCombo.DataSource = gestionEventos.obtenerDescsEventos();
            descripcionCombo.SelectedIndex = -1;

            criticidadCombo.SelectedIndex = -1;
        }

        private void listar(List<Evento> eventos)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = eventos;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BE.Evento evento = (BE.Evento)dataGridView1.CurrentRow.DataBoundItem;
            nombreTxt.Text = evento.Usuario.Nombre;
            apellidoTxt.Text = evento.Usuario.Apellido;
        }

        private void aplicarBtn_Click(object sender, EventArgs e)
        {
            string selectedUser = userCombo.Text;
            string selectedModule = moduloCombo.Text;
            string selectedEventDesc = descripcionCombo.Text;
            int? selectedCriticidad = null;
            if (int.TryParse(criticidadCombo.SelectedItem?.ToString(), out int criticidad))
            {
                selectedCriticidad = criticidad;
            }
            DateTime? fechaInicio = fechaInicioPicker.Value;
            DateTime? fechaFin = fechaFinPicker.Value;
            bool filtrarPorFecha = flagFiltrarFechaCheck.Checked;

            var eventosFiltrados = events.Where(ev =>
                (string.IsNullOrEmpty(selectedUser) || ev.Usuario.User == selectedUser) &&
                (string.IsNullOrEmpty(selectedModule) || ev.Modulo == selectedModule) &&
                (string.IsNullOrEmpty(selectedEventDesc) || ev.Descripcion == selectedEventDesc) &&
                (!selectedCriticidad.HasValue || ev.Criticidad == selectedCriticidad.Value) &&
                (!filtrarPorFecha ||
                    ((fechaInicio.HasValue && ev.Fecha >= fechaInicio.Value.Date) &&
                     (fechaFin.HasValue && ev.Fecha <= fechaFin.Value.Date)))
            ).ToList();

            listar(eventosFiltrados);
        }

        private void fechaFinPicker_ValueChanged(object sender, EventArgs e)
        {
            if (fechaFinPicker.Value < fechaInicioPicker.Value)
            {
                fechaInicioPicker.Value = fechaFinPicker.Value;
            }
        }

        private void fechaInicioPicker_ValueChanged(object sender, EventArgs e)
        {
            if (fechaInicioPicker.Value > fechaFinPicker.Value)
            {
                fechaFinPicker.Value = fechaInicioPicker.Value;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            fechasGroup.Visible = flagFiltrarFechaCheck.Checked;
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            inicializar();
        }

        private void imrimirBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog
            {
                FileName = "Eventos.pdf",
                Filter = "PDF files (*.pdf)|*.pdf",
                OverwritePrompt = true, 
                Title = "Guardar PDF"
            };
            string paginahtmlTexto = GenerarHTMLDesdeDataGridView(dataGridView1);

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                {
                    Document pdf = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdf, stream);
                    pdf.Open();

                    using (StringReader reader = new StringReader(paginahtmlTexto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdf, reader);

                    }
                    pdf.Close();
                    stream.Close();
                }
                MessageBox.Show("PDF generado y guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string GenerarHTMLDesdeDataGridView(DataGridView dataGridView)
        {
            StringBuilder html = new StringBuilder();

            html.Append("<html><body><h2>Reporte de Eventos</h2><table border='1' cellpadding='5' cellspacing='0'>");

            html.Append("<tr>");
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                html.Append($"<th>{column.HeaderText}</th>");
            }
            html.Append("</tr>");

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                html.Append("<tr>");
                foreach (DataGridViewCell cell in row.Cells)
                {
                    html.Append($"<td>{cell.Value}</td>");
                }
                html.Append("</tr>");
            }

            html.Append("</table></body></html>");

            return html.ToString();
        }

    }
}
