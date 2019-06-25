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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
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
            resources.ApplyResources(this.gbSearchAndFiltration, "gbSearchAndFiltration");
            this.gbSearchAndFiltration.Controls.Add(this.pnSearch);
            this.gbSearchAndFiltration.Controls.Add(this.pnFiltration);
            this.gbSearchAndFiltration.Name = "gbSearchAndFiltration";
            this.gbSearchAndFiltration.TabStop = false;
            // 
            // pnSearch
            // 
            resources.ApplyResources(this.pnSearch, "pnSearch");
            this.pnSearch.Controls.Add(this.tbSearch);
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
            resources.ApplyResources(this.pnFiltration, "pnFiltration");
            this.pnFiltration.Controls.Add(this.chbFiltration);
            this.pnFiltration.Name = "pnFiltration";
            // 
            // chbFiltration
            // 
            resources.ApplyResources(this.chbFiltration, "chbFiltration");
            this.chbFiltration.Name = "chbFiltration";
            this.chbFiltration.UseVisualStyleBackColor = true;
            this.chbFiltration.CheckedChanged += new System.EventHandler(this.chbFiltration_CheckedChanged);
            // 
            // pnCancel
            // 
            resources.ApplyResources(this.pnCancel, "pnCancel");
            this.pnCancel.Controls.Add(this.btnError);
            this.pnCancel.Controls.Add(this.btnExit);
            this.pnCancel.Name = "pnCancel";
            // 
            // btnError
            // 
            resources.ApplyResources(this.btnError, "btnError");
            this.btnError.Name = "btnError";
            this.btnError.UseVisualStyleBackColor = true;
            this.btnError.Click += new System.EventHandler(this.btnError_Click);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbWriter
            // 
            resources.ApplyResources(this.cbWriter, "cbWriter");
            this.cbWriter.FormattingEnabled = true;
            this.cbWriter.Name = "cbWriter";
            // 
            // cbPublishing
            // 
            resources.ApplyResources(this.cbPublishing, "cbPublishing");
            this.cbPublishing.FormattingEnabled = true;
            this.cbPublishing.Name = "cbPublishing";
            // 
            // cbGenre
            // 
            resources.ApplyResources(this.cbGenre, "cbGenre");
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Name = "cbGenre";
            // 
            // tbNumberPages
            // 
            resources.ApplyResources(this.tbNumberPages, "tbNumberPages");
            this.tbNumberPages.Name = "tbNumberPages";
            // 
            // tbBookTitle
            // 
            resources.ApplyResources(this.tbBookTitle, "tbBookTitle");
            this.tbBookTitle.Name = "tbBookTitle";
            // 
            // tbDatePublication
            // 
            resources.ApplyResources(this.tbDatePublication, "tbDatePublication");
            this.tbDatePublication.Name = "tbDatePublication";
            // 
            // gbManipulationData
            // 
            resources.ApplyResources(this.gbManipulationData, "gbManipulationData");
            this.gbManipulationData.Controls.Add(this.pnComboBox);
            this.gbManipulationData.Controls.Add(this.pnTextBox);
            this.gbManipulationData.Name = "gbManipulationData";
            this.gbManipulationData.TabStop = false;
            // 
            // pnComboBox
            // 
            resources.ApplyResources(this.pnComboBox, "pnComboBox");
            this.pnComboBox.Controls.Add(this.pnUpdateButtons);
            this.pnComboBox.Controls.Add(this.cbGenre);
            this.pnComboBox.Controls.Add(this.lbGenre);
            this.pnComboBox.Controls.Add(this.cbPublishing);
            this.pnComboBox.Controls.Add(this.lbPublishing);
            this.pnComboBox.Controls.Add(this.cbWriter);
            this.pnComboBox.Controls.Add(this.lbWriter);
            this.pnComboBox.Name = "pnComboBox";
            // 
            // pnUpdateButtons
            // 
            resources.ApplyResources(this.pnUpdateButtons, "pnUpdateButtons");
            this.pnUpdateButtons.Controls.Add(this.btnUpdateGenre);
            this.pnUpdateButtons.Controls.Add(this.btnUpdatePublishing);
            this.pnUpdateButtons.Controls.Add(this.btnUpdateWriter);
            this.pnUpdateButtons.Name = "pnUpdateButtons";
            // 
            // btnUpdateGenre
            // 
            resources.ApplyResources(this.btnUpdateGenre, "btnUpdateGenre");
            this.btnUpdateGenre.Name = "btnUpdateGenre";
            this.btnUpdateGenre.UseVisualStyleBackColor = true;
            this.btnUpdateGenre.Click += new System.EventHandler(this.btnUpdateGenre_Click);
            // 
            // btnUpdatePublishing
            // 
            resources.ApplyResources(this.btnUpdatePublishing, "btnUpdatePublishing");
            this.btnUpdatePublishing.Name = "btnUpdatePublishing";
            this.btnUpdatePublishing.UseVisualStyleBackColor = true;
            this.btnUpdatePublishing.Click += new System.EventHandler(this.btnUpdatePublishing_Click);
            // 
            // btnUpdateWriter
            // 
            resources.ApplyResources(this.btnUpdateWriter, "btnUpdateWriter");
            this.btnUpdateWriter.Name = "btnUpdateWriter";
            this.btnUpdateWriter.UseVisualStyleBackColor = true;
            this.btnUpdateWriter.Click += new System.EventHandler(this.btnUpdateWriter_Click);
            // 
            // lbGenre
            // 
            resources.ApplyResources(this.lbGenre, "lbGenre");
            this.lbGenre.Name = "lbGenre";
            // 
            // lbPublishing
            // 
            resources.ApplyResources(this.lbPublishing, "lbPublishing");
            this.lbPublishing.Name = "lbPublishing";
            // 
            // lbWriter
            // 
            resources.ApplyResources(this.lbWriter, "lbWriter");
            this.lbWriter.Name = "lbWriter";
            // 
            // pnTextBox
            // 
            resources.ApplyResources(this.pnTextBox, "pnTextBox");
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
            this.pnTextBox.Name = "pnTextBox";
            // 
            // tbDateRegistration
            // 
            resources.ApplyResources(this.tbDateRegistration, "tbDateRegistration");
            this.tbDateRegistration.BackColor = System.Drawing.SystemColors.Control;
            this.tbDateRegistration.Name = "tbDateRegistration";
            this.tbDateRegistration.ReadOnly = true;
            // 
            // lbDateRegisration
            // 
            resources.ApplyResources(this.lbDateRegisration, "lbDateRegisration");
            this.lbDateRegisration.Name = "lbDateRegisration";
            // 
            // tbAvailableCopies
            // 
            resources.ApplyResources(this.tbAvailableCopies, "tbAvailableCopies");
            this.tbAvailableCopies.Name = "tbAvailableCopies";
            this.tbAvailableCopies.ReadOnly = true;
            // 
            // lbAvailableCopies
            // 
            resources.ApplyResources(this.lbAvailableCopies, "lbAvailableCopies");
            this.lbAvailableCopies.Name = "lbAvailableCopies";
            // 
            // tbTotalCopies
            // 
            resources.ApplyResources(this.tbTotalCopies, "tbTotalCopies");
            this.tbTotalCopies.Name = "tbTotalCopies";
            // 
            // lbTotalCopies
            // 
            resources.ApplyResources(this.lbTotalCopies, "lbTotalCopies");
            this.lbTotalCopies.Name = "lbTotalCopies";
            // 
            // tbCostBook
            // 
            resources.ApplyResources(this.tbCostBook, "tbCostBook");
            this.tbCostBook.Name = "tbCostBook";
            // 
            // lbCostBook
            // 
            resources.ApplyResources(this.lbCostBook, "lbCostBook");
            this.lbCostBook.Name = "lbCostBook";
            // 
            // tbISBN
            // 
            resources.ApplyResources(this.tbISBN, "tbISBN");
            this.tbISBN.Name = "tbISBN";
            // 
            // lbISBN
            // 
            resources.ApplyResources(this.lbISBN, "lbISBN");
            this.lbISBN.Name = "lbISBN";
            // 
            // lbNumberPages
            // 
            resources.ApplyResources(this.lbNumberPages, "lbNumberPages");
            this.lbNumberPages.Name = "lbNumberPages";
            // 
            // lbDatePublication
            // 
            resources.ApplyResources(this.lbDatePublication, "lbDatePublication");
            this.lbDatePublication.Name = "lbDatePublication";
            // 
            // lbBookTitle
            // 
            resources.ApplyResources(this.lbBookTitle, "lbBookTitle");
            this.lbBookTitle.Name = "lbBookTitle";
            // 
            // pnManipulationButtons
            // 
            resources.ApplyResources(this.pnManipulationButtons, "pnManipulationButtons");
            this.pnManipulationButtons.Controls.Add(this.btnInsert);
            this.pnManipulationButtons.Controls.Add(this.btnDelete);
            this.pnManipulationButtons.Controls.Add(this.btnUpdate);
            this.pnManipulationButtons.Name = "pnManipulationButtons";
            // 
            // btnInsert
            // 
            resources.ApplyResources(this.btnInsert, "btnInsert");
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
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
            // dgvBook
            // 
            resources.ApplyResources(this.dgvBook, "dgvBook");
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToDeleteRows = false;
            this.dgvBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBook.BackgroundColor = System.Drawing.Color.White;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            this.dgvBook.RowTemplate.Height = 24;
            this.dgvBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellClick);
            // 
            // BookForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.pnManipulationButtons);
            this.Controls.Add(this.gbManipulationData);
            this.Controls.Add(this.pnCancel);
            this.Controls.Add(this.gbSearchAndFiltration);
            this.Name = "BookForm";
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