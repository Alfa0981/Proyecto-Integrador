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
            this.fechaExpLbl = new System.Windows.Forms.Label();
            this.fechaExpTxt = new System.Windows.Forms.TextBox();
            this.cvvLbl = new System.Windows.Forms.Label();
            this.cvvTxt = new System.Windows.Forms.TextBox();
            this.numTarjetaLbl = new System.Windows.Forms.Label();
            this.nrmTarjetaTxt = new System.Windows.Forms.TextBox();
            this.datostarjetaGB = new System.Windows.Forms.GroupBox();
            this.datosEfectivoGB = new System.Windows.Forms.GroupBox();
            this.vueltoCantLbl = new System.Windows.Forms.Label();
            this.vueltoLbl = new System.Windows.Forms.Label();
            this.montoClienteLbl = new System.Windows.Forms.Label();
            this.precioLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.montoLbl = new System.Windows.Forms.Label();
            this.tipoPagoGB = new System.Windows.Forms.GroupBox();
            this.efectivoRBtn = new System.Windows.Forms.RadioButton();
            this.transferenciaRBtn = new System.Windows.Forms.RadioButton();
            this.tarjetaRBtn = new System.Windows.Forms.RadioButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datosEfectivoGB.SuspendLayout();
            this.tipoPagoGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // generarVentaBtn
            // 
            this.generarVentaBtn.BackColor = System.Drawing.Color.IndianRed;
            this.generarVentaBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.generarVentaBtn.FlatAppearance.BorderSize = 0;
            this.generarVentaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generarVentaBtn.Location = new System.Drawing.Point(188, 529);
            this.generarVentaBtn.Name = "generarVentaBtn";
            this.generarVentaBtn.Size = new System.Drawing.Size(71, 39);
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
            this.titularLbl.Location = new System.Drawing.Point(46, 196);
            this.titularLbl.Name = "titularLbl";
            this.titularLbl.Size = new System.Drawing.Size(48, 17);
            this.titularLbl.TabIndex = 33;
            this.titularLbl.Text = "Titular";
            // 
            // titularTxt
            // 
            this.titularTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.titularTxt.Location = new System.Drawing.Point(40, 189);
            this.titularTxt.Multiline = true;
            this.titularTxt.Name = "titularTxt";
            this.titularTxt.Size = new System.Drawing.Size(321, 31);
            this.titularTxt.TabIndex = 34;
            // 
            // fechaExpLbl
            // 
            this.fechaExpLbl.AutoSize = true;
            this.fechaExpLbl.BackColor = System.Drawing.Color.Snow;
            this.fechaExpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.fechaExpLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.fechaExpLbl.Location = new System.Drawing.Point(130, 270);
            this.fechaExpLbl.Name = "fechaExpLbl";
            this.fechaExpLbl.Size = new System.Drawing.Size(116, 17);
            this.fechaExpLbl.TabIndex = 31;
            this.fechaExpLbl.Text = "Fecha Expiracion";
            // 
            // fechaExpTxt
            // 
            this.fechaExpTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.fechaExpTxt.Location = new System.Drawing.Point(121, 263);
            this.fechaExpTxt.Multiline = true;
            this.fechaExpTxt.Name = "fechaExpTxt";
            this.fechaExpTxt.Size = new System.Drawing.Size(240, 31);
            this.fechaExpTxt.TabIndex = 32;
            // 
            // cvvLbl
            // 
            this.cvvLbl.AutoSize = true;
            this.cvvLbl.BackColor = System.Drawing.Color.Snow;
            this.cvvLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cvvLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.cvvLbl.Location = new System.Drawing.Point(46, 270);
            this.cvvLbl.Name = "cvvLbl";
            this.cvvLbl.Size = new System.Drawing.Size(35, 17);
            this.cvvLbl.TabIndex = 29;
            this.cvvLbl.Text = "CVV";
            // 
            // cvvTxt
            // 
            this.cvvTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cvvTxt.Location = new System.Drawing.Point(40, 263);
            this.cvvTxt.Multiline = true;
            this.cvvTxt.Name = "cvvTxt";
            this.cvvTxt.Size = new System.Drawing.Size(75, 31);
            this.cvvTxt.TabIndex = 30;
            // 
            // numTarjetaLbl
            // 
            this.numTarjetaLbl.AutoSize = true;
            this.numTarjetaLbl.BackColor = System.Drawing.Color.Snow;
            this.numTarjetaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.numTarjetaLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.numTarjetaLbl.Location = new System.Drawing.Point(46, 233);
            this.numTarjetaLbl.Name = "numTarjetaLbl";
            this.numTarjetaLbl.Size = new System.Drawing.Size(107, 17);
            this.numTarjetaLbl.TabIndex = 27;
            this.numTarjetaLbl.Text = "Numero Tarjeta";
            // 
            // nrmTarjetaTxt
            // 
            this.nrmTarjetaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.nrmTarjetaTxt.Location = new System.Drawing.Point(40, 226);
            this.nrmTarjetaTxt.Multiline = true;
            this.nrmTarjetaTxt.Name = "nrmTarjetaTxt";
            this.nrmTarjetaTxt.Size = new System.Drawing.Size(321, 31);
            this.nrmTarjetaTxt.TabIndex = 28;
            // 
            // datostarjetaGB
            // 
            this.datostarjetaGB.Location = new System.Drawing.Point(15, 167);
            this.datostarjetaGB.Name = "datostarjetaGB";
            this.datostarjetaGB.Size = new System.Drawing.Size(427, 156);
            this.datostarjetaGB.TabIndex = 36;
            this.datostarjetaGB.TabStop = false;
            this.datostarjetaGB.Text = "Datos de Tarjeta";
            // 
            // datosEfectivoGB
            // 
            this.datosEfectivoGB.Controls.Add(this.vueltoCantLbl);
            this.datosEfectivoGB.Controls.Add(this.vueltoLbl);
            this.datosEfectivoGB.Controls.Add(this.montoClienteLbl);
            this.datosEfectivoGB.Controls.Add(this.textBox1);
            this.datosEfectivoGB.Location = new System.Drawing.Point(15, 353);
            this.datosEfectivoGB.Name = "datosEfectivoGB";
            this.datosEfectivoGB.Size = new System.Drawing.Size(427, 139);
            this.datosEfectivoGB.TabIndex = 37;
            this.datosEfectivoGB.TabStop = false;
            this.datosEfectivoGB.Text = "Datos en Efectivo";
            // 
            // vueltoCantLbl
            // 
            this.vueltoCantLbl.AutoSize = true;
            this.vueltoCantLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.vueltoCantLbl.Location = new System.Drawing.Point(89, 91);
            this.vueltoCantLbl.Name = "vueltoCantLbl";
            this.vueltoCantLbl.Size = new System.Drawing.Size(51, 20);
            this.vueltoCantLbl.TabIndex = 41;
            this.vueltoCantLbl.Text = "vuelto";
            this.vueltoCantLbl.Visible = false;
            // 
            // vueltoLbl
            // 
            this.vueltoLbl.AutoSize = true;
            this.vueltoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.vueltoLbl.Location = new System.Drawing.Point(21, 91);
            this.vueltoLbl.Name = "vueltoLbl";
            this.vueltoLbl.Size = new System.Drawing.Size(59, 20);
            this.vueltoLbl.TabIndex = 40;
            this.vueltoLbl.Text = "Vuelto:";
            // 
            // montoClienteLbl
            // 
            this.montoClienteLbl.AutoSize = true;
            this.montoClienteLbl.BackColor = System.Drawing.Color.Snow;
            this.montoClienteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.montoClienteLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.montoClienteLbl.Location = new System.Drawing.Point(31, 37);
            this.montoClienteLbl.Name = "montoClienteLbl";
            this.montoClienteLbl.Size = new System.Drawing.Size(117, 17);
            this.montoClienteLbl.TabIndex = 38;
            this.montoClienteLbl.Text = "Monto del Cliente";
            // 
            // precioLbl
            // 
            this.precioLbl.AutoSize = true;
            this.precioLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.precioLbl.Location = new System.Drawing.Point(626, 121);
            this.precioLbl.Name = "precioLbl";
            this.precioLbl.Size = new System.Drawing.Size(52, 20);
            this.precioLbl.TabIndex = 39;
            this.precioLbl.Text = "precio";
            this.precioLbl.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBox1.Location = new System.Drawing.Point(25, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(321, 31);
            this.textBox1.TabIndex = 39;
            // 
            // montoLbl
            // 
            this.montoLbl.AutoSize = true;
            this.montoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.montoLbl.Location = new System.Drawing.Point(558, 121);
            this.montoLbl.Name = "montoLbl";
            this.montoLbl.Size = new System.Drawing.Size(62, 20);
            this.montoLbl.TabIndex = 38;
            this.montoLbl.Text = "Monto: ";
            // 
            // tipoPagoGB
            // 
            this.tipoPagoGB.Controls.Add(this.efectivoRBtn);
            this.tipoPagoGB.Controls.Add(this.transferenciaRBtn);
            this.tipoPagoGB.Controls.Add(this.tarjetaRBtn);
            this.tipoPagoGB.Location = new System.Drawing.Point(15, 12);
            this.tipoPagoGB.Name = "tipoPagoGB";
            this.tipoPagoGB.Size = new System.Drawing.Size(148, 129);
            this.tipoPagoGB.TabIndex = 38;
            this.tipoPagoGB.TabStop = false;
            this.tipoPagoGB.Text = "Tipo de Pago";
            // 
            // efectivoRBtn
            // 
            this.efectivoRBtn.AutoSize = true;
            this.efectivoRBtn.Location = new System.Drawing.Point(27, 41);
            this.efectivoRBtn.Name = "efectivoRBtn";
            this.efectivoRBtn.Size = new System.Drawing.Size(64, 17);
            this.efectivoRBtn.TabIndex = 27;
            this.efectivoRBtn.TabStop = true;
            this.efectivoRBtn.Text = "Efectivo";
            this.efectivoRBtn.UseVisualStyleBackColor = true;
            // 
            // transferenciaRBtn
            // 
            this.transferenciaRBtn.AutoSize = true;
            this.transferenciaRBtn.Location = new System.Drawing.Point(27, 87);
            this.transferenciaRBtn.Name = "transferenciaRBtn";
            this.transferenciaRBtn.Size = new System.Drawing.Size(90, 17);
            this.transferenciaRBtn.TabIndex = 29;
            this.transferenciaRBtn.TabStop = true;
            this.transferenciaRBtn.Text = "Transferencia";
            this.transferenciaRBtn.UseVisualStyleBackColor = true;
            // 
            // tarjetaRBtn
            // 
            this.tarjetaRBtn.AutoSize = true;
            this.tarjetaRBtn.Location = new System.Drawing.Point(27, 64);
            this.tarjetaRBtn.Name = "tarjetaRBtn";
            this.tarjetaRBtn.Size = new System.Drawing.Size(58, 17);
            this.tarjetaRBtn.TabIndex = 28;
            this.tarjetaRBtn.TabStop = true;
            this.tarjetaRBtn.Text = "Tarjeta";
            this.tarjetaRBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column5});
            this.dataGridView2.Location = new System.Drawing.Point(561, 167);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(345, 401);
            this.dataGridView2.TabIndex = 42;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cantidad";
            this.Column5.Name = "Column5";
            // 
            // FormCobrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1015, 673);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.tipoPagoGB);
            this.Controls.Add(this.datosEfectivoGB);
            this.Controls.Add(this.precioLbl);
            this.Controls.Add(this.generarVentaBtn);
            this.Controls.Add(this.montoLbl);
            this.Controls.Add(this.titularLbl);
            this.Controls.Add(this.titularTxt);
            this.Controls.Add(this.fechaExpLbl);
            this.Controls.Add(this.fechaExpTxt);
            this.Controls.Add(this.cvvLbl);
            this.Controls.Add(this.cvvTxt);
            this.Controls.Add(this.numTarjetaLbl);
            this.Controls.Add(this.nrmTarjetaTxt);
            this.Controls.Add(this.datostarjetaGB);
            this.Name = "FormCobrarVenta";
            this.Text = "FormCobrarVenta";
            this.Load += new System.EventHandler(this.FormCobrarVenta_Load);
            this.datosEfectivoGB.ResumeLayout(false);
            this.datosEfectivoGB.PerformLayout();
            this.tipoPagoGB.ResumeLayout(false);
            this.tipoPagoGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generarVentaBtn;
        private System.Windows.Forms.Label titularLbl;
        private System.Windows.Forms.TextBox titularTxt;
        private System.Windows.Forms.Label fechaExpLbl;
        private System.Windows.Forms.TextBox fechaExpTxt;
        private System.Windows.Forms.Label cvvLbl;
        private System.Windows.Forms.TextBox cvvTxt;
        private System.Windows.Forms.Label numTarjetaLbl;
        private System.Windows.Forms.TextBox nrmTarjetaTxt;
        private System.Windows.Forms.GroupBox datostarjetaGB;
        private System.Windows.Forms.GroupBox datosEfectivoGB;
        private System.Windows.Forms.Label vueltoCantLbl;
        private System.Windows.Forms.Label vueltoLbl;
        private System.Windows.Forms.Label montoClienteLbl;
        private System.Windows.Forms.Label precioLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label montoLbl;
        private System.Windows.Forms.GroupBox tipoPagoGB;
        private System.Windows.Forms.RadioButton efectivoRBtn;
        private System.Windows.Forms.RadioButton transferenciaRBtn;
        private System.Windows.Forms.RadioButton tarjetaRBtn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}