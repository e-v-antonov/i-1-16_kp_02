﻿namespace Library
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
            this.miHandbook = new System.Windows.Forms.ToolStripMenuItem();
            this.miInformationSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.sstInformation = new System.Windows.Forms.StatusStrip();
            this.lbsstDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbsstConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.miGenreBook = new System.Windows.Forms.ToolStripMenuItem();
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
            this.miHandbook,
            this.miInformationSystem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
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
            this.miExitProfile.Name = "miExitProfile";
            this.miExitProfile.Size = new System.Drawing.Size(394, 26);
            this.miExitProfile.Text = "Выход из профиля";
            // 
            // miSettings
            // 
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
            // 
            // miHandbook
            // 
            this.miHandbook.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miGenreBook});
            this.miHandbook.Font = new System.Drawing.Font("Arial", 9F);
            this.miHandbook.Name = "miHandbook";
            this.miHandbook.Size = new System.Drawing.Size(110, 24);
            this.miHandbook.Text = "Справочники";
            // 
            // miInformationSystem
            // 
            this.miInformationSystem.Font = new System.Drawing.Font("Arial", 9F);
            this.miInformationSystem.Name = "miInformationSystem";
            this.miInformationSystem.Size = new System.Drawing.Size(88, 24);
            this.miInformationSystem.Text = "Сведения";
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
            // miGenreBook
            // 
            this.miGenreBook.Name = "miGenreBook";
            this.miGenreBook.Size = new System.Drawing.Size(216, 26);
            this.miGenreBook.Text = "Жанры книг...";
            this.miGenreBook.Click += new System.EventHandler(this.miGenreBook_Click);
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
    }
}
