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
            this.ltbPublishing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltbPublishing.FormattingEnabled = true;
            this.ltbPublishing.ItemHeight = 17;
            this.ltbPublishing.Location = new System.Drawing.Point(3, 21);
            this.ltbPublishing.Name = "ltbPublishing";
            this.ltbPublishing.Size = new System.Drawing.Size(483, 248);
            this.ltbPublishing.TabIndex = 0;
            this.ltbPublishing.Click += new System.EventHandler(this.ltbPublishing_Click);
            this.ltbPublishing.SelectedIndexChanged += new System.EventHandler(this.ltbPublishing_SelectedIndexChanged);
            // 
            // gbManipulationData
            // 
            this.gbManipulationData.Controls.Add(this.btnDelete);
            this.gbManipulationData.Controls.Add(this.btnUpdate);
            this.gbManipulationData.Controls.Add(this.btnInsert);
            this.gbManipulationData.Controls.Add(this.tbPublishing);
            this.gbManipulationData.Controls.Add(this.lbNamePublishing);
            this.gbManipulationData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbManipulationData.Location = new System.Drawing.Point(0, 320);
            this.gbManipulationData.Name = "gbManipulationData";
            this.gbManipulationData.Size = new System.Drawing.Size(489, 128);
            this.gbManipulationData.TabIndex = 1;
            this.gbManipulationData.TabStop = false;
            this.gbManipulationData.Text = "Манипулирование данными:";
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.Location = new System.Drawing.Point(3, 111);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(483, 24);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Удалить издательство";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdate.Location = new System.Drawing.Point(3, 87);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(483, 24);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Изменить данные";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInsert.Location = new System.Drawing.Point(3, 63);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(483, 24);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Добавить новое издательство";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // tbPublishing
            // 
            this.tbPublishing.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPublishing.Location = new System.Drawing.Point(3, 38);
            this.tbPublishing.Name = "tbPublishing";
            this.tbPublishing.Size = new System.Drawing.Size(483, 25);
            this.tbPublishing.TabIndex = 0;
            // 
            // lbNamePublishing
            // 
            this.lbNamePublishing.AutoSize = true;
            this.lbNamePublishing.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbNamePublishing.Location = new System.Drawing.Point(3, 21);
            this.lbNamePublishing.Name = "lbNamePublishing";
            this.lbNamePublishing.Size = new System.Drawing.Size(175, 17);
            this.lbNamePublishing.TabIndex = 4;
            this.lbNamePublishing.Text = "Название издательства:";
            // 
            // pnCancel
            // 
            this.pnCancel.Controls.Add(this.btnExit);
            this.pnCancel.Controls.Add(this.btnError);
            this.pnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCancel.Location = new System.Drawing.Point(0, 448);
            this.pnCancel.Name = "pnCancel";
            this.pnCancel.Size = new System.Drawing.Size(489, 36);
            this.pnCancel.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Location = new System.Drawing.Point(370, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 36);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Закрыть";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.btnError.Click += new System.EventHandler(this.btnError_Click);
            // 
            // gbSearchPublishing
            // 
            this.gbSearchPublishing.Controls.Add(this.tbSearch);
            this.gbSearchPublishing.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSearchPublishing.Location = new System.Drawing.Point(0, 0);
            this.gbSearchPublishing.Name = "gbSearchPublishing";
            this.gbSearchPublishing.Size = new System.Drawing.Size(489, 48);
            this.gbSearchPublishing.TabIndex = 3;
            this.gbSearchPublishing.TabStop = false;
            this.gbSearchPublishing.Text = "Поиск издательства:";
            // 
            // tbSearch
            // 
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSearch.Location = new System.Drawing.Point(3, 21);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(483, 25);
            this.tbSearch.TabIndex = 4;
            this.tbSearch.Text = "Введите название издательства...";
            this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
            this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
            // 
            // gbListPublishing
            // 
            this.gbListPublishing.Controls.Add(this.ltbPublishing);
            this.gbListPublishing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbListPublishing.Location = new System.Drawing.Point(0, 48);
            this.gbListPublishing.Name = "gbListPublishing";
            this.gbListPublishing.Size = new System.Drawing.Size(489, 272);
            this.gbListPublishing.TabIndex = 4;
            this.gbListPublishing.TabStop = false;
            this.gbListPublishing.Text = "Список издательств:";
            // 
            // PublishingBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(489, 484);
            this.Controls.Add(this.gbListPublishing);
            this.Controls.Add(this.gbManipulationData);
            this.Controls.Add(this.pnCancel);
            this.Controls.Add(this.gbSearchPublishing);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "PublishingBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Книжные издательства";
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
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnError;
        private System.Windows.Forms.Label lbNamePublishing;
        private System.Windows.Forms.GroupBox gbSearchPublishing;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.GroupBox gbListPublishing;
    }
}