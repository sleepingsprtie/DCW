using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DCW
{
    public partial class UC_TWO : UserControl
    {
        private Form_Kartei Kartei;
        public UC_TWO(DataRow dataRow, Form_Kartei Kartei)
        {
            InitializeComponent();

            int lfd = Convert.ToInt32(dataRow["Teil_lfd"]);
            this.Teil_lfd.Text = lfd + "";
            string Veranstaltung_Datum = Convert.ToString(dataRow["Teil_Veranstaltung_Datum"]);
            this.Teil_Veranstaltung_Datum.Text = Veranstaltung_Datum;
            string Veranstaltung_Titel = Convert.ToString(dataRow["Teil_Veranstaltung_Titel"]);
            this.Teil_Veranstaltung_Titel.Text = Veranstaltung_Titel;
            string Veranstaltung_Ort = Convert.ToString(dataRow["Teil_Veranstaltung_Ort"]);
            this.Teil_Veranstaltung_Ort.Text = Veranstaltung_Ort;
            string Anmeldung_Datum = Convert.ToString(dataRow["Teil_Anmeldung_Datum"]);
            this.Teil_Anmeldung_Datum.Text = Anmeldung_Datum;
           double Gebuehr = 0.0;
            if (dataRow["Teil_Gebuehr"]!= DBNull.Value)
            {
                Gebuehr = Convert.ToDouble(dataRow["Teil_Gebuehr"]);
            }
                this.Teil_Gebuehr.Text = Gebuehr + "";
                double Mwst = 0.0;
                if (dataRow["Teil_Mwst"] != DBNull.Value) { 
            Mwst = Convert.ToDouble(dataRow["Teil_Mwst"]);
        }
            this.Teil_Mwst.Text = Mwst + "";
            int Gesamtbetrag = 0;
            if (dataRow["Teil_Gesamtbetrag"] != DBNull.Value)
            Gesamtbetrag = Convert.ToInt32(dataRow["Teil_Gesamtbetrag"]);
            this.Teil_Gesamtbetrag.Text = Gesamtbetrag + "";
            if (dataRow["Teil_Essen"] != System.DBNull.Value)
            {
                bool Essen = Convert.ToBoolean(dataRow["Teil_Essen"]);
                this.Teil_Essen.Checked = Essen;
            }
            if (dataRow["Teil_Rechtzeitig_Abmeldung"] != System.DBNull.Value)
            {
                bool Rechtzeitig_Abmeldung = Convert.ToBoolean(dataRow["Teil_Rechtzeitig_Abmeldung"]);
                this.Teil_Rechtzeitig_Abmeldung.Checked = Rechtzeitig_Abmeldung;
            }
            double Zahlung_Betrag = Convert.ToDouble(dataRow["Teil_Zahlung_Betrag"]);
            this.Teil_Zahlung_Betrag.Text = Zahlung_Betrag + "";
            if (dataRow["Teil_Bezahlt_Am"] != System.DBNull.Value)
            {
                string Bezahlt_Am = Convert.ToString(dataRow["Teil_Bezahlt_Am"]);
                this.Teil_Bezahlt_Am.Text = Bezahlt_Am;
            }
            this.Kartei = Kartei;
        }

        public void Teil_Gesamtbetrag_LostFocus(object sender, EventArgs e)
        {
            int Teil_lfd = Convert.ToInt32(this.Teil_lfd.Text);
            this.teilnehmerveranstaltungTableAdapter.Connection.Open();
            double Teil_Gesamtbetrag = Convert.ToDouble(this.Teil_Gesamtbetrag.Text);
            string updateSql = "UPDATE teilnehmerveranstaltung SET Teil_Gesamtbetrag = " + Teil_Gesamtbetrag
                            + " WHERE Teil_lfd = " + Teil_lfd;
            using (MySql.Data.MySqlClient.MySqlCommand updateData = new MySql.Data.MySqlClient.MySqlCommand(updateSql, this.teilnehmerveranstaltungTableAdapter.Connection))
            {
                updateData.ExecuteNonQuery();
            }
            this.teilnehmerveranstaltungTableAdapter.Connection.Close();
        }

        public void Teil_Essen_LostFocus(object sender, EventArgs e)
        {
            int Teil_lfd = Convert.ToInt32(this.Teil_lfd.Text);
            this.teilnehmerveranstaltungTableAdapter.Connection.Open();
            bool Teil_Essen = this.Teil_Essen.Checked;
            string updateSql = "UPDATE teilnehmerveranstaltung SET Teil_Essen = " + Teil_Essen
                            + " WHERE Teil_lfd = " + Teil_lfd;
            using (MySql.Data.MySqlClient.MySqlCommand updateData = new MySql.Data.MySqlClient.MySqlCommand(updateSql, this.teilnehmerveranstaltungTableAdapter.Connection))
            {
                updateData.ExecuteNonQuery();
            }
            this.teilnehmerveranstaltungTableAdapter.Connection.Close();
        }

        public void Teil_Rechtzeitig_Abmeldung_LostFocus(object sender, EventArgs e)
        {
            int Teil_lfd = Convert.ToInt32(this.Teil_lfd.Text);
            this.teilnehmerveranstaltungTableAdapter.Connection.Open();
            bool Teil_Rechtzeitig_Abmeldung = this.Teil_Rechtzeitig_Abmeldung.Checked;
            string updateSql = "UPDATE teilnehmerveranstaltung SET Teil_Rechtzeitig_Abmeldung = " + Teil_Rechtzeitig_Abmeldung
                            + " WHERE Teil_lfd = " + Teil_lfd;
            using (MySql.Data.MySqlClient.MySqlCommand updateData = new MySql.Data.MySqlClient.MySqlCommand(updateSql, this.teilnehmerveranstaltungTableAdapter.Connection))
            {
                updateData.ExecuteNonQuery();
            }
            this.teilnehmerveranstaltungTableAdapter.Connection.Close();
        }

        public void Teil_Zahlung_Betrag_LostFocus(object sender, EventArgs e)
        {
            int Teil_lfd = Convert.ToInt32(this.Teil_lfd.Text);
            this.teilnehmerveranstaltungTableAdapter.Connection.Open();
            string Teil_Zahlung_Betrag = Convert.ToString(this.Teil_Zahlung_Betrag.Text);
            string updateSql = "UPDATE teilnehmerveranstaltung SET Teil_Zahlung_Betrag = " + Teil_Zahlung_Betrag
                            + " WHERE Teil_lfd = " + Teil_lfd;
            using (MySql.Data.MySqlClient.MySqlCommand updateData = new MySql.Data.MySqlClient.MySqlCommand(updateSql, this.teilnehmerveranstaltungTableAdapter.Connection))
            {
                updateData.ExecuteNonQuery();
            }
            this.teilnehmerveranstaltungTableAdapter.Connection.Close();
        }

        public void Teil_Bezahlt_Am_LostFocus(object sender, EventArgs e)
        {
            int Teil_lfd = Convert.ToInt32(this.Teil_lfd.Text);
            this.teilnehmerveranstaltungTableAdapter.Connection.Open();

            DateTime Teil_Bezahlt_Am = Convert.ToDateTime(this.Teil_Bezahlt_Am.Text);
            string updateSql = "UPDATE teilnehmerveranstaltung SET Teil_Bezahlt_Am = '" + Teil_Bezahlt_Am
                            + "' WHERE Teil_lfd = " + Teil_lfd;
            using (MySql.Data.MySqlClient.MySqlCommand updateData = new MySql.Data.MySqlClient.MySqlCommand(updateSql, this.teilnehmerveranstaltungTableAdapter.Connection))
            {
                updateData.ExecuteNonQuery();
            }
            this.teilnehmerveranstaltungTableAdapter.Connection.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete Teilnahme an Veranstaltungen?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
                int Teil_lfd = Convert.ToInt32(this.Teil_lfd.Text);
                this.teilnehmerveranstaltungTableAdapter.Connection.Open();

                string deleteSql = "DELETE FROM teilnehmerveranstaltung " + " WHERE Teil_lfd = " + Teil_lfd;
                using (MySql.Data.MySqlClient.MySqlCommand updateData = new MySql.Data.MySqlClient.MySqlCommand(deleteSql, this.teilnehmerveranstaltungTableAdapter.Connection))
                {
                    updateData.ExecuteNonQuery();
                }
                this.teilnehmerveranstaltungTableAdapter.Connection.Close();
                int Mgl = Convert.ToInt32(this.Kartei.daten_MitgliedsnummerTextBox.Text);
                this.Kartei.teilnehmerveranstaltung_Load(Mgl);
            }
        }
    }
}
