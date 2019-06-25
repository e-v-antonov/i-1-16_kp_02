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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionForm));
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
            resources.ApplyResources(this.lbAddressServer, "lbAddressServer");
            this.lbAddressServer.Name = "lbAddressServer";
            // 
            // lbNameServer
            // 
            resources.ApplyResources(this.lbNameServer, "lbNameServer");
            this.lbNameServer.Name = "lbNameServer";
            // 
            // lbUserServer
            // 
            resources.ApplyResources(this.lbUserServer, "lbUserServer");
            this.lbUserServer.Name = "lbUserServer";
            // 
            // lbPasswordServer
            // 
            resources.ApplyResources(this.lbPasswordServer, "lbPasswordServer");
            this.lbPasswordServer.Name = "lbPasswordServer";
            // 
            // lbListDataBase
            // 
            resources.ApplyResources(this.lbListDataBase, "lbListDataBase");
            this.lbListDataBase.Name = "lbListDataBase";
            // 
            // cbAddressServer
            // 
            resources.ApplyResources(this.cbAddressServer, "cbAddressServer");
            this.cbAddressServer.FormattingEnabled = true;
            this.cbAddressServer.Name = "cbAddressServer";
            // 
            // cbNameServer
            // 
            resources.ApplyResources(this.cbNameServer, "cbNameServer");
            this.cbNameServer.FormattingEnabled = true;
            this.cbNameServer.Name = "cbNameServer";
            // 
            // cbListDataBase
            // 
            resources.ApplyResources(this.cbListDataBase, "cbListDataBase");
            this.cbListDataBase.FormattingEnabled = true;
            this.cbListDataBase.Name = "cbListDataBase";
            // 
            // tbUserServer
            // 
            resources.ApplyResources(this.tbUserServer, "tbUserServer");
            this.tbUserServer.Name = "tbUserServer";
            // 
            // tbPasswordServer
            // 
            resources.ApplyResources(this.tbPasswordServer, "tbPasswordServer");
            this.tbPasswordServer.Name = "tbPasswordServer";
            // 
            // sstStatusConnection
            // 
            resources.ApplyResources(this.sstStatusConnection, "sstStatusConnection");
            this.sstStatusConnection.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sstStatusConnection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbsstStatus});
            this.sstStatusConnection.Name = "sstStatusConnection";
            // 
            // lbsstStatus
            // 
            resources.ApplyResources(this.lbsstStatus, "lbsstStatus");
            this.lbsstStatus.Name = "lbsstStatus";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnCheck, "btnCheck");
            this.btnCheck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnConnect
            // 
            resources.ApplyResources(this.btnConnect, "btnConnect");
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ConnectionForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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