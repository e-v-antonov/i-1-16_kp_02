namespace Library
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenreBookForm));
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
            resources.ApplyResources(this.ltbGenre, "ltbGenre");
            this.ltbGenre.FormattingEnabled = true;
            this.ltbGenre.Name = "ltbGenre";
            this.ltbGenre.SelectedIndexChanged += new System.EventHandler(this.ltbGenre_SelectedIndexChanged);
            // 
            // gbManipulationData
            // 
            resources.ApplyResources(this.gbManipulationData, "gbManipulationData");
            this.gbManipulationData.Controls.Add(this.btnDelete);
            this.gbManipulationData.Controls.Add(this.btnUpdate);
            this.gbManipulationData.Controls.Add(this.btnInsert);
            this.gbManipulationData.Controls.Add(this.tbGenre);
            this.gbManipulationData.Controls.Add(this.lbNameGenre);
            this.gbManipulationData.Name = "gbManipulationData";
            this.gbManipulationData.TabStop = false;
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
            // tbGenre
            // 
            resources.ApplyResources(this.tbGenre, "tbGenre");
            this.tbGenre.Name = "tbGenre";
            // 
            // lbNameGenre
            // 
            resources.ApplyResources(this.lbNameGenre, "lbNameGenre");
            this.lbNameGenre.Name = "lbNameGenre";
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
            // gbSearchGenre
            // 
            resources.ApplyResources(this.gbSearchGenre, "gbSearchGenre");
            this.gbSearchGenre.Controls.Add(this.tbSearch);
            this.gbSearchGenre.Name = "gbSearchGenre";
            this.gbSearchGenre.TabStop = false;
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
            // gbListGenre
            // 
            resources.ApplyResources(this.gbListGenre, "gbListGenre");
            this.gbListGenre.Controls.Add(this.ltbGenre);
            this.gbListGenre.Name = "gbListGenre";
            this.gbListGenre.TabStop = false;
            // 
            // GenreBookForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbListGenre);
            this.Controls.Add(this.gbManipulationData);
            this.Controls.Add(this.pnCancel);
            this.Controls.Add(this.gbSearchGenre);
            this.Name = "GenreBookForm";
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