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
    public partial class UC_FOUR : UserControl
    {
        private Form_Kartei Kartei;
        public UC_FOUR(DataRow dataRow, Form_Kartei Kartei)
        {
            InitializeComponent();

            int lfd = Convert.ToInt32(dataRow["CT_lfd"]);
            this.CT_lfd.Text = lfd + "";
            this.CT_Beitragsjahr.Text = Convert.ToString(dataRow["CT_Beitragsjahr"]);
            this.CT_Betrag.Text = Convert.ToString(dataRow["CT_Betrag"]);
            this.CT_Datum.Text = Convert.ToString(dataRow["CT_Datum"]);
            this.Kartei = Kartei;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete beitraege?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int CT_lfd = Convert.ToInt32(this.CT_lfd.Text);
                this.ct_beiträgeTableAdapter.Connection.Open();

                string deleteSql = "DELETE FROM ct_beitraege " + " WHERE CT_lfd = " + CT_lfd;
                using (MySql.Data.MySqlClient.MySqlCommand updateData = new MySql.Data.MySqlClient.MySqlCommand(deleteSql, this.ct_beiträgeTableAdapter.Connection))
                {
                    updateData.ExecuteNonQuery();
                }
                this.ct_beiträgeTableAdapter.Connection.Close();
                int Mgl = Convert.ToInt32(this.Kartei.daten_MitgliedsnummerTextBox.Text);
                this.Kartei.ct_beiträge_Load(Mgl);
            }
        }
    }
}
