namespace Proyecto_Integrador
{
    partial class ReparacionDB
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
            this.textoLbl = new System.Windows.Forms.Label();
            this.recalcularBtn = new System.Windows.Forms.Button();
            this.restoreBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoLbl
            // 
            this.textoLbl.AutoSize = true;
            this.textoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textoLbl.Location = new System.Drawing.Point(63, 64);
            this.textoLbl.Name = "textoLbl";
            this.textoLbl.Size = new System.Drawing.Size(286, 17);
            this.textoLbl.TabIndex = 0;
            this.textoLbl.Text = "Inconsistencia encontra en la base de datos";
            // 
            // recalcularBtn
            // 
            this.recalcularBtn.BackColor = System.Drawing.Color.IndianRed;
            this.recalcularBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.recalcularBtn.FlatAppearance.BorderSize = 0;
            this.recalcularBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.recalcularBtn.Location = new System.Drawing.Point(157, 119);
            this.recalcularBtn.Name = "recalcularBtn";
            this.recalcularBtn.Size = new System.Drawing.Size(105, 39);
            this.recalcularBtn.TabIndex = 11;
            this.recalcularBtn.Text = "Recalcular DB";
            this.recalcularBtn.UseVisualStyleBackColor = false;
            // 
            // restoreBtn
            // 
            this.restoreBtn.BackColor = System.Drawing.Color.IndianRed;
            this.restoreBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.restoreBtn.FlatAppearance.BorderSize = 0;
            this.restoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.restoreBtn.Location = new System.Drawing.Point(157, 187);
            this.restoreBtn.Name = "restoreBtn";
            this.restoreBtn.Size = new System.Drawing.Size(105, 39);
            this.restoreBtn.TabIndex = 12;
            this.restoreBtn.Text = "Restore DB";
            this.restoreBtn.UseVisualStyleBackColor = false;
            // 
            // ReparacionDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(397, 316);
            this.Controls.Add(this.restoreBtn);
            this.Controls.Add(this.recalcularBtn);
            this.Controls.Add(this.textoLbl);
            this.Name = "ReparacionDB";
            this.Text = "ReparacionDB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textoLbl;
        private System.Windows.Forms.Button recalcularBtn;
        private System.Windows.Forms.Button restoreBtn;
    }
}