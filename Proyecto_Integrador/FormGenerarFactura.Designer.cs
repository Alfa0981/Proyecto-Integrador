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
            this.buscarBtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.clienteLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ayudaBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Snow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(33, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 29);
            this.label3.TabIndex = 38;
            this.label3.Text = "Carrito Id";
            // 
            // carritoIdTxt
            // 
            this.carritoIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.carritoIdTxt.Location = new System.Drawing.Point(22, 83);
            this.carritoIdTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.carritoIdTxt.Multiline = true;
            this.carritoIdTxt.Name = "carritoIdTxt";
            this.carritoIdTxt.Size = new System.Drawing.Size(184, 54);
            this.carritoIdTxt.TabIndex = 39;
            this.carritoIdTxt.Enter += new System.EventHandler(this.carritoIdTxt_Enter);
            this.carritoIdTxt.Leave += new System.EventHandler(this.carritoIdTxt_Leave);
            // 
            // cobrarVentaBtn
            // 
            this.cobrarVentaBtn.BackColor = System.Drawing.Color.IndianRed;
            this.cobrarVentaBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.cobrarVentaBtn.FlatAppearance.BorderSize = 0;
            this.cobrarVentaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cobrarVentaBtn.Location = new System.Drawing.Point(581, 899);
            this.cobrarVentaBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cobrarVentaBtn.Name = "cobrarVentaBtn";
            this.cobrarVentaBtn.Size = new System.Drawing.Size(130, 72);
            this.cobrarVentaBtn.TabIndex = 40;
            this.cobrarVentaBtn.Text = "Cobrar Venta";
            this.cobrarVentaBtn.UseVisualStyleBackColor = false;
            this.cobrarVentaBtn.Click += new System.EventHandler(this.cobrarVentaBtn_Click);
            // 
            // buscarBtn
            // 
            this.buscarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.buscarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.buscarBtn.FlatAppearance.BorderSize = 0;
            this.buscarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buscarBtn.Location = new System.Drawing.Point(55, 151);
            this.buscarBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(130, 72);
            this.buscarBtn.TabIndex = 42;
            this.buscarBtn.Text = "Buscar";
            this.buscarBtn.UseVisualStyleBackColor = false;
            this.buscarBtn.Click += new System.EventHandler(this.buscarBtn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(220, 83);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 72;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(820, 766);
            this.dataGridView2.TabIndex = 43;
            // 
            // clienteLbl
            // 
            this.clienteLbl.AutoSize = true;
            this.clienteLbl.Location = new System.Drawing.Point(33, 301);
            this.clienteLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.clienteLbl.Name = "clienteLbl";
            this.clienteLbl.Size = new System.Drawing.Size(79, 25);
            this.clienteLbl.TabIndex = 44;
            this.clienteLbl.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 351);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 45;
            // 
            // ayudaBtn
            // 
            this.ayudaBtn.BackColor = System.Drawing.Color.IndianRed;
            this.ayudaBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.ayudaBtn.FlatAppearance.BorderSize = 0;
            this.ayudaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ayudaBtn.Location = new System.Drawing.Point(55, 899);
            this.ayudaBtn.Margin = new System.Windows.Forms.Padding(6);
            this.ayudaBtn.Name = "ayudaBtn";
            this.ayudaBtn.Size = new System.Drawing.Size(130, 72);
            this.ayudaBtn.TabIndex = 56;
            this.ayudaBtn.Text = "Ayuda";
            this.ayudaBtn.UseVisualStyleBackColor = false;
            this.ayudaBtn.Click += new System.EventHandler(this.ayudaBtn_Click);
            // 
            // FormGenerarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1089, 1047);
            this.Controls.Add(this.ayudaBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clienteLbl);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.buscarBtn);
            this.Controls.Add(this.cobrarVentaBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.carritoIdTxt);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label clienteLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ayudaBtn;
    }
}