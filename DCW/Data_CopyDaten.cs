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
    public partial class Data_CopyDaten : Form
    {
        private Form_Kartei form;
        private int PkValue;
        private int Position;
        public Data_CopyDaten(Form_Kartei form, int pos)
        {
            InitializeComponent();
            this.form = form;
            this.Position = pos;
        }

        private void CopyData(object sender, EventArgs e) 
        {
            string strMsg = checkFields();
            if (strMsg != "") {
                MessageBox.Show(strMsg);
                return;
            }

            this.datenTableAdapter.Connection.Open();
            string str1 = "SELECT Daten_Mitgliedsnummer FROM daten ORDER BY Daten_Mitgliedsnummer DESC limit 1";
            int Mitgliedsnummer = 0; ;
            using (MySql.Data.MySqlClient.MySqlCommand selectData = new MySql.Data.MySqlClient.MySqlCommand(str1, this.datenTableAdapter.Connection))
            {
                using (MySql.Data.MySqlClient.MySqlDataReader reader1 = selectData.ExecuteReader())
                {
                    if (reader1.HasRows)
                    {
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
            sb.AppendFormat("N'{0}', ", this.Copy_ArtDatenSatzes.Text);
            sb.AppendFormat("N'{0}', ", this.Copy_Briefanrede.Text);
            sb.AppendFormat("N'{0}', ", this.Copy_BriefanredeCN.Text);
            sb.AppendFormat("N'{0}', ", this.Copy_datenGeschlechtLabel.Text);
            sb.AppendFormat("N'{0}', ", this.Copy_Email.Text);
            sb.AppendFormat("N'{0}', ", this.Copy_Fax.Text);
            sb.AppendFormat("N'{0}', ", this.Copy_FaxCN.Text);
            sb.AppendFormat("N'{0}', ", this.Copy_Firma1.Text);
            sb.AppendFormat("N'{0}', ", this.Copy_Firma2.Text);
            sb.AppendFormat("N'{0}', ", this.Copy_Internet.Text);
            sb.AppendFormat("N'{0}', ", this.Copy_Land.Text);
            sb.AppendFormat("N'{0}', ", this.Copy_LandCN.Text);
            sb.AppendFormat(" {0}, ", Mitgliedsnummer + 1);
            sb.AppendFormat("N'{0}', ", this.Copy_Mobil.Text);
            sb.AppendFormat("N'{0}', ", this.Copy_MobilCN.Text);
            sb.AppendFormat("N'{0}', ", this.Copy_Nachname.Text);
            sb.AppendFormat("N'{0}', ", this.Copy_NachnameCN.Text);
            sb.AppendFormat("N'{0}', ", this.Copy_Ort.Text);
            sb.AppendFormat("N'{0}', ", this.Copy_OrtCN.Text);
            sb.AppendFormat("N'{0}', ", this.Copy_PLZ.Text);
            sb.AppendFormat("N'{0}', ", this.Copy_PLZCN.Text);
            sb.AppendFormat("N'{0}', ", this.Copy_PosAbt.Text);
            sb.AppendFormat("N'{0}', ", this.Copy_PosAbtCN.Text);
            sb.AppendFormat("N'{0}', ", this.Copy_Straße.Text);
            sb.AppendFormat("N'{0}', ", this.Copy_StraßeCN.Text);
            sb.AppendFormat("N'{0}', ", this.Copy_Telefon.Text);
            sb.AppendFormat("N'{0}', ", this.Copy_TelefonCN.Text);
            sb.AppendFormat("N'{0}', ", this.Copy_TitVorAP.Text);
            sb.AppendFormat("N'{0}' ", this.Copy_TitVorAPCN.Text);
            sb.Append(" )");

            try
            {
                using (MySql.Data.MySqlClient.MySqlCommand insertData = new MySql.Data.MySqlClient.MySqlCommand(sb.ToString(), this.datenTableAdapter.Connection))
                {
                    insertData.ExecuteNonQuery();
                }

                this.form.Form_Kartei_Load(sender, e);
                MessageBox.Show("Insert Copy Member Info Success!");
                this.form.setPosition(this.Position);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert Copy Member Info Failure! " + ex.Message);
            }
            finally
            {
                this.datenTableAdapter.Connection.Close();
                this.Hide();
                this.form.Show();
                this.form.button4.Enabled = true;
            }

        }

        private string checkFields()
        {
            string strMsg = "";

            return strMsg;
        }

        private void CancelCopy(object sender, EventArgs e)
        {
            this.Hide();
            this.form.button4.Enabled = true;
        }

        private void Data_CopyDaten_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            this.form.button4.Enabled = true;
        }

        private void Data_CopyDaten_Load(object sender, EventArgs e)
        {
            try
            {
                this.PkValue = Convert.ToInt32(this.form.daten_PkValue.Text);
                this.Copy_ArtDatenSatzes.Text = this.form.daten_Art_DatensatzTextBox.Text;
                this.Copy_Briefanrede.Text = this.form.daten_BriefanredeTextBox.Text;
                this.Copy_BriefanredeCN.Text = this.form.daten_Briefanrede_CNTextBox.Text;
                this.Copy_datenGeschlechtLabel.Text = this.form.daten_GeschlechtTextBox.Text;
                this.Copy_Fax.Text = this.form.daten_FaxTextBox.Text;
                this.Copy_FaxCN.Text = this.form.daten_Fax_CNTextBox.Text;
                this.Copy_Firma1.Text = this.form.daten_Firma1TextBox.Text;
                this.Copy_Firma2.Text = this.form.daten_Firma2TextBox.Text;
                this.Copy_Internet.Text = this.form.daten_InternetTextBox.Text;
                this.Copy_Land.Text = this.form.daten_LandTextBox.Text;
                this.Copy_LandCN.Text = this.form.daten_Land_CNTextBox.Text;
                //this.Copy_Mitgliedsnummer.Text = this.form.daten_MitgliedsnummerTextBox.Text;
                this.Copy_Mobil.Text = this.form.daten_HandyTextBox.Text;
                this.Copy_MobilCN.Text = this.form.daten_Handy_CNTextBox.Text;
                this.Copy_Nachname.Text = this.form.daten_NachnameTextBox.Text;
                this.Copy_NachnameCN.Text = this.form.daten_Nachname_CNTextBox.Text;
                this.Copy_Ort.Text = this.form.daten_OrtTextBox.Text;
                this.Copy_OrtCN.Text = this.form.daten_Ort_CNTextBox.Text;
                this.Copy_PLZ.Text = this.form.daten_PLZTextBox.Text;
                this.Copy_PLZCN.Text = this.form.daten_PLZ_CNTextBox.Text;
                this.Copy_PosAbt.Text = this.form.daten_Pos_AbtTextBox.Text;
                this.Copy_PosAbtCN.Text = this.form.daten_Pos_Abt_CNTextBox.Text;
                this.Copy_Straße.Text = this.form.daten_StrasseTextBox.Text;
                this.Copy_StraßeCN.Text = this.form.daten_Strasse_CNTextBox.Text;
                this.Copy_Telefon.Text = this.form.daten_TelefonTextBox.Text;
                this.Copy_TelefonCN.Text = this.form.daten_Telefon_CNTextBox.Text;
                this.Copy_TitVorAP.Text = this.form.daten_Tit_Vor_APTextBox.Text;
                this.Copy_TitVorAPCN.Text = this.form.daten_Tit_Vor_AP_CNTextBox.Text;
            }
            catch
            {
                MessageBox.Show("data is error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
