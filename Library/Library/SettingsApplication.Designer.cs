namespace Library
{
    partial class SettingsApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsApplication));
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.btnChangeLanguage = new System.Windows.Forms.Button();
            this.pnLabelPath = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.lbPath = new System.Windows.Forms.Label();
            this.pnLanguage = new System.Windows.Forms.Panel();
            this.fbdPath = new System.Windows.Forms.FolderBrowserDialog();
            this.pnLabelPath.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbLanguage
            // 
            resources.ApplyResources(this.cbLanguage, "cbLanguage");
            this.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Name = "cbLanguage";
            // 
            // btnChangeLanguage
            // 
            resources.ApplyResources(this.btnChangeLanguage, "btnChangeLanguage");
            this.btnChangeLanguage.Name = "btnChangeLanguage";
            this.btnChangeLanguage.UseVisualStyleBackColor = true;
            this.btnChangeLanguage.Click += new System.EventHandler(this.ChangeLanguage_Click);
            // 
            // pnLabelPath
            // 
            this.pnLabelPath.Controls.Add(this.panel2);
            this.pnLabelPath.Controls.Add(this.lbPath);
            resources.ApplyResources(this.pnLabelPath, "pnLabelPath");
            this.pnLabelPath.Name = "pnLabelPath";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbPath);
            this.panel2.Controls.Add(this.btnPath);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // tbPath
            // 
            resources.ApplyResources(this.tbPath, "tbPath");
            this.tbPath.Name = "tbPath";
            // 
            // btnPath
            // 
            resources.ApplyResources(this.btnPath, "btnPath");
            this.btnPath.Name = "btnPath";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // lbPath
            // 
            resources.ApplyResources(this.lbPath, "lbPath");
            this.lbPath.Name = "lbPath";
            // 
            // pnLanguage
            // 
            this.pnLanguage.Controls.Add(this.btnChangeLanguage);
            this.pnLanguage.Controls.Add(this.cbLanguage);
            resources.ApplyResources(this.pnLanguage, "pnLanguage");
            this.pnLanguage.Name = "pnLanguage";
            // 
            // SettingsApplication
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnLanguage);
            this.Controls.Add(this.pnLabelPath);
            this.Name = "SettingsApplication";
            this.Load += new System.EventHandler(this.SettingsApplication_Load);
            this.pnLabelPath.ResumeLayout(false);
            this.pnLabelPath.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnLanguage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.Button btnChangeLanguage;
        private System.Windows.Forms.Panel pnLabelPath;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Panel pnLanguage;
        private System.Windows.Forms.FolderBrowserDialog fbdPath;
    }
}