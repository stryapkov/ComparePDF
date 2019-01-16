namespace ComparePDF
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddFolder1 = new System.Windows.Forms.Button();
            this.btnAddFolder2 = new System.Windows.Forms.Button();
            this.lb2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.XLSX = new System.Windows.Forms.PictureBox();
            this.DOCX = new System.Windows.Forms.PictureBox();
            this.DOC = new System.Windows.Forms.PictureBox();
            this.PDF = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cbAllFiles = new System.Windows.Forms.CheckBox();
            this.lbInfoCheck = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.XLSX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOCX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PDF)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddFolder1
            // 
            this.btnAddFolder1.Location = new System.Drawing.Point(284, 31);
            this.btnAddFolder1.Name = "btnAddFolder1";
            this.btnAddFolder1.Size = new System.Drawing.Size(30, 23);
            this.btnAddFolder1.TabIndex = 0;
            this.btnAddFolder1.Text = "...";
            this.btnAddFolder1.UseVisualStyleBackColor = true;
            // 
            // btnAddFolder2
            // 
            this.btnAddFolder2.Location = new System.Drawing.Point(284, 77);
            this.btnAddFolder2.Name = "btnAddFolder2";
            this.btnAddFolder2.Size = new System.Drawing.Size(30, 23);
            this.btnAddFolder2.TabIndex = 1;
            this.btnAddFolder2.Text = "...";
            this.btnAddFolder2.UseVisualStyleBackColor = true;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(6, 61);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(252, 13);
            this.lb2.TabIndex = 2;
            this.lb2.Text = "Путь к папке с которой хотите сравнить файлы:";
            // 
            // progressBar1
            // 
            this.progressBar1.Enabled = false;
            this.progressBar1.Location = new System.Drawing.Point(6, 321);
            this.progressBar1.Maximum = 0;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(399, 38);
            this.progressBar1.Step = 30;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.btnSearch.Location = new System.Drawing.Point(360, 127);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 37);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(272, 20);
            this.textBox1.TabIndex = 7;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Control;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.Location = new System.Drawing.Point(6, 168);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(560, 147);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Копии файлов";
            this.columnHeader1.Width = 560;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            this.columnHeader2.Width = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(272, 20);
            this.textBox2.TabIndex = 9;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(6, 15);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(226, 13);
            this.lb1.TabIndex = 10;
            this.lb1.Text = "Путь к папке для сравнения содержимого:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Укажите тип файлов для поиска копий:";
            // 
            // XLSX
            // 
            this.XLSX.Image = global::ComparePDF.Properties.Resources.xlsx;
            this.XLSX.Location = new System.Drawing.Point(522, 35);
            this.XLSX.Name = "XLSX";
            this.XLSX.Size = new System.Drawing.Size(44, 50);
            this.XLSX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.XLSX.TabIndex = 15;
            this.XLSX.TabStop = false;
            // 
            // DOCX
            // 
            this.DOCX.Image = global::ComparePDF.Properties.Resources.docx;
            this.DOCX.Location = new System.Drawing.Point(471, 35);
            this.DOCX.Name = "DOCX";
            this.DOCX.Size = new System.Drawing.Size(45, 50);
            this.DOCX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DOCX.TabIndex = 14;
            this.DOCX.TabStop = false;
            // 
            // DOC
            // 
            this.DOC.Image = global::ComparePDF.Properties.Resources.doc;
            this.DOC.Location = new System.Drawing.Point(418, 35);
            this.DOC.Name = "DOC";
            this.DOC.Size = new System.Drawing.Size(47, 50);
            this.DOC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DOC.TabIndex = 13;
            this.DOC.TabStop = false;
            // 
            // PDF
            // 
            this.PDF.Image = global::ComparePDF.Properties.Resources.pdf;
            this.PDF.Location = new System.Drawing.Point(360, 35);
            this.PDF.Name = "PDF";
            this.PDF.Size = new System.Drawing.Size(52, 50);
            this.PDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PDF.TabIndex = 12;
            this.PDF.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(411, 321);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 38);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Сохранить\r\n  список";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(493, 321);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 37);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Сбросить";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // cbAllFiles
            // 
            this.cbAllFiles.AutoSize = true;
            this.cbAllFiles.Location = new System.Drawing.Point(360, 91);
            this.cbAllFiles.Name = "cbAllFiles";
            this.cbAllFiles.Size = new System.Drawing.Size(164, 30);
            this.cbAllFiles.TabIndex = 18;
            this.cbAllFiles.Text = "Писк всех файлов и папок \r\nс одинаковым названием";
            this.cbAllFiles.UseVisualStyleBackColor = true;
            // 
            // lbInfoCheck
            // 
            this.lbInfoCheck.AutoSize = true;
            this.lbInfoCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lbInfoCheck.Location = new System.Drawing.Point(234, 144);
            this.lbInfoCheck.Name = "lbInfoCheck";
            this.lbInfoCheck.Size = new System.Drawing.Size(44, 20);
            this.lbInfoCheck.TabIndex = 19;
            this.lbInfoCheck.Text = "PDF";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb3.Location = new System.Drawing.Point(12, 115);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(118, 18);
            this.lb3.TabIndex = 20;
            this.lb3.Text = "Найдено копий:";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCount.Location = new System.Drawing.Point(157, 104);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(30, 31);
            this.lbCount.TabIndex = 21;
            this.lbCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Тип файлов для поиска";
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.btnStop.Location = new System.Drawing.Point(471, 127);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(95, 37);
            this.btnStop.TabIndex = 23;
            this.btnStop.Text = "Стоп";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(578, 368);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lbInfoCheck);
            this.Controls.Add(this.cbAllFiles);
            this.Controls.Add(this.XLSX);
            this.Controls.Add(this.DOCX);
            this.Controls.Add(this.DOC);
            this.Controls.Add(this.PDF);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.btnAddFolder2);
            this.Controls.Add(this.btnAddFolder1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Поиск копий";
            ((System.ComponentModel.ISupportInitialize)(this.XLSX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOCX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PDF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddFolder1;
        private System.Windows.Forms.Button btnAddFolder2;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PDF;
        private System.Windows.Forms.PictureBox DOC;
        private System.Windows.Forms.PictureBox DOCX;
        private System.Windows.Forms.PictureBox XLSX;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox cbAllFiles;
        private System.Windows.Forms.Label lbInfoCheck;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStop;
    }
}

