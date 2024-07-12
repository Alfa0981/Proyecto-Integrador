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

namespace Proyecto_Integrador
{
    public partial class FormGestionarPerfil : Form, IIdiomaObserver
    {
        private BLL.Perfil gestorPerfil = new BLL.Perfil();

        public FormGestionarPerfil()
        {
            InitializeComponent();
            IdiomaManager.Instance.Suscribir(this);
            ActualizarIdioma(IdiomaManager.Instance.IdiomaActual);
            Inicializar();
        }

        private void Inicializar()
        {
            patenteLB.DataSource = Enum.GetValues(typeof(TipoPermiso))
                                     .Cast<TipoPermiso>()
                                     .ToList();
            familiasLB.DataSource = gestorPerfil.obtenerTodasFamilias();
            listar();
        }

        private void listar()
        {
            
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void agregarNuevoBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nombreTxt.Text))
            {
                string root = nombreTxt.Text;
                TreeNode nuevoRootNode = new TreeNode(root) { Tag = new Familia(root) };
                treeViewPerfiles.Nodes.Add(nuevoRootNode);
            }
            else
            {
                CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("FaltanCamposException"),"","OK");
            }
        }

        public void ActualizarIdioma(Idioma nuevoIdioma)
        {
            grpFamilias.Text = IdiomaManager.Instance.ObtenerMensaje("Familias");
            grpNuevo.Text = IdiomaManager.Instance.ObtenerMensaje("Nuevo");
            grpPerfiles.Text = IdiomaManager.Instance.ObtenerMensaje("Perfiles");
            grpPatentes.Text = IdiomaManager.Instance.ObtenerMensaje("Patentes");
            nombreLbl.Text = IdiomaManager.Instance.ObtenerMensaje("Nombre");
            todosPerfilesLbl.Text = IdiomaManager.Instance.ObtenerMensaje("TodosPerfiles");
            todasPatentesLbl.Text = IdiomaManager.Instance.ObtenerMensaje("TodasPatentes");
            todasFamiliasLbl.Text = IdiomaManager.Instance.ObtenerMensaje("TodasFamilias");
            agregarFamiliaBtn.Text = IdiomaManager.Instance.ObtenerMensaje("AgregarAPerfil");
            agregarPatenteBtn.Text = IdiomaManager.Instance.ObtenerMensaje("AgregarAPerfil");
            agregarNuevoBtn.Text = IdiomaManager.Instance.ObtenerMensaje("Agregar");
            configurarBtn.Text = IdiomaManager.Instance.ObtenerMensaje("GestionarFamilias");
            guardarBtn.Text = IdiomaManager.Instance.ObtenerMensaje("Guardar");
            eliminarBtn.Text = IdiomaManager.Instance.ObtenerMensaje("Eliminar");
            quitarBtn.Text = IdiomaManager.Instance.ObtenerMensaje("Quitar");
            this.Text = IdiomaManager.Instance.ObtenerMensaje("FormGestionarPerfil");
        }

        private void configurarBtn_Click(object sender, EventArgs e)
        {
            Form configurarFamilias = new FormGestionarFamilias();
            configurarFamilias.MdiParent = this.MdiParent;
            configurarFamilias.Show();
        }

        private void agregarPatenteBtn_Click(object sender, EventArgs e)
        {
            if (treeViewPerfiles.SelectedNode == null)
            {
                CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("NodoNoSeleccionadoException"), "", "OK");
                return;
            }

            TipoPermiso permiso = (TipoPermiso)patenteLB.SelectedItem;

            if (string.IsNullOrEmpty(permiso.ToString()))
            {
                CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("PatenteNoSeleccionadaException"), "", "OK");
                return;
            }

            if (treeViewPerfiles.SelectedNode.Tag is Patente)
            {
                CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("NodoNoEsFamiliaException"), "", "OK");
                return;
            }

            foreach (TreeNode childNode in treeViewPerfiles.SelectedNode.Nodes)
            {
                if (childNode.Tag is Patente patente && patente.Nombre == permiso.ToString())
                {
                    CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("PatenteYaExisteException"), "", "OK");
                    return;
                }
            }
            Patente nuevaPatente = new Patente(permiso.ToString());
            TreeNode nuevaPatenteNode = new TreeNode(nuevaPatente.Nombre) { Tag = nuevaPatente };
            treeViewPerfiles.SelectedNode.Nodes.Add(nuevaPatenteNode);
            treeViewPerfiles.SelectedNode.Expand();
        }

        private void quitarBtn_Click(object sender, EventArgs e)
        {
            if (treeViewPerfiles.SelectedNode == null)
            {
                CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("NodoNoSeleccionadoException"), "", "OK");
                return;
            }

            if (treeViewPerfiles.SelectedNode.Parent == null)
            {
                CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("NoSePuedeEliminarRootException"), "", "OK");
                return;
            }

            treeViewPerfiles.SelectedNode.Remove();
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (treeViewPerfiles.SelectedNode == null)
            {
                CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("NodoNoSeleccionadoException"), "", "OK");
                return;
            }

            if (treeViewPerfiles.SelectedNode.Parent != null)
            {
                CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("NoEsRootException"), "", "OK");
                return;
            }

            treeViewPerfiles.SelectedNode.Remove();
        }

        private void agregarFamiliaBtn_Click(object sender, EventArgs e)
        {
            if (familiasLB.SelectedItem != null && treeViewPerfiles.SelectedNode != null)
            {
                if (treeViewPerfiles.SelectedNode.Tag is Patente)
                {
                    CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("NodoNoEsFamiliaException"), "", "OK");
                    return;
                }
                TreeNode nodoSeleccionado = treeViewPerfiles.SelectedNode;
                Familia familiaSeleccionada = nodoSeleccionado.Tag as Familia;

                Familia familiaAAgregar = familiasLB.SelectedItem as Familia;

                
            }
            else
            {
                CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("SeleccioneFamiliaException"), "", "OK");
            }
        }
    }
}
