namespace Proyecto_Integrador
{
    partial class OrdenCompraForm
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
            this.notificarBtn = new System.Windows.Forms.Button();
            this.removerBtn = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.totalTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // notificarBtn
            // 
            this.notificarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.notificarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.notificarBtn.FlatAppearance.BorderSize = 0;
            this.notificarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.notificarBtn.Location = new System.Drawing.Point(550, 182);
            this.notificarBtn.Name = "notificarBtn";
            this.notificarBtn.Size = new System.Drawing.Size(71, 38);
            this.notificarBtn.TabIndex = 57;
            this.notificarBtn.Text = "Generar Orden";
            this.notificarBtn.UseVisualStyleBackColor = false;
            // 
            // removerBtn
            // 
            this.removerBtn.BackColor = System.Drawing.Color.IndianRed;
            this.removerBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.removerBtn.FlatAppearance.BorderSize = 0;
            this.removerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removerBtn.Location = new System.Drawing.Point(473, 182);
            this.removerBtn.Name = "removerBtn";
            this.removerBtn.Size = new System.Drawing.Size(71, 38);
            this.removerBtn.TabIndex = 56;
            this.removerBtn.Text = "Remover";
            this.removerBtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView3.Location = new System.Drawing.Point(29, 26);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(592, 150);
            this.dataGridView3.TabIndex = 64;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(651, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 25);
            this.comboBox1.TabIndex = 80;
            // 
            // totalTxt
            // 
            this.totalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.totalTxt.Location = new System.Drawing.Point(649, 89);
            this.totalTxt.Multiline = true;
            this.totalTxt.Name = "totalTxt";
            this.totalTxt.Size = new System.Drawing.Size(123, 31);
            this.totalTxt.TabIndex = 81;
            // 
            // OrdenCompraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(800, 286);
            this.Controls.Add(this.totalTxt);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.notificarBtn);
            this.Controls.Add(this.removerBtn);
            this.Name = "OrdenCompraForm";
            this.Text = "OrdenCompraForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button notificarBtn;
        private System.Windows.Forms.Button removerBtn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox totalTxt;
    }
}