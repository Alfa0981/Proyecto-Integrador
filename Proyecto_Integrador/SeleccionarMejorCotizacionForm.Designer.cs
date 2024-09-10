namespace Proyecto_Integrador
{
    partial class SeleccionarMejorCotizacionForm
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
            this.valorFiltroLbl = new System.Windows.Forms.Label();
            this.tipoFiltroLbl = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.filtrarBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.seleccionarBtn = new System.Windows.Forms.Button();
            this.cantLbl = new System.Windows.Forms.Label();
            this.cantNumeric = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cantNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // valorFiltroLbl
            // 
            this.valorFiltroLbl.AutoSize = true;
            this.valorFiltroLbl.Location = new System.Drawing.Point(223, 18);
            this.valorFiltroLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valorFiltroLbl.Name = "valorFiltroLbl";
            this.valorFiltroLbl.Size = new System.Drawing.Size(31, 13);
            this.valorFiltroLbl.TabIndex = 83;
            this.valorFiltroLbl.Text = "Valor";
            // 
            // tipoFiltroLbl
            // 
            this.tipoFiltroLbl.AutoSize = true;
            this.tipoFiltroLbl.Location = new System.Drawing.Point(50, 18);
            this.tipoFiltroLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tipoFiltroLbl.Name = "tipoFiltroLbl";
            this.tipoFiltroLbl.Size = new System.Drawing.Size(47, 13);
            this.tipoFiltroLbl.TabIndex = 82;
            this.tipoFiltroLbl.Text = "Filtar por";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(184, 40);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 25);
            this.comboBox2.TabIndex = 81;
            // 
            // filtrarBtn
            // 
            this.filtrarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.filtrarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.filtrarBtn.FlatAppearance.BorderSize = 0;
            this.filtrarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.filtrarBtn.Location = new System.Drawing.Point(337, 27);
            this.filtrarBtn.Name = "filtrarBtn";
            this.filtrarBtn.Size = new System.Drawing.Size(71, 38);
            this.filtrarBtn.TabIndex = 80;
            this.filtrarBtn.Text = "Filtrar";
            this.filtrarBtn.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(23, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 25);
            this.comboBox1.TabIndex = 79;
            // 
            // seleccionarBtn
            // 
            this.seleccionarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.seleccionarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.seleccionarBtn.FlatAppearance.BorderSize = 0;
            this.seleccionarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seleccionarBtn.Location = new System.Drawing.Point(656, 183);
            this.seleccionarBtn.Name = "seleccionarBtn";
            this.seleccionarBtn.Size = new System.Drawing.Size(71, 38);
            this.seleccionarBtn.TabIndex = 75;
            this.seleccionarBtn.Text = "Seleccionar";
            this.seleccionarBtn.UseVisualStyleBackColor = false;
            // 
            // cantLbl
            // 
            this.cantLbl.AutoSize = true;
            this.cantLbl.Location = new System.Drawing.Point(630, 114);
            this.cantLbl.Name = "cantLbl";
            this.cantLbl.Size = new System.Drawing.Size(49, 13);
            this.cantLbl.TabIndex = 74;
            this.cantLbl.Text = "Cantidad";
            // 
            // cantNumeric
            // 
            this.cantNumeric.Location = new System.Drawing.Point(630, 141);
            this.cantNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cantNumeric.Name = "cantNumeric";
            this.cantNumeric.Size = new System.Drawing.Size(120, 20);
            this.cantNumeric.TabIndex = 73;
            this.cantNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.Location = new System.Drawing.Point(23, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(592, 150);
            this.dataGridView1.TabIndex = 70;
            // 
            // SeleccionarMejorCotizacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(802, 342);
            this.Controls.Add(this.valorFiltroLbl);
            this.Controls.Add(this.tipoFiltroLbl);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.filtrarBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.seleccionarBtn);
            this.Controls.Add(this.cantLbl);
            this.Controls.Add(this.cantNumeric);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SeleccionarMejorCotizacionForm";
            this.Text = "SeleccionarMejorCotizacionForm";
            ((System.ComponentModel.ISupportInitialize)(this.cantNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label valorFiltroLbl;
        private System.Windows.Forms.Label tipoFiltroLbl;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button filtrarBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button seleccionarBtn;
        private System.Windows.Forms.Label cantLbl;
        private System.Windows.Forms.NumericUpDown cantNumeric;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}