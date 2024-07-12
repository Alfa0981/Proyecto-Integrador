namespace Proyecto_Integrador
{
    partial class FormGestionarFamilias
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
            this.grpPatentes = new System.Windows.Forms.GroupBox();
            this.agregarPatenteBtn = new System.Windows.Forms.Button();
            this.patenteLB = new System.Windows.Forms.ListBox();
            this.todasPatentesLbl = new System.Windows.Forms.Label();
            this.grpFamilias = new System.Windows.Forms.GroupBox();
            this.familiasLB = new System.Windows.Forms.ListBox();
            this.agregarFamiliaBtn = new System.Windows.Forms.Button();
            this.todasFamiliasLbl = new System.Windows.Forms.Label();
            this.grpConfigurarFamilia = new System.Windows.Forms.GroupBox();
            this.grpNuevo = new System.Windows.Forms.GroupBox();
            this.agregarBtn = new System.Windows.Forms.Button();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.nombreLbl = new System.Windows.Forms.Label();
            this.quitarBtn = new System.Windows.Forms.Button();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.guardarFamiliaBtn = new System.Windows.Forms.Button();
            this.treeConfigurarFamilia = new System.Windows.Forms.TreeView();
            this.configurarBtn = new System.Windows.Forms.Button();
            this.grpPatentes.SuspendLayout();
            this.grpFamilias.SuspendLayout();
            this.grpConfigurarFamilia.SuspendLayout();
            this.grpNuevo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPatentes
            // 
            this.grpPatentes.Controls.Add(this.agregarPatenteBtn);
            this.grpPatentes.Controls.Add(this.patenteLB);
            this.grpPatentes.Controls.Add(this.todasPatentesLbl);
            this.grpPatentes.Location = new System.Drawing.Point(41, 390);
            this.grpPatentes.Margin = new System.Windows.Forms.Padding(2);
            this.grpPatentes.Name = "grpPatentes";
            this.grpPatentes.Padding = new System.Windows.Forms.Padding(2);
            this.grpPatentes.Size = new System.Drawing.Size(290, 322);
            this.grpPatentes.TabIndex = 8;
            this.grpPatentes.TabStop = false;
            this.grpPatentes.Text = "Patentes";
            // 
            // agregarPatenteBtn
            // 
            this.agregarPatenteBtn.BackColor = System.Drawing.Color.IndianRed;
            this.agregarPatenteBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.agregarPatenteBtn.FlatAppearance.BorderSize = 0;
            this.agregarPatenteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.agregarPatenteBtn.Location = new System.Drawing.Point(76, 253);
            this.agregarPatenteBtn.Name = "agregarPatenteBtn";
            this.agregarPatenteBtn.Size = new System.Drawing.Size(121, 23);
            this.agregarPatenteBtn.TabIndex = 12;
            this.agregarPatenteBtn.Text = "Agregar a Familia ";
            this.agregarPatenteBtn.UseVisualStyleBackColor = false;
            this.agregarPatenteBtn.Click += new System.EventHandler(this.agregarPatenteBtn_Click);
            // 
            // patenteLB
            // 
            this.patenteLB.FormattingEnabled = true;
            this.patenteLB.Location = new System.Drawing.Point(12, 39);
            this.patenteLB.Name = "patenteLB";
            this.patenteLB.Size = new System.Drawing.Size(258, 199);
            this.patenteLB.TabIndex = 11;
            // 
            // todasPatentesLbl
            // 
            this.todasPatentesLbl.AutoSize = true;
            this.todasPatentesLbl.Location = new System.Drawing.Point(9, 23);
            this.todasPatentesLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.todasPatentesLbl.Name = "todasPatentesLbl";
            this.todasPatentesLbl.Size = new System.Drawing.Size(97, 13);
            this.todasPatentesLbl.TabIndex = 5;
            this.todasPatentesLbl.Text = "Todas las patentes";
            // 
            // grpFamilias
            // 
            this.grpFamilias.Controls.Add(this.configurarBtn);
            this.grpFamilias.Controls.Add(this.familiasLB);
            this.grpFamilias.Controls.Add(this.agregarFamiliaBtn);
            this.grpFamilias.Controls.Add(this.todasFamiliasLbl);
            this.grpFamilias.Location = new System.Drawing.Point(335, 390);
            this.grpFamilias.Margin = new System.Windows.Forms.Padding(2);
            this.grpFamilias.Name = "grpFamilias";
            this.grpFamilias.Padding = new System.Windows.Forms.Padding(2);
            this.grpFamilias.Size = new System.Drawing.Size(290, 322);
            this.grpFamilias.TabIndex = 9;
            this.grpFamilias.TabStop = false;
            this.grpFamilias.Text = "Familias";
            // 
            // familiasLB
            // 
            this.familiasLB.FormattingEnabled = true;
            this.familiasLB.Location = new System.Drawing.Point(16, 39);
            this.familiasLB.Name = "familiasLB";
            this.familiasLB.Size = new System.Drawing.Size(258, 199);
            this.familiasLB.TabIndex = 13;
            // 
            // agregarFamiliaBtn
            // 
            this.agregarFamiliaBtn.BackColor = System.Drawing.Color.IndianRed;
            this.agregarFamiliaBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.agregarFamiliaBtn.FlatAppearance.BorderSize = 0;
            this.agregarFamiliaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.agregarFamiliaBtn.Location = new System.Drawing.Point(153, 253);
            this.agregarFamiliaBtn.Name = "agregarFamiliaBtn";
            this.agregarFamiliaBtn.Size = new System.Drawing.Size(121, 23);
            this.agregarFamiliaBtn.TabIndex = 13;
            this.agregarFamiliaBtn.Text = "Agregar a Familia";
            this.agregarFamiliaBtn.UseVisualStyleBackColor = false;
            this.agregarFamiliaBtn.Click += new System.EventHandler(this.agregarFamiliaBtn_Click);
            // 
            // todasFamiliasLbl
            // 
            this.todasFamiliasLbl.AutoSize = true;
            this.todasFamiliasLbl.Location = new System.Drawing.Point(13, 23);
            this.todasFamiliasLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.todasFamiliasLbl.Name = "todasFamiliasLbl";
            this.todasFamiliasLbl.Size = new System.Drawing.Size(90, 13);
            this.todasFamiliasLbl.TabIndex = 7;
            this.todasFamiliasLbl.Text = "Todas las familias";
            // 
            // grpConfigurarFamilia
            // 
            this.grpConfigurarFamilia.Controls.Add(this.grpNuevo);
            this.grpConfigurarFamilia.Controls.Add(this.grpFamilias);
            this.grpConfigurarFamilia.Controls.Add(this.quitarBtn);
            this.grpConfigurarFamilia.Controls.Add(this.grpPatentes);
            this.grpConfigurarFamilia.Controls.Add(this.eliminarBtn);
            this.grpConfigurarFamilia.Controls.Add(this.guardarFamiliaBtn);
            this.grpConfigurarFamilia.Controls.Add(this.treeConfigurarFamilia);
            this.grpConfigurarFamilia.Location = new System.Drawing.Point(11, 11);
            this.grpConfigurarFamilia.Margin = new System.Windows.Forms.Padding(2);
            this.grpConfigurarFamilia.Name = "grpConfigurarFamilia";
            this.grpConfigurarFamilia.Padding = new System.Windows.Forms.Padding(2);
            this.grpConfigurarFamilia.Size = new System.Drawing.Size(665, 733);
            this.grpConfigurarFamilia.TabIndex = 10;
            this.grpConfigurarFamilia.TabStop = false;
            this.grpConfigurarFamilia.Text = "Configurar Familia";
            this.grpConfigurarFamilia.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // grpNuevo
            // 
            this.grpNuevo.Controls.Add(this.agregarBtn);
            this.grpNuevo.Controls.Add(this.nombreTxt);
            this.grpNuevo.Controls.Add(this.nombreLbl);
            this.grpNuevo.Location = new System.Drawing.Point(41, 17);
            this.grpNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.grpNuevo.Name = "grpNuevo";
            this.grpNuevo.Padding = new System.Windows.Forms.Padding(2);
            this.grpNuevo.Size = new System.Drawing.Size(232, 102);
            this.grpNuevo.TabIndex = 15;
            this.grpNuevo.TabStop = false;
            this.grpNuevo.Text = "Nuevo";
            // 
            // agregarBtn
            // 
            this.agregarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.agregarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.agregarBtn.FlatAppearance.BorderSize = 0;
            this.agregarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.agregarBtn.Location = new System.Drawing.Point(11, 62);
            this.agregarBtn.Name = "agregarBtn";
            this.agregarBtn.Size = new System.Drawing.Size(71, 23);
            this.agregarBtn.TabIndex = 12;
            this.agregarBtn.Text = "Agregar";
            this.agregarBtn.UseVisualStyleBackColor = false;
            this.agregarBtn.Click += new System.EventHandler(this.button12_Click);
            // 
            // nombreTxt
            // 
            this.nombreTxt.Location = new System.Drawing.Point(11, 37);
            this.nombreTxt.Margin = new System.Windows.Forms.Padding(2);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(174, 20);
            this.nombreTxt.TabIndex = 3;
            // 
            // nombreLbl
            // 
            this.nombreLbl.AutoSize = true;
            this.nombreLbl.Location = new System.Drawing.Point(9, 20);
            this.nombreLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombreLbl.Name = "nombreLbl";
            this.nombreLbl.Size = new System.Drawing.Size(44, 13);
            this.nombreLbl.TabIndex = 2;
            this.nombreLbl.Text = "Nombre";
            // 
            // quitarBtn
            // 
            this.quitarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.quitarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.quitarBtn.FlatAppearance.BorderSize = 0;
            this.quitarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.quitarBtn.Location = new System.Drawing.Point(374, 339);
            this.quitarBtn.Name = "quitarBtn";
            this.quitarBtn.Size = new System.Drawing.Size(71, 23);
            this.quitarBtn.TabIndex = 14;
            this.quitarBtn.Text = "Quitar";
            this.quitarBtn.UseVisualStyleBackColor = false;
            this.quitarBtn.Click += new System.EventHandler(this.quitarBtn_Click);
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.eliminarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.eliminarBtn.FlatAppearance.BorderSize = 0;
            this.eliminarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eliminarBtn.Location = new System.Drawing.Point(297, 339);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(71, 23);
            this.eliminarBtn.TabIndex = 13;
            this.eliminarBtn.Text = "Eliminar";
            this.eliminarBtn.UseVisualStyleBackColor = false;
            this.eliminarBtn.Click += new System.EventHandler(this.eliminarBtn_Click);
            // 
            // guardarFamiliaBtn
            // 
            this.guardarFamiliaBtn.BackColor = System.Drawing.Color.IndianRed;
            this.guardarFamiliaBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.guardarFamiliaBtn.FlatAppearance.BorderSize = 0;
            this.guardarFamiliaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.guardarFamiliaBtn.Location = new System.Drawing.Point(220, 339);
            this.guardarFamiliaBtn.Name = "guardarFamiliaBtn";
            this.guardarFamiliaBtn.Size = new System.Drawing.Size(71, 23);
            this.guardarFamiliaBtn.TabIndex = 12;
            this.guardarFamiliaBtn.Text = "Guardar";
            this.guardarFamiliaBtn.UseVisualStyleBackColor = false;
            this.guardarFamiliaBtn.Click += new System.EventHandler(this.guardarFamiliaBtn_Click);
            // 
            // treeConfigurarFamilia
            // 
            this.treeConfigurarFamilia.Location = new System.Drawing.Point(41, 138);
            this.treeConfigurarFamilia.Margin = new System.Windows.Forms.Padding(2);
            this.treeConfigurarFamilia.Name = "treeConfigurarFamilia";
            this.treeConfigurarFamilia.Size = new System.Drawing.Size(584, 192);
            this.treeConfigurarFamilia.TabIndex = 0;
            // 
            // configurarBtn
            // 
            this.configurarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.configurarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.configurarBtn.FlatAppearance.BorderSize = 0;
            this.configurarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.configurarBtn.Location = new System.Drawing.Point(16, 253);
            this.configurarBtn.Name = "configurarBtn";
            this.configurarBtn.Size = new System.Drawing.Size(121, 23);
            this.configurarBtn.TabIndex = 14;
            this.configurarBtn.Text = "Configurar";
            this.configurarBtn.UseVisualStyleBackColor = false;
            this.configurarBtn.Click += new System.EventHandler(this.configurarBtn_Click);
            // 
            // FormGestionarFamilias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(729, 785);
            this.Controls.Add(this.grpConfigurarFamilia);
            this.Name = "FormGestionarFamilias";
            this.Text = "FormGestionarFamilias";
            this.grpPatentes.ResumeLayout(false);
            this.grpPatentes.PerformLayout();
            this.grpFamilias.ResumeLayout(false);
            this.grpFamilias.PerformLayout();
            this.grpConfigurarFamilia.ResumeLayout(false);
            this.grpNuevo.ResumeLayout(false);
            this.grpNuevo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPatentes;
        private System.Windows.Forms.Button agregarPatenteBtn;
        private System.Windows.Forms.ListBox patenteLB;
        private System.Windows.Forms.Label todasPatentesLbl;
        private System.Windows.Forms.GroupBox grpFamilias;
        private System.Windows.Forms.Label todasFamiliasLbl;
        private System.Windows.Forms.Button agregarFamiliaBtn;
        private System.Windows.Forms.GroupBox grpConfigurarFamilia;
        private System.Windows.Forms.Button quitarBtn;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Button guardarFamiliaBtn;
        private System.Windows.Forms.TreeView treeConfigurarFamilia;
        private System.Windows.Forms.GroupBox grpNuevo;
        private System.Windows.Forms.Button agregarBtn;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.Label nombreLbl;
        private System.Windows.Forms.ListBox familiasLB;
        private System.Windows.Forms.Button configurarBtn;
    }
}