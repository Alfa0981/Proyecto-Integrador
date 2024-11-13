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
            this.productosDataGrid = new System.Windows.Forms.DataGridView();
            this.todosPerfilesLbl = new System.Windows.Forms.Label();
            this.seleccionarBtn = new System.Windows.Forms.Button();
            this.notificarBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.registrarProveedoresBtn = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ayudaBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // productosDataGrid
            // 
            this.productosDataGrid.AllowUserToAddRows = false;
            this.productosDataGrid.AllowUserToDeleteRows = false;
            this.productosDataGrid.BackgroundColor = System.Drawing.Color.MistyRose;
            this.productosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productosDataGrid.GridColor = System.Drawing.SystemColors.ControlText;
            this.productosDataGrid.Location = new System.Drawing.Point(31, 96);
            this.productosDataGrid.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.productosDataGrid.Name = "productosDataGrid";
            this.productosDataGrid.ReadOnly = true;
            this.productosDataGrid.RowHeadersWidth = 72;
            this.productosDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productosDataGrid.Size = new System.Drawing.Size(730, 277);
            this.productosDataGrid.TabIndex = 23;
            this.productosDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.proveedoresDataGrid_CellClick);
            // 
            // todosPerfilesLbl
            // 
            this.todosPerfilesLbl.AutoSize = true;
            this.todosPerfilesLbl.Location = new System.Drawing.Point(26, 42);
            this.todosPerfilesLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.todosPerfilesLbl.Name = "todosPerfilesLbl";
            this.todosPerfilesLbl.Size = new System.Drawing.Size(100, 25);
            this.todosPerfilesLbl.TabIndex = 47;
            this.todosPerfilesLbl.Text = "Productos";
            // 
            // seleccionarBtn
            // 
            this.seleccionarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.seleccionarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.seleccionarBtn.FlatAppearance.BorderSize = 0;
            this.seleccionarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seleccionarBtn.Location = new System.Drawing.Point(33, 384);
            this.seleccionarBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.seleccionarBtn.Name = "seleccionarBtn";
            this.seleccionarBtn.Size = new System.Drawing.Size(130, 70);
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
            this.notificarBtn.Location = new System.Drawing.Point(176, 825);
            this.notificarBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.notificarBtn.Name = "notificarBtn";
            this.notificarBtn.Size = new System.Drawing.Size(130, 70);
            this.notificarBtn.TabIndex = 54;
            this.notificarBtn.Text = "Notificar";
            this.notificarBtn.UseVisualStyleBackColor = false;
            this.notificarBtn.Click += new System.EventHandler(this.notificarBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(35, 825);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 70);
            this.button2.TabIndex = 53;
            this.button2.Text = "Remover";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // registrarProveedoresBtn
            // 
            this.registrarProveedoresBtn.BackColor = System.Drawing.Color.IndianRed;
            this.registrarProveedoresBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.registrarProveedoresBtn.FlatAppearance.BorderSize = 0;
            this.registrarProveedoresBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registrarProveedoresBtn.Location = new System.Drawing.Point(631, 384);
            this.registrarProveedoresBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.registrarProveedoresBtn.Name = "registrarProveedoresBtn";
            this.registrarProveedoresBtn.Size = new System.Drawing.Size(130, 70);
            this.registrarProveedoresBtn.TabIndex = 56;
            this.registrarProveedoresBtn.Text = "Registrar Proveedor";
            this.registrarProveedoresBtn.UseVisualStyleBackColor = false;
            this.registrarProveedoresBtn.Click += new System.EventHandler(this.registrarProveedoresBtn_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(896, 96);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(508, 238);
            this.checkedListBox1.TabIndex = 58;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(31, 519);
            this.listBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(508, 292);
            this.listBox1.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(891, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 25);
            this.label2.TabIndex = 61;
            this.label2.Text = "Proveedores del Producto";
            // 
            // ayudaBtn
            // 
            this.ayudaBtn.BackColor = System.Drawing.Color.IndianRed;
            this.ayudaBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.ayudaBtn.FlatAppearance.BorderSize = 0;
            this.ayudaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ayudaBtn.Location = new System.Drawing.Point(1274, 741);
            this.ayudaBtn.Margin = new System.Windows.Forms.Padding(6);
            this.ayudaBtn.Name = "ayudaBtn";
            this.ayudaBtn.Size = new System.Drawing.Size(130, 70);
            this.ayudaBtn.TabIndex = 62;
            this.ayudaBtn.Text = "Ayuda";
            this.ayudaBtn.UseVisualStyleBackColor = false;
            this.ayudaBtn.Click += new System.EventHandler(this.ayudaBtn_Click);
            // 
            // PedidoCotizacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1467, 977);
            this.Controls.Add(this.ayudaBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.registrarProveedoresBtn);
            this.Controls.Add(this.notificarBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.seleccionarBtn);
            this.Controls.Add(this.todosPerfilesLbl);
            this.Controls.Add(this.productosDataGrid);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "PedidoCotizacionForm";
            this.Text = "PedidoCotizacionForm";
            ((System.ComponentModel.ISupportInitialize)(this.productosDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productosDataGrid;
        private System.Windows.Forms.Label todosPerfilesLbl;
        private System.Windows.Forms.Button seleccionarBtn;
        private System.Windows.Forms.Button notificarBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button registrarProveedoresBtn;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ayudaBtn;
    }
}