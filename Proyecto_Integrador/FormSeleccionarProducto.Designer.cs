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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(545, 415);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.generarCarritoBtn.Click += new System.EventHandler(this.generarCarritoBtn_Click);
            // 
            // cantNumeric
            // 
            this.cantNumeric.Location = new System.Drawing.Point(566, 238);
            this.cantNumeric.Name = "cantNumeric";
            this.cantNumeric.Size = new System.Drawing.Size(120, 20);
            this.cantNumeric.TabIndex = 9;
            // 
            // cantLbl
            // 
            this.cantLbl.AutoSize = true;
            this.cantLbl.Location = new System.Drawing.Point(566, 211);
            this.cantLbl.Name = "cantLbl";
            this.cantLbl.Size = new System.Drawing.Size(49, 13);
            this.cantLbl.TabIndex = 10;
            this.cantLbl.Text = "Cantidad";
            // 
            // FormSeleccionarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(720, 581);
            this.Controls.Add(this.cantLbl);
            this.Controls.Add(this.cantNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.generarCarritoBtn);
            this.Controls.Add(this.seleccionarBtn);
            this.Controls.Add(this.dataGridView1);
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
    }
}