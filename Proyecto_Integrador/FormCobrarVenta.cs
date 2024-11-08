using BE;
using Services;
using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.xml;
using System.IO;
using iTextSharp.tool.xml;
using System.Text;

namespace Proyecto_Integrador
{
    public partial class FormCobrarVenta : Form, IIdiomaObserver
    {
        BE.Carrito carrito;
        BLL.Factura gestorFactura = new BLL.Factura();

        public FormCobrarVenta(Carrito carrito)
        {
            InitializeComponent();
            IdiomaManager.Instance.Suscribir(this);
            ActualizarIdioma(IdiomaManager.Instance.IdiomaActual);
            this.carrito = carrito;
            inicializar();
            
        }

        private void inicializar()
        {
            datostarjetaGB.Hide();
            transferenciaGB.Hide();
            datosEfectivoGB.Hide();
            precioFinalLbl.Text = carrito.PrecioFinal.ToString();
            generarVentaBtn.Hide();
            mostrarCarrito();
        }

        private void mostrarCarrito()
        {
            dataGridView2.DataSource = carrito.Productos.Select(p => new
            {
                Producto = p.Producto.Nombre,
                p.Cantidad,
                PrecioUnitario = p.Producto.Precio,
                PrecioTotal = p.Producto.Precio * p.Cantidad
            }).ToList();
        }

        public void ActualizarIdioma(Idioma nuevoIdioma)
        {
            tipoPagoGB.Text = IdiomaManager.Instance.ObtenerMensaje("TipoPago");
            efectivoRBtn.Text = IdiomaManager.Instance.ObtenerMensaje("Efectivo");
            tarjetaRBtn.Text = IdiomaManager.Instance.ObtenerMensaje("Tarjeta");
            transferenciaRBtn.Text = IdiomaManager.Instance.ObtenerMensaje("Transferencia");
            datostarjetaGB.Text = IdiomaManager.Instance.ObtenerMensaje("DatosTarjeta");
            transferenciaGB.Text = IdiomaManager.Instance.ObtenerMensaje("DatosTransferencia");
            titularLbl.Text = IdiomaManager.Instance.ObtenerMensaje("Titular");
            numTarjetaLbl.Text = IdiomaManager.Instance.ObtenerMensaje("NumeroTarjeta");
            cvvLbl.Text = IdiomaManager.Instance.ObtenerMensaje("CVV");
            fechaExpLbl.Text = IdiomaManager.Instance.ObtenerMensaje("FechaExp");
            datosEfectivoGB.Text = IdiomaManager.Instance.ObtenerMensaje("DatosEfectivo");
            montoClienteLbl.Text = IdiomaManager.Instance.ObtenerMensaje("MontoCliente");
            montoLbl.Text = IdiomaManager.Instance.ObtenerMensaje("Monto");
            generarVentaBtn.Text = IdiomaManager.Instance.ObtenerMensaje("GenerarVenta");
            this.Text = IdiomaManager.Instance.ObtenerMensaje("FormCobrarVenta");
        }

        private void FormCobrarVenta_Load(object sender, EventArgs e)
        {

        }

        private void generarVentaBtn_Click(object sender, EventArgs e)
        {
            bool ventaExitosa = false;

            if (efectivoRBtn.Checked)
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    CustomMessageBox.Show(
                               IdiomaManager.Instance.ObtenerMensaje("MontoClienteMissing"),
                               IdiomaManager.Instance.ObtenerMensaje(""),
                               "OK");
                }
                else
                {
                    if (carrito.PrecioFinal > int.Parse(textBox1.Text))
                    {
                        CustomMessageBox.Show(
                               IdiomaManager.Instance.ObtenerMensaje("MontoInsuficiente"),
                               IdiomaManager.Instance.ObtenerMensaje(""),
                               "OK");
                        return;
                    }
                   
                    CustomMessageBox.Show(
                               IdiomaManager.Instance.ObtenerMensaje("VentaCerradaPlusVuelto") + (int.Parse(textBox1.Text) - carrito.PrecioFinal),
                               IdiomaManager.Instance.ObtenerMensaje(""),
                               "OK");
                    ventaExitosa = true;
                }

            }
            else if (tarjetaRBtn.Checked)
            {
                if (string.IsNullOrWhiteSpace(titularTxt.Text) ||
                    string.IsNullOrWhiteSpace(nrmTarjetaTxt.Text) ||
                    string.IsNullOrWhiteSpace(cvvTxt.Text) ||
                    string.IsNullOrWhiteSpace(fechaExpTxt.Text))
                {
                    CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("FaltanCamposException"), IdiomaManager.Instance.ObtenerMensaje(""), "OK");
                }
                else
                {
                    if (!Regex.IsMatch(fechaExpTxt.Text, @"^(0[1-9]|1[0-2])\/([0-9]{2})$"))
                    {
                        CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("RegexFechaExpException"), IdiomaManager.Instance.ObtenerMensaje(""), "OK");
                        return;
                    }

                    string[] partes = fechaExpTxt.Text.Split('/');
                    int mes = int.Parse(partes[0]);
                    int año = int.Parse(partes[1]) + 2000;

