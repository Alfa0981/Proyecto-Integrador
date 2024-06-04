namespace Proyecto_Integrador
{
    partial class FormGestionarUsuario
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
            this.emailLbl = new System.Windows.Forms.Label();
            this.dniLbl = new System.Windows.Forms.Label();
            this.apellidoLbl = new System.Windows.Forms.Label();
            this.nombreLbl = new System.Windows.Forms.Label();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.modificarBtn = new System.Windows.Forms.Button();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.dniTxt = new System.Windows.Forms.TextBox();
            this.apellidoTxt = new System.Windows.Forms.TextBox();
            this.cargarBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rolCmb = new System.Windows.Forms.ComboBox();
            this.desbloquearBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.BackColor = System.Drawing.Color.Snow;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.emailLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.emailLbl.Location = new System.Drawing.Point(88, 283);
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
            this.dniLbl.Location = new System.Drawing.Point(85, 237);
            this.dniLbl.Name = "dniLbl";
            this.dniLbl.Size = new System.Drawing.Size(29, 17);
            this.dniLbl.TabIndex = 34;
            this.dniLbl.Text = "Dni";
            // 
            // apellidoLbl
            // 
            this.apellidoLbl.AutoSize = true;
            this.apellidoLbl.BackColor = System.Drawing.Color.Snow;
            this.apellidoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.apellidoLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.apellidoLbl.Location = new System.Drawing.Point(85, 190);
            this.apellidoLbl.Name = "apellidoLbl";
            this.apellidoLbl.Size = new System.Drawing.Size(58, 17);
            this.apellidoLbl.TabIndex = 33;
            this.apellidoLbl.Text = "Apellido";
            // 
            // nombreLbl
            // 
            this.nombreLbl.AutoSize = true;
            this.nombreLbl.BackColor = System.Drawing.Color.Snow;
            this.nombreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.nombreLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.nombreLbl.Location = new System.Drawing.Point(85, 144);
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
            this.eliminarBtn.Location = new System.Drawing.Point(555, 436);
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
            this.nombreTxt.Location = new System.Drawing.Point(82, 138);
            this.nombreTxt.Multiline = true;
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(255, 31);
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
            this.modificarBtn.Location = new System.Drawing.Point(334, 436);
            this.modificarBtn.Name = "modificarBtn";
            this.modificarBtn.Size = new System.Drawing.Size(71, 23);
            this.modificarBtn.TabIndex = 30;
            this.modificarBtn.Text = "Modificar";
            this.modificarBtn.UseVisualStyleBackColor = false;
            this.modificarBtn.Click += new System.EventHandler(this.modificarBtn_Click);
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(82, 276);
            this.emailTxt.Multiline = true;
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(255, 31);
            this.emailTxt.TabIndex = 27;
            this.emailTxt.Enter += new System.EventHandler(this.emailTxt_Enter);
            this.emailTxt.Leave += new System.EventHandler(this.emailTxt_Leave);
            // 
            // dniTxt
            // 
            this.dniTxt.Location = new System.Drawing.Point(82, 230);
            this.dniTxt.Multiline = true;
            this.dniTxt.Name = "dniTxt";
            this.dniTxt.Size = new System.Drawing.Size(255, 31);
            this.dniTxt.TabIndex = 26;
            this.dniTxt.Enter += new System.EventHandler(this.dniTxt_Enter);
            this.dniTxt.Leave += new System.EventHandler(this.dniTxt_Leave);
            // 
            // apellidoTxt
            // 
            this.apellidoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.apellidoTxt.Location = new System.Drawing.Point(82, 184);
            this.apellidoTxt.Multiline = true;
            this.apellidoTxt.Name = "apellidoTxt";
            this.apellidoTxt.Size = new System.Drawing.Size(255, 31);
            this.apellidoTxt.TabIndex = 25;
            this.apellidoTxt.Enter += new System.EventHandler(this.apellidoTxt_Enter);
            this.apellidoTxt.Leave += new System.EventHandler(this.apellidoTxt_Leave);
            // 
            // cargarBtn
            // 
            this.cargarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.cargarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.cargarBtn.FlatAppearance.BorderSize = 0;
            this.cargarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cargarBtn.Location = new System.Drawing.Point(102, 436);
            this.cargarBtn.Name = "cargarBtn";
            this.cargarBtn.Size = new System.Drawing.Size(71, 23);
            this.cargarBtn.TabIndex = 23;
            this.cargarBtn.Text = "Cargar";
            this.cargarBtn.UseVisualStyleBackColor = false;
            this.cargarBtn.Click += new System.EventHandler(this.cargarBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.Location = new System.Drawing.Point(357, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(646, 265);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // rolCmb
            // 
            this.rolCmb.AllowDrop = true;
            this.rolCmb.FormattingEnabled = true;
            this.rolCmb.ItemHeight = 13;
            this.rolCmb.Location = new System.Drawing.Point(82, 327);
            this.rolCmb.Name = "rolCmb";
            this.rolCmb.Size = new System.Drawing.Size(103, 21);
            this.rolCmb.TabIndex = 37;
            this.rolCmb.Text = "Rol";
            // 
            // desbloquearBtn
            // 
            this.desbloquearBtn.BackColor = System.Drawing.Color.IndianRed;
            this.desbloquearBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.desbloquearBtn.FlatAppearance.BorderSize = 0;
            this.desbloquearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.desbloquearBtn.Location = new System.Drawing.Point(758, 436);
            this.desbloquearBtn.Name = "desbloquearBtn";
            this.desbloquearBtn.Size = new System.Drawing.Size(78, 23);
            this.desbloquearBtn.TabIndex = 38;
            this.desbloquearBtn.Text = "Desbloquear";
            this.desbloquearBtn.UseVisualStyleBackColor = false;
            this.desbloquearBtn.Click += new System.EventHandler(this.desbloquearBtn_Click);
            // 
            // FormGestionarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1052, 499);
            this.Controls.Add(this.desbloquearBtn);
            this.Controls.Add(this.rolCmb);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.dniLbl);
            this.Controls.Add(this.apellidoLbl);
            this.Controls.Add(this.nombreLbl);
            this.Controls.Add(this.eliminarBtn);
            this.Controls.Add(this.nombreTxt);
            this.Controls.Add(this.modificarBtn);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.dniTxt);
            this.Controls.Add(this.apellidoTxt);
            this.Controls.Add(this.cargarBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormGestionarUsuario";
            this.Text = "Gestionar Usuario";
            this.Load += new System.EventHandler(this.FormGestionarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label dniLbl;
        private System.Windows.Forms.Label apellidoLbl;
        private System.Windows.Forms.Label nombreLbl;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.Button modificarBtn;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox dniTxt;
        private System.Windows.Forms.TextBox apellidoTxt;
        private System.Windows.Forms.Button cargarBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox rolCmb;
        private System.Windows.Forms.Button desbloquearBtn;
    }
}