namespace Proyecto_Integrador
{
    partial class Login
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
            this.usuarioTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contraTxt = new System.Windows.Forms.TextBox();
            this.ingeresarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usuarioTxt
            // 
            this.usuarioTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.usuarioTxt.Location = new System.Drawing.Point(60, 106);
            this.usuarioTxt.Multiline = true;
            this.usuarioTxt.Name = "usuarioTxt";
            this.usuarioTxt.Size = new System.Drawing.Size(217, 31);
            this.usuarioTxt.TabIndex = 35;
            this.usuarioTxt.Enter += new System.EventHandler(this.usuarioTxt_Enter);
            this.usuarioTxt.Leave += new System.EventHandler(this.usuarioTxt_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(67, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Snow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(67, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Contraseña";
            // 
            // contraTxt
            // 
            this.contraTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.contraTxt.Location = new System.Drawing.Point(60, 143);
            this.contraTxt.Multiline = true;
            this.contraTxt.Name = "contraTxt";
            this.contraTxt.Size = new System.Drawing.Size(217, 31);
            this.contraTxt.TabIndex = 37;
            this.contraTxt.Enter += new System.EventHandler(this.contraTxt_Enter);
            this.contraTxt.Leave += new System.EventHandler(this.contraTxt_Leave);
            // 
            // ingeresarBtn
            // 
            this.ingeresarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.ingeresarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.ingeresarBtn.FlatAppearance.BorderSize = 0;
            this.ingeresarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ingeresarBtn.Location = new System.Drawing.Point(139, 198);
            this.ingeresarBtn.Name = "ingeresarBtn";
            this.ingeresarBtn.Size = new System.Drawing.Size(71, 24);
            this.ingeresarBtn.TabIndex = 39;
            this.ingeresarBtn.Text = "Ingresar";
            this.ingeresarBtn.UseVisualStyleBackColor = false;
            this.ingeresarBtn.Click += new System.EventHandler(this.ingeresarBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(371, 332);
            this.Controls.Add(this.ingeresarBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contraTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usuarioTxt);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usuarioTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox contraTxt;
        private System.Windows.Forms.Button ingeresarBtn;
    }
}