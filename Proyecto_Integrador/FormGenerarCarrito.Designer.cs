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
            this.generarCarritoBtn = new System.Windows.Forms.Button();
            this.precioFinalLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.asociarCliente = new System.Windows.Forms.Button();
            this.clienteIdLbl = new System.Windows.Forms.Label();
            this.clienteIdTxt = new System.Windows.Forms.TextBox();
            this.ayudaBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // registarClienteBtn
            // 
            this.registarClienteBtn.BackColor = System.Drawing.Color.IndianRed;
            this.registarClienteBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.registarClienteBtn.FlatAppearance.BorderSize = 0;
            this.registarClienteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registarClienteBtn.Location = new System.Drawing.Point(55, 497);
            this.registarClienteBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.registarClienteBtn.Name = "registarClienteBtn";
            this.registarClienteBtn.Size = new System.Drawing.Size(130, 72);
            this.registarClienteBtn.TabIndex = 2;
            this.registarClienteBtn.Text = "Registrar Cliente";
            this.registarClienteBtn.UseVisualStyleBackColor = false;
            this.registarClienteBtn.Click += new System.EventHandler(this.registarClienteBtn_Click);
            // 
            // resumenLbl
            // 
            this.resumenLbl.AutoSize = true;
            this.resumenLbl.Location = new System.Drawing.Point(244, 37);
            this.resumenLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.resumenLbl.Name = "resumenLbl";
            this.resumenLbl.Size = new System.Drawing.Size(95, 25);
            this.resumenLbl.TabIndex = 3;
            this.resumenLbl.Text = "Resumen";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(249, 92);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 72;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(820, 766);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // generarCarritoBtn
            // 
            this.generarCarritoBtn.BackColor = System.Drawing.Color.IndianRed;
            this.generarCarritoBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.generarCarritoBtn.FlatAppearance.BorderSize = 0;
            this.generarCarritoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generarCarritoBtn.Location = new System.Drawing.Point(55, 617);
            this.generarCarritoBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.generarCarritoBtn.Name = "generarCarritoBtn";
            this.generarCarritoBtn.Size = new System.Drawing.Size(130, 72);
            this.generarCarritoBtn.TabIndex = 5;
            this.generarCarritoBtn.Text = "Generar Carrito";
            this.generarCarritoBtn.UseVisualStyleBackColor = false;
            this.generarCarritoBtn.Click += new System.EventHandler(this.generarCarritoBtn_Click);
            // 
            // precioFinalLbl
            // 
            this.precioFinalLbl.AutoSize = true;
            this.precioFinalLbl.Location = new System.Drawing.Point(97, 834);
            this.precioFinalLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.precioFinalLbl.Name = "precioFinalLbl";
            this.precioFinalLbl.Size = new System.Drawing.Size(23, 25);
            this.precioFinalLbl.TabIndex = 8;
            this.precioFinalLbl.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 781);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total a Pagar: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(50, 92);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 72);
            this.button1.TabIndex = 9;
            this.button1.Text = "Eliminar Producto";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // asociarCliente
            // 
            this.asociarCliente.BackColor = System.Drawing.Color.IndianRed;
            this.asociarCliente.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.asociarCliente.FlatAppearance.BorderSize = 0;
            this.asociarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.asociarCliente.Location = new System.Drawing.Point(50, 192);
            this.asociarCliente.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.asociarCliente.Name = "asociarCliente";
            this.asociarCliente.Size = new System.Drawing.Size(130, 72);
            this.asociarCliente.TabIndex = 10;
            this.asociarCliente.Text = "Asociar Cliente";
            this.asociarCliente.UseVisualStyleBackColor = false;
            this.asociarCliente.Click += new System.EventHandler(this.asociarCliente_Click);
            // 
            // clienteIdLbl
            // 
            this.clienteIdLbl.AutoSize = true;
            this.clienteIdLbl.BackColor = System.Drawing.Color.Snow;
            this.clienteIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.clienteIdLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.clienteIdLbl.Location = new System.Drawing.Point(59, 305);
            this.clienteIdLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.clienteIdLbl.Name = "clienteIdLbl";
            this.clienteIdLbl.Size = new System.Drawing.Size(115, 29);
            this.clienteIdLbl.TabIndex = 40;
            this.clienteIdLbl.Text = "Cliente Id";
            // 
            // clienteIdTxt
            // 
            this.clienteIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.clienteIdTxt.Location = new System.Drawing.Point(48, 292);
            this.clienteIdTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.clienteIdTxt.Multiline = true;
            this.clienteIdTxt.Name = "clienteIdTxt";
            this.clienteIdTxt.Size = new System.Drawing.Size(134, 54);
            this.clienteIdTxt.TabIndex = 41;
            this.clienteIdTxt.Enter += new System.EventHandler(this.carritoIdTxt_Enter);
            this.clienteIdTxt.Leave += new System.EventHandler(this.carritoIdTxt_Leave);
            // 
            // ayudaBtn
            // 
            this.ayudaBtn.BackColor = System.Drawing.Color.IndianRed;
            this.ayudaBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.ayudaBtn.FlatAppearance.BorderSize = 0;
            this.ayudaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ayudaBtn.Location = new System.Drawing.Point(1134, 786);
            this.ayudaBtn.Margin = new System.Windows.Forms.Padding(6);
            this.ayudaBtn.Name = "ayudaBtn";
            this.ayudaBtn.Size = new System.Drawing.Size(130, 72);
            this.ayudaBtn.TabIndex = 55;
            this.ayudaBtn.Text = "Ayuda";
            this.ayudaBtn.UseVisualStyleBackColor = false;
            this.ayudaBtn.Click += new System.EventHandler(this.ayudaBtn_Click);
            // 
            // FormGenerarCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1764, 910);
            this.Controls.Add(this.ayudaBtn);
            this.Controls.Add(this.clienteIdLbl);
            this.Controls.Add(this.clienteIdTxt);
            this.Controls.Add(this.asociarCliente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.precioFinalLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generarCarritoBtn);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.resumenLbl);
            this.Controls.Add(this.registarClienteBtn);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
        private System.Windows.Forms.Button generarCarritoBtn;
        private System.Windows.Forms.Label precioFinalLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button asociarCliente;
        private System.Windows.Forms.Label clienteIdLbl;
        private System.Windows.Forms.TextBox clienteIdTxt;
        private System.Windows.Forms.Button ayudaBtn;
    }
}