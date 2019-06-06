namespace Library
{
    partial class IssueBookForm
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
            this.gbSearchReader = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegistrationReader = new System.Windows.Forms.Button();
            this.btnIdentificationReader = new System.Windows.Forms.Button();
            this.pnPassportNumber = new System.Windows.Forms.Panel();
            this.tbPassportNumber = new System.Windows.Forms.TextBox();
            this.lbPassportNumber = new System.Windows.Forms.Label();
            this.pnPassportSeries = new System.Windows.Forms.Panel();
            this.tbPassportSeries = new System.Windows.Forms.TextBox();
            this.lbPassportSeries = new System.Windows.Forms.Label();
            this.pnPatronymic = new System.Windows.Forms.Panel();
            this.tbPatronymic = new System.Windows.Forms.TextBox();
            this.lbPatronymic = new System.Windows.Forms.Label();
            this.pnName = new System.Windows.Forms.Panel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.pnSurname = new System.Windows.Forms.Panel();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.lbSurname = new System.Windows.Forms.Label();
            this.gbSearchBook = new System.Windows.Forms.GroupBox();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnCheckBook = new System.Windows.Forms.Button();
            this.pnPublishing = new System.Windows.Forms.Panel();
            this.cbPublishing = new System.Windows.Forms.ComboBox();
            this.lbPublishing = new System.Windows.Forms.Label();
            this.pnGenre = new System.Windows.Forms.Panel();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.lbGenre = new System.Windows.Forms.Label();
            this.pnWriter = new System.Windows.Forms.Panel();
            this.cbWriter = new System.Windows.Forms.ComboBox();
            this.lbWriter = new System.Windows.Forms.Label();
            this.pnTitleBook = new System.Windows.Forms.Panel();
            this.tbTitleBook = new System.Windows.Forms.TextBox();
            this.lbTitleBook = new System.Windows.Forms.Label();
            this.gbIssueBook = new System.Windows.Forms.GroupBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnIssueBook = new System.Windows.Forms.Button();
            this.pnDateRetirnBook = new System.Windows.Forms.Panel();
            this.tbDateReturn = new System.Windows.Forms.TextBox();
            this.lbDateReturnBook = new System.Windows.Forms.Label();
            this.pnNumberDays = new System.Windows.Forms.Panel();
            this.nudNumberDays = new System.Windows.Forms.NumericUpDown();
            this.lbNumberDays = new System.Windows.Forms.Label();
            this.pnDateIssueBook = new System.Windows.Forms.Panel();
            this.dtpDateIssueBook = new System.Windows.Forms.DateTimePicker();
            this.lbDateIssueBook = new System.Windows.Forms.Label();
            this.pnCancel.SuspendLayout();
            this.gbSearchReader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnPassportNumber.SuspendLayout();
            this.pnPassportSeries.SuspendLayout();
            this.pnPatronymic.SuspendLayout();
            this.pnName.SuspendLayout();
            this.pnSurname.SuspendLayout();
            this.gbSearchBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.panel11.SuspendLayout();
            this.pnPublishing.SuspendLayout();
            this.pnGenre.SuspendLayout();
            this.pnWriter.SuspendLayout();
            this.pnTitleBook.SuspendLayout();
            this.gbIssueBook.SuspendLayout();
            this.panel15.SuspendLayout();
            this.pnDateRetirnBook.SuspendLayout();
            this.pnNumberDays.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberDays)).BeginInit();
            this.pnDateIssueBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCancel
            // 
            this.pnCancel.Controls.Add(this.btnExit);
            this.pnCancel.Controls.Add(this.btnError);
            this.pnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCancel.Location = new System.Drawing.Point(0, 520);
            this.pnCancel.Name = "pnCancel";
            this.pnCancel.Size = new System.Drawing.Size(1062, 36);
            this.pnCancel.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Location = new System.Drawing.Point(943, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 36);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Закрыть";
            this.btnExit.UseVisualStyleBackColor = true;
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
            // 
            // gbSearchReader
            // 
            this.gbSearchReader.Controls.Add(this.panel1);
            this.gbSearchReader.Controls.Add(this.pnPassportNumber);
            this.gbSearchReader.Controls.Add(this.pnPassportSeries);
            this.gbSearchReader.Controls.Add(this.pnPatronymic);
            this.gbSearchReader.Controls.Add(this.pnName);
            this.gbSearchReader.Controls.Add(this.pnSurname);
            this.gbSearchReader.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSearchReader.Location = new System.Drawing.Point(0, 0);
            this.gbSearchReader.Name = "gbSearchReader";
            this.gbSearchReader.Size = new System.Drawing.Size(1062, 72);
            this.gbSearchReader.TabIndex = 6;
            this.gbSearchReader.TabStop = false;
            this.gbSearchReader.Text = "Поиск читателя";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRegistrationReader);
            this.panel1.Controls.Add(this.btnIdentificationReader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(728, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 50);
            this.panel1.TabIndex = 0;
            // 
            // btnRegistrationReader
            // 
            this.btnRegistrationReader.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrationReader.Location = new System.Drawing.Point(0, 23);
            this.btnRegistrationReader.Name = "btnRegistrationReader";
            this.btnRegistrationReader.Size = new System.Drawing.Size(331, 23);
            this.btnRegistrationReader.TabIndex = 1;
            this.btnRegistrationReader.Text = "Регистрация читателя";
            this.btnRegistrationReader.UseVisualStyleBackColor = true;
            this.btnRegistrationReader.Click += new System.EventHandler(this.btnRegistrationReader_Click);
            // 
            // btnIdentificationReader
            // 
            this.btnIdentificationReader.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIdentificationReader.Location = new System.Drawing.Point(0, 0);
            this.btnIdentificationReader.Name = "btnIdentificationReader";
            this.btnIdentificationReader.Size = new System.Drawing.Size(331, 23);
            this.btnIdentificationReader.TabIndex = 0;
            this.btnIdentificationReader.Text = "Идентификация читателя";
            this.btnIdentificationReader.UseVisualStyleBackColor = true;
            this.btnIdentificationReader.Click += new System.EventHandler(this.btnIdentificationReader_Click);
            // 
            // pnPassportNumber
            // 
            this.pnPassportNumber.Controls.Add(this.tbPassportNumber);
            this.pnPassportNumber.Controls.Add(this.lbPassportNumber);
            this.pnPassportNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnPassportNumber.Location = new System.Drawing.Point(583, 19);
            this.pnPassportNumber.Name = "pnPassportNumber";
            this.pnPassportNumber.Size = new System.Drawing.Size(145, 50);
            this.pnPassportNumber.TabIndex = 5;
            // 
            // tbPassportNumber
            // 
            this.tbPassportNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPassportNumber.Location = new System.Drawing.Point(0, 16);
            this.tbPassportNumber.Name = "tbPassportNumber";
            this.tbPassportNumber.Size = new System.Drawing.Size(145, 23);
            this.tbPassportNumber.TabIndex = 3;
            // 
            // lbPassportNumber
            // 
            this.lbPassportNumber.AutoSize = true;
            this.lbPassportNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPassportNumber.Location = new System.Drawing.Point(0, 0);
            this.lbPassportNumber.Name = "lbPassportNumber";
            this.lbPassportNumber.Size = new System.Drawing.Size(117, 16);
            this.lbPassportNumber.TabIndex = 1;
            this.lbPassportNumber.Text = "Номер паспорта";
            // 
            // pnPassportSeries
            // 
            this.pnPassportSeries.Controls.Add(this.tbPassportSeries);
            this.pnPassportSeries.Controls.Add(this.lbPassportSeries);
            this.pnPassportSeries.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnPassportSeries.Location = new System.Drawing.Point(438, 19);
            this.pnPassportSeries.Name = "pnPassportSeries";
            this.pnPassportSeries.Size = new System.Drawing.Size(145, 50);
            this.pnPassportSeries.TabIndex = 4;
            // 
            // tbPassportSeries
            // 
            this.tbPassportSeries.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPassportSeries.Location = new System.Drawing.Point(0, 16);
            this.tbPassportSeries.Name = "tbPassportSeries";
            this.tbPassportSeries.Size = new System.Drawing.Size(145, 23);
            this.tbPassportSeries.TabIndex = 3;
            // 
            // lbPassportSeries
            // 
            this.lbPassportSeries.AutoSize = true;
            this.lbPassportSeries.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPassportSeries.Location = new System.Drawing.Point(0, 0);
            this.lbPassportSeries.Name = "lbPassportSeries";
            this.lbPassportSeries.Size = new System.Drawing.Size(116, 16);
            this.lbPassportSeries.TabIndex = 1;
            this.lbPassportSeries.Text = "Серия паспорта";
            // 
            // pnPatronymic
            // 
            this.pnPatronymic.Controls.Add(this.tbPatronymic);
            this.pnPatronymic.Controls.Add(this.lbPatronymic);
            this.pnPatronymic.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnPatronymic.Location = new System.Drawing.Point(293, 19);
            this.pnPatronymic.Name = "pnPatronymic";
            this.pnPatronymic.Size = new System.Drawing.Size(145, 50);
            this.pnPatronymic.TabIndex = 3;
            // 
            // tbPatronymic
            // 
            this.tbPatronymic.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPatronymic.Location = new System.Drawing.Point(0, 16);
            this.tbPatronymic.Name = "tbPatronymic";
            this.tbPatronymic.Size = new System.Drawing.Size(145, 23);
            this.tbPatronymic.TabIndex = 3;
            // 
            // lbPatronymic
            // 
            this.lbPatronymic.AutoSize = true;
            this.lbPatronymic.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPatronymic.Location = new System.Drawing.Point(0, 0);
            this.lbPatronymic.Name = "lbPatronymic";
            this.lbPatronymic.Size = new System.Drawing.Size(70, 16);
            this.lbPatronymic.TabIndex = 1;
            this.lbPatronymic.Text = "Отчество";
            // 
            // pnName
            // 
            this.pnName.Controls.Add(this.tbName);
            this.pnName.Controls.Add(this.lbName);
            this.pnName.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnName.Location = new System.Drawing.Point(148, 19);
            this.pnName.Name = "pnName";
            this.pnName.Size = new System.Drawing.Size(145, 50);
            this.pnName.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbName.Location = new System.Drawing.Point(0, 16);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(145, 23);
            this.tbName.TabIndex = 3;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbName.Location = new System.Drawing.Point(0, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(36, 16);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Имя";
            // 
            // pnSurname
            // 
            this.pnSurname.Controls.Add(this.tbSurname);
            this.pnSurname.Controls.Add(this.lbSurname);
            this.pnSurname.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSurname.Location = new System.Drawing.Point(3, 19);
            this.pnSurname.Name = "pnSurname";
            this.pnSurname.Size = new System.Drawing.Size(145, 50);
            this.pnSurname.TabIndex = 1;
            // 
            // tbSurname
            // 
            this.tbSurname.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSurname.Location = new System.Drawing.Point(0, 16);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(145, 23);
            this.tbSurname.TabIndex = 2;
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSurname.Location = new System.Drawing.Point(0, 0);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(69, 16);
            this.lbSurname.TabIndex = 0;
            this.lbSurname.Text = "Фамилия";
            // 
            // gbSearchBook
            // 
            this.gbSearchBook.Controls.Add(this.dgvBook);
            this.gbSearchBook.Controls.Add(this.panel11);
            this.gbSearchBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSearchBook.Location = new System.Drawing.Point(0, 72);
            this.gbSearchBook.Name = "gbSearchBook";
            this.gbSearchBook.Size = new System.Drawing.Size(1062, 376);
            this.gbSearchBook.TabIndex = 7;
            this.gbSearchBook.TabStop = false;
            this.gbSearchBook.Text = "Поиск книги";
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToDeleteRows = false;
            this.dgvBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBook.BackgroundColor = System.Drawing.Color.White;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBook.Enabled = false;
            this.dgvBook.Location = new System.Drawing.Point(3, 59);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            this.dgvBook.RowTemplate.Height = 24;
            this.dgvBook.Size = new System.Drawing.Size(1056, 314);
            this.dgvBook.TabIndex = 7;
            this.dgvBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellClick);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnCheckBook);
            this.panel11.Controls.Add(this.pnPublishing);
            this.panel11.Controls.Add(this.pnGenre);
            this.panel11.Controls.Add(this.pnWriter);
            this.panel11.Controls.Add(this.pnTitleBook);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(3, 19);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1056, 40);
            this.panel11.TabIndex = 6;
            // 
            // btnCheckBook
            // 
            this.btnCheckBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCheckBook.Enabled = false;
            this.btnCheckBook.Location = new System.Drawing.Point(913, 0);
            this.btnCheckBook.Name = "btnCheckBook";
            this.btnCheckBook.Size = new System.Drawing.Size(143, 45);
            this.btnCheckBook.TabIndex = 6;
            this.btnCheckBook.Text = "Проверить наличие книги";
            this.btnCheckBook.UseVisualStyleBackColor = true;
            this.btnCheckBook.Click += new System.EventHandler(this.btnCheckBook_Click);
            // 
            // pnPublishing
            // 
            this.pnPublishing.Controls.Add(this.cbPublishing);
            this.pnPublishing.Controls.Add(this.lbPublishing);
            this.pnPublishing.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnPublishing.Location = new System.Drawing.Point(677, 0);
            this.pnPublishing.Name = "pnPublishing";
            this.pnPublishing.Size = new System.Drawing.Size(236, 40);
            this.pnPublishing.TabIndex = 5;
            // 
            // cbPublishing
            // 
            this.cbPublishing.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbPublishing.Enabled = false;
            this.cbPublishing.FormattingEnabled = true;
            this.cbPublishing.Location = new System.Drawing.Point(0, 16);
            this.cbPublishing.Name = "cbPublishing";
            this.cbPublishing.Size = new System.Drawing.Size(236, 24);
            this.cbPublishing.TabIndex = 1;
            this.cbPublishing.TextChanged += new System.EventHandler(this.cbPublishing_TextChanged);
            // 
            // lbPublishing
            // 
            this.lbPublishing.AutoSize = true;
            this.lbPublishing.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPublishing.Location = new System.Drawing.Point(0, 0);
            this.lbPublishing.Name = "lbPublishing";
            this.lbPublishing.Size = new System.Drawing.Size(168, 16);
            this.lbPublishing.TabIndex = 0;
            this.lbPublishing.Text = "Выберите издательство";
            // 
            // pnGenre
            // 
            this.pnGenre.Controls.Add(this.cbGenre);
            this.pnGenre.Controls.Add(this.lbGenre);
            this.pnGenre.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnGenre.Location = new System.Drawing.Point(441, 0);
            this.pnGenre.Name = "pnGenre";
            this.pnGenre.Size = new System.Drawing.Size(236, 40);
            this.pnGenre.TabIndex = 4;
            // 
            // cbGenre
            // 
            this.cbGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbGenre.Enabled = false;
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(0, 16);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(236, 24);
            this.cbGenre.TabIndex = 1;
            this.cbGenre.TextChanged += new System.EventHandler(this.cbGenre_TextChanged);
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbGenre.Location = new System.Drawing.Point(0, 0);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(111, 16);
            this.lbGenre.TabIndex = 0;
            this.lbGenre.Text = "Выберите жанр";
            // 
            // pnWriter
            // 
            this.pnWriter.Controls.Add(this.cbWriter);
            this.pnWriter.Controls.Add(this.lbWriter);
            this.pnWriter.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnWriter.Location = new System.Drawing.Point(205, 0);
            this.pnWriter.Name = "pnWriter";
            this.pnWriter.Size = new System.Drawing.Size(236, 40);
            this.pnWriter.TabIndex = 3;
            // 
            // cbWriter
            // 
            this.cbWriter.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbWriter.Enabled = false;
            this.cbWriter.FormattingEnabled = true;
            this.cbWriter.Location = new System.Drawing.Point(0, 16);
            this.cbWriter.Name = "cbWriter";
            this.cbWriter.Size = new System.Drawing.Size(236, 24);
            this.cbWriter.TabIndex = 1;
            this.cbWriter.TextChanged += new System.EventHandler(this.cbWriter_TextChanged);
            // 
            // lbWriter
            // 
            this.lbWriter.AutoSize = true;
            this.lbWriter.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbWriter.Location = new System.Drawing.Point(0, 0);
            this.lbWriter.Name = "lbWriter";
            this.lbWriter.Size = new System.Drawing.Size(124, 16);
            this.lbWriter.TabIndex = 0;
            this.lbWriter.Text = "Выберите автора";
            // 
            // pnTitleBook
            // 
            this.pnTitleBook.Controls.Add(this.tbTitleBook);
            this.pnTitleBook.Controls.Add(this.lbTitleBook);
            this.pnTitleBook.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnTitleBook.Location = new System.Drawing.Point(0, 0);
            this.pnTitleBook.Name = "pnTitleBook";
            this.pnTitleBook.Size = new System.Drawing.Size(205, 40);
            this.pnTitleBook.TabIndex = 2;
            // 
            // tbTitleBook
            // 
            this.tbTitleBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbTitleBook.Enabled = false;
            this.tbTitleBook.Location = new System.Drawing.Point(0, 16);
            this.tbTitleBook.Name = "tbTitleBook";
            this.tbTitleBook.Size = new System.Drawing.Size(205, 23);
            this.tbTitleBook.TabIndex = 2;
            this.tbTitleBook.TextChanged += new System.EventHandler(this.tbTitleBook_TextChanged);
            // 
            // lbTitleBook
            // 
            this.lbTitleBook.AutoSize = true;
            this.lbTitleBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitleBook.Location = new System.Drawing.Point(0, 0);
            this.lbTitleBook.Name = "lbTitleBook";
            this.lbTitleBook.Size = new System.Drawing.Size(128, 16);
            this.lbTitleBook.TabIndex = 0;
            this.lbTitleBook.Text = "Введите название";
            // 
            // gbIssueBook
            // 
            this.gbIssueBook.Controls.Add(this.panel15);
            this.gbIssueBook.Controls.Add(this.pnDateRetirnBook);
            this.gbIssueBook.Controls.Add(this.pnNumberDays);
            this.gbIssueBook.Controls.Add(this.pnDateIssueBook);
            this.gbIssueBook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbIssueBook.Location = new System.Drawing.Point(0, 448);
            this.gbIssueBook.Name = "gbIssueBook";
            this.gbIssueBook.Size = new System.Drawing.Size(1062, 72);
            this.gbIssueBook.TabIndex = 8;
            this.gbIssueBook.TabStop = false;
            this.gbIssueBook.Text = "Настройка длительности выдачи";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.btnCancel);
            this.panel15.Controls.Add(this.btnIssueBook);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(618, 19);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(441, 50);
            this.panel15.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCancel.Location = new System.Drawing.Point(0, 23);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(441, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnIssueBook
            // 
            this.btnIssueBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIssueBook.Enabled = false;
            this.btnIssueBook.Location = new System.Drawing.Point(0, 0);
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.Size = new System.Drawing.Size(441, 23);
            this.btnIssueBook.TabIndex = 0;
            this.btnIssueBook.Text = "Выдать книгу";
            this.btnIssueBook.UseVisualStyleBackColor = true;
            this.btnIssueBook.Click += new System.EventHandler(this.btnIssueBook_Click);
            // 
            // pnDateRetirnBook
            // 
            this.pnDateRetirnBook.Controls.Add(this.tbDateReturn);
            this.pnDateRetirnBook.Controls.Add(this.lbDateReturnBook);
            this.pnDateRetirnBook.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnDateRetirnBook.Location = new System.Drawing.Point(413, 19);
            this.pnDateRetirnBook.Name = "pnDateRetirnBook";
            this.pnDateRetirnBook.Size = new System.Drawing.Size(205, 50);
            this.pnDateRetirnBook.TabIndex = 5;
            // 
            // tbDateReturn
            // 
            this.tbDateReturn.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbDateReturn.Location = new System.Drawing.Point(0, 16);
            this.tbDateReturn.Name = "tbDateReturn";
            this.tbDateReturn.ReadOnly = true;
            this.tbDateReturn.Size = new System.Drawing.Size(205, 23);
            this.tbDateReturn.TabIndex = 5;
            // 
            // lbDateReturnBook
            // 
            this.lbDateReturnBook.AutoSize = true;
            this.lbDateReturnBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDateReturnBook.Location = new System.Drawing.Point(0, 0);
            this.lbDateReturnBook.Name = "lbDateReturnBook";
            this.lbDateReturnBook.Size = new System.Drawing.Size(142, 16);
            this.lbDateReturnBook.TabIndex = 0;
            this.lbDateReturnBook.Text = "Дата возврата книги";
            // 
            // pnNumberDays
            // 
            this.pnNumberDays.Controls.Add(this.nudNumberDays);
            this.pnNumberDays.Controls.Add(this.lbNumberDays);
            this.pnNumberDays.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnNumberDays.Location = new System.Drawing.Point(208, 19);
            this.pnNumberDays.Name = "pnNumberDays";
            this.pnNumberDays.Size = new System.Drawing.Size(205, 50);
            this.pnNumberDays.TabIndex = 4;
            // 
            // nudNumberDays
            // 
            this.nudNumberDays.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudNumberDays.Enabled = false;
            this.nudNumberDays.Location = new System.Drawing.Point(0, 16);
            this.nudNumberDays.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.nudNumberDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberDays.Name = "nudNumberDays";
            this.nudNumberDays.Size = new System.Drawing.Size(205, 23);
            this.nudNumberDays.TabIndex = 3;
            this.nudNumberDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberDays.ValueChanged += new System.EventHandler(this.nudNumberDays_ValueChanged);
            // 
            // lbNumberDays
            // 
            this.lbNumberDays.AutoSize = true;
            this.lbNumberDays.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbNumberDays.Location = new System.Drawing.Point(0, 0);
            this.lbNumberDays.Name = "lbNumberDays";
            this.lbNumberDays.Size = new System.Drawing.Size(172, 16);
            this.lbNumberDays.TabIndex = 0;
            this.lbNumberDays.Text = "Количество дней выдачи";
            // 
            // pnDateIssueBook
            // 
            this.pnDateIssueBook.Controls.Add(this.dtpDateIssueBook);
            this.pnDateIssueBook.Controls.Add(this.lbDateIssueBook);
            this.pnDateIssueBook.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnDateIssueBook.Location = new System.Drawing.Point(3, 19);
            this.pnDateIssueBook.Name = "pnDateIssueBook";
            this.pnDateIssueBook.Size = new System.Drawing.Size(205, 50);
            this.pnDateIssueBook.TabIndex = 3;
            // 
            // dtpDateIssueBook
            // 
            this.dtpDateIssueBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpDateIssueBook.Enabled = false;
            this.dtpDateIssueBook.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateIssueBook.Location = new System.Drawing.Point(0, 16);
            this.dtpDateIssueBook.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpDateIssueBook.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDateIssueBook.Name = "dtpDateIssueBook";
            this.dtpDateIssueBook.Size = new System.Drawing.Size(205, 23);
            this.dtpDateIssueBook.TabIndex = 19;
            // 
            // lbDateIssueBook
            // 
            this.lbDateIssueBook.AutoSize = true;
            this.lbDateIssueBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDateIssueBook.Location = new System.Drawing.Point(0, 0);
            this.lbDateIssueBook.Name = "lbDateIssueBook";
            this.lbDateIssueBook.Size = new System.Drawing.Size(131, 16);
            this.lbDateIssueBook.TabIndex = 0;
            this.lbDateIssueBook.Text = "Дата выдачи книги";
            // 
            // IssueBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 556);
            this.Controls.Add(this.gbSearchBook);
            this.Controls.Add(this.gbIssueBook);
            this.Controls.Add(this.gbSearchReader);
            this.Controls.Add(this.pnCancel);
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "IssueBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IssueBookForm";
            this.pnCancel.ResumeLayout(false);
            this.gbSearchReader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnPassportNumber.ResumeLayout(false);
            this.pnPassportNumber.PerformLayout();
            this.pnPassportSeries.ResumeLayout(false);
            this.pnPassportSeries.PerformLayout();
            this.pnPatronymic.ResumeLayout(false);
            this.pnPatronymic.PerformLayout();
            this.pnName.ResumeLayout(false);
            this.pnName.PerformLayout();
            this.pnSurname.ResumeLayout(false);
            this.pnSurname.PerformLayout();
            this.gbSearchBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.panel11.ResumeLayout(false);
            this.pnPublishing.ResumeLayout(false);
            this.pnPublishing.PerformLayout();
            this.pnGenre.ResumeLayout(false);
            this.pnGenre.PerformLayout();
            this.pnWriter.ResumeLayout(false);
            this.pnWriter.PerformLayout();
            this.pnTitleBook.ResumeLayout(false);
            this.pnTitleBook.PerformLayout();
            this.gbIssueBook.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.pnDateRetirnBook.ResumeLayout(false);
            this.pnDateRetirnBook.PerformLayout();
            this.pnNumberDays.ResumeLayout(false);
            this.pnNumberDays.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberDays)).EndInit();
            this.pnDateIssueBook.ResumeLayout(false);
            this.pnDateIssueBook.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnError;
        private System.Windows.Forms.GroupBox gbSearchReader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegistrationReader;
        private System.Windows.Forms.Button btnIdentificationReader;
        private System.Windows.Forms.Panel pnPassportNumber;
        private System.Windows.Forms.TextBox tbPassportNumber;
        private System.Windows.Forms.Label lbPassportNumber;
        private System.Windows.Forms.Panel pnPassportSeries;
        private System.Windows.Forms.TextBox tbPassportSeries;
        private System.Windows.Forms.Label lbPassportSeries;
        private System.Windows.Forms.Panel pnPatronymic;
        private System.Windows.Forms.TextBox tbPatronymic;
        private System.Windows.Forms.Label lbPatronymic;
        private System.Windows.Forms.Panel pnName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel pnSurname;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.GroupBox gbSearchBook;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnCheckBook;
        private System.Windows.Forms.Panel pnPublishing;
        private System.Windows.Forms.ComboBox cbPublishing;
        private System.Windows.Forms.Label lbPublishing;
        private System.Windows.Forms.Panel pnGenre;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.Panel pnWriter;
        private System.Windows.Forms.ComboBox cbWriter;
        private System.Windows.Forms.Label lbWriter;
        private System.Windows.Forms.Panel pnTitleBook;
        private System.Windows.Forms.TextBox tbTitleBook;
        private System.Windows.Forms.Label lbTitleBook;
        private System.Windows.Forms.GroupBox gbIssueBook;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnIssueBook;
        private System.Windows.Forms.Panel pnDateRetirnBook;
        private System.Windows.Forms.Label lbDateReturnBook;
        private System.Windows.Forms.Panel pnNumberDays;
        private System.Windows.Forms.Label lbNumberDays;
        private System.Windows.Forms.Panel pnDateIssueBook;
        private System.Windows.Forms.Label lbDateIssueBook;
        private System.Windows.Forms.DateTimePicker dtpDateIssueBook;
        private System.Windows.Forms.NumericUpDown nudNumberDays;
        private System.Windows.Forms.TextBox tbDateReturn;
    }
}