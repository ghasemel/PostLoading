using Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PostLoading
{
    public partial class FormLoadingWizard : Form
    {
        BLL bll;

        public FormLoadingWizard()
        {
            InitializeComponent();

            bll = new BLL();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
            if (this.tabControl1.SelectedTab.Equals(tabPage1))
            {
                if (this.txtListName.Text.Trim() == "")
                {
                    this.errorProvider1.SetError(txtListName, "لطفا عنوانی را انتخاب کنید");
                    this.txtListName.Select();
                    return;
                }

                // check for existance of the title
                if (bll.IsDoreExist(this.txtListName.Text))
                {
                    MessageBox.Show("عنوان دوره تکراری است", "", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                    this.errorProvider1.SetError(txtListName, "عنوان دوره تکراری است");
                    this.txtListName.Select();
                    return;
                }

                this.tabControl1.SelectedTab = this.tabPage2;
            }
            else if (this.tabControl1.SelectedTab.Equals(tabPage2))
            {
                if (this.listBox1.Items.Count == 0)
                {
                    this.errorProvider1.SetError(listBox1, "هیچ فایلی انتخاب نشده است");
                    this.btnBrowseFiles.Select();
                    return;
                }

                tabControl1.SelectedTab = tabPage3;
            }
            else if (this.tabControl1.SelectedTab.Equals(tabPage3))
            {
                LoadFilesToDatabase();
                
            }
        }


        private bool LoadFilesToDatabase()
        {
            if (this.listBox1.Items.Count > 0)
            {
                int doreId = bll.AddDore(this.txtListName.Text);
                if (doreId == - 1)
                {
                    MessageBox.Show("عملیات با شکست مواجه شد", "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                    return false;
                }


                List<string> files = new List<string>();
                foreach (var item in listBox1.Items)
                    files.Add(item.ToString());

                int ignore_rows = (int)this.numStartRow.Value;

                progressBar1.Value = 0;
                progressBar1.Minimum = 0;
                progressBar1.Maximum = listBox1.Items.Count;
                BackgroundWorker worker = new BackgroundWorker();
                worker.WorkerReportsProgress = true;
                worker.WorkerSupportsCancellation = true;

                try
                {
                    worker.DoWork += (s, e) =>
                    {
                        try
                        {
                            bll.AddDoreDetailFromFiles(files, ignore_rows, doreId, worker);
                        }
                        catch (Exception ex)
                        {
                            e.Cancel = true;
                            throw ex;
                        }
                    };

                    worker.ProgressChanged += (s, e) =>
                    {
                        this.progressBar1.PerformStep();
                    };                 
                    
                    worker.RunWorkerCompleted += (s, e) =>
                    {
                        if (!e.Cancelled && e.Error == null)
                        {
                            MessageBox.Show("با موفقیت انجام شد.", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            if (e.Error != null)
                            {
                                MessageBox.Show(e.Error.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                            }
                        }
                    };
                    worker.RunWorkerAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            return true;
        }
     

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedTab.Equals(tabPage3))
                this.tabControl1.SelectedTab = tabPage2;
            else if (this.tabControl1.SelectedTab.Equals(tabPage2))
                this.tabControl1.SelectedTab = tabPage1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FormLoadingWizard_Load(object sender, EventArgs e)
        {
            this.txtListName.Select();
            CrossCutting.ChangeKeybaordToPersian();
        }

        private void btnBrowseFiles_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog1.FileNames)
                {
                    this.listBox1.Items.Add(file);
                }
            }
        }

        private void btnClearFilesList_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
        }
    }
}
