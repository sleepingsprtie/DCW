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
    public partial class Befeh1_Suchen : Form
    {
        private Form_Kartei form;
        private BindingSource datenBindingSource;
        private List<string> columnNameList = new List<string>();
        private Dictionary<string, string> columnNameList1 = new Dictionary<string, string>();
        public Befeh1_Suchen(Form_Kartei form, BindingSource datenBindingSource)
        {
            InitializeComponent();
            this.form = form;
            this.datenBindingSource = datenBindingSource;
            if (this.comboBox1.Items.Count == 0)
            {
                ComboboxItem item = new ComboboxItem();

                this.datenTableAdapter.Connection.Open();
                string strSQL = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS " +
                        "WHERE TABLE_NAME = 'daten' AND TABLE_SCHEMA = 'dcw' AND (COLUMN_NAME like 'daten_%' OR COLUMN_NAME = 'Id');";
                DataTable param = new DataTable();

                using (MySql.Data.MySqlClient.MySqlCommand selectData = new MySql.Data.MySqlClient.MySqlCommand(strSQL, this.datenTableAdapter.Connection))
                {
                    using (MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(selectData))
                    {
                        adapter.Fill(param);
                    }
                }

                this.datenTableAdapter.Connection.Close();

                for (int i = 0; i < param.Rows.Count; i++)
                {
                    DataRow tmpRow = param.Rows[i];
                    string column = Convert.ToString(tmpRow["COLUMN_NAME"]);
                    item = new ComboboxItem();
                    item.Text = column;
                    item.Value = column;
                    this.comboBox1.Items.Add(item);
                    this.columnNameList.Add(column.ToLower());
                    this.columnNameList1.Add(column.ToLower(), column);
                    
                }
                this.comboBox1.SelectedIndex = 0;
            }
            this.comboBox2.SelectedIndex = 0;

        }
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void Befeh1_Suchen_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private string expression(string column, string text) {
            int count, tmp;
            count = text.Length;
            try
            {
                tmp = Convert.ToInt32(text);
                return column + "= " + tmp;
            }
            catch (Exception) {
                return " 1=0 ";
            }
        }
        private void comboBox1_Select(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                this.OK.Enabled = false;
                this.Cancel.Enabled = false;
                string column = this.comboBox1.Text;
                string operat = this.comboBox2.Text;
                string text = this.condition.Text;
                string boolValue = "true,false";
                string condition = "";
                if ((column == "Id") && (text != ""))
                {
                    condition = column + operat + Convert.ToInt32(text);
                }
                else if ((column == "Daten_Mitgliedsnummer") && (text != ""))
                {
                    condition = column + operat + Convert.ToInt32(text);
                }
                else if ((column == "Daten_lfd") && (text != ""))
                {
                    condition = column + operat + Convert.ToInt32(text);
                }
                else if ((column == "Daten_Firmenmitglied") && (boolValue.Contains(text.ToLower())))
                {
                    condition = column + "=" + Convert.ToBoolean(text);
                }
                else if ((column == "Daten_Firmafrei") && (boolValue.Contains(text.ToLower())))
                {
                    condition = column + "=" + Convert.ToBoolean(text);
                }
                else if ((column == "Daten_Firmasonst") && (boolValue.Contains(text.ToLower())))
                {
                    condition = column + "=" + Convert.ToBoolean(text);
                }
                else if ((column == "Daten_Jahresbeitrag") && (text != ""))
                {
                    condition = column + operat + Convert.ToInt32(text);
                }
                else if ((column == "Daten_vorherweniger") && (text != ""))
                {
                    condition = column + operat + Convert.ToInt32(text);
                }
                else if ((column == "Daten_Total_Offen") && (text != ""))
                {
                    condition = column + operat + Convert.ToInt32(text);
                }
                else if ((column == "Daten_Umlage1") && (text != ""))
                {
                    condition = column + operat + Convert.ToInt32(text);
                }
                else if ((column == "Daten_Umlage2") && (text != ""))
                {
                    condition = column + operat + Convert.ToInt32(text);
                }
                else if ((column == "Daten_Umlage3") && (text != ""))
                {
                    condition = column + operat + Convert.ToInt32(text);
                }
                else if ((column == "Daten_Umlage4") && (text != ""))
                {
                    condition = column + operat + Convert.ToInt32(text);
                }
                else if ((column == "Daten_Imlage5") && (text != ""))
                {
                    condition = column + operat + Convert.ToInt32(text);
                }
                else if ((column == "Daten_CT_Menge") && (text != ""))
                {
                    condition = column + operat + Convert.ToInt32(text);
                }
                else if ((column == "Daten_CT_versendet") && (boolValue.Contains(text.ToLower())))
                {
                    condition = column + "=" + Convert.ToBoolean(text);
                }
                else if ((column == "Daten_CT_Preis") && (text != ""))
                {
                    condition = column + operat + Convert.ToInt32(text);
                }
                else if ((column == "Daten_Firmenhandbuch") && (boolValue.Contains(text.ToLower())))
                {
                    condition = column + "=" + Convert.ToBoolean(text);
                }
                else if ((column == "Daten_Akt") && (text != ""))
                {
                    condition = column + operat + Convert.ToInt32(text);
                }
                else
                {
                    if (operat == "like")
                    {
                        condition = column + " " + operat + " '%" + text + "%'";
                    }
                    else
                    {
                        condition = column + " " + operat + " '" + text + "'";
                    }
                }

                //*** 以下为 日期栏位 备用。
                //condition += "OR Daten_Beitrittsdatum like '%" + text + "%' ";
                //condition += "OR Daten_Kuendigung like '%" + text + "%' ";
                //condition += "OR Daten_Beitrag_Ausgesetzt like '%" + text + "%' ";
                //condition += "OR Daten_Letzt_Zahl like '%" + text + "%' ";
                //condition += "OR Daten_CT_Abo_seit like '%" + text + "%' ";
                //condition += "OR Daten_Angelegt like '%" + text + "%' ";
                if (condition != "")
                {
                    this.datenBindingSource.Filter = condition ;
                }
                this.Hide();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
                this.OK.Enabled = true;
                this.Cancel.Enabled = true;
            }
        }

        private void Befeh1_Suchen_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dcwDataSet.daten”中。您可以根据需要移动或删除它。
            this.datenTableAdapter.Fill(this.dcwDataSet.daten);

        }



        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                this.OK.Enabled = false;
                this.Cancel.Enabled = false;
                string column = this.comboBox3.Text;
                string operat = "like";
                string text = this.tb_condition.Text;
                string boolValue = "true,false";
                string condition = "";

                List<string> columnList = columnNameList1.Keys.Where(x => x.Contains(column.ToLower())).Select(x => columnNameList1[x]).ToList<string>();


                int num = columnList.Count;
                columnList.ForEach(x => {
                    if(string.IsNullOrEmpty(condition))
                    {
                        condition = string.Format("{0} like '%{1}%'", x, text);
                    }
                    else
                    {
                        condition +=string.Format(" or {0} like '%{1}%'",x,text);
                    }
                });

                //+" or Daten_Nachname_CN like '%Li%'"

                //if ((column == "Id") && (text != ""))
                //{
                //    condition = column + operat + Convert.ToInt32(text);
                //}
                //else if ((column == "Daten_Mitgliedsnummer") && (text != ""))
                //{
                //    condition = column + operat + Convert.ToInt32(text);
                //}
                //else if ((column == "Daten_lfd") && (text != ""))
                //{
                //    condition = column + operat + Convert.ToInt32(text);
                //}
                //else if ((column == "Daten_Firmenmitglied") && (boolValue.Contains(text.ToLower())))
                //{
                //    condition = column + "=" + Convert.ToBoolean(text);
                //}
                //else if ((column == "Daten_Firmafrei") && (boolValue.Contains(text.ToLower())))
                //{
                //    condition = column + "=" + Convert.ToBoolean(text);
                //}
                //else if ((column == "Daten_Firmasonst") && (boolValue.Contains(text.ToLower())))
                //{
                //    condition = column + "=" + Convert.ToBoolean(text);
                //}
                //else if ((column == "Daten_Jahresbeitrag") && (text != ""))
                //{
                //    condition = column + operat + Convert.ToInt32(text);
                //}
                //else if ((column == "Daten_vorherweniger") && (text != ""))
                //{
                //    condition = column + operat + Convert.ToInt32(text);
                //}
                //else if ((column == "Daten_Total_Offen") && (text != ""))
                //{
                //    condition = column + operat + Convert.ToInt32(text);
                //}
                //else if ((column == "Daten_Umlage1") && (text != ""))
                //{
                //    condition = column + operat + Convert.ToInt32(text);
                //}
                //else if ((column == "Daten_Umlage2") && (text != ""))
                //{
                //    condition = column + operat + Convert.ToInt32(text);
                //}
                //else if ((column == "Daten_Umlage3") && (text != ""))
                //{
                //    condition = column + operat + Convert.ToInt32(text);
                //}
                //else if ((column == "Daten_Umlage4") && (text != ""))
                //{
                //    condition = column + operat + Convert.ToInt32(text);
                //}
                //else if ((column == "Daten_Imlage5") && (text != ""))
                //{
                //    condition = column + operat + Convert.ToInt32(text);
                //}
                //else if ((column == "Daten_CT_Menge") && (text != ""))
                //{
                //    condition = column + operat + Convert.ToInt32(text);
                //}
                //else if ((column == "Daten_CT_versendet") && (boolValue.Contains(text.ToLower())))
                //{
                //    condition = column + "=" + Convert.ToBoolean(text);
                //}
                //else if ((column == "Daten_CT_Preis") && (text != ""))
                //{
                //    condition = column + operat + Convert.ToInt32(text);
                //}
                //else if ((column == "Daten_Firmenhandbuch") && (boolValue.Contains(text.ToLower())))
                //{
                //    condition = column + "=" + Convert.ToBoolean(text);
                //}
                //else if ((column == "Daten_Akt") && (text != ""))
                //{
                //    condition = column + operat + Convert.ToInt32(text);
                //}
                //else
                //{
                //    if (operat == "like")
                //    {
                //        condition = column + " " + operat + " '%" + text + "%'";
                //    }
                //    else
                //    {
                //        condition = column + " " + operat + " '" + text + "'";
                //    }
                //}

                //*** 以下为 日期栏位 备用。
                //condition += "OR Daten_Beitrittsdatum like '%" + text + "%' ";
                //condition += "OR Daten_Kuendigung like '%" + text + "%' ";
                //condition += "OR Daten_Beitrag_Ausgesetzt like '%" + text + "%' ";
                //condition += "OR Daten_Letzt_Zahl like '%" + text + "%' ";
                //condition += "OR Daten_CT_Abo_seit like '%" + text + "%' ";
                //condition += "OR Daten_Angelegt like '%" + text + "%' ";
                if (condition != "")
                {
                    this.datenBindingSource.Filter = condition;
                }
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.OK.Enabled = true;
                this.Cancel.Enabled = true;
            }
        }
    }
}
