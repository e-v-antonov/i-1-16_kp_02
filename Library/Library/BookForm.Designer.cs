namespace Library
{
    partial class BookForm
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
            this.pnSearch = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.pnFiltration = new System.Windows.Forms.Panel();
            this.chbFiltration = new System.Windows.Forms.CheckBox();
            this.pnCancel = new System.Windows.Forms.Panel();
            this.btnError = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbWriter = new System.Windows.Forms.ComboBox();
            this.cbPublishing = new System.Windows.Forms.ComboBox();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.tbNumberPages = new System.Windows.Forms.TextBox();
            this.tbBookTitle = new System.Windows.Forms.TextBox();
            this.tbDatePublication = new System.Windows.Forms.TextBox();
            this.gbManipulationData = new System.Windows.Forms.GroupBox();
            this.pnComboBox = new System.Windows.Forms.Panel();
            this.pnUpdateButtons = new System.Windows.Forms.Panel();
            this.btnUpdateGenre = new System.Windows.Forms.Button();
            this.btnUpdatePublishing = new System.Windows.Forms.Button();
            this.btnUpdateWriter = new System.Windows.Forms.Button();
            this.lbGenre = new System.Windows.Forms.Label();
            this.lbPublishing = new System.Windows.Forms.Label();
            this.lbWriter = new System.Windows.Forms.Label();
            this.pnTextBox = new System.Windows.Forms.Panel();
            this.tbDateRegistration = new System.Windows.Forms.TextBox();
            this.lbDateRegisration = new System.Windows.Forms.Label();
            this.tbAvailableCopies = new System.Windows.Forms.TextBox();
            this.lbAvailableCopies = new System.Windows.Forms.Label();
            this.tbTotalCopies = new System.Windows.Forms.TextBox();
            this.lbTotalCopies = new System.Windows.Forms.Label();
            this.tbCostBook = new System.Windows.Forms.TextBox();
            this.lbCostBook = new System.Windows.Forms.Label();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.lbISBN = new System.Windows.Forms.Label();
            this.lbNumberPages = new System.Windows.Forms.Label();
            this.lbDatePublication = new System.Windows.Forms.Label();
            this.lbBookTitle = new System.Windows.Forms.Label();
            this.pnManipulationButtons = new System.Windows.Forms.Panel();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.gbSearchAndFiltration.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.pnFiltration.SuspendLayout();
            this.pnCancel.SuspendLayout();
            this.gbManipulationData.SuspendLayout();
            this.pnComboBox.SuspendLayout();
            this.pnUpdateButtons.SuspendLayout();
            this.pnTextBox.SuspendLayout();
            this.pnManipulationButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSearchAndFiltration
            // 
            this.gbSearchAndFiltration.Controls.Add(this.pnSearch);
            this.gbSearchAndFiltration.Controls.Add(this.pnFiltration);
            this.gbSearchAndFiltration.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSearchAndFiltration.Location = new System.Drawing.Point(0, 0);
            this.gbSearchAndFiltration.Name = "gbSearchAndFiltration";
            this.gbSearchAndFiltration.Size = new System.Drawing.Size(1108, 48);
            this.gbSearchAndFiltration.TabIndex = 3;
            this.gbSearchAndFiltration.TabStop = false;
            this.gbSearchAndFiltration.Text = "Поиск и фильтрация:";
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.tbSearch);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSearch.Location = new System.Drawing.Point(3, 19);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(969, 32);
            this.pnSearch.TabIndex = 2;
            // 
            // tbSearch
            // 
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSearch.Location = new System.Drawing.Point(0, 0);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(969, 23);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.Text = "Введите данные книги...";
            this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
            this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
            // 
            // pnFiltration
            // 
            this.pnFiltration.Controls.Add(this.chbFiltration);
            this.pnFiltration.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnFiltration.Location = new System.Drawing.Point(972, 19);
            this.pnFiltration.Name = "pnFiltration";
            this.pnFiltration.Size = new System.Drawing.Size(133, 26);
            this.pnFiltration.TabIndex = 3;
            // 
            // chbFiltration
            // 
            this.chbFiltration.AutoSize = true;
            this.chbFiltration.Dock = System.Windows.Forms.DockStyle.Right;
            this.chbFiltration.Location = new System.Drawing.Point(-19, 0);
            this.chbFiltration.Name = "chbFiltration";
            this.chbFiltration.Size = new System.Drawing.Size(152, 26);
            this.chbFiltration.TabIndex = 1;
            this.chbFiltration.Text = "Отфильтровывать";
            this.chbFiltration.UseVisualStyleBackColor = true;
            this.chbFiltration.CheckedChanged += new System.EventHandler(this.chbFiltration_CheckedChanged);
            // 
            // pnCancel
            // 
            this.pnCancel.Controls.Add(this.btnError);
            this.pnCancel.Controls.Add(this.btnExit);
            this.pnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCancel.Location = new System.Drawing.Point(0, 518);
            this.pnCancel.Name = "pnCancel";
            this.pnCancel.Size = new System.Drawing.Size(1108, 36);
            this.pnCancel.TabIndex = 4;
            // 
            // btnError
            // 
            this.btnError.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnError.Location = new System.Drawing.Point(0, 0);
            this.btnError.Name = "btnError";
            this.btnError.Size = new System.Drawing.Size(119, 36);
            this.btnError.TabIndex = 1;
            this.btnError.Text = "Ошибки";
            this.btnError.UseVisualStyleBackColor = true;
            this.btnError.Click += new System.EventHandler(this.btnError_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Location = new System.Drawing.Point(989, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 36);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Закрыть";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbWriter
            // 
            this.cbWriter.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbWriter.FormattingEnabled = true;
            this.cbWriter.Location = new System.Drawing.Point(0, 16);
            this.cbWriter.Name = "cbWriter";
            this.cbWriter.Size = new System.Drawing.Size(266, 24);
            this.cbWriter.TabIndex = 5;
            // 
            // cbPublishing
            // 
            this.cbPublishing.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbPublishing.FormattingEnabled = true;
            this.cbPublishing.Location = new System.Drawing.Point(0, 56);
            this.cbPublishing.Name = "cbPublishing";
            this.cbPublishing.Size = new System.Drawing.Size(266, 24);
            this.cbPublishing.TabIndex = 6;
            // 
            // cbGenre
            // 
            this.cbGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(0, 96);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(266, 24);
            this.cbGenre.TabIndex = 7;
            // 
            // tbNumberPages
            // 
            this.tbNumberPages.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbNumberPages.Location = new System.Drawing.Point(0, 94);
            this.tbNumberPages.Name = "tbNumberPages";
            this.tbNumberPages.Size = new System.Drawing.Size(266, 23);
            this.tbNumberPages.TabIndex = 8;
            // 
            // tbBookTitle
            // 
            this.tbBookTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbBookTitle.Location = new System.Drawing.Point(0, 16);
            this.tbBookTitle.Name = "tbBookTitle";
            this.tbBookTitle.Size = new System.Drawing.Size(266, 23);
            this.tbBookTitle.TabIndex = 9;
            // 
            // tbDatePublication
            // 
            this.tbDatePublication.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbDatePublication.Location = new System.Drawing.Point(0, 55);
            this.tbDatePublication.Name = "tbDatePublication";
            this.tbDatePublication.Size = new System.Drawing.Size(266, 23);
            this.tbDatePublication.TabIndex = 10;
            // 
            // gbManipulationData
            // 
            this.gbManipulationData.Controls.Add(this.pnComboBox);
            this.gbManipulationData.Controls.Add(this.pnTextBox);
            this.gbManipulationData.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbManipulationData.Location = new System.Drawing.Point(0, 48);
            this.gbManipulationData.Name = "gbManipulationData";
            this.gbManipulationData.Size = new System.Drawing.Size(272, 470);
            this.gbManipulationData.TabIndex = 16;
            this.gbManipulationData.TabStop = false;
            this.gbManipulationData.Text = "Манипулирование даннными:";
            // 
            // pnComboBox
            // 
            this.pnComboBox.Controls.Add(this.pnUpdateButtons);
            this.pnComboBox.Controls.Add(this.cbGenre);
            this.pnComboBox.Controls.Add(this.lbGenre);
            this.pnComboBox.Controls.Add(this.cbPublishing);
            this.pnComboBox.Controls.Add(this.lbPublishing);
            this.pnComboBox.Controls.Add(this.cbWriter);
            this.pnComboBox.Controls.Add(this.lbWriter);
            this.pnComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnComboBox.Location = new System.Drawing.Point(3, 292);
            this.pnComboBox.Name = "pnComboBox";
            this.pnComboBox.Size = new System.Drawing.Size(266, 192);
            this.pnComboBox.TabIndex = 3;
            // 
            // pnUpdateButtons
            // 
            this.pnUpdateButtons.Controls.Add(this.btnUpdateGenre);
            this.pnUpdateButtons.Controls.Add(this.btnUpdatePublishing);
            this.pnUpdateButtons.Controls.Add(this.btnUpdateWriter);
            this.pnUpdateButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnUpdateButtons.Location = new System.Drawing.Point(0, 120);
            this.pnUpdateButtons.Name = "pnUpdateButtons";
            this.pnUpdateButtons.Size = new System.Drawing.Size(266, 72);
            this.pnUpdateButtons.TabIndex = 18;
            // 
            // btnUpdateGenre
            // 
            this.btnUpdateGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateGenre.Enabled = false;
            this.btnUpdateGenre.Location = new System.Drawing.Point(0, 46);
            this.btnUpdateGenre.Name = "btnUpdateGenre";
            this.btnUpdateGenre.Size = new System.Drawing.Size(266, 23);
            this.btnUpdateGenre.TabIndex = 2;
            this.btnUpdateGenre.Text = "Редактировать жанры";
            this.btnUpdateGenre.UseVisualStyleBackColor = true;
            this.btnUpdateGenre.Click += new System.EventHandler(this.btnUpdateGenre_Click);
            // 
            // btnUpdatePublishing
            // 
            this.btnUpdatePublishing.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdatePublishing.Enabled = false;
            this.btnUpdatePublishing.Location = new System.Drawing.Point(0, 23);
            this.btnUpdatePublishing.Name = "btnUpdatePublishing";
            this.btnUpdatePublishing.Size = new System.Drawing.Size(266, 23);
            this.btnUpdatePublishing.TabIndex = 1;
            this.btnUpdatePublishing.Text = "Редактировать издательства";
            this.btnUpdatePublishing.UseVisualStyleBackColor = true;
            this.btnUpdatePublishing.Click += new System.EventHandler(this.btnUpdatePublishing_Click);
            // 
            // btnUpdateWriter
            // 
            this.btnUpdateWriter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateWriter.Enabled = false;
            this.btnUpdateWriter.Location = new System.Drawing.Point(0, 0);
            this.btnUpdateWriter.Name = "btnUpdateWriter";
            this.btnUpdateWriter.Size = new System.Drawing.Size(266, 23);
            this.btnUpdateWriter.TabIndex = 0;
            this.btnUpdateWriter.Text = "Редактировать авторов";
            this.btnUpdateWriter.UseVisualStyleBackColor = true;
            this.btnUpdateWriter.Click += new System.EventHandler(this.btnUpdateWriter_Click);
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbGenre.Location = new System.Drawing.Point(0, 80);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(45, 16);
            this.lbGenre.TabIndex = 20;
            this.lbGenre.Text = "Жанр";
            // 
            // lbPublishing
            // 
            this.lbPublishing.AutoSize = true;
            this.lbPublishing.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPublishing.Location = new System.Drawing.Point(0, 40);
            this.lbPublishing.Name = "lbPublishing";
            this.lbPublishing.Size = new System.Drawing.Size(100, 16);
            this.lbPublishing.TabIndex = 19;
            this.lbPublishing.Text = "Издательство";
            // 
            // lbWriter
            // 
            this.lbWriter.AutoSize = true;
            this.lbWriter.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbWriter.Location = new System.Drawing.Point(0, 0);
            this.lbWriter.Name = "lbWriter";
            this.lbWriter.Size = new System.Drawing.Size(47, 16);
            this.lbWriter.TabIndex = 18;
            this.lbWriter.Text = "Автор";
            // 
            // pnTextBox
            // 
            this.pnTextBox.Controls.Add(this.tbDateRegistration);
            this.pnTextBox.Controls.Add(this.lbDateRegisration);
            this.pnTextBox.Controls.Add(this.tbAvailableCopies);
            this.pnTextBox.Controls.Add(this.lbAvailableCopies);
            this.pnTextBox.Controls.Add(this.tbTotalCopies);
            this.pnTextBox.Controls.Add(this.lbTotalCopies);
            this.pnTextBox.Controls.Add(this.tbCostBook);
            this.pnTextBox.Controls.Add(this.lbCostBook);
            this.pnTextBox.Controls.Add(this.tbISBN);
            this.pnTextBox.Controls.Add(this.lbISBN);
            this.pnTextBox.Controls.Add(this.tbNumberPages);
            this.pnTextBox.Controls.Add(this.lbNumberPages);
            this.pnTextBox.Controls.Add(this.tbDatePublication);
            this.pnTextBox.Controls.Add(this.lbDatePublication);
            this.pnTextBox.Controls.Add(this.tbBookTitle);
            this.pnTextBox.Controls.Add(this.lbBookTitle);
            this.pnTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTextBox.Location = new System.Drawing.Point(3, 19);
            this.pnTextBox.Name = "pnTextBox";
            this.pnTextBox.Size = new System.Drawing.Size(266, 273);
            this.pnTextBox.TabIndex = 17;
            // 
            // tbDateRegistration
            // 
            this.tbDateRegistration.BackColor = System.Drawing.SystemColors.Control;
            this.tbDateRegistration.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbDateRegistration.Location = new System.Drawing.Point(0, 289);
            this.tbDateRegistration.Name = "tbDateRegistration";
            this.tbDateRegistration.ReadOnly = true;
            this.tbDateRegistration.Size = new System.Drawing.Size(266, 23);
            this.tbDateRegistration.TabIndex = 9;
            // 
            // lbDateRegisration
            // 
            this.lbDateRegisration.AutoSize = true;
            this.lbDateRegisration.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDateRegisration.Location = new System.Drawing.Point(0, 273);
            this.lbDateRegisration.Name = "lbDateRegisration";
            this.lbDateRegisration.Size = new System.Drawing.Size(167, 16);
            this.lbDateRegisration.TabIndex = 18;
            this.lbDateRegisration.Text = "Дата регистрации книги";
            // 
            // tbAvailableCopies
            // 
            this.tbAvailableCopies.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbAvailableCopies.Location = new System.Drawing.Point(0, 250);
            this.tbAvailableCopies.Name = "tbAvailableCopies";
            this.tbAvailableCopies.ReadOnly = true;
            this.tbAvailableCopies.Size = new System.Drawing.Size(266, 23);
            this.tbAvailableCopies.TabIndex = 8;
            // 
            // lbAvailableCopies
            // 
            this.lbAvailableCopies.AutoSize = true;
            this.lbAvailableCopies.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbAvailableCopies.Location = new System.Drawing.Point(0, 234);
            this.lbAvailableCopies.Name = "lbAvailableCopies";
            this.lbAvailableCopies.Size = new System.Drawing.Size(244, 16);
            this.lbAvailableCopies.TabIndex = 17;
            this.lbAvailableCopies.Text = "Доступное количество экземпляров";
            // 
            // tbTotalCopies
            // 
            this.tbTotalCopies.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbTotalCopies.Location = new System.Drawing.Point(0, 211);
            this.tbTotalCopies.Name = "tbTotalCopies";
            this.tbTotalCopies.Size = new System.Drawing.Size(266, 23);
            this.tbTotalCopies.TabIndex = 10;
            // 
            // lbTotalCopies
            // 
            this.lbTotalCopies.AutoSize = true;
            this.lbTotalCopies.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTotalCopies.Location = new System.Drawing.Point(0, 195);
            this.lbTotalCopies.Name = "lbTotalCopies";
            this.lbTotalCopies.Size = new System.Drawing.Size(220, 16);
            this.lbTotalCopies.TabIndex = 19;
            this.lbTotalCopies.Text = "Общее количество экземпляров";
            // 
            // tbCostBook
            // 
            this.tbCostBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbCostBook.Location = new System.Drawing.Point(0, 172);
            this.tbCostBook.Name = "tbCostBook";
            this.tbCostBook.Size = new System.Drawing.Size(266, 23);
            this.tbCostBook.TabIndex = 9;
            // 
            // lbCostBook
            // 
            this.lbCostBook.AutoSize = true;
            this.lbCostBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCostBook.Location = new System.Drawing.Point(0, 156);
            this.lbCostBook.Name = "lbCostBook";
            this.lbCostBook.Size = new System.Drawing.Size(193, 16);
            this.lbCostBook.TabIndex = 18;
            this.lbCostBook.Text = "Стоимость экземпляра, руб";
            // 
            // tbISBN
            // 
            this.tbISBN.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbISBN.Location = new System.Drawing.Point(0, 133);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(266, 23);
            this.tbISBN.TabIndex = 8;
            // 
            // lbISBN
            // 
            this.lbISBN.AutoSize = true;
            this.lbISBN.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbISBN.Location = new System.Drawing.Point(0, 117);
            this.lbISBN.Name = "lbISBN";
            this.lbISBN.Size = new System.Drawing.Size(85, 16);
            this.lbISBN.TabIndex = 17;
            this.lbISBN.Text = "Номер ISBN";
            // 
            // lbNumberPages
            // 
            this.lbNumberPages.AutoSize = true;
            this.lbNumberPages.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbNumberPages.Location = new System.Drawing.Point(0, 78);
            this.lbNumberPages.Name = "lbNumberPages";
            this.lbNumberPages.Size = new System.Drawing.Size(143, 16);
            this.lbNumberPages.TabIndex = 19;
            this.lbNumberPages.Text = "Количество страниц";
            // 
            // lbDatePublication
            // 
            this.lbDatePublication.AutoSize = true;
            this.lbDatePublication.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDatePublication.Location = new System.Drawing.Point(0, 39);
            this.lbDatePublication.Name = "lbDatePublication";
            this.lbDatePublication.Size = new System.Drawing.Size(89, 16);
            this.lbDatePublication.TabIndex = 18;
            this.lbDatePublication.Text = "Год издания";
            // 
            // lbBookTitle
            // 
            this.lbBookTitle.AutoSize = true;
            this.lbBookTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbBookTitle.Location = new System.Drawing.Point(0, 0);
            this.lbBookTitle.Name = "lbBookTitle";
            this.lbBookTitle.Size = new System.Drawing.Size(109, 16);
            this.lbBookTitle.TabIndex = 17;
            this.lbBookTitle.Text = "Название книги";
            // 
            // pnManipulationButtons
            // 
            this.pnManipulationButtons.Controls.Add(this.btnInsert);
            this.pnManipulationButtons.Controls.Add(this.btnDelete);
            this.pnManipulationButtons.Controls.Add(this.btnUpdate);
            this.pnManipulationButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnManipulationButtons.Location = new System.Drawing.Point(272, 482);
            this.pnManipulationButtons.Name = "pnManipulationButtons";
            this.pnManipulationButtons.Size = new System.Drawing.Size(836, 36);
            this.pnManipulationButtons.TabIndex = 4;
            // 
            // btnInsert
            // 
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInsert.Enabled = false;
            this.btnInsert.Location = new System.Drawing.Point(0, 0);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(279, 36);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Добавить данные книги";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(557, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(279, 36);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Удалить данные книги";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(0, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(836, 36);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Изменить данные";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToDeleteRows = false;
            this.dgvBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBook.BackgroundColor = System.Drawing.Color.White;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBook.Location = new System.Drawing.Point(272, 48);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            this.dgvBook.RowTemplate.Height = 24;
            this.dgvBook.Size = new System.Drawing.Size(836, 434);
            this.dgvBook.TabIndex = 17;
            this.dgvBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellClick);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1108, 554);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.pnManipulationButtons);
            this.Controls.Add(this.gbManipulationData);
            this.Controls.Add(this.pnCancel);
            this.Controls.Add(this.gbSearchAndFiltration);
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Книги";
            this.Load += new System.EventHandler(this.BookForm_Load);
            this.gbSearchAndFiltration.ResumeLayout(false);
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.pnFiltration.ResumeLayout(false);
            this.pnFiltration.PerformLayout();
            this.pnCancel.ResumeLayout(false);
            this.gbManipulationData.ResumeLayout(false);
            this.pnComboBox.ResumeLayout(false);
            this.pnComboBox.PerformLayout();
            this.pnUpdateButtons.ResumeLayout(false);
            this.pnTextBox.ResumeLayout(false);
            this.pnTextBox.PerformLayout();
            this.pnManipulationButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearchAndFiltration;
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Panel pnFiltration;
        private System.Windows.Forms.CheckBox chbFiltration;
        private System.Windows.Forms.Panel pnCancel;
        private System.Windows.Forms.Button btnError;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbWriter;
        private System.Windows.Forms.ComboBox cbPublishing;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.TextBox tbNumberPages;
        private System.Windows.Forms.TextBox tbBookTitle;
        private System.Windows.Forms.TextBox tbDatePublication;
        private System.Windows.Forms.GroupBox gbManipulationData;
        private System.Windows.Forms.Panel pnManipulationButtons;
        private System.Windows.Forms.Panel pnComboBox;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.Label lbPublishing;
        private System.Windows.Forms.Label lbWriter;
        private System.Windows.Forms.TextBox tbDateRegistration;
        private System.Windows.Forms.Label lbDateRegisration;
        private System.Windows.Forms.TextBox tbAvailableCopies;
        private System.Windows.Forms.Label lbAvailableCopies;
        private System.Windows.Forms.TextBox tbTotalCopies;
        private System.Windows.Forms.Label lbTotalCopies;
        private System.Windows.Forms.TextBox tbCostBook;
        private System.Windows.Forms.Label lbCostBook;
        private System.Windows.Forms.TextBox tbISBN;
        private System.Windows.Forms.Label lbISBN;
        private System.Windows.Forms.Label lbNumberPages;
        private System.Windows.Forms.Label lbDatePublication;
        private System.Windows.Forms.Label lbBookTitle;
        private System.Windows.Forms.Panel pnUpdateButtons;
        private System.Windows.Forms.Panel pnTextBox;
        private System.Windows.Forms.DataGridView dgvBook;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnInsert;
        public System.Windows.Forms.Button btnUpdateGenre;
        public System.Windows.Forms.Button btnUpdatePublishing;
        public System.Windows.Forms.Button btnUpdateWriter;
    }
}