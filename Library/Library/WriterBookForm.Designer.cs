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
            this.pnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCancel.Location = new System.Drawing.Point(0, 442);
            this.pnCancel.Name = "pnCancel";
            this.pnCancel.Size = new System.Drawing.Size(800, 36);
            this.pnCancel.TabIndex = 0;
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
            this.btnExit.Location = new System.Drawing.Point(681, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 36);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Закрыть";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbManipulationData
            // 
            this.gbManipulationData.Controls.Add(this.pnName);
            this.gbManipulationData.Controls.Add(this.pnPatronymic);
            this.gbManipulationData.Controls.Add(this.pnSurname);
            this.gbManipulationData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbManipulationData.Location = new System.Drawing.Point(0, 352);
            this.gbManipulationData.Name = "gbManipulationData";
            this.gbManipulationData.Size = new System.Drawing.Size(800, 90);
            this.gbManipulationData.TabIndex = 1;
            this.gbManipulationData.TabStop = false;
            this.gbManipulationData.Text = "Манипулирование данными:";
            // 
            // pnName
            // 
            this.pnName.Controls.Add(this.btnUpdate);
            this.pnName.Controls.Add(this.tbNameWriter);
            this.pnName.Controls.Add(this.lbNameWriter);
            this.pnName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnName.Location = new System.Drawing.Point(270, 21);
            this.pnName.Name = "pnName";
            this.pnName.Size = new System.Drawing.Size(267, 66);
            this.pnName.TabIndex = 9;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdate.Location = new System.Drawing.Point(0, 42);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(267, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Изменить данные";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbNameWriter
            // 
            this.tbNameWriter.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbNameWriter.Location = new System.Drawing.Point(0, 17);
            this.tbNameWriter.Margin = new System.Windows.Forms.Padding(0);
            this.tbNameWriter.Name = "tbNameWriter";
            this.tbNameWriter.Size = new System.Drawing.Size(267, 25);
            this.tbNameWriter.TabIndex = 1;
            // 
            // lbNameWriter
            // 
            this.lbNameWriter.AutoSize = true;
            this.lbNameWriter.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbNameWriter.Location = new System.Drawing.Point(0, 0);
            this.lbNameWriter.Name = "lbNameWriter";
            this.lbNameWriter.Size = new System.Drawing.Size(92, 17);
            this.lbNameWriter.TabIndex = 4;
            this.lbNameWriter.Text = "Имя автора:";
            // 
            // pnPatronymic
            // 
            this.pnPatronymic.Controls.Add(this.btnDelete);
            this.pnPatronymic.Controls.Add(this.tbPatronymicWriter);
            this.pnPatronymic.Controls.Add(this.lbPatronymicWriter);
            this.pnPatronymic.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnPatronymic.Location = new System.Drawing.Point(537, 21);
            this.pnPatronymic.Name = "pnPatronymic";
            this.pnPatronymic.Size = new System.Drawing.Size(260, 66);
            this.pnPatronymic.TabIndex = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.Location = new System.Drawing.Point(0, 42);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(260, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Удалить автора";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbPatronymicWriter
            // 
            this.tbPatronymicWriter.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPatronymicWriter.Location = new System.Drawing.Point(0, 17);
            this.tbPatronymicWriter.Name = "tbPatronymicWriter";
            this.tbPatronymicWriter.Size = new System.Drawing.Size(260, 25);
            this.tbPatronymicWriter.TabIndex = 2;
            // 
            // lbPatronymicWriter
            // 
            this.lbPatronymicWriter.AutoSize = true;
            this.lbPatronymicWriter.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPatronymicWriter.Location = new System.Drawing.Point(0, 0);
            this.lbPatronymicWriter.Name = "lbPatronymicWriter";
            this.lbPatronymicWriter.Size = new System.Drawing.Size(129, 17);
            this.lbPatronymicWriter.TabIndex = 5;
            this.lbPatronymicWriter.Text = "Отчество автора:";
            // 
            // pnSurname
            // 
            this.pnSurname.Controls.Add(this.btnInsert);
            this.pnSurname.Controls.Add(this.tbSurnameWriter);
            this.pnSurname.Controls.Add(this.lbSurnameWriter);
            this.pnSurname.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSurname.Location = new System.Drawing.Point(3, 21);
            this.pnSurname.Name = "pnSurname";
            this.pnSurname.Size = new System.Drawing.Size(267, 66);
            this.pnSurname.TabIndex = 3;
            // 
            // btnInsert
            // 
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInsert.Location = new System.Drawing.Point(0, 42);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(267, 23);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Добавить автора";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // tbSurnameWriter
            // 
            this.tbSurnameWriter.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSurnameWriter.Location = new System.Drawing.Point(0, 17);
            this.tbSurnameWriter.Name = "tbSurnameWriter";
            this.tbSurnameWriter.Size = new System.Drawing.Size(267, 25);
            this.tbSurnameWriter.TabIndex = 0;
            // 
            // lbSurnameWriter
            // 
            this.lbSurnameWriter.AutoSize = true;
            this.lbSurnameWriter.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSurnameWriter.Location = new System.Drawing.Point(0, 0);
            this.lbSurnameWriter.Name = "lbSurnameWriter";
            this.lbSurnameWriter.Size = new System.Drawing.Size(124, 17);
            this.lbSurnameWriter.TabIndex = 3;
            this.lbSurnameWriter.Text = "Фамилия автора:";
            // 
            // gbSearchAndFiltration
            // 
            this.gbSearchAndFiltration.Controls.Add(this.pnSearch);
            this.gbSearchAndFiltration.Controls.Add(this.pnFiltration);
            this.gbSearchAndFiltration.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSearchAndFiltration.Location = new System.Drawing.Point(0, 0);
            this.gbSearchAndFiltration.Name = "gbSearchAndFiltration";
            this.gbSearchAndFiltration.Size = new System.Drawing.Size(800, 48);
            this.gbSearchAndFiltration.TabIndex = 2;
            this.gbSearchAndFiltration.TabStop = false;
            this.gbSearchAndFiltration.Text = "Поиск и фильтрация:";
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.tbSearch);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSearch.Location = new System.Drawing.Point(3, 21);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(661, 32);
            this.pnSearch.TabIndex = 2;
            // 
            // tbSearch
            // 
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSearch.Location = new System.Drawing.Point(0, 0);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(661, 25);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.Text = "Введите данные автора...";
            this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
            this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
            // 
            // pnFiltration
            // 
            this.pnFiltration.Controls.Add(this.chbFiltration);
            this.pnFiltration.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnFiltration.Location = new System.Drawing.Point(664, 21);
            this.pnFiltration.Name = "pnFiltration";
            this.pnFiltration.Size = new System.Drawing.Size(133, 24);
            this.pnFiltration.TabIndex = 3;
            // 
            // chbFiltration
            // 
            this.chbFiltration.AutoSize = true;
            this.chbFiltration.Dock = System.Windows.Forms.DockStyle.Right;
            this.chbFiltration.Location = new System.Drawing.Point(-23, 0);
            this.chbFiltration.Name = "chbFiltration";
            this.chbFiltration.Size = new System.Drawing.Size(156, 24);
            this.chbFiltration.TabIndex = 1;
            this.chbFiltration.Text = "Отфильтровывать";
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
            this.dgvWriterBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWriterBook.Location = new System.Drawing.Point(0, 48);
            this.dgvWriterBook.Name = "dgvWriterBook";
            this.dgvWriterBook.ReadOnly = true;
            this.dgvWriterBook.RowTemplate.Height = 24;
            this.dgvWriterBook.Size = new System.Drawing.Size(800, 304);
            this.dgvWriterBook.TabIndex = 3;
            this.dgvWriterBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWriterBook_CellClick);
            // 
            // WriterBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.dgvWriterBook);
            this.Controls.Add(this.gbManipulationData);
            this.Controls.Add(this.gbSearchAndFiltration);
            this.Controls.Add(this.pnCancel);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "WriterBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторы";
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