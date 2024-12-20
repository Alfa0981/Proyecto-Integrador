﻿using BLL;
using System;
using System.Windows.Forms;
using Services;
using BE;


namespace Proyecto_Integrador
{
    public partial class MdiContainer : Form, IIdiomaObserver
    {
        BLL.Usuario gestorUsuario = new BLL.Usuario();
        public MdiContainer()
        {
            InitializeComponent();
            IdiomaManager.Instance.Suscribir(this);
            ActualizarIdioma(IdiomaManager.Instance.IdiomaActual);
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }


        private void MdiContainer_Load(object sender, EventArgs e)
        {
            InicializarAplicacion();
        }

        private void InicializarAplicacion()
        {
            productosToolStripMenuItem.Enabled = false;
            ventasToolStripMenuItem.Enabled = false;
            adminToolStripMenuItem.Enabled = false;
            this.Hide();
            Form login = new Login();
            login.ShowDialog();

            if (SessionManager.GetInstance != null && SessionManager.GetInstance.Usuario != null)
            {
                
                if (SessionManager.GetInstance.Usuario.Perfil.TienePermiso(TipoPermiso.VistaProductos) ||
                    SessionManager.GetInstance.Usuario.Perfil.TienePermiso(TipoPermiso.AdminPatente))
                    productosToolStripMenuItem.Enabled = true;
                if (SessionManager.GetInstance.Usuario.Perfil.TienePermiso(TipoPermiso.VistaVentas) ||
                    SessionManager.GetInstance.Usuario.Perfil.TienePermiso(TipoPermiso.AdminPatente))
                    ventasToolStripMenuItem.Enabled = true;
                if (SessionManager.GetInstance.Usuario.Perfil.TienePermiso(TipoPermiso.AdminPatente))
                    adminToolStripMenuItem.Enabled = true;

            }

            ActualizarIdioma(IdiomaManager.Instance.IdiomaActual);
            Form main = new Main();
            main.MdiParent = this;
            main.Show();
            this.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = CustomMessageBox.Show(
                                IdiomaManager.Instance.ObtenerMensaje("PreguntaCerrarSesion"),
                                IdiomaManager.Instance.ObtenerMensaje("CerrarSesion"),
                                IdiomaManager.Instance.ObtenerMensaje("Aceptar"),
                                IdiomaManager.Instance.ObtenerMensaje("Cancelar"));

            if (result == DialogResult.OK)
            {
                foreach (Form childForm in this.MdiChildren)
                {
                    childForm.Close();
                }
                gestorUsuario.logout();
                InicializarAplicacion(); 
            }
        }

        private void gestionarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form gestionarUsuarios = new FormGestionarUsuario();
            gestionarUsuarios.MdiParent = this;
            gestionarUsuarios.Show();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cambiarPass = new FormCambiarPass();
            cambiarPass.ShowDialog();
        }

        private void cambiarIdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cambiarIdioma = new FormCambiarIdioma();
            cambiarIdioma.MdiParent = this;
            cambiarIdioma.Show();
        }

        public void ActualizarIdioma(Idioma nuevoIdioma)
        {
            ajustesToolStripMenuItem.Text = IdiomaManager.Instance.ObtenerMensaje("Ajustes");
            productosToolStripMenuItem.Text = IdiomaManager.Instance.ObtenerMensaje("Productos");
            ventasToolStripMenuItem.Text = IdiomaManager.Instance.ObtenerMensaje("Ventas");
            generarVentaToolStripMenuItem.Text = IdiomaManager.Instance.ObtenerMensaje("GenerarVenta");
            clientesToolStripMenuItem.Text = IdiomaManager.Instance.ObtenerMensaje("Clientes");
            ayudaToolStripMenuItem.Text = IdiomaManager.Instance.ObtenerMensaje("Ayuda");
            adminToolStripMenuItem.Text = IdiomaManager.Instance.ObtenerMensaje("Admin");
            logoutToolStripMenuItem.Text = IdiomaManager.Instance.ObtenerMensaje("Salir");
            cambiarContraseñaToolStripMenuItem.Text = IdiomaManager.Instance.ObtenerMensaje("CambiarContraseña");
            cambiarIdiomaToolStripMenuItem.Text = IdiomaManager.Instance.ObtenerMensaje("CambiarIdioma");
            seleccionarProducToolStripMenuItem.Text = IdiomaManager.Instance.ObtenerMensaje("SeleccionarProducto");
            registrarClienteToolStripMenuItem.Text = IdiomaManager.Instance.ObtenerMensaje("RegistrarCliente");
            gestionarUsuariosToolStripMenuItem.Text = IdiomaManager.Instance.ObtenerMensaje("GestionarUsuarios");
            gestionarProductosToolStripMenuItem.Text = IdiomaManager.Instance.ObtenerMensaje("GestionarProductos");
            gestionarPerfilesToolStripMenuItem.Text = IdiomaManager.Instance.ObtenerMensaje("GestionarPerfiles");

        }

        private void seleccionarProducToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form seleccionarProd = new FormSeleccionarProducto();
            seleccionarProd.MdiParent = this;
            seleccionarProd.Show();
        }

        private void generarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form generarFactura = new FormGenerarFactura();
            generarFactura.MdiParent = this;
            generarFactura.Show();
        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form registrarCliente = new FormRegistrarCliente();
            registrarCliente.MdiParent = this;
            registrarCliente.Show();
        }

        private void gestionarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form gestionarProd = new FormGestionarProducto();
            gestionarProd.MdiParent = this;
            gestionarProd.Show();
        }

        private void gestionarPerfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form gestionarPerfiles = new FormGestionarPerfil();
            gestionarPerfiles.MdiParent = this;
            gestionarPerfiles.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bitacoraEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form bitacoraEventos = new BitacoraEventos();
            bitacoraEventos.MdiParent = this;
            bitacoraEventos.Show();
        }

        private void backupRestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form buckupRestore = new BackupRestore(false);
            buckupRestore.MdiParent = this;
            buckupRestore.Show();
        }

        private void ajustesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            gestorUsuario.logout();
        }

        private void bitacoraCambiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form bitacoraCambios = new BitacoraCambios();
            bitacoraCambios.MdiParent = this;
            bitacoraCambios.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form pedidoCotizacion = new PedidoCotizacionForm();
            pedidoCotizacion.MdiParent = this;
            pedidoCotizacion.Show();
        }

        private void ordenCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ordenCompra = new OrdenCompraForm();
            ordenCompra.MdiParent = this;
            ordenCompra.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form proveedores = new RegistrarProveedorForm();
            proveedores.MdiParent = this;
            proveedores.Show();
        }

        private void recibirProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form reponerStock = new ReponerStockForm();
            reponerStock.MdiParent = this;
            reponerStock.Show();
        }
    }
}
