namespace Library
{
    partial class FormationCardAndFormularForm
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
            this.btnCreateWordFormular = new System.Windows.Forms.Button();
            this.btnCreatePdfFormular = new System.Windows.Forms.Button();
            this.btnPdfRegistrationCard = new System.Windows.Forms.Button();
            this.btnCreateWordRegistrationCard = new System.Windows.Forms.Button();
            this.dgvRegistrationCard = new System.Windows.Forms.DataGridView();
            this.pnCancel.SuspendLayout();
            this.gbCreateDocument.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrationCard)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(1036, 24);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Выберите читателя";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnCancel
            // 
            this.pnCancel.Controls.Add(this.btnExit);
            this.pnCancel.Controls.Add(this.btnError);
            this.pnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCancel.Location = new System.Drawing.Point(0, 484);
            this.pnCancel.Name = "pnCancel";
            this.pnCancel.Size = new System.Drawing.Size(1036, 36);
            this.pnCancel.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Location = new System.Drawing.Point(917, 0);
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
            this.gbCreateDocument.Controls.Add(this.btnCreateWordFormular);
            this.gbCreateDocument.Controls.Add(this.btnCreatePdfFormular);
            this.gbCreateDocument.Controls.Add(this.btnPdfRegistrationCard);
            this.gbCreateDocument.Controls.Add(this.btnCreateWordRegistrationCard);
            this.gbCreateDocument.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbCreateDocument.Location = new System.Drawing.Point(0, 374);
            this.gbCreateDocument.Name = "gbCreateDocument";
            this.gbCreateDocument.Size = new System.Drawing.Size(1036, 110);
            this.gbCreateDocument.TabIndex = 5;
            this.gbCreateDocument.TabStop = false;
            this.gbCreateDocument.Text = "Формирование документов";
            // 
            // btnCreateWordFormular
            // 
            this.btnCreateWordFormular.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCreateWordFormular.Location = new System.Drawing.Point(745, 19);
            this.btnCreateWordFormular.Name = "btnCreateWordFormular";
            this.btnCreateWordFormular.Size = new System.Drawing.Size(144, 88);
            this.btnCreateWordFormular.TabIndex = 3;
            this.btnCreateWordFormular.Text = "Сформировать формуляр читателя в формате .pdf";
            this.btnCreateWordFormular.UseVisualStyleBackColor = true;
            // 
            // btnCreatePdfFormular
            // 
            this.btnCreatePdfFormular.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCreatePdfFormular.Location = new System.Drawing.Point(889, 19);
            this.btnCreatePdfFormular.Name = "btnCreatePdfFormular";
            this.btnCreatePdfFormular.Size = new System.Drawing.Size(144, 88);
            this.btnCreatePdfFormular.TabIndex = 2;
            this.btnCreatePdfFormular.Text = "Сформировать формуляр читателя в формате .docx";
            this.btnCreatePdfFormular.UseVisualStyleBackColor = true;
            // 
            // btnPdfRegistrationCard
            // 
            this.btnPdfRegistrationCard.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPdfRegistrationCard.Location = new System.Drawing.Point(147, 19);
            this.btnPdfRegistrationCard.Name = "btnPdfRegistrationCard";
            this.btnPdfRegistrationCard.Size = new System.Drawing.Size(144, 88);
            this.btnPdfRegistrationCard.TabIndex = 1;
            this.btnPdfRegistrationCard.Text = "Сформировать регистрационную карточку читателя в формате *.pdf";
            this.btnPdfRegistrationCard.UseVisualStyleBackColor = true;
            this.btnPdfRegistrationCard.Click += new System.EventHandler(this.btnPdfRegistrationCard_Click);
            // 
            // btnCreateWordRegistrationCard
            // 
            this.btnCreateWordRegistrationCard.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCreateWordRegistrationCard.Location = new System.Drawing.Point(3, 19);
            this.btnCreateWordRegistrationCard.Name = "btnCreateWordRegistrationCard";
            this.btnCreateWordRegistrationCard.Size = new System.Drawing.Size(144, 88);
            this.btnCreateWordRegistrationCard.TabIndex = 0;
            this.btnCreateWordRegistrationCard.Text = "Сформировать регистрационную карточку читателя в формате *.docx";
            this.btnCreateWordRegistrationCard.UseVisualStyleBackColor = true;
            this.btnCreateWordRegistrationCard.Click += new System.EventHandler(this.btnCreateWordRegistrationCard_Click);
            // 
            // dgvRegistrationCard
            // 
            this.dgvRegistrationCard.AllowUserToAddRows = false;
            this.dgvRegistrationCard.AllowUserToDeleteRows = false;
            this.dgvRegistrationCard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegistrationCard.BackgroundColor = System.Drawing.Color.White;
            this.dgvRegistrationCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistrationCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegistrationCard.Location = new System.Drawing.Point(0, 24);
            this.dgvRegistrationCard.MultiSelect = false;
            this.dgvRegistrationCard.Name = "dgvRegistrationCard";
            this.dgvRegistrationCard.ReadOnly = true;
            this.dgvRegistrationCard.RowTemplate.Height = 24;
            this.dgvRegistrationCard.Size = new System.Drawing.Size(1036, 350);
            this.dgvRegistrationCard.TabIndex = 6;
            // 
            // FormationCardAndFormularForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1036, 520);
            this.Controls.Add(this.dgvRegistrationCard);
            this.Controls.Add(this.gbCreateDocument);
            this.Controls.Add(this.pnCancel);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FormationCardAndFormularForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormationCardAndFormularForm";
            this.Load += new System.EventHandler(this.FormationCardAndFormularForm_Load);
            this.pnCancel.ResumeLayout(false);
            this.gbCreateDocument.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrationCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnError;
        private System.Windows.Forms.GroupBox gbCreateDocument;
        private System.Windows.Forms.Button btnCreateWordFormular;
        private System.Windows.Forms.Button btnCreatePdfFormular;
        private System.Windows.Forms.Button btnPdfRegistrationCard;
        private System.Windows.Forms.Button btnCreateWordRegistrationCard;
        private System.Windows.Forms.DataGridView dgvRegistrationCard;
    }
}