                    DateTime fechaIngresada = new DateTime(año, mes, 1);
                    DateTime fechaActual = DateTime.Now;

                    if (fechaIngresada < new DateTime(fechaActual.Year, fechaActual.Month, 1))
                    {
                        CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("FechaExpException"), IdiomaManager.Instance.ObtenerMensaje(""), "OK");
                    }
                    else
                    {
                        CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("VentaCerrada"), IdiomaManager.Instance.ObtenerMensaje(""), "OK");
                        ventaExitosa = true;
                    }
                }

            }
            else if (transferenciaRBtn.Checked)
            {
                CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("VentaCerrada"), IdiomaManager.Instance.ObtenerMensaje(""), "OK");
                ventaExitosa = true;
            }
            if (ventaExitosa)
            {
                Factura factura = new Factura();
                factura.Carrito = carrito;
                factura.Cliente = carrito.Cliente;
                factura.Precio = carrito.PrecioFinal;
                factura.Fecha = DateTime.Now;

                gestorFactura.crear(factura);
                SaveFileDialog guardar = new SaveFileDialog();
                guardar.FileName = "Venta.pdf";

                string paginahtmlTexto = GenerarHtmlFactura(factura);

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
        }

        private void transferenciaRBtn_Click(object sender, EventArgs e)
        {
            datostarjetaGB.Hide();
            transferenciaGB.Show();
            datosEfectivoGB.Hide();
            generarVentaBtn.Show();

        }

        private void tarjetaRBtn_Click(object sender, EventArgs e)
        {
            datostarjetaGB.Show();
            transferenciaGB.Hide();
            datosEfectivoGB.Hide();
            generarVentaBtn.Show();

        }

        private void efectivoRBtn_Click(object sender, EventArgs e)
        {
            datostarjetaGB.Hide();
            transferenciaGB.Hide();
            datosEfectivoGB.Show();
            generarVentaBtn.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void titularTxt_Enter(object sender, EventArgs e)
        {
            titularLbl.Hide();
        }

        private void titularTxt_Leave(object sender, EventArgs e)
        {
            if (titularTxt.Text == "")
            {
                titularLbl.Show();
            }
        }

        private void nrmTarjetaTxt_Enter(object sender, EventArgs e)
        {
            numTarjetaLbl.Hide();
        }

        private void nrmTarjetaTxt_Leave(object sender, EventArgs e)
        {
            if (nrmTarjetaTxt.Text == "")
            {
                numTarjetaLbl.Show();
            }
        }

        private void cvvTxt_Enter(object sender, EventArgs e)
        {
            cvvLbl.Hide();
        }

        private void cvvTxt_Leave(object sender, EventArgs e)
        {
            if (cvvTxt.Text == "")
            {
                cvvLbl.Show();
            }
        }

        private void fechaExpTxt_Enter(object sender, EventArgs e)
        {
            fechaExpLbl.Hide();
        }

        private void fechaExpTxt_Leave(object sender, EventArgs e)
        {
            if (fechaExpTxt.Text == "")
            {
                fechaExpLbl.Show();
            }
        }

        private void fechaExpTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void fechaExpTxt_TextChanged(object sender, EventArgs e)
        {
            string texto = fechaExpTxt.Text;
            if (texto.Length == 2 && !texto.Contains("/"))
            {
                fechaExpTxt.Text = texto + "/";
                fechaExpTxt.SelectionStart = fechaExpTxt.Text.Length; 
            }
        }

        private void nrmTarjetaTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            montoClienteLbl.Hide();
        }

        private void textBox1_Leave_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                montoClienteLbl.Show();
            }
        }
        public string GenerarHtmlFactura(Factura factura)
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

            html.Append("<h1>Factura</h1>");
            html.Append($"<p><strong>Fecha:</strong> {factura.Fecha.ToString("dd/MM/yyyy")}</p>");
            html.Append($"<p><strong>Cliente:</strong> {factura.Cliente.Nombre + " "+ factura.Cliente.Apellido}</p>");
            html.Append($"<p><strong>Precio Total:</strong> ${factura.Precio}</p>");

            html.Append("<h2>Productos</h2>");
            html.Append("<table>");
            html.Append("<tr><th>Producto</th><th>Cantidad</th><th>Precio Unitario</th><th>Subtotal</th></tr>");

            foreach (var item in factura.Carrito.Productos)
            {
                html.Append("<tr>");
                html.Append($"<td>{item.Producto.Nombre}</td>");
                html.Append($"<td>{item.Cantidad}</td>");
                html.Append($"<td>${item.Producto.Precio}</td>");
                html.Append($"<td>${item.Cantidad * item.Producto.Precio}</td>");
                html.Append("</tr>");
            }

            html.Append("</table>");
            html.Append("</body>");
            html.Append("</html>");

            return html.ToString();
        }

        private void ayudaBtn_Click(object sender, EventArgs e)
        {
            string rutaHtml = Path.Combine(Application.StartupPath, "Ayuda", "cobrar-venta.html");

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
