namespace Library
{
    partial class PublishingBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PublishingBookForm));
            this.ltbPublishing = new System.Windows.Forms.ListBox();
            this.gbManipulationData = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.tbPublishing = new System.Windows.Forms.TextBox();
            this.lbNamePublishing = new System.Windows.Forms.Label();
            this.pnCancel = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnError = new System.Windows.Forms.Button();
            this.gbSearchPublishing = new System.Windows.Forms.GroupBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.gbListPublishing = new System.Windows.Forms.GroupBox();
            this.gbManipulationData.SuspendLayout();
            this.pnCancel.SuspendLayout();
            this.gbSearchPublishing.SuspendLayout();
            this.gbListPublishing.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltbPublishing
            // 
            resources.ApplyResources(this.ltbPublishing, "ltbPublishing");
            this.ltbPublishing.FormattingEnabled = true;
            this.ltbPublishing.Name = "ltbPublishing";
            this.ltbPublishing.Click += new System.EventHandler(this.ltbPublishing_Click);
            this.ltbPublishing.SelectedIndexChanged += new System.EventHandler(this.ltbPublishing_SelectedIndexChanged);
            // 
            // gbManipulationData
            // 
            resources.ApplyResources(this.gbManipulationData, "gbManipulationData");
            this.gbManipulationData.Controls.Add(this.btnDelete);
            this.gbManipulationData.Controls.Add(this.btnUpdate);
            this.gbManipulationData.Controls.Add(this.btnInsert);
            this.gbManipulationData.Controls.Add(this.tbPublishing);
            this.gbManipulationData.Controls.Add(this.lbNamePublishing);
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
            // tbPublishing
            // 
            resources.ApplyResources(this.tbPublishing, "tbPublishing");
            this.tbPublishing.Name = "tbPublishing";
            // 
            // lbNamePublishing
            // 
            resources.ApplyResources(this.lbNamePublishing, "lbNamePublishing");
            this.lbNamePublishing.Name = "lbNamePublishing";
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
            // gbSearchPublishing
            // 
            resources.ApplyResources(this.gbSearchPublishing, "gbSearchPublishing");
            this.gbSearchPublishing.Controls.Add(this.tbSearch);
            this.gbSearchPublishing.Name = "gbSearchPublishing";
            this.gbSearchPublishing.TabStop = false;
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
            // gbListPublishing
            // 
            resources.ApplyResources(this.gbListPublishing, "gbListPublishing");
            this.gbListPublishing.Controls.Add(this.ltbPublishing);
            this.gbListPublishing.Name = "gbListPublishing";
            this.gbListPublishing.TabStop = false;
            // 
            // PublishingBookForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbListPublishing);
            this.Controls.Add(this.gbManipulationData);
            this.Controls.Add(this.pnCancel);
            this.Controls.Add(this.gbSearchPublishing);
            this.Name = "PublishingBookForm";
            this.Load += new System.EventHandler(this.PublishingBookForm_Load);
            this.gbManipulationData.ResumeLayout(false);
            this.gbManipulationData.PerformLayout();
            this.pnCancel.ResumeLayout(false);
            this.gbSearchPublishing.ResumeLayout(false);
            this.gbSearchPublishing.PerformLayout();
            this.gbListPublishing.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ltbPublishing;
        private System.Windows.Forms.GroupBox gbManipulationData;
        private System.Windows.Forms.Panel pnCancel;
        private System.Windows.Forms.TextBox tbPublishing;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnError;
        private System.Windows.Forms.Label lbNamePublishing;
        private System.Windows.Forms.GroupBox gbSearchPublishing;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.GroupBox gbListPublishing;
        public System.Windows.Forms.Button btnInsert;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnDelete;
    }
}