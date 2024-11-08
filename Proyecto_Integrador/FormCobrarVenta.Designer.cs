namespace Proyecto_Integrador
{
    partial class FormCobrarVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.generarVentaBtn = new System.Windows.Forms.Button();
            this.titularLbl = new System.Windows.Forms.Label();
            this.titularTxt = new System.Windows.Forms.TextBox();
            this.fechaExpTxt = new System.Windows.Forms.TextBox();
            this.cvvLbl = new System.Windows.Forms.Label();
            this.cvvTxt = new System.Windows.Forms.TextBox();
            this.numTarjetaLbl = new System.Windows.Forms.Label();
            this.nrmTarjetaTxt = new System.Windows.Forms.TextBox();
            this.datostarjetaGB = new System.Windows.Forms.GroupBox();
            this.fechaExpLbl = new System.Windows.Forms.Label();
            this.datosEfectivoGB = new System.Windows.Forms.GroupBox();
            this.montoClienteLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.montoLbl = new System.Windows.Forms.Label();
            this.tipoPagoGB = new System.Windows.Forms.GroupBox();
            this.efectivoRBtn = new System.Windows.Forms.RadioButton();
            this.transferenciaRBtn = new System.Windows.Forms.RadioButton();
            this.tarjetaRBtn = new System.Windows.Forms.RadioButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.precioFinalLbl = new System.Windows.Forms.Label();
            this.transferenciaGB = new System.Windows.Forms.GroupBox();
            this.aliasLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ayudaBtn = new System.Windows.Forms.Button();
            this.datostarjetaGB.SuspendLayout();
            this.datosEfectivoGB.SuspendLayout();
            this.tipoPagoGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.transferenciaGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // generarVentaBtn
            // 
            this.generarVentaBtn.BackColor = System.Drawing.Color.IndianRed;
            this.generarVentaBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.generarVentaBtn.FlatAppearance.BorderSize = 0;
            this.generarVentaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generarVentaBtn.Location = new System.Drawing.Point(363, 977);
            this.generarVentaBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.generarVentaBtn.Name = "generarVentaBtn";
            this.generarVentaBtn.Size = new System.Drawing.Size(130, 72);
            this.generarVentaBtn.TabIndex = 35;
            this.generarVentaBtn.Text = "Generar Venta";
            this.generarVentaBtn.UseVisualStyleBackColor = false;
            this.generarVentaBtn.Click += new System.EventHandler(this.generarVentaBtn_Click);
            // 
            // titularLbl
            // 
            this.titularLbl.AutoSize = true;
            this.titularLbl.BackColor = System.Drawing.Color.Snow;
            this.titularLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.titularLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.titularLbl.Location = new System.Drawing.Point(57, 68);
            this.titularLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.titularLbl.Name = "titularLbl";
            this.titularLbl.Size = new System.Drawing.Size(81, 29);
            this.titularLbl.TabIndex = 33;
            this.titularLbl.Text = "Titular";
            // 
            // titularTxt
            // 
            this.titularTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.titularTxt.Location = new System.Drawing.Point(46, 55);
            this.titularTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.titularTxt.Multiline = true;
            this.titularTxt.Name = "titularTxt";
            this.titularTxt.Size = new System.Drawing.Size(585, 54);
            this.titularTxt.TabIndex = 34;
            this.titularTxt.Enter += new System.EventHandler(this.titularTxt_Enter);
            this.titularTxt.Leave += new System.EventHandler(this.titularTxt_Leave);
            // 
            // fechaExpTxt
            // 
            this.fechaExpTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.fechaExpTxt.Location = new System.Drawing.Point(194, 192);
            this.fechaExpTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.fechaExpTxt.Multiline = true;
            this.fechaExpTxt.Name = "fechaExpTxt";
            this.fechaExpTxt.Size = new System.Drawing.Size(437, 54);
            this.fechaExpTxt.TabIndex = 32;
            this.fechaExpTxt.TextChanged += new System.EventHandler(this.fechaExpTxt_TextChanged);
            this.fechaExpTxt.Enter += new System.EventHandler(this.fechaExpTxt_Enter);
            this.fechaExpTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fechaExpTxt_KeyPress);
            this.fechaExpTxt.Leave += new System.EventHandler(this.fechaExpTxt_Leave);
            // 
            // cvvLbl
            // 
            this.cvvLbl.AutoSize = true;
            this.cvvLbl.BackColor = System.Drawing.Color.Snow;
            this.cvvLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cvvLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.cvvLbl.Location = new System.Drawing.Point(57, 205);
            this.cvvLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cvvLbl.Name = "cvvLbl";
            this.cvvLbl.Size = new System.Drawing.Size(60, 29);
            this.cvvLbl.TabIndex = 29;
            this.cvvLbl.Text = "CVV";
            // 
            // cvvTxt
            // 
            this.cvvTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cvvTxt.Location = new System.Drawing.Point(46, 192);
            this.cvvTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cvvTxt.Multiline = true;
            this.cvvTxt.Name = "cvvTxt";
            this.cvvTxt.Size = new System.Drawing.Size(134, 54);
            this.cvvTxt.TabIndex = 30;
            this.cvvTxt.Enter += new System.EventHandler(this.cvvTxt_Enter);
            this.cvvTxt.Leave += new System.EventHandler(this.cvvTxt_Leave);
            // 
            // numTarjetaLbl
            // 
            this.numTarjetaLbl.AutoSize = true;
            this.numTarjetaLbl.BackColor = System.Drawing.Color.Snow;
            this.numTarjetaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.numTarjetaLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.numTarjetaLbl.Location = new System.Drawing.Point(57, 137);
            this.numTarjetaLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.numTarjetaLbl.Name = "numTarjetaLbl";
            this.numTarjetaLbl.Size = new System.Drawing.Size(182, 29);
            this.numTarjetaLbl.TabIndex = 27;
            this.numTarjetaLbl.Text = "Numero Tarjeta";
            // 
            // nrmTarjetaTxt
            // 
            this.nrmTarjetaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.nrmTarjetaTxt.Location = new System.Drawing.Point(46, 124);
            this.nrmTarjetaTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nrmTarjetaTxt.Multiline = true;
            this.nrmTarjetaTxt.Name = "nrmTarjetaTxt";
            this.nrmTarjetaTxt.Size = new System.Drawing.Size(585, 54);
            this.nrmTarjetaTxt.TabIndex = 28;
            this.nrmTarjetaTxt.Enter += new System.EventHandler(this.nrmTarjetaTxt_Enter);
            this.nrmTarjetaTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nrmTarjetaTxt_KeyPress);
            this.nrmTarjetaTxt.Leave += new System.EventHandler(this.nrmTarjetaTxt_Leave);
            // 
            // datostarjetaGB
            // 
            this.datostarjetaGB.Controls.Add(this.numTarjetaLbl);
            this.datostarjetaGB.Controls.Add(this.cvvLbl);
            this.datostarjetaGB.Controls.Add(this.fechaExpLbl);
            this.datostarjetaGB.Controls.Add(this.titularLbl);
            this.datostarjetaGB.Controls.Add(this.titularTxt);
            this.datostarjetaGB.Controls.Add(this.nrmTarjetaTxt);
            this.datostarjetaGB.Controls.Add(this.cvvTxt);
            this.datostarjetaGB.Controls.Add(this.fechaExpTxt);
            this.datostarjetaGB.Location = new System.Drawing.Point(28, 308);
            this.datostarjetaGB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.datostarjetaGB.Name = "datostarjetaGB";
            this.datostarjetaGB.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.datostarjetaGB.Size = new System.Drawing.Size(783, 288);
            this.datostarjetaGB.TabIndex = 36;
            this.datostarjetaGB.TabStop = false;
            this.datostarjetaGB.Text = "Datos de Tarjeta";
            // 
            // fechaExpLbl
            // 
            this.fechaExpLbl.AutoSize = true;
            this.fechaExpLbl.BackColor = System.Drawing.Color.Snow;
            this.fechaExpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.fechaExpLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.fechaExpLbl.Location = new System.Drawing.Point(211, 205);
            this.fechaExpLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.fechaExpLbl.Name = "fechaExpLbl";
            this.fechaExpLbl.Size = new System.Drawing.Size(199, 29);
            this.fechaExpLbl.TabIndex = 31;
            this.fechaExpLbl.Text = "Fecha Expiracion";
            // 
            // datosEfectivoGB
            // 
            this.datosEfectivoGB.Controls.Add(this.montoClienteLbl);
            this.datosEfectivoGB.Controls.Add(this.textBox1);
            this.datosEfectivoGB.Location = new System.Drawing.Point(28, 628);
            this.datosEfectivoGB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.datosEfectivoGB.Name = "datosEfectivoGB";
            this.datosEfectivoGB.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.datosEfectivoGB.Size = new System.Drawing.Size(783, 151);
            this.datosEfectivoGB.TabIndex = 37;
            this.datosEfectivoGB.TabStop = false;
            this.datosEfectivoGB.Text = "Datos en Efectivo";
            // 
            // montoClienteLbl
            // 
            this.montoClienteLbl.AutoSize = true;
            this.montoClienteLbl.BackColor = System.Drawing.Color.Snow;
            this.montoClienteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.montoClienteLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.montoClienteLbl.Location = new System.Drawing.Point(57, 68);
            this.montoClienteLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.montoClienteLbl.Name = "montoClienteLbl";
            this.montoClienteLbl.Size = new System.Drawing.Size(202, 29);
            this.montoClienteLbl.TabIndex = 38;
            this.montoClienteLbl.Text = "Monto del Cliente";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBox1.Location = new System.Drawing.Point(46, 55);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(585, 54);
            this.textBox1.TabIndex = 39;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter_1);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave_1);
            // 
            // montoLbl
            // 
            this.montoLbl.AutoSize = true;
            this.montoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.montoLbl.Location = new System.Drawing.Point(904, 223);
            this.montoLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.montoLbl.Name = "montoLbl";
            this.montoLbl.Size = new System.Drawing.Size(108, 32);
            this.montoLbl.TabIndex = 38;
            this.montoLbl.Text = "Monto: ";
            // 
            // tipoPagoGB
            // 
            this.tipoPagoGB.Controls.Add(this.efectivoRBtn);
            this.tipoPagoGB.Controls.Add(this.transferenciaRBtn);
            this.tipoPagoGB.Controls.Add(this.tarjetaRBtn);
            this.tipoPagoGB.Location = new System.Drawing.Point(28, 22);
            this.tipoPagoGB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tipoPagoGB.Name = "tipoPagoGB";
            this.tipoPagoGB.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tipoPagoGB.Size = new System.Drawing.Size(271, 238);
            this.tipoPagoGB.TabIndex = 38;
            this.tipoPagoGB.TabStop = false;
            this.tipoPagoGB.Text = "Tipo de Pago";
            // 
            // efectivoRBtn
            // 
            this.efectivoRBtn.AutoSize = true;
            this.efectivoRBtn.Location = new System.Drawing.Point(50, 76);
            this.efectivoRBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.efectivoRBtn.Name = "efectivoRBtn";
            this.efectivoRBtn.Size = new System.Drawing.Size(106, 29);
            this.efectivoRBtn.TabIndex = 27;
            this.efectivoRBtn.TabStop = true;
            this.efectivoRBtn.Text = "Efectivo";
            this.efectivoRBtn.UseVisualStyleBackColor = true;
            this.efectivoRBtn.Click += new System.EventHandler(this.efectivoRBtn_Click);
            // 
            // transferenciaRBtn
            // 
            this.transferenciaRBtn.AutoSize = true;
            this.transferenciaRBtn.Location = new System.Drawing.Point(50, 161);
            this.transferenciaRBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.transferenciaRBtn.Name = "transferenciaRBtn";
            this.transferenciaRBtn.Size = new System.Drawing.Size(157, 29);
            this.transferenciaRBtn.TabIndex = 29;
            this.transferenciaRBtn.TabStop = true;
            this.transferenciaRBtn.Text = "Transferencia";
            this.transferenciaRBtn.UseVisualStyleBackColor = true;
            this.transferenciaRBtn.Click += new System.EventHandler(this.transferenciaRBtn_Click);
            // 
            // tarjetaRBtn
            // 
            this.tarjetaRBtn.AutoSize = true;
            this.tarjetaRBtn.Location = new System.Drawing.Point(50, 118);
            this.tarjetaRBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tarjetaRBtn.Name = "tarjetaRBtn";
            this.tarjetaRBtn.Size = new System.Drawing.Size(98, 29);
            this.tarjetaRBtn.TabIndex = 28;
            this.tarjetaRBtn.TabStop = true;
            this.tarjetaRBtn.Text = "Tarjeta";
            this.tarjetaRBtn.UseVisualStyleBackColor = true;
            this.tarjetaRBtn.Click += new System.EventHandler(this.tarjetaRBtn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(906, 308);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 72;
            this.dataGridView2.Size = new System.Drawing.Size(810, 740);
            this.dataGridView2.TabIndex = 42;
            // 
            // precioFinalLbl
            // 
            this.precioFinalLbl.AutoSize = true;
            this.precioFinalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.precioFinalLbl.Location = new System.Drawing.Point(1028, 223);
            this.precioFinalLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.precioFinalLbl.Name = "precioFinalLbl";
            this.precioFinalLbl.Size = new System.Drawing.Size(108, 32);
            this.precioFinalLbl.TabIndex = 43;
            this.precioFinalLbl.Text = "Monto: ";
            // 
            // transferenciaGB
            // 
            this.transferenciaGB.Controls.Add(this.aliasLbl);
            this.transferenciaGB.Controls.Add(this.label2);
            this.transferenciaGB.Location = new System.Drawing.Point(28, 814);
            this.transferenciaGB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.transferenciaGB.Name = "transferenciaGB";
            this.transferenciaGB.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.transferenciaGB.Size = new System.Drawing.Size(783, 151);
            this.transferenciaGB.TabIndex = 40;
            this.transferenciaGB.TabStop = false;
            this.transferenciaGB.Text = "Datos Transferencia";
            // 
            // aliasLbl
            // 
            this.aliasLbl.AutoSize = true;
            this.aliasLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.aliasLbl.Location = new System.Drawing.Point(108, 66);
            this.aliasLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.aliasLbl.Name = "aliasLbl";
            this.aliasLbl.Size = new System.Drawing.Size(362, 32);
            this.aliasLbl.TabIndex = 45;
            this.aliasLbl.Text = "FABRICA.PASTAS.LOMAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(11, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 32);
            this.label2.TabIndex = 44;
            this.label2.Text = "Alias:";
            // 
            // ayudaBtn
            // 
            this.ayudaBtn.BackColor = System.Drawing.Color.IndianRed;
            this.ayudaBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.ayudaBtn.FlatAppearance.BorderSize = 0;
            this.ayudaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ayudaBtn.Location = new System.Drawing.Point(1586, 206);
            this.ayudaBtn.Margin = new System.Windows.Forms.Padding(6);
            this.ayudaBtn.Name = "ayudaBtn";
            this.ayudaBtn.Size = new System.Drawing.Size(130, 72);
            this.ayudaBtn.TabIndex = 57;
            this.ayudaBtn.Text = "Ayuda";
            this.ayudaBtn.UseVisualStyleBackColor = false;
            this.ayudaBtn.Click += new System.EventHandler(this.ayudaBtn_Click);
            // 
            // FormCobrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1861, 1242);
            this.Controls.Add(this.ayudaBtn);
            this.Controls.Add(this.transferenciaGB);
            this.Controls.Add(this.precioFinalLbl);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.tipoPagoGB);
            this.Controls.Add(this.datosEfectivoGB);
            this.Controls.Add(this.generarVentaBtn);
            this.Controls.Add(this.montoLbl);
            this.Controls.Add(this.datostarjetaGB);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormCobrarVenta";
            this.Text = "FormCobrarVenta";
            this.Load += new System.EventHandler(this.FormCobrarVenta_Load);
            this.datostarjetaGB.ResumeLayout(false);
            this.datostarjetaGB.PerformLayout();
            this.datosEfectivoGB.ResumeLayout(false);
            this.datosEfectivoGB.PerformLayout();
            this.tipoPagoGB.ResumeLayout(false);
            this.tipoPagoGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.transferenciaGB.ResumeLayout(false);
            this.transferenciaGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generarVentaBtn;
        private System.Windows.Forms.Label titularLbl;
        private System.Windows.Forms.TextBox titularTxt;
        private System.Windows.Forms.TextBox fechaExpTxt;
        private System.Windows.Forms.Label cvvLbl;
        private System.Windows.Forms.TextBox cvvTxt;
        private System.Windows.Forms.Label numTarjetaLbl;
        private System.Windows.Forms.TextBox nrmTarjetaTxt;
        private System.Windows.Forms.GroupBox datostarjetaGB;
        private System.Windows.Forms.GroupBox datosEfectivoGB;
        private System.Windows.Forms.Label montoClienteLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label montoLbl;
        private System.Windows.Forms.GroupBox tipoPagoGB;
        private System.Windows.Forms.RadioButton efectivoRBtn;
        private System.Windows.Forms.RadioButton transferenciaRBtn;
        private System.Windows.Forms.RadioButton tarjetaRBtn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label precioFinalLbl;
        private System.Windows.Forms.Label fechaExpLbl;
        private System.Windows.Forms.GroupBox transferenciaGB;
        private System.Windows.Forms.Label aliasLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ayudaBtn;
    }
}