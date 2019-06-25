namespace Library
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbPatronymic = new System.Windows.Forms.Label();
            this.tbPatronymic = new System.Windows.Forms.TextBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbRepeatPassword = new System.Windows.Forms.Label();
            this.tbRepeatPassword = new System.Windows.Forms.TextBox();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.btnAuthorization = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            resources.ApplyResources(this.lbTitle, "lbTitle");
            this.lbTitle.Name = "lbTitle";
            // 
            // lbSurname
            // 
            resources.ApplyResources(this.lbSurname, "lbSurname");
            this.lbSurname.Name = "lbSurname";
            // 
            // tbSurname
            // 
            resources.ApplyResources(this.tbSurname, "tbSurname");
            this.tbSurname.Name = "tbSurname";
            // 
            // lbName
            // 
            resources.ApplyResources(this.lbName, "lbName");
            this.lbName.Name = "lbName";
            // 
            // tbName
            // 
            resources.ApplyResources(this.tbName, "tbName");
            this.tbName.Name = "tbName";
            // 
            // lbPatronymic
            // 
            resources.ApplyResources(this.lbPatronymic, "lbPatronymic");
            this.lbPatronymic.Name = "lbPatronymic";
            // 
            // tbPatronymic
            // 
            resources.ApplyResources(this.tbPatronymic, "tbPatronymic");
            this.tbPatronymic.Name = "tbPatronymic";
            // 
            // lbLogin
            // 
            resources.ApplyResources(this.lbLogin, "lbLogin");
            this.lbLogin.Name = "lbLogin";
            // 
            // tbLogin
            // 
            resources.ApplyResources(this.tbLogin, "tbLogin");
            this.tbLogin.Name = "tbLogin";
            // 
            // lbPassword
            // 
            resources.ApplyResources(this.lbPassword, "lbPassword");
            this.lbPassword.Name = "lbPassword";
            // 
            // tbPassword
            // 
            resources.ApplyResources(this.tbPassword, "tbPassword");
            this.tbPassword.Name = "tbPassword";
            // 
            // lbRepeatPassword
            // 
            resources.ApplyResources(this.lbRepeatPassword, "lbRepeatPassword");
            this.lbRepeatPassword.Name = "lbRepeatPassword";
            // 
            // tbRepeatPassword
            // 
            resources.ApplyResources(this.tbRepeatPassword, "tbRepeatPassword");
            this.tbRepeatPassword.Name = "tbRepeatPassword";
            // 
            // btnRegistration
            // 
            resources.ApplyResources(this.btnRegistration, "btnRegistration");
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // btnAuthorization
            // 
            resources.ApplyResources(this.btnAuthorization, "btnAuthorization");
            this.btnAuthorization.Name = "btnAuthorization";
            this.btnAuthorization.UseVisualStyleBackColor = true;
            this.btnAuthorization.Click += new System.EventHandler(this.btnAuthorization_Click);
            // 
            // RegistrationForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnAuthorization);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.tbRepeatPassword);
            this.Controls.Add(this.lbRepeatPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.tbPatronymic);
            this.Controls.Add(this.lbPatronymic);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.lbSurname);
            this.Controls.Add(this.lbTitle);
            this.Name = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbPatronymic;
        private System.Windows.Forms.TextBox tbPatronymic;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbRepeatPassword;
        private System.Windows.Forms.TextBox tbRepeatPassword;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.Button btnAuthorization;
    }
}