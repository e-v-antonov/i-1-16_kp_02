﻿namespace Library
{
    partial class GenreBookForm
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
            this.ltbGenre = new System.Windows.Forms.ListBox();
            this.gbManipulationData = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.lbNameGenre = new System.Windows.Forms.Label();
            this.pnCancel = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnError = new System.Windows.Forms.Button();
            this.gbSearchGenre = new System.Windows.Forms.GroupBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.gbListGenre = new System.Windows.Forms.GroupBox();
            this.gbManipulationData.SuspendLayout();
            this.pnCancel.SuspendLayout();
            this.gbSearchGenre.SuspendLayout();
            this.gbListGenre.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltbGenre
            // 
            this.ltbGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ltbGenre.FormattingEnabled = true;
            this.ltbGenre.ItemHeight = 17;
            this.ltbGenre.Location = new System.Drawing.Point(3, 21);
            this.ltbGenre.Name = "ltbGenre";
            this.ltbGenre.Size = new System.Drawing.Size(483, 248);
            this.ltbGenre.TabIndex = 0;
            this.ltbGenre.SelectedIndexChanged += new System.EventHandler(this.ltbGenre_SelectedIndexChanged);
            // 
            // gbManipulationData
            // 
            this.gbManipulationData.Controls.Add(this.btnDelete);
            this.gbManipulationData.Controls.Add(this.btnUpdate);
            this.gbManipulationData.Controls.Add(this.btnInsert);
            this.gbManipulationData.Controls.Add(this.tbGenre);
            this.gbManipulationData.Controls.Add(this.lbNameGenre);
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
            this.btnDelete.Text = "Удалить жанр";
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
            this.btnInsert.Text = "Добавить новый жанр";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // tbGenre
            // 
            this.tbGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbGenre.Location = new System.Drawing.Point(3, 38);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(483, 25);
            this.tbGenre.TabIndex = 0;
            // 
            // lbNameGenre
            // 
            this.lbNameGenre.AutoSize = true;
            this.lbNameGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbNameGenre.Location = new System.Drawing.Point(3, 21);
            this.lbNameGenre.Name = "lbNameGenre";
            this.lbNameGenre.Size = new System.Drawing.Size(122, 17);
            this.lbNameGenre.TabIndex = 4;
            this.lbNameGenre.Text = "Название жанра:";
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
            // gbSearchGenre
            // 
            this.gbSearchGenre.Controls.Add(this.tbSearch);
            this.gbSearchGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSearchGenre.Location = new System.Drawing.Point(0, 0);
            this.gbSearchGenre.Name = "gbSearchGenre";
            this.gbSearchGenre.Size = new System.Drawing.Size(489, 48);
            this.gbSearchGenre.TabIndex = 3;
            this.gbSearchGenre.TabStop = false;
            this.gbSearchGenre.Text = "Поиск жанра:";
            // 
            // tbSearch
            // 
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSearch.Location = new System.Drawing.Point(3, 21);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(483, 25);
            this.tbSearch.TabIndex = 4;
            this.tbSearch.Text = "Введите название жанра...";
            this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
            this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
            // 
            // gbListGenre
            // 
            this.gbListGenre.Controls.Add(this.ltbGenre);
            this.gbListGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbListGenre.Location = new System.Drawing.Point(0, 48);
            this.gbListGenre.Name = "gbListGenre";
            this.gbListGenre.Size = new System.Drawing.Size(489, 272);
            this.gbListGenre.TabIndex = 4;
            this.gbListGenre.TabStop = false;
            this.gbListGenre.Text = "Список жанров:";
            // 
            // GenreBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(489, 484);
            this.Controls.Add(this.gbListGenre);
            this.Controls.Add(this.gbManipulationData);
            this.Controls.Add(this.pnCancel);
            this.Controls.Add(this.gbSearchGenre);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "GenreBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Жанры книг";
            this.Load += new System.EventHandler(this.GenreBookForm_Load);
            this.gbManipulationData.ResumeLayout(false);
            this.gbManipulationData.PerformLayout();
            this.pnCancel.ResumeLayout(false);
            this.gbSearchGenre.ResumeLayout(false);
            this.gbSearchGenre.PerformLayout();
            this.gbListGenre.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ltbGenre;
        private System.Windows.Forms.GroupBox gbManipulationData;
        private System.Windows.Forms.Panel pnCancel;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnError;
        private System.Windows.Forms.Label lbNameGenre;
        private System.Windows.Forms.GroupBox gbSearchGenre;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.GroupBox gbListGenre;
        public System.Windows.Forms.Button btnInsert;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnDelete;
    }
}