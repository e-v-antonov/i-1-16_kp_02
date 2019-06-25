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
            this.pnCancel = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnError = new System.Windows.Forms.Button();
            this.gbSearchAndFiltration = new System.Windows.Forms.GroupBox();
            this.pnFiltration = new System.Windows.Forms.Panel();
            this.chbFiltration = new System.Windows.Forms.CheckBox();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.gbManipulationData = new System.Windows.Forms.GroupBox();
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
            this.pnFiltration.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.gbManipulationData.SuspendLayout();
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
            this.pnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCancel.Location = new System.Drawing.Point(0, 586);
            this.pnCancel.Name = "pnCancel";
            this.pnCancel.Size = new System.Drawing.Size(1155, 36);
            this.pnCancel.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Location = new System.Drawing.Point(1036, 0);
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
            // gbSearchAndFiltration
            // 
            this.gbSearchAndFiltration.Controls.Add(this.pnFiltration);
            this.gbSearchAndFiltration.Controls.Add(this.pnSearch);
            this.gbSearchAndFiltration.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSearchAndFiltration.Location = new System.Drawing.Point(0, 0);
            this.gbSearchAndFiltration.Name = "gbSearchAndFiltration";
            this.gbSearchAndFiltration.Size = new System.Drawing.Size(1155, 48);
            this.gbSearchAndFiltration.TabIndex = 1;
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
            this.tbSearch.Text = "Введите данные регистрационной карточки...";
            this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
            this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
            // 
            // gbManipulationData
            // 
            this.gbManipulationData.Controls.Add(this.pnButtons);
            this.gbManipulationData.Controls.Add(this.lbHaveBook);
            this.gbManipulationData.Controls.Add(this.gbContactInformation);
            this.gbManipulationData.Controls.Add(this.gbPlaceResidence);
            this.gbManipulationData.Controls.Add(this.gbPassportData);
            this.gbManipulationData.Controls.Add(this.gbPersonalData);
            this.gbManipulationData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbManipulationData.Location = new System.Drawing.Point(0, 408);
            this.gbManipulationData.Name = "gbManipulationData";
            this.gbManipulationData.Size = new System.Drawing.Size(1155, 178);
            this.gbManipulationData.TabIndex = 2;
            this.gbManipulationData.TabStop = false;
            this.gbManipulationData.Text = "Манипулирование данными:";
            // 
            // pnButtons
            // 
            this.pnButtons.Controls.Add(this.btnDelete);
            this.pnButtons.Controls.Add(this.btnUpdate);
            this.pnButtons.Controls.Add(this.btnInsert);
            this.pnButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnButtons.Location = new System.Drawing.Point(943, 35);
            this.pnButtons.Name = "pnButtons";
            this.pnButtons.Size = new System.Drawing.Size(209, 85);
            this.pnButtons.TabIndex = 23;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(0, 53);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(209, 26);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Удалить регистрационную карточку";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(0, 27);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(209, 26);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Изменить данные";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.AutoSize = true;
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInsert.Enabled = false;
            this.btnInsert.Location = new System.Drawing.Point(0, 0);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(209, 27);
            this.btnInsert.TabIndex = 22;
            this.btnInsert.Text = "Добавить регистрационную карточку";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lbHaveBook
            // 
            this.lbHaveBook.AutoSize = true;
            this.lbHaveBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbHaveBook.Location = new System.Drawing.Point(943, 19);
            this.lbHaveBook.Name = "lbHaveBook";
            this.lbHaveBook.Size = new System.Drawing.Size(255, 16);
            this.lbHaveBook.TabIndex = 24;
            this.lbHaveBook.Text = "Наличие книги в данный момент: Нет";
            // 
            // gbContactInformation
            // 
            this.gbContactInformation.Controls.Add(this.tbEmail);
            this.gbContactInformation.Controls.Add(this.lbEmail);
            this.gbContactInformation.Controls.Add(this.mtbHomePhone);
            this.gbContactInformation.Controls.Add(this.lbMobilePhone);
            this.gbContactInformation.Controls.Add(this.mtbMobilePhone);
            this.gbContactInformation.Controls.Add(this.lbHomeTelephone);
            this.gbContactInformation.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbContactInformation.Location = new System.Drawing.Point(708, 19);
            this.gbContactInformation.Name = "gbContactInformation";
            this.gbContactInformation.Size = new System.Drawing.Size(235, 156);
            this.gbContactInformation.TabIndex = 19;
            this.gbContactInformation.TabStop = false;
            this.gbContactInformation.Text = "Контактные данные:";
            // 
            // tbEmail
            // 
            this.tbEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbEmail.Location = new System.Drawing.Point(3, 113);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(229, 23);
            this.tbEmail.TabIndex = 20;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbEmail.Location = new System.Drawing.Point(3, 97);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(180, 16);
            this.lbEmail.TabIndex = 19;
            this.lbEmail.Text = "Адрес электронной почты";
            // 
            // mtbHomePhone
            // 
            this.mtbHomePhone.Dock = System.Windows.Forms.DockStyle.Top;
            this.mtbHomePhone.Location = new System.Drawing.Point(3, 74);
            this.mtbHomePhone.Mask = "0(000)000-00-00";
            this.mtbHomePhone.Name = "mtbHomePhone";
            this.mtbHomePhone.Size = new System.Drawing.Size(229, 23);
            this.mtbHomePhone.TabIndex = 18;
            // 
            // lbMobilePhone
            // 
            this.lbMobilePhone.AutoSize = true;
            this.lbMobilePhone.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbMobilePhone.Location = new System.Drawing.Point(3, 58);
            this.lbMobilePhone.Name = "lbMobilePhone";
            this.lbMobilePhone.Size = new System.Drawing.Size(199, 16);
            this.lbMobilePhone.TabIndex = 17;
            this.lbMobilePhone.Text = "Номер домашнего телефона";
            // 
            // mtbMobilePhone
            // 
            this.mtbMobilePhone.Dock = System.Windows.Forms.DockStyle.Top;
            this.mtbMobilePhone.Location = new System.Drawing.Point(3, 35);
            this.mtbMobilePhone.Mask = "0(000)000-00-00";
            this.mtbMobilePhone.Name = "mtbMobilePhone";
            this.mtbMobilePhone.Size = new System.Drawing.Size(229, 23);
            this.mtbMobilePhone.TabIndex = 16;
            // 
            // lbHomeTelephone
            // 
            this.lbHomeTelephone.AutoSize = true;
            this.lbHomeTelephone.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbHomeTelephone.Location = new System.Drawing.Point(3, 19);
            this.lbHomeTelephone.Name = "lbHomeTelephone";
            this.lbHomeTelephone.Size = new System.Drawing.Size(204, 16);
            this.lbHomeTelephone.TabIndex = 9;
            this.lbHomeTelephone.Text = "Номер мобильного телефона";
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
            this.gbPlaceResidence.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbPlaceResidence.Location = new System.Drawing.Point(473, 19);
            this.gbPlaceResidence.Name = "gbPlaceResidence";
            this.gbPlaceResidence.Size = new System.Drawing.Size(235, 156);
            this.gbPlaceResidence.TabIndex = 18;
            this.gbPlaceResidence.TabStop = false;
            this.gbPlaceResidence.Text = "Место проживания:";
            // 
            // tbApartment
            // 
            this.tbApartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbApartment.Location = new System.Drawing.Point(3, 152);
            this.tbApartment.Name = "tbApartment";
            this.tbApartment.Size = new System.Drawing.Size(229, 23);
            this.tbApartment.TabIndex = 16;
            // 
            // lbApartment
            // 
            this.lbApartment.AutoSize = true;
            this.lbApartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbApartment.Location = new System.Drawing.Point(3, 136);
            this.lbApartment.Name = "lbApartment";
            this.lbApartment.Size = new System.Drawing.Size(70, 16);
            this.lbApartment.TabIndex = 15;
            this.lbApartment.Text = "Квартира";
            // 
            // tbBuilding
            // 
            this.tbBuilding.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbBuilding.Location = new System.Drawing.Point(3, 113);
            this.tbBuilding.Name = "tbBuilding";
            this.tbBuilding.Size = new System.Drawing.Size(229, 23);
            this.tbBuilding.TabIndex = 14;
            // 
            // lbBuilding
            // 
            this.lbBuilding.AutoSize = true;
            this.lbBuilding.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbBuilding.Location = new System.Drawing.Point(3, 97);
            this.lbBuilding.Name = "lbBuilding";
            this.lbBuilding.Size = new System.Drawing.Size(35, 16);
            this.lbBuilding.TabIndex = 13;
            this.lbBuilding.Text = "Дом";
            // 
            // tbStreet
            // 
            this.tbStreet.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbStreet.Location = new System.Drawing.Point(3, 74);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(229, 23);
            this.tbStreet.TabIndex = 12;
            // 
            // lbStreet
            // 
            this.lbStreet.AutoSize = true;
            this.lbStreet.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbStreet.Location = new System.Drawing.Point(3, 58);
            this.lbStreet.Name = "lbStreet";
            this.lbStreet.Size = new System.Drawing.Size(49, 16);
            this.lbStreet.TabIndex = 11;
            this.lbStreet.Text = "Улица";
            // 
            // tbTown
            // 
            this.tbTown.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbTown.Location = new System.Drawing.Point(3, 35);
            this.tbTown.Name = "tbTown";
            this.tbTown.Size = new System.Drawing.Size(229, 23);
            this.tbTown.TabIndex = 10;
            // 
            // lbTown
            // 
            this.lbTown.AutoSize = true;
            this.lbTown.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTown.Location = new System.Drawing.Point(3, 19);
            this.lbTown.Name = "lbTown";
            this.lbTown.Size = new System.Drawing.Size(47, 16);
            this.lbTown.TabIndex = 9;
            this.lbTown.Text = "Город";
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
            this.gbPassportData.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbPassportData.Location = new System.Drawing.Point(238, 19);
            this.gbPassportData.Name = "gbPassportData";
            this.gbPassportData.Size = new System.Drawing.Size(235, 156);
            this.gbPassportData.TabIndex = 17;
            this.gbPassportData.TabStop = false;
            this.gbPassportData.Text = "Паспортные данные:";
            // 
            // dtpWhenGivePassport
            // 
            this.dtpWhenGivePassport.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpWhenGivePassport.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWhenGivePassport.Location = new System.Drawing.Point(3, 152);
            this.dtpWhenGivePassport.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpWhenGivePassport.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpWhenGivePassport.Name = "dtpWhenGivePassport";
            this.dtpWhenGivePassport.Size = new System.Drawing.Size(229, 23);
            this.dtpWhenGivePassport.TabIndex = 15;
            // 
            // lbWhenGivePassport
            // 
            this.lbWhenGivePassport.AutoSize = true;
            this.lbWhenGivePassport.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbWhenGivePassport.Location = new System.Drawing.Point(3, 136);
            this.lbWhenGivePassport.Name = "lbWhenGivePassport";
            this.lbWhenGivePassport.Size = new System.Drawing.Size(147, 16);
            this.lbWhenGivePassport.TabIndex = 14;
            this.lbWhenGivePassport.Text = "Когда выдан паспорт";
            // 
            // tbWhoGivePassport
            // 
            this.tbWhoGivePassport.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbWhoGivePassport.Location = new System.Drawing.Point(3, 113);
            this.tbWhoGivePassport.Name = "tbWhoGivePassport";
            this.tbWhoGivePassport.Size = new System.Drawing.Size(229, 23);
            this.tbWhoGivePassport.TabIndex = 13;
            // 
            // lbWhoGivePassport
            // 
            this.lbWhoGivePassport.AutoSize = true;
            this.lbWhoGivePassport.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbWhoGivePassport.Location = new System.Drawing.Point(3, 97);
            this.lbWhoGivePassport.Name = "lbWhoGivePassport";
            this.lbWhoGivePassport.Size = new System.Drawing.Size(137, 16);
            this.lbWhoGivePassport.TabIndex = 12;
            this.lbWhoGivePassport.Text = "Кем выдан паспорт";
            // 
            // tbPassportNumber
            // 
            this.tbPassportNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPassportNumber.Location = new System.Drawing.Point(3, 74);
            this.tbPassportNumber.Name = "tbPassportNumber";
            this.tbPassportNumber.Size = new System.Drawing.Size(229, 23);
            this.tbPassportNumber.TabIndex = 11;
            // 
            // lbPassportNumber
            // 
            this.lbPassportNumber.AutoSize = true;
            this.lbPassportNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPassportNumber.Location = new System.Drawing.Point(3, 58);
            this.lbPassportNumber.Name = "lbPassportNumber";
            this.lbPassportNumber.Size = new System.Drawing.Size(117, 16);
            this.lbPassportNumber.TabIndex = 10;
            this.lbPassportNumber.Text = "Номер паспорта";
            // 
            // tbPassportSeries
            // 
            this.tbPassportSeries.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPassportSeries.Location = new System.Drawing.Point(3, 35);
            this.tbPassportSeries.Name = "tbPassportSeries";
            this.tbPassportSeries.Size = new System.Drawing.Size(229, 23);
            this.tbPassportSeries.TabIndex = 9;
            // 
            // lbPassportSeries
            // 
            this.lbPassportSeries.AutoSize = true;
            this.lbPassportSeries.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPassportSeries.Location = new System.Drawing.Point(3, 19);
            this.lbPassportSeries.Name = "lbPassportSeries";
            this.lbPassportSeries.Size = new System.Drawing.Size(116, 16);
            this.lbPassportSeries.TabIndex = 8;
            this.lbPassportSeries.Text = "Серия паспорта";
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
            this.gbPersonalData.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbPersonalData.Location = new System.Drawing.Point(3, 19);
            this.gbPersonalData.Name = "gbPersonalData";
            this.gbPersonalData.Size = new System.Drawing.Size(235, 156);
            this.gbPersonalData.TabIndex = 16;
            this.gbPersonalData.TabStop = false;
            this.gbPersonalData.Text = "Личные данные:";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthday.Location = new System.Drawing.Point(3, 152);
            this.dtpBirthday.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpBirthday.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(229, 23);
            this.dtpBirthday.TabIndex = 7;
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbBirthday.Location = new System.Drawing.Point(3, 136);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(109, 16);
            this.lbBirthday.TabIndex = 6;
            this.lbBirthday.Text = "Дата рождения";
            // 
            // tbPatronymic
            // 
            this.tbPatronymic.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPatronymic.Location = new System.Drawing.Point(3, 113);
            this.tbPatronymic.Name = "tbPatronymic";
            this.tbPatronymic.Size = new System.Drawing.Size(229, 23);
            this.tbPatronymic.TabIndex = 5;
            // 
            // lbPatronymic
            // 
            this.lbPatronymic.AutoSize = true;
            this.lbPatronymic.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPatronymic.Location = new System.Drawing.Point(3, 97);
            this.lbPatronymic.Name = "lbPatronymic";
            this.lbPatronymic.Size = new System.Drawing.Size(70, 16);
            this.lbPatronymic.TabIndex = 4;
            this.lbPatronymic.Text = "Отчество";
            // 
            // tbName
            // 
            this.tbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbName.Location = new System.Drawing.Point(3, 74);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(229, 23);
            this.tbName.TabIndex = 3;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbName.Location = new System.Drawing.Point(3, 58);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(36, 16);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Имя";
            // 
            // tbSurname
            // 
            this.tbSurname.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSurname.Location = new System.Drawing.Point(3, 35);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(229, 23);
            this.tbSurname.TabIndex = 1;
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSurname.Location = new System.Drawing.Point(3, 19);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(69, 16);
            this.lbSurname.TabIndex = 0;
            this.lbSurname.Text = "Фамилия";
            // 
            // dgvRegistrationCard
            // 
            this.dgvRegistrationCard.AllowUserToAddRows = false;
            this.dgvRegistrationCard.AllowUserToDeleteRows = false;
            this.dgvRegistrationCard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegistrationCard.BackgroundColor = System.Drawing.Color.White;
            this.dgvRegistrationCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistrationCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegistrationCard.Location = new System.Drawing.Point(0, 48);
            this.dgvRegistrationCard.Name = "dgvRegistrationCard";
            this.dgvRegistrationCard.ReadOnly = true;
            this.dgvRegistrationCard.RowTemplate.Height = 24;
            this.dgvRegistrationCard.Size = new System.Drawing.Size(1155, 360);
            this.dgvRegistrationCard.TabIndex = 3;
            this.dgvRegistrationCard.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistrationCard_CellClick);
            this.dgvRegistrationCard.Click += new System.EventHandler(this.dgvRegistrationCard_Click);
            // 
            // RegistrationCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 622);
            this.Controls.Add(this.dgvRegistrationCard);
            this.Controls.Add(this.gbSearchAndFiltration);
            this.Controls.Add(this.gbManipulationData);
            this.Controls.Add(this.pnCancel);
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "RegistrationCardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрационные карточки читателей";
            this.Load += new System.EventHandler(this.RegistrationCardForm_Load);
            this.pnCancel.ResumeLayout(false);
            this.gbSearchAndFiltration.ResumeLayout(false);
            this.pnFiltration.ResumeLayout(false);
            this.pnFiltration.PerformLayout();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.gbManipulationData.ResumeLayout(false);
            this.gbManipulationData.PerformLayout();
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
    }
}