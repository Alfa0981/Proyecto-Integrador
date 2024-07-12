namespace Proyecto_Integrador
{
    partial class FormGestionarPerfil
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
            this.grpFamilias = new System.Windows.Forms.GroupBox();
            this.agregarFamiliaBtn = new System.Windows.Forms.Button();
            this.configurarBtn = new System.Windows.Forms.Button();
            this.todasFamiliasLbl = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNombreFamilia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpPatentes = new System.Windows.Forms.GroupBox();
            this.agregarPatenteBtn = new System.Windows.Forms.Button();
            this.patenteLB = new System.Windows.Forms.ListBox();
            this.todasPatentesLbl = new System.Windows.Forms.Label();
            this.grpPerfiles = new System.Windows.Forms.GroupBox();
            this.quitarBtn = new System.Windows.Forms.Button();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.grpNuevo = new System.Windows.Forms.GroupBox();
            this.agregarNuevoBtn = new System.Windows.Forms.Button();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.nombreLbl = new System.Windows.Forms.Label();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.treeViewPerfiles = new System.Windows.Forms.TreeView();
            this.todosPerfilesLbl = new System.Windows.Forms.Label();
            this.familiasLB = new System.Windows.Forms.ListBox();
            this.grpFamilias.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpPatentes.SuspendLayout();
            this.grpPerfiles.SuspendLayout();
            this.grpNuevo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFamilias
            // 
            this.grpFamilias.Controls.Add(this.familiasLB);
            this.grpFamilias.Controls.Add(this.agregarFamiliaBtn);
            this.grpFamilias.Controls.Add(this.configurarBtn);
            this.grpFamilias.Controls.Add(this.todasFamiliasLbl);
            this.grpFamilias.Location = new System.Drawing.Point(344, 410);
            this.grpFamilias.Margin = new System.Windows.Forms.Padding(2);
            this.grpFamilias.Name = "grpFamilias";
            this.grpFamilias.Padding = new System.Windows.Forms.Padding(2);
            this.grpFamilias.Size = new System.Drawing.Size(290, 322);
            this.grpFamilias.TabIndex = 8;
            this.grpFamilias.TabStop = false;
            this.grpFamilias.Text = "Familias";
            // 
            // agregarFamiliaBtn
            // 
            this.agregarFamiliaBtn.BackColor = System.Drawing.Color.IndianRed;
            this.agregarFamiliaBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.agregarFamiliaBtn.FlatAppearance.BorderSize = 0;
            this.agregarFamiliaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.agregarFamiliaBtn.Location = new System.Drawing.Point(152, 253);
            this.agregarFamiliaBtn.Name = "agregarFamiliaBtn";
            this.agregarFamiliaBtn.Size = new System.Drawing.Size(121, 23);
            this.agregarFamiliaBtn.TabIndex = 13;
            this.agregarFamiliaBtn.Text = "Agregar a Perfil ";
            this.agregarFamiliaBtn.UseVisualStyleBackColor = false;
            this.agregarFamiliaBtn.Click += new System.EventHandler(this.agregarFamiliaBtn_Click);
            // 
            // configurarBtn
            // 
            this.configurarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.configurarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.configurarBtn.FlatAppearance.BorderSize = 0;
            this.configurarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.configurarBtn.Location = new System.Drawing.Point(16, 253);
            this.configurarBtn.Name = "configurarBtn";
            this.configurarBtn.Size = new System.Drawing.Size(105, 23);
            this.configurarBtn.TabIndex = 12;
            this.configurarBtn.Text = "Gestionar Familias";
            this.configurarBtn.UseVisualStyleBackColor = false;
            this.configurarBtn.Click += new System.EventHandler(this.configurarBtn_Click);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txtNombreFamilia);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(743, 925);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(232, 102);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nueva";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(11, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtNombreFamilia
            // 
            this.txtNombreFamilia.Location = new System.Drawing.Point(11, 37);
            this.txtNombreFamilia.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreFamilia.Name = "txtNombreFamilia";
            this.txtNombreFamilia.Size = new System.Drawing.Size(174, 20);
            this.txtNombreFamilia.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre";
            // 
            // grpPatentes
            // 
            this.grpPatentes.Controls.Add(this.agregarPatenteBtn);
            this.grpPatentes.Controls.Add(this.patenteLB);
            this.grpPatentes.Controls.Add(this.todasPatentesLbl);
            this.grpPatentes.Location = new System.Drawing.Point(50, 410);
            this.grpPatentes.Margin = new System.Windows.Forms.Padding(2);
            this.grpPatentes.Name = "grpPatentes";
            this.grpPatentes.Padding = new System.Windows.Forms.Padding(2);
            this.grpPatentes.Size = new System.Drawing.Size(290, 322);
            this.grpPatentes.TabIndex = 7;
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
            this.agregarPatenteBtn.Text = "Agregar a Perfil ";
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
            // grpPerfiles
            // 
            this.grpPerfiles.Controls.Add(this.quitarBtn);
            this.grpPerfiles.Controls.Add(this.guardarBtn);
            this.grpPerfiles.Controls.Add(this.grpFamilias);
            this.grpPerfiles.Controls.Add(this.grpNuevo);
            this.grpPerfiles.Controls.Add(this.grpPatentes);
            this.grpPerfiles.Controls.Add(this.eliminarBtn);
            this.grpPerfiles.Controls.Add(this.treeViewPerfiles);
            this.grpPerfiles.Controls.Add(this.todosPerfilesLbl);
            this.grpPerfiles.Location = new System.Drawing.Point(11, 11);
            this.grpPerfiles.Margin = new System.Windows.Forms.Padding(2);
            this.grpPerfiles.Name = "grpPerfiles";
            this.grpPerfiles.Padding = new System.Windows.Forms.Padding(2);
            this.grpPerfiles.Size = new System.Drawing.Size(663, 752);
            this.grpPerfiles.TabIndex = 13;
            this.grpPerfiles.TabStop = false;
            this.grpPerfiles.Text = "Perfiles";
            this.grpPerfiles.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // quitarBtn
            // 
            this.quitarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.quitarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.quitarBtn.FlatAppearance.BorderSize = 0;
            this.quitarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.quitarBtn.Location = new System.Drawing.Point(375, 358);
            this.quitarBtn.Name = "quitarBtn";
            this.quitarBtn.Size = new System.Drawing.Size(71, 23);
            this.quitarBtn.TabIndex = 19;
            this.quitarBtn.Text = "Quitar";
            this.quitarBtn.UseVisualStyleBackColor = false;
            this.quitarBtn.Click += new System.EventHandler(this.quitarBtn_Click);
            // 
            // guardarBtn
            // 
            this.guardarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.guardarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.guardarBtn.FlatAppearance.BorderSize = 0;
            this.guardarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.guardarBtn.Location = new System.Drawing.Point(221, 358);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(71, 23);
            this.guardarBtn.TabIndex = 17;
            this.guardarBtn.Text = "Guardar";
            this.guardarBtn.UseVisualStyleBackColor = false;
            // 
            // grpNuevo
            // 
            this.grpNuevo.Controls.Add(this.agregarNuevoBtn);
            this.grpNuevo.Controls.Add(this.nombreTxt);
            this.grpNuevo.Controls.Add(this.nombreLbl);
            this.grpNuevo.Location = new System.Drawing.Point(50, 17);
            this.grpNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.grpNuevo.Name = "grpNuevo";
            this.grpNuevo.Padding = new System.Windows.Forms.Padding(2);
            this.grpNuevo.Size = new System.Drawing.Size(232, 102);
            this.grpNuevo.TabIndex = 13;
            this.grpNuevo.TabStop = false;
            this.grpNuevo.Text = "Nuevo";
            // 
            // agregarNuevoBtn
            // 
            this.agregarNuevoBtn.BackColor = System.Drawing.Color.IndianRed;
            this.agregarNuevoBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.agregarNuevoBtn.FlatAppearance.BorderSize = 0;
            this.agregarNuevoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.agregarNuevoBtn.Location = new System.Drawing.Point(12, 62);
            this.agregarNuevoBtn.Name = "agregarNuevoBtn";
            this.agregarNuevoBtn.Size = new System.Drawing.Size(71, 23);
            this.agregarNuevoBtn.TabIndex = 12;
            this.agregarNuevoBtn.Text = "Agregar";
            this.agregarNuevoBtn.UseVisualStyleBackColor = false;
            this.agregarNuevoBtn.Click += new System.EventHandler(this.agregarNuevoBtn_Click);
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
            // eliminarBtn
            // 
            this.eliminarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.eliminarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.eliminarBtn.FlatAppearance.BorderSize = 0;
            this.eliminarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eliminarBtn.Location = new System.Drawing.Point(298, 358);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(71, 23);
            this.eliminarBtn.TabIndex = 18;
            this.eliminarBtn.Text = "Eliminar";
            this.eliminarBtn.UseVisualStyleBackColor = false;
            this.eliminarBtn.Click += new System.EventHandler(this.eliminarBtn_Click);
            // 
            // treeViewPerfiles
            // 
            this.treeViewPerfiles.Location = new System.Drawing.Point(50, 156);
            this.treeViewPerfiles.Margin = new System.Windows.Forms.Padding(2);
            this.treeViewPerfiles.Name = "treeViewPerfiles";
            this.treeViewPerfiles.Size = new System.Drawing.Size(584, 192);
            this.treeViewPerfiles.TabIndex = 14;
            // 
            // todosPerfilesLbl
            // 
            this.todosPerfilesLbl.AutoSize = true;
            this.todosPerfilesLbl.Location = new System.Drawing.Point(49, 141);
            this.todosPerfilesLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.todosPerfilesLbl.Name = "todosPerfilesLbl";
            this.todosPerfilesLbl.Size = new System.Drawing.Size(89, 13);
            this.todosPerfilesLbl.TabIndex = 5;
            this.todosPerfilesLbl.Text = "Todos los perfiles";
            // 
            // familiasLB
            // 
            this.familiasLB.FormattingEnabled = true;
            this.familiasLB.Location = new System.Drawing.Point(16, 39);
            this.familiasLB.Name = "familiasLB";
            this.familiasLB.Size = new System.Drawing.Size(258, 199);
            this.familiasLB.TabIndex = 14;
            // 
            // FormGestionarPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(694, 777);
            this.Controls.Add(this.grpPerfiles);
            this.Controls.Add(this.groupBox3);
            this.Name = "FormGestionarPerfil";
            this.Text = "FormGestionarPerfil";
            this.grpFamilias.ResumeLayout(false);
            this.grpFamilias.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpPatentes.ResumeLayout(false);
            this.grpPatentes.PerformLayout();
            this.grpPerfiles.ResumeLayout(false);
            this.grpPerfiles.PerformLayout();
            this.grpNuevo.ResumeLayout(false);
            this.grpNuevo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpFamilias;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNombreFamilia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label todasFamiliasLbl;
        private System.Windows.Forms.GroupBox grpPatentes;
        private System.Windows.Forms.Label todasPatentesLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox patenteLB;
        private System.Windows.Forms.Button agregarFamiliaBtn;
        private System.Windows.Forms.Button configurarBtn;
        private System.Windows.Forms.Button agregarPatenteBtn;
        private System.Windows.Forms.GroupBox grpPerfiles;
        private System.Windows.Forms.GroupBox grpNuevo;
        private System.Windows.Forms.Button agregarNuevoBtn;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.Label nombreLbl;
        private System.Windows.Forms.TreeView treeViewPerfiles;
        private System.Windows.Forms.Label todosPerfilesLbl;
        private System.Windows.Forms.Button quitarBtn;
        private System.Windows.Forms.Button guardarBtn;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.ListBox familiasLB;
    }
}