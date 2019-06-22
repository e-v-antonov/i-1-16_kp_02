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
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnCancel = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnError = new System.Windows.Forms.Button();
            this.gbCreateDocument = new System.Windows.Forms.GroupBox();
            this.btnCreateWordExceptionBook = new System.Windows.Forms.Button();
            this.btnCreatePdfExceptionBook = new System.Windows.Forms.Button();
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
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(700, 24);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Выберите книги";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnCancel
            // 
            this.pnCancel.Controls.Add(this.btnExit);
            this.pnCancel.Controls.Add(this.btnError);
            this.pnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCancel.Location = new System.Drawing.Point(0, 414);
            this.pnCancel.Name = "pnCancel";
            this.pnCancel.Size = new System.Drawing.Size(700, 36);
            this.pnCancel.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Location = new System.Drawing.Point(581, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 36);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Закрыть";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnError
            // 
            this.btnError.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnError.Location = new System.Drawing.Point(0, 0);
            this.btnError.Name = "btnError";
            this.btnError.Size = new System.Drawing.Size(119, 36);
            this.btnError.TabIndex = 0;
            this.btnError.Text = "Ошибки";
            this.btnError.UseVisualStyleBackColor = true;
            // 
            // gbCreateDocument
            // 
            this.gbCreateDocument.Controls.Add(this.btnCreateWordExceptionBook);
            this.gbCreateDocument.Controls.Add(this.btnCreatePdfExceptionBook);
            this.gbCreateDocument.Controls.Add(this.btnCreatePdfAdoptionBook);
            this.gbCreateDocument.Controls.Add(this.btnCreateWordAdoptionBook);
            this.gbCreateDocument.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbCreateDocument.Location = new System.Drawing.Point(0, 304);
            this.gbCreateDocument.Name = "gbCreateDocument";
            this.gbCreateDocument.Size = new System.Drawing.Size(700, 110);
            this.gbCreateDocument.TabIndex = 6;
            this.gbCreateDocument.TabStop = false;
            this.gbCreateDocument.Text = "Формирование документов";
            // 
            // btnCreateWordExceptionBook
            // 
            this.btnCreateWordExceptionBook.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCreateWordExceptionBook.Location = new System.Drawing.Point(409, 19);
            this.btnCreateWordExceptionBook.Name = "btnCreateWordExceptionBook";
            this.btnCreateWordExceptionBook.Size = new System.Drawing.Size(144, 88);
            this.btnCreateWordExceptionBook.TabIndex = 3;
            this.btnCreateWordExceptionBook.Text = "Сформировать акт об исключении из фонда в формате .pdf";
            this.btnCreateWordExceptionBook.UseVisualStyleBackColor = true;
            // 
            // btnCreatePdfExceptionBook
            // 
            this.btnCreatePdfExceptionBook.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCreatePdfExceptionBook.Location = new System.Drawing.Point(553, 19);
            this.btnCreatePdfExceptionBook.Name = "btnCreatePdfExceptionBook";
            this.btnCreatePdfExceptionBook.Size = new System.Drawing.Size(144, 88);
            this.btnCreatePdfExceptionBook.TabIndex = 2;
            this.btnCreatePdfExceptionBook.Text = "Сформировать акт об исключении из фонда в формате .docx";
            this.btnCreatePdfExceptionBook.UseVisualStyleBackColor = true;
            // 
            // btnCreatePdfAdoptionBook
            // 
            this.btnCreatePdfAdoptionBook.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCreatePdfAdoptionBook.Location = new System.Drawing.Point(147, 19);
            this.btnCreatePdfAdoptionBook.Name = "btnCreatePdfAdoptionBook";
            this.btnCreatePdfAdoptionBook.Size = new System.Drawing.Size(144, 88);
            this.btnCreatePdfAdoptionBook.TabIndex = 1;
            this.btnCreatePdfAdoptionBook.Text = "Сформировать акт о приемке книг в формате *.pdf";
            this.btnCreatePdfAdoptionBook.UseVisualStyleBackColor = true;
            this.btnCreatePdfAdoptionBook.Click += new System.EventHandler(this.btnCreatePdfAdoptionBook_Click);
            // 
            // btnCreateWordAdoptionBook
            // 
            this.btnCreateWordAdoptionBook.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCreateWordAdoptionBook.Location = new System.Drawing.Point(3, 19);
            this.btnCreateWordAdoptionBook.Name = "btnCreateWordAdoptionBook";
            this.btnCreateWordAdoptionBook.Size = new System.Drawing.Size(144, 88);
            this.btnCreateWordAdoptionBook.TabIndex = 0;
            this.btnCreateWordAdoptionBook.Text = "Сформировать акт о приемке книг в формате *.docx";
            this.btnCreateWordAdoptionBook.UseVisualStyleBackColor = true;
            this.btnCreateWordAdoptionBook.Click += new System.EventHandler(this.btnCreateWordAdoptionBook_Click);
            // 
            // dgvListBook
            // 
            this.dgvListBook.AllowUserToAddRows = false;
            this.dgvListBook.AllowUserToDeleteRows = false;
            this.dgvListBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListBook.BackgroundColor = System.Drawing.Color.White;
            this.dgvListBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListBook.Location = new System.Drawing.Point(0, 24);
            this.dgvListBook.Name = "dgvListBook";
            this.dgvListBook.ReadOnly = true;
            this.dgvListBook.RowTemplate.Height = 24;
            this.dgvListBook.Size = new System.Drawing.Size(700, 280);
            this.dgvListBook.TabIndex = 7;
            // 
            // FormationActsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.dgvListBook);
            this.Controls.Add(this.gbCreateDocument);
            this.Controls.Add(this.pnCancel);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FormationActsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Формирование  актов";
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
        private System.Windows.Forms.Button btnCreateWordExceptionBook;
        private System.Windows.Forms.Button btnCreatePdfExceptionBook;
        private System.Windows.Forms.Button btnCreatePdfAdoptionBook;
        private System.Windows.Forms.Button btnCreateWordAdoptionBook;
        private System.Windows.Forms.DataGridView dgvListBook;
    }
}