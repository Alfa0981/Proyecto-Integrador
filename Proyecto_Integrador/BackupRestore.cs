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
    public partial class BackupRestore : Form
    {
        BLL.BackupRestore backupRestore;

        public BackupRestore()
        {
            InitializeComponent();
            backupRestore = new BLL.BackupRestore();
        }

        private void aplicarBtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    backupPathTxt.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "SQL Backup Files (*.bak)|*.bak";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    restoreTxt.Text = openFileDialog.FileName;
                }
            }
        }

        private void realizarBackupBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(backupPathTxt.Text))
            {
                try
                {
                    backupRestore.RealizarBackup(backupPathTxt.Text);
                    MessageBox.Show("Backup realizado con éxito.");
                    backupPathTxt.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al realizar el backup: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una ubicación para el backup.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(restoreTxt.Text))
            {
                try
                {
                    backupRestore.RealizarRestore(restoreTxt.Text);
                    MessageBox.Show("Restauración realizada con éxito.");
                    restoreTxt.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al restaurar la base de datos: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un archivo de restore.");
            }
        }
    }
}
