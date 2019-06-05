namespace Library
{
    partial class UsersForm
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
            this.gbSearchAndFiltration = new System.Windows.Forms.GroupBox();
            this.pnFiltration = new System.Windows.Forms.Panel();
            this.chbFiltration = new System.Windows.Forms.CheckBox();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.pnCancel = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnError = new System.Windows.Forms.Button();
            this.gbManipulationData = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdatePost = new System.Windows.Forms.Button();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.lbPost = new System.Windows.Forms.Label();
            this.tbRepeatPassword = new System.Windows.Forms.TextBox();
            this.lbRepeatPssword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.tbPatronymic = new System.Windows.Forms.TextBox();
            this.lbPatronymic = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.lbSurname = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.gbSearchAndFiltration.SuspendLayout();
            this.pnFiltration.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.pnCancel.SuspendLayout();
            this.gbManipulationData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSearchAndFiltration
            // 
            this.gbSearchAndFiltration.Controls.Add(this.pnFiltration);
            this.gbSearchAndFiltration.Controls.Add(this.pnSearch);
            this.gbSearchAndFiltration.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSearchAndFiltration.Location = new System.Drawing.Point(0, 0);
            this.gbSearchAndFiltration.Name = "gbSearchAndFiltration";
            this.gbSearchAndFiltration.Size = new System.Drawing.Size(1072, 48);
            this.gbSearchAndFiltration.TabIndex = 2;
            this.gbSearchAndFiltration.TabStop = false;
            this.gbSearchAndFiltration.Text = "Поиск и фильтрация:";
            // 
            // pnFiltration
            // 
            this.pnFiltration.Controls.Add(this.chbFiltration);
            this.pnFiltration.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnFiltration.Location = new System.Drawing.Point(928, 19);
            this.pnFiltration.Name = "pnFiltration";
            this.pnFiltration.Size = new System.Drawing.Size(128, 26);
            this.pnFiltration.TabIndex = 1;
            // 
            // chbFiltration
            // 
            this.chbFiltration.AutoSize = true;
            this.chbFiltration.Dock = System.Windows.Forms.DockStyle.Right;
            this.chbFiltration.Location = new System.Drawing.Point(-24, 0);
            this.chbFiltration.Name = "chbFiltration";
            this.chbFiltration.Size = new System.Drawing.Size(152, 26);
            this.chbFiltration.TabIndex = 0;
            this.chbFiltration.Text = "Отфильтровывать";
            this.chbFiltration.UseVisualStyleBackColor = true;
            this.chbFiltration.CheckedChanged += new System.EventHandler(this.chbFiltration_CheckedChanged);
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.tbSearch);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSearch.Location = new System.Drawing.Point(3, 19);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(925, 26);
            this.pnSearch.TabIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSearch.Location = new System.Drawing.Point(0, 0);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(925, 23);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.Text = "Введите данные пользователя...";
            this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
            this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
            // 
            // pnCancel
            // 
            this.pnCancel.Controls.Add(this.btnExit);
            this.pnCancel.Controls.Add(this.btnError);
            this.pnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCancel.Location = new System.Drawing.Point(0, 434);
            this.pnCancel.Name = "pnCancel";
            this.pnCancel.Size = new System.Drawing.Size(1072, 36);
            this.pnCancel.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Location = new System.Drawing.Point(953, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 36);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Закрыть";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnError
            // 
            this.btnError.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnError.Location = new System.Drawing.Point(0, 0);
            this.btnError.Name = "btnError";
            this.btnError.Size = new System.Drawing.Size(119, 36);
            this.btnError.TabIndex = 0;
            this.btnError.Text = "Ошибки";
            this.btnError.UseVisualStyleBackColor = true;
            this.btnError.Click += new System.EventHandler(this.btnError_Click);
            // 
            // gbManipulationData
            // 
            this.gbManipulationData.Controls.Add(this.btnDelete);
            this.gbManipulationData.Controls.Add(this.btnUpdate);
            this.gbManipulationData.Controls.Add(this.btnInsert);
            this.gbManipulationData.Controls.Add(this.btnUpdatePost);
            this.gbManipulationData.Controls.Add(this.cbRole);
            this.gbManipulationData.Controls.Add(this.lbPost);
            this.gbManipulationData.Controls.Add(this.tbRepeatPassword);
            this.gbManipulationData.Controls.Add(this.lbRepeatPssword);
            this.gbManipulationData.Controls.Add(this.tbPassword);
            this.gbManipulationData.Controls.Add(this.lbPassword);
            this.gbManipulationData.Controls.Add(this.tbLogin);
            this.gbManipulationData.Controls.Add(this.lbLogin);
            this.gbManipulationData.Controls.Add(this.tbPatronymic);
            this.gbManipulationData.Controls.Add(this.lbPatronymic);
            this.gbManipulationData.Controls.Add(this.tbName);
            this.gbManipulationData.Controls.Add(this.lbName);
            this.gbManipulationData.Controls.Add(this.tbSurname);
            this.gbManipulationData.Controls.Add(this.lbSurname);
            this.gbManipulationData.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbManipulationData.Location = new System.Drawing.Point(0, 48);
            this.gbManipulationData.Name = "gbManipulationData";
            this.gbManipulationData.Size = new System.Drawing.Size(264, 386);
            this.gbManipulationData.TabIndex = 4;
            this.gbManipulationData.TabStop = false;
            this.gbManipulationData.Text = "Манипулирование данными:";
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.Location = new System.Drawing.Point(3, 362);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(258, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Удалить пользователя";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdate.Location = new System.Drawing.Point(3, 339);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(258, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Изменить данные";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInsert.Location = new System.Drawing.Point(3, 316);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(258, 23);
            this.btnInsert.TabIndex = 14;
            this.btnInsert.Text = "Добавить пользователя";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdatePost
            // 
            this.btnUpdatePost.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdatePost.Location = new System.Drawing.Point(3, 293);
            this.btnUpdatePost.Name = "btnUpdatePost";
            this.btnUpdatePost.Size = new System.Drawing.Size(258, 23);
            this.btnUpdatePost.TabIndex = 13;
            this.btnUpdatePost.Text = "Редактирование данных должностей";
            this.btnUpdatePost.UseVisualStyleBackColor = true;
            this.btnUpdatePost.Click += new System.EventHandler(this.btnUpdatePost_Click);
            // 
            // cbRole
            // 
            this.cbRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(3, 269);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(258, 24);
            this.cbRole.TabIndex = 5;
            // 
            // lbPost
            // 
            this.lbPost.AutoSize = true;
            this.lbPost.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPost.Location = new System.Drawing.Point(3, 253);
            this.lbPost.Name = "lbPost";
            this.lbPost.Size = new System.Drawing.Size(80, 16);
            this.lbPost.TabIndex = 12;
            this.lbPost.Text = "Должность";
            // 
            // tbRepeatPassword
            // 
            this.tbRepeatPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbRepeatPassword.Location = new System.Drawing.Point(3, 230);
            this.tbRepeatPassword.MaxLength = 16;
            this.tbRepeatPassword.Name = "tbRepeatPassword";
            this.tbRepeatPassword.Size = new System.Drawing.Size(258, 23);
            this.tbRepeatPassword.TabIndex = 11;
            // 
            // lbRepeatPssword
            // 
            this.lbRepeatPssword.AutoSize = true;
            this.lbRepeatPssword.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbRepeatPssword.Location = new System.Drawing.Point(3, 214);
            this.lbRepeatPssword.Name = "lbRepeatPssword";
            this.lbRepeatPssword.Size = new System.Drawing.Size(130, 16);
            this.lbRepeatPssword.TabIndex = 10;
            this.lbRepeatPssword.Text = "Повторите пароль";
            // 
            // tbPassword
            // 
            this.tbPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPassword.Location = new System.Drawing.Point(3, 191);
            this.tbPassword.MaxLength = 16;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(258, 23);
            this.tbPassword.TabIndex = 9;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPassword.Location = new System.Drawing.Point(3, 175);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(57, 16);
            this.lbPassword.TabIndex = 8;
            this.lbPassword.Text = "Пароль";
            // 
            // tbLogin
            // 
            this.tbLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbLogin.Location = new System.Drawing.Point(3, 152);
            this.tbLogin.MaxLength = 16;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(258, 23);
            this.tbLogin.TabIndex = 7;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbLogin.Location = new System.Drawing.Point(3, 136);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(46, 16);
            this.lbLogin.TabIndex = 6;
            this.lbLogin.Text = "Логин";
            // 
            // tbPatronymic
            // 
            this.tbPatronymic.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPatronymic.Location = new System.Drawing.Point(3, 113);
            this.tbPatronymic.Name = "tbPatronymic";
            this.tbPatronymic.Size = new System.Drawing.Size(258, 23);
            this.tbPatronymic.TabIndex = 5;
            // 
            // lbPatronymic
            // 
            this.lbPatronymic.AutoSize = true;
            this.lbPatronymic.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPatronymic.Location = new System.Drawing.Point(3, 97);
            this.lbPatronymic.Name = "lbPatronymic";
            this.lbPatronymic.Size = new System.Drawing.Size(166, 16);
            this.lbPatronymic.TabIndex = 4;
            this.lbPatronymic.Text = "Отчество пользователя";
            // 
            // tbName
            // 
            this.tbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbName.Location = new System.Drawing.Point(3, 74);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(258, 23);
            this.tbName.TabIndex = 3;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbName.Location = new System.Drawing.Point(3, 58);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(132, 16);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Имя пользователя";
            // 
            // tbSurname
            // 
            this.tbSurname.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSurname.Location = new System.Drawing.Point(3, 35);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(258, 23);
            this.tbSurname.TabIndex = 1;
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSurname.Location = new System.Drawing.Point(3, 19);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(165, 16);
            this.lbSurname.TabIndex = 0;
            this.lbSurname.Text = "Фамилия пользователя";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(264, 48);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(808, 386);
            this.dgvUsers.TabIndex = 5;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1072, 470);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.gbManipulationData);
            this.Controls.Add(this.pnCancel);
            this.Controls.Add(this.gbSearchAndFiltration);
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пользователи";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            this.gbSearchAndFiltration.ResumeLayout(false);
            this.pnFiltration.ResumeLayout(false);
            this.pnFiltration.PerformLayout();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.pnCancel.ResumeLayout(false);
            this.gbManipulationData.ResumeLayout(false);
            this.gbManipulationData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearchAndFiltration;
        private System.Windows.Forms.Panel pnFiltration;
        private System.Windows.Forms.CheckBox chbFiltration;
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Panel pnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnError;
        private System.Windows.Forms.GroupBox gbManipulationData;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdatePost;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label lbPost;
        private System.Windows.Forms.TextBox tbRepeatPassword;
        private System.Windows.Forms.Label lbRepeatPssword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.TextBox tbPatronymic;
        private System.Windows.Forms.Label lbPatronymic;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.DataGridView dgvUsers;
    }
}