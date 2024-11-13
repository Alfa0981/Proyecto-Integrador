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
    public partial class ReponerStockForm : Form
    {
        BLL.OrdenCompra gestorOrdenCompra = new BLL.OrdenCompra();
        BLL.ProductoReposicion gestorProductoReposicion = new BLL.ProductoReposicion();
        BLL.Producto gestorProducto = new BLL.Producto();
        List<BE.ProductoReposicion> productosReposicion = new List<BE.ProductoReposicion>();
        List<BE.Producto> productosLista = new List<BE.Producto>();
        BE.OrdenCompra ordenCompra;

        public ReponerStockForm()
        {
            InitializeComponent();
            InicializarOrdenProductos();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buscsarBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(ordenCompraTxt.Text, out int idOrdenCompra))
            {
                refrescarDataGrids();
                ordenCompra = gestorOrdenCompra.buscarPorId(idOrdenCompra);

                if (ordenCompra == null)
                {
                    MessageBox.Show("No existe una orden asociada a ese id");
                    return;
                }
                if (ordenCompra.FechaRecibido != null)
                {
                    MessageBox.Show("La orden de compra ya fue marcada como recibida");
                    return;
                }
                foreach (var producto in ordenCompra.Productos)
                {
                    productosDataGrid.Rows.Add(producto.Nombre, producto.Stock, producto.Id, ordenCompra.Id);
                }
                proveedorLbl.Text = ordenCompra.Proveedor.Nombre;
            }
            else
                MessageBox.Show("Debe ser un numero valido");
        }

        private void InicializarOrdenProductos()
        {
            productosDataGrid.Columns.Clear();
            productosDataGrid.Columns.Add("NombreProducto", "Nombre del Producto");
            productosDataGrid.Columns.Add("Cantidad", "Cantidad");
            productosDataGrid.Columns.Add("IdProducto", "IdProducto");

            productosAprobadosDataGrid.Columns.Clear();
            productosAprobadosDataGrid.Columns.Add("NombreProducto", "Nombre del Producto");
            productosAprobadosDataGrid.Columns.Add("Cantidad", "Cantidad");
            productosAprobadosDataGrid.Columns.Add("IdProducto", "IdProducto");

            productosDesaprobadosDataGrid.Columns.Clear();
            productosDesaprobadosDataGrid.Columns.Add("NombreProducto", "Nombre del Producto");
            productosDesaprobadosDataGrid.Columns.Add("Cantidad", "Cantidad");
            productosDesaprobadosDataGrid.Columns.Add("IdProducto", "IdProducto");
        }

        private void ordenCompraTxt_Enter(object sender, EventArgs e)
        {
            ordenCompraLbl.Hide();
        }

        private void ordenCompraTxt_Leave(object sender, EventArgs e)
        {
            if (ordenCompraTxt.Text == "")
            {
                ordenCompraLbl.Show();
            }
        }

        private void aprobarBtn_Click(object sender, EventArgs e)
        {

            if (productosDataGrid.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un producto");
                return;
            }

            string nombreProducto = productosDataGrid.CurrentRow.Cells["NombreProducto"].Value.ToString();
            int cantidadIngresante = int.Parse(productosDataGrid.CurrentRow.Cells["Cantidad"].Value.ToString());
            int idProducto = int.Parse(productosDataGrid.CurrentRow.Cells["IdProducto"].Value.ToString());

            int cantidadAprobada = (int)cantidadNumeric.Value;

            if (cantidadAprobada > cantidadIngresante)
            {
                MessageBox.Show("Debe seleccionar una cantidad válida");
                return;
            }

            BE.Producto producto = new BE.Producto()
            {
                Nombre = nombreProducto,
                Stock = cantidadAprobada,
                Id = idProducto,
            };
            productosAprobadosDataGrid.Rows.Add(nombreProducto, cantidadAprobada, idProducto);
            productosLista.Add(producto);

            if ((cantidadIngresante - cantidadAprobada) != 0)
            {
                BE.ProductoReposicion productoReposicion = new BE.ProductoReposicion()
                {
                    Faltantes = cantidadIngresante - cantidadAprobada,
                    OrdenAsociada = new BE.OrdenCompra
                    {
                        Id = ordenCompra.Id,
                    },
                    Producto = new BE.Producto()
                    {
                        Id = idProducto,
                    },
                };

                productosDesaprobadosDataGrid.Rows.Add(nombreProducto, productoReposicion.Faltantes, productoReposicion.Producto.Id);
                productosReposicion.Add(productoReposicion);
            }
    
            productosDataGrid.Rows.RemoveAt(productosDataGrid.CurrentRow.Index);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (productosDataGrid.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un producto");
                return;
            }

            string nombreProducto = productosDataGrid.CurrentRow.Cells["NombreProducto"].Value.ToString();
            int cantidadIngresante = int.Parse(productosDataGrid.CurrentRow.Cells["Cantidad"].Value.ToString());
            int idProducto = int.Parse(productosDataGrid.CurrentRow.Cells["IdProducto"].Value.ToString());

            int cantidadDesaprobada = (int)cantidadNumeric.Value;

            if (cantidadDesaprobada > cantidadIngresante)
            {
                MessageBox.Show("Debe seleccionar una cantidad válida");
                return;
            }

            if (cantidadIngresante - cantidadDesaprobada != 0)
            {
                BE.Producto producto = new BE.Producto()
                {
                    Nombre = nombreProducto,
                    Stock = cantidadIngresante - cantidadDesaprobada,
                    Id = idProducto,
                };
                productosAprobadosDataGrid.Rows.Add(nombreProducto, cantidadIngresante - cantidadDesaprobada, idProducto);
                productosLista.Add(producto);
            }

            if (cantidadDesaprobada != 0)
            {
                BE.ProductoReposicion productoReposicion = new BE.ProductoReposicion()
                {
                    Faltantes = cantidadDesaprobada,
                    OrdenAsociada = new BE.OrdenCompra
                    {
                        Id = ordenCompra.Id,
                    },
                    Producto = new BE.Producto()
                    {
                        Id = idProducto,
                    },
                };

                productosDesaprobadosDataGrid.Rows.Add(nombreProducto, productoReposicion.Faltantes, productoReposicion.Producto.Id);

                productosReposicion.Add(productoReposicion);
            }

            productosDataGrid.Rows.RemoveAt(productosDataGrid.CurrentRow.Index);
        }

        private void finalizarBtn_Click(object sender, EventArgs e)
        {
            if (productosDataGrid.Rows.Count == 0)
            {
                gestorOrdenCompra.recibirOrden(ordenCompra);
                if (productosLista.Count != 0) 
                {
                    foreach (var producto in productosLista)
                    {
                        gestorProducto.actualizarStockPorId(producto);
                    }
                }
                if (productosReposicion.Count != 0)
                {
                    foreach (var producto in productosReposicion)
                    {
                        gestorProductoReposicion.insertarRegistro(producto);
                    }
                }
                
                MessageBox.Show("Orden recibida con exito");
                refrescarDataGrids();
            }
            else
            {
                MessageBox.Show("Debe terminar de gestionar la orden para finalizarla");
                return;
            }
        }

        private void refrescarDataGrids()
        {
            productosDesaprobadosDataGrid.Rows.Clear();
            productosAprobadosDataGrid.Rows.Clear();
        }

        private void ayudaBtn_Click(object sender, EventArgs e)
        {
            string rutaHtml = Path.Combine(Application.StartupPath, "Ayuda", "reponer-stock.html");

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
