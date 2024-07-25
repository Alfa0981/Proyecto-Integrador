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
            List<Perfil> perfiles = gestorPerfil.obtenerTodosPerfiles();
            CargarPerfilesEnTreeView(perfiles);
        }

        private void CargarPerfilesEnTreeView(List<Perfil> perfiles)
        {
            List<TreeNode> nodos = ConvertirPerfilesANodos(perfiles);

            treeViewPerfiles.Nodes.Clear();
            foreach (var nodo in nodos)
            {
                treeViewPerfiles.Nodes.Add(nodo);
            }
        }

        private List<TreeNode> ConvertirPerfilesANodos(List<Perfil> perfiles)
        {
            List<TreeNode> nodos = new List<TreeNode>();

            foreach (var perfil in perfiles)
            {
                TreeNode nodo = ConvertirPerfilANodo(perfil);
                nodos.Add(nodo);
            }

            return nodos;
        }

        private TreeNode ConvertirPerfilANodo(Perfil perfil)
        {
            TreeNode nodo = new TreeNode(perfil.Nombre) { Tag = perfil };

            if (perfil.EsFamilia)
            {
                Familia familia = perfil as Familia;
                foreach (var subPerfil in familia.ObtenerSubFamilias())
                {
                    TreeNode nodoHijo = ConvertirPerfilANodo(subPerfil);
                    nodo.Nodes.Add(nodoHijo);
                }
            }

            return nodo;
        }


        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void agregarNuevoBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nombreTxt.Text))
            {
                string root = nombreTxt.Text;

                bool existe = treeViewPerfiles.Nodes.Cast<TreeNode>().Any(n => n.Text == root);

                if (!existe)
                {
                    Familia nuevaFamilia = new Familia(root) { Tipo = "Perfil" };
                    TreeNode nuevoRootNode = new TreeNode(root) { Tag = nuevaFamilia };
                    treeViewPerfiles.Nodes.Add(nuevoRootNode);
                }
                else
                {
                    CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("FamiliaAlreadyExists"), "", "OK");
                }
            }
            else
            {
                CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("FaltanCamposException"), "", "OK");
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

            Perfil perfilSeleccionado = treeViewPerfiles.SelectedNode.Tag as Perfil;

            if (perfilSeleccionado != null && perfilSeleccionado.Tipo == "Perfil")
            {
                try
                {
                    gestorPerfil.EliminarPerfil(perfilSeleccionado.ID);
                    treeViewPerfiles.SelectedNode.Remove();
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("ErrorEliminacionException") + ": " + ex.Message, "", "OK");
                }
            }
            else
            {
                CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("NodoNoEsPerfilException"), "", "OK");
            }
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

                if (familiaSeleccionada.Nombre != familiaAAgregar.Nombre)
                {
                    if (FamiliaYaExiste(nodoSeleccionado, familiaAAgregar))
                    {
                        CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("FamiliaYaExisteException"), "", "OK");
                        return;
                    }

                    if (SubfamiliaYaExiste(familiaSeleccionada, familiaAAgregar))
                    {
                        CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("FamiliaYaExisteException"), "", "OK");
                        return;
                    }
                    familiaSeleccionada.Agregar(familiaAAgregar);

                    TreeNode nuevoNodoFamilia = new TreeNode(familiaAAgregar.Nombre) { Tag = familiaAAgregar };

                    nodoSeleccionado.Nodes.Add(nuevoNodoFamilia);
                    CargarSubNodos(nuevoNodoFamilia, familiaAAgregar);
                    nodoSeleccionado.Expand();
                }
                else
                {
                    CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("NoSePuedeAgregarMismaFamiliaException"), "", "OK");
                }
            }
            else
            {
                CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("SeleccioneFamiliaException"), "", "OK");
            }
        }

        private void CargarSubNodos(TreeNode parentNode, Familia familia)
        {
            foreach (var f in familia.ObtenerSubFamilias())
            {
                TreeNode newNode = new TreeNode(f.Nombre) { Tag = f };
                parentNode.Nodes.Add(newNode);
                if (f is Familia subFamilia)
                {
                    CargarSubNodos(newNode, subFamilia);
                }
            }
        }

        private bool FamiliaYaExiste(TreeNode nodo, Familia familiaAAgregar)
        {
            if (nodo.Tag is Familia nodoFamilia && nodoFamilia.Nombre == familiaAAgregar.Nombre)
            {
                return true;
            }

            foreach (TreeNode childNode in nodo.Nodes)
            {
                if (FamiliaYaExiste(childNode, familiaAAgregar))
                {
                    return true;
                }
            }

            return false;
        }

        private bool SubfamiliaYaExiste(Familia destino, Familia aAgregar)
        {
            foreach (var subfamilia in aAgregar.ObtenerSubFamilias().OfType<Familia>())
            {
                if (SubfamiliaYaExisteRecursivamente(destino, subfamilia))
                {
                    return true;
                }
            }
            return false;
        }

        private bool SubfamiliaYaExisteRecursivamente(Familia destino, Familia subfamilia)
        {
            if (destino.Nombre == subfamilia.Nombre)
            {
                return true;
            }

            foreach (var sub in destino.ObtenerSubFamilias().OfType<Familia>())
            {
                if (SubfamiliaYaExisteRecursivamente(sub, subfamilia))
                {
                    return true;
                }
            }

            return false;
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            if (treeViewPerfiles.SelectedNode != null)
            {
                Familia perfilSeleccionado = treeViewPerfiles.SelectedNode.Tag as Familia;
                
                if (perfilSeleccionado != null && perfilSeleccionado.Tipo == "Perfil")
                {
                    TreeNode nodo = treeViewPerfiles.SelectedNode;
                    List<Perfil> perfiles = new List<Perfil>();

                    foreach (TreeNode hijo in nodo.Nodes)
                    {
                        if (hijo.Tag is Perfil perfil)
                        {
                            perfiles.Add(perfil);
                        }
                    }

                    Familia nuevoPerfil = new Familia(nodo.Text, perfiles.ToArray());
                    nuevoPerfil.Tipo = "Perfil";
                    gestorPerfil.crearPerfil(nuevoPerfil);
                }
                else
                {
                    CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("NodoNoEsPerfilException"), "", "OK");
                }
            }
            else
            {
                CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("SeleccioneNodoException"), "", "OK");
            }
        }
    }
}
