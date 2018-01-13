using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Xml;

namespace DCW
{
    public partial class Form_SetupVerbindung : Form
    {
        private Form fHauptmenu;
        private Properties.Settings connset = Properties.Settings.Default;

        public Form_SetupVerbindung(Form fHauptmenu)
        {
            InitializeComponent();

            XmlDocument doc = new XmlDocument();
            doc.Load("config.xml");
            if (doc != null)
            {
                //分析文件  
                XmlNode node = doc.SelectSingleNode("//DCW/database");
                if (node != null)
                {
                    connset.IP = node.Attributes["IP"].InnerText.Trim();
                    connset.port = node.Attributes["port"].InnerText.Trim();
                    connset.userName = node.Attributes["userName"].InnerText.Trim();
                    connset.password = node.Attributes["password"].InnerText.Trim();
                    connset.databaseName = node.Attributes["databaseName"].InnerText.Trim();
                    connset.Save();
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



            this.fHauptmenu = fHauptmenu;
            this.tb_IP.Text = connset.IP;
            this.tb_port.Text = connset.port;
            this.tb_userName.Text = connset.userName;
            this.tb_password.Text = connset.password;
            this.tb_databaseName.Text = connset.databaseName;
            connset.MysqlConnectionString = "server=" + connset.IP + ";user id=" + connset.userName + ";password=" + connset.password + ";persistsecurityinfo=True;database=" + connset.databaseName + "";
            //Properties.Settings.Default.SetConnectionString("server=mysql.w3.sqlkunden.de;user id=m_wei_dcw;password=Koeln@2015;persistsecurityinfo=True;database=m_wei_dcw");
            connset.Save();
            label6.Text = connset.MysqlConnectionString;
        }
        private void Form_SetupVerbindung_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            this.fHauptmenu.Show();
        }
        private void btn_DBConnectionTest_Click(object sender, EventArgs e)
        {
            if(DCWHelper.IsDBConnected(this.tb_IP.Text.Trim(), 
                Convert.ToUInt32(this.tb_port.Text.Trim()), 
                this.tb_databaseName.Text.Trim(), 
                this.tb_userName.Text.Trim(), 
                this.tb_password.Text.Trim()))
            {
                MessageBox.Show("Connection with Database tested OK!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Connection with Database is defect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            connset.IP = this.tb_IP.Text.Trim();
            connset.port=this.tb_port.Text.Trim();
            connset.userName = this.tb_userName.Text.Trim();
            connset.password = this.tb_password.Text.Trim();
            connset.databaseName = this.tb_databaseName.Text.Trim();

            connset.MysqlConnectionString = "server=" + connset.IP + ";user id=" + connset.userName + ";password=" + connset.password + ";persistsecurityinfo=True;database=" + connset.databaseName + "";
            //Properties.Settings.Default.SetConnectionString("server=mysql.w3.sqlkunden.de;user id=m_wei_dcw;password=Koeln@2015;persistsecurityinfo=True;database=m_wei_dcw");
            connset.Save();

            XmlDocument doc = new XmlDocument();
            doc.Load("config.xml");
            if (doc != null)
            {
                //分析文件  
                XmlNode node = doc.SelectSingleNode("//DCW/database");
                if (node != null)
                {
                    node.Attributes["IP"].InnerText=connset.IP;
                    node.Attributes["port"].InnerText=connset.port;
                    node.Attributes["userName"].InnerText=connset.userName;
                    node.Attributes["password"].InnerText=connset.password;
                    node.Attributes["databaseName"].InnerText=connset.databaseName;
                    doc.Save("config.xml");
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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.tb_IP.Text = connset.IP;
            this.tb_port.Text = connset.port;
            this.tb_userName.Text = connset.userName;
            this.tb_password.Text = connset.password;
            this.tb_databaseName.Text = connset.databaseName;
        }

        private void btn_setLocal_Click(object sender, EventArgs e)
        {
            this.tb_IP.Text = "127.0.0.1";
            this.tb_port.Text = "3306";
            this.tb_userName.Text = "root";
            this.tb_password.Text = "123123";
            this.tb_databaseName.Text ="dcw";
        }

        private void btn_setRemoting_Click(object sender, EventArgs e)
        {
            this.tb_IP.Text = "mysql.w3.sqlkunden.de";
            this.tb_port.Text = "3306";
            this.tb_userName.Text = "m_wei_dcw";
            this.tb_password.Text = "Koeln@2015";
            this.tb_databaseName.Text = "m_wei_dcw";
            //server=mysql.w3.sqlkunden.de;user id=m_wei_dcw;password=Koeln@2015;persistsecurityinfo=True;database=m_wei_dcw");
        }
    }
}
