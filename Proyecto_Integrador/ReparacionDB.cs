using BLL;
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
    public partial class ReparacionDB : Form
    {
        bool isClosingByMe;

        public ReparacionDB()
        {
            InitializeComponent();
        }

        private void recalcularBtn_Click(object sender, EventArgs e)
        {
            DV.Instance.ActualizarDV();
            isClosingByMe = true;
            this.Close();
        }

        private void textoLbl_Click(object sender, EventArgs e)
        {

        }

        private void restoreBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form backupRestore = new BackupRestore(true);
            backupRestore.ShowDialog();
            if (backupRestore.DialogResult != DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void ReparacionDB_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isClosingByMe)
                Application.Exit();
        }
    }
}
