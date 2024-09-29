namespace Proyecto_Integrador
{
    partial class BitacoraEventos
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
            this.aplicarBtn = new System.Windows.Forms.Button();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.apellidoTxt = new System.Windows.Forms.TextBox();
            this.limpiarBtn = new System.Windows.Forms.Button();
            this.imrimirBtn = new System.Windows.Forms.Button();
            this.fechaFinPicker = new System.Windows.Forms.DateTimePicker();
            this.fechaInicioPicker = new System.Windows.Forms.DateTimePicker();
            this.todosPerfilesLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.userCombo = new System.Windows.Forms.ComboBox();
            this.moduloCombo = new System.Windows.Forms.ComboBox();
            this.descripcionCombo = new System.Windows.Forms.ComboBox();
            this.criticidadCombo = new System.Windows.Forms.ComboBox();
            this.flagFiltrarFechaCheck = new System.Windows.Forms.CheckBox();
            this.fechasGroup = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.fechasGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.Location = new System.Drawing.Point(73, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(706, 265);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // aplicarBtn
            // 
            this.aplicarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.aplicarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.aplicarBtn.FlatAppearance.BorderSize = 0;
            this.aplicarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aplicarBtn.Location = new System.Drawing.Point(74, 627);
            this.aplicarBtn.Name = "aplicarBtn";
            this.aplicarBtn.Size = new System.Drawing.Size(71, 23);
            this.aplicarBtn.TabIndex = 24;
            this.aplicarBtn.Text = "Aplicar";
            this.aplicarBtn.UseVisualStyleBackColor = false;
            this.aplicarBtn.Click += new System.EventHandler(this.aplicarBtn_Click);
            // 
            // nombreTxt
            // 
            this.nombreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.nombreTxt.Location = new System.Drawing.Point(282, 320);
            this.nombreTxt.Multiline = true;
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.ReadOnly = true;
            this.nombreTxt.Size = new System.Drawing.Size(106, 31);
            this.nombreTxt.TabIndex = 33;
            // 
            // apellidoTxt
            // 
            this.apellidoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.apellidoTxt.Location = new System.Drawing.Point(437, 320);
            this.apellidoTxt.Multiline = true;
            this.apellidoTxt.Name = "apellidoTxt";
            this.apellidoTxt.ReadOnly = true;
            this.apellidoTxt.Size = new System.Drawing.Size(106, 31);
            this.apellidoTxt.TabIndex = 35;
            // 
            // limpiarBtn
            // 
            this.limpiarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.limpiarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.limpiarBtn.FlatAppearance.BorderSize = 0;
            this.limpiarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.limpiarBtn.Location = new System.Drawing.Point(228, 627);
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(71, 23);
            this.limpiarBtn.TabIndex = 37;
            this.limpiarBtn.Text = "Limpiar";
            this.limpiarBtn.UseVisualStyleBackColor = false;
            this.limpiarBtn.Click += new System.EventHandler(this.limpiarBtn_Click);
            // 
            // imrimirBtn
            // 
            this.imrimirBtn.BackColor = System.Drawing.Color.IndianRed;
            this.imrimirBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.imrimirBtn.FlatAppearance.BorderSize = 0;
            this.imrimirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.imrimirBtn.Location = new System.Drawing.Point(387, 627);
            this.imrimirBtn.Name = "imrimirBtn";
            this.imrimirBtn.Size = new System.Drawing.Size(71, 23);
            this.imrimirBtn.TabIndex = 38;
            this.imrimirBtn.Text = "Imprimir";
            this.imrimirBtn.UseVisualStyleBackColor = false;
            this.imrimirBtn.Click += new System.EventHandler(this.imrimirBtn_Click);
            // 
            // fechaFinPicker
            // 
            this.fechaFinPicker.Location = new System.Drawing.Point(41, 173);
            this.fechaFinPicker.Name = "fechaFinPicker";
            this.fechaFinPicker.Size = new System.Drawing.Size(200, 20);
            this.fechaFinPicker.TabIndex = 43;
            this.fechaFinPicker.ValueChanged += new System.EventHandler(this.fechaFinPicker_ValueChanged);
            // 
            // fechaInicioPicker
            // 
            this.fechaInicioPicker.Location = new System.Drawing.Point(41, 62);
            this.fechaInicioPicker.Name = "fechaInicioPicker";
            this.fechaInicioPicker.Size = new System.Drawing.Size(200, 20);
            this.fechaInicioPicker.TabIndex = 44;
            this.fechaInicioPicker.ValueChanged += new System.EventHandler(this.fechaInicioPicker_ValueChanged);
            // 
            // todosPerfilesLbl
            // 
            this.todosPerfilesLbl.AutoSize = true;
            this.todosPerfilesLbl.Location = new System.Drawing.Point(122, 393);
            this.todosPerfilesLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.todosPerfilesLbl.Name = "todosPerfilesLbl";
            this.todosPerfilesLbl.Size = new System.Drawing.Size(57, 13);
            this.todosPerfilesLbl.TabIndex = 45;
            this.todosPerfilesLbl.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Fecha Inicio";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Fecha Fin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 504);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Modulo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 504);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Descripcion Evento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 393);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Criticidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 294);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(468, 294);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Apellido";
            // 
            // userCombo
            // 
            this.userCombo.FormattingEnabled = true;
            this.userCombo.Location = new System.Drawing.Point(92, 431);
            this.userCombo.Name = "userCombo";
            this.userCombo.Size = new System.Drawing.Size(121, 21);
            this.userCombo.TabIndex = 56;
            // 
            // moduloCombo
            // 
            this.moduloCombo.FormattingEnabled = true;
            this.moduloCombo.Location = new System.Drawing.Point(92, 541);
            this.moduloCombo.Name = "moduloCombo";
            this.moduloCombo.Size = new System.Drawing.Size(121, 21);
            this.moduloCombo.TabIndex = 57;
            this.moduloCombo.SelectedIndexChanged += new System.EventHandler(this.moduloCombo_SelectedIndexChanged);
            // 
            // descripcionCombo
            // 
            this.descripcionCombo.FormattingEnabled = true;
            this.descripcionCombo.Location = new System.Drawing.Point(301, 541);
            this.descripcionCombo.Name = "descripcionCombo";
            this.descripcionCombo.Size = new System.Drawing.Size(121, 21);
            this.descripcionCombo.TabIndex = 58;
            // 
            // criticidadCombo
            // 
            this.criticidadCombo.FormattingEnabled = true;
            this.criticidadCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.criticidadCombo.Location = new System.Drawing.Point(301, 430);
            this.criticidadCombo.Name = "criticidadCombo";
            this.criticidadCombo.Size = new System.Drawing.Size(121, 21);
            this.criticidadCombo.TabIndex = 59;
            // 
            // flagFiltrarFechaCheck
            // 
            this.flagFiltrarFechaCheck.AutoSize = true;
            this.flagFiltrarFechaCheck.Location = new System.Drawing.Point(588, 334);
            this.flagFiltrarFechaCheck.Name = "flagFiltrarFechaCheck";
            this.flagFiltrarFechaCheck.Size = new System.Drawing.Size(102, 17);
            this.flagFiltrarFechaCheck.TabIndex = 60;
            this.flagFiltrarFechaCheck.Text = "Filtrar por Fecha";
            this.flagFiltrarFechaCheck.UseVisualStyleBackColor = true;
            this.flagFiltrarFechaCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // fechasGroup
            // 
            this.fechasGroup.Controls.Add(this.label1);
            this.fechasGroup.Controls.Add(this.fechaFinPicker);
            this.fechasGroup.Controls.Add(this.label2);
            this.fechasGroup.Controls.Add(this.fechaInicioPicker);
            this.fechasGroup.Location = new System.Drawing.Point(490, 369);
            this.fechasGroup.Name = "fechasGroup";
            this.fechasGroup.Size = new System.Drawing.Size(289, 229);
            this.fechasGroup.TabIndex = 61;
            this.fechasGroup.TabStop = false;
            this.fechasGroup.Text = "Fechas";
            // 
            // BitacoraEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(800, 662);
            this.Controls.Add(this.flagFiltrarFechaCheck);
            this.Controls.Add(this.criticidadCombo);
            this.Controls.Add(this.descripcionCombo);
            this.Controls.Add(this.moduloCombo);
            this.Controls.Add(this.userCombo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.todosPerfilesLbl);
            this.Controls.Add(this.imrimirBtn);
            this.Controls.Add(this.limpiarBtn);
            this.Controls.Add(this.apellidoTxt);
            this.Controls.Add(this.nombreTxt);
            this.Controls.Add(this.aplicarBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.fechasGroup);
            this.Name = "BitacoraEventos";
            this.Text = "BitacoraEventos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.fechasGroup.ResumeLayout(false);
            this.fechasGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button aplicarBtn;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.TextBox apellidoTxt;
        private System.Windows.Forms.Button limpiarBtn;
        private System.Windows.Forms.Button imrimirBtn;
        private System.Windows.Forms.DateTimePicker fechaFinPicker;
        private System.Windows.Forms.DateTimePicker fechaInicioPicker;
        private System.Windows.Forms.Label todosPerfilesLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox userCombo;
        private System.Windows.Forms.ComboBox moduloCombo;
        private System.Windows.Forms.ComboBox descripcionCombo;
        private System.Windows.Forms.ComboBox criticidadCombo;
        private System.Windows.Forms.CheckBox flagFiltrarFechaCheck;
        private System.Windows.Forms.GroupBox fechasGroup;
    }
}