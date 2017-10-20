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
    public partial class Form_CT_Beitragszahlung : Form
    {
        private Form_Kartei Kartei;
        public Form_CT_Beitragszahlung(Form_Kartei Kartei)
        {
            InitializeComponent();
            this.Kartei = Kartei;
        }
        private void Form_CT_Beitragszahlung_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void Form_CT_Beitragszahlung_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: 这行代码将数据加载到表“dcwDataSet.ct_beiträge”中。您可以根据需要移动或删除它。
                this.ct_beiträgeTableAdapter.Fill(this.dcwDataSet.ct_beiträge);
                this.label1.Text = "CT-Zahlung von Mitglied Nr. " + this.Kartei.daten_MitgliedsnummerTextBox.Text;
                this.CT_Betrag.Text = Convert.ToDouble(this.Kartei.daten_CT_PreisTextBox.Text).ToString("F");
                this.CT_Beitragsjahr.Text = DateTime.Now.Year.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection with Database is defect!" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Abbrechen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("M鯿hten Sie wirklich abbrechen?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Hide();
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            int Mnr = Convert.ToInt32(this.Kartei.daten_MitgliedsnummerTextBox.Text);
            string CT_Datum = this.dateTimePicker1.Text;
            if (CT_Datum == "")
            {
                MessageBox.Show("Das Datum hat kein Datumsformat!");
            }
            else
            {
                this.ct_beiträgeTableAdapter.Connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append("INSERT INTO ct_beitraege(CT_Mgl, CT_Betrag, CT_Datum, CT_Beitragsjahr ");
                sb.Append(" )VALUES ( ");
                sb.AppendFormat("{0}, ", Mnr);
                sb.AppendFormat("{0}, ", Convert.ToDouble(this.CT_Betrag.Text));
                CT_Datum = String.Format("{0:yyyy-MM-dd hh:MM:ss}", Convert.ToDateTime(CT_Datum));
                sb.AppendFormat("N'{0}', ", CT_Datum);
                sb.AppendFormat("N'{0}' ", this.CT_Beitragsjahr.Text);
                sb.Append(" )");

                try
                {
                    using (MySql.Data.MySqlClient.MySqlCommand insertData = new MySql.Data.MySqlClient.MySqlCommand(sb.ToString(), this.ct_beiträgeTableAdapter.Connection))
                    {
                        insertData.ExecuteNonQuery();
                    }

                    MessageBox.Show("Form Beitragszahlung Insert Success!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Form Beitragszahlung Insert Failure! " + ex.Message);
                }
                finally
                {
                    this.ct_beiträgeTableAdapter.Connection.Close();
                    this.Hide();
                    this.Kartei.ct_beiträgeShow();
                }

            }
        }
    }
}
