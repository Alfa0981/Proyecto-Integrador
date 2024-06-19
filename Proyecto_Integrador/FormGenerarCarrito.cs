using BE;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Integrador
{
    public partial class FormGenerarCarrito : Form, IIdiomaObserver
    {
        private List<CarritoProducto> productosEnCarrito;
        private BLL.Carrito gestorCarrito = new BLL.Carrito();
        private BLL.Cliente gestorCliente = new BLL.Cliente();
        private BLL.Producto gestorProducto = new BLL.Producto();
        private Cliente cliente;

        public FormGenerarCarrito(List<CarritoProducto> productosEnCarrito)
        {
            InitializeComponent();
            IdiomaManager.Instance.Suscribir(this);
            ActualizarIdioma(IdiomaManager.Instance.IdiomaActual);
            this.productosEnCarrito = productosEnCarrito;
            CargarCarrito();
        }

        private void CargarCarrito()
        {
            dataGridView2.DataSource = productosEnCarrito.Select(p => new
            {
                p.Producto.Id,
                Producto = p.Producto.Nombre,
                p.Cantidad,
                PrecioUnitario = p.Producto.Precio,
                PrecioTotal = p.Producto.Precio * p.Cantidad
            }).ToList();

            dataGridView2.Columns["Id"].Visible = false;

            precioFinalLbl.Text = $"${CalcularTotalCarrito():0.00}";
        }

        public void ActualizarIdioma(Idioma nuevoIdioma)
        {
            resumenLbl.Text = IdiomaManager.Instance.ObtenerMensaje("Resumen");
            label1.Text = IdiomaManager.Instance.ObtenerMensaje("TotalPagar");
            registarClienteBtn.Text = IdiomaManager.Instance.ObtenerMensaje("RegistrarCliente");
            generarCarritoBtn.Text = IdiomaManager.Instance.ObtenerMensaje("GenerarCarrito");
            asociarCliente.Text = IdiomaManager.Instance.ObtenerMensaje("AsociarCliente");
            button1.Text = IdiomaManager.Instance.ObtenerMensaje("EliminarProducto");

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void registarClienteBtn_Click(object sender, EventArgs e)
        {
            Form registrarCliente = new FormRegistrarCliente();
            registrarCliente.MdiParent = this.MdiParent;
            registrarCliente.Show();
        }

        private void generarCarritoBtn_Click(object sender, EventArgs e)
        {
            if (!productosEnCarrito.Any())
            {
                CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("CarritoVacioException"), IdiomaManager.Instance.ObtenerMensaje(""), "OK");   
            }else if (cliente == null)
            {
                CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("ClienteAsociadoException"), IdiomaManager.Instance.ObtenerMensaje(""), "OK");
            }
            else
            {
                Carrito carrito = new Carrito();
                carrito.Productos = productosEnCarrito;
                carrito.Cliente = cliente;
                string precioFinalTexto = precioFinalLbl.Text.Replace("$", "");
                carrito.PrecioFinal = double.Parse(precioFinalTexto);

                try
                {
                    int carritoId = gestorCarrito.crearCarrito(carrito);

                    gestorProducto.ActualizarStock(carrito);

                    CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("CarritoCreado") + " " + carritoId, IdiomaManager.Instance.ObtenerMensaje(""), "OK");
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("CarritoError") + " " + ex.Message, IdiomaManager.Instance.ObtenerMensaje(""), "OK");
                }
            }             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView2.SelectedRows[0].Index;

                int productoId = (int)dataGridView2.SelectedRows[0].Cells["Id"].Value;

                var productoAEliminar = productosEnCarrito.FirstOrDefault(p => p.Producto.Id == productoId);
                if (productoAEliminar != null)
                {
                    productosEnCarrito.Remove(productoAEliminar);
                }

                CargarCarrito();

                CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("ProductoEliminado"), IdiomaManager.Instance.ObtenerMensaje(""), "OK");
            }
            else
            {
                CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("SeleccionFilaEliminar"), IdiomaManager.Instance.ObtenerMensaje(""), "OK");
            }
        }
        private double CalcularTotalCarrito()
        {
            return productosEnCarrito.Sum(p => p.Producto.Precio * p.Cantidad);
        }

        private void asociarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(clienteIdTxt.Text))
            {
                CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("FaltanCamposException"), IdiomaManager.Instance.ObtenerMensaje(""), "OK");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(clienteIdTxt.Text, "^[0-9]*$"))
            {
                CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("OnlyNumbers"), IdiomaManager.Instance.ObtenerMensaje(""), "OK");
            }
            else if (!productosEnCarrito.Any())
            {
                CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("CarritoVacioException"), IdiomaManager.Instance.ObtenerMensaje(""), "OK");
            }
            else
            {
                try
                {
                    cliente = gestorCliente.buscarPorId(int.Parse(clienteIdTxt.Text));
                    CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("ClienteAsociadoOK"), IdiomaManager.Instance.ObtenerMensaje(""), "OK");
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(ex.Message, IdiomaManager.Instance.ObtenerMensaje(""), "OK");
                }
            }
        }

        private void carritoIdTxt_Enter(object sender, EventArgs e)
        {
            clienteIdLbl.Hide();
        }

        private void carritoIdTxt_Leave(object sender, EventArgs e)
        {
            if (clienteIdTxt.Text == "")
            {
                clienteIdLbl.Show();
            }
        }
    }
}
