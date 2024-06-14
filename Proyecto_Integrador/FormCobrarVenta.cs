using BE;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Integrador
{
    public partial class FormCobrarVenta : Form, IIdiomaObserver
    {
        BE.Carrito carrito;

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
            switch (nuevoIdioma)
            {
                case Idioma.Spanish:
                    tipoPagoGB.Text = "Tipo de Pago";
                    efectivoRBtn.Text = "Efectivo";
                    tarjetaRBtn.Text = "Tarjeta";
                    transferenciaRBtn.Text = "Transferencia";
                    datostarjetaGB.Text = "Datos de Tarjeta";
                    titularLbl.Text = "Titular";
                    numTarjetaLbl.Text = "Numero de Tarjeta";
                    cvvLbl.Text = "CVV";
                    fechaExpLbl.Text = "Fecha de Expiracion";
                    datosEfectivoGB.Text = "Datos Efectivo";
                    montoClienteLbl.Text = "Monto del cliente";
                    montoLbl.Text = "Monto: ";
                    generarVentaBtn.Text = "Generar Venta";
                    break;

                case Idioma.English:
                    tipoPagoGB.Text = "Payment Type";
                    efectivoRBtn.Text = "Cash";
                    tarjetaRBtn.Text = "Card";
                    transferenciaRBtn.Text = "Transfer";
                    datostarjetaGB.Text = "Card Details";
                    titularLbl.Text = "Owner";
                    numTarjetaLbl.Text = "Card Number";
                    cvvLbl.Text = "CVV";
                    fechaExpLbl.Text = "Expiration Date";
                    datosEfectivoGB.Text = "Cash Details";
                    montoClienteLbl.Text = "Customer Amount";
                    montoLbl.Text = "Amount: ";
                    generarVentaBtn.Text = "Generarate Sell";
                    break;
            }
        }

        private void FormCobrarVenta_Load(object sender, EventArgs e)
        {

        }

        private void generarVentaBtn_Click(object sender, EventArgs e)
        {
            if (efectivoRBtn.Checked)
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Por favor, complete el monto del cliente.");
                }
                else
                {
                    if (carrito.PrecioFinal > int.Parse(textBox1.Text))
                    {
                        MessageBox.Show("El monto no es suficiente");
                        return;
                    }
                    MessageBox.Show("Venta cerrada, el vuelto es de: " + (int.Parse(textBox1.Text)- carrito.PrecioFinal));
                }

            }
            else if (tarjetaRBtn.Checked)
            {
                if (string.IsNullOrWhiteSpace(titularTxt.Text) ||
                    string.IsNullOrWhiteSpace(nrmTarjetaTxt.Text) ||
                    string.IsNullOrWhiteSpace(cvvTxt.Text) ||
                    string.IsNullOrWhiteSpace(fechaExpTxt.Text))
                {
                    MessageBox.Show("Por favor, complete todos los datos de la tarjeta.");
                }
                else
                {
                    if (!Regex.IsMatch(fechaExpTxt.Text, @"^(0[1-9]|1[0-2])\/([0-9]{2})$"))
                    {
                        MessageBox.Show("Fecha de expiración inválida. Use el formato MM/AA.");
                        return;
                    }

                    string[] partes = fechaExpTxt.Text.Split('/');
                    int mes = int.Parse(partes[0]);
                    int año = int.Parse(partes[1]) + 2000;

                    DateTime fechaIngresada = new DateTime(año, mes, 1);
                    DateTime fechaActual = DateTime.Now;

                    if (fechaIngresada < new DateTime(fechaActual.Year, fechaActual.Month, 1))
                    {
                        MessageBox.Show("La fecha de expiración no puede ser anterior al mes y año actuales.");
                    }
                    else
                    {
                        MessageBox.Show("Venta cerrada");
                    }
                }

            }
            else if (transferenciaRBtn.Checked)
            {
                MessageBox.Show("Venta cerrada");
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
