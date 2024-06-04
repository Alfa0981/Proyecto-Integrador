﻿using BE;
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
                Id = p.Producto.Id,
                Producto = p.Producto.Nombre,
                Cantidad = p.Cantidad,
                PrecioUnitario = p.Producto.Precio,
                PrecioTotal = p.Producto.Precio * p.Cantidad
            }).ToList();

            dataGridView2.Columns["Id"].Visible = false;

            precioFinalLbl.Text = $"${CalcularTotalCarrito():0.00}";
        }

        public void ActualizarIdioma(Idioma nuevoIdioma)
        {
            switch (nuevoIdioma)
            {
                case Idioma.Spanish:
                    resumenLbl.Text = "Resumen";
                    label1.Text = "Total a Pagar:";
                    registarClienteBtn.Text = "Registrar Cliente";
                    generarCarritoBtn.Text = "Generar Carrito";
                    break;
                case Idioma.English:
                    resumenLbl.Text = "Summary";
                    label1.Text = "Total to pay:";
                    registarClienteBtn.Text = "Register Cliente";
                    generarCarritoBtn.Text = "Generate Cart";
                    break;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void registarClienteBtn_Click(object sender, EventArgs e)
        {
            Form registrarCliente = new FormRegistrarCliente();
            registrarCliente.MdiParent = this.MdiParent;
            registrarCliente.ShowDialog();
        }

        private void generarCarritoBtn_Click(object sender, EventArgs e)
        {
            if (!productosEnCarrito.Any())
            {
                MessageBox.Show("Debe cargar el carrito primero");
            }else if (cliente == null)
            {
                MessageBox.Show("Debe asociar un cliente al carrito");
            }
            else
            {
                Carrito carrito = new Carrito();
                carrito.Productos = productosEnCarrito;
                carrito.Cliente = cliente;
                string precioFinalTexto = precioFinalLbl.Text.Replace("$", "");
                carrito.PrecioFinal = double.Parse(precioFinalTexto);

                int carritoId = gestorCarrito.crearCarrito(carrito);

                MessageBox.Show($"Carrito creado con ID: {carritoId}");
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

                MessageBox.Show("Producto eliminado del carrito correctamente.");
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.");
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
                MessageBox.Show("Campo vacio");
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(clienteIdTxt.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Solo se admiten numeros");
            }
            else if (!productosEnCarrito.Any())
            {
                MessageBox.Show("El carrito se encuentra vacio");
            }
            else
            {
                try
                {
                    cliente = gestorCliente.buscarPorId(int.Parse(clienteIdTxt.Text));
                    MessageBox.Show("Cliente asociado con exito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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