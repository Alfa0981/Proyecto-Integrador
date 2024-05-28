namespace Proyecto_Integrador
{
    partial class FormCambiarPass
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
            this.cambiarBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.contraX2Txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contraTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cambiarBtn
            // 
            this.cambiarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.cambiarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.cambiarBtn.FlatAppearance.BorderSize = 0;
            this.cambiarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cambiarBtn.Location = new System.Drawing.Point(123, 164);
            this.cambiarBtn.Name = "cambiarBtn";
            this.cambiarBtn.Size = new System.Drawing.Size(71, 24);
            this.cambiarBtn.TabIndex = 44;
            this.cambiarBtn.Text = "Cambiar";
            this.cambiarBtn.UseVisualStyleBackColor = false;
            this.cambiarBtn.Click += new System.EventHandler(this.cambiarBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Snow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(51, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Repita Contraseña";
            // 
            // contraX2Txt
            // 
            this.contraX2Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.contraX2Txt.Location = new System.Drawing.Point(44, 109);
            this.contraX2Txt.Multiline = true;
            this.contraX2Txt.Name = "contraX2Txt";
            this.contraX2Txt.Size = new System.Drawing.Size(217, 31);
            this.contraX2Txt.TabIndex = 42;
            this.contraX2Txt.Enter += new System.EventHandler(this.contraX2Txt_Enter);
            this.contraX2Txt.Leave += new System.EventHandler(this.contraX2Txt_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(51, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Contraseña";
            // 
            // contraTxt
            // 
            this.contraTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.contraTxt.Location = new System.Drawing.Point(44, 72);
            this.contraTxt.Multiline = true;
            this.contraTxt.Name = "contraTxt";
            this.contraTxt.Size = new System.Drawing.Size(217, 31);
            this.contraTxt.TabIndex = 40;
            this.contraTxt.Enter += new System.EventHandler(this.contraTxt_Enter);
            this.contraTxt.Leave += new System.EventHandler(this.contraTxt_Leave);
            // 
            // FormCambiarPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(305, 260);
            this.Controls.Add(this.cambiarBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contraX2Txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contraTxt);
            this.Name = "FormCambiarPass";
            this.Text = "FormCambiarPass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cambiarBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox contraX2Txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contraTxt;
    }
}