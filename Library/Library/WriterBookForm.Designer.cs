namespace Library
{
    partial class WriterBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WriterBookForm));
            this.pnCancel = new System.Windows.Forms.Panel();
            this.btnError = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbManipulationData = new System.Windows.Forms.GroupBox();
            this.pnName = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbNameWriter = new System.Windows.Forms.TextBox();
            this.lbNameWriter = new System.Windows.Forms.Label();
            this.pnPatronymic = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbPatronymicWriter = new System.Windows.Forms.TextBox();
            this.lbPatronymicWriter = new System.Windows.Forms.Label();
            this.pnSurname = new System.Windows.Forms.Panel();
            this.btnInsert = new System.Windows.Forms.Button();
            this.tbSurnameWriter = new System.Windows.Forms.TextBox();
            this.lbSurnameWriter = new System.Windows.Forms.Label();
            this.gbSearchAndFiltration = new System.Windows.Forms.GroupBox();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.pnFiltration = new System.Windows.Forms.Panel();
            this.chbFiltration = new System.Windows.Forms.CheckBox();
            this.dgvWriterBook = new System.Windows.Forms.DataGridView();
            this.pnCancel.SuspendLayout();
            this.gbManipulationData.SuspendLayout();
            this.pnName.SuspendLayout();
            this.pnPatronymic.SuspendLayout();
            this.pnSurname.SuspendLayout();
            this.gbSearchAndFiltration.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.pnFiltration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWriterBook)).BeginInit();
            this.SuspendLayout();
            // 
            // pnCancel
            // 
            this.pnCancel.Controls.Add(this.btnError);
            this.pnCancel.Controls.Add(this.btnExit);
            resources.ApplyResources(this.pnCancel, "pnCancel");
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
            // gbManipulationData
            // 
            this.gbManipulationData.Controls.Add(this.pnName);
            this.gbManipulationData.Controls.Add(this.pnPatronymic);
            this.gbManipulationData.Controls.Add(this.pnSurname);
            resources.ApplyResources(this.gbManipulationData, "gbManipulationData");
            this.gbManipulationData.Name = "gbManipulationData";
            this.gbManipulationData.TabStop = false;
            // 
            // pnName
            // 
            this.pnName.Controls.Add(this.btnUpdate);
            this.pnName.Controls.Add(this.tbNameWriter);
            this.pnName.Controls.Add(this.lbNameWriter);
            resources.ApplyResources(this.pnName, "pnName");
            this.pnName.Name = "pnName";
            // 
            // btnUpdate
            // 
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbNameWriter
            // 
            resources.ApplyResources(this.tbNameWriter, "tbNameWriter");
            this.tbNameWriter.Name = "tbNameWriter";
            // 
            // lbNameWriter
            // 
            resources.ApplyResources(this.lbNameWriter, "lbNameWriter");
            this.lbNameWriter.Name = "lbNameWriter";
            // 
            // pnPatronymic
            // 
            this.pnPatronymic.Controls.Add(this.btnDelete);
            this.pnPatronymic.Controls.Add(this.tbPatronymicWriter);
            this.pnPatronymic.Controls.Add(this.lbPatronymicWriter);
            resources.ApplyResources(this.pnPatronymic, "pnPatronymic");
            this.pnPatronymic.Name = "pnPatronymic";
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbPatronymicWriter
            // 
            resources.ApplyResources(this.tbPatronymicWriter, "tbPatronymicWriter");
            this.tbPatronymicWriter.Name = "tbPatronymicWriter";
            // 
            // lbPatronymicWriter
            // 
            resources.ApplyResources(this.lbPatronymicWriter, "lbPatronymicWriter");
            this.lbPatronymicWriter.Name = "lbPatronymicWriter";
            // 
            // pnSurname
            // 
            this.pnSurname.Controls.Add(this.btnInsert);
            this.pnSurname.Controls.Add(this.tbSurnameWriter);
            this.pnSurname.Controls.Add(this.lbSurnameWriter);
            resources.ApplyResources(this.pnSurname, "pnSurname");
            this.pnSurname.Name = "pnSurname";
            // 
            // btnInsert
            // 
            resources.ApplyResources(this.btnInsert, "btnInsert");
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // tbSurnameWriter
            // 
            resources.ApplyResources(this.tbSurnameWriter, "tbSurnameWriter");
            this.tbSurnameWriter.Name = "tbSurnameWriter";
            // 
            // lbSurnameWriter
            // 
            resources.ApplyResources(this.lbSurnameWriter, "lbSurnameWriter");
            this.lbSurnameWriter.Name = "lbSurnameWriter";
            // 
            // gbSearchAndFiltration
            // 
            this.gbSearchAndFiltration.Controls.Add(this.pnSearch);
            this.gbSearchAndFiltration.Controls.Add(this.pnFiltration);
            resources.ApplyResources(this.gbSearchAndFiltration, "gbSearchAndFiltration");
            this.gbSearchAndFiltration.Name = "gbSearchAndFiltration";
            this.gbSearchAndFiltration.TabStop = false;
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.tbSearch);
            resources.ApplyResources(this.pnSearch, "pnSearch");
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
            this.pnFiltration.Controls.Add(this.chbFiltration);
            resources.ApplyResources(this.pnFiltration, "pnFiltration");
            this.pnFiltration.Name = "pnFiltration";
            // 
            // chbFiltration
            // 
            resources.ApplyResources(this.chbFiltration, "chbFiltration");
            this.chbFiltration.Name = "chbFiltration";
            this.chbFiltration.UseVisualStyleBackColor = true;
            this.chbFiltration.CheckedChanged += new System.EventHandler(this.chbFiltration_CheckedChanged);
            // 
            // dgvWriterBook
            // 
            this.dgvWriterBook.AllowUserToAddRows = false;
            this.dgvWriterBook.AllowUserToDeleteRows = false;
            this.dgvWriterBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWriterBook.BackgroundColor = System.Drawing.Color.White;
            this.dgvWriterBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvWriterBook, "dgvWriterBook");
            this.dgvWriterBook.Name = "dgvWriterBook";
            this.dgvWriterBook.ReadOnly = true;
            this.dgvWriterBook.RowTemplate.Height = 24;
            this.dgvWriterBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWriterBook_CellClick);
            // 
            // WriterBookForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvWriterBook);
            this.Controls.Add(this.gbManipulationData);
            this.Controls.Add(this.gbSearchAndFiltration);
            this.Controls.Add(this.pnCancel);
            this.Name = "WriterBookForm";
            this.Load += new System.EventHandler(this.WriterBookForm_Load);
            this.pnCancel.ResumeLayout(false);
            this.gbManipulationData.ResumeLayout(false);
            this.pnName.ResumeLayout(false);
            this.pnName.PerformLayout();
            this.pnPatronymic.ResumeLayout(false);
            this.pnPatronymic.PerformLayout();
            this.pnSurname.ResumeLayout(false);
            this.pnSurname.PerformLayout();
            this.gbSearchAndFiltration.ResumeLayout(false);
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.pnFiltration.ResumeLayout(false);
            this.pnFiltration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWriterBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnCancel;
        private System.Windows.Forms.Button btnError;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbManipulationData;
        private System.Windows.Forms.Label lbPatronymicWriter;
        private System.Windows.Forms.Label lbNameWriter;
        private System.Windows.Forms.Label lbSurnameWriter;
        private System.Windows.Forms.TextBox tbPatronymicWriter;
        private System.Windows.Forms.TextBox tbNameWriter;
        private System.Windows.Forms.TextBox tbSurnameWriter;
        private System.Windows.Forms.GroupBox gbSearchAndFiltration;
        private System.Windows.Forms.CheckBox chbFiltration;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Panel pnName;
        private System.Windows.Forms.Panel pnSurname;
        private System.Windows.Forms.Panel pnPatronymic;
        private System.Windows.Forms.DataGridView dgvWriterBook;
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.Panel pnFiltration;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnInsert;
    }
}