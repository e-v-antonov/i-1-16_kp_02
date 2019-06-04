namespace Library
{
    partial class UsersForm
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
            this.pnFiltration = new System.Windows.Forms.Panel();
            this.chbFiltration = new System.Windows.Forms.CheckBox();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.pnCancel = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnError = new System.Windows.Forms.Button();
            this.gbManipulationData = new System.Windows.Forms.GroupBox();
            this.tbPatronymic = new System.Windows.Forms.TextBox();
            this.lbPatronymic = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.lbSurname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbSearchAndFiltration.SuspendLayout();
            this.pnFiltration.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.pnCancel.SuspendLayout();
            this.gbManipulationData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSearchAndFiltration
            // 
            this.gbSearchAndFiltration.Controls.Add(this.pnFiltration);
            this.gbSearchAndFiltration.Controls.Add(this.pnSearch);
            this.gbSearchAndFiltration.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSearchAndFiltration.Location = new System.Drawing.Point(0, 0);
            this.gbSearchAndFiltration.Name = "gbSearchAndFiltration";
            this.gbSearchAndFiltration.Size = new System.Drawing.Size(1072, 48);
            this.gbSearchAndFiltration.TabIndex = 2;
            this.gbSearchAndFiltration.TabStop = false;
            this.gbSearchAndFiltration.Text = "Поиск и фильтрация:";
            // 
            // pnFiltration
            // 
            this.pnFiltration.Controls.Add(this.chbFiltration);
            this.pnFiltration.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnFiltration.Location = new System.Drawing.Point(928, 19);
            this.pnFiltration.Name = "pnFiltration";
            this.pnFiltration.Size = new System.Drawing.Size(128, 26);
            this.pnFiltration.TabIndex = 1;
            // 
            // chbFiltration
            // 
            this.chbFiltration.AutoSize = true;
            this.chbFiltration.Dock = System.Windows.Forms.DockStyle.Right;
            this.chbFiltration.Location = new System.Drawing.Point(-24, 0);
            this.chbFiltration.Name = "chbFiltration";
            this.chbFiltration.Size = new System.Drawing.Size(152, 26);
            this.chbFiltration.TabIndex = 0;
            this.chbFiltration.Text = "Отфильтровывать";
            this.chbFiltration.UseVisualStyleBackColor = true;
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.tbSearch);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSearch.Location = new System.Drawing.Point(3, 19);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(925, 26);
            this.pnSearch.TabIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSearch.Location = new System.Drawing.Point(0, 0);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(925, 23);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.Text = "Введите данные регистрационной карточки...";
            // 
            // pnCancel
            // 
            this.pnCancel.Controls.Add(this.btnExit);
            this.pnCancel.Controls.Add(this.btnError);
            this.pnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCancel.Location = new System.Drawing.Point(0, 434);
            this.pnCancel.Name = "pnCancel";
            this.pnCancel.Size = new System.Drawing.Size(1072, 36);
            this.pnCancel.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Location = new System.Drawing.Point(953, 0);
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
            // gbManipulationData
            // 
            this.gbManipulationData.Controls.Add(this.button4);
            this.gbManipulationData.Controls.Add(this.button3);
            this.gbManipulationData.Controls.Add(this.button2);
            this.gbManipulationData.Controls.Add(this.button1);
            this.gbManipulationData.Controls.Add(this.comboBox1);
            this.gbManipulationData.Controls.Add(this.label4);
            this.gbManipulationData.Controls.Add(this.textBox3);
            this.gbManipulationData.Controls.Add(this.label3);
            this.gbManipulationData.Controls.Add(this.textBox2);
            this.gbManipulationData.Controls.Add(this.label2);
            this.gbManipulationData.Controls.Add(this.textBox1);
            this.gbManipulationData.Controls.Add(this.label1);
            this.gbManipulationData.Controls.Add(this.tbPatronymic);
            this.gbManipulationData.Controls.Add(this.lbPatronymic);
            this.gbManipulationData.Controls.Add(this.tbName);
            this.gbManipulationData.Controls.Add(this.lbName);
            this.gbManipulationData.Controls.Add(this.tbSurname);
            this.gbManipulationData.Controls.Add(this.lbSurname);
            this.gbManipulationData.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbManipulationData.Location = new System.Drawing.Point(0, 48);
            this.gbManipulationData.Name = "gbManipulationData";
            this.gbManipulationData.Size = new System.Drawing.Size(264, 386);
            this.gbManipulationData.TabIndex = 4;
            this.gbManipulationData.TabStop = false;
            this.gbManipulationData.Text = "Манипулирование данными:";
            // 
            // tbPatronymic
            // 
            this.tbPatronymic.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPatronymic.Location = new System.Drawing.Point(3, 113);
            this.tbPatronymic.Name = "tbPatronymic";
            this.tbPatronymic.Size = new System.Drawing.Size(258, 23);
            this.tbPatronymic.TabIndex = 5;
            // 
            // lbPatronymic
            // 
            this.lbPatronymic.AutoSize = true;
            this.lbPatronymic.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPatronymic.Location = new System.Drawing.Point(3, 97);
            this.lbPatronymic.Name = "lbPatronymic";
            this.lbPatronymic.Size = new System.Drawing.Size(166, 16);
            this.lbPatronymic.TabIndex = 4;
            this.lbPatronymic.Text = "Отчество пользователя";
            // 
            // tbName
            // 
            this.tbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbName.Location = new System.Drawing.Point(3, 74);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(258, 23);
            this.tbName.TabIndex = 3;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbName.Location = new System.Drawing.Point(3, 58);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(132, 16);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Имя пользователя";
            // 
            // tbSurname
            // 
            this.tbSurname.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSurname.Location = new System.Drawing.Point(3, 35);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(258, 23);
            this.tbSurname.TabIndex = 1;
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSurname.Location = new System.Drawing.Point(3, 19);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(165, 16);
            this.lbSurname.TabIndex = 0;
            this.lbSurname.Text = "Фамилия пользователя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Логин";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(3, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 23);
            this.textBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(3, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Пароль";
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Location = new System.Drawing.Point(3, 191);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(258, 23);
            this.textBox2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(3, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Повторите пароль";
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox3.Location = new System.Drawing.Point(3, 230);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(258, 23);
            this.textBox3.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(3, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Должность";
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 269);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(258, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(3, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Редактирование данных должностей";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(3, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Добавить пользователя";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(3, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(258, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Изменить данные";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(3, 362);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(258, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Удалить пользователя";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(264, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(808, 386);
            this.dataGridView1.TabIndex = 5;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1072, 470);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbManipulationData);
            this.Controls.Add(this.pnCancel);
            this.Controls.Add(this.gbSearchAndFiltration);
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsersForm";
            this.gbSearchAndFiltration.ResumeLayout(false);
            this.pnFiltration.ResumeLayout(false);
            this.pnFiltration.PerformLayout();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.pnCancel.ResumeLayout(false);
            this.gbManipulationData.ResumeLayout(false);
            this.gbManipulationData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearchAndFiltration;
        private System.Windows.Forms.Panel pnFiltration;
        private System.Windows.Forms.CheckBox chbFiltration;
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Panel pnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnError;
        private System.Windows.Forms.GroupBox gbManipulationData;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPatronymic;
        private System.Windows.Forms.Label lbPatronymic;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}