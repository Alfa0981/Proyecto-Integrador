﻿using BE;
using Services;
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
    public partial class FormGestionarProducto : Form , IIdiomaObserver
    {
        BLL.Producto gestorProducto = new BLL.Producto();
        Producto producto;

        public FormGestionarProducto()
        {
            InitializeComponent();
            IdiomaManager.Instance.Suscribir(this);
            ActualizarIdioma(IdiomaManager.Instance.IdiomaActual);
            listar();
            modificarBtn.Hide();
            eliminarBtn.Hide();
            modificarBtn.Enabled = false;
            eliminarBtn.Enabled = false;
            agregarBtn.Enabled = false;
            if (SessionManager.GetInstance.Usuario.Perfil.TienePermiso(TipoPermiso.CRUDProd) ||
                SessionManager.GetInstance.Usuario.Perfil.TienePermiso(TipoPermiso.AdminPatente))
            {
                modificarBtn.Enabled = true;
                eliminarBtn.Enabled = true;
                agregarBtn.Enabled = true;
            }
        }

        private void listar()
        {
            dataGridView2.DataSource = gestorProducto.mostrarTodos();
            dataGridView2.Columns["Id"].Visible = false;
            dataGridView2.Columns["Activo"].Visible = false;
        }

        public void ActualizarIdioma(Idioma nuevoIdioma)
        {
            nombreLbl.Text = IdiomaManager.Instance.ObtenerMensaje("Nombre");
            stockLbl.Text = IdiomaManager.Instance.ObtenerMensaje("Stock");
            precioLbl.Text = IdiomaManager.Instance.ObtenerMensaje("Precio");
            agregarBtn.Text = IdiomaManager.Instance.ObtenerMensaje("Agregar");
            eliminarBtn.Text = IdiomaManager.Instance.ObtenerMensaje("Eliminar");
            modificarBtn.Text = IdiomaManager.Instance.ObtenerMensaje("Modificar");
            this.Text = IdiomaManager.Instance.ObtenerMensaje("FormGestionarProducto");
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            if (validarInputs())
            {
                Producto producto = new Producto();
                producto.Nombre = nombreTxt.Text;
                producto.Stock = int.Parse(stockTxt.Text);
                producto.Precio = double.Parse(precioTxt.Text);

                try
                {
                    gestorProducto.crearProducto(producto);
                    listar();
                }
                catch (Exception ex)
                {

                    CustomMessageBox.Show(ex.Message, IdiomaManager.Instance.ObtenerMensaje(""), "OK");
                }
            }
        }

        private bool validarInputs()
        {
            if (string.IsNullOrEmpty(nombreTxt.Text)||
                string.IsNullOrEmpty(precioTxt.Text) ||
                string.IsNullOrEmpty(stockTxt.Text))
            {
                CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("FaltanCamposException"), IdiomaManager.Instance.ObtenerMensaje(""), "OK");
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(stockTxt.Text, "^[0-9]*$"))
            {
                CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("OnlyNumbers"), IdiomaManager.Instance.ObtenerMensaje(""), "OK");
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(precioTxt.Text, @"^\d+(,\d+)?$"))
            {
                CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("FormatoIncorrecto"), IdiomaManager.Instance.ObtenerMensaje(""), "OK");
                return false;
            }
            return true;
        }

        private void nombreTxt_Enter(object sender, EventArgs e)
        {
            nombreLbl.Hide();
        }

        private void nombreTxt_Leave(object sender, EventArgs e)
        {
            if (nombreTxt.Text == "")
            {
                nombreLbl.Show();
            }
        }

        private void precioTxt_Enter(object sender, EventArgs e)
        {
            precioLbl.Hide();
        }

        private void precioTxt_Leave(object sender, EventArgs e)
        {
            if (precioTxt.Text == "")
            {
                precioLbl.Show();
            }
        }

        private void stockTxt_Enter(object sender, EventArgs e)
        {
            stockLbl.Hide();
        }

        private void stockTxt_Leave(object sender, EventArgs e)
        {
            if (stockTxt.Text == "")
            {
                stockLbl.Show();
            }
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            producto.Activo = false;
            gestorProducto.modificarProducto(producto);
            listar();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            producto = (Producto)dataGridView2.CurrentRow.DataBoundItem;

            nombreLbl.Hide();
            precioLbl.Hide();
            stockLbl.Hide();

            nombreTxt.Text = producto.Nombre;
            stockTxt.Text = producto.Stock.ToString();
            precioTxt.Text = producto.Precio.ToString();

            eliminarBtn.Show();
            modificarBtn.Show();
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            if (validarInputs())
            {
                producto.Nombre = nombreTxt.Text;
                producto.Stock = int.Parse(stockTxt.Text);
                producto.Precio = double.Parse(precioTxt.Text);
                gestorProducto.modificarProducto(producto);
                listar();
            }
        }

        private void ayudaBtn_Click(object sender, EventArgs e)
        {
            string rutaHtml = Path.Combine(Application.StartupPath, "Ayuda", "gestionar-productos.html");

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
