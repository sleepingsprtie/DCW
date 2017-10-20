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
    public partial class Form_Beitragszahlung : Form
    {
        private Form_Kartei Kartei;
        public Form_Beitragszahlung(Form_Kartei Kartei)
        {
            InitializeComponent();
            this.Kartei = Kartei;
        }

        private void Form_Beitragszahlung_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        public void Form_Beitragszahlung_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: 这行代码将数据加载到表“dcwDataSet.beiträge”中。您可以根据需要移动或删除它。
                this.beiträgeTableAdapter.Fill(this.dcwDataSet.beiträge);
                this.label4.Text = "Beitragszahlung von Mitglied Nr. " + this.Kartei.daten_MitgliedsnummerTextBox.Text;
                this.textBox1.Text = Convert.ToDouble(this.Kartei.daten_JahresbeitragTextBox.Text).ToString("F");
                this.textBox2.Text = DateTime.Now.Year.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection with Database is defect!" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Abbrechen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("M鯿hten Sie wirklich abbrechen?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
                this.Hide();
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            int Mnr = Convert.ToInt32(this.Kartei.daten_MitgliedsnummerTextBox.Text);
            string Bei_Datum = this.dateTimePicker1.Text;
            if (Bei_Datum == "")
            {
                MessageBox.Show("Das Datum hat kein Datumsformat!");
            }
            else {
                this.beiträgeTableAdapter.Connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append("INSERT INTO beitraege(Bei_Mgl, Bei_Betrag, Bei_Datum, Bei_Beitragsjahr ");
                sb.Append(" )VALUES ( ");
                sb.AppendFormat("{0}, ", Mnr);
                sb.AppendFormat("{0}, ", Convert.ToDouble(this.textBox1.Text).ToString("F"));
                Bei_Datum = String.Format("{0:yyyy-MM-dd hh:MM:ss}", Convert.ToDateTime(Bei_Datum));
                sb.AppendFormat("N'{0}', ", Bei_Datum);
                sb.AppendFormat("N'{0}' ", this.textBox2.Text);
                sb.Append(" )");

                try
                {
                    using (MySql.Data.MySqlClient.MySqlCommand insertData = new MySql.Data.MySqlClient.MySqlCommand(sb.ToString(), this.beiträgeTableAdapter.Connection))
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
                    this.beiträgeTableAdapter.Connection.Close();
                    this.Hide();
                    this.Kartei.beiträgeShow();
                }

            }
        }
    }
}
