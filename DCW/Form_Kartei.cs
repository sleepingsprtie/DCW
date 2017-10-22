using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DCW
{
    public partial class Form_Kartei : Form
    {
        private Form fHauptmenu;
        private Data_Modification DataModification;
        private Data_InsertDaten DataInsertDaten;
        private Data_CopyDaten DataCopyDaten;
        private Befeh1_Suchen Befeh1Suchen;
        private Form_Beitragszahlung Beitragszahlung;
        private Form_CT_Beitragszahlung CT_Beitragszahlung;
        public Form_Kartei(Form fHauptmenu)
        {
            InitializeComponent();
            this.fHauptmenu = fHauptmenu;
            this.fHauptmenu.Hide();
        }

        private void Form_Kartei_FormClosing(object sender, FormClosingEventArgs e)
        {
            datenBindingNavigatorSaveItem_Click(sender, e);
            e.Cancel = true;
            this.datenBindingSource.Filter = null;
            this.Hide();
            this.fHauptmenu.Show();
        }

        private void datenBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.datenBindingSource.EndEdit();
            try
            {
                DataTable dt = this.dcwDataSet.daten.GetChanges();
                if (dt != null)
                {
                    this.tableAdapterManager.UpdateAll(this.dcwDataSet);
                }
            }
            catch (Exception)
            {
            }

        }

        public void Form_Kartei_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: 这行代码将数据加载到表“dcwDataSet.veranstaltungen”中。您可以根据需要移动或删除它。
                this.veranstaltungenTableAdapter.Fill(this.dcwDataSet.veranstaltungen);
                // TODO: 这行代码将数据加载到表“dcwDataSet.bundesland”中。您可以根据需要移动或删除它。
                this.bundeslandTableAdapter.Fill(this.dcwDataSet.bundesland);
                // TODO: 这行代码将数据加载到表“dcwDataSet.branchen”中。您可以根据需要移动或删除它。
                this.branchenTableAdapter.Fill(this.dcwDataSet.branchen);
                // TODO: 这行代码将数据加载到表“dcwDataSet.daten”中。您可以根据需要移动或删除它。
                this.datenTableAdapter.Fill(this.dcwDataSet.daten);
                // TODO: 这行代码将数据加载到表“dcwDataSet.teilnehmerveranstaltung”中。您可以根据需要移动或删除它。
                this.teilnehmerveranstaltungTableAdapter.Fill(this.dcwDataSet.teilnehmerveranstaltung);
                // TODO: 这行代码将数据加载到表“dcwDataSet.ct_beiträge”中。您可以根据需要移动或删除它。
                this.ct_beiträgeTableAdapter.Fill(this.dcwDataSet.ct_beiträge);
                // TODO: 这行代码将数据加载到表“dcwDataSet.beiträge”中。您可以根据需要移动或删除它。
                this.beiträgeTableAdapter.Fill(this.dcwDataSet.beiträge);

                //*** 给dropdownlist 添加选项，使用下面方法，是想有第一个选项。
                if (this.dropdownlist.Items.Count == 0)
                {
                    ComboboxItem item = new ComboboxItem();
                    dcwDataSet.veranstaltungenDataTable vdt = this.dcwDataSet.veranstaltungen;
                    vdt.DefaultView.Sort = "Ver_Datum DESC";
                    DataTable vdt2 = vdt.DefaultView.ToTable();

                    item.Text = "请选择";
                    item.Value = "";
                    this.dropdownlist.Items.Add(item);
                    DCWHelper helper = new DCWHelper();
                    

                    for (int i = 0; i < vdt2.Rows.Count; i++)
                    {
                        DataRow tmpRow = vdt2.Rows[i];
                        int Ver_lfd = Convert.ToInt32(tmpRow["Ver_lfd"]);
                        //System.Console.WriteLine(Ver_lfd);
                        item = new ComboboxItem();
                        DateTime datum = tmpRow["Ver_Datum"] is DBNull ? new DateTime(1900,1,1) : Convert.ToDateTime(tmpRow["Ver_Datum"]); 
                        string ort = (tmpRow["Ver_Ort"] as string)??"";
                        string title = (tmpRow["Ver_Titel"] as string)??"";
                        item.Text = string.Format("{0} | {1} | {2}", datum.ToString("dd.MM.yyyy"),                            
                            title.PadRight(100),                           
                            ort
                            );
                        item.Value = Ver_lfd;
                        this.dropdownlist.Items.Add(item);
                    }
                    this.dropdownlist.SelectedIndex = 0;
                }
                var Mgl = Convert.ToInt32(this.daten_MitgliedsnummerTextBox.Text);
                this.teilnehmerveranstaltung_Load(Mgl);
                this.beiträge_Load(Mgl);
                this.ct_beiträge_Load(Mgl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection with Database is defect!" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //*** 泛查
        private void Befehl_Suchen(object sender, EventArgs e)
        {
            if (this.dcwDataSet.daten.Count < 1)
            {
                MessageBox.Show("No Data! Please Insert First!");
                return;
            }
            this.Befeh1Suchen = new Befeh1_Suchen(this, this.datenBindingSource);

            this.Befeh1Suchen.ShowDialog();
        }

        //*** 修改会员
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.dcwDataSet.daten.Count < 1)
            {
                MessageBox.Show("No Data! Please Insert First!");
                return;
            }
            int pos = this.datenBindingSource.Position;
            this.DataModification = new Data_Modification(this, pos);
            this.button2.Enabled = false;
            this.DataModification.ShowDialog();
        }

        //*** 新增会员
        private void button3_Click(object sender, EventArgs e)
        {
            int pos = this.datenBindingSource.Count;
            this.DataInsertDaten = new Data_InsertDaten(this, pos);
            this.button3.Enabled = false;
            this.DataInsertDaten.ShowDialog();
        }

        //*** 复制会员信息
        private void button4_Click(object sender, EventArgs e)
        {
            if (this.dcwDataSet.daten.Count < 1)
            {
                MessageBox.Show("No Data! Please Insert First!");
                return;
            }
            int pos = this.datenBindingSource.Count;
            this.DataCopyDaten = new Data_CopyDaten(this, pos);
            this.button4.Enabled = false;
            this.DataCopyDaten.ShowDialog();
        }

        //*** OK 按钮，回到主画面
        private void button6_Click(object sender, EventArgs e)
        {
            //datenBindingNavigatorSaveItem_Click(sender, e);
            this.Hide();
            this.fHauptmenu.Show();
        }

        //*** 写入 CSV
        private void button5_Click(object sender, EventArgs e)
        {
            //this.button5.Enabled = false;
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);//引用Excel工作簿 
            excel.Visible = true; //使Excel可视
            excel.ActiveSheet.Cells[1, 1] = "Firma1";
            excel.ActiveSheet.Cells[1, 2] = "Firma2";
            excel.ActiveSheet.Cells[1, 3] = "TitVorAP";
            excel.ActiveSheet.Cells[1, 4] = "NameAP";
            excel.ActiveSheet.Cells[1, 5] = "PosAbt";
            excel.ActiveSheet.Cells[1, 6] = "Adresse";
            excel.ActiveSheet.Cells[1, 7] = "PLZ";
            excel.ActiveSheet.Cells[1, 8] = "Ort";
            excel.ActiveSheet.Cells[1, 9] = "Telefon";
            excel.ActiveSheet.Cells[1, 10] = "Fax";
            excel.ActiveSheet.Cells[1, 11] = "E-Mail";
            excel.ActiveSheet.Cells[1, 12] = "Internet";
            excel.ActiveSheet.Cells[1, 13] = "Branche";
            excel.ActiveSheet.Cells[1, 14] = "InChina";
            excel.ActiveSheet.Cells[1, 15] = "Login";
            excel.ActiveSheet.Cells[1, 16] = "Passwort";
            excel.ActiveSheet.Cells[1, 17] = "Briefan";

            dcwDataSet.datenDataTable dt = this.datenTableAdapter.GetData();

            bool isSave = false;
            for (int i = 0, zeile = 2; i < dt.Rows.Count; i++)
            {
                DataRow tmpRow = dt.Rows[i];
                string Daten_Art_Datensatz = Convert.ToString(tmpRow["Daten_Art_Datensatz"]);
                if (Daten_Art_Datensatz == "DCW-Mitglied")
                {
                    isSave = true;
                    excel.ActiveSheet.Cells[zeile, 1] = Convert.ToString(tmpRow["Daten_Firma1"]);
                    excel.ActiveSheet.Cells[zeile, 2] = Convert.ToString(tmpRow["Daten_Firma2"]);
                    excel.ActiveSheet.Cells[zeile, 3] = Convert.ToString(tmpRow["Daten_Tit_Vor_AP"]);
                    excel.ActiveSheet.Cells[zeile, 4] = Convert.ToString(tmpRow["Daten_Nachname"]);
                    excel.ActiveSheet.Cells[zeile, 5] = Convert.ToString(tmpRow["Daten_Pos_Abt"]);
                    excel.ActiveSheet.Cells[zeile, 6] = Convert.ToString(tmpRow["Daten_Strasse"]);
                    excel.ActiveSheet.Cells[zeile, 7] = Convert.ToString(tmpRow["Daten_PLZ"]);
                    excel.ActiveSheet.Cells[zeile, 8] = Convert.ToString(tmpRow["Daten_Ort"]);
                    excel.ActiveSheet.Cells[zeile, 8] = Convert.ToString(tmpRow["Daten_Telefon"]);
                    excel.ActiveSheet.Cells[zeile, 10] = Convert.ToString(tmpRow["Daten_Fax"]);
                    excel.ActiveSheet.Cells[zeile, 11] = Convert.ToString(tmpRow["Daten_Email"]);
                    excel.ActiveSheet.Cells[zeile, 12] = Convert.ToString(tmpRow["Daten_Internet"]);
                    excel.ActiveSheet.Cells[zeile, 13] = Convert.ToString(tmpRow["Daten_Produkte"]);
                    excel.ActiveSheet.Cells[zeile, 14] = Convert.ToString(tmpRow["Daten_InChina"]);
                    excel.ActiveSheet.Cells[zeile, 15] = Convert.ToString(tmpRow["Daten_Login"]);
                    excel.ActiveSheet.Cells[zeile, 16] = Convert.ToString(tmpRow["Daten_Passwort"]);
                    excel.ActiveSheet.Cells[zeile, 17] = Convert.ToString(tmpRow["Daten_Briefanrede"]);
                    zeile++;
                }
            }

            /*try
            {
                if (isSave)
                {
                    string nowDate = String.Format("{0:yyyyMMddhhMMss}", DateTime.Now);

                    string path = "";
                    FolderBrowserDialog fbd = new FolderBrowserDialog();
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        path = fbd.SelectedPath;
                    }
                    else
                    {
                        if (!Directory.Exists(Application.StartupPath + "\\mitglieder"))
                        {
                            Directory.CreateDirectory(Application.StartupPath + "\\mitglieder");
                        }
                        path = Application.StartupPath + "\\mitglieder";
                    }
                    excel.ActiveWorkbook.SaveAs(path + "\\mitglieder" + nowDate + ".csv");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                excel = null;
                this.button5.Enabled = true;
            }*/
        }

        //*** 点击选项，新增 TeilnehmerVeranstaltung 一笔资料
        private void dropdownlist_Select(object sender, EventArgs e)
        {
            if ((this.dropdownlist.SelectedItem as ComboboxItem).Value == "") { return; }
            int fldValue = Convert.ToInt32((this.dropdownlist.SelectedItem as ComboboxItem).Value);
            DataTable table = this.veranstaltungenTableAdapter.GetData();
            DataRow tmpRow = table.Rows.Find(fldValue);

            if (tmpRow != null)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("INSERT INTO TeilnehmerVeranstaltung(Teil_TeilnehmerMgl, Teil_Veranstaltunglfd, Teil_Veranstaltung_Titel, Teil_Veranstaltung_Datum, Teil_Veranstaltung_Ort, ");
                sb.Append(" Teil_Gebuehr, Teil_Mwst, Teil_Gesamtbetrag, Teil_Anmeldung_Datum, Teil_Essen ");
                sb.Append(" )VALUES ( ");
                sb.AppendFormat("{0}, ", Convert.ToInt32(this.daten_MitgliedsnummerTextBox.Text));
                sb.AppendFormat("{0}, ", fldValue);
                sb.AppendFormat("N'{0}', ", tmpRow["Ver_Titel"]);
                string Ver_Datum = String.Format("{0:yyyy-MM-dd hh:MM:ss}", tmpRow["Ver_Datum"]);
                if (Ver_Datum != "")
                {
                    sb.AppendFormat("N'{0}', ", Ver_Datum);
                }
                else
                {
                    sb.Append("NULL,");
                }

                sb.AppendFormat("N'{0}', ", tmpRow["Ver_Ort"]);

                string tmp_Art_Datensatz = this.daten_Art_DatensatzTextBox.Text;
                double VPreism = 0;
                if (tmpRow["Ver_Preis_Mitglied"] != DBNull.Value)
                {
                    VPreism = Convert.ToDouble(tmpRow["Ver_Preis_Mitglied"]);
                }
                double VPreisn = 0;
                if (tmpRow["Ver_Preis_Nichtmitglied"] != DBNull.Value)
                {
                    VPreisn = Convert.ToDouble(tmpRow["Ver_Preis_Nichtmitglied"]);
                }
                bool flg = true;
                if (tmp_Art_Datensatz == "Nicht-Mitglied")
                {
                    flg = false;
                    sb.AppendFormat("{0}, ", (VPreisn / 107 * 100));
                    sb.AppendFormat("{0}, ", (VPreisn / 107 * 7));
                    sb.AppendFormat("{0}, ", VPreisn);
                }

                if (tmp_Art_Datensatz.StartsWith("DCW"))
                {
                    flg = false;
                    sb.AppendFormat("{0}, ", (VPreism / 107 * 100));
                    sb.AppendFormat("{0}, ", (VPreism / 107 * 7));
                    sb.AppendFormat("{0}, ", VPreism);
                }
                if (flg)
                {
                    sb.AppendFormat("{0}, ", 0 );
                    sb.AppendFormat("{0}, ", 0);
                    sb.AppendFormat("{0}, ", 0); 
                }
                string nowDate = String.Format("{0:yyyy-MM-dd hh:MM:ss}", DateTime.Now);
                sb.AppendFormat("N'{0}', ", nowDate);
                sb.AppendFormat("{0} ", 1);

                sb.Append(" )");

                DataTable param = new DataTable();
                this.teilnehmerveranstaltungTableAdapter.Connection.Open();
                try
                {
                    using (MySql.Data.MySqlClient.MySqlCommand insertData = new MySql.Data.MySqlClient.MySqlCommand(sb.ToString(), this.teilnehmerveranstaltungTableAdapter.Connection))
                    {
                        insertData.ExecuteNonQuery();
                    }

                    MessageBox.Show("Insert TeilnehmerVeranstaltung Success!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insert TeilnehmerVeranstaltung Failure! " + ex.Message);
                }
                finally
                {
                    string strSQL = "SELECT * FROM teilnehmerveranstaltung ORDER BY Teil_lfd DESC LIMIT 1;";

                    using (MySql.Data.MySqlClient.MySqlCommand selectData = new MySql.Data.MySqlClient.MySqlCommand(strSQL, this.teilnehmerveranstaltungTableAdapter.Connection))
                    {
                        using (MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(selectData))
                        {
                            adapter.Fill(param);
                        }
                    }

                    this.teilnehmerveranstaltungTableAdapter.Connection.Close();
                }

                this.teilnehmerveranstaltungTableAdapter.Fill(this.dcwDataSet.teilnehmerveranstaltung);
                this.createForm(param.Rows[0]);
            }
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

        //*** 第三个页签的按钮
        private void btn_MitgliedsbeiträgeZahlung_Click(object sender, EventArgs e)
        {
            if (this.daten_Art_DatensatzTextBox.Text == "DCW-Mitglied")
            {
                this.Beitragszahlung = new Form_Beitragszahlung(this);
                this.Beitragszahlung.ShowDialog();
            }
            else
            {
                MessageBox.Show("Dieser Datensatz ist kein DCW-Mitglied!\nEs könen keine Zahlungseing鋘ge verbucht werden!");
            }

        }

        public void beiträgeShow()
        {
            this.beiträgeTableAdapter.Fill(this.dcwDataSet.beiträge);
            int Mgl = Convert.ToInt32(this.daten_MitgliedsnummerTextBox.Text);

            DataTable param = new DataTable();
            string strSQL = "SELECT * FROM beitraege ORDER BY Bei_lfd DESC LIMIT 1;";
            this.beiträgeTableAdapter.Connection.Open();
            using (MySql.Data.MySqlClient.MySqlCommand selectData = new MySql.Data.MySqlClient.MySqlCommand(strSQL, this.beiträgeTableAdapter.Connection))
            {
                using (MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(selectData))
                {
                    adapter.Fill(param);
                }
            }

            this.beiträgeTableAdapter.Connection.Close();

            this.createForm2(param.Rows[0]);
        }

        //*** 第四个页签的按钮
        private void btn_ChinaTelegrammZahlung_Click(object sender, EventArgs e)
        {
            if (this.daten_Art_DatensatzTextBox.Text == "DCW-Mitglied")
            {
                MessageBox.Show("Dieser Datensatz ist DCW-Mitglied!\nMitglieder erhalten das CT kostenlos, so dass keine Zahlungseing鋘ge verbucht werden k鰊nen!");
            }
            else
            {
                this.CT_Beitragszahlung = new Form_CT_Beitragszahlung(this);
                this.CT_Beitragszahlung.ShowDialog();
            }
        }

        public void ct_beiträgeShow()
        {
            this.ct_beiträgeTableAdapter.Fill(this.dcwDataSet.ct_beiträge);
            int Mgl = Convert.ToInt32(this.daten_MitgliedsnummerTextBox.Text);

            DataTable param = new DataTable();
            string strSQL = "SELECT * FROM ct_beitraege ORDER BY CT_lfd DESC LIMIT 1;";
            this.ct_beiträgeTableAdapter.Connection.Open();
            using (MySql.Data.MySqlClient.MySqlCommand selectData = new MySql.Data.MySqlClient.MySqlCommand(strSQL, this.ct_beiträgeTableAdapter.Connection))
            {
                using (MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(selectData))
                {
                    adapter.Fill(param);
                }
            }

            this.ct_beiträgeTableAdapter.Connection.Close();

            this.createForm3(param.Rows[0]);
        }

        private void datenBindingSource_CurrentChanged(object sender, EventArgs e)
        {

            if (this.daten_MitgliedsnummerTextBox.Text != "")
            {
                int Mgl = Convert.ToInt32(this.daten_MitgliedsnummerTextBox.Text);
                this.teilnehmerveranstaltung_Load(Mgl);
                this.beiträge_Load(Mgl);
                this.ct_beiträge_Load(Mgl);
                this.dropdownlist.SelectedIndex = 0;
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Comfirm Delete?", "title", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                this.datenBindingSource.RemoveCurrent();
            }
        }

        public void setPosition(int pos)
        {
            this.datenBindingSource.Position = pos;
        }

        private void createForm(DataRow dataRow)
        {
            //获得一个子窗体实例
            UserControl UCTWO = new UC_TWO(dataRow, this);
            int count = this.panel_TWO.Controls.Count;
            int y = count * 150;

            UCTWO.Location = new Point(0, y);
            if (UCTWO != null)
            {
                //加入到panelMain空间组中
                this.panel_TWO.Controls.Add(UCTWO);
            }
        }

        public void teilnehmerveranstaltung_Load(int Mgl)
        {
            this.panel_TWO.Controls.Clear();
            dcwDataSet.teilnehmerveranstaltungDataTable dt_teil = this.teilnehmerveranstaltungTableAdapter.GetData();

            for (int i = 0; i < dt_teil.Rows.Count; i++)
            {
                DataRow tmpRow = dt_teil.Rows[i];
                int Teil_TeilnehmerMgl;
                if (tmpRow["Teil_TeilnehmerMgl"] != DBNull.Value)
                {
                    Teil_TeilnehmerMgl = Convert.ToInt32(tmpRow["Teil_TeilnehmerMgl"]);
                }else{
                    Teil_TeilnehmerMgl = -1;
                }
                
                if (Teil_TeilnehmerMgl == Mgl)
                {
                    this.createForm(tmpRow);
                }
            }
        }

        private void createForm2(DataRow dataRow)
        {
            //获得一个子窗体实例
            UserControl UCTHREE = new UC_THREE(dataRow, this);
            int count = this.panel_THREE.Controls.Count;
            int y = count * 70;

            UCTHREE.Location = new Point(0, y);
            if (UCTHREE != null)
            {
                //加入到panelMain空间组中
                this.panel_THREE.Controls.Add(UCTHREE);
            }
        }

        public void beiträge_Load(int Mgl)
        {
            this.panel_THREE.Controls.Clear();
            dcwDataSet.beiträgeDataTable dt_teil = this.beiträgeTableAdapter.GetData();

            for (int i = 0; i < dt_teil.Rows.Count; i++)
            {
                DataRow tmpRow = dt_teil.Rows[i];
                int Bei_Mgl = Convert.ToInt32(tmpRow["Bei_Mgl"]);
                if (Bei_Mgl == Mgl)
                {
                    this.createForm2(tmpRow);
                }
            }
        }

        private void createForm3(DataRow dataRow)
        {
            //获得一个子窗体实例
            UserControl UCFOUR = new UC_FOUR(dataRow, this);
            int count = this.panel_FOUR.Controls.Count;
            int y = count * 70;

            UCFOUR.Location = new Point(0, y);
            if (UCFOUR != null)
            {
                //加入到panelMain空间组中
                this.panel_FOUR.Controls.Add(UCFOUR);
            }
        }

        public void ct_beiträge_Load(int Mgl)
        {
            this.panel_FOUR.Controls.Clear();
            dcwDataSet.ct_beiträgeDataTable dt_teil = this.ct_beiträgeTableAdapter.GetData();

            for (int i = 0; i < dt_teil.Rows.Count; i++)
            {
                DataRow tmpRow = dt_teil.Rows[i];
                int CT_Mgl = Convert.ToInt32(tmpRow["CT_Mgl"]);
                if (CT_Mgl == Mgl)
                {
                    this.createForm3(tmpRow);
                }
            }
        }

    }
}
