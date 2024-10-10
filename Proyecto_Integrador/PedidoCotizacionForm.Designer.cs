namespace Proyecto_Integrador
{
    partial class PedidoCotizacionForm
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
            this.proveedoresDataGrid = new System.Windows.Forms.DataGridView();
            this.todosPerfilesLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productosCombo = new System.Windows.Forms.ComboBox();
            this.seleccionarTodosBtn = new System.Windows.Forms.Button();
            this.seleccionarBtn = new System.Windows.Forms.Button();
            this.notificarBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ProveedoresSelectedDataGrid = new System.Windows.Forms.DataGridView();
            this.registrarProveedoresBtn = new System.Windows.Forms.Button();
            this.limpiarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresSelectedDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // proveedoresDataGrid
            // 
            this.proveedoresDataGrid.AllowUserToAddRows = false;
            this.proveedoresDataGrid.AllowUserToDeleteRows = false;
            this.proveedoresDataGrid.BackgroundColor = System.Drawing.Color.MistyRose;
            this.proveedoresDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proveedoresDataGrid.GridColor = System.Drawing.SystemColors.ControlText;
            this.proveedoresDataGrid.Location = new System.Drawing.Point(24, 121);
            this.proveedoresDataGrid.Name = "proveedoresDataGrid";
            this.proveedoresDataGrid.ReadOnly = true;
            this.proveedoresDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.proveedoresDataGrid.Size = new System.Drawing.Size(741, 150);
            this.proveedoresDataGrid.TabIndex = 23;
            // 
            // todosPerfilesLbl
            // 
            this.todosPerfilesLbl.AutoSize = true;
            this.todosPerfilesLbl.Location = new System.Drawing.Point(21, 92);
            this.todosPerfilesLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.todosPerfilesLbl.Name = "todosPerfilesLbl";
            this.todosPerfilesLbl.Size = new System.Drawing.Size(67, 13);
            this.todosPerfilesLbl.TabIndex = 47;
            this.todosPerfilesLbl.Text = "Proveedores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Producto Id";
            // 
            // productosCombo
            // 
            this.productosCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.productosCombo.FormattingEnabled = true;
            this.productosCombo.Location = new System.Drawing.Point(88, 24);
            this.productosCombo.Name = "productosCombo";
            this.productosCombo.Size = new System.Drawing.Size(121, 25);
            this.productosCombo.TabIndex = 48;
            // 
            // seleccionarTodosBtn
            // 
            this.seleccionarTodosBtn.BackColor = System.Drawing.Color.IndianRed;
            this.seleccionarTodosBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.seleccionarTodosBtn.FlatAppearance.BorderSize = 0;
            this.seleccionarTodosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seleccionarTodosBtn.Location = new System.Drawing.Point(694, 277);
            this.seleccionarTodosBtn.Name = "seleccionarTodosBtn";
            this.seleccionarTodosBtn.Size = new System.Drawing.Size(71, 38);
            this.seleccionarTodosBtn.TabIndex = 52;
            this.seleccionarTodosBtn.Text = "Seleccionar Todos";
            this.seleccionarTodosBtn.UseVisualStyleBackColor = false;
            // 
            // seleccionarBtn
            // 
            this.seleccionarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.seleccionarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.seleccionarBtn.FlatAppearance.BorderSize = 0;
            this.seleccionarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seleccionarBtn.Location = new System.Drawing.Point(617, 277);
            this.seleccionarBtn.Name = "seleccionarBtn";
            this.seleccionarBtn.Size = new System.Drawing.Size(71, 38);
            this.seleccionarBtn.TabIndex = 51;
            this.seleccionarBtn.Text = "Seleccionar";
            this.seleccionarBtn.UseVisualStyleBackColor = false;
            this.seleccionarBtn.Click += new System.EventHandler(this.seleccionarBtn_Click);
            // 
            // notificarBtn
            // 
            this.notificarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.notificarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.notificarBtn.FlatAppearance.BorderSize = 0;
            this.notificarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.notificarBtn.Location = new System.Drawing.Point(694, 506);
            this.notificarBtn.Name = "notificarBtn";
            this.notificarBtn.Size = new System.Drawing.Size(71, 38);
            this.notificarBtn.TabIndex = 54;
            this.notificarBtn.Text = "Notificar";
            this.notificarBtn.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(617, 506);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 38);
            this.button2.TabIndex = 53;
            this.button2.Text = "Remover";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // ProveedoresSelectedDataGrid
            // 
            this.ProveedoresSelectedDataGrid.AllowUserToAddRows = false;
            this.ProveedoresSelectedDataGrid.AllowUserToDeleteRows = false;
            this.ProveedoresSelectedDataGrid.BackgroundColor = System.Drawing.Color.MistyRose;
            this.ProveedoresSelectedDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProveedoresSelectedDataGrid.GridColor = System.Drawing.SystemColors.ControlText;
            this.ProveedoresSelectedDataGrid.Location = new System.Drawing.Point(25, 350);
            this.ProveedoresSelectedDataGrid.Name = "ProveedoresSelectedDataGrid";
            this.ProveedoresSelectedDataGrid.ReadOnly = true;
            this.ProveedoresSelectedDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProveedoresSelectedDataGrid.Size = new System.Drawing.Size(741, 150);
            this.ProveedoresSelectedDataGrid.TabIndex = 55;
            // 
            // registrarProveedoresBtn
            // 
            this.registrarProveedoresBtn.BackColor = System.Drawing.Color.IndianRed;
            this.registrarProveedoresBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.registrarProveedoresBtn.FlatAppearance.BorderSize = 0;
            this.registrarProveedoresBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registrarProveedoresBtn.Location = new System.Drawing.Point(694, 77);
            this.registrarProveedoresBtn.Name = "registrarProveedoresBtn";
            this.registrarProveedoresBtn.Size = new System.Drawing.Size(71, 38);
            this.registrarProveedoresBtn.TabIndex = 56;
            this.registrarProveedoresBtn.Text = "Registrar Proveedor";
            this.registrarProveedoresBtn.UseVisualStyleBackColor = false;
            this.registrarProveedoresBtn.Click += new System.EventHandler(this.registrarProveedoresBtn_Click);
            // 
            // limpiarBtn
            // 
            this.limpiarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.limpiarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.limpiarBtn.FlatAppearance.BorderSize = 0;
            this.limpiarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.limpiarBtn.Location = new System.Drawing.Point(239, 17);
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(71, 38);
            this.limpiarBtn.TabIndex = 57;
            this.limpiarBtn.Text = "Limpiar Filtro";
            this.limpiarBtn.UseVisualStyleBackColor = false;
            this.limpiarBtn.Click += new System.EventHandler(this.limpiarBtn_Click);
            // 
            // PedidoCotizacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(800, 599);
            this.Controls.Add(this.limpiarBtn);
            this.Controls.Add(this.registrarProveedoresBtn);
            this.Controls.Add(this.ProveedoresSelectedDataGrid);
            this.Controls.Add(this.notificarBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.seleccionarTodosBtn);
            this.Controls.Add(this.seleccionarBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productosCombo);
            this.Controls.Add(this.todosPerfilesLbl);
            this.Controls.Add(this.proveedoresDataGrid);
            this.Name = "PedidoCotizacionForm";
            this.Text = "PedidoCotizacionForm";
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresSelectedDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView proveedoresDataGrid;
        private System.Windows.Forms.Label todosPerfilesLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox productosCombo;
        private System.Windows.Forms.Button seleccionarTodosBtn;
        private System.Windows.Forms.Button seleccionarBtn;
        private System.Windows.Forms.Button notificarBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView ProveedoresSelectedDataGrid;
        private System.Windows.Forms.Button registrarProveedoresBtn;
        private System.Windows.Forms.Button limpiarBtn;
    }
}