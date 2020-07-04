using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostLoading
{
    public partial class FormMain : Form
    {
        BLL bll;
        DataView dv = null;

        public FormMain()
        {
            InitializeComponent();

            bll = new BLL();
            LoadDoreList();

            cmbSearch.DataSource = SearchColumns.GetColumns(); 
            
            if (!string.IsNullOrEmpty(Properties.Settings.Default.LastSearchFilter))
            {
                int i = -1;
                foreach (var item in cmbSearch.Items)
                {
                    i++;
                    if ((item as SearchColumns).name == Properties.Settings.Default.LastSearchFilter)
                    {
                        cmbSearch.SelectedIndex = i;
                        break;
                    }
                }
            }
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            CrossCutting.ChangeKeybaordToPersian();
        }


        private void LoadDoreList()
        {
            this.doreBindingSource.DataSource = this.doreTableAdapter.GetDoreList();            

            if (dv != null)
                this.dv.Table = null;
            //this.dataGridView1.DataSource = dv;
        }


        private void btnShow_Click(object sender, EventArgs e)
        {
            if (cmbDore.SelectedIndex >= 0)
            {
                if (cmbDore.SelectedItem is DataRowView)
                {
                    int doreId = (cmbDore.SelectedItem as DataRowView)[0].ToInt();
                    dv = bll.GetDoreDetail(doreId);
                    dataGridView1.DataSource = dv;
                }
            }
        }


        private void txtSearchFilter_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchFilter.Text == "")
                if (dv != null)
                    dv.RowFilter = "";

            if (cmbSearch.SelectedIndex > -1)
            {
                if (dv != null)
                {
                    SearchColumns col = (cmbSearch.SelectedItem as SearchColumns);
                    dv.RowFilter = string.Format("{0} like '%{1}%' OR {0} like '%{2}%'", col.name, txtSearchFilter.Text.RemoveArabicKaf(), txtSearchFilter.Text.RemoveArabicKaf().ReplaceWithArabicYa());                    
                }
            }
        }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchFilter_TextChanged(sender, e);

            if (cmbSearch.SelectedIndex > -1)
            {
                Properties.Settings.Default.LastSearchFilter = (cmbSearch.SelectedItem as SearchColumns).name;
                Properties.Settings.Default.Save();
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.labelRowCount.Text = this.dataGridView1.RowCount.ToString();
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.labelRowCount.Text = this.dataGridView1.RowCount.ToString();
        }

        private void btnLoading_Click(object sender, EventArgs e)
        {
            FormLoadingWizard frmWizard = new FormLoadingWizard();
            if (frmWizard.ShowDialog() == DialogResult.OK)
                LoadDoreList();
        }
    }
}
