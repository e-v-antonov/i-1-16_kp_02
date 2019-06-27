namespace Library
{
    partial class FormularForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularForm));
            this.gbSearchAndFiltration = new System.Windows.Forms.GroupBox();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.pnFiltration = new System.Windows.Forms.Panel();
            this.chbFiltration = new System.Windows.Forms.CheckBox();
            this.pnCancel = new System.Windows.Forms.Panel();
            this.btnError = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbManipulationData = new System.Windows.Forms.GroupBox();
            this.pnRefreshData = new System.Windows.Forms.Panel();
            this.btnRefreshData = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.pnComboBox = new System.Windows.Forms.Panel();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnUpdateReader = new System.Windows.Forms.Button();
            this.cbBook = new System.Windows.Forms.ComboBox();
            this.lbBook = new System.Windows.Forms.Label();
            this.cbReader = new System.Windows.Forms.ComboBox();
            this.lbReader = new System.Windows.Forms.Label();
            this.chbBookReturned = new System.Windows.Forms.CheckBox();
            this.tbDateReturn = new System.Windows.Forms.TextBox();
            this.lbDateReturn = new System.Windows.Forms.Label();
            this.nudNumberDays = new System.Windows.Forms.NumericUpDown();
            this.lbNumberDays = new System.Windows.Forms.Label();
            this.dtpDateIssue = new System.Windows.Forms.DateTimePicker();
            this.lbDateIssue = new System.Windows.Forms.Label();
            this.dgvFormular = new System.Windows.Forms.DataGridView();
            this.ttRefreshData = new System.Windows.Forms.ToolTip(this.components);
            this.gbSearchAndFiltration.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.pnFiltration.SuspendLayout();
            this.pnCancel.SuspendLayout();
            this.gbManipulationData.SuspendLayout();
            this.pnRefreshData.SuspendLayout();
            this.pnComboBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormular)).BeginInit();
            this.SuspendLayout();
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
            this.gbManipulationData.Controls.Add(this.pnRefreshData);
            this.gbManipulationData.Controls.Add(this.btnDelete);
            this.gbManipulationData.Controls.Add(this.btnUpdate);
            this.gbManipulationData.Controls.Add(this.btnInsert);
            this.gbManipulationData.Controls.Add(this.pnComboBox);
            this.gbManipulationData.Controls.Add(this.chbBookReturned);
            this.gbManipulationData.Controls.Add(this.tbDateReturn);
            this.gbManipulationData.Controls.Add(this.lbDateReturn);
            this.gbManipulationData.Controls.Add(this.nudNumberDays);
            this.gbManipulationData.Controls.Add(this.lbNumberDays);
            this.gbManipulationData.Controls.Add(this.dtpDateIssue);
            this.gbManipulationData.Controls.Add(this.lbDateIssue);
            resources.ApplyResources(this.gbManipulationData, "gbManipulationData");
            this.gbManipulationData.Name = "gbManipulationData";
            this.gbManipulationData.TabStop = false;
            // 
            // pnRefreshData
            // 
            this.pnRefreshData.Controls.Add(this.btnRefreshData);
            resources.ApplyResources(this.pnRefreshData, "pnRefreshData");
            this.pnRefreshData.Name = "pnRefreshData";
            // 
            // btnRefreshData
            // 
            resources.ApplyResources(this.btnRefreshData, "btnRefreshData");
            this.btnRefreshData.Name = "btnRefreshData";
            this.btnRefreshData.UseVisualStyleBackColor = true;
            this.btnRefreshData.Click += new System.EventHandler(this.btnRefreshData_Click);
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
            // pnComboBox
            // 
            this.pnComboBox.Controls.Add(this.btnUpdateBook);
            this.pnComboBox.Controls.Add(this.btnUpdateReader);
            this.pnComboBox.Controls.Add(this.cbBook);
            this.pnComboBox.Controls.Add(this.lbBook);
            this.pnComboBox.Controls.Add(this.cbReader);
            this.pnComboBox.Controls.Add(this.lbReader);
            resources.ApplyResources(this.pnComboBox, "pnComboBox");
            this.pnComboBox.Name = "pnComboBox";
            // 
            // btnUpdateBook
            // 
            resources.ApplyResources(this.btnUpdateBook, "btnUpdateBook");
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnUpdateReader
            // 
            resources.ApplyResources(this.btnUpdateReader, "btnUpdateReader");
            this.btnUpdateReader.Name = "btnUpdateReader";
            this.btnUpdateReader.UseVisualStyleBackColor = true;
            this.btnUpdateReader.Click += new System.EventHandler(this.btnUpdateReader_Click);
            // 
            // cbBook
            // 
            resources.ApplyResources(this.cbBook, "cbBook");
            this.cbBook.FormattingEnabled = true;
            this.cbBook.Name = "cbBook";
            this.cbBook.DropDown += new System.EventHandler(this.cbBook_DropDown);
            // 
            // lbBook
            // 
            resources.ApplyResources(this.lbBook, "lbBook");
            this.lbBook.Name = "lbBook";
            // 
            // cbReader
            // 
            resources.ApplyResources(this.cbReader, "cbReader");
            this.cbReader.FormattingEnabled = true;
            this.cbReader.Name = "cbReader";
            this.cbReader.DropDown += new System.EventHandler(this.cbReader_DropDown);
            // 
            // lbReader
            // 
            resources.ApplyResources(this.lbReader, "lbReader");
            this.lbReader.Name = "lbReader";
            // 
            // chbBookReturned
            // 
            resources.ApplyResources(this.chbBookReturned, "chbBookReturned");
            this.chbBookReturned.Name = "chbBookReturned";
            this.chbBookReturned.UseVisualStyleBackColor = true;
            // 
            // tbDateReturn
            // 
            resources.ApplyResources(this.tbDateReturn, "tbDateReturn");
            this.tbDateReturn.Name = "tbDateReturn";
            this.tbDateReturn.ReadOnly = true;
            // 
            // lbDateReturn
            // 
            resources.ApplyResources(this.lbDateReturn, "lbDateReturn");
            this.lbDateReturn.Name = "lbDateReturn";
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
            // dtpDateIssue
            // 
            resources.ApplyResources(this.dtpDateIssue, "dtpDateIssue");
            this.dtpDateIssue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateIssue.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpDateIssue.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDateIssue.Name = "dtpDateIssue";
            this.dtpDateIssue.ValueChanged += new System.EventHandler(this.dtpDateIssue_ValueChanged);
            // 
            // lbDateIssue
            // 
            resources.ApplyResources(this.lbDateIssue, "lbDateIssue");
            this.lbDateIssue.Name = "lbDateIssue";
            // 
            // dgvFormular
            // 
            this.dgvFormular.AllowUserToAddRows = false;
            this.dgvFormular.AllowUserToDeleteRows = false;
            this.dgvFormular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFormular.BackgroundColor = System.Drawing.Color.White;
            this.dgvFormular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvFormular, "dgvFormular");
            this.dgvFormular.Name = "dgvFormular";
            this.dgvFormular.ReadOnly = true;
            this.dgvFormular.RowTemplate.Height = 24;
            this.dgvFormular.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFormular_CellClick);
            this.dgvFormular.Click += new System.EventHandler(this.dgvFormular_Click);
            // 
            // FormularForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvFormular);
            this.Controls.Add(this.gbManipulationData);
            this.Controls.Add(this.pnCancel);
            this.Controls.Add(this.gbSearchAndFiltration);
            this.Name = "FormularForm";
            this.Load += new System.EventHandler(this.FormularForm_Load);
            this.gbSearchAndFiltration.ResumeLayout(false);
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.pnFiltration.ResumeLayout(false);
            this.pnFiltration.PerformLayout();
            this.pnCancel.ResumeLayout(false);
            this.gbManipulationData.ResumeLayout(false);
            this.gbManipulationData.PerformLayout();
            this.pnRefreshData.ResumeLayout(false);
            this.pnComboBox.ResumeLayout(false);
            this.pnComboBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormular)).EndInit();
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
        private System.Windows.Forms.GroupBox gbManipulationData;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnUpdateReader;
        private System.Windows.Forms.ComboBox cbBook;
        private System.Windows.Forms.Label lbBook;
        private System.Windows.Forms.ComboBox cbReader;
        private System.Windows.Forms.Label lbReader;
        private System.Windows.Forms.CheckBox chbBookReturned;
        private System.Windows.Forms.TextBox tbDateReturn;
        private System.Windows.Forms.Label lbDateReturn;
        private System.Windows.Forms.NumericUpDown nudNumberDays;
        private System.Windows.Forms.Label lbNumberDays;
        private System.Windows.Forms.Label lbDateIssue;
        private System.Windows.Forms.Panel pnComboBox;
        private System.Windows.Forms.DataGridView dgvFormular;
        private System.Windows.Forms.DateTimePicker dtpDateIssue;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Panel pnRefreshData;
        private System.Windows.Forms.Button btnRefreshData;
        private System.Windows.Forms.ToolTip ttRefreshData;
    }
}