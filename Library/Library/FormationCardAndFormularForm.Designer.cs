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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormationCardAndFormularForm));
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnCancel = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnError = new System.Windows.Forms.Button();
            this.gbCreateDocument = new System.Windows.Forms.GroupBox();
            this.btnCreatePdfFormular = new System.Windows.Forms.Button();
            this.btnCreateWordFormular = new System.Windows.Forms.Button();
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
            this.gbCreateDocument.Controls.Add(this.btnCreatePdfFormular);
            this.gbCreateDocument.Controls.Add(this.btnCreateWordFormular);
            this.gbCreateDocument.Controls.Add(this.btnPdfRegistrationCard);
            this.gbCreateDocument.Controls.Add(this.btnCreateWordRegistrationCard);
            this.gbCreateDocument.Name = "gbCreateDocument";
            this.gbCreateDocument.TabStop = false;
            // 
            // btnCreatePdfFormular
            // 
            resources.ApplyResources(this.btnCreatePdfFormular, "btnCreatePdfFormular");
            this.btnCreatePdfFormular.Name = "btnCreatePdfFormular";
            this.btnCreatePdfFormular.UseVisualStyleBackColor = true;
            this.btnCreatePdfFormular.Click += new System.EventHandler(this.btnCreatePdfFormular_Click);
            // 
            // btnCreateWordFormular
            // 
            resources.ApplyResources(this.btnCreateWordFormular, "btnCreateWordFormular");
            this.btnCreateWordFormular.Name = "btnCreateWordFormular";
            this.btnCreateWordFormular.UseVisualStyleBackColor = true;
            this.btnCreateWordFormular.Click += new System.EventHandler(this.btnCreateWordFormular_Click);
            // 
            // btnPdfRegistrationCard
            // 
            resources.ApplyResources(this.btnPdfRegistrationCard, "btnPdfRegistrationCard");
            this.btnPdfRegistrationCard.Name = "btnPdfRegistrationCard";
            this.btnPdfRegistrationCard.UseVisualStyleBackColor = true;
            this.btnPdfRegistrationCard.Click += new System.EventHandler(this.btnPdfRegistrationCard_Click);
            // 
            // btnCreateWordRegistrationCard
            // 
            resources.ApplyResources(this.btnCreateWordRegistrationCard, "btnCreateWordRegistrationCard");
            this.btnCreateWordRegistrationCard.Name = "btnCreateWordRegistrationCard";
            this.btnCreateWordRegistrationCard.UseVisualStyleBackColor = true;
            this.btnCreateWordRegistrationCard.Click += new System.EventHandler(this.btnCreateWordRegistrationCard_Click);
            // 
            // dgvRegistrationCard
            // 
            resources.ApplyResources(this.dgvRegistrationCard, "dgvRegistrationCard");
            this.dgvRegistrationCard.AllowUserToAddRows = false;
            this.dgvRegistrationCard.AllowUserToDeleteRows = false;
            this.dgvRegistrationCard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegistrationCard.BackgroundColor = System.Drawing.Color.White;
            this.dgvRegistrationCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistrationCard.MultiSelect = false;
            this.dgvRegistrationCard.Name = "dgvRegistrationCard";
            this.dgvRegistrationCard.ReadOnly = true;
            this.dgvRegistrationCard.RowTemplate.Height = 24;
            // 
            // FormationCardAndFormularForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvRegistrationCard);
            this.Controls.Add(this.gbCreateDocument);
            this.Controls.Add(this.pnCancel);
            this.Controls.Add(this.lbTitle);
            this.Name = "FormationCardAndFormularForm";
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
        private System.Windows.Forms.Button btnCreatePdfFormular;
        private System.Windows.Forms.Button btnCreateWordFormular;
        private System.Windows.Forms.Button btnPdfRegistrationCard;
        private System.Windows.Forms.Button btnCreateWordRegistrationCard;
        private System.Windows.Forms.DataGridView dgvRegistrationCard;
    }
}