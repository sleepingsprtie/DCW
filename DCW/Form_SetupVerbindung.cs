using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DCW
{
    public partial class Form_SetupVerbindung : Form
    {
        private Form fHauptmenu;
        private Properties.Settings connset = Properties.Settings.Default;

        public Form_SetupVerbindung(Form fHauptmenu)
        {
            InitializeComponent();
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
            MySqlConnectionStringBuilder connStr = new MySqlConnectionStringBuilder();
            connStr.Server = this.tb_IP.Text.Trim();
            connStr.Port = Convert.ToUInt32(this.tb_port.Text.Trim()) ;  //mysql端口号
            connStr.Database = this.tb_databaseName.Text.Trim();
            connStr.UserID = this.tb_userName.Text.Trim();
            connStr.Password = this.tb_password.Text.Trim();

            using (MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand com = new MySqlCommand("SELECT * FROM daten",conn))
                    {
                        com.ExecuteReader();
                    }                    
                    conn.Close();
                    MessageBox.Show("Connection with Database tested OK!", "Info",MessageBoxButtons.OK, MessageBoxIcon.Information );
                }
                catch
                {
                    MessageBox.Show("Connection with Database is defect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
