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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.miSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.miAuthorization = new System.Windows.Forms.ToolStripMenuItem();
            this.miSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.miSettingApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.miSettingConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.miExitProfile = new System.Windows.Forms.ToolStripMenuItem();
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
            this.miDocument});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // miSystem
            // 
            this.miSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAuthorization,
            this.miSettings,
            this.miExitProfile,
            this.miExitSystem});
            resources.ApplyResources(this.miSystem, "miSystem");
            this.miSystem.Name = "miSystem";
            // 
            // miAuthorization
            // 
            this.miAuthorization.Name = "miAuthorization";
            resources.ApplyResources(this.miAuthorization, "miAuthorization");
            this.miAuthorization.Click += new System.EventHandler(this.miAuthorization_Click);
            // 
            // miSettings
            // 
            this.miSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSettingApplication,
            this.miSettingConnection});
            resources.ApplyResources(this.miSettings, "miSettings");
            this.miSettings.Name = "miSettings";
            // 
            // miSettingApplication
            // 
            resources.ApplyResources(this.miSettingApplication, "miSettingApplication");
            this.miSettingApplication.Name = "miSettingApplication";
            this.miSettingApplication.Click += new System.EventHandler(this.miSettingApplication_Click);
            // 
            // miSettingConnection
            // 
            resources.ApplyResources(this.miSettingConnection, "miSettingConnection");
            this.miSettingConnection.Name = "miSettingConnection";
            this.miSettingConnection.Click += new System.EventHandler(this.miSettingConnection_Click);
            // 
            // miExitProfile
            // 
            resources.ApplyResources(this.miExitProfile, "miExitProfile");
            this.miExitProfile.Name = "miExitProfile";
            this.miExitProfile.Click += new System.EventHandler(this.miExitProfile_Click);
            // 
            // miExitSystem
            // 
            this.miExitSystem.Name = "miExitSystem";
            resources.ApplyResources(this.miExitSystem, "miExitSystem");
            this.miExitSystem.Click += new System.EventHandler(this.miExitSystem_Click);
            // 
            // miIssueBook
            // 
            resources.ApplyResources(this.miIssueBook, "miIssueBook");
            this.miIssueBook.Name = "miIssueBook";
            this.miIssueBook.Click += new System.EventHandler(this.miIssueBook_Click);
            // 
            // miReturnBook
            // 
            resources.ApplyResources(this.miReturnBook, "miReturnBook");
            this.miReturnBook.Name = "miReturnBook";
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
            resources.ApplyResources(this.miHandbook, "miHandbook");
            this.miHandbook.Name = "miHandbook";
            // 
            // miFormulars
            // 
            resources.ApplyResources(this.miFormulars, "miFormulars");
            this.miFormulars.Name = "miFormulars";
            this.miFormulars.Click += new System.EventHandler(this.miFormulars_Click);
            // 
            // miRegistrationCardReader
            // 
            resources.ApplyResources(this.miRegistrationCardReader, "miRegistrationCardReader");
            this.miRegistrationCardReader.Name = "miRegistrationCardReader";
            this.miRegistrationCardReader.Click += new System.EventHandler(this.miRegistrationCardReader_Click);
            // 
            // miBooks
            // 
            resources.ApplyResources(this.miBooks, "miBooks");
            this.miBooks.Name = "miBooks";
            this.miBooks.Click += new System.EventHandler(this.miBooks_Click);
            // 
            // miWriterBook
            // 
            resources.ApplyResources(this.miWriterBook, "miWriterBook");
            this.miWriterBook.Name = "miWriterBook";
            this.miWriterBook.Click += new System.EventHandler(this.miWriterBook_Click);
            // 
            // miPublishingBook
            // 
            resources.ApplyResources(this.miPublishingBook, "miPublishingBook");
            this.miPublishingBook.Name = "miPublishingBook";
            this.miPublishingBook.Click += new System.EventHandler(this.miPublishingBook_Click);
            // 
            // miGenreBook
            // 
            resources.ApplyResources(this.miGenreBook, "miGenreBook");
            this.miGenreBook.Name = "miGenreBook";
            this.miGenreBook.Click += new System.EventHandler(this.miGenreBook_Click);
            // 
            // miUsers
            // 
            resources.ApplyResources(this.miUsers, "miUsers");
            this.miUsers.Name = "miUsers";
            this.miUsers.Click += new System.EventHandler(this.miUsers_Click);
            // 
            // miDocument
            // 
            this.miDocument.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCreatedRegistrationCardAndFormular,
            this.miCreateActs,
            this.miCreateInventoryBook,
            this.miCreateSummaryBook});
            resources.ApplyResources(this.miDocument, "miDocument");
            this.miDocument.Name = "miDocument";
            // 
            // miCreatedRegistrationCardAndFormular
            // 
            resources.ApplyResources(this.miCreatedRegistrationCardAndFormular, "miCreatedRegistrationCardAndFormular");
            this.miCreatedRegistrationCardAndFormular.Name = "miCreatedRegistrationCardAndFormular";
            this.miCreatedRegistrationCardAndFormular.Click += new System.EventHandler(this.miCreatedRegistrationCardAndFormular_Click);
            // 
            // miCreateActs
            // 
            resources.ApplyResources(this.miCreateActs, "miCreateActs");
            this.miCreateActs.Name = "miCreateActs";
            this.miCreateActs.Click += new System.EventHandler(this.miCreateActs_Click);
            // 
            // miCreateInventoryBook
            // 
            resources.ApplyResources(this.miCreateInventoryBook, "miCreateInventoryBook");
            this.miCreateInventoryBook.Name = "miCreateInventoryBook";
            this.miCreateInventoryBook.Click += new System.EventHandler(this.miCreateInventoryBook_Click);
            // 
            // miCreateSummaryBook
            // 
            resources.ApplyResources(this.miCreateSummaryBook, "miCreateSummaryBook");
            this.miCreateSummaryBook.Name = "miCreateSummaryBook";
            this.miCreateSummaryBook.Click += new System.EventHandler(this.miCreateSummaryBook_Click);
            // 
            // sstInformation
            // 
            this.sstInformation.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sstInformation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbsstDateTime,
            this.lbsstConnection});
            resources.ApplyResources(this.sstInformation, "sstInformation");
            this.sstInformation.Name = "sstInformation";
            // 
            // lbsstDateTime
            // 
            resources.ApplyResources(this.lbsstDateTime, "lbsstDateTime");
            this.lbsstDateTime.Name = "lbsstDateTime";
            // 
            // lbsstConnection
            // 
            this.lbsstConnection.Name = "lbsstConnection";
            resources.ApplyResources(this.lbsstConnection, "lbsstConnection");
            // 
            // timer
            // 
            this.timer.Enabled = true;
            // 
            // MainMenuForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.sstInformation);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainMenuForm";
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
        private System.Windows.Forms.ToolStripMenuItem miAuthorization;
        private System.Windows.Forms.ToolStripMenuItem miSettingApplication;
        private System.Windows.Forms.ToolStripMenuItem miSettingConnection;
    }
}

