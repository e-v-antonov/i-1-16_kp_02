namespace Library
{
    partial class IssueBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBookForm));
            this.pnCancel = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnError = new System.Windows.Forms.Button();
            this.gbSearchReader = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegistrationReader = new System.Windows.Forms.Button();
            this.btnIdentificationReader = new System.Windows.Forms.Button();
            this.pnPassportNumber = new System.Windows.Forms.Panel();
            this.tbPassportNumber = new System.Windows.Forms.TextBox();
            this.lbPassportNumber = new System.Windows.Forms.Label();
            this.pnPassportSeries = new System.Windows.Forms.Panel();
            this.tbPassportSeries = new System.Windows.Forms.TextBox();
            this.lbPassportSeries = new System.Windows.Forms.Label();
            this.pnPatronymic = new System.Windows.Forms.Panel();
            this.tbPatronymic = new System.Windows.Forms.TextBox();
            this.lbPatronymic = new System.Windows.Forms.Label();
            this.pnName = new System.Windows.Forms.Panel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.pnSurname = new System.Windows.Forms.Panel();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.lbSurname = new System.Windows.Forms.Label();
            this.gbSearchBook = new System.Windows.Forms.GroupBox();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnCheckBook = new System.Windows.Forms.Button();
            this.pnPublishing = new System.Windows.Forms.Panel();
            this.cbPublishing = new System.Windows.Forms.ComboBox();
            this.lbPublishing = new System.Windows.Forms.Label();
            this.pnGenre = new System.Windows.Forms.Panel();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.lbGenre = new System.Windows.Forms.Label();
            this.pnWriter = new System.Windows.Forms.Panel();
            this.cbWriter = new System.Windows.Forms.ComboBox();
            this.lbWriter = new System.Windows.Forms.Label();
            this.pnTitleBook = new System.Windows.Forms.Panel();
            this.tbTitleBook = new System.Windows.Forms.TextBox();
            this.lbTitleBook = new System.Windows.Forms.Label();
            this.gbIssueBook = new System.Windows.Forms.GroupBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnIssueBook = new System.Windows.Forms.Button();
            this.pnDateRetirnBook = new System.Windows.Forms.Panel();
            this.tbDateReturn = new System.Windows.Forms.TextBox();
            this.lbDateReturnBook = new System.Windows.Forms.Label();
            this.pnNumberDays = new System.Windows.Forms.Panel();
            this.nudNumberDays = new System.Windows.Forms.NumericUpDown();
            this.lbNumberDays = new System.Windows.Forms.Label();
            this.pnDateIssueBook = new System.Windows.Forms.Panel();
            this.dtpDateIssueBook = new System.Windows.Forms.DateTimePicker();
            this.lbDateIssueBook = new System.Windows.Forms.Label();
            this.pnCancel.SuspendLayout();
            this.gbSearchReader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnPassportNumber.SuspendLayout();
            this.pnPassportSeries.SuspendLayout();
            this.pnPatronymic.SuspendLayout();
            this.pnName.SuspendLayout();
            this.pnSurname.SuspendLayout();
            this.gbSearchBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.panel11.SuspendLayout();
            this.pnPublishing.SuspendLayout();
            this.pnGenre.SuspendLayout();
            this.pnWriter.SuspendLayout();
            this.pnTitleBook.SuspendLayout();
            this.gbIssueBook.SuspendLayout();
            this.panel15.SuspendLayout();
            this.pnDateRetirnBook.SuspendLayout();
            this.pnNumberDays.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberDays)).BeginInit();
            this.pnDateIssueBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCancel
            // 
            this.pnCancel.Controls.Add(this.btnExit);
            this.pnCancel.Controls.Add(this.btnError);
            resources.ApplyResources(this.pnCancel, "pnCancel");
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
            // gbSearchReader
            // 
            this.gbSearchReader.Controls.Add(this.panel1);
            this.gbSearchReader.Controls.Add(this.pnPassportNumber);
            this.gbSearchReader.Controls.Add(this.pnPassportSeries);
            this.gbSearchReader.Controls.Add(this.pnPatronymic);
            this.gbSearchReader.Controls.Add(this.pnName);
            this.gbSearchReader.Controls.Add(this.pnSurname);
            resources.ApplyResources(this.gbSearchReader, "gbSearchReader");
            this.gbSearchReader.Name = "gbSearchReader";
            this.gbSearchReader.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRegistrationReader);
            this.panel1.Controls.Add(this.btnIdentificationReader);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnRegistrationReader
            // 
            resources.ApplyResources(this.btnRegistrationReader, "btnRegistrationReader");
            this.btnRegistrationReader.Name = "btnRegistrationReader";
            this.btnRegistrationReader.UseVisualStyleBackColor = true;
            this.btnRegistrationReader.Click += new System.EventHandler(this.btnRegistrationReader_Click);
            // 
            // btnIdentificationReader
            // 
            resources.ApplyResources(this.btnIdentificationReader, "btnIdentificationReader");
            this.btnIdentificationReader.Name = "btnIdentificationReader";
            this.btnIdentificationReader.UseVisualStyleBackColor = true;
            this.btnIdentificationReader.Click += new System.EventHandler(this.btnIdentificationReader_Click);
            // 
            // pnPassportNumber
            // 
            this.pnPassportNumber.Controls.Add(this.tbPassportNumber);
            this.pnPassportNumber.Controls.Add(this.lbPassportNumber);
            resources.ApplyResources(this.pnPassportNumber, "pnPassportNumber");
            this.pnPassportNumber.Name = "pnPassportNumber";
            // 
            // tbPassportNumber
            // 
            resources.ApplyResources(this.tbPassportNumber, "tbPassportNumber");
            this.tbPassportNumber.Name = "tbPassportNumber";
            // 
            // lbPassportNumber
            // 
            resources.ApplyResources(this.lbPassportNumber, "lbPassportNumber");
            this.lbPassportNumber.Name = "lbPassportNumber";
            // 
            // pnPassportSeries
            // 
            this.pnPassportSeries.Controls.Add(this.tbPassportSeries);
            this.pnPassportSeries.Controls.Add(this.lbPassportSeries);
            resources.ApplyResources(this.pnPassportSeries, "pnPassportSeries");
            this.pnPassportSeries.Name = "pnPassportSeries";
            // 
            // tbPassportSeries
            // 
            resources.ApplyResources(this.tbPassportSeries, "tbPassportSeries");
            this.tbPassportSeries.Name = "tbPassportSeries";
            // 
            // lbPassportSeries
            // 
            resources.ApplyResources(this.lbPassportSeries, "lbPassportSeries");
            this.lbPassportSeries.Name = "lbPassportSeries";
            // 
            // pnPatronymic
            // 
            this.pnPatronymic.Controls.Add(this.tbPatronymic);
            this.pnPatronymic.Controls.Add(this.lbPatronymic);
            resources.ApplyResources(this.pnPatronymic, "pnPatronymic");
            this.pnPatronymic.Name = "pnPatronymic";
            // 
            // tbPatronymic
            // 
            resources.ApplyResources(this.tbPatronymic, "tbPatronymic");
            this.tbPatronymic.Name = "tbPatronymic";
            // 
            // lbPatronymic
            // 
            resources.ApplyResources(this.lbPatronymic, "lbPatronymic");
            this.lbPatronymic.Name = "lbPatronymic";
            // 
            // pnName
            // 
            this.pnName.Controls.Add(this.tbName);
            this.pnName.Controls.Add(this.lbName);
            resources.ApplyResources(this.pnName, "pnName");
            this.pnName.Name = "pnName";
            // 
            // tbName
            // 
            resources.ApplyResources(this.tbName, "tbName");
            this.tbName.Name = "tbName";
            // 
            // lbName
            // 
            resources.ApplyResources(this.lbName, "lbName");
            this.lbName.Name = "lbName";
            // 
            // pnSurname
            // 
            this.pnSurname.Controls.Add(this.tbSurname);
            this.pnSurname.Controls.Add(this.lbSurname);
            resources.ApplyResources(this.pnSurname, "pnSurname");
            this.pnSurname.Name = "pnSurname";
            // 
            // tbSurname
            // 
            resources.ApplyResources(this.tbSurname, "tbSurname");
            this.tbSurname.Name = "tbSurname";
            // 
            // lbSurname
            // 
            resources.ApplyResources(this.lbSurname, "lbSurname");
            this.lbSurname.Name = "lbSurname";
            // 
            // gbSearchBook
            // 
            this.gbSearchBook.Controls.Add(this.dgvBook);
            this.gbSearchBook.Controls.Add(this.panel11);
            resources.ApplyResources(this.gbSearchBook, "gbSearchBook");
            this.gbSearchBook.Name = "gbSearchBook";
            this.gbSearchBook.TabStop = false;
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToDeleteRows = false;
            this.dgvBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBook.BackgroundColor = System.Drawing.Color.White;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvBook, "dgvBook");
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            this.dgvBook.RowTemplate.Height = 24;
            this.dgvBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellClick);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnCheckBook);
            this.panel11.Controls.Add(this.pnPublishing);
            this.panel11.Controls.Add(this.pnGenre);
            this.panel11.Controls.Add(this.pnWriter);
            this.panel11.Controls.Add(this.pnTitleBook);
            resources.ApplyResources(this.panel11, "panel11");
            this.panel11.Name = "panel11";
            // 
            // btnCheckBook
            // 
            resources.ApplyResources(this.btnCheckBook, "btnCheckBook");
            this.btnCheckBook.Name = "btnCheckBook";
            this.btnCheckBook.UseVisualStyleBackColor = true;
            this.btnCheckBook.Click += new System.EventHandler(this.btnCheckBook_Click);
            // 
            // pnPublishing
            // 
            this.pnPublishing.Controls.Add(this.cbPublishing);
            this.pnPublishing.Controls.Add(this.lbPublishing);
            resources.ApplyResources(this.pnPublishing, "pnPublishing");
            this.pnPublishing.Name = "pnPublishing";
            // 
            // cbPublishing
            // 
            resources.ApplyResources(this.cbPublishing, "cbPublishing");
            this.cbPublishing.FormattingEnabled = true;
            this.cbPublishing.Name = "cbPublishing";
            this.cbPublishing.TextChanged += new System.EventHandler(this.cbPublishing_TextChanged);
            // 
            // lbPublishing
            // 
            resources.ApplyResources(this.lbPublishing, "lbPublishing");
            this.lbPublishing.Name = "lbPublishing";
            // 
            // pnGenre
            // 
            this.pnGenre.Controls.Add(this.cbGenre);
            this.pnGenre.Controls.Add(this.lbGenre);
            resources.ApplyResources(this.pnGenre, "pnGenre");
            this.pnGenre.Name = "pnGenre";
            // 
            // cbGenre
            // 
            resources.ApplyResources(this.cbGenre, "cbGenre");
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.TextChanged += new System.EventHandler(this.cbGenre_TextChanged);
            // 
            // lbGenre
            // 
            resources.ApplyResources(this.lbGenre, "lbGenre");
            this.lbGenre.Name = "lbGenre";
            // 
            // pnWriter
            // 
            this.pnWriter.Controls.Add(this.cbWriter);
            this.pnWriter.Controls.Add(this.lbWriter);
            resources.ApplyResources(this.pnWriter, "pnWriter");
            this.pnWriter.Name = "pnWriter";
            // 
            // cbWriter
            // 
            resources.ApplyResources(this.cbWriter, "cbWriter");
            this.cbWriter.FormattingEnabled = true;
            this.cbWriter.Name = "cbWriter";
            this.cbWriter.TextChanged += new System.EventHandler(this.cbWriter_TextChanged);
            // 
            // lbWriter
            // 
            resources.ApplyResources(this.lbWriter, "lbWriter");
            this.lbWriter.Name = "lbWriter";
            // 
            // pnTitleBook
            // 
            this.pnTitleBook.Controls.Add(this.tbTitleBook);
            this.pnTitleBook.Controls.Add(this.lbTitleBook);
            resources.ApplyResources(this.pnTitleBook, "pnTitleBook");
            this.pnTitleBook.Name = "pnTitleBook";
            // 
            // tbTitleBook
            // 
            resources.ApplyResources(this.tbTitleBook, "tbTitleBook");
            this.tbTitleBook.Name = "tbTitleBook";
            this.tbTitleBook.TextChanged += new System.EventHandler(this.tbTitleBook_TextChanged);
            // 
            // lbTitleBook
            // 
            resources.ApplyResources(this.lbTitleBook, "lbTitleBook");
            this.lbTitleBook.Name = "lbTitleBook";
            // 
            // gbIssueBook
            // 
            this.gbIssueBook.Controls.Add(this.panel15);
            this.gbIssueBook.Controls.Add(this.pnDateRetirnBook);
            this.gbIssueBook.Controls.Add(this.pnNumberDays);
            this.gbIssueBook.Controls.Add(this.pnDateIssueBook);
            resources.ApplyResources(this.gbIssueBook, "gbIssueBook");
            this.gbIssueBook.Name = "gbIssueBook";
            this.gbIssueBook.TabStop = false;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.btnCancel);
            this.panel15.Controls.Add(this.btnIssueBook);
            resources.ApplyResources(this.panel15, "panel15");
            this.panel15.Name = "panel15";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnIssueBook
            // 
            resources.ApplyResources(this.btnIssueBook, "btnIssueBook");
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.UseVisualStyleBackColor = true;
            this.btnIssueBook.Click += new System.EventHandler(this.btnIssueBook_Click);
            // 
            // pnDateRetirnBook
            // 
            this.pnDateRetirnBook.Controls.Add(this.tbDateReturn);
            this.pnDateRetirnBook.Controls.Add(this.lbDateReturnBook);
            resources.ApplyResources(this.pnDateRetirnBook, "pnDateRetirnBook");
            this.pnDateRetirnBook.Name = "pnDateRetirnBook";
            // 
            // tbDateReturn
            // 
            resources.ApplyResources(this.tbDateReturn, "tbDateReturn");
            this.tbDateReturn.Name = "tbDateReturn";
            this.tbDateReturn.ReadOnly = true;
            // 
            // lbDateReturnBook
            // 
            resources.ApplyResources(this.lbDateReturnBook, "lbDateReturnBook");
            this.lbDateReturnBook.Name = "lbDateReturnBook";
            // 
            // pnNumberDays
            // 
            this.pnNumberDays.Controls.Add(this.nudNumberDays);
            this.pnNumberDays.Controls.Add(this.lbNumberDays);
            resources.ApplyResources(this.pnNumberDays, "pnNumberDays");
            this.pnNumberDays.Name = "pnNumberDays";
            // 
            // nudNumberDays
            // 
            resources.ApplyResources(this.nudNumberDays, "nudNumberDays");
            this.nudNumberDays.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.nudNumberDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberDays.Name = "nudNumberDays";
            this.nudNumberDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberDays.ValueChanged += new System.EventHandler(this.nudNumberDays_ValueChanged);
            // 
            // lbNumberDays
            // 
            resources.ApplyResources(this.lbNumberDays, "lbNumberDays");
            this.lbNumberDays.Name = "lbNumberDays";
            // 
            // pnDateIssueBook
            // 
            this.pnDateIssueBook.Controls.Add(this.dtpDateIssueBook);
            this.pnDateIssueBook.Controls.Add(this.lbDateIssueBook);
            resources.ApplyResources(this.pnDateIssueBook, "pnDateIssueBook");
            this.pnDateIssueBook.Name = "pnDateIssueBook";
            // 
            // dtpDateIssueBook
            // 
            resources.ApplyResources(this.dtpDateIssueBook, "dtpDateIssueBook");
            this.dtpDateIssueBook.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateIssueBook.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpDateIssueBook.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDateIssueBook.Name = "dtpDateIssueBook";
            // 
            // lbDateIssueBook
            // 
            resources.ApplyResources(this.lbDateIssueBook, "lbDateIssueBook");
            this.lbDateIssueBook.Name = "lbDateIssueBook";
            // 
            // IssueBookForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbSearchBook);
            this.Controls.Add(this.gbIssueBook);
            this.Controls.Add(this.gbSearchReader);
            this.Controls.Add(this.pnCancel);
            this.Name = "IssueBookForm";
            this.pnCancel.ResumeLayout(false);
            this.gbSearchReader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnPassportNumber.ResumeLayout(false);
            this.pnPassportNumber.PerformLayout();
            this.pnPassportSeries.ResumeLayout(false);
            this.pnPassportSeries.PerformLayout();
            this.pnPatronymic.ResumeLayout(false);
            this.pnPatronymic.PerformLayout();
            this.pnName.ResumeLayout(false);
            this.pnName.PerformLayout();
            this.pnSurname.ResumeLayout(false);
            this.pnSurname.PerformLayout();
            this.gbSearchBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.panel11.ResumeLayout(false);
            this.pnPublishing.ResumeLayout(false);
            this.pnPublishing.PerformLayout();
            this.pnGenre.ResumeLayout(false);
            this.pnGenre.PerformLayout();
            this.pnWriter.ResumeLayout(false);
            this.pnWriter.PerformLayout();
            this.pnTitleBook.ResumeLayout(false);
            this.pnTitleBook.PerformLayout();
            this.gbIssueBook.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.pnDateRetirnBook.ResumeLayout(false);
            this.pnDateRetirnBook.PerformLayout();
            this.pnNumberDays.ResumeLayout(false);
            this.pnNumberDays.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberDays)).EndInit();
            this.pnDateIssueBook.ResumeLayout(false);
            this.pnDateIssueBook.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnError;
        private System.Windows.Forms.GroupBox gbSearchReader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegistrationReader;
        private System.Windows.Forms.Button btnIdentificationReader;
        private System.Windows.Forms.Panel pnPassportNumber;
        private System.Windows.Forms.TextBox tbPassportNumber;
        private System.Windows.Forms.Label lbPassportNumber;
        private System.Windows.Forms.Panel pnPassportSeries;
        private System.Windows.Forms.TextBox tbPassportSeries;
        private System.Windows.Forms.Label lbPassportSeries;
        private System.Windows.Forms.Panel pnPatronymic;
        private System.Windows.Forms.TextBox tbPatronymic;
        private System.Windows.Forms.Label lbPatronymic;
        private System.Windows.Forms.Panel pnName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel pnSurname;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.GroupBox gbSearchBook;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnCheckBook;
        private System.Windows.Forms.Panel pnPublishing;
        private System.Windows.Forms.ComboBox cbPublishing;
        private System.Windows.Forms.Label lbPublishing;
        private System.Windows.Forms.Panel pnGenre;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.Panel pnWriter;
        private System.Windows.Forms.ComboBox cbWriter;
        private System.Windows.Forms.Label lbWriter;
        private System.Windows.Forms.Panel pnTitleBook;
        private System.Windows.Forms.TextBox tbTitleBook;
        private System.Windows.Forms.Label lbTitleBook;
        private System.Windows.Forms.GroupBox gbIssueBook;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnIssueBook;
        private System.Windows.Forms.Panel pnDateRetirnBook;
        private System.Windows.Forms.Label lbDateReturnBook;
        private System.Windows.Forms.Panel pnNumberDays;
        private System.Windows.Forms.Label lbNumberDays;
        private System.Windows.Forms.Panel pnDateIssueBook;
        private System.Windows.Forms.Label lbDateIssueBook;
        private System.Windows.Forms.DateTimePicker dtpDateIssueBook;
        private System.Windows.Forms.NumericUpDown nudNumberDays;
        private System.Windows.Forms.TextBox tbDateReturn;
    }
}