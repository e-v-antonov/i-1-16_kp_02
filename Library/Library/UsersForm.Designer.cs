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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
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
            resources.ApplyResources(this.gbSearchAndFiltration, "gbSearchAndFiltration");
            this.gbSearchAndFiltration.Controls.Add(this.pnFiltration);
            this.gbSearchAndFiltration.Controls.Add(this.pnSearch);
            this.gbSearchAndFiltration.Name = "gbSearchAndFiltration";
            this.gbSearchAndFiltration.TabStop = false;
            // 
            // pnFiltration
            // 
            resources.ApplyResources(this.pnFiltration, "pnFiltration");
            this.pnFiltration.Controls.Add(this.chbFiltration);
            this.pnFiltration.Name = "pnFiltration";
            // 
            // chbFiltration
            // 
            resources.ApplyResources(this.chbFiltration, "chbFiltration");
            this.chbFiltration.Name = "chbFiltration";
            this.chbFiltration.UseVisualStyleBackColor = true;
            this.chbFiltration.CheckedChanged += new System.EventHandler(this.chbFiltration_CheckedChanged);
            // 
            // pnSearch
            // 
            resources.ApplyResources(this.pnSearch, "pnSearch");
            this.pnSearch.Controls.Add(this.tbSearch);
            this.pnSearch.Name = "pnSearch";
            // 
            // tbSearch
            // 
            resources.ApplyResources(this.tbSearch, "tbSearch");
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
            this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
            // 
            // pnCancel
            // 
            resources.ApplyResources(this.pnCancel, "pnCancel");
            this.pnCancel.Controls.Add(this.btnExit);
            this.pnCancel.Controls.Add(this.btnError);
            this.pnCancel.Name = "pnCancel";
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnError
            // 
            resources.ApplyResources(this.btnError, "btnError");
            this.btnError.Name = "btnError";
            this.btnError.UseVisualStyleBackColor = true;
            this.btnError.Click += new System.EventHandler(this.btnError_Click);
            // 
            // gbManipulationData
            // 
            resources.ApplyResources(this.gbManipulationData, "gbManipulationData");
            this.gbManipulationData.Controls.Add(this.btnDelete);
            this.gbManipulationData.Controls.Add(this.btnUpdate);
            this.gbManipulationData.Controls.Add(this.btnInsert);
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
            this.gbManipulationData.Name = "gbManipulationData";
            this.gbManipulationData.TabStop = false;
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            resources.ApplyResources(this.btnInsert, "btnInsert");
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // cbRole
            // 
            resources.ApplyResources(this.cbRole, "cbRole");
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Name = "cbRole";
            // 
            // lbPost
            // 
            resources.ApplyResources(this.lbPost, "lbPost");
            this.lbPost.Name = "lbPost";
            // 
            // tbRepeatPassword
            // 
            resources.ApplyResources(this.tbRepeatPassword, "tbRepeatPassword");
            this.tbRepeatPassword.Name = "tbRepeatPassword";
            // 
            // lbRepeatPssword
            // 
            resources.ApplyResources(this.lbRepeatPssword, "lbRepeatPssword");
            this.lbRepeatPssword.Name = "lbRepeatPssword";
            // 
            // tbPassword
            // 
            resources.ApplyResources(this.tbPassword, "tbPassword");
            this.tbPassword.Name = "tbPassword";
            // 
            // lbPassword
            // 
            resources.ApplyResources(this.lbPassword, "lbPassword");
            this.lbPassword.Name = "lbPassword";
            // 
            // tbLogin
            // 
            resources.ApplyResources(this.tbLogin, "tbLogin");
            this.tbLogin.Name = "tbLogin";
            // 
            // lbLogin
            // 
            resources.ApplyResources(this.lbLogin, "lbLogin");
            this.lbLogin.Name = "lbLogin";
            // 
            // tbPatronymic
            // 
            resources.ApplyResources(this.tbPatronymic, "tbPatronymic");
            this.tbPatronymic.Name = "tbPatronymic";
            // 
            // lbPatronymic
            // 
            resources.ApplyResources(this.lbPatronymic, "lbPatronymic");
            this.lbPatronymic.Name = "lbPatronymic";
            // 
            // tbName
            // 
            resources.ApplyResources(this.tbName, "tbName");
            this.tbName.Name = "tbName";
            // 
            // lbName
            // 
            resources.ApplyResources(this.lbName, "lbName");
            this.lbName.Name = "lbName";
            // 
            // tbSurname
            // 
            resources.ApplyResources(this.tbSurname, "tbSurname");
            this.tbSurname.Name = "tbSurname";
            // 
            // lbSurname
            // 
            resources.ApplyResources(this.lbSurname, "lbSurname");
            this.lbSurname.Name = "lbSurname";
            // 
            // dgvUsers
            // 
            resources.ApplyResources(this.dgvUsers, "dgvUsers");
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // UsersForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.gbManipulationData);
            this.Controls.Add(this.pnCancel);
            this.Controls.Add(this.gbSearchAndFiltration);
            this.Name = "UsersForm";
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