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
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox(string message, string okButtonText, string cancelButtonText)
        {
            InitializeComponent();
            labelMessage.Text = message;
            buttonOK.Text = okButtonText;
            buttonCancel.Text = cancelButtonText;
        }

        public CustomMessageBox(string message, string okButtonText)
        {
            InitializeComponent();
            labelMessage.Text = message;
            buttonOK.Text = okButtonText;
            buttonCancel.Hide();
        }

        public static DialogResult Show(string message, string title, string okButtonText, string cancelButtonText)
        {
            using (CustomMessageBox customMessageBox = new CustomMessageBox(message, okButtonText, cancelButtonText))
            {
                customMessageBox.Text = title;
                return customMessageBox.ShowDialog();
            }
        }

        public static DialogResult Show(string message, string title, string okButtonText)
        {
            using (CustomMessageBox customMessageBox = new CustomMessageBox(message, okButtonText))
            {

                customMessageBox.Text = title;
                return customMessageBox.ShowDialog();
            }
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

