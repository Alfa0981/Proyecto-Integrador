namespace Proyecto_Integrador
{
    partial class FormGenerarFactura
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
            this.label3 = new System.Windows.Forms.Label();
            this.carritoIdTxt = new System.Windows.Forms.TextBox();
            this.cobrarVentaBtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Snow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(35, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Carrito Id";
            // 
            // carritoIdTxt
            // 
            this.carritoIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.carritoIdTxt.Location = new System.Drawing.Point(29, 45);
            this.carritoIdTxt.Multiline = true;
            this.carritoIdTxt.Name = "carritoIdTxt";
            this.carritoIdTxt.Size = new System.Drawing.Size(75, 31);
            this.carritoIdTxt.TabIndex = 39;
            // 
            // cobrarVentaBtn
            // 
            this.cobrarVentaBtn.BackColor = System.Drawing.Color.IndianRed;
            this.cobrarVentaBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.cobrarVentaBtn.FlatAppearance.BorderSize = 0;
            this.cobrarVentaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cobrarVentaBtn.Location = new System.Drawing.Point(277, 488);
            this.cobrarVentaBtn.Name = "cobrarVentaBtn";
            this.cobrarVentaBtn.Size = new System.Drawing.Size(71, 39);
            this.cobrarVentaBtn.TabIndex = 40;
            this.cobrarVentaBtn.Text = "Cobrar Venta";
            this.cobrarVentaBtn.UseVisualStyleBackColor = false;
            this.cobrarVentaBtn.Click += new System.EventHandler(this.cobrarVentaBtn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column5});
            this.dataGridView2.Location = new System.Drawing.Point(137, 45);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(345, 415);
            this.dataGridView2.TabIndex = 41;
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
            // FormGenerarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(566, 567);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.cobrarVentaBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.carritoIdTxt);
            this.Name = "FormGenerarFactura";
            this.Text = "FormGenerarFactura";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox carritoIdTxt;
        private System.Windows.Forms.Button cobrarVentaBtn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}