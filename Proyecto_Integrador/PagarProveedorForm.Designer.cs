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
            this.precioFinalLbl = new System.Windows.Forms.Label();
            this.montoLbl = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.generarVentaBtn = new System.Windows.Forms.Button();
            this.proveedorLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // precioFinalLbl
            // 
            this.precioFinalLbl.AutoSize = true;
            this.precioFinalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.precioFinalLbl.Location = new System.Drawing.Point(80, 45);
            this.precioFinalLbl.Name = "precioFinalLbl";
            this.precioFinalLbl.Size = new System.Drawing.Size(30, 20);
            this.precioFinalLbl.TabIndex = 48;
            this.precioFinalLbl.Text = "xxx";
            // 
            // montoLbl
            // 
            this.montoLbl.AutoSize = true;
            this.montoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.montoLbl.Location = new System.Drawing.Point(12, 45);
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
            this.dataGridView2.Location = new System.Drawing.Point(16, 134);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(373, 220);
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
            this.generarVentaBtn.Location = new System.Drawing.Point(174, 400);
            this.generarVentaBtn.Name = "generarVentaBtn";
            this.generarVentaBtn.Size = new System.Drawing.Size(71, 39);
            this.generarVentaBtn.TabIndex = 52;
            this.generarVentaBtn.Text = "Pagar";
            this.generarVentaBtn.UseVisualStyleBackColor = false;
            this.generarVentaBtn.Click += new System.EventHandler(this.generarVentaBtn_Click);
            // 
            // proveedorLbl
            // 
            this.proveedorLbl.AutoSize = true;
            this.proveedorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.proveedorLbl.Location = new System.Drawing.Point(103, 88);
            this.proveedorLbl.Name = "proveedorLbl";
            this.proveedorLbl.Size = new System.Drawing.Size(30, 20);
            this.proveedorLbl.TabIndex = 54;
            this.proveedorLbl.Text = "xxx";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(12, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "Proveedor:";
            // 
            // PagarProveedorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(415, 532);
            this.Controls.Add(this.proveedorLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.generarVentaBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.precioFinalLbl);
            this.Controls.Add(this.montoLbl);
            this.Name = "PagarProveedorForm";
            this.Text = "PagarProveedorForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label precioFinalLbl;
        private System.Windows.Forms.Label montoLbl;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generarVentaBtn;
        private System.Windows.Forms.Label proveedorLbl;
        private System.Windows.Forms.Label label6;
    }
}