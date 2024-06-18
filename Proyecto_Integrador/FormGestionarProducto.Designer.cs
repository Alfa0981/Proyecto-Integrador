namespace Proyecto_Integrador
{
    partial class FormGestionarProducto
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.agregarBtn = new System.Windows.Forms.Button();
            this.nombreLbl = new System.Windows.Forms.Label();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.stockLbl = new System.Windows.Forms.Label();
            this.stockTxt = new System.Windows.Forms.TextBox();
            this.precioLbl = new System.Windows.Forms.Label();
            this.precioTxt = new System.Windows.Forms.TextBox();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.modificarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(265, 68);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(350, 415);
            this.dataGridView2.TabIndex = 44;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // agregarBtn
            // 
            this.agregarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.agregarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.agregarBtn.FlatAppearance.BorderSize = 0;
            this.agregarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.agregarBtn.Location = new System.Drawing.Point(646, 68);
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Size = new System.Drawing.Size(71, 39);
            this.agregarBtn.TabIndex = 45;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = false;
            this.agregarBtn.Click += new System.EventHandler(this.agregarBtn_Click);
            // 
            // nombreLbl
            // 
            this.nombreLbl.AutoSize = true;
            this.nombreLbl.BackColor = System.Drawing.Color.Snow;
            this.nombreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.nombreLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.nombreLbl.Location = new System.Drawing.Point(56, 75);
            this.nombreLbl.Name = "nombreLbl";
            this.nombreLbl.Size = new System.Drawing.Size(58, 17);
            this.nombreLbl.TabIndex = 47;
            this.nombreLbl.Text = "Nombre";
            // 
            // nombreTxt
            // 
            this.nombreTxt.Location = new System.Drawing.Point(50, 68);
            this.nombreTxt.Multiline = true;
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(199, 31);
            this.nombreTxt.TabIndex = 46;
            this.nombreTxt.Enter += new System.EventHandler(this.nombreTxt_Enter);
            this.nombreTxt.Leave += new System.EventHandler(this.nombreTxt_Leave);
            // 
            // stockLbl
            // 
            this.stockLbl.AutoSize = true;
            this.stockLbl.BackColor = System.Drawing.Color.Snow;
            this.stockLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.stockLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.stockLbl.Location = new System.Drawing.Point(56, 177);
            this.stockLbl.Name = "stockLbl";
            this.stockLbl.Size = new System.Drawing.Size(43, 17);
            this.stockLbl.TabIndex = 49;
            this.stockLbl.Text = "Stock";
            // 
            // stockTxt
            // 
            this.stockTxt.Location = new System.Drawing.Point(50, 170);
            this.stockTxt.Multiline = true;
            this.stockTxt.Name = "stockTxt";
            this.stockTxt.Size = new System.Drawing.Size(199, 31);
            this.stockTxt.TabIndex = 48;
            this.stockTxt.Enter += new System.EventHandler(this.stockTxt_Enter);
            this.stockTxt.Leave += new System.EventHandler(this.stockTxt_Leave);
            // 
            // precioLbl
            // 
            this.precioLbl.AutoSize = true;
            this.precioLbl.BackColor = System.Drawing.Color.Snow;
            this.precioLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.precioLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.precioLbl.Location = new System.Drawing.Point(56, 124);
            this.precioLbl.Name = "precioLbl";
            this.precioLbl.Size = new System.Drawing.Size(48, 17);
            this.precioLbl.TabIndex = 51;
            this.precioLbl.Text = "Precio";
            // 
            // precioTxt
            // 
            this.precioTxt.Location = new System.Drawing.Point(50, 117);
            this.precioTxt.Multiline = true;
            this.precioTxt.Name = "precioTxt";
            this.precioTxt.Size = new System.Drawing.Size(199, 31);
            this.precioTxt.TabIndex = 50;
            this.precioTxt.Enter += new System.EventHandler(this.precioTxt_Enter);
            this.precioTxt.Leave += new System.EventHandler(this.precioTxt_Leave);
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.eliminarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.eliminarBtn.FlatAppearance.BorderSize = 0;
            this.eliminarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eliminarBtn.Location = new System.Drawing.Point(646, 124);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(71, 39);
            this.eliminarBtn.TabIndex = 52;
            this.eliminarBtn.Text = "Eliminar";
            this.eliminarBtn.UseVisualStyleBackColor = false;
            this.eliminarBtn.Click += new System.EventHandler(this.eliminarBtn_Click);
            // 
            // modificarBtn
            // 
            this.modificarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.modificarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.modificarBtn.FlatAppearance.BorderSize = 0;
            this.modificarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.modificarBtn.Location = new System.Drawing.Point(646, 177);
            this.modificarBtn.Name = "modificarBtn";
            this.modificarBtn.Size = new System.Drawing.Size(71, 39);
            this.modificarBtn.TabIndex = 53;
            this.modificarBtn.Text = "Modificar";
            this.modificarBtn.UseVisualStyleBackColor = false;
            this.modificarBtn.Click += new System.EventHandler(this.modificarBtn_Click);
            // 
            // FormGestionarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(778, 558);
            this.Controls.Add(this.modificarBtn);
            this.Controls.Add(this.eliminarBtn);
            this.Controls.Add(this.precioLbl);
            this.Controls.Add(this.precioTxt);
            this.Controls.Add(this.stockLbl);
            this.Controls.Add(this.stockTxt);
            this.Controls.Add(this.nombreLbl);
            this.Controls.Add(this.nombreTxt);
            this.Controls.Add(this.agregarBtn);
            this.Controls.Add(this.dataGridView2);
            this.Name = "FormGestionarProducto";
            this.Text = "FormGestionarProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button agregarBtn;
        private System.Windows.Forms.Label nombreLbl;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.Label stockLbl;
        private System.Windows.Forms.TextBox stockTxt;
        private System.Windows.Forms.Label precioLbl;
        private System.Windows.Forms.TextBox precioTxt;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Button modificarBtn;
    }
}