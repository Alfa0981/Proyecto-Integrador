namespace Proyecto_Integrador
{
    partial class BitacoraCambios
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
            this.activarBtn = new System.Windows.Forms.Button();
            this.limpiarBtn = new System.Windows.Forms.Button();
            this.nombreLbl = new System.Windows.Forms.Label();
            this.codProdLbl = new System.Windows.Forms.Label();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.codProdTxt = new System.Windows.Forms.TextBox();
            this.flagFiltrarFechaCheck = new System.Windows.Forms.CheckBox();
            this.fechasGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fechaFinPicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.fechaInicioPicker = new System.Windows.Forms.DateTimePicker();
            this.filtrarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.fechasGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.Location = new System.Drawing.Point(30, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(741, 166);
            this.dataGridView1.TabIndex = 1;
            // 
            // activarBtn
            // 
            this.activarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.activarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.activarBtn.FlatAppearance.BorderSize = 0;
            this.activarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.activarBtn.Location = new System.Drawing.Point(700, 415);
            this.activarBtn.Name = "activarBtn";
            this.activarBtn.Size = new System.Drawing.Size(71, 23);
            this.activarBtn.TabIndex = 14;
            this.activarBtn.Text = "Activar";
            this.activarBtn.UseVisualStyleBackColor = false;
            this.activarBtn.Click += new System.EventHandler(this.activarBtn_Click);
            // 
            // limpiarBtn
            // 
            this.limpiarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.limpiarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.limpiarBtn.FlatAppearance.BorderSize = 0;
            this.limpiarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.limpiarBtn.Location = new System.Drawing.Point(482, 415);
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(71, 23);
            this.limpiarBtn.TabIndex = 13;
            this.limpiarBtn.Text = "Limpiar";
            this.limpiarBtn.UseVisualStyleBackColor = false;
            this.limpiarBtn.Click += new System.EventHandler(this.limpiarBtn_Click);
            // 
            // nombreLbl
            // 
            this.nombreLbl.AutoSize = true;
            this.nombreLbl.BackColor = System.Drawing.Color.Snow;
            this.nombreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.nombreLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.nombreLbl.Location = new System.Drawing.Point(110, 305);
            this.nombreLbl.Name = "nombreLbl";
            this.nombreLbl.Size = new System.Drawing.Size(58, 17);
            this.nombreLbl.TabIndex = 22;
            this.nombreLbl.Text = "Nombre";
            // 
            // codProdLbl
            // 
            this.codProdLbl.AutoSize = true;
            this.codProdLbl.BackColor = System.Drawing.Color.Snow;
            this.codProdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.codProdLbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.codProdLbl.Location = new System.Drawing.Point(110, 251);
            this.codProdLbl.Name = "codProdLbl";
            this.codProdLbl.Size = new System.Drawing.Size(94, 17);
            this.codProdLbl.TabIndex = 21;
            this.codProdLbl.Text = "Cod Producto";
            // 
            // nombreTxt
            // 
            this.nombreTxt.Location = new System.Drawing.Point(107, 298);
            this.nombreTxt.Multiline = true;
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(135, 31);
            this.nombreTxt.TabIndex = 20;
            this.nombreTxt.Enter += new System.EventHandler(this.nombreTxt_Enter);
            this.nombreTxt.Leave += new System.EventHandler(this.nombreTxt_Leave);
            // 
            // codProdTxt
            // 
            this.codProdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.codProdTxt.Location = new System.Drawing.Point(107, 245);
            this.codProdTxt.Multiline = true;
            this.codProdTxt.Name = "codProdTxt";
            this.codProdTxt.Size = new System.Drawing.Size(135, 31);
            this.codProdTxt.TabIndex = 19;
            this.codProdTxt.Enter += new System.EventHandler(this.codProdTxt_Enter);
            this.codProdTxt.Leave += new System.EventHandler(this.codProdTxt_Leave);
            // 
            // flagFiltrarFechaCheck
            // 
            this.flagFiltrarFechaCheck.AutoSize = true;
            this.flagFiltrarFechaCheck.Location = new System.Drawing.Point(361, 274);
            this.flagFiltrarFechaCheck.Name = "flagFiltrarFechaCheck";
            this.flagFiltrarFechaCheck.Size = new System.Drawing.Size(102, 17);
            this.flagFiltrarFechaCheck.TabIndex = 62;
            this.flagFiltrarFechaCheck.Text = "Filtrar por Fecha";
            this.flagFiltrarFechaCheck.UseVisualStyleBackColor = true;
            this.flagFiltrarFechaCheck.CheckedChanged += new System.EventHandler(this.flagFiltrarFechaCheck_CheckedChanged);
            // 
            // fechasGroup
            // 
            this.fechasGroup.Controls.Add(this.label1);
            this.fechasGroup.Controls.Add(this.fechaFinPicker);
            this.fechasGroup.Controls.Add(this.label3);
            this.fechasGroup.Controls.Add(this.fechaInicioPicker);
            this.fechasGroup.Location = new System.Drawing.Point(482, 194);
            this.fechasGroup.Name = "fechasGroup";
            this.fechasGroup.Size = new System.Drawing.Size(289, 190);
            this.fechasGroup.TabIndex = 63;
            this.fechasGroup.TabStop = false;
            this.fechasGroup.Text = "Fechas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Fecha Fin";
            // 
            // fechaFinPicker
            // 
            this.fechaFinPicker.Location = new System.Drawing.Point(41, 141);
            this.fechaFinPicker.Name = "fechaFinPicker";
            this.fechaFinPicker.Size = new System.Drawing.Size(200, 20);
            this.fechaFinPicker.TabIndex = 43;
            this.fechaFinPicker.ValueChanged += new System.EventHandler(this.fechaFinPicker_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Fecha Inicio";
            // 
            // fechaInicioPicker
            // 
            this.fechaInicioPicker.Location = new System.Drawing.Point(41, 62);
            this.fechaInicioPicker.Name = "fechaInicioPicker";
            this.fechaInicioPicker.Size = new System.Drawing.Size(200, 20);
            this.fechaInicioPicker.TabIndex = 44;
            this.fechaInicioPicker.ValueChanged += new System.EventHandler(this.fechaInicioPicker_ValueChanged);
            // 
            // filtrarBtn
            // 
            this.filtrarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.filtrarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.filtrarBtn.FlatAppearance.BorderSize = 0;
            this.filtrarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.filtrarBtn.Location = new System.Drawing.Point(287, 415);
            this.filtrarBtn.Name = "filtrarBtn";
            this.filtrarBtn.Size = new System.Drawing.Size(71, 23);
            this.filtrarBtn.TabIndex = 64;
            this.filtrarBtn.Text = "Filtrar";
            this.filtrarBtn.UseVisualStyleBackColor = false;
            this.filtrarBtn.Click += new System.EventHandler(this.filtrarBtn_Click);
            // 
            // BitacoraCambios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.filtrarBtn);
            this.Controls.Add(this.flagFiltrarFechaCheck);
            this.Controls.Add(this.fechasGroup);
            this.Controls.Add(this.nombreLbl);
            this.Controls.Add(this.codProdLbl);
            this.Controls.Add(this.nombreTxt);
            this.Controls.Add(this.codProdTxt);
            this.Controls.Add(this.activarBtn);
            this.Controls.Add(this.limpiarBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BitacoraCambios";
            this.Text = "BitacoraCambios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.fechasGroup.ResumeLayout(false);
            this.fechasGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button activarBtn;
        private System.Windows.Forms.Button limpiarBtn;
        private System.Windows.Forms.Label nombreLbl;
        private System.Windows.Forms.Label codProdLbl;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.TextBox codProdTxt;
        private System.Windows.Forms.CheckBox flagFiltrarFechaCheck;
        private System.Windows.Forms.GroupBox fechasGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fechaFinPicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fechaInicioPicker;
        private System.Windows.Forms.Button filtrarBtn;
    }
}