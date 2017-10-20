using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Data;

namespace DCW
{
    public class DBHelper
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="columnName"></param>
        /// <returns>>0 is normal result | -1 is error</returns>
        public static int GetMaxLengthFromColumn(string tableName, string columnName)
        {
            Properties.Settings connset = Properties.Settings.Default;
            MySqlConnectionStringBuilder connStr = new MySqlConnectionStringBuilder();

            connStr.Server = connset.IP;
            connStr.Port = Convert.ToUInt32(connset.port);  //mysql端口号
            connStr.Database = connset.databaseName;
            connStr.UserID = connset.userName;
            connStr.Password = connset.password;

            int result = -1;
            using (MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr.ConnectionString))
            {
                try
                {
                    conn.Open();
                    string str = string.Format("SELECT max(length(`{0}`))  FROM dcw.{1};", columnName, tableName);
                    using (MySqlCommand com = new MySqlCommand(str, conn))
                    {
                        var temp = com.ExecuteScalar();
                        result = temp != null ? Convert.ToInt16(temp) : 0;
                    }
                    conn.Close();

                }
                catch (Exception e)
                {
                    result = -1;
                }
            }
            return result;
        }

        public static DataTable CreateNamePlate(int Ver_lfd)
        {
            string strSQL = "SELECT Daten_Nachname,Daten_Tit_Vor_AP,Daten_Firma1 " +
                    "FROM Veranstaltungen, TeilnehmerVeranstaltung, Daten WHERE Veranstaltungen.Ver_lfd = TeilnehmerVeranstaltung.Teil_Veranstaltunglfd " +
                    "AND TeilnehmerVeranstaltung.Teil_TeilnehmerMgl = Daten.Daten_Mitgliedsnummer " +
                    "AND Veranstaltungen.Ver_lfd = " + Ver_lfd + " " +
                    "AND TeilnehmerVeranstaltung.Teil_Rechtzeitig_Abmeldung = 0 ORDER BY Daten.Daten_Nachname; ";

            Properties.Settings connset = Properties.Settings.Default;
            MySqlConnectionStringBuilder connStr = new MySqlConnectionStringBuilder();

            connStr.Server = connset.IP;
            connStr.Port = Convert.ToUInt32(connset.port);  //mysql端口号
            connStr.Database = connset.databaseName;
            connStr.UserID = connset.userName;
            connStr.Password = connset.password;

            DataTable dt = null;
            using (MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(strSQL, conn))
                    {

                        dt = new DataTable("namePlate");
                        adapter.Fill(dt);
                    }
                    conn.Close();
                }
                catch (Exception e)
                {
                }
            }
            return dt;

        }

        public static DataTable CreateRechnungGmbH(int Ver_lfd)
        {
            string strSQL = "SELECT * FROM Veranstaltungen, TeilnehmerVeranstaltung, Daten " +
                                "WHERE Veranstaltungen.Ver_lfd = TeilnehmerVeranstaltung.Teil_Veranstaltunglfd " +
                                "AND TeilnehmerVeranstaltung.Teil_TeilnehmerMgl = Daten.Daten_Mitgliedsnummer " +
                                "AND Veranstaltungen.Ver_lfd = " + Ver_lfd+ " " +
                                "AND TeilnehmerVeranstaltung.Teil_Rechtzeitig_Abmeldung = 0 ORDER BY Daten.Daten_Nachname ; ";

            Properties.Settings connset = Properties.Settings.Default;
            MySqlConnectionStringBuilder connStr = new MySqlConnectionStringBuilder();

            connStr.Server = connset.IP;
            connStr.Port = Convert.ToUInt32(connset.port);  //mysql端口号
            connStr.Database = connset.databaseName;
            connStr.UserID = connset.userName;
            connStr.Password = connset.password;

            DataTable dt = null;
            using (MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(strSQL, conn))
                    {

                        dt = new DataTable("RechnungGmbH");
                        adapter.Fill(dt);
                    }
                    conn.Close();
                }
                catch (Exception e)
                {
                }
            }

            return dt;
        }

        
    }
}