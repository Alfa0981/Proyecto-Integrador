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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Snow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(18, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Carrito Id";
            // 
            // carritoIdTxt
            // 
            this.carritoIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.carritoIdTxt.Location = new System.Drawing.Point(12, 45);
            this.carritoIdTxt.Multiline = true;
            this.carritoIdTxt.Name = "carritoIdTxt";
            this.carritoIdTxt.Size = new System.Drawing.Size(102, 31);
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
            this.cobrarVentaBtn.Location = new System.Drawing.Point(317, 487);
            this.cobrarVentaBtn.Name = "cobrarVentaBtn";
            this.cobrarVentaBtn.Size = new System.Drawing.Size(71, 39);
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
            this.buscarBtn.Location = new System.Drawing.Point(30, 82);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(71, 39);
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
            this.dataGridView2.Location = new System.Drawing.Point(120, 45);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(447, 415);
            this.dataGridView2.TabIndex = 43;
            // 
            // clienteLbl
            // 
            this.clienteLbl.AutoSize = true;
            this.clienteLbl.Location = new System.Drawing.Point(18, 163);
            this.clienteLbl.Name = "clienteLbl";
            this.clienteLbl.Size = new System.Drawing.Size(42, 13);
            this.clienteLbl.TabIndex = 44;
            this.clienteLbl.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 45;
            // 
            // FormGenerarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(594, 567);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clienteLbl);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.buscarBtn);
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
        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label clienteLbl;
        private System.Windows.Forms.Label label1;
    }
}