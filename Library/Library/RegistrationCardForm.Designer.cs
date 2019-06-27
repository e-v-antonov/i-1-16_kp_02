namespace Library
{
    partial class RegistrationCardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationCardForm));
            this.pnCancel = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnError = new System.Windows.Forms.Button();
            this.gbSearchAndFiltration = new System.Windows.Forms.GroupBox();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.pnFiltration = new System.Windows.Forms.Panel();
            this.chbFiltration = new System.Windows.Forms.CheckBox();
            this.gbManipulationData = new System.Windows.Forms.GroupBox();
            this.pnRefreshData = new System.Windows.Forms.Panel();
            this.btnRefreshData = new System.Windows.Forms.Button();
            this.pnButtons = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lbHaveBook = new System.Windows.Forms.Label();
            this.gbContactInformation = new System.Windows.Forms.GroupBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.mtbHomePhone = new System.Windows.Forms.MaskedTextBox();
            this.lbMobilePhone = new System.Windows.Forms.Label();
            this.mtbMobilePhone = new System.Windows.Forms.MaskedTextBox();
            this.lbHomeTelephone = new System.Windows.Forms.Label();
            this.gbPlaceResidence = new System.Windows.Forms.GroupBox();
            this.tbApartment = new System.Windows.Forms.TextBox();
            this.lbApartment = new System.Windows.Forms.Label();
            this.tbBuilding = new System.Windows.Forms.TextBox();
            this.lbBuilding = new System.Windows.Forms.Label();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.lbStreet = new System.Windows.Forms.Label();
            this.tbTown = new System.Windows.Forms.TextBox();
            this.lbTown = new System.Windows.Forms.Label();
            this.gbPassportData = new System.Windows.Forms.GroupBox();
            this.dtpWhenGivePassport = new System.Windows.Forms.DateTimePicker();
            this.lbWhenGivePassport = new System.Windows.Forms.Label();
            this.tbWhoGivePassport = new System.Windows.Forms.TextBox();
            this.lbWhoGivePassport = new System.Windows.Forms.Label();
            this.tbPassportNumber = new System.Windows.Forms.TextBox();
            this.lbPassportNumber = new System.Windows.Forms.Label();
            this.tbPassportSeries = new System.Windows.Forms.TextBox();
            this.lbPassportSeries = new System.Windows.Forms.Label();
            this.gbPersonalData = new System.Windows.Forms.GroupBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.tbPatronymic = new System.Windows.Forms.TextBox();
            this.lbPatronymic = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.lbSurname = new System.Windows.Forms.Label();
            this.dgvRegistrationCard = new System.Windows.Forms.DataGridView();
            this.pnCancel.SuspendLayout();
            this.gbSearchAndFiltration.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.pnFiltration.SuspendLayout();
            this.gbManipulationData.SuspendLayout();
            this.pnRefreshData.SuspendLayout();
            this.pnButtons.SuspendLayout();
            this.gbContactInformation.SuspendLayout();
            this.gbPlaceResidence.SuspendLayout();
            this.gbPassportData.SuspendLayout();
            this.gbPersonalData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrationCard)).BeginInit();
            this.SuspendLayout();
            // 
            // pnCancel
            // 
            this.pnCancel.Controls.Add(this.btnExit);
            this.pnCancel.Controls.Add(this.btnError);
            resources.ApplyResources(this.pnCancel, "pnCancel");
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
            // gbSearchAndFiltration
            // 
            this.gbSearchAndFiltration.Controls.Add(this.pnSearch);
            this.gbSearchAndFiltration.Controls.Add(this.pnFiltration);
            resources.ApplyResources(this.gbSearchAndFiltration, "gbSearchAndFiltration");
            this.gbSearchAndFiltration.Name = "gbSearchAndFiltration";
            this.gbSearchAndFiltration.TabStop = false;
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.tbSearch);
            resources.ApplyResources(this.pnSearch, "pnSearch");
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
            // pnFiltration
            // 
            this.pnFiltration.Controls.Add(this.chbFiltration);
            resources.ApplyResources(this.pnFiltration, "pnFiltration");
            this.pnFiltration.Name = "pnFiltration";
            // 
            // chbFiltration
            // 
            resources.ApplyResources(this.chbFiltration, "chbFiltration");
            this.chbFiltration.Name = "chbFiltration";
            this.chbFiltration.UseVisualStyleBackColor = true;
            this.chbFiltration.CheckedChanged += new System.EventHandler(this.chbFiltration_CheckedChanged);
            // 
            // gbManipulationData
            // 
            this.gbManipulationData.Controls.Add(this.pnRefreshData);
            this.gbManipulationData.Controls.Add(this.pnButtons);
            this.gbManipulationData.Controls.Add(this.lbHaveBook);
            this.gbManipulationData.Controls.Add(this.gbContactInformation);
            this.gbManipulationData.Controls.Add(this.gbPlaceResidence);
            this.gbManipulationData.Controls.Add(this.gbPassportData);
            this.gbManipulationData.Controls.Add(this.gbPersonalData);
            resources.ApplyResources(this.gbManipulationData, "gbManipulationData");
            this.gbManipulationData.Name = "gbManipulationData";
            this.gbManipulationData.TabStop = false;
            // 
            // pnRefreshData
            // 
            this.pnRefreshData.Controls.Add(this.btnRefreshData);
            resources.ApplyResources(this.pnRefreshData, "pnRefreshData");
            this.pnRefreshData.Name = "pnRefreshData";
            // 
            // btnRefreshData
            // 
            resources.ApplyResources(this.btnRefreshData, "btnRefreshData");
            this.btnRefreshData.Name = "btnRefreshData";
            this.btnRefreshData.UseVisualStyleBackColor = true;
            this.btnRefreshData.Click += new System.EventHandler(this.btnRefreshData_Click);
            // 
            // pnButtons
            // 
            this.pnButtons.Controls.Add(this.btnDelete);
            this.pnButtons.Controls.Add(this.btnUpdate);
            this.pnButtons.Controls.Add(this.btnInsert);
            resources.ApplyResources(this.pnButtons, "pnButtons");
            this.pnButtons.Name = "pnButtons";
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
            // lbHaveBook
            // 
            resources.ApplyResources(this.lbHaveBook, "lbHaveBook");
            this.lbHaveBook.Name = "lbHaveBook";
            // 
            // gbContactInformation
            // 
            this.gbContactInformation.Controls.Add(this.tbEmail);
            this.gbContactInformation.Controls.Add(this.lbEmail);
            this.gbContactInformation.Controls.Add(this.mtbHomePhone);
            this.gbContactInformation.Controls.Add(this.lbMobilePhone);
            this.gbContactInformation.Controls.Add(this.mtbMobilePhone);
            this.gbContactInformation.Controls.Add(this.lbHomeTelephone);
            resources.ApplyResources(this.gbContactInformation, "gbContactInformation");
            this.gbContactInformation.Name = "gbContactInformation";
            this.gbContactInformation.TabStop = false;
            // 
            // tbEmail
            // 
            resources.ApplyResources(this.tbEmail, "tbEmail");
            this.tbEmail.Name = "tbEmail";
            // 
            // lbEmail
            // 
            resources.ApplyResources(this.lbEmail, "lbEmail");
            this.lbEmail.Name = "lbEmail";
            // 
            // mtbHomePhone
            // 
            resources.ApplyResources(this.mtbHomePhone, "mtbHomePhone");
            this.mtbHomePhone.Name = "mtbHomePhone";
            // 
            // lbMobilePhone
            // 
            resources.ApplyResources(this.lbMobilePhone, "lbMobilePhone");
            this.lbMobilePhone.Name = "lbMobilePhone";
            // 
            // mtbMobilePhone
            // 
            resources.ApplyResources(this.mtbMobilePhone, "mtbMobilePhone");
            this.mtbMobilePhone.Name = "mtbMobilePhone";
            // 
            // lbHomeTelephone
            // 
            resources.ApplyResources(this.lbHomeTelephone, "lbHomeTelephone");
            this.lbHomeTelephone.Name = "lbHomeTelephone";
            // 
            // gbPlaceResidence
            // 
            this.gbPlaceResidence.Controls.Add(this.tbApartment);
            this.gbPlaceResidence.Controls.Add(this.lbApartment);
            this.gbPlaceResidence.Controls.Add(this.tbBuilding);
            this.gbPlaceResidence.Controls.Add(this.lbBuilding);
            this.gbPlaceResidence.Controls.Add(this.tbStreet);
            this.gbPlaceResidence.Controls.Add(this.lbStreet);
            this.gbPlaceResidence.Controls.Add(this.tbTown);
            this.gbPlaceResidence.Controls.Add(this.lbTown);
            resources.ApplyResources(this.gbPlaceResidence, "gbPlaceResidence");
            this.gbPlaceResidence.Name = "gbPlaceResidence";
            this.gbPlaceResidence.TabStop = false;
            // 
            // tbApartment
            // 
            resources.ApplyResources(this.tbApartment, "tbApartment");
            this.tbApartment.Name = "tbApartment";
            // 
            // lbApartment
            // 
            resources.ApplyResources(this.lbApartment, "lbApartment");
            this.lbApartment.Name = "lbApartment";
            // 
            // tbBuilding
            // 
            resources.ApplyResources(this.tbBuilding, "tbBuilding");
            this.tbBuilding.Name = "tbBuilding";
            // 
            // lbBuilding
            // 
            resources.ApplyResources(this.lbBuilding, "lbBuilding");
            this.lbBuilding.Name = "lbBuilding";
            // 
            // tbStreet
            // 
            resources.ApplyResources(this.tbStreet, "tbStreet");
            this.tbStreet.Name = "tbStreet";
            // 
            // lbStreet
            // 
            resources.ApplyResources(this.lbStreet, "lbStreet");
            this.lbStreet.Name = "lbStreet";
            // 
            // tbTown
            // 
            resources.ApplyResources(this.tbTown, "tbTown");
            this.tbTown.Name = "tbTown";
            // 
            // lbTown
            // 
            resources.ApplyResources(this.lbTown, "lbTown");
            this.lbTown.Name = "lbTown";
            // 
            // gbPassportData
            // 
            this.gbPassportData.Controls.Add(this.dtpWhenGivePassport);
            this.gbPassportData.Controls.Add(this.lbWhenGivePassport);
            this.gbPassportData.Controls.Add(this.tbWhoGivePassport);
            this.gbPassportData.Controls.Add(this.lbWhoGivePassport);
            this.gbPassportData.Controls.Add(this.tbPassportNumber);
            this.gbPassportData.Controls.Add(this.lbPassportNumber);
            this.gbPassportData.Controls.Add(this.tbPassportSeries);
            this.gbPassportData.Controls.Add(this.lbPassportSeries);
            resources.ApplyResources(this.gbPassportData, "gbPassportData");
            this.gbPassportData.Name = "gbPassportData";
            this.gbPassportData.TabStop = false;
            // 
            // dtpWhenGivePassport
            // 
            resources.ApplyResources(this.dtpWhenGivePassport, "dtpWhenGivePassport");
            this.dtpWhenGivePassport.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWhenGivePassport.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpWhenGivePassport.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpWhenGivePassport.Name = "dtpWhenGivePassport";
            // 
            // lbWhenGivePassport
            // 
            resources.ApplyResources(this.lbWhenGivePassport, "lbWhenGivePassport");
            this.lbWhenGivePassport.Name = "lbWhenGivePassport";
            // 
            // tbWhoGivePassport
            // 
            resources.ApplyResources(this.tbWhoGivePassport, "tbWhoGivePassport");
            this.tbWhoGivePassport.Name = "tbWhoGivePassport";
            // 
            // lbWhoGivePassport
            // 
            resources.ApplyResources(this.lbWhoGivePassport, "lbWhoGivePassport");
            this.lbWhoGivePassport.Name = "lbWhoGivePassport";
            // 
            // tbPassportNumber
            // 
            resources.ApplyResources(this.tbPassportNumber, "tbPassportNumber");
            this.tbPassportNumber.Name = "tbPassportNumber";
            // 
            // lbPassportNumber
            // 
            resources.ApplyResources(this.lbPassportNumber, "lbPassportNumber");
            this.lbPassportNumber.Name = "lbPassportNumber";
            // 
            // tbPassportSeries
            // 
            resources.ApplyResources(this.tbPassportSeries, "tbPassportSeries");
            this.tbPassportSeries.Name = "tbPassportSeries";
            // 
            // lbPassportSeries
            // 
            resources.ApplyResources(this.lbPassportSeries, "lbPassportSeries");
            this.lbPassportSeries.Name = "lbPassportSeries";
            // 
            // gbPersonalData
            // 
            this.gbPersonalData.Controls.Add(this.dtpBirthday);
            this.gbPersonalData.Controls.Add(this.lbBirthday);
            this.gbPersonalData.Controls.Add(this.tbPatronymic);
            this.gbPersonalData.Controls.Add(this.lbPatronymic);
            this.gbPersonalData.Controls.Add(this.tbName);
            this.gbPersonalData.Controls.Add(this.lbName);
            this.gbPersonalData.Controls.Add(this.tbSurname);
            this.gbPersonalData.Controls.Add(this.lbSurname);
            resources.ApplyResources(this.gbPersonalData, "gbPersonalData");
            this.gbPersonalData.Name = "gbPersonalData";
            this.gbPersonalData.TabStop = false;
            // 
            // dtpBirthday
            // 
            resources.ApplyResources(this.dtpBirthday, "dtpBirthday");
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthday.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpBirthday.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpBirthday.Name = "dtpBirthday";
            // 
            // lbBirthday
            // 
            resources.ApplyResources(this.lbBirthday, "lbBirthday");
            this.lbBirthday.Name = "lbBirthday";
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
            // dgvRegistrationCard
            // 
            this.dgvRegistrationCard.AllowUserToAddRows = false;
            this.dgvRegistrationCard.AllowUserToDeleteRows = false;
            this.dgvRegistrationCard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegistrationCard.BackgroundColor = System.Drawing.Color.White;
            this.dgvRegistrationCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvRegistrationCard, "dgvRegistrationCard");
            this.dgvRegistrationCard.Name = "dgvRegistrationCard";
            this.dgvRegistrationCard.ReadOnly = true;
            this.dgvRegistrationCard.RowTemplate.Height = 24;
            this.dgvRegistrationCard.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistrationCard_CellClick);
            this.dgvRegistrationCard.Click += new System.EventHandler(this.dgvRegistrationCard_Click);
            // 
            // RegistrationCardForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvRegistrationCard);
            this.Controls.Add(this.gbSearchAndFiltration);
            this.Controls.Add(this.gbManipulationData);
            this.Controls.Add(this.pnCancel);
            this.Name = "RegistrationCardForm";
            this.Load += new System.EventHandler(this.RegistrationCardForm_Load);
            this.pnCancel.ResumeLayout(false);
            this.gbSearchAndFiltration.ResumeLayout(false);
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.pnFiltration.ResumeLayout(false);
            this.pnFiltration.PerformLayout();
            this.gbManipulationData.ResumeLayout(false);
            this.gbManipulationData.PerformLayout();
            this.pnRefreshData.ResumeLayout(false);
            this.pnButtons.ResumeLayout(false);
            this.pnButtons.PerformLayout();
            this.gbContactInformation.ResumeLayout(false);
            this.gbContactInformation.PerformLayout();
            this.gbPlaceResidence.ResumeLayout(false);
            this.gbPlaceResidence.PerformLayout();
            this.gbPassportData.ResumeLayout(false);
            this.gbPassportData.PerformLayout();
            this.gbPersonalData.ResumeLayout(false);
            this.gbPersonalData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrationCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnError;
        private System.Windows.Forms.GroupBox gbSearchAndFiltration;
        private System.Windows.Forms.Panel pnFiltration;
        private System.Windows.Forms.CheckBox chbFiltration;
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.GroupBox gbManipulationData;
        private System.Windows.Forms.GroupBox gbPassportData;
        private System.Windows.Forms.TextBox tbPassportNumber;
        private System.Windows.Forms.Label lbPassportNumber;
        private System.Windows.Forms.TextBox tbPassportSeries;
        private System.Windows.Forms.Label lbWhenGivePassport;
        private System.Windows.Forms.Label lbPassportSeries;
        private System.Windows.Forms.TextBox tbWhoGivePassport;
        private System.Windows.Forms.Label lbWhoGivePassport;
        private System.Windows.Forms.GroupBox gbPersonalData;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.TextBox tbPatronymic;
        private System.Windows.Forms.Label lbPatronymic;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.GroupBox gbContactInformation;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.MaskedTextBox mtbHomePhone;
        private System.Windows.Forms.Label lbMobilePhone;
        private System.Windows.Forms.MaskedTextBox mtbMobilePhone;
        private System.Windows.Forms.Label lbHomeTelephone;
        private System.Windows.Forms.GroupBox gbPlaceResidence;
        private System.Windows.Forms.TextBox tbApartment;
        private System.Windows.Forms.Label lbApartment;
        private System.Windows.Forms.TextBox tbBuilding;
        private System.Windows.Forms.Label lbBuilding;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.Label lbStreet;
        private System.Windows.Forms.TextBox tbTown;
        private System.Windows.Forms.Label lbTown;
        private System.Windows.Forms.DataGridView dgvRegistrationCard;
        private System.Windows.Forms.Panel pnButtons;
        private System.Windows.Forms.Label lbHaveBook;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.DateTimePicker dtpWhenGivePassport;
        public System.Windows.Forms.Button btnInsert;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnRefreshData;
        private System.Windows.Forms.Button btnRefreshData;
    }
}