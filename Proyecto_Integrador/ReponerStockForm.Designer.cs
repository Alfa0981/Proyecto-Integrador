namespace Proyecto_Integrador
{
    partial class ReponerStockForm
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
            this.ordenCompraLbl = new System.Windows.Forms.Label();
            this.ordenCompraTxt = new System.Windows.Forms.TextBox();
            this.productosDataGrid = new System.Windows.Forms.DataGridView();
            this.todosPerfilesLbl = new System.Windows.Forms.Label();
            this.productosAprobadosDataGrid = new System.Windows.Forms.DataGridView();
            this.productosDesaprobadosDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aprobarBtn = new System.Windows.Forms.Button();
            this.desaprobarBtn = new System.Windows.Forms.Button();
            this.finalizarBtn = new System.Windows.Forms.Button();
            this.cantidadNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.buscsarBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.proveedorLbl = new System.Windows.Forms.Label();
            this.ayudaBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosAprobadosDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosDesaprobadosDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // ordenCompraLbl
            // 
            this.ordenCompraLbl.AutoSize = true;
            this.ordenCompraLbl.BackColor = System.Drawing.Color.Snow;
            this.ordenCompraLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ordenCompraLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.ordenCompraLbl.Location = new System.Drawing.Point(977, 65);
            this.ordenCompraLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ordenCompraLbl.Name = "ordenCompraLbl";
            this.ordenCompraLbl.Size = new System.Drawing.Size(218, 29);
            this.ordenCompraLbl.TabIndex = 42;
            this.ordenCompraLbl.Text = "Codigo de Compra";
            // 
            // ordenCompraTxt
            // 
            this.ordenCompraTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ordenCompraTxt.Location = new System.Drawing.Point(966, 52);
            this.ordenCompraTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ordenCompraTxt.Multiline = true;
            this.ordenCompraTxt.Name = "ordenCompraTxt";
            this.ordenCompraTxt.Size = new System.Drawing.Size(292, 56);
            this.ordenCompraTxt.TabIndex = 43;
            this.ordenCompraTxt.Enter += new System.EventHandler(this.ordenCompraTxt_Enter);
            this.ordenCompraTxt.Leave += new System.EventHandler(this.ordenCompraTxt_Leave);
            // 
            // productosDataGrid
            // 
            this.productosDataGrid.AllowUserToAddRows = false;
            this.productosDataGrid.AllowUserToDeleteRows = false;
            this.productosDataGrid.BackgroundColor = System.Drawing.Color.MistyRose;
            this.productosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productosDataGrid.GridColor = System.Drawing.SystemColors.ControlText;
            this.productosDataGrid.Location = new System.Drawing.Point(433, 233);
            this.productosDataGrid.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.productosDataGrid.Name = "productosDataGrid";
            this.productosDataGrid.ReadOnly = true;
            this.productosDataGrid.RowHeadersWidth = 72;
            this.productosDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productosDataGrid.Size = new System.Drawing.Size(653, 277);
            this.productosDataGrid.TabIndex = 44;
            // 
            // todosPerfilesLbl
            // 
            this.todosPerfilesLbl.AutoSize = true;
            this.todosPerfilesLbl.Location = new System.Drawing.Point(427, 185);
            this.todosPerfilesLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.todosPerfilesLbl.Name = "todosPerfilesLbl";
            this.todosPerfilesLbl.Size = new System.Drawing.Size(100, 25);
            this.todosPerfilesLbl.TabIndex = 48;
            this.todosPerfilesLbl.Text = "Productos";
            // 
            // productosAprobadosDataGrid
            // 
            this.productosAprobadosDataGrid.AllowUserToAddRows = false;
            this.productosAprobadosDataGrid.AllowUserToDeleteRows = false;
            this.productosAprobadosDataGrid.BackgroundColor = System.Drawing.Color.MistyRose;
            this.productosAprobadosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productosAprobadosDataGrid.GridColor = System.Drawing.SystemColors.ControlText;
            this.productosAprobadosDataGrid.Location = new System.Drawing.Point(68, 834);
            this.productosAprobadosDataGrid.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.productosAprobadosDataGrid.Name = "productosAprobadosDataGrid";
            this.productosAprobadosDataGrid.ReadOnly = true;
            this.productosAprobadosDataGrid.RowHeadersWidth = 72;
            this.productosAprobadosDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productosAprobadosDataGrid.Size = new System.Drawing.Size(653, 277);
            this.productosAprobadosDataGrid.TabIndex = 51;
            // 
            // productosDesaprobadosDataGrid
            // 
            this.productosDesaprobadosDataGrid.AllowUserToAddRows = false;
            this.productosDesaprobadosDataGrid.AllowUserToDeleteRows = false;
            this.productosDesaprobadosDataGrid.BackgroundColor = System.Drawing.Color.MistyRose;
            this.productosDesaprobadosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productosDesaprobadosDataGrid.GridColor = System.Drawing.SystemColors.ControlText;
            this.productosDesaprobadosDataGrid.Location = new System.Drawing.Point(774, 834);
            this.productosDesaprobadosDataGrid.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.productosDesaprobadosDataGrid.Name = "productosDesaprobadosDataGrid";
            this.productosDesaprobadosDataGrid.ReadOnly = true;
            this.productosDesaprobadosDataGrid.RowHeadersWidth = 72;
            this.productosDesaprobadosDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productosDesaprobadosDataGrid.Size = new System.Drawing.Size(653, 277);
            this.productosDesaprobadosDataGrid.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 786);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 53;
            this.label1.Text = "Aprobados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(768, 786);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 54;
            this.label2.Text = "Desaprobados";
            // 
            // aprobarBtn
            // 
            this.aprobarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.aprobarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.aprobarBtn.FlatAppearance.BorderSize = 0;
            this.aprobarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aprobarBtn.Location = new System.Drawing.Point(622, 624);
            this.aprobarBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.aprobarBtn.Name = "aprobarBtn";
            this.aprobarBtn.Size = new System.Drawing.Size(130, 70);
            this.aprobarBtn.TabIndex = 57;
            this.aprobarBtn.Text = "Aprobar";
            this.aprobarBtn.UseVisualStyleBackColor = false;
            this.aprobarBtn.Click += new System.EventHandler(this.aprobarBtn_Click);
            // 
            // desaprobarBtn
            // 
            this.desaprobarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.desaprobarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.desaprobarBtn.FlatAppearance.BorderSize = 0;
            this.desaprobarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.desaprobarBtn.Location = new System.Drawing.Point(763, 624);
            this.desaprobarBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.desaprobarBtn.Name = "desaprobarBtn";
            this.desaprobarBtn.Size = new System.Drawing.Size(130, 70);
            this.desaprobarBtn.TabIndex = 58;
            this.desaprobarBtn.Text = "Desaprobar";
            this.desaprobarBtn.UseVisualStyleBackColor = false;
            this.desaprobarBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // finalizarBtn
            // 
            this.finalizarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.finalizarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.finalizarBtn.FlatAppearance.BorderSize = 0;
            this.finalizarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.finalizarBtn.Location = new System.Drawing.Point(689, 1150);
            this.finalizarBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.finalizarBtn.Name = "finalizarBtn";
            this.finalizarBtn.Size = new System.Drawing.Size(130, 70);
            this.finalizarBtn.TabIndex = 59;
            this.finalizarBtn.Text = "Finalizar";
            this.finalizarBtn.UseVisualStyleBackColor = false;
            this.finalizarBtn.Click += new System.EventHandler(this.finalizarBtn_Click);
            // 
            // cantidadNumeric
            // 
            this.cantidadNumeric.Location = new System.Drawing.Point(431, 554);
            this.cantidadNumeric.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cantidadNumeric.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.cantidadNumeric.Name = "cantidadNumeric";
            this.cantidadNumeric.Size = new System.Drawing.Size(220, 29);
            this.cantidadNumeric.TabIndex = 60;
            this.cantidadNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 522);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 25);
            this.label3.TabIndex = 61;
            this.label3.Text = "Cantidad a Aprobar/Desaprobar";
            // 
            // buscsarBtn
            // 
            this.buscsarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.buscsarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.buscsarBtn.FlatAppearance.BorderSize = 0;
            this.buscsarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buscsarBtn.Location = new System.Drawing.Point(1296, 46);
            this.buscsarBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buscsarBtn.Name = "buscsarBtn";
            this.buscsarBtn.Size = new System.Drawing.Size(130, 70);
            this.buscsarBtn.TabIndex = 62;
            this.buscsarBtn.Text = "Buscar";
            this.buscsarBtn.UseVisualStyleBackColor = false;
            this.buscsarBtn.Click += new System.EventHandler(this.buscsarBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(880, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 63;
            this.label4.Text = "Proveedor: ";
            // 
            // proveedorLbl
            // 
            this.proveedorLbl.AutoSize = true;
            this.proveedorLbl.Location = new System.Drawing.Point(994, 185);
            this.proveedorLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.proveedorLbl.Name = "proveedorLbl";
            this.proveedorLbl.Size = new System.Drawing.Size(0, 25);
            this.proveedorLbl.TabIndex = 64;
            // 
            // ayudaBtn
            // 
            this.ayudaBtn.BackColor = System.Drawing.Color.IndianRed;
            this.ayudaBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.ayudaBtn.FlatAppearance.BorderSize = 0;
            this.ayudaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ayudaBtn.Location = new System.Drawing.Point(68, 46);
            this.ayudaBtn.Margin = new System.Windows.Forms.Padding(6);
            this.ayudaBtn.Name = "ayudaBtn";
            this.ayudaBtn.Size = new System.Drawing.Size(130, 70);
            this.ayudaBtn.TabIndex = 65;
            this.ayudaBtn.Text = "Ayuda";
            this.ayudaBtn.UseVisualStyleBackColor = false;
            this.ayudaBtn.Click += new System.EventHandler(this.ayudaBtn_Click);
            // 
            // ReponerStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1577, 1285);
            this.Controls.Add(this.ayudaBtn);
            this.Controls.Add(this.proveedorLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buscsarBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cantidadNumeric);
            this.Controls.Add(this.finalizarBtn);
            this.Controls.Add(this.desaprobarBtn);
            this.Controls.Add(this.aprobarBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productosDesaprobadosDataGrid);
            this.Controls.Add(this.productosAprobadosDataGrid);
            this.Controls.Add(this.todosPerfilesLbl);
            this.Controls.Add(this.productosDataGrid);
            this.Controls.Add(this.ordenCompraLbl);
            this.Controls.Add(this.ordenCompraTxt);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ReponerStockForm";
            this.Text = "ReponerStockForm";
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosAprobadosDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosDesaprobadosDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ordenCompraLbl;
        private System.Windows.Forms.TextBox ordenCompraTxt;
        private System.Windows.Forms.DataGridView productosDataGrid;
        private System.Windows.Forms.Label todosPerfilesLbl;
        private System.Windows.Forms.DataGridView productosAprobadosDataGrid;
        private System.Windows.Forms.DataGridView productosDesaprobadosDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button aprobarBtn;
        private System.Windows.Forms.Button desaprobarBtn;
        private System.Windows.Forms.Button finalizarBtn;
        private System.Windows.Forms.NumericUpDown cantidadNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buscsarBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label proveedorLbl;
        private System.Windows.Forms.Button ayudaBtn;
    }
}