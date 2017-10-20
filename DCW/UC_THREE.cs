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
    public partial class UC_THREE : UserControl
    {
        private Form_Kartei Kartei;
        public UC_THREE(DataRow dataRow, Form_Kartei Kartei)
        {
            InitializeComponent();

            int lfd = Convert.ToInt32(dataRow["Bei_lfd"]);
            this.Bei_lfd.Text = lfd + "";
            this.Bei_Beitragsjahr.Text = Convert.ToString(dataRow["Bei_Beitragsjahr"]);
            this.Bei_Betrag.Text = Convert.ToString(dataRow["Bei_Betrag"]);
            this.Bei_Datum.Text = Convert.ToString(dataRow["Bei_Datum"]);
            this.Kartei = Kartei;
        }

        public void Teil_Gesamtbetrag_LostFocus(object sender, EventArgs e)
        {
            return;
            int Bei_lfd = Convert.ToInt32(this.Bei_lfd.Text);
            this.beiträgeTableAdapter.Connection.Open();
            string updateSql = "UPDATE teilnehmerveranstaltung SET Bei_lfd = " + Bei_lfd
                            + " WHERE Bei_lfd = " + Bei_lfd;
            using (MySql.Data.MySqlClient.MySqlCommand updateData = new MySql.Data.MySqlClient.MySqlCommand(updateSql, this.beiträgeTableAdapter.Connection))
            {
                updateData.ExecuteNonQuery();
            }
            this.beiträgeTableAdapter.Connection.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete beitraege?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int Bei_lfd = Convert.ToInt32(this.Bei_lfd.Text);
                this.beiträgeTableAdapter.Connection.Open();

                string deleteSql = "DELETE FROM beitraege " + " WHERE Bei_lfd = " + Bei_lfd;
                using (MySql.Data.MySqlClient.MySqlCommand updateData = new MySql.Data.MySqlClient.MySqlCommand(deleteSql, this.beiträgeTableAdapter.Connection))
                {
                    updateData.ExecuteNonQuery();
                }
                this.beiträgeTableAdapter.Connection.Close();
                int Mgl = Convert.ToInt32(this.Kartei.daten_MitgliedsnummerTextBox.Text);
                this.Kartei.beiträge_Load(Mgl);
            }
        }
    }
}
