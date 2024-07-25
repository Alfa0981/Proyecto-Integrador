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
            cobrarVentaBtn.Enabled = false;
            if (SessionManager.GetInstance.Usuario.Perfil.TienePermiso(TipoPermiso.CRUDVentas) ||
                SessionManager.GetInstance.Usuario.Perfil.TienePermiso(TipoPermiso.AdminPatente))
                cobrarVentaBtn.Enabled = true;
        }

        public void ActualizarIdioma(Idioma nuevoIdioma)
        {
            label3.Text = IdiomaManager.Instance.ObtenerMensaje("CarritoId");
            cobrarVentaBtn.Text = IdiomaManager.Instance.ObtenerMensaje("CobrarVenta");
            buscarBtn.Text = IdiomaManager.Instance.ObtenerMensaje("Buscar");
            clienteLbl.Text = IdiomaManager.Instance.ObtenerMensaje("Cliente");
            this.Text = IdiomaManager.Instance.ObtenerMensaje("FormGenerarFactura");
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
                CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("SeleccionarCarritoException"), IdiomaManager.Instance.ObtenerMensaje(""), "OK");

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
                CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("OnlyNumbers"), IdiomaManager.Instance.ObtenerMensaje(""), "OK");
            }
            else if (string.IsNullOrEmpty(carritoIdTxt.Text))
            {
                CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("FaltanCamposException"), IdiomaManager.Instance.ObtenerMensaje(""), "OK");
            }
            else
            {
                int carritoId = int.Parse(carritoIdTxt.Text);
                carrito = gestorCarrito.buscarPorId(carritoId);

                if (carrito == null)
                {
                    CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("CarritoNotFound"), IdiomaManager.Instance.ObtenerMensaje(""), "OK");
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
