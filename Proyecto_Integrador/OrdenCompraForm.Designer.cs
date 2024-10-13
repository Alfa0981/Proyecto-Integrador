namespace Proyecto_Integrador
{
    partial class OrdenCompraForm
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
            this.pagarProveedorBtn = new System.Windows.Forms.Button();
            this.removerBtn = new System.Windows.Forms.Button();
            this.productosDataGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.productosSeleccionadosDataGrid = new System.Windows.Forms.DataGridView();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.proveedorCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.precioUnitarioNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosSeleccionadosDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioUnitarioNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // pagarProveedorBtn
            // 
            this.pagarProveedorBtn.BackColor = System.Drawing.Color.IndianRed;
            this.pagarProveedorBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.pagarProveedorBtn.FlatAppearance.BorderSize = 0;
            this.pagarProveedorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pagarProveedorBtn.Location = new System.Drawing.Point(404, 464);
            this.pagarProveedorBtn.Name = "pagarProveedorBtn";
            this.pagarProveedorBtn.Size = new System.Drawing.Size(71, 38);
            this.pagarProveedorBtn.TabIndex = 57;
            this.pagarProveedorBtn.Text = "Pagar Proveedor";
            this.pagarProveedorBtn.UseVisualStyleBackColor = false;
            this.pagarProveedorBtn.Click += new System.EventHandler(this.notificarBtn_Click);
            // 
            // removerBtn
            // 
            this.removerBtn.BackColor = System.Drawing.Color.IndianRed;
            this.removerBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.removerBtn.FlatAppearance.BorderSize = 0;
            this.removerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removerBtn.Location = new System.Drawing.Point(327, 464);
            this.removerBtn.Name = "removerBtn";
            this.removerBtn.Size = new System.Drawing.Size(71, 38);
            this.removerBtn.TabIndex = 56;
            this.removerBtn.Text = "Remover";
            this.removerBtn.UseVisualStyleBackColor = false;
            this.removerBtn.Click += new System.EventHandler(this.removerBtn_Click);
            // 
            // productosDataGrid
            // 
            this.productosDataGrid.AllowUserToAddRows = false;
            this.productosDataGrid.AllowUserToDeleteRows = false;
            this.productosDataGrid.BackgroundColor = System.Drawing.Color.MistyRose;
            this.productosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productosDataGrid.GridColor = System.Drawing.SystemColors.ControlText;
            this.productosDataGrid.Location = new System.Drawing.Point(29, 26);
            this.productosDataGrid.Name = "productosDataGrid";
            this.productosDataGrid.ReadOnly = true;
            this.productosDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productosDataGrid.Size = new System.Drawing.Size(268, 276);
            this.productosDataGrid.TabIndex = 64;
            this.productosDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productosDataGrid_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(405, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 38);
            this.button1.TabIndex = 82;
            this.button1.Text = "Agregar Producto";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // productosSeleccionadosDataGrid
            // 
            this.productosSeleccionadosDataGrid.AllowUserToAddRows = false;
            this.productosSeleccionadosDataGrid.AllowUserToDeleteRows = false;
            this.productosSeleccionadosDataGrid.BackgroundColor = System.Drawing.Color.MistyRose;
            this.productosSeleccionadosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productosSeleccionadosDataGrid.GridColor = System.Drawing.SystemColors.ControlText;
            this.productosSeleccionadosDataGrid.Location = new System.Drawing.Point(29, 308);
            this.productosSeleccionadosDataGrid.Name = "productosSeleccionadosDataGrid";
            this.productosSeleccionadosDataGrid.ReadOnly = true;
            this.productosSeleccionadosDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productosSeleccionadosDataGrid.Size = new System.Drawing.Size(446, 150);
            this.productosSeleccionadosDataGrid.TabIndex = 83;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(405, 151);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 84;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 100);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 85;
            this.label6.Text = "Precio Unitario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 86;
            this.label1.Text = "Cantidad:";
            // 
            // proveedorCombo
            // 
            this.proveedorCombo.FormattingEnabled = true;
            this.proveedorCombo.Location = new System.Drawing.Point(404, 26);
            this.proveedorCombo.Name = "proveedorCombo";
            this.proveedorCombo.Size = new System.Drawing.Size(121, 21);
            this.proveedorCombo.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 88;
            this.label2.Text = "Proveedor: ";
            // 
            // precioUnitarioNumeric
            // 
            this.precioUnitarioNumeric.Location = new System.Drawing.Point(405, 98);
            this.precioUnitarioNumeric.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.precioUnitarioNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.precioUnitarioNumeric.Name = "precioUnitarioNumeric";
            this.precioUnitarioNumeric.Size = new System.Drawing.Size(120, 20);
            this.precioUnitarioNumeric.TabIndex = 89;
            this.precioUnitarioNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // OrdenCompraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(596, 559);
            this.Controls.Add(this.precioUnitarioNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.proveedorCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.productosSeleccionadosDataGrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.productosDataGrid);
            this.Controls.Add(this.pagarProveedorBtn);
            this.Controls.Add(this.removerBtn);
            this.Name = "OrdenCompraForm";
            this.Text = "OrdenCompraForm";
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosSeleccionadosDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioUnitarioNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button pagarProveedorBtn;
        private System.Windows.Forms.Button removerBtn;
        private System.Windows.Forms.DataGridView productosDataGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView productosSeleccionadosDataGrid;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox proveedorCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown precioUnitarioNumeric;
    }
}