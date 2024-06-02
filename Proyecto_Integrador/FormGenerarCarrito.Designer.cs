namespace Proyecto_Integrador
{
    partial class FormGenerarCarrito
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
            this.registarClienteBtn = new System.Windows.Forms.Button();
            this.resumenLbl = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generarCarritoBtn = new System.Windows.Forms.Button();
            this.precioFinalLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // registarClienteBtn
            // 
            this.registarClienteBtn.BackColor = System.Drawing.Color.IndianRed;
            this.registarClienteBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.registarClienteBtn.FlatAppearance.BorderSize = 0;
            this.registarClienteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registarClienteBtn.Location = new System.Drawing.Point(494, 50);
            this.registarClienteBtn.Name = "registarClienteBtn";
            this.registarClienteBtn.Size = new System.Drawing.Size(71, 39);
            this.registarClienteBtn.TabIndex = 2;
            this.registarClienteBtn.Text = "Registrar Cliente";
            this.registarClienteBtn.UseVisualStyleBackColor = false;
            this.registarClienteBtn.Click += new System.EventHandler(this.registarClienteBtn_Click);
            // 
            // resumenLbl
            // 
            this.resumenLbl.AutoSize = true;
            this.resumenLbl.Location = new System.Drawing.Point(113, 25);
            this.resumenLbl.Name = "resumenLbl";
            this.resumenLbl.Size = new System.Drawing.Size(52, 13);
            this.resumenLbl.TabIndex = 3;
            this.resumenLbl.Text = "Resumen";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column5});
            this.dataGridView2.Location = new System.Drawing.Point(116, 50);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(345, 415);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
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
            // generarCarritoBtn
            // 
            this.generarCarritoBtn.BackColor = System.Drawing.Color.IndianRed;
            this.generarCarritoBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.generarCarritoBtn.FlatAppearance.BorderSize = 0;
            this.generarCarritoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generarCarritoBtn.Location = new System.Drawing.Point(494, 121);
            this.generarCarritoBtn.Name = "generarCarritoBtn";
            this.generarCarritoBtn.Size = new System.Drawing.Size(71, 39);
            this.generarCarritoBtn.TabIndex = 5;
            this.generarCarritoBtn.Text = "Generar Carrito";
            this.generarCarritoBtn.UseVisualStyleBackColor = false;
            this.generarCarritoBtn.Click += new System.EventHandler(this.generarCarritoBtn_Click);
            // 
            // precioFinalLbl
            // 
            this.precioFinalLbl.AutoSize = true;
            this.precioFinalLbl.Location = new System.Drawing.Point(517, 452);
            this.precioFinalLbl.Name = "precioFinalLbl";
            this.precioFinalLbl.Size = new System.Drawing.Size(13, 13);
            this.precioFinalLbl.TabIndex = 8;
            this.precioFinalLbl.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total a Pagar: ";
            // 
            // FormGenerarCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(665, 493);
            this.Controls.Add(this.precioFinalLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generarCarritoBtn);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.resumenLbl);
            this.Controls.Add(this.registarClienteBtn);
            this.Name = "FormGenerarCarrito";
            this.Text = "FormGenerarCarrito";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registarClienteBtn;
        private System.Windows.Forms.Label resumenLbl;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button generarCarritoBtn;
        private System.Windows.Forms.Label precioFinalLbl;
        private System.Windows.Forms.Label label1;
    }
}