namespace Proyecto_Integrador
{
    partial class BackupRestore
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
            this.backupPathTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.aplicarBtn = new System.Windows.Forms.Button();
            this.realizarBackupBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.restoreTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // backupPathTxt
            // 
            this.backupPathTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.backupPathTxt.Location = new System.Drawing.Point(12, 51);
            this.backupPathTxt.Multiline = true;
            this.backupPathTxt.Name = "backupPathTxt";
            this.backupPathTxt.ReadOnly = true;
            this.backupPathTxt.Size = new System.Drawing.Size(185, 31);
            this.backupPathTxt.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Path Backup";
            // 
            // aplicarBtn
            // 
            this.aplicarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.aplicarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.aplicarBtn.FlatAppearance.BorderSize = 0;
            this.aplicarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aplicarBtn.Location = new System.Drawing.Point(241, 59);
            this.aplicarBtn.Name = "aplicarBtn";
            this.aplicarBtn.Size = new System.Drawing.Size(71, 23);
            this.aplicarBtn.TabIndex = 56;
            this.aplicarBtn.Text = "Buscar";
            this.aplicarBtn.UseVisualStyleBackColor = false;
            this.aplicarBtn.Click += new System.EventHandler(this.aplicarBtn_Click);
            // 
            // realizarBackupBtn
            // 
            this.realizarBackupBtn.BackColor = System.Drawing.Color.IndianRed;
            this.realizarBackupBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.realizarBackupBtn.FlatAppearance.BorderSize = 0;
            this.realizarBackupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.realizarBackupBtn.Location = new System.Drawing.Point(75, 118);
            this.realizarBackupBtn.Name = "realizarBackupBtn";
            this.realizarBackupBtn.Size = new System.Drawing.Size(71, 23);
            this.realizarBackupBtn.TabIndex = 57;
            this.realizarBackupBtn.Text = "Realizar";
            this.realizarBackupBtn.UseVisualStyleBackColor = false;
            this.realizarBackupBtn.Click += new System.EventHandler(this.realizarBackupBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(75, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 23);
            this.button2.TabIndex = 61;
            this.button2.Text = "Realizar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.IndianRed;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(241, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 23);
            this.button3.TabIndex = 60;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 189);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Path Restore";
            // 
            // restoreTxt
            // 
            this.restoreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.restoreTxt.Location = new System.Drawing.Point(12, 216);
            this.restoreTxt.Multiline = true;
            this.restoreTxt.Name = "restoreTxt";
            this.restoreTxt.ReadOnly = true;
            this.restoreTxt.Size = new System.Drawing.Size(185, 31);
            this.restoreTxt.TabIndex = 58;
            // 
            // BackupRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(336, 351);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.restoreTxt);
            this.Controls.Add(this.realizarBackupBtn);
            this.Controls.Add(this.aplicarBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.backupPathTxt);
            this.Name = "BackupRestore";
            this.Text = "BackupRestore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox backupPathTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button aplicarBtn;
        private System.Windows.Forms.Button realizarBackupBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox restoreTxt;
    }
}