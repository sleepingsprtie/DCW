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
    public partial class Data_Modification : Form
    {
        private Form_Kartei form;
        private int Position;
        private int PkValue;
        public Data_Modification(Form_Kartei form, int pos)
        {
            InitializeComponent();
            this.form = form;
            this.Position = pos;
        }

        private void UpdateData(object sender, EventArgs e) 
        {
            string strMsg = checkFields();
            if (strMsg != "") {
                MessageBox.Show(strMsg);
                return;
            }
            DataTable table = this.datenTableAdapter.GetData();
            DataRow tmpRow = table.Rows.Find(this.PkValue);
            tmpRow.SetField("Daten_Art_Datensatz", this.Mod_ArtDatenSatzes.Text);
            tmpRow.SetField("Daten_Briefanrede", this.Mod_Briefanrede.Text);
            tmpRow.SetField("Daten_Briefanrede_CN", this.Mod_BriefanredeCN.Text);
            tmpRow.SetField("Daten_Geschlecht", this.Mod_datenGeschlechtLabel.Text);
            tmpRow.SetField("Daten_Email", this.Mod_Email.Text);
            tmpRow.SetField("Daten_Fax", this.Mod_Fax.Text);
            tmpRow.SetField("Daten_Fax_CN", this.Mod_FaxCN.Text);
            tmpRow.SetField("Daten_Firma1", this.Mod_Firma1.Text);
            tmpRow.SetField("Daten_Firma2", this.Mod_Firma2.Text);
            tmpRow.SetField("Daten_Internet", this.Mod_Internet.Text);
            tmpRow.SetField("Daten_Land", this.Mod_Land.Text);
            tmpRow.SetField("Daten_Land_CN", this.Mod_LandCN.Text);
            tmpRow.SetField("Daten_Mitgliedsnummer", Convert.ToInt32(this.Mod_Mitgliedsnummer.Text));
            tmpRow.SetField("Daten_Handy", this.Mod_Mobil.Text);
            tmpRow.SetField("Daten_Handy_CN", this.Mod_MobilCN.Text);
            tmpRow.SetField("Daten_Nachname", this.Mod_Nachname.Text);
            tmpRow.SetField("Daten_Nachname_CN", this.Mod_NachnameCN.Text);
            tmpRow.SetField("Daten_Ort", this.Mod_Ort.Text);
            tmpRow.SetField("Daten_Ort_CN", this.Mod_OrtCN.Text);
            tmpRow.SetField("Daten_PLZ", this.Mod_PLZ.Text);
            tmpRow.SetField("Daten_PLZ_CN", this.Mod_PLZCN.Text);
            tmpRow.SetField("Daten_Pos_Abt", this.Mod_PosAbt.Text);
            tmpRow.SetField("Daten_Pos_Abt_CN", this.Mod_PosAbtCN.Text);
            tmpRow.SetField("Daten_Strasse", this.Mod_Straße.Text);
            tmpRow.SetField("Daten_Strasse_CN", this.Mod_StraßeCN.Text);
            tmpRow.SetField("Daten_Telefon", this.Mod_Telefon.Text);
            tmpRow.SetField("Daten_Telefon_CN", this.Mod_TelefonCN.Text);
            tmpRow.SetField("Daten_Tit_Vor_AP", this.Mod_TitVorAP.Text);
            tmpRow.SetField("Daten_Tit_Vor_AP_CN", this.Mod_TitVorAPCN.Text);

            try
            {
                this.datenTableAdapter.Update(tmpRow);
                this.form.Form_Kartei_Load(sender, e);
                MessageBox.Show("Update Success!");
            }
            catch (Exception ex) {
                MessageBox.Show("Update Failure! " + ex.Message);
            }

        }

        private string checkFields()
        {
            string strMsg = "";

            return strMsg;
        }

        private void CancelModi(object sender, EventArgs e)
        {
            this.Hide();
            this.form.button2.Enabled = true;
            this.form.setPosition(this.Position);
        }

        private void Data_Modification_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.CancelModi(sender , e);
        }

        private void Data_Modification_Load(object sender, EventArgs e)
        {
            try
            {
                this.PkValue = Convert.ToInt32(this.form.daten_PkValue.Text);
                this.Mod_ArtDatenSatzes.Text = this.form.daten_Art_DatensatzTextBox.Text;
                this.Mod_Briefanrede.Text = this.form.daten_BriefanredeTextBox.Text;
                this.Mod_BriefanredeCN.Text = this.form.daten_Briefanrede_CNTextBox.Text;
                this.Mod_datenGeschlechtLabel.Text = this.form.daten_GeschlechtTextBox.Text;
                this.Mod_Email.Text = this.form.daten_EmailTextBox.Text;
                this.Mod_Fax.Text = this.form.daten_FaxTextBox.Text;
                this.Mod_FaxCN.Text = this.form.daten_Fax_CNTextBox.Text;
                this.Mod_Firma1.Text = this.form.daten_Firma1TextBox.Text;
                this.Mod_Firma2.Text = this.form.daten_Firma2TextBox.Text;
                this.Mod_Internet.Text = this.form.daten_InternetTextBox.Text;
                this.Mod_Land.Text = this.form.daten_LandTextBox.Text;
                this.Mod_LandCN.Text = this.form.daten_Land_CNTextBox.Text;
                this.Mod_Mitgliedsnummer.Text = this.form.daten_MitgliedsnummerTextBox.Text;
                this.Mod_Mobil.Text = this.form.daten_HandyTextBox.Text;
                this.Mod_MobilCN.Text = this.form.daten_Handy_CNTextBox.Text;
                this.Mod_Nachname.Text = this.form.daten_NachnameTextBox.Text;
                this.Mod_NachnameCN.Text = this.form.daten_Nachname_CNTextBox.Text;
                this.Mod_Ort.Text = this.form.daten_OrtTextBox.Text;
                this.Mod_OrtCN.Text = this.form.daten_Ort_CNTextBox.Text;
                this.Mod_PLZ.Text = this.form.daten_PLZTextBox.Text;
                this.Mod_PLZCN.Text = this.form.daten_PLZ_CNTextBox.Text;
                this.Mod_PosAbt.Text = this.form.daten_Pos_AbtTextBox.Text;
                this.Mod_PosAbtCN.Text = this.form.daten_Pos_Abt_CNTextBox.Text;
                this.Mod_Straße.Text = this.form.daten_StrasseTextBox.Text;
                this.Mod_StraßeCN.Text = this.form.daten_Strasse_CNTextBox.Text;
                this.Mod_Telefon.Text = this.form.daten_TelefonTextBox.Text;
                this.Mod_TelefonCN.Text = this.form.daten_Telefon_CNTextBox.Text;
                this.Mod_TitVorAP.Text = this.form.daten_Tit_Vor_APTextBox.Text;
                this.Mod_TitVorAPCN.Text = this.form.daten_Tit_Vor_AP_CNTextBox.Text;
            }
            catch
            {
                MessageBox.Show("data is error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
