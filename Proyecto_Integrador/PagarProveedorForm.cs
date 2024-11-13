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
    public partial class PagarProveedorForm : Form
    {
        BE.OrdenCompra ordenCompra;

        public PagarProveedorForm(BE.OrdenCompra orden)
        {
            InitializeComponent();
            InicializarDataGrid();
            this.ordenCompra = orden;
            Inicializar();
        }

        private void Inicializar()
        {
            label2.Text = ordenCompra.Id.ToString();
            proveedorLbl.Text = ordenCompra.Proveedor.Nombre;
            foreach (var producto in ordenCompra.Productos)
            {
                dataGridView2.Rows.Add(producto.Nombre, producto.Precio, producto.Stock);
            }
            precioFinalLbl.Text = ordenCompra.Total.ToString();
        }

        private void generarVentaBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = "Orden.pdf";

            string paginahtmlTexto = GenerarHtmlOrdenCompra();

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

            MessageBox.Show("Validando el pago al proveedor...");
            MessageBox.Show("Pago validado con exito.");
        }

        private void InicializarDataGrid()
        {
            dataGridView2.Columns.Clear();
            dataGridView2.Columns.Add("NombreProducto", "Nombre del Producto");
            dataGridView2.Columns.Add("PrecioUnitario", "Precio Unitario");
            dataGridView2.Columns.Add("Cantidad", "Cantidad");
        }

        public string GenerarHtmlOrdenCompra()
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

            html.Append("<h1>Orden Compra</h1>");
            html.Append($"<p><strong>Fecha:</strong> {ordenCompra.FechaEmitida.ToString("dd/MM/yyyy")}</p>");
            html.Append($"<p><strong>Proveedor:</strong> {ordenCompra.Proveedor.Nombre}</p>");
            html.Append($"<p><strong>Precio Total:</strong> ${ordenCompra.Total}</p>");

            html.Append("<h2>Productos</h2>");
            html.Append("<table>");
            html.Append("<tr><th>Producto</th><th>Cantidad</th><th>Precio Unitario</th><th>Subtotal</th></tr>");

            foreach (var item in ordenCompra.Productos)
            {
                html.Append("<tr>");
                html.Append($"<td>{item.Nombre}</td>");
                html.Append($"<td>{item.Stock}</td>");
                html.Append($"<td>${item.Precio}</td>");
                html.Append($"<td>${item.Stock * item.Precio}</td>");
                html.Append("</tr>");
            }

            html.Append("</table>");
            html.Append("</body>");
            html.Append("</html>");

            return html.ToString();
        }

        private void ayudaBtn_Click(object sender, EventArgs e)
        {
            string rutaHtml = Path.Combine(Application.StartupPath, "Ayuda", "pagar-proveedor.html");

            if (File.Exists(rutaHtml))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = rutaHtml,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("El archivo de ayuda no se encontró.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
