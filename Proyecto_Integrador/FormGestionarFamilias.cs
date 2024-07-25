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
    public partial class FormGestionarFamilias : Form, IIdiomaObserver
    {

        private BLL.Perfil gestorPerfil = new BLL.Perfil();

        public FormGestionarFamilias()
        {
            InitializeComponent();
            IdiomaManager.Instance.Suscribir(this);
            ActualizarIdioma(IdiomaManager.Instance.IdiomaActual);

            patenteLB.DataSource = Enum.GetValues(typeof(TipoPermiso))
                                     .Cast<TipoPermiso>()
                                     .ToList();
            listar();
        }
        private void listar()
        {
            familiasLB.DataSource = gestorPerfil.obtenerTodasFamilias();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nombreTxt.Text))
            {
                List<Familia> familiasArray = familiasLB.Items.Cast<Familia>().ToList();
                if (!familiasArray.Any(f => f.Nombre == nombreTxt.Text))
                {
                    treeConfigurarFamilia.Nodes.Clear();
                    string root = nombreTxt.Text;
                    Familia nuevaFamilia = new Familia(root);

                    TreeNode nuevoRootNode = new TreeNode(root) { Tag = new Familia(root) };
                    treeConfigurarFamilia.Nodes.Add(nuevoRootNode);                 
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
            grpConfigurarFamilia.Text = IdiomaManager.Instance.ObtenerMensaje("ConfigurarFamilias");
            grpNuevo.Text = IdiomaManager.Instance.ObtenerMensaje("Nuevo");
            grpFamilias.Text = IdiomaManager.Instance.ObtenerMensaje("Patentes");
            grpPatentes.Text = IdiomaManager.Instance.ObtenerMensaje("Familias");
            nombreLbl.Text = IdiomaManager.Instance.ObtenerMensaje("Nombre");
            todasFamiliasLbl.Text = IdiomaManager.Instance.ObtenerMensaje("TodasFamilias");
            todasPatentesLbl.Text = IdiomaManager.Instance.ObtenerMensaje("TodasPatentes");
            agregarBtn.Text = IdiomaManager.Instance.ObtenerMensaje("Agregar");
            agregarFamiliaBtn.Text = IdiomaManager.Instance.ObtenerMensaje("AgregarAFamilia");
            agregarPatenteBtn.Text = IdiomaManager.Instance.ObtenerMensaje("AgregarAFamilia");
            guardarFamiliaBtn.Text = IdiomaManager.Instance.ObtenerMensaje("Guardar");
            eliminarBtn.Text = IdiomaManager.Instance.ObtenerMensaje("Eliminar");
            quitarBtn.Text = IdiomaManager.Instance.ObtenerMensaje("Quitar");
            configurarBtn.Text = IdiomaManager.Instance.ObtenerMensaje("Configurar");
            this.Text = IdiomaManager.Instance.ObtenerMensaje("FormGestionarFamilias");
        }

        private void agregarPatenteBtn_Click(object sender, EventArgs e)
        {
            if (treeConfigurarFamilia.SelectedNode == null)
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

            if (treeConfigurarFamilia.SelectedNode.Tag is Patente)
            {
                CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("NodoNoEsFamiliaException"), "", "OK");
                return;
            }

            foreach (TreeNode childNode in treeConfigurarFamilia.SelectedNode.Nodes)
            {
                if (childNode.Tag is Patente patente && patente.Nombre == permiso.ToString())
                {
                    CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("PatenteYaExisteException"), "", "OK");
                    return;
                }
            }
            Patente nuevaPatente = new Patente(permiso.ToString());
            TreeNode nuevaPatenteNode = new TreeNode(nuevaPatente.Nombre) { Tag = nuevaPatente };
            treeConfigurarFamilia.SelectedNode.Nodes.Add(nuevaPatenteNode);
            treeConfigurarFamilia.SelectedNode.Expand();
        }

        private void quitarBtn_Click(object sender, EventArgs e)
        {
            if (treeConfigurarFamilia.SelectedNode == null)
            {
                CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("NodoNoSeleccionadoException"), "", "OK");
                return;
            }

            if (treeConfigurarFamilia.SelectedNode.Parent == null)
            {
                CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("NoSePuedeEliminarRootException"), "", "OK");
                return;
            }

            treeConfigurarFamilia.SelectedNode.Remove();
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (treeConfigurarFamilia.SelectedNode == null)
            {
                CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("NodoNoSeleccionadoException"), "", "OK");
                return;
            }

            if (treeConfigurarFamilia.SelectedNode.Parent != null)
            {
                CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("NoEsRootException"), "", "OK");
                return;
            }

            Familia familiaSeleccionado = treeConfigurarFamilia.SelectedNode.Tag as Familia;

            if (familiaSeleccionado != null && familiaSeleccionado.EsFamilia)
            {
                try
                {
                    gestorPerfil.EliminarFamilia(familiaSeleccionado.ID);
                    treeConfigurarFamilia.SelectedNode.Remove();
                    listar();
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("ErrorEliminacionException") + ": " + ex.Message, "", "OK");
                }
            }
            else
            {
                CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("NodoNoEsFamiliaException"), "", "OK");
            }
        }

        private void configurarBtn_Click(object sender, EventArgs e)
        {
            if (familiasLB.SelectedItem != null)
            {
                Familia familiaSeleccionada = familiasLB.SelectedItem as Familia;
                
                treeConfigurarFamilia.Nodes.Clear();

                TreeNode rootNode = new TreeNode(familiaSeleccionada.Nombre) { Tag = familiaSeleccionada };

                CargarSubNodos(rootNode, familiaSeleccionada);

                treeConfigurarFamilia.Nodes.Add(rootNode);

                rootNode.Expand();
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

        private void agregarFamiliaBtn_Click(object sender, EventArgs e)
        {
            if (familiasLB.SelectedItem != null && treeConfigurarFamilia.SelectedNode != null)
            {
                if (treeConfigurarFamilia.SelectedNode.Tag is Patente)
                {
                    CustomMessageBox.Show(IdiomaManager.Instance.ObtenerMensaje("NodoNoEsFamiliaException"), "", "OK");
                    return;
                }
                TreeNode nodoSeleccionado = treeConfigurarFamilia.SelectedNode;
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

        private void guardarFamiliaBtn_Click(object sender, EventArgs e)
        {
            TreeNode nodo = treeConfigurarFamilia.Nodes[0];
            List<Perfil> perfiles = new List<Perfil>();

            foreach (TreeNode hijo in nodo.Nodes)
            {
                if (hijo.Tag is Perfil perfil)
                {
                    perfiles.Add(perfil);
                }
            }

            Familia nuevaFamilia = new Familia(nodo.Text, perfiles.ToArray());
            gestorPerfil.crearFamilia(nuevaFamilia);
            listar();
        }
    }
}
