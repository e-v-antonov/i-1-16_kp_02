namespace Library
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.miSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.miExitProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.miSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.miExitSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.miIssueBook = new System.Windows.Forms.ToolStripMenuItem();
            this.miReturnBook = new System.Windows.Forms.ToolStripMenuItem();
            this.miHandbook = new System.Windows.Forms.ToolStripMenuItem();
            this.miFormulars = new System.Windows.Forms.ToolStripMenuItem();
            this.miRegistrationCardReader = new System.Windows.Forms.ToolStripMenuItem();
            this.miBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.miWriterBook = new System.Windows.Forms.ToolStripMenuItem();
            this.miPublishingBook = new System.Windows.Forms.ToolStripMenuItem();
            this.miGenreBook = new System.Windows.Forms.ToolStripMenuItem();
            this.miUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.miInformationSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.miDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.miCreatedRegistrationCardAndFormular = new System.Windows.Forms.ToolStripMenuItem();
            this.miCreateActs = new System.Windows.Forms.ToolStripMenuItem();
            this.miCreateInventoryBook = new System.Windows.Forms.ToolStripMenuItem();
            this.miCreateSummaryBook = new System.Windows.Forms.ToolStripMenuItem();
            this.sstInformation = new System.Windows.Forms.StatusStrip();
            this.lbsstDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbsstConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.sstInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSystem,
            this.miIssueBook,
            this.miReturnBook,
            this.miHandbook,
            this.miInformationSystem,
            this.miDocument});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 28);
            this.menuStrip.TabIndex = 0;
            // 
            // miSystem
            // 
            this.miSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miExitProfile,
            this.miSettings,
            this.miExitSystem});
            this.miSystem.Font = new System.Drawing.Font("Arial", 9F);
            this.miSystem.Name = "miSystem";
            this.miSystem.Size = new System.Drawing.Size(80, 24);
            this.miSystem.Text = "Система";
            // 
            // miExitProfile
            // 
            this.miExitProfile.Enabled = false;
            this.miExitProfile.Name = "miExitProfile";
            this.miExitProfile.Size = new System.Drawing.Size(394, 26);
            this.miExitProfile.Text = "Выход из профиля";
            this.miExitProfile.Click += new System.EventHandler(this.miExitProfile_Click);
            // 
            // miSettings
            // 
            this.miSettings.Enabled = false;
            this.miSettings.Name = "miSettings";
            this.miSettings.Size = new System.Drawing.Size(394, 26);
            this.miSettings.Text = "Настройки";
            this.miSettings.Click += new System.EventHandler(this.miSettings_Click);
            // 
            // miExitSystem
            // 
            this.miExitSystem.Name = "miExitSystem";
            this.miExitSystem.Size = new System.Drawing.Size(394, 26);
            this.miExitSystem.Text = "Завершить работу информационной системы";
            this.miExitSystem.Click += new System.EventHandler(this.miExitSystem_Click);
            // 
            // miIssueBook
            // 
            this.miIssueBook.Enabled = false;
            this.miIssueBook.Name = "miIssueBook";
            this.miIssueBook.Size = new System.Drawing.Size(117, 24);
            this.miIssueBook.Text = "Выдача книги";
            this.miIssueBook.Click += new System.EventHandler(this.miIssueBook_Click);
            // 
            // miReturnBook
            // 
            this.miReturnBook.Enabled = false;
            this.miReturnBook.Name = "miReturnBook";
            this.miReturnBook.Size = new System.Drawing.Size(121, 24);
            this.miReturnBook.Text = "Возврат книги";
            this.miReturnBook.Click += new System.EventHandler(this.miReturnBook_Click);
            // 
            // miHandbook
            // 
            this.miHandbook.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFormulars,
            this.miRegistrationCardReader,
            this.miBooks,
            this.miWriterBook,
            this.miPublishingBook,
            this.miGenreBook,
            this.miUsers});
            this.miHandbook.Font = new System.Drawing.Font("Arial", 9F);
            this.miHandbook.Name = "miHandbook";
            this.miHandbook.Size = new System.Drawing.Size(110, 24);
            this.miHandbook.Text = "Справочники";
            // 
            // miFormulars
            // 
            this.miFormulars.Name = "miFormulars";
            this.miFormulars.Size = new System.Drawing.Size(280, 26);
            this.miFormulars.Text = "Формуляры...";
            this.miFormulars.Click += new System.EventHandler(this.miFormulars_Click);
            // 
            // miRegistrationCardReader
            // 
            this.miRegistrationCardReader.Name = "miRegistrationCardReader";
            this.miRegistrationCardReader.Size = new System.Drawing.Size(280, 26);
            this.miRegistrationCardReader.Text = "Регистрационные карточки...";
            this.miRegistrationCardReader.Click += new System.EventHandler(this.miRegistrationCardReader_Click);
            // 
            // miBooks
            // 
            this.miBooks.Name = "miBooks";
            this.miBooks.Size = new System.Drawing.Size(280, 26);
            this.miBooks.Text = "Книги...";
            this.miBooks.Click += new System.EventHandler(this.miBooks_Click);
            // 
            // miWriterBook
            // 
            this.miWriterBook.Name = "miWriterBook";
            this.miWriterBook.Size = new System.Drawing.Size(280, 26);
            this.miWriterBook.Text = "Авторы...";
            this.miWriterBook.Click += new System.EventHandler(this.авторыToolStripMenuItem_Click);
            // 
            // miPublishingBook
            // 
            this.miPublishingBook.Name = "miPublishingBook";
            this.miPublishingBook.Size = new System.Drawing.Size(280, 26);
            this.miPublishingBook.Text = "Книжные издательства...";
            this.miPublishingBook.Click += new System.EventHandler(this.miPublishingBook_Click);
            // 
            // miGenreBook
            // 
            this.miGenreBook.Name = "miGenreBook";
            this.miGenreBook.Size = new System.Drawing.Size(280, 26);
            this.miGenreBook.Text = "Жанры книг...";
            this.miGenreBook.Click += new System.EventHandler(this.miGenreBook_Click);
            // 
            // miUsers
            // 
            this.miUsers.Name = "miUsers";
            this.miUsers.Size = new System.Drawing.Size(280, 26);
            this.miUsers.Text = "Пользователи...";
            this.miUsers.Click += new System.EventHandler(this.miUsers_Click);
            // 
            // miInformationSystem
            // 
            this.miInformationSystem.Font = new System.Drawing.Font("Arial", 9F);
            this.miInformationSystem.Name = "miInformationSystem";
            this.miInformationSystem.Size = new System.Drawing.Size(88, 24);
            this.miInformationSystem.Text = "Сведения";
            // 
            // miDocument
            // 
            this.miDocument.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCreatedRegistrationCardAndFormular,
            this.miCreateActs,
            this.miCreateInventoryBook,
            this.miCreateSummaryBook});
            this.miDocument.Name = "miDocument";
            this.miDocument.Size = new System.Drawing.Size(207, 24);
            this.miDocument.Text = "Формирование документа";
            // 
            // miCreatedRegistrationCardAndFormular
            // 
            this.miCreatedRegistrationCardAndFormular.Name = "miCreatedRegistrationCardAndFormular";
            this.miCreatedRegistrationCardAndFormular.Size = new System.Drawing.Size(573, 26);
            this.miCreatedRegistrationCardAndFormular.Text = "Формирование регистрационной карточки и формуляра читателя";
            this.miCreatedRegistrationCardAndFormular.Click += new System.EventHandler(this.miCreatedRegistrationCardAndFormular_Click);
            // 
            // miCreateActs
            // 
            this.miCreateActs.Name = "miCreateActs";
            this.miCreateActs.Size = new System.Drawing.Size(573, 26);
            this.miCreateActs.Text = "Формирование актов о приемке и исключении книг";
            this.miCreateActs.Click += new System.EventHandler(this.miCreateActs_Click);
            // 
            // miCreateInventoryBook
            // 
            this.miCreateInventoryBook.Name = "miCreateInventoryBook";
            this.miCreateInventoryBook.Size = new System.Drawing.Size(573, 26);
            this.miCreateInventoryBook.Text = "Сформировать документ \"Инвентарная книга\"";
            this.miCreateInventoryBook.Click += new System.EventHandler(this.miCreateInventoryBook_Click);
            // 
            // miCreateSummaryBook
            // 
            this.miCreateSummaryBook.Name = "miCreateSummaryBook";
            this.miCreateSummaryBook.Size = new System.Drawing.Size(573, 26);
            this.miCreateSummaryBook.Text = "Сформировать документ \"Книга суммарного учета основного фонда\"";
            this.miCreateSummaryBook.Click += new System.EventHandler(this.miCreateSummaryBook_Click);
            // 
            // sstInformation
            // 
            this.sstInformation.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sstInformation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbsstDateTime,
            this.lbsstConnection});
            this.sstInformation.Location = new System.Drawing.Point(0, 425);
            this.sstInformation.Name = "sstInformation";
            this.sstInformation.Size = new System.Drawing.Size(800, 25);
            this.sstInformation.TabIndex = 1;
            this.sstInformation.Text = "statusStrip1";
            // 
            // lbsstDateTime
            // 
            this.lbsstDateTime.Font = new System.Drawing.Font("Arial", 9F);
            this.lbsstDateTime.Name = "lbsstDateTime";
            this.lbsstDateTime.Size = new System.Drawing.Size(140, 20);
            this.lbsstDateTime.Text = "00:00:00/00.00.0000";
            // 
            // lbsstConnection
            // 
            this.lbsstConnection.Name = "lbsstConnection";
            this.lbsstConnection.Size = new System.Drawing.Size(15, 20);
            this.lbsstConnection.Text = "-";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sstInformation);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuForm_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.sstInformation.ResumeLayout(false);
            this.sstInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip sstInformation;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem miSystem;
        private System.Windows.Forms.ToolStripMenuItem miHandbook;
        private System.Windows.Forms.ToolStripMenuItem miInformationSystem;
        private System.Windows.Forms.ToolStripMenuItem miExitProfile;
        private System.Windows.Forms.ToolStripMenuItem miSettings;
        private System.Windows.Forms.ToolStripMenuItem miExitSystem;
        private System.Windows.Forms.ToolStripStatusLabel lbsstDateTime;
        private System.Windows.Forms.ToolStripStatusLabel lbsstConnection;
        private System.Windows.Forms.ToolStripMenuItem miGenreBook;
        private System.Windows.Forms.ToolStripMenuItem miPublishingBook;
        private System.Windows.Forms.ToolStripMenuItem miWriterBook;
        private System.Windows.Forms.ToolStripMenuItem miRegistrationCardReader;
        private System.Windows.Forms.ToolStripMenuItem miBooks;
        private System.Windows.Forms.ToolStripMenuItem miFormulars;
        private System.Windows.Forms.ToolStripMenuItem miDocument;
        private System.Windows.Forms.ToolStripMenuItem miIssueBook;
        private System.Windows.Forms.ToolStripMenuItem miReturnBook;
        private System.Windows.Forms.ToolStripMenuItem miCreatedRegistrationCardAndFormular;
        private System.Windows.Forms.ToolStripMenuItem miCreateActs;
        private System.Windows.Forms.ToolStripMenuItem miCreateInventoryBook;
        private System.Windows.Forms.ToolStripMenuItem miCreateSummaryBook;
        private System.Windows.Forms.ToolStripMenuItem miUsers;
    }
}

