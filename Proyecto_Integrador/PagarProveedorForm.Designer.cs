namespace Proyecto_Integrador
{
    partial class PagarProveedorForm
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
            this.datostarjetaGB = new System.Windows.Forms.GroupBox();
            this.numTarjetaLbl = new System.Windows.Forms.Label();
            this.cvvLbl = new System.Windows.Forms.Label();
            this.fechaExpLbl = new System.Windows.Forms.Label();
            this.nrmTarjetaTxt = new System.Windows.Forms.TextBox();
            this.cvvTxt = new System.Windows.Forms.TextBox();
            this.fechaExpTxt = new System.Windows.Forms.TextBox();
            this.precioFinalLbl = new System.Windows.Forms.Label();
            this.montoLbl = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.generarVentaBtn = new System.Windows.Forms.Button();
            this.datostarjetaGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // datostarjetaGB
            // 
            this.datostarjetaGB.Controls.Add(this.numTarjetaLbl);
            this.datostarjetaGB.Controls.Add(this.cvvLbl);
            this.datostarjetaGB.Controls.Add(this.fechaExpLbl);
            this.datostarjetaGB.Controls.Add(this.nrmTarjetaTxt);
            this.datostarjetaGB.Controls.Add(this.cvvTxt);
            this.datostarjetaGB.Controls.Add(this.fechaExpTxt);
            this.datostarjetaGB.Location = new System.Drawing.Point(12, 74);
            this.datostarjetaGB.Name = "datostarjetaGB";
            this.datostarjetaGB.Size = new System.Drawing.Size(362, 127);
            this.datostarjetaGB.TabIndex = 46;
            this.datostarjetaGB.TabStop = false;
            this.datostarjetaGB.Text = "Datos de Tarjeta";
            // 
            // numTarjetaLbl
            // 
            this.numTarjetaLbl.AutoSize = true;
            this.numTarjetaLbl.BackColor = System.Drawing.Color.Snow;
            this.numTarjetaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.numTarjetaLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.numTarjetaLbl.Location = new System.Drawing.Point(15, 40);
            this.numTarjetaLbl.Name = "numTarjetaLbl";
            this.numTarjetaLbl.Size = new System.Drawing.Size(107, 17);
            this.numTarjetaLbl.TabIndex = 27;
            this.numTarjetaLbl.Text = "Numero Tarjeta";
            // 
            // cvvLbl
            // 
            this.cvvLbl.AutoSize = true;
            this.cvvLbl.BackColor = System.Drawing.Color.Snow;
            this.cvvLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cvvLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.cvvLbl.Location = new System.Drawing.Point(15, 77);
            this.cvvLbl.Name = "cvvLbl";
            this.cvvLbl.Size = new System.Drawing.Size(35, 17);
            this.cvvLbl.TabIndex = 29;
            this.cvvLbl.Text = "CVV";
            // 
            // fechaExpLbl
            // 
            this.fechaExpLbl.AutoSize = true;
            this.fechaExpLbl.BackColor = System.Drawing.Color.Snow;
            this.fechaExpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.fechaExpLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.fechaExpLbl.Location = new System.Drawing.Point(99, 77);
            this.fechaExpLbl.Name = "fechaExpLbl";
            this.fechaExpLbl.Size = new System.Drawing.Size(116, 17);
            this.fechaExpLbl.TabIndex = 31;
            this.fechaExpLbl.Text = "Fecha Expiracion";
            // 
            // nrmTarjetaTxt
            // 
            this.nrmTarjetaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.nrmTarjetaTxt.Location = new System.Drawing.Point(9, 33);
            this.nrmTarjetaTxt.Multiline = true;
            this.nrmTarjetaTxt.Name = "nrmTarjetaTxt";
            this.nrmTarjetaTxt.Size = new System.Drawing.Size(321, 31);
            this.nrmTarjetaTxt.TabIndex = 28;
            // 
            // cvvTxt
            // 
            this.cvvTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cvvTxt.Location = new System.Drawing.Point(9, 70);
            this.cvvTxt.Multiline = true;
            this.cvvTxt.Name = "cvvTxt";
            this.cvvTxt.Size = new System.Drawing.Size(75, 31);
            this.cvvTxt.TabIndex = 30;
            // 
            // fechaExpTxt
            // 
            this.fechaExpTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.fechaExpTxt.Location = new System.Drawing.Point(90, 70);
            this.fechaExpTxt.Multiline = true;
            this.fechaExpTxt.Name = "fechaExpTxt";
            this.fechaExpTxt.Size = new System.Drawing.Size(240, 31);
            this.fechaExpTxt.TabIndex = 32;
            // 
            // precioFinalLbl
            // 
            this.precioFinalLbl.AutoSize = true;
            this.precioFinalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.precioFinalLbl.Location = new System.Drawing.Point(477, 74);
            this.precioFinalLbl.Name = "precioFinalLbl";
            this.precioFinalLbl.Size = new System.Drawing.Size(30, 20);
            this.precioFinalLbl.TabIndex = 48;
            this.precioFinalLbl.Text = "xxx";
            // 
            // montoLbl
            // 
            this.montoLbl.AutoSize = true;
            this.montoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.montoLbl.Location = new System.Drawing.Point(409, 74);
            this.montoLbl.Name = "montoLbl";
            this.montoLbl.Size = new System.Drawing.Size(62, 20);
            this.montoLbl.TabIndex = 47;
            this.montoLbl.Text = "Monto: ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(411, 119);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(442, 401);
            this.dataGridView2.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "Codigo de Orden Compra: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(215, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "xxx";
            // 
            // generarVentaBtn
            // 
            this.generarVentaBtn.BackColor = System.Drawing.Color.IndianRed;
            this.generarVentaBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.generarVentaBtn.FlatAppearance.BorderSize = 0;
            this.generarVentaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generarVentaBtn.Location = new System.Drawing.Point(156, 225);
            this.generarVentaBtn.Name = "generarVentaBtn";
            this.generarVentaBtn.Size = new System.Drawing.Size(71, 39);
            this.generarVentaBtn.TabIndex = 52;
            this.generarVentaBtn.Text = "Pagar";
            this.generarVentaBtn.UseVisualStyleBackColor = false;
            // 
            // PagarProveedorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(880, 532);
            this.Controls.Add(this.generarVentaBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.precioFinalLbl);
            this.Controls.Add(this.montoLbl);
            this.Controls.Add(this.datostarjetaGB);
            this.Name = "PagarProveedorForm";
            this.Text = "PagarProveedorForm";
            this.datostarjetaGB.ResumeLayout(false);
            this.datostarjetaGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox datostarjetaGB;
        private System.Windows.Forms.Label numTarjetaLbl;
        private System.Windows.Forms.Label cvvLbl;
        private System.Windows.Forms.Label fechaExpLbl;
        private System.Windows.Forms.TextBox nrmTarjetaTxt;
        private System.Windows.Forms.TextBox cvvTxt;
        private System.Windows.Forms.TextBox fechaExpTxt;
        private System.Windows.Forms.Label precioFinalLbl;
        private System.Windows.Forms.Label montoLbl;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generarVentaBtn;
    }
}