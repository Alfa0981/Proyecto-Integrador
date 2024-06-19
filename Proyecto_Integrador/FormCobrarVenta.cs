using BE;
using Services;
using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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
            titularLbl.Text = IdiomaManager.Instance.ObtenerMensaje("Titular");
            numTarjetaLbl.Text = IdiomaManager.Instance.ObtenerMensaje("NumeroTarjeta");
            cvvLbl.Text = IdiomaManager.Instance.ObtenerMensaje("CVV");
            fechaExpLbl.Text = IdiomaManager.Instance.ObtenerMensaje("FechaExp");
            datosEfectivoGB.Text = IdiomaManager.Instance.ObtenerMensaje("DatosEfectivo");
            montoClienteLbl.Text = IdiomaManager.Instance.ObtenerMensaje("MontoCliente");
            montoLbl.Text = IdiomaManager.Instance.ObtenerMensaje("Monto");
            generarVentaBtn.Text = IdiomaManager.Instance.ObtenerMensaje("GenerarVenta");
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
            }
        }

        private void transferenciaRBtn_Click(object sender, EventArgs e)
        {
            datostarjetaGB.Hide();
            datosEfectivoGB.Hide();
            generarVentaBtn.Show();

        }

        private void tarjetaRBtn_Click(object sender, EventArgs e)
        {
            datostarjetaGB.Show();
            datosEfectivoGB.Hide();
            generarVentaBtn.Show();

        }

        private void efectivoRBtn_Click(object sender, EventArgs e)
        {
            datostarjetaGB.Hide();
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
    }
}
