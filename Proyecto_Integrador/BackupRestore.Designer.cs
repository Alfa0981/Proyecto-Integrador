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
            this.pathBackupLbl = new System.Windows.Forms.Label();
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
            this.backupPathTxt.Location = new System.Drawing.Point(22, 94);
            this.backupPathTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.backupPathTxt.Multiline = true;
            this.backupPathTxt.Name = "backupPathTxt";
            this.backupPathTxt.ReadOnly = true;
            this.backupPathTxt.Size = new System.Drawing.Size(692, 54);
            this.backupPathTxt.TabIndex = 34;
            // 
            // pathBackupLbl
            // 
            this.pathBackupLbl.AutoSize = true;
            this.pathBackupLbl.Location = new System.Drawing.Point(20, 44);
            this.pathBackupLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pathBackupLbl.Name = "pathBackupLbl";
            this.pathBackupLbl.Size = new System.Drawing.Size(123, 25);
            this.pathBackupLbl.TabIndex = 55;
            this.pathBackupLbl.Text = "Path Backup";
            // 
            // aplicarBtn
            // 
            this.aplicarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.aplicarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.aplicarBtn.FlatAppearance.BorderSize = 0;
            this.aplicarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aplicarBtn.Location = new System.Drawing.Point(764, 106);
            this.aplicarBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.aplicarBtn.Name = "aplicarBtn";
            this.aplicarBtn.Size = new System.Drawing.Size(130, 42);
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
            this.realizarBackupBtn.Location = new System.Drawing.Point(138, 218);
            this.realizarBackupBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.realizarBackupBtn.Name = "realizarBackupBtn";
            this.realizarBackupBtn.Size = new System.Drawing.Size(130, 42);
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
            this.button2.Location = new System.Drawing.Point(138, 522);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 42);
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
            this.button3.Location = new System.Drawing.Point(764, 414);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 42);
            this.button3.TabIndex = 60;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 349);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 59;
            this.label1.Text = "Path Restore";
            // 
            // restoreTxt
            // 
            this.restoreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.restoreTxt.Location = new System.Drawing.Point(22, 399);
            this.restoreTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.restoreTxt.Multiline = true;
            this.restoreTxt.Name = "restoreTxt";
            this.restoreTxt.ReadOnly = true;
            this.restoreTxt.Size = new System.Drawing.Size(692, 54);
            this.restoreTxt.TabIndex = 58;
            // 
            // BackupRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1006, 648);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.restoreTxt);
            this.Controls.Add(this.realizarBackupBtn);
            this.Controls.Add(this.aplicarBtn);
            this.Controls.Add(this.pathBackupLbl);
            this.Controls.Add(this.backupPathTxt);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "BackupRestore";
            this.Text = "BackupRestore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox backupPathTxt;
        private System.Windows.Forms.Label pathBackupLbl;
        private System.Windows.Forms.Button aplicarBtn;
        private System.Windows.Forms.Button realizarBackupBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox restoreTxt;
    }
}