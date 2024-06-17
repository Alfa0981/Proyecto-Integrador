using BE;
using BLL;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Integrador
{
    public partial class FormGenerarFactura : Form, IIdiomaObserver
    {
        BLL.Carrito gestorCarrito = new BLL.Carrito();
        BE.Carrito carrito;

        public FormGenerarFactura()
        {
            InitializeComponent();
            IdiomaManager.Instance.Suscribir(this);
            ActualizarIdioma(IdiomaManager.Instance.IdiomaActual);
        }

        public void ActualizarIdioma(Idioma nuevoIdioma)
        {
            label3.Text = IdiomaManager.Instance.ObtenerMensaje("CarritoId");
            cobrarVentaBtn.Text = IdiomaManager.Instance.ObtenerMensaje("CobrarVenta");
            buscarBtn.Text = IdiomaManager.Instance.ObtenerMensaje("Buscar");
            clienteLbl.Text = IdiomaManager.Instance.ObtenerMensaje("Cliente");
        }

        private void cobrarVentaBtn_Click(object sender, EventArgs e)
        {
            if (carrito != null)
            {
                Form cobrarVenta = new FormCobrarVenta(carrito);
                cobrarVenta.MdiParent = this.MdiParent;
                cobrarVenta.Show();
            }
            else
            {
                MessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("SeleccionarCarritoException"));
            }
        }

        private void carritoIdTxt_Enter(object sender, EventArgs e)
        {
            label3.Hide();
        }

        private void carritoIdTxt_Leave(object sender, EventArgs e)
        {
            if (carritoIdTxt.Text == "")
            {
                label3.Show();
            }
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(carritoIdTxt.Text, "^[0-9]*$"))
            {
                MessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("OnlyNumbers"));
            }
            else if (string.IsNullOrEmpty(carritoIdTxt.Text))
            {
                MessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("FaltanCamposException"));
            }
            else
            {
                int carritoId = int.Parse(carritoIdTxt.Text);
                carrito = gestorCarrito.buscarPorId(carritoId);

                if (carrito == null)
                {
                    MessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("CarritoNotFound"));
                }
                else
                {
                    MostrarCarrito(carrito);
                    label1.Text = carrito.Cliente.ToString();
                }
            }
        }

        private void MostrarCarrito(BE.Carrito carrito)
        {
            dataGridView2.DataSource = carrito.Productos.Select(p => new
            {
                Producto = p.Producto.Nombre,
                p.Cantidad,
                PrecioUnitario = p.Producto.Precio,
                PrecioTotal = p.Producto.Precio * p.Cantidad
            }).ToList();
        }
    }
}
