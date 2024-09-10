namespace Proyecto_Integrador
{
    partial class NotificarProveedorForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.mensajeTxt = new System.Windows.Forms.TextBox();
            this.notificarBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productoTotalTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(436, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Mensaje Adicional";
            // 
            // mensajeTxt
            // 
            this.mensajeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.mensajeTxt.Location = new System.Drawing.Point(433, 26);
            this.mensajeTxt.Multiline = true;
            this.mensajeTxt.Name = "mensajeTxt";
            this.mensajeTxt.Size = new System.Drawing.Size(321, 313);
            this.mensajeTxt.TabIndex = 33;
            // 
            // notificarBtn
            // 
            this.notificarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.notificarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.notificarBtn.FlatAppearance.BorderSize = 0;
            this.notificarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.notificarBtn.Location = new System.Drawing.Point(562, 359);
            this.notificarBtn.Name = "notificarBtn";
            this.notificarBtn.Size = new System.Drawing.Size(71, 23);
            this.notificarBtn.TabIndex = 35;
            this.notificarBtn.Text = "Notificar";
            this.notificarBtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.Location = new System.Drawing.Point(21, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(397, 268);
            this.dataGridView1.TabIndex = 36;
            // 
            // productoTotalTxt
            // 
            this.productoTotalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.productoTotalTxt.Location = new System.Drawing.Point(227, 308);
            this.productoTotalTxt.Multiline = true;
            this.productoTotalTxt.Name = "productoTotalTxt";
            this.productoTotalTxt.Size = new System.Drawing.Size(191, 31);
            this.productoTotalTxt.TabIndex = 39;
            // 
            // NotificarProveedorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.productoTotalTxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.notificarBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mensajeTxt);
            this.Name = "NotificarProveedorForm";
            this.Text = "NotificarProveedorForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mensajeTxt;
        private System.Windows.Forms.Button notificarBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox productoTotalTxt;
    }
}