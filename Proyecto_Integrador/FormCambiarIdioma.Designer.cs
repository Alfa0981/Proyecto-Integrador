namespace Proyecto_Integrador
{
    partial class FormCambiarIdioma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCambiarIdioma));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cambiarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cambiarBtn
            // 
            this.cambiarBtn.BackColor = System.Drawing.Color.IndianRed;
            this.cambiarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.cambiarBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.cambiarBtn, "cambiarBtn");
            this.cambiarBtn.Name = "cambiarBtn";
            this.cambiarBtn.UseVisualStyleBackColor = false;
            this.cambiarBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // FormCambiarIdioma
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cambiarBtn);
            this.Controls.Add(this.comboBox1);
            this.Name = "FormCambiarIdioma";
            this.Load += new System.EventHandler(this.FormCambiarIdioma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button cambiarBtn;
        private System.Windows.Forms.Label label1;
    }
}