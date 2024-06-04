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
        }

        public void ActualizarIdioma(Idioma nuevoIdioma)
        {
            switch (nuevoIdioma)
            {
                case Idioma.Spanish:
                    label2.Text = "Productos";
                    seleccionarBtn.Text = "Añadir al Carrito";
                    generarCarritoBtn.Text = "Ir al carrito";
                    cantLbl.Text = "Cantidad";
                    break;
                case Idioma.English:
                    label2.Text = "Products";
                    seleccionarBtn.Text = "Add to Cart";
                    generarCarritoBtn.Text = "Go to Cart";
                    cantLbl.Text = "Amount";
                    break;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void seleccionarBtn_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                BE.Producto producto = (BE.Producto)dataGridView1.CurrentRow.DataBoundItem;
                int cantidad = (int)cantNumeric.Value;
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
                MessageBox.Show("Debe seleccionar un producto primero");
            }
            //TODO 4 una vez apretado el boton "ir al carrito" desplegar form con todos los productos + cant y precio final
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
        }

        private void generarCarritoBtn_Click(object sender, EventArgs e)
        {
            Form generarCarrito = new FormGenerarCarrito(productosEnCarrito);
            generarCarrito.MdiParent = this.MdiParent;
            generarCarrito.Show();
        }
    }
}
