namespace Proyecto_Integrador
{
    partial class FormRegistrarCliente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.apellidoTxt = new System.Windows.Forms.TextBox();
            this.dniTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.telefonoTxt = new System.Windows.Forms.TextBox();
            this.direccionTxt = new System.Windows.Forms.TextBox();
            this.modificarBtn = new System.Windows.Forms.Button();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dniLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.telefonoLbl = new System.Windows.Forms.Label();
            this.direccionLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(741, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(130, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cargar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nombreTxt
            // 
            this.nombreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.nombreTxt.Location = new System.Drawing.Point(67, 294);
            this.nombreTxt.Multiline = true;
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(321, 31);
            this.nombreTxt.TabIndex = 4;
            this.nombreTxt.Enter += new System.EventHandler(this.nombreTxt_Enter);
            this.nombreTxt.Leave += new System.EventHandler(this.nombreTxt_Leave);
            // 
            // apellidoTxt
            // 
            this.apellidoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.apellidoTxt.Location = new System.Drawing.Point(67, 340);
            this.apellidoTxt.Multiline = true;
            this.apellidoTxt.Name = "apellidoTxt";
            this.apellidoTxt.Size = new System.Drawing.Size(321, 31);
            this.apellidoTxt.TabIndex = 5;
            this.apellidoTxt.Enter += new System.EventHandler(this.apellidoTxt_Enter);
            this.apellidoTxt.Leave += new System.EventHandler(this.apellidoTxt_Leave);
            // 
            // dniTxt
            // 
            this.dniTxt.Location = new System.Drawing.Point(67, 386);
            this.dniTxt.Multiline = true;
            this.dniTxt.Name = "dniTxt";
            this.dniTxt.Size = new System.Drawing.Size(321, 31);
            this.dniTxt.TabIndex = 6;
            this.dniTxt.Enter += new System.EventHandler(this.dniTxt_Enter);
            this.dniTxt.Leave += new System.EventHandler(this.dniTxt_Leave);
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(394, 294);
            this.emailTxt.Multiline = true;
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(321, 31);
            this.emailTxt.TabIndex = 7;
            this.emailTxt.Enter += new System.EventHandler(this.emailTxt_Enter);
            this.emailTxt.Leave += new System.EventHandler(this.emailTxt_Leave);
            // 
            // telefonoTxt
            // 
            this.telefonoTxt.Location = new System.Drawing.Point(394, 340);
            this.telefonoTxt.Multiline = true;
            this.telefonoTxt.Name = "telefonoTxt";
            this.telefonoTxt.Size = new System.Drawing.Size(321, 31);
            this.telefonoTxt.TabIndex = 8;
            this.telefonoTxt.Enter += new System.EventHandler(this.telefonoTxt_Enter);
            this.telefonoTxt.Leave += new System.EventHandler(this.telefonoTxt_Leave);
            // 
            // direccionTxt
            // 
            this.direccionTxt.Location = new System.Drawing.Point(394, 386);
            this.direccionTxt.Multiline = true;
            this.direccionTxt.Name = "direccionTxt";
            this.direccionTxt.Size = new System.Drawing.Size(321, 31);
            this.direccionTxt.TabIndex = 9;
            this.direccionTxt.Enter += new System.EventHandler(this.direccionTxt_Enter);
            this.direccionTxt.Leave += new System.EventHandler(this.direccionTxt_Leave);
            // 
            // modificarBtn
            // 
            this.modificarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.modificarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.modificarBtn.FlatAppearance.BorderSize = 0;
            this.modificarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.modificarBtn.Location = new System.Drawing.Point(362, 460);
            this.modificarBtn.Name = "modificarBtn";
            this.modificarBtn.Size = new System.Drawing.Size(71, 23);
            this.modificarBtn.TabIndex = 10;
            this.modificarBtn.Text = "Modificar";
            this.modificarBtn.UseVisualStyleBackColor = false;
            this.modificarBtn.Click += new System.EventHandler(this.modificarBtn_Click);
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.eliminarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.eliminarBtn.FlatAppearance.BorderSize = 0;
            this.eliminarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eliminarBtn.Location = new System.Drawing.Point(583, 460);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(71, 23);
            this.eliminarBtn.TabIndex = 11;
            this.eliminarBtn.Text = "Eliminar";
            this.eliminarBtn.UseVisualStyleBackColor = false;
            this.eliminarBtn.Click += new System.EventHandler(this.eliminarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(70, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Snow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(70, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Apellido";
            // 
            // dniLbl
            // 
            this.dniLbl.AutoSize = true;
            this.dniLbl.BackColor = System.Drawing.Color.Snow;
            this.dniLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dniLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.dniLbl.Location = new System.Drawing.Point(70, 393);
            this.dniLbl.Name = "dniLbl";
            this.dniLbl.Size = new System.Drawing.Size(29, 17);
            this.dniLbl.TabIndex = 18;
            this.dniLbl.Text = "Dni";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.BackColor = System.Drawing.Color.Snow;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.emailLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.emailLbl.Location = new System.Drawing.Point(400, 301);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(42, 17);
            this.emailLbl.TabIndex = 19;
            this.emailLbl.Text = "Email";
            // 
            // telefonoLbl
            // 
            this.telefonoLbl.AutoSize = true;
            this.telefonoLbl.BackColor = System.Drawing.Color.Snow;
            this.telefonoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.telefonoLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.telefonoLbl.Location = new System.Drawing.Point(402, 347);
            this.telefonoLbl.Name = "telefonoLbl";
            this.telefonoLbl.Size = new System.Drawing.Size(64, 17);
            this.telefonoLbl.TabIndex = 20;
            this.telefonoLbl.Text = "Telefono";
            // 
            // direccionLbl
            // 
            this.direccionLbl.AutoSize = true;
            this.direccionLbl.BackColor = System.Drawing.Color.Snow;
            this.direccionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.direccionLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.direccionLbl.Location = new System.Drawing.Point(401, 393);
            this.direccionLbl.Name = "direccionLbl";
            this.direccionLbl.Size = new System.Drawing.Size(67, 17);
            this.direccionLbl.TabIndex = 21;
            this.direccionLbl.Text = "Direccion";
            // 
            // FormRegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(884, 571);
            this.Controls.Add(this.direccionLbl);
            this.Controls.Add(this.telefonoLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.dniLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eliminarBtn);
            this.Controls.Add(this.nombreTxt);
            this.Controls.Add(this.modificarBtn);
            this.Controls.Add(this.direccionTxt);
            this.Controls.Add(this.telefonoTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.dniTxt);
            this.Controls.Add(this.apellidoTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormRegistrarCliente";
            this.Text = "FormRegistrarCliente";
            this.Load += new System.EventHandler(this.FormRegistrarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.TextBox apellidoTxt;
        private System.Windows.Forms.TextBox dniTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox telefonoTxt;
        private System.Windows.Forms.TextBox direccionTxt;
        private System.Windows.Forms.Button modificarBtn;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dniLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label telefonoLbl;
        private System.Windows.Forms.Label direccionLbl;
    }
}

