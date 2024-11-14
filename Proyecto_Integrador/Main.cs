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
using BE;
using BLL;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using Services;

namespace Proyecto_Integrador
{
    public partial class Main : Form, IIdiomaObserver
    {
        BLL.Reportes reportes = new BLL.Reportes();

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

        private void reporteBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = "Reporte.pdf";

            var reporte = reportes.ObtenerReporte();

            string paginahtmlTexto = GenerarHtmlReporte(reporte);

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
            }
        }

        public string GenerarHtmlReporte(Dictionary<BE.Cliente, BE.Producto> reporte)
        {
            StringBuilder html = new StringBuilder();

            html.Append("<html>");
            html.Append("<head>");
            html.Append("<style>");
            html.Append("table { width: 100%; border-collapse: collapse; }");
            html.Append("th, td { padding: 8px; text-align: left; border-bottom: 1px solid #ddd; }");
            html.Append("th { background-color: #f2f2f2; }");
            html.Append("</style>");
            html.Append("</head>");
            html.Append("<body>");

            html.Append("<h1>Reporte de Clientes VIP y Productos Frecuentes</h1>");
            html.Append("<p>En el análisis de los datos de consumo del último mes, se encontró que los siguientes clientes realizaron un gasto superior al promedio. </p>");
            html.Append("<p>Además, se identificó que consumieron ciertos productos de manera más frecuente. Se recomienda ofrecerles un descuento en su próxima compra para incentivarlos a volver.</p>");

            html.Append("<h2>Clientes y sus Productos Más Frecuentes</h2>");
            html.Append("<table>");
            html.Append("<tr><th>Cliente</th><th>Producto Frecuente</th></tr>");

            foreach (var entry in reporte)
            {
                var cliente = entry.Key;
                var producto = entry.Value;

                html.Append("<tr>");
                html.Append($"<td>{cliente.Nombre} {cliente.Apellido} ID: {cliente.Id}</td>");
                html.Append($"<td>{producto.Nombre} ID: {producto.Id}</td>");
                html.Append("</tr>");
            }

            html.Append("</table>");
            html.Append("</body>");
            html.Append("</html>");

            return html.ToString();
        }

    }
}
