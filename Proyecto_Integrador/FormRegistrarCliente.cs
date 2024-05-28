﻿using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Integrador
{
    public partial class FormRegistrarCliente : Form
    {


        public FormRegistrarCliente()
        {
            InitializeComponent();
        }

        private void FormRegistrarCliente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = nombreTxt.Text;
            string apellido = apellidoTxt.Text;

            byte[] nombreBytes = Encoding.UTF8.GetBytes(nombre);
            byte[] apellidoBytes = Encoding.UTF8.GetBytes(apellido);

            byte[] entropy = new byte[20];
            new RNGCryptoServiceProvider().GetBytes(entropy);

            byte[] nombreEncriptado = UserEncryption.EncryptData(nombreBytes, entropy);
            byte[] apellidoEncriptado = UserEncryption.EncryptData(apellidoBytes, entropy);


            string nombreEncriptadoBase64 = Convert.ToBase64String(nombreEncriptado);
            string apellidoEncriptadoBase64 = Convert.ToBase64String(apellidoEncriptado);
            nombreLbl.Text = nombreEncriptadoBase64;
            apellidoLbl.Text = apellidoEncriptadoBase64;


            byte[] nombreEncriptadoBytes = Convert.FromBase64String(nombreEncriptadoBase64);
            byte[] apellidoEncriptadoBytes = Convert.FromBase64String(apellidoEncriptadoBase64);

            byte[] nombreDesencriptado = UserEncryption.DecryptData(nombreEncriptadoBytes, entropy);
            byte[] apellidoDesencriptado = UserEncryption.DecryptData(apellidoEncriptadoBytes, entropy);

            string nombreOriginal = Encoding.UTF8.GetString(nombreDesencriptado);
            string apellidoOriginal = Encoding.UTF8.GetString(apellidoDesencriptado);
            desencriptado1Lbl.Text = nombreOriginal;
            desencriptado2Lbl.Text = apellidoOriginal;

            //hay que guardar entropy junto al atributo encriptado

        }

        private void apellidoTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nombreTxt_Enter(object sender, EventArgs e)
        {
            label1.Hide();
        }
    }
}
