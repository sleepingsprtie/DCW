using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DCW
{
    public partial class Form_Administrator : Form
    {
        private ComboBox cmb_Temp = new ComboBox();
        private Form fHauptmenu;
        private Dictionary<int, string> dictDienstleistunge = new Dictionary<int, string>();
        private List<string> listDienstleistunge = new List<string>();
        public Form_Administrator(Form fHauptmenu)
        {
            InitializeComponent();
            this.fHauptmenu = fHauptmenu;

            using (dcwDataSet.t_dienstleistungenDataTable table = this.t_dienstleistungenTableAdapter.GetData())
            {
                this.dictDienstleistunge.Clear();
                this.listDienstleistunge.Clear();
                foreach (dcwDataSet.t_dienstleistungenRow row in table.Rows)
                {
                    dictDienstleistunge.Add(Convert.ToInt16(row["dienst_id"]), Convert.ToString(row["dienstleistung"]));
                    listDienstleistunge.Add(Convert.ToString(row["dienstleistung"]));
                }
            }
            this.cmb_Temp.Visible = false;
            //this.t_wer_macht_wasDataGridView.
        }

        private void t_wer_macht_wasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_wer_macht_wasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dcwDataSet);

            
        }

        private void Form_Administrator_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dcwDataSet.t_dienstleistungen”中。您可以根据需要移动或删除它。
            this.t_dienstleistungenTableAdapter.Fill(this.dcwDataSet.t_dienstleistungen);
            // TODO: 这行代码将数据加载到表“dcwDataSet.t_wer_macht_was”中。您可以根据需要移动或删除它。
            this.t_wer_macht_wasTableAdapter.Fill(this.dcwDataSet.t_wer_macht_was);

        }

        private void Form_Administrator_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            this.fHauptmenu.Show();
        }



        private void t_wer_macht_wasDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                DataGridView dgv = sender as DataGridView;

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    DataGridViewComboBoxCell cell = row.Cells["Dienstleistung"] as DataGridViewComboBoxCell;
                    int index = Convert.ToInt16(row.Cells["f_dienstleistung"].Value);
                    string text=this.t_dienstleistungenTableAdapter.ScalarQueryByID(Convert.ToInt16(row.Cells["f_dienstleistung"].Value));

                    cell.Value = text;
                }
            }
            catch
            {

            }
            
        }

        private void t_wer_macht_wasDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            DataGridViewTextBoxCell cell=sender as DataGridViewTextBoxCell;


            Rectangle rect = t_wer_macht_wasDataGridView.GetCellDisplayRectangle(t_wer_macht_wasDataGridView.CurrentCell.ColumnIndex, t_wer_macht_wasDataGridView.CurrentCell.RowIndex, false);
            
            
            this.cb_dienstleistung.Left = rect.Left+t_wer_macht_wasDataGridView.Location.X;
            this.cb_dienstleistung.Top = rect.Top+t_wer_macht_wasDataGridView.Location.Y;
            this.cb_dienstleistung.Width = rect.Width;
            this.cb_dienstleistung.Height = rect.Height;
            this.cb_dienstleistung.Visible = true;
            /*
            if (this.t_wer_macht_wasDataGridView.Columns[e.ColumnIndex].Name == "Dienstleistung")
            {
                int cellX = t_wer_macht_wasDataGridView.GetCellDisplayRectangle(e.ColumnIndex,e.RowIndex,false).X;
                int cellY = t_wer_macht_wasDataGridView.GetCellDisplayRectangle(e.ColumnIndex,e.RowIndex,false).Y;
                //Rectangle rect = t_wer_macht_wasDataGridView.GetCellDisplayRectangle(e.ColumnIndex,e.RowIndex,false);

                ////this.cb_dienstleistung.SetBounds(rect.X, rect.Y, rect.Width, rect.Height);

                Rectangle rect = t_wer_macht_wasDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                this.cb_dienstleistung.Left = rect.Left;
                this.cb_dienstleistung.Top = rect.Top;
                this.cb_dienstleistung.Width = rect.Width;
                this.cb_dienstleistung.Height = rect.Height;
                this.cb_dienstleistung.Visible = true;
            }
             * */
        }
    }
}
