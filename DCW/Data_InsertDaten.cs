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
    public partial class Data_InsertDaten : Form
    {
        private Form_Kartei form;
        private int Position;
        public Data_InsertDaten(Form_Kartei form, int pos)
        {
            InitializeComponent();
            this.form = form;
            this.Position = pos;
        }

        private void InsertData(object sender, EventArgs e) 
        {
            string strMsg = checkFields();
            if (strMsg != "") {
                MessageBox.Show(strMsg);
                return;
            }

            this.datenTableAdapter.Connection.Open();
            string str1 = "SELECT Daten_Mitgliedsnummer FROM daten ORDER BY Daten_Mitgliedsnummer DESC limit 1";
            int Mitgliedsnummer = -1;
            using (MySql.Data.MySqlClient.MySqlCommand selectData = new MySql.Data.MySqlClient.MySqlCommand(str1, this.datenTableAdapter.Connection))
            {
                using(MySql.Data.MySqlClient.MySqlDataReader reader1 = selectData.ExecuteReader()){
                    if(reader1.HasRows){
                        reader1.Read();
                        Mitgliedsnummer = Convert.ToInt32(reader1["Daten_Mitgliedsnummer"]);
                    }
                }
            }

            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO daten(Daten_Art_Datensatz, Daten_Briefanrede, Daten_Briefanrede_CN, Daten_Geschlecht, Daten_Email, ");
            sb.Append(" Daten_Fax, Daten_Fax_CN, Daten_Firma1, Daten_Firma2, Daten_Internet, Daten_Land, Daten_Land_CN, Daten_Mitgliedsnummer, ");
            sb.Append(" Daten_Handy, Daten_Handy_CN, Daten_Nachname, Daten_Nachname_CN, Daten_Ort, Daten_Ort_CN, Daten_PLZ, Daten_PLZ_CN, ");
            sb.Append(" Daten_Pos_Abt, Daten_Pos_Abt_CN, Daten_Strasse, Daten_Strasse_CN, Daten_Telefon, Daten_Telefon_CN, Daten_Tit_Vor_AP, Daten_Tit_Vor_AP_CN ");
            sb.Append(" )VALUES ( ");
            sb.AppendFormat("N'{0}', ", this.Add_ArtDatenSatzes.Text);
            sb.AppendFormat("N'{0}', ", this.Add_Briefanrede.Text);
            sb.AppendFormat("N'{0}', ", this.Add_BriefanredeCN.Text);
            sb.AppendFormat("N'{0}', ", this.Add_datenGeschlechtLabel.Text);
            sb.AppendFormat("N'{0}', ", this.Add_Email.Text);
            sb.AppendFormat("N'{0}', ", this.Add_Fax.Text);
            sb.AppendFormat("N'{0}', ", this.Add_FaxCN.Text);
            sb.AppendFormat("N'{0}', ", this.Add_Firma1.Text);
            sb.AppendFormat("N'{0}', ", this.Add_Firma2.Text);
            sb.AppendFormat("N'{0}', ", this.Add_Internet.Text);
            sb.AppendFormat("N'{0}', ", this.Add_Land.Text);
            sb.AppendFormat("N'{0}', ", this.Add_LandCN.Text);
            sb.AppendFormat(" {0}, ", Mitgliedsnummer + 1);
            sb.AppendFormat("N'{0}', ", this.Add_Mobil.Text);
            sb.AppendFormat("N'{0}', ", this.Add_MobilCN.Text);
            sb.AppendFormat("N'{0}', ", this.Add_Nachname.Text);
            sb.AppendFormat("N'{0}', ", this.Add_NachnameCN.Text);
            sb.AppendFormat("N'{0}', ", this.Add_Ort.Text);
            sb.AppendFormat("N'{0}', ", this.Add_OrtCN.Text);
            sb.AppendFormat("N'{0}', ", this.Add_PLZ.Text);
            sb.AppendFormat("N'{0}', ", this.Add_PLZCN.Text);
            sb.AppendFormat("N'{0}', ", this.Add_PosAbt.Text);
            sb.AppendFormat("N'{0}', ", this.Add_PosAbtCN.Text);
            sb.AppendFormat("N'{0}', ", this.Add_Straße.Text);
            sb.AppendFormat("N'{0}', ", this.Add_StraßeCN.Text);
            sb.AppendFormat("N'{0}', ", this.Add_Telefon.Text);
            sb.AppendFormat("N'{0}', ", this.Add_TelefonCN.Text);
            sb.AppendFormat("N'{0}', ", this.Add_TitVorAP.Text);
            sb.AppendFormat("N'{0}' ", this.Add_TitVorAPCN.Text);
            sb.Append(" )");

            try
            {
                using (MySql.Data.MySqlClient.MySqlCommand insertData = new MySql.Data.MySqlClient.MySqlCommand(sb.ToString(), this.datenTableAdapter.Connection))
                {
                    insertData.ExecuteNonQuery();
                }

                this.form.Form_Kartei_Load(sender, e);
                MessageBox.Show("Insert Success!");
                this.form.setPosition(this.Position);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert Failure! " + ex.Message);
            }
            finally {
                this.datenTableAdapter.Connection.Close();
                this.Hide();
                this.form.Show();
                this.form.button3.Enabled = true;
            }
        }

        private string checkFields()
        {
            string strMsg = "";

            return strMsg;
        }

        private void CancelAdd(object sender, EventArgs e)
        {
            this.Hide();
            this.form.button3.Enabled = true;
        }

        private void Data_InsertDaten_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            this.form.button3.Enabled = true;
        }
    }
}
