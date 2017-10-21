using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Data;
using System.Windows.Forms;

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

        public static DataTable CreateRechnung(int Ver_lfd,string[] columnNameList)
        {
            string columns = "";
            for(int i=0;i<columnNameList.Length; i++)
            {
                columns += columnNameList[i];
                if ((i + 1) < columnNameList.Length)
                    columns += ",";
            }
            string strSQL = "SELECT "+ columns + " FROM Veranstaltungen, TeilnehmerVeranstaltung, Daten " +
                                "WHERE Veranstaltungen.Ver_lfd = TeilnehmerVeranstaltung.Teil_Veranstaltunglfd " +
                                "AND TeilnehmerVeranstaltung.Teil_TeilnehmerMgl = Daten.Daten_Mitgliedsnummer " +
                                "AND Veranstaltungen.Ver_lfd = " + Ver_lfd + " " +
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


        public static void CreatePagesWord(string masterFile,DataTable dt, string[] replaceList, ProgressBar pb=null)
        {
            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document docOriginal = word.Documents.Open(masterFile);//打开 母版
            Microsoft.Office.Interop.Word.Document doc = word.Documents.Add();//新建一个文档

            docOriginal.ActiveWindow.Selection.WholeStory();//全选
            docOriginal.ActiveWindow.Selection.Copy();//剪切
            docOriginal.Close();

            if(pb!=null)
            {
                pb.Minimum = 0;
                pb.Maximum= dt.Rows.Count - 1;
                pb.Value = 0;
            }
            //progressBar2.Minimum = 0;
            //progressBar2.Maximum = dt.Rows.Count - 1;
            //progressBar2.Value = 0;

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                doc.ActiveWindow.Selection.Paste();//黏贴

                DataRow row = dt.Rows[i];
                for (int j = 0; j < replaceList.Length; j++)
                {
                    string columnName = replaceList[j];
                    string mark = string.Format("«{0}»", columnName);

                    if(columnName== "Teil_Gesamtbetrag")
                    {
                        double Teil_Gesamtbetrag = (row["Teil_Gesamtbetrag"] as double?) ?? 0;
                        Replace(doc, "«Teil_Gesamtbetrag»", Teil_Gesamtbetrag + "");
                        //*** NOTICE: Daten_Mwst 这个对应数据库的哪个栏位？
                        int Daten_Mwst = (int)(Teil_Gesamtbetrag * 0.07);
                        Replace(doc, "«Daten_Mwst»", Daten_Mwst + "");
                        //*** NOTICE: Daten_Gesamtbetrag 这个对应数据库的哪个栏位？
                        Replace(doc, "«Daten_Gesamtbetrag»", "" + (Teil_Gesamtbetrag + Daten_Mwst));
                    }
                    else
                        Replace(doc, mark, (row[columnName] as string) ?? "");

                }
                Replace(doc, "«date»", DateTime.Now.ToString("yyyy/MM/dd"));



                if ((i + 1) < dt.Rows.Count)
                {
                    Microsoft.Office.Interop.Word.Section mySec = doc.Sections.Add();//文档末尾下一页插入一个分节符

                    //光标移动到文档末端
                    object dummy = System.Reflection.Missing.Value;
                    object what = Microsoft.Office.Interop.Word.WdGoToItem.wdGoToLine;
                    object which = Microsoft.Office.Interop.Word.WdGoToDirection.wdGoToLast;
                    object count = 100;
                    word.Selection.GoTo(ref what, ref which, ref count, ref dummy);
                }
                if (pb != null)
                {
                    pb.Value = i;
                }
            }
            word.Visible = true; //使 Word 可视
        }

        public static bool Replace(Microsoft.Office.Interop.Word.Document wordDoc, string strOldText, string strNewText)
        {
            wordDoc.Content.Find.Text = strOldText;
            object FindText, ReplaceWith, Replace;// 
            object MissingValue = Type.Missing;
            FindText = strOldText;//要查找的文本
            ReplaceWith = strNewText;//替换文本
            Replace = Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll;/*wdReplaceAll - 替换找到的所有项。
                                                      * wdReplaceNone - 不替换找到的任何项。
                                                    * wdReplaceOne - 替换找到的第一项。
                                                    * */
            wordDoc.Content.Find.ClearFormatting();//移除Find的搜索文本和段落格式设置
            if (wordDoc.Content.Find.Execute(
                ref FindText, ref MissingValue,
                ref MissingValue, ref MissingValue,
                ref MissingValue, ref MissingValue,
                ref MissingValue, ref MissingValue, ref MissingValue,
                ref ReplaceWith, ref Replace,
                ref MissingValue, ref MissingValue,
                ref MissingValue, ref MissingValue))
            {
                return true;
            }
            return false;

        }


    }
}