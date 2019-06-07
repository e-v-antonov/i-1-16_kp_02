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
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(311, 32);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Регистрация";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbSurname
            // 
            this.lbSurname.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSurname.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSurname.Location = new System.Drawing.Point(0, 32);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(311, 24);
            this.lbSurname.TabIndex = 2;
            this.lbSurname.Text = "Фамилия:";
            // 
            // tbSurname
            // 
            this.tbSurname.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSurname.Location = new System.Drawing.Point(0, 56);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(311, 23);
            this.tbSurname.TabIndex = 4;
            // 
            // lbName
            // 
            this.lbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(0, 79);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(311, 24);
            this.lbName.TabIndex = 5;
            this.lbName.Text = "Имя:";
            // 
            // tbName
            // 
            this.tbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbName.Location = new System.Drawing.Point(0, 103);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(311, 23);
            this.tbName.TabIndex = 6;
            // 
            // lbPatronymic
            // 
            this.lbPatronymic.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPatronymic.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPatronymic.Location = new System.Drawing.Point(0, 126);
            this.lbPatronymic.Name = "lbPatronymic";
            this.lbPatronymic.Size = new System.Drawing.Size(311, 24);
            this.lbPatronymic.TabIndex = 7;
            this.lbPatronymic.Text = "Отчество:";
            // 
            // tbPatronymic
            // 
            this.tbPatronymic.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPatronymic.Location = new System.Drawing.Point(0, 150);
            this.tbPatronymic.Name = "tbPatronymic";
            this.tbPatronymic.Size = new System.Drawing.Size(311, 23);
            this.tbPatronymic.TabIndex = 8;
            // 
            // lbLogin
            // 
            this.lbLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbLogin.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLogin.Location = new System.Drawing.Point(0, 173);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(311, 24);
            this.lbLogin.TabIndex = 9;
            this.lbLogin.Text = "Логин:";
            // 
            // tbLogin
            // 
            this.tbLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbLogin.Location = new System.Drawing.Point(0, 197);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(311, 23);
            this.tbLogin.TabIndex = 10;
            // 
            // lbPassword
            // 
            this.lbPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPassword.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPassword.Location = new System.Drawing.Point(0, 220);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(311, 24);
            this.lbPassword.TabIndex = 11;
            this.lbPassword.Text = "Пароль:";
            // 
            // tbPassword
            // 
            this.tbPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPassword.Location = new System.Drawing.Point(0, 244);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(311, 23);
            this.tbPassword.TabIndex = 12;
            // 
            // lbRepeatPassword
            // 
            this.lbRepeatPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbRepeatPassword.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRepeatPassword.Location = new System.Drawing.Point(0, 267);
            this.lbRepeatPassword.Name = "lbRepeatPassword";
            this.lbRepeatPassword.Size = new System.Drawing.Size(311, 24);
            this.lbRepeatPassword.TabIndex = 13;
            this.lbRepeatPassword.Text = "Повторите пароль:";
            // 
            // tbRepeatPassword
            // 
            this.tbRepeatPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbRepeatPassword.Location = new System.Drawing.Point(0, 291);
            this.tbRepeatPassword.Name = "tbRepeatPassword";
            this.tbRepeatPassword.Size = new System.Drawing.Size(311, 23);
            this.tbRepeatPassword.TabIndex = 14;
            // 
            // btnRegistration
            // 
            this.btnRegistration.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistration.Location = new System.Drawing.Point(0, 314);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(311, 23);
            this.btnRegistration.TabIndex = 15;
            this.btnRegistration.Text = "Зарегестрироваться";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // btnAuthorization
            // 
            this.btnAuthorization.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAuthorization.Location = new System.Drawing.Point(0, 337);
            this.btnAuthorization.Name = "btnAuthorization";
            this.btnAuthorization.Size = new System.Drawing.Size(311, 23);
            this.btnAuthorization.TabIndex = 16;
            this.btnAuthorization.Text = "Авторизация";
            this.btnAuthorization.UseVisualStyleBackColor = true;
            this.btnAuthorization.Click += new System.EventHandler(this.btnAuthorization_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(311, 358);
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
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
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