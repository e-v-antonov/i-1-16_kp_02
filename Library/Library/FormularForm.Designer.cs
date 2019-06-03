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
            this.gbSearchAndFiltration = new System.Windows.Forms.GroupBox();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.pnFiltration = new System.Windows.Forms.Panel();
            this.chbFiltration = new System.Windows.Forms.CheckBox();
            this.pnCancel = new System.Windows.Forms.Panel();
            this.btnError = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbManipulationData = new System.Windows.Forms.GroupBox();
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
            this.lbDateIssue = new System.Windows.Forms.Label();
            this.dgvFormular = new System.Windows.Forms.DataGridView();
            this.dtpDateIssue = new System.Windows.Forms.DateTimePicker();
            this.gbSearchAndFiltration.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.pnFiltration.SuspendLayout();
            this.pnCancel.SuspendLayout();
            this.gbManipulationData.SuspendLayout();
            this.pnComboBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormular)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSearchAndFiltration
            // 
            this.gbSearchAndFiltration.Controls.Add(this.pnSearch);
            this.gbSearchAndFiltration.Controls.Add(this.pnFiltration);
            this.gbSearchAndFiltration.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSearchAndFiltration.Location = new System.Drawing.Point(0, 0);
            this.gbSearchAndFiltration.Name = "gbSearchAndFiltration";
            this.gbSearchAndFiltration.Size = new System.Drawing.Size(1073, 48);
            this.gbSearchAndFiltration.TabIndex = 4;
            this.gbSearchAndFiltration.TabStop = false;
            this.gbSearchAndFiltration.Text = "Поиск и фильтрация:";
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.tbSearch);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSearch.Location = new System.Drawing.Point(3, 19);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(934, 32);
            this.pnSearch.TabIndex = 2;
            // 
            // tbSearch
            // 
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSearch.Location = new System.Drawing.Point(0, 0);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(934, 23);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.Text = "Введите данные книги...";
            this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
            this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
            // 
            // pnFiltration
            // 
            this.pnFiltration.Controls.Add(this.chbFiltration);
            this.pnFiltration.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnFiltration.Location = new System.Drawing.Point(937, 19);
            this.pnFiltration.Name = "pnFiltration";
            this.pnFiltration.Size = new System.Drawing.Size(133, 26);
            this.pnFiltration.TabIndex = 3;
            // 
            // chbFiltration
            // 
            this.chbFiltration.AutoSize = true;
            this.chbFiltration.Dock = System.Windows.Forms.DockStyle.Right;
            this.chbFiltration.Location = new System.Drawing.Point(-19, 0);
            this.chbFiltration.Name = "chbFiltration";
            this.chbFiltration.Size = new System.Drawing.Size(152, 26);
            this.chbFiltration.TabIndex = 1;
            this.chbFiltration.Text = "Отфильтровывать";
            this.chbFiltration.UseVisualStyleBackColor = true;
            this.chbFiltration.CheckedChanged += new System.EventHandler(this.chbFiltration_CheckedChanged);
            // 
            // pnCancel
            // 
            this.pnCancel.Controls.Add(this.btnError);
            this.pnCancel.Controls.Add(this.btnExit);
            this.pnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCancel.Location = new System.Drawing.Point(0, 481);
            this.pnCancel.Name = "pnCancel";
            this.pnCancel.Size = new System.Drawing.Size(1073, 36);
            this.pnCancel.TabIndex = 5;
            // 
            // btnError
            // 
            this.btnError.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnError.Location = new System.Drawing.Point(0, 0);
            this.btnError.Name = "btnError";
            this.btnError.Size = new System.Drawing.Size(119, 36);
            this.btnError.TabIndex = 1;
            this.btnError.Text = "Ошибки";
            this.btnError.UseVisualStyleBackColor = true;
            this.btnError.Click += new System.EventHandler(this.btnError_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Location = new System.Drawing.Point(954, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 36);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Закрыть";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbManipulationData
            // 
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
            this.gbManipulationData.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbManipulationData.Location = new System.Drawing.Point(0, 48);
            this.gbManipulationData.Name = "gbManipulationData";
            this.gbManipulationData.Size = new System.Drawing.Size(280, 433);
            this.gbManipulationData.TabIndex = 6;
            this.gbManipulationData.TabStop = false;
            this.gbManipulationData.Text = "Манипулирование данными:";
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.Location = new System.Drawing.Point(3, 334);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(274, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Удалить запись формуляра";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdate.Location = new System.Drawing.Point(3, 311);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(274, 23);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Изменить запись";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInsert.Location = new System.Drawing.Point(3, 288);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(274, 23);
            this.btnInsert.TabIndex = 14;
            this.btnInsert.Text = "Добавить запись формуляра";
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
            this.pnComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnComboBox.Location = new System.Drawing.Point(3, 156);
            this.pnComboBox.Name = "pnComboBox";
            this.pnComboBox.Size = new System.Drawing.Size(274, 132);
            this.pnComboBox.TabIndex = 17;
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateBook.Location = new System.Drawing.Point(0, 103);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(274, 23);
            this.btnUpdateBook.TabIndex = 13;
            this.btnUpdateBook.Text = "Редактировать данные книги";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnUpdateReader
            // 
            this.btnUpdateReader.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateReader.Location = new System.Drawing.Point(0, 80);
            this.btnUpdateReader.Name = "btnUpdateReader";
            this.btnUpdateReader.Size = new System.Drawing.Size(274, 23);
            this.btnUpdateReader.TabIndex = 12;
            this.btnUpdateReader.Text = "Редактировать данные читателя";
            this.btnUpdateReader.UseVisualStyleBackColor = true;
            this.btnUpdateReader.Click += new System.EventHandler(this.btnUpdateReader_Click);
            // 
            // cbBook
            // 
            this.cbBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbBook.FormattingEnabled = true;
            this.cbBook.Location = new System.Drawing.Point(0, 56);
            this.cbBook.Name = "cbBook";
            this.cbBook.Size = new System.Drawing.Size(274, 24);
            this.cbBook.TabIndex = 9;
            // 
            // lbBook
            // 
            this.lbBook.AutoSize = true;
            this.lbBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbBook.Location = new System.Drawing.Point(0, 40);
            this.lbBook.Name = "lbBook";
            this.lbBook.Size = new System.Drawing.Size(45, 16);
            this.lbBook.TabIndex = 11;
            this.lbBook.Text = "Книга";
            // 
            // cbReader
            // 
            this.cbReader.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbReader.FormattingEnabled = true;
            this.cbReader.Location = new System.Drawing.Point(0, 16);
            this.cbReader.Name = "cbReader";
            this.cbReader.Size = new System.Drawing.Size(274, 24);
            this.cbReader.TabIndex = 8;
            // 
            // lbReader
            // 
            this.lbReader.AutoSize = true;
            this.lbReader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbReader.Location = new System.Drawing.Point(0, 0);
            this.lbReader.Name = "lbReader";
            this.lbReader.Size = new System.Drawing.Size(70, 16);
            this.lbReader.TabIndex = 10;
            this.lbReader.Text = "Читатель";
            // 
            // chbBookReturned
            // 
            this.chbBookReturned.AutoSize = true;
            this.chbBookReturned.Dock = System.Windows.Forms.DockStyle.Top;
            this.chbBookReturned.Location = new System.Drawing.Point(3, 136);
            this.chbBookReturned.Name = "chbBookReturned";
            this.chbBookReturned.Size = new System.Drawing.Size(274, 20);
            this.chbBookReturned.TabIndex = 7;
            this.chbBookReturned.Text = "Книга возвращена";
            this.chbBookReturned.UseVisualStyleBackColor = true;
            // 
            // tbDateReturn
            // 
            this.tbDateReturn.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbDateReturn.Location = new System.Drawing.Point(3, 113);
            this.tbDateReturn.Name = "tbDateReturn";
            this.tbDateReturn.ReadOnly = true;
            this.tbDateReturn.Size = new System.Drawing.Size(274, 23);
            this.tbDateReturn.TabIndex = 4;
            // 
            // lbDateReturn
            // 
            this.lbDateReturn.AutoSize = true;
            this.lbDateReturn.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDateReturn.Location = new System.Drawing.Point(3, 97);
            this.lbDateReturn.Name = "lbDateReturn";
            this.lbDateReturn.Size = new System.Drawing.Size(142, 16);
            this.lbDateReturn.TabIndex = 5;
            this.lbDateReturn.Text = "Дата возврата книги";
            // 
            // nudNumberDays
            // 
            this.nudNumberDays.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudNumberDays.Location = new System.Drawing.Point(3, 74);
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
            this.nudNumberDays.Size = new System.Drawing.Size(274, 23);
            this.nudNumberDays.TabIndex = 0;
            this.nudNumberDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberDays.ValueChanged += new System.EventHandler(this.nudNumberDays_ValueChanged);
            // 
            // lbNumberDays
            // 
            this.lbNumberDays.AutoSize = true;
            this.lbNumberDays.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbNumberDays.Location = new System.Drawing.Point(3, 58);
            this.lbNumberDays.Name = "lbNumberDays";
            this.lbNumberDays.Size = new System.Drawing.Size(172, 16);
            this.lbNumberDays.TabIndex = 3;
            this.lbNumberDays.Text = "Количество дней выдачи";
            // 
            // lbDateIssue
            // 
            this.lbDateIssue.AutoSize = true;
            this.lbDateIssue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDateIssue.Location = new System.Drawing.Point(3, 19);
            this.lbDateIssue.Name = "lbDateIssue";
            this.lbDateIssue.Size = new System.Drawing.Size(131, 16);
            this.lbDateIssue.TabIndex = 1;
            this.lbDateIssue.Text = "Дата выдачи книги";
            // 
            // dgvFormular
            // 
            this.dgvFormular.AllowUserToAddRows = false;
            this.dgvFormular.AllowUserToDeleteRows = false;
            this.dgvFormular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFormular.BackgroundColor = System.Drawing.Color.White;
            this.dgvFormular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFormular.Location = new System.Drawing.Point(280, 48);
            this.dgvFormular.Name = "dgvFormular";
            this.dgvFormular.ReadOnly = true;
            this.dgvFormular.RowTemplate.Height = 24;
            this.dgvFormular.Size = new System.Drawing.Size(793, 433);
            this.dgvFormular.TabIndex = 7;
            this.dgvFormular.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFormular_CellClick);
            this.dgvFormular.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvFormular_MouseMove);
            // 
            // dtpDateIssue
            // 
            this.dtpDateIssue.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpDateIssue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateIssue.Location = new System.Drawing.Point(3, 35);
            this.dtpDateIssue.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpDateIssue.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDateIssue.Name = "dtpDateIssue";
            this.dtpDateIssue.Size = new System.Drawing.Size(274, 23);
            this.dtpDateIssue.TabIndex = 18;
            this.dtpDateIssue.ValueChanged += new System.EventHandler(this.dtpDateIssue_ValueChanged);
            // 
            // FormularForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1073, 517);
            this.Controls.Add(this.dgvFormular);
            this.Controls.Add(this.gbManipulationData);
            this.Controls.Add(this.pnCancel);
            this.Controls.Add(this.gbSearchAndFiltration);
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FormularForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Формуляры";
            this.Load += new System.EventHandler(this.FormularForm_Load);
            this.gbSearchAndFiltration.ResumeLayout(false);
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.pnFiltration.ResumeLayout(false);
            this.pnFiltration.PerformLayout();
            this.pnCancel.ResumeLayout(false);
            this.gbManipulationData.ResumeLayout(false);
            this.gbManipulationData.PerformLayout();
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
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
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
    }
}