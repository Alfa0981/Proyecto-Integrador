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
    public partial class FormSeleccionarProducto : Form, IIdiomaObserver
    {

        BLL.Producto gestorProducto = new BLL.Producto();
        List<CarritoProducto> productosEnCarrito;
        bool flag = false;

        public FormSeleccionarProducto()
        {
            InitializeComponent();
            productosEnCarrito = new List<CarritoProducto>();
            IdiomaManager.Instance.Suscribir(this);
            ActualizarIdioma(IdiomaManager.Instance.IdiomaActual);
            seleccionarBtn.Hide();
            generarCarritoBtn.Hide();
        }

        public void ActualizarIdioma(Idioma nuevoIdioma)
        {
            label2.Text = IdiomaManager.Instance.ObtenerMensaje("Productos");
            seleccionarBtn.Text = IdiomaManager.Instance.ObtenerMensaje("AñadirCarrito");
            generarCarritoBtn.Text = IdiomaManager.Instance.ObtenerMensaje("IrCarrito");
            cantLbl.Text = IdiomaManager.Instance.ObtenerMensaje("Cantidad");
        }

        private void seleccionarBtn_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                BE.Producto producto = (BE.Producto)dataGridView1.CurrentRow.DataBoundItem;
                int cantidad = (int)cantNumeric.Value;

                if (producto.Stock >= cantidad)
                {
                    var itemExistente = productosEnCarrito.FirstOrDefault(p => p.Producto.Id == producto.Id);

                    if (itemExistente != null)
                    {
                        itemExistente.Cantidad += cantidad;
                    }
                    else
                    {
                        CarritoProducto nuevoItem = new CarritoProducto
                        {
                            Producto = producto,
                            Cantidad = cantidad
                        };
                        productosEnCarrito.Add(nuevoItem);
                    }
                }
                else
                {
                    MessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("StockException"));
                }
            }
            else
            {
                MessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("SelectAProductException"));
            }
        }

        private void FormSeleccionarProducto_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void listar()
        {
            dataGridView1.DataSource = gestorProducto.mostrarTodos();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            flag = true;
            seleccionarBtn.Show();
            generarCarritoBtn.Show();
        }

        private void generarCarritoBtn_Click(object sender, EventArgs e)
        {
            Form generarCarrito = new FormGenerarCarrito(productosEnCarrito);
            generarCarrito.MdiParent = this.MdiParent;
            generarCarrito.Show();
        }
    }
}
