using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace DCW
{
    public partial class Form_Hauptmenue : Form
    {
        private Form_Kartei fKartai;
        private Form_Veranstaltungen fVeranstaltungen;
        private Form_Administrator fAdministraor;
        private Form_SetupVerbindung fSetupVerbindung;
        private string nowVersion = "";
        public Form_Hauptmenue()
        {
            InitializeComponent();
            try
            {
                this.fKartai = new Form_Kartei(this);
            }
            catch { }
            try
            {
                this.fVeranstaltungen = new Form_Veranstaltungen(this);
            }
            catch { }
            try
            {
                this.fSetupVerbindung = new Form_SetupVerbindung(this);
            }
            catch { }
            try
            {
                this.fAdministraor = new Form_Administrator(this);
            }
            catch { }

            XmlDocument doc = new XmlDocument();
            doc.Load("config.xml");
            if (doc != null)
            {
                //分析文件  
                XmlNode node = doc.SelectSingleNode("//DCW/configuration");
                if (node != null)
                {
                    this.nowVersion = node.Attributes["version"].InnerText.Trim();
                    this.Text += " Ver."+this.nowVersion;


                }
                else
                {
                    MessageBox.Show("DCW.xml is defect", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Can't get local config.xml", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Kartei_Click(object sender, EventArgs e)
        {
            this.fKartai.Show();
            this.Hide();
        }

        private void btn_Veranstaltungen_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.fVeranstaltungen.Show();
        }

        private void btn_SetupVerbindung_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.fSetupVerbindung.Show();
        }

        private void btn_AdministratorLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.fAdministraor.Show();
        }

        
    }
}
