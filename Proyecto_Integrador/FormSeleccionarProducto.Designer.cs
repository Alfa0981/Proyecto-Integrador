namespace Proyecto_Integrador
{
    partial class FormSeleccionarProducto
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.seleccionarBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.generarCarritoBtn = new System.Windows.Forms.Button();
            this.cantNumeric = new System.Windows.Forms.NumericUpDown();
            this.cantLbl = new System.Windows.Forms.Label();
            this.ayudaBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 153);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(999, 766);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // seleccionarBtn
            // 
            this.seleccionarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.seleccionarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.seleccionarBtn.FlatAppearance.BorderSize = 0;
            this.seleccionarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seleccionarBtn.Location = new System.Drawing.Point(169, 969);
            this.seleccionarBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.seleccionarBtn.Name = "seleccionarBtn";
            this.seleccionarBtn.Size = new System.Drawing.Size(136, 81);
            this.seleccionarBtn.TabIndex = 2;
            this.seleccionarBtn.Text = "Añadir al Carrito";
            this.seleccionarBtn.UseVisualStyleBackColor = false;
            this.seleccionarBtn.Click += new System.EventHandler(this.seleccionarBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Productos";
            // 
            // generarCarritoBtn
            // 
            this.generarCarritoBtn.BackColor = System.Drawing.Color.IndianRed;
            this.generarCarritoBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.generarCarritoBtn.FlatAppearance.BorderSize = 0;
            this.generarCarritoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generarCarritoBtn.Location = new System.Drawing.Point(524, 969);
            this.generarCarritoBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.generarCarritoBtn.Name = "generarCarritoBtn";
            this.generarCarritoBtn.Size = new System.Drawing.Size(148, 81);
            this.generarCarritoBtn.TabIndex = 7;
            this.generarCarritoBtn.Text = "Ir al Carrito";
            this.generarCarritoBtn.UseVisualStyleBackColor = false;
            this.generarCarritoBtn.Click += new System.EventHandler(this.generarCarritoBtn_Click);
            // 
            // cantNumeric
            // 
            this.cantNumeric.Location = new System.Drawing.Point(1038, 439);
            this.cantNumeric.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cantNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cantNumeric.Name = "cantNumeric";
            this.cantNumeric.Size = new System.Drawing.Size(220, 29);
            this.cantNumeric.TabIndex = 9;
            this.cantNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cantLbl
            // 
            this.cantLbl.AutoSize = true;
            this.cantLbl.Location = new System.Drawing.Point(1038, 390);
            this.cantLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cantLbl.Name = "cantLbl";
            this.cantLbl.Size = new System.Drawing.Size(91, 25);
            this.cantLbl.TabIndex = 10;
            this.cantLbl.Text = "Cantidad";
            // 
            // ayudaBtn
            // 
            this.ayudaBtn.BackColor = System.Drawing.Color.IndianRed;
            this.ayudaBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.ayudaBtn.FlatAppearance.BorderSize = 0;
            this.ayudaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ayudaBtn.Location = new System.Drawing.Point(897, 66);
            this.ayudaBtn.Margin = new System.Windows.Forms.Padding(6);
            this.ayudaBtn.Name = "ayudaBtn";
            this.ayudaBtn.Size = new System.Drawing.Size(130, 72);
            this.ayudaBtn.TabIndex = 55;
            this.ayudaBtn.Text = "Ayuda";
            this.ayudaBtn.UseVisualStyleBackColor = false;
            this.ayudaBtn.Click += new System.EventHandler(this.ayudaBtn_Click);
            // 
            // FormSeleccionarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1320, 1073);
            this.Controls.Add(this.ayudaBtn);
            this.Controls.Add(this.cantLbl);
            this.Controls.Add(this.cantNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.generarCarritoBtn);
            this.Controls.Add(this.seleccionarBtn);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormSeleccionarProducto";
            this.Text = "FormSeleccionarProducto";
            this.Load += new System.EventHandler(this.FormSeleccionarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button seleccionarBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generarCarritoBtn;
        private System.Windows.Forms.NumericUpDown cantNumeric;
        private System.Windows.Forms.Label cantLbl;
        private System.Windows.Forms.Button ayudaBtn;
    }
}