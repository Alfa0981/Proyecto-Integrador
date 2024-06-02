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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seleccionarBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.generarCarritoBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(15, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 415);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Producto";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Precio";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fecha expiracion";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Stock";
            this.Column4.Name = "Column4";
            // 
            // seleccionarBtn
            // 
            this.seleccionarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.seleccionarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.seleccionarBtn.FlatAppearance.BorderSize = 0;
            this.seleccionarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seleccionarBtn.Location = new System.Drawing.Point(92, 525);
            this.seleccionarBtn.Name = "seleccionarBtn";
            this.seleccionarBtn.Size = new System.Drawing.Size(74, 44);
            this.seleccionarBtn.TabIndex = 2;
            this.seleccionarBtn.Text = "Añadir al Carrito";
            this.seleccionarBtn.UseVisualStyleBackColor = false;
            this.seleccionarBtn.Click += new System.EventHandler(this.seleccionarBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Productos";
            // 
            // generarCarritoBtn
            // 
            this.generarCarritoBtn.BackColor = System.Drawing.Color.IndianRed;
            this.generarCarritoBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.generarCarritoBtn.FlatAppearance.BorderSize = 0;
            this.generarCarritoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generarCarritoBtn.Location = new System.Drawing.Point(286, 525);
            this.generarCarritoBtn.Name = "generarCarritoBtn";
            this.generarCarritoBtn.Size = new System.Drawing.Size(81, 44);
            this.generarCarritoBtn.TabIndex = 7;
            this.generarCarritoBtn.Text = "Ir al Carrito";
            this.generarCarritoBtn.UseVisualStyleBackColor = false;
            // 
            // FormSeleccionarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(585, 581);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.generarCarritoBtn);
            this.Controls.Add(this.seleccionarBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormSeleccionarProducto";
            this.Text = "FormSeleccionarProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button seleccionarBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generarCarritoBtn;
    }
}