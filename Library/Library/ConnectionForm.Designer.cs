namespace Library
{
    partial class ConnectionForm
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
            this.lbAddressServer = new System.Windows.Forms.Label();
            this.lbNameServer = new System.Windows.Forms.Label();
            this.lbUserServer = new System.Windows.Forms.Label();
            this.lbPasswordServer = new System.Windows.Forms.Label();
            this.lbListDataBase = new System.Windows.Forms.Label();
            this.cbAddressServer = new System.Windows.Forms.ComboBox();
            this.cbNameServer = new System.Windows.Forms.ComboBox();
            this.cbListDataBase = new System.Windows.Forms.ComboBox();
            this.tbUserServer = new System.Windows.Forms.TextBox();
            this.tbPasswordServer = new System.Windows.Forms.TextBox();
            this.sstStatusConnection = new System.Windows.Forms.StatusStrip();
            this.lbsstStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.sstStatusConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAddressServer
            // 
            this.lbAddressServer.AutoSize = true;
            this.lbAddressServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbAddressServer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAddressServer.Location = new System.Drawing.Point(0, 0);
            this.lbAddressServer.Name = "lbAddressServer";
            this.lbAddressServer.Size = new System.Drawing.Size(114, 17);
            this.lbAddressServer.TabIndex = 0;
            this.lbAddressServer.Text = "Адрес сервера:";
            // 
            // lbNameServer
            // 
            this.lbNameServer.AutoSize = true;
            this.lbNameServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbNameServer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNameServer.Location = new System.Drawing.Point(0, 41);
            this.lbNameServer.Name = "lbNameServer";
            this.lbNameServer.Size = new System.Drawing.Size(137, 17);
            this.lbNameServer.TabIndex = 1;
            this.lbNameServer.Text = "Название сервера:";
            // 
            // lbUserServer
            // 
            this.lbUserServer.AutoSize = true;
            this.lbUserServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbUserServer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUserServer.Location = new System.Drawing.Point(0, 82);
            this.lbUserServer.Name = "lbUserServer";
            this.lbUserServer.Size = new System.Drawing.Size(168, 17);
            this.lbUserServer.TabIndex = 2;
            this.lbUserServer.Text = "Пользователь сервера:";
            // 
            // lbPasswordServer
            // 
            this.lbPasswordServer.AutoSize = true;
            this.lbPasswordServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPasswordServer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPasswordServer.Location = new System.Drawing.Point(0, 121);
            this.lbPasswordServer.Name = "lbPasswordServer";
            this.lbPasswordServer.Size = new System.Drawing.Size(160, 17);
            this.lbPasswordServer.TabIndex = 3;
            this.lbPasswordServer.Text = "Пароль пользователя:";
            // 
            // lbListDataBase
            // 
            this.lbListDataBase.AutoSize = true;
            this.lbListDataBase.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbListDataBase.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbListDataBase.Location = new System.Drawing.Point(0, 160);
            this.lbListDataBase.Name = "lbListDataBase";
            this.lbListDataBase.Size = new System.Drawing.Size(145, 17);
            this.lbListDataBase.TabIndex = 4;
            this.lbListDataBase.Text = "Список баз данных:";
            // 
            // cbAddressServer
            // 
            this.cbAddressServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbAddressServer.Enabled = false;
            this.cbAddressServer.FormattingEnabled = true;
            this.cbAddressServer.Location = new System.Drawing.Point(0, 17);
            this.cbAddressServer.Name = "cbAddressServer";
            this.cbAddressServer.Size = new System.Drawing.Size(385, 24);
            this.cbAddressServer.TabIndex = 5;
            // 
            // cbNameServer
            // 
            this.cbNameServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbNameServer.Enabled = false;
            this.cbNameServer.FormattingEnabled = true;
            this.cbNameServer.Location = new System.Drawing.Point(0, 58);
            this.cbNameServer.Name = "cbNameServer";
            this.cbNameServer.Size = new System.Drawing.Size(385, 24);
            this.cbNameServer.TabIndex = 6;
            // 
            // cbListDataBase
            // 
            this.cbListDataBase.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbListDataBase.Enabled = false;
            this.cbListDataBase.FormattingEnabled = true;
            this.cbListDataBase.Location = new System.Drawing.Point(0, 177);
            this.cbListDataBase.Name = "cbListDataBase";
            this.cbListDataBase.Size = new System.Drawing.Size(385, 24);
            this.cbListDataBase.TabIndex = 7;
            // 
            // tbUserServer
            // 
            this.tbUserServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbUserServer.Enabled = false;
            this.tbUserServer.Location = new System.Drawing.Point(0, 99);
            this.tbUserServer.Name = "tbUserServer";
            this.tbUserServer.PasswordChar = '*';
            this.tbUserServer.Size = new System.Drawing.Size(385, 22);
            this.tbUserServer.TabIndex = 8;
            // 
            // tbPasswordServer
            // 
            this.tbPasswordServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPasswordServer.Enabled = false;
            this.tbPasswordServer.Location = new System.Drawing.Point(0, 138);
            this.tbPasswordServer.Name = "tbPasswordServer";
            this.tbPasswordServer.PasswordChar = '*';
            this.tbPasswordServer.Size = new System.Drawing.Size(385, 22);
            this.tbPasswordServer.TabIndex = 9;
            // 
            // sstStatusConnection
            // 
            this.sstStatusConnection.Dock = System.Windows.Forms.DockStyle.Top;
            this.sstStatusConnection.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sstStatusConnection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbsstStatus});
            this.sstStatusConnection.Location = new System.Drawing.Point(0, 297);
            this.sstStatusConnection.Name = "sstStatusConnection";
            this.sstStatusConnection.Size = new System.Drawing.Size(385, 22);
            this.sstStatusConnection.TabIndex = 10;
            this.sstStatusConnection.Text = "statusStrip1";
            // 
            // lbsstStatus
            // 
            this.lbsstStatus.Font = new System.Drawing.Font("Arial", 9F);
            this.lbsstStatus.Name = "lbsstStatus";
            this.lbsstStatus.Size = new System.Drawing.Size(13, 17);
            this.lbsstStatus.Text = "-";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Transparent;
            this.btnCheck.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCheck.Enabled = false;
            this.btnCheck.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCheck.Location = new System.Drawing.Point(0, 201);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(385, 32);
            this.btnCheck.TabIndex = 11;
            this.btnCheck.Text = "Проверить";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConnect.Enabled = false;
            this.btnConnect.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConnect.Location = new System.Drawing.Point(0, 233);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(385, 32);
            this.btnConnect.TabIndex = 12;
            this.btnConnect.Text = "Подключить";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(0, 265);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(385, 32);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(385, 343);
            this.Controls.Add(this.sstStatusConnection);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.cbListDataBase);
            this.Controls.Add(this.lbListDataBase);
            this.Controls.Add(this.tbPasswordServer);
            this.Controls.Add(this.lbPasswordServer);
            this.Controls.Add(this.tbUserServer);
            this.Controls.Add(this.lbUserServer);
            this.Controls.Add(this.cbNameServer);
            this.Controls.Add(this.lbNameServer);
            this.Controls.Add(this.cbAddressServer);
            this.Controls.Add(this.lbAddressServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ConnectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подключение к БД";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConnectionForm_FormClosing);
            this.Load += new System.EventHandler(this.ConnectionForm_Load);
            this.sstStatusConnection.ResumeLayout(false);
            this.sstStatusConnection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAddressServer;
        private System.Windows.Forms.Label lbNameServer;
        private System.Windows.Forms.Label lbUserServer;
        private System.Windows.Forms.Label lbPasswordServer;
        private System.Windows.Forms.Label lbListDataBase;
        private System.Windows.Forms.ComboBox cbAddressServer;
        private System.Windows.Forms.ComboBox cbNameServer;
        private System.Windows.Forms.ComboBox cbListDataBase;
        private System.Windows.Forms.TextBox tbUserServer;
        private System.Windows.Forms.TextBox tbPasswordServer;
        private System.Windows.Forms.StatusStrip sstStatusConnection;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolStripStatusLabel lbsstStatus;
    }
}