namespace PostLoading
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.cmbDore = new System.Windows.Forms.ComboBox();
            this.doreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postDataSet = new PostLoading.PostDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.doreTableAdapter = new PostLoading.PostDataSetTableAdapters.DoreTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colDetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoreId_FK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_radif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_marsoole_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_receiver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_detail_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hagh_maghar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_destination_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_source_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_vazn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_mablagh_ezhar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_haghe_bime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_maliat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hagh_sahm_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hagh_sahm_t_gh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.txtSearchFilter = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelRowCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnLoading = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.doreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDore
            // 
            this.cmbDore.DataSource = this.doreBindingSource;
            this.cmbDore.DisplayMember = "doreName";
            this.cmbDore.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbDore.FormattingEnabled = true;
            this.cmbDore.ItemHeight = 16;
            this.cmbDore.Location = new System.Drawing.Point(399, 36);
            this.cmbDore.Name = "cmbDore";
            this.cmbDore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbDore.Size = new System.Drawing.Size(370, 24);
            this.cmbDore.TabIndex = 2;
            this.cmbDore.ValueMember = "doreId";
            // 
            // doreBindingSource
            // 
            this.doreBindingSource.DataMember = "Dore";
            this.doreBindingSource.DataSource = this.postDataSet;
            // 
            // postDataSet
            // 
            this.postDataSet.DataSetName = "PostDataSet";
            this.postDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(775, 39);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "عنوان دوره یا ماه:";
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnShow.Location = new System.Drawing.Point(306, 36);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(87, 26);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "نمایش";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // doreTableAdapter
            // 
            this.doreTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDetailId,
            this.colDoreId_FK,
            this.col_radif,
            this.col_marsoole_id,
            this.col_sender,
            this.col_receiver,
            this.col_destination,
            this.col_detail_time,
            this.col_hagh_maghar,
            this.col_destination_code,
            this.col_source_code,
            this.col_d,
            this.col_vazn,
            this.col_mablagh_ezhar,
            this.col_haghe_bime,
            this.col_maliat,
            this.col_hagh_sahm_p,
            this.col_hagh_sahm_t_gh,
            this.col_price});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 139);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(1169, 398);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // colDetailId
            // 
            this.colDetailId.DataPropertyName = "detailId";
            this.colDetailId.HeaderText = "detailId";
            this.colDetailId.Name = "colDetailId";
            this.colDetailId.ReadOnly = true;
            this.colDetailId.Visible = false;
            this.colDetailId.Width = 67;
            // 
            // colDoreId_FK
            // 
            this.colDoreId_FK.DataPropertyName = "doreId_FK";
            this.colDoreId_FK.HeaderText = "doreId_FK";
            this.colDoreId_FK.Name = "colDoreId_FK";
            this.colDoreId_FK.ReadOnly = true;
            this.colDoreId_FK.Visible = false;
            this.colDoreId_FK.Width = 91;
            // 
            // col_radif
            // 
            this.col_radif.DataPropertyName = "radif";
            this.col_radif.HeaderText = "ردیف";
            this.col_radif.Name = "col_radif";
            this.col_radif.ReadOnly = true;
            this.col_radif.Width = 65;
            // 
            // col_marsoole_id
            // 
            this.col_marsoole_id.DataPropertyName = "marsoole_id";
            this.col_marsoole_id.HeaderText = "شماره مرسوله";
            this.col_marsoole_id.Name = "col_marsoole_id";
            this.col_marsoole_id.ReadOnly = true;
            this.col_marsoole_id.Width = 117;
            // 
            // col_sender
            // 
            this.col_sender.DataPropertyName = "sender";
            this.col_sender.HeaderText = "فرستنده";
            this.col_sender.Name = "col_sender";
            this.col_sender.ReadOnly = true;
            this.col_sender.Width = 78;
            // 
            // col_receiver
            // 
            this.col_receiver.DataPropertyName = "receiver";
            this.col_receiver.HeaderText = "گیرنده";
            this.col_receiver.Name = "col_receiver";
            this.col_receiver.ReadOnly = true;
            this.col_receiver.Width = 70;
            // 
            // col_destination
            // 
            this.col_destination.DataPropertyName = "destination";
            this.col_destination.HeaderText = "مقصد";
            this.col_destination.Name = "col_destination";
            this.col_destination.ReadOnly = true;
            this.col_destination.Width = 65;
            // 
            // col_detail_time
            // 
            this.col_detail_time.DataPropertyName = "detail_time";
            this.col_detail_time.HeaderText = "زمان";
            this.col_detail_time.Name = "col_detail_time";
            this.col_detail_time.ReadOnly = true;
            this.col_detail_time.Width = 62;
            // 
            // col_hagh_maghar
            // 
            this.col_hagh_maghar.DataPropertyName = "hagh_maghar";
            this.col_hagh_maghar.HeaderText = "حق مقر";
            this.col_hagh_maghar.Name = "col_hagh_maghar";
            this.col_hagh_maghar.ReadOnly = true;
            this.col_hagh_maghar.Width = 77;
            // 
            // col_destination_code
            // 
            this.col_destination_code.DataPropertyName = "destination_code";
            this.col_destination_code.HeaderText = "کد مقصد";
            this.col_destination_code.Name = "col_destination_code";
            this.col_destination_code.ReadOnly = true;
            this.col_destination_code.Width = 83;
            // 
            // col_source_code
            // 
            this.col_source_code.DataPropertyName = "source_code";
            this.col_source_code.HeaderText = "ک م";
            this.col_source_code.Name = "col_source_code";
            this.col_source_code.ReadOnly = true;
            this.col_source_code.Width = 54;
            // 
            // col_d
            // 
            this.col_d.DataPropertyName = "d";
            this.col_d.HeaderText = "د";
            this.col_d.Name = "col_d";
            this.col_d.ReadOnly = true;
            this.col_d.Width = 39;
            // 
            // col_vazn
            // 
            this.col_vazn.DataPropertyName = "vazn";
            this.col_vazn.HeaderText = "وزن";
            this.col_vazn.Name = "col_vazn";
            this.col_vazn.ReadOnly = true;
            this.col_vazn.Width = 57;
            // 
            // col_mablagh_ezhar
            // 
            this.col_mablagh_ezhar.DataPropertyName = "mablagh_ezhar";
            dataGridViewCellStyle2.Format = "N0";
            this.col_mablagh_ezhar.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_mablagh_ezhar.HeaderText = "مبلغ اظهار شده";
            this.col_mablagh_ezhar.Name = "col_mablagh_ezhar";
            this.col_mablagh_ezhar.ReadOnly = true;
            this.col_mablagh_ezhar.Width = 124;
            // 
            // col_haghe_bime
            // 
            this.col_haghe_bime.DataPropertyName = "haghe_bime";
            dataGridViewCellStyle3.Format = "N0";
            this.col_haghe_bime.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_haghe_bime.HeaderText = "حق بیمه";
            this.col_haghe_bime.Name = "col_haghe_bime";
            this.col_haghe_bime.ReadOnly = true;
            this.col_haghe_bime.Width = 81;
            // 
            // col_maliat
            // 
            this.col_maliat.DataPropertyName = "maliat";
            dataGridViewCellStyle4.Format = "N0";
            this.col_maliat.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_maliat.HeaderText = "مالیات";
            this.col_maliat.Name = "col_maliat";
            this.col_maliat.ReadOnly = true;
            this.col_maliat.Width = 71;
            // 
            // col_hagh_sahm_p
            // 
            this.col_hagh_sahm_p.DataPropertyName = "hagh_sahm_p";
            dataGridViewCellStyle5.Format = "N0";
            this.col_hagh_sahm_p.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_hagh_sahm_p.HeaderText = "حق السهم پ";
            this.col_hagh_sahm_p.Name = "col_hagh_sahm_p";
            this.col_hagh_sahm_p.ReadOnly = true;
            this.col_hagh_sahm_p.Width = 106;
            // 
            // col_hagh_sahm_t_gh
            // 
            this.col_hagh_sahm_t_gh.DataPropertyName = "hagh_sahm_t_gh";
            dataGridViewCellStyle6.Format = "N0";
            this.col_hagh_sahm_t_gh.DefaultCellStyle = dataGridViewCellStyle6;
            this.col_hagh_sahm_t_gh.HeaderText = "حق السهم ط ق";
            this.col_hagh_sahm_t_gh.Name = "col_hagh_sahm_t_gh";
            this.col_hagh_sahm_t_gh.ReadOnly = true;
            this.col_hagh_sahm_t_gh.Width = 119;
            // 
            // col_price
            // 
            this.col_price.DataPropertyName = "price";
            dataGridViewCellStyle7.Format = "N0";
            this.col_price.DefaultCellStyle = dataGridViewCellStyle7;
            this.col_price.HeaderText = "مبلغ ریال";
            this.col_price.Name = "col_price";
            this.col_price.ReadOnly = true;
            this.col_price.Width = 89;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(1003, 107);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "جستجو:";
            // 
            // cmbSearch
            // 
            this.cmbSearch.DataSource = this.doreBindingSource;
            this.cmbSearch.DisplayMember = "doreName";
            this.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.ItemHeight = 16;
            this.cmbSearch.Location = new System.Drawing.Point(847, 104);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSearch.Size = new System.Drawing.Size(150, 24);
            this.cmbSearch.TabIndex = 9;
            this.cmbSearch.ValueMember = "doreId";
            this.cmbSearch.SelectedIndexChanged += new System.EventHandler(this.cmbSearch_SelectedIndexChanged);
            // 
            // txtSearchFilter
            // 
            this.txtSearchFilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSearchFilter.Location = new System.Drawing.Point(523, 104);
            this.txtSearchFilter.Name = "txtSearchFilter";
            this.txtSearchFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearchFilter.Size = new System.Drawing.Size(318, 23);
            this.txtSearchFilter.TabIndex = 10;
            this.txtSearchFilter.TextChanged += new System.EventHandler(this.txtSearchFilter_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.labelRowCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 537);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(1169, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(67, 17);
            this.toolStripStatusLabel1.Text = "تعداد سطرها:";
            // 
            // labelRowCount
            // 
            this.labelRowCount.Name = "labelRowCount";
            this.labelRowCount.Size = new System.Drawing.Size(13, 17);
            this.labelRowCount.Text = "0";
            // 
            // btnLoading
            // 
            this.btnLoading.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnLoading.Location = new System.Drawing.Point(12, 103);
            this.btnLoading.Name = "btnLoading";
            this.btnLoading.Size = new System.Drawing.Size(179, 26);
            this.btnLoading.TabIndex = 12;
            this.btnLoading.Text = "بارگذاری لیست جدید";
            this.btnLoading.UseVisualStyleBackColor = true;
            this.btnLoading.Click += new System.EventHandler(this.btnLoading_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 559);
            this.Controls.Add(this.btnLoading);
            this.Controls.Add(this.txtSearchFilter);
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDore);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بارگذاری پست";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbDore;
        private System.Windows.Forms.Label label1;
        private PostDataSet postDataSet;
        private System.Windows.Forms.BindingSource doreBindingSource;
        private PostDataSetTableAdapters.DoreTableAdapter doreTableAdapter;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoreId_FK;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_radif;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_marsoole_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sender;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_receiver;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_detail_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hagh_maghar;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_destination_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_source_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_d;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_vazn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_mablagh_ezhar;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_haghe_bime;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_maliat;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hagh_sahm_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hagh_sahm_t_gh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.TextBox txtSearchFilter;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel labelRowCount;
        private System.Windows.Forms.Button btnLoading;
    }
}

