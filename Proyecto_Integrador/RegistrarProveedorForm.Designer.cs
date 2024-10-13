namespace Proyecto_Integrador
{
    partial class RegistrarProveedorForm
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
            this.direccionLbl = new System.Windows.Forms.Label();
            this.telefonoLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.dniLbl = new System.Windows.Forms.Label();
            this.nombreLbl = new System.Windows.Forms.Label();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.modificarBtn = new System.Windows.Forms.Button();
            this.direccionTxt = new System.Windows.Forms.TextBox();
            this.telefonoTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.dniTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productosCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.removerProductoBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.todosPerfilesLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // direccionLbl
            // 
            this.direccionLbl.AutoSize = true;
            this.direccionLbl.BackColor = System.Drawing.Color.Snow;
            this.direccionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.direccionLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.direccionLbl.Location = new System.Drawing.Point(30, 361);
            this.direccionLbl.Name = "direccionLbl";
            this.direccionLbl.Size = new System.Drawing.Size(67, 17);
            this.direccionLbl.TabIndex = 37;
            this.direccionLbl.Text = "Direccion";
            // 
            // telefonoLbl
            // 
            this.telefonoLbl.AutoSize = true;
            this.telefonoLbl.BackColor = System.Drawing.Color.Snow;
            this.telefonoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.telefonoLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.telefonoLbl.Location = new System.Drawing.Point(31, 270);
            this.telefonoLbl.Name = "telefonoLbl";
            this.telefonoLbl.Size = new System.Drawing.Size(64, 17);
            this.telefonoLbl.TabIndex = 36;
            this.telefonoLbl.Text = "Telefono";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.BackColor = System.Drawing.Color.Snow;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.emailLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.emailLbl.Location = new System.Drawing.Point(29, 224);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(42, 17);
            this.emailLbl.TabIndex = 35;
            this.emailLbl.Text = "Email";
            // 
            // dniLbl
            // 
            this.dniLbl.AutoSize = true;
            this.dniLbl.BackColor = System.Drawing.Color.Snow;
            this.dniLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dniLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dniLbl.Location = new System.Drawing.Point(26, 407);
            this.dniLbl.Name = "dniLbl";
            this.dniLbl.Size = new System.Drawing.Size(29, 17);
            this.dniLbl.TabIndex = 34;
            this.dniLbl.Text = "Dni";
            // 
            // nombreLbl
            // 
            this.nombreLbl.AutoSize = true;
            this.nombreLbl.BackColor = System.Drawing.Color.Snow;
            this.nombreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.nombreLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.nombreLbl.Location = new System.Drawing.Point(26, 314);
            this.nombreLbl.Name = "nombreLbl";
            this.nombreLbl.Size = new System.Drawing.Size(58, 17);
            this.nombreLbl.TabIndex = 32;
            this.nombreLbl.Text = "Nombre";
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.eliminarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.eliminarBtn.FlatAppearance.BorderSize = 0;
            this.eliminarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eliminarBtn.Location = new System.Drawing.Point(385, 503);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(71, 23);
            this.eliminarBtn.TabIndex = 31;
            this.eliminarBtn.Text = "Eliminar";
            this.eliminarBtn.UseVisualStyleBackColor = false;
            this.eliminarBtn.Click += new System.EventHandler(this.eliminarBtn_Click);
            // 
            // nombreTxt
            // 
            this.nombreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.nombreTxt.Location = new System.Drawing.Point(23, 308);
            this.nombreTxt.Multiline = true;
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(321, 31);
            this.nombreTxt.TabIndex = 24;
            this.nombreTxt.Enter += new System.EventHandler(this.nombreTxt_Enter);
            this.nombreTxt.Leave += new System.EventHandler(this.nombreTxt_Leave);
            // 
            // modificarBtn
            // 
            this.modificarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.modificarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.modificarBtn.FlatAppearance.BorderSize = 0;
            this.modificarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.modificarBtn.Location = new System.Drawing.Point(494, 503);
            this.modificarBtn.Name = "modificarBtn";
            this.modificarBtn.Size = new System.Drawing.Size(71, 23);
            this.modificarBtn.TabIndex = 30;
            this.modificarBtn.Text = "Modificar";
            this.modificarBtn.UseVisualStyleBackColor = false;
            this.modificarBtn.Click += new System.EventHandler(this.modificarBtn_Click);
            // 
            // direccionTxt
            // 
            this.direccionTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.direccionTxt.Location = new System.Drawing.Point(23, 354);
            this.direccionTxt.Multiline = true;
            this.direccionTxt.Name = "direccionTxt";
            this.direccionTxt.Size = new System.Drawing.Size(321, 31);
            this.direccionTxt.TabIndex = 29;
            this.direccionTxt.Enter += new System.EventHandler(this.direccionTxt_Enter);
            this.direccionTxt.Leave += new System.EventHandler(this.direccionTxt_Leave);
            // 
            // telefonoTxt
            // 
            this.telefonoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.telefonoTxt.Location = new System.Drawing.Point(23, 263);
            this.telefonoTxt.Multiline = true;
            this.telefonoTxt.Name = "telefonoTxt";
            this.telefonoTxt.Size = new System.Drawing.Size(321, 31);
            this.telefonoTxt.TabIndex = 28;
            this.telefonoTxt.Enter += new System.EventHandler(this.telefonoTxt_Enter);
            this.telefonoTxt.Leave += new System.EventHandler(this.telefonoTxt_Leave);
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.emailTxt.Location = new System.Drawing.Point(23, 217);
            this.emailTxt.Multiline = true;
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(321, 31);
            this.emailTxt.TabIndex = 27;
            this.emailTxt.Enter += new System.EventHandler(this.emailTxt_Enter);
            this.emailTxt.Leave += new System.EventHandler(this.emailTxt_Leave);
            // 
            // dniTxt
            // 
            this.dniTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dniTxt.Location = new System.Drawing.Point(23, 400);
            this.dniTxt.Multiline = true;
            this.dniTxt.Name = "dniTxt";
            this.dniTxt.Size = new System.Drawing.Size(321, 31);
            this.dniTxt.TabIndex = 26;
            this.dniTxt.Enter += new System.EventHandler(this.dniTxt_Enter);
            this.dniTxt.Leave += new System.EventHandler(this.dniTxt_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(280, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Cargar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.Location = new System.Drawing.Point(23, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(625, 150);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // productosCombo
            // 
            this.productosCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.productosCombo.FormattingEnabled = true;
            this.productosCombo.Location = new System.Drawing.Point(166, 34);
            this.productosCombo.Name = "productosCombo";
            this.productosCombo.Size = new System.Drawing.Size(121, 25);
            this.productosCombo.TabIndex = 38;
            this.productosCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.removerProductoBtn);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.todosPerfilesLbl);
            this.groupBox1.Controls.Add(this.productosCombo);
            this.groupBox1.Location = new System.Drawing.Point(361, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 196);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos";
            // 
            // removerProductoBtn
            // 
            this.removerProductoBtn.BackColor = System.Drawing.Color.IndianRed;
            this.removerProductoBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.removerProductoBtn.FlatAppearance.BorderSize = 0;
            this.removerProductoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removerProductoBtn.Location = new System.Drawing.Point(120, 137);
            this.removerProductoBtn.Name = "removerProductoBtn";
            this.removerProductoBtn.Size = new System.Drawing.Size(71, 23);
            this.removerProductoBtn.TabIndex = 49;
            this.removerProductoBtn.Text = "Remover";
            this.removerProductoBtn.UseVisualStyleBackColor = false;
            this.removerProductoBtn.Click += new System.EventHandler(this.removerProductoBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(120, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 23);
            this.button2.TabIndex = 48;
            this.button2.Text = "Asociar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(293, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(203, 147);
            this.listBox1.TabIndex = 47;
            // 
            // todosPerfilesLbl
            // 
            this.todosPerfilesLbl.AutoSize = true;
            this.todosPerfilesLbl.Location = new System.Drawing.Point(24, 40);
            this.todosPerfilesLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.todosPerfilesLbl.Name = "todosPerfilesLbl";
            this.todosPerfilesLbl.Size = new System.Drawing.Size(88, 13);
            this.todosPerfilesLbl.TabIndex = 46;
            this.todosPerfilesLbl.Text = "Asociar Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Proveedores";
            // 
            // RegistrarProveedorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(928, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.direccionLbl);
            this.Controls.Add(this.telefonoLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.dniLbl);
            this.Controls.Add(this.nombreLbl);
            this.Controls.Add(this.eliminarBtn);
            this.Controls.Add(this.nombreTxt);
            this.Controls.Add(this.modificarBtn);
            this.Controls.Add(this.direccionTxt);
            this.Controls.Add(this.telefonoTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.dniTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistrarProveedorForm";
            this.Text = "RegistrarProveedorForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label direccionLbl;
        private System.Windows.Forms.Label telefonoLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label dniLbl;
        private System.Windows.Forms.Label nombreLbl;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.Button modificarBtn;
        private System.Windows.Forms.TextBox direccionTxt;
        private System.Windows.Forms.TextBox telefonoTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox dniTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox productosCombo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label todosPerfilesLbl;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removerProductoBtn;
    }
}