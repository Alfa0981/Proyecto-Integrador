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
            switch (nuevoIdioma)
            {
                case Idioma.Spanish:
                    label3.Text = "Carrito Id";
                    cobrarVentaBtn.Text = "Cobrar Venta";
                    buscarBtn.Text = "Buscar";
                    clienteLbl.Text = "Cliente: ";
                    break;
                case Idioma.English:
                    label3.Text = "Cart Id";
                    cobrarVentaBtn.Text = "Pay Sale";
                    buscarBtn.Text = "Find";
                    clienteLbl.Text = "Client: ";

                    break;
            }
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
                MessageBox.Show("Debe seleccionar un carrito");
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
                MessageBox.Show("Solo se admiten numeros");
            }
            else if (string.IsNullOrEmpty(carritoIdTxt.Text))
            {
                MessageBox.Show("Campo vacios");
            }
            else
            {
                int carritoId = int.Parse(carritoIdTxt.Text);
                carrito = gestorCarrito.buscarPorId(carritoId);

                if (carrito == null)
                {
                    MessageBox.Show("Carrito no encontrado");
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
