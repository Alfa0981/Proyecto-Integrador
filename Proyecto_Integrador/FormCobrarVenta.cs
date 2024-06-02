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
    public partial class FormCobrarVenta : Form, IIdiomaObserver
    {
        public FormCobrarVenta()
        {
            InitializeComponent();
            IdiomaManager.Instance.Suscribir(this);
            ActualizarIdioma(IdiomaManager.Instance.IdiomaActual);
        }

        public void ActualizarIdioma(Idioma nuevoIdioma)
        {
            switch (nuevoIdioma)
            {
                case Idioma.Spanish:
                    tipoPagoGB.Text = "Tipo de Pago";
                    efectivoRBtn.Text = "Efectivo";
                    tarjetaRBtn.Text = "Tarjeta";
                    transferenciaRBtn.Text = "Transferencia";
                    datostarjetaGB.Text = "Datos de Tarjeta";
                    titularLbl.Text = "Titular";
                    numTarjetaLbl.Text = "Numero de Tarjeta";
                    cvvLbl.Text = "CVV";
                    fechaExpLbl.Text = "Fecha de Expiracion";
                    datosEfectivoGB.Text = "Datos Efectivo";
                    montoClienteLbl.Text = "Monto del cliente";
                    montoLbl.Text = "Monto: ";
                    precioLbl.Text = "";
                    vueltoLbl.Text = "Vuelto: ";
                    vueltoCantLbl.Text = "";
                    generarVentaBtn.Text = "Generar Venta";
                    break;

                case Idioma.English:
                    tipoPagoGB.Text = "Payment Type";
                    efectivoRBtn.Text = "Cash";
                    tarjetaRBtn.Text = "Card";
                    transferenciaRBtn.Text = "Transfer";
                    datostarjetaGB.Text = "Card Details";
                    titularLbl.Text = "Owner";
                    numTarjetaLbl.Text = "Card Number";
                    cvvLbl.Text = "CVV";
                    fechaExpLbl.Text = "Expiration Date";
                    datosEfectivoGB.Text = "Cash Details";
                    montoClienteLbl.Text = "Customer Amount";
                    montoLbl.Text = "Amount: ";
                    precioLbl.Text = "";
                    vueltoLbl.Text = "Change: ";
                    vueltoCantLbl.Text = "";
                    generarVentaBtn.Text = "Generarate Sell";
                    break;
            }
        }

        private void FormCobrarVenta_Load(object sender, EventArgs e)
        {

        }

        private void generarVentaBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
