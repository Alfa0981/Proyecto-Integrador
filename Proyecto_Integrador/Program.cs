using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Integrador
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form mdiContainer = new MdiContainer();
            Form loginForm = new Login();
            Form cambiarPass = new FormCambiarPass();


            /*switch (loginForm.ShowDialog())
            {
                case DialogResult.OK:
                    if (cambiarPass.ShowDialog() == DialogResult.OK)
                        Application.Run(mdiContainer);
                    break;
                case DialogResult.Ignore:
                    Application.Run(mdiContainer);
                    break;
            }*/

            Application.Run(mdiContainer);
            
        }
    }
}
