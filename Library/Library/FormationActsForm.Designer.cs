namespace Library
{
    partial class FormationActsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormationActsForm));
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnCancel = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnError = new System.Windows.Forms.Button();
            this.gbCreateDocument = new System.Windows.Forms.GroupBox();
            this.btnCreatePdfExceptionBook = new System.Windows.Forms.Button();
            this.btnCreateWordExceptionBook = new System.Windows.Forms.Button();
            this.btnCreatePdfAdoptionBook = new System.Windows.Forms.Button();
            this.btnCreateWordAdoptionBook = new System.Windows.Forms.Button();
            this.dgvListBook = new System.Windows.Forms.DataGridView();
            this.pnCancel.SuspendLayout();
            this.gbCreateDocument.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBook)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            resources.ApplyResources(this.lbTitle, "lbTitle");
            this.lbTitle.Name = "lbTitle";
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
            // gbCreateDocument
            // 
            resources.ApplyResources(this.gbCreateDocument, "gbCreateDocument");
            this.gbCreateDocument.Controls.Add(this.btnCreatePdfExceptionBook);
            this.gbCreateDocument.Controls.Add(this.btnCreateWordExceptionBook);
            this.gbCreateDocument.Controls.Add(this.btnCreatePdfAdoptionBook);
            this.gbCreateDocument.Controls.Add(this.btnCreateWordAdoptionBook);
            this.gbCreateDocument.Name = "gbCreateDocument";
            this.gbCreateDocument.TabStop = false;
            // 
            // btnCreatePdfExceptionBook
            // 
            resources.ApplyResources(this.btnCreatePdfExceptionBook, "btnCreatePdfExceptionBook");
            this.btnCreatePdfExceptionBook.Name = "btnCreatePdfExceptionBook";
            this.btnCreatePdfExceptionBook.UseVisualStyleBackColor = true;
            this.btnCreatePdfExceptionBook.Click += new System.EventHandler(this.btnCreatePdfExceptionBook_Click);
            // 
            // btnCreateWordExceptionBook
            // 
            resources.ApplyResources(this.btnCreateWordExceptionBook, "btnCreateWordExceptionBook");
            this.btnCreateWordExceptionBook.Name = "btnCreateWordExceptionBook";
            this.btnCreateWordExceptionBook.UseVisualStyleBackColor = true;
            this.btnCreateWordExceptionBook.Click += new System.EventHandler(this.btnCreateWordExceptionBook_Click);
            // 
            // btnCreatePdfAdoptionBook
            // 
            resources.ApplyResources(this.btnCreatePdfAdoptionBook, "btnCreatePdfAdoptionBook");
            this.btnCreatePdfAdoptionBook.Name = "btnCreatePdfAdoptionBook";
            this.btnCreatePdfAdoptionBook.UseVisualStyleBackColor = true;
            this.btnCreatePdfAdoptionBook.Click += new System.EventHandler(this.btnCreatePdfAdoptionBook_Click);
            // 
            // btnCreateWordAdoptionBook
            // 
            resources.ApplyResources(this.btnCreateWordAdoptionBook, "btnCreateWordAdoptionBook");
            this.btnCreateWordAdoptionBook.Name = "btnCreateWordAdoptionBook";
            this.btnCreateWordAdoptionBook.UseVisualStyleBackColor = true;
            this.btnCreateWordAdoptionBook.Click += new System.EventHandler(this.btnCreateWordAdoptionBook_Click);
            // 
            // dgvListBook
            // 
            resources.ApplyResources(this.dgvListBook, "dgvListBook");
            this.dgvListBook.AllowUserToAddRows = false;
            this.dgvListBook.AllowUserToDeleteRows = false;
            this.dgvListBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListBook.BackgroundColor = System.Drawing.Color.White;
            this.dgvListBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListBook.Name = "dgvListBook";
            this.dgvListBook.ReadOnly = true;
            this.dgvListBook.RowTemplate.Height = 24;
            // 
            // FormationActsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvListBook);
            this.Controls.Add(this.gbCreateDocument);
            this.Controls.Add(this.pnCancel);
            this.Controls.Add(this.lbTitle);
            this.Name = "FormationActsForm";
            this.Load += new System.EventHandler(this.FormationActsForm_Load);
            this.pnCancel.ResumeLayout(false);
            this.gbCreateDocument.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnError;
        private System.Windows.Forms.GroupBox gbCreateDocument;
        private System.Windows.Forms.Button btnCreatePdfExceptionBook;
        private System.Windows.Forms.Button btnCreateWordExceptionBook;
        private System.Windows.Forms.Button btnCreatePdfAdoptionBook;
        private System.Windows.Forms.Button btnCreateWordAdoptionBook;
        private System.Windows.Forms.DataGridView dgvListBook;
    }
}