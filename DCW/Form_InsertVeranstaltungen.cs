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
    public partial class Form_InsertVeranstaltungen : Form
    {
        private Form_Veranstaltungen Veranstaltungen;
        public Form_InsertVeranstaltungen(Form_Veranstaltungen Veranstaltungen)
        {
            InitializeComponent();
            this.Veranstaltungen = Veranstaltungen;
        }

        private void Form_InsertVeranstaltungen_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            this.Veranstaltungen.ADD.Enabled = true;
        }

        private void add_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //this.fHauptmenu.Show();
            string strMsg = checkFields();
            if (strMsg != "")
            {
                MessageBox.Show(strMsg);
                return;
            }

            this.veranstaltungenTableAdapter.Connection.Open();

            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO veranstaltungen(Ver_Datum, Ver_Uhrzeit, Ver_Titel, Ver_Ort, Ver_Tagungsstaette, ");
            sb.Append(" Ver_Preis_Mitglied, Ver_Preis_Nichtmitglied, Ver_Veranstalter1, Ver_Veranstalter2, Ver_Rechnung_versandt_am ");
            sb.Append(" )VALUES ( ");
            sb.AppendFormat("N'{0}', ", String.Format("{0:yyyy-MM-dd hh:MM:ss }", Convert.ToDateTime(this.ver_DatumDateTimePicker.Text)));
            sb.AppendFormat("N'{0}', ", this.ver_UhrzeitTextBox.Text);
            sb.AppendFormat("N'{0}', ", this.ver_TitelTextBox.Text);
            sb.AppendFormat("N'{0}', ", this.ver_OrtTextBox.Text);
            sb.AppendFormat("N'{0}', ", this.ver_TagungsstaetteTextBox.Text);
            sb.AppendFormat("{0}, ", Convert.ToDouble(this.ver_Preis_MitgliedTextBox.Text));
            sb.AppendFormat("{0}, ", Convert.ToDouble(this.ver_Preis_NichtmitgliedTextBox.Text));
            sb.AppendFormat("N'{0}', ", this.ver_Veranstalter1TextBox.Text);
            sb.AppendFormat("N'{0}', ", this.ver_Veranstalter2TextBox.Text);
            sb.AppendFormat("N'{0}' ", String.Format("{0:yyyy-MM-dd hh:MM:ss }", Convert.ToDateTime(this.ver_Rechnung_versandt_amDateTimePicker.Text)));
            sb.Append(" )");

            try
            {
                using (MySql.Data.MySqlClient.MySqlCommand insertData = new MySql.Data.MySqlClient.MySqlCommand(sb.ToString(), this.veranstaltungenTableAdapter.Connection))
                {
                    insertData.ExecuteNonQuery();
                }

                this.Veranstaltungen.Form_Veranstaltungen_Load(sender, e);
                MessageBox.Show("Insert Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert Failure! " + ex.Message);
            }
            finally
            {
                this.veranstaltungenTableAdapter.Connection.Close();
                this.Hide();
                this.Veranstaltungen.ADD.Enabled = true;
            }
        }

        private string checkFields()
        {
            string strMsg = "";

            return strMsg;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Veranstaltungen.ADD.Enabled = true;

        }

    }
}
