namespace PostLoading
{
    partial class FormLoadingWizard
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtListName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnClearFilesList = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnBrowseFiles = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.numStartRow = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStartRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabControl1.Location = new System.Drawing.Point(-3, -24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(486, 290);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtListName);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(478, 261);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 105);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "عنوان دوره یا ماه:";
            // 
            // txtListName
            // 
            this.txtListName.Location = new System.Drawing.Point(82, 102);
            this.txtListName.Name = "txtListName";
            this.txtListName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtListName.Size = new System.Drawing.Size(226, 23);
            this.txtListName.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnClearFilesList);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.btnBrowseFiles);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(478, 261);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnClearFilesList
            // 
            this.btnClearFilesList.Location = new System.Drawing.Point(16, 37);
            this.btnClearFilesList.Name = "btnClearFilesList";
            this.btnClearFilesList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClearFilesList.Size = new System.Drawing.Size(126, 24);
            this.btnClearFilesList.TabIndex = 2;
            this.btnClearFilesList.Text = "پاک کردن لیست";
            this.btnClearFilesList.UseVisualStyleBackColor = true;
            this.btnClearFilesList.Click += new System.EventHandler(this.btnClearFilesList_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(16, 67);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(446, 132);
            this.listBox1.TabIndex = 1;
            // 
            // btnBrowseFiles
            // 
            this.btnBrowseFiles.Location = new System.Drawing.Point(349, 37);
            this.btnBrowseFiles.Name = "btnBrowseFiles";
            this.btnBrowseFiles.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBrowseFiles.Size = new System.Drawing.Size(113, 24);
            this.btnBrowseFiles.TabIndex = 0;
            this.btnBrowseFiles.Text = "انتخاب فایلها...";
            this.btnBrowseFiles.UseVisualStyleBackColor = true;
            this.btnBrowseFiles.Click += new System.EventHandler(this.btnBrowseFiles_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.progressBar1);
            this.tabPage3.Controls.Add(this.numStartRow);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(478, 261);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(112, 184);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(273, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // numStartRow
            // 
            this.numStartRow.Location = new System.Drawing.Point(125, 101);
            this.numStartRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numStartRow.Name = "numStartRow";
            this.numStartRow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numStartRow.Size = new System.Drawing.Size(62, 23);
            this.numStartRow.TabIndex = 1;
            this.numStartRow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numStartRow.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(193, 88);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(175, 53);
            this.label2.TabIndex = 0;
            this.label2.Text = "شماره سطر شروع جدول اطلاعات در اکسل با در نظر گرفتن ستون‏های عناوین:";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(286, 277);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(71, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "بعدی";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(211, 277);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(71, 23);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.Text = "قبلی";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(137, 277);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "لغو";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Excel 2007, 2010, 2013, 2017|*.xlsx";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(27, 202);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(435, 56);
            this.label3.TabIndex = 3;
            this.label3.Text = "فرمت فایلهای اکسل باید از فرمت 2007 به بعد باشد\r\nاگر فرمت فایلها مربوط به قبل از " +
    "2007 است با استفاده از نرم‏افزار اکسل آن را به فرمت بالاتر تبدیل نمایید";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormLoadingWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 312);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLoadingWizard";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "بارگذاری لیست جدید...";
            this.Load += new System.EventHandler(this.FormLoadingWizard_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numStartRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnBrowseFiles;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnClearFilesList;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtListName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numStartRow;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
    }
}