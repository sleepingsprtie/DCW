using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DCW
{
    public partial class Form_Veranstaltungen : Form
    {
        private Form fHauptmenu;
        private Form_InsertVeranstaltungen DataInsert;
        public Form_Veranstaltungen(Form fHauptmenu)
        {
            InitializeComponent();
            this.fHauptmenu = fHauptmenu;
        }

        private void Form_Veranstaltungen_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            this.fHauptmenu.Show();
        }

        private void veranstaltungenBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.veranstaltungenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dcwDataSet);

        }

        public void Form_Veranstaltungen_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dcwDataSet.veranstaltungen”中。您可以根据需要移动或删除它。
            this.veranstaltungenTableAdapter.Fill(this.dcwDataSet.veranstaltungen);

        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.fHauptmenu.Show();
        }

        //*** 打印到 Excel 中。
        private void btn_Teilnehmerliste_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);//引用Excel工作簿 
            
            excel.ActiveSheet.Cells[1, 2] = "Name";
            excel.ActiveSheet.Cells[1, 3] = "Vorname";
            excel.ActiveSheet.Cells[1, 4] = "Firma";
            excel.ActiveSheet.Cells[1, 5] = "Ort";
            excel.ActiveSheet.Cells[1, 6] = "Teilnahme an Essen";
            excel.ActiveSheet.Cells[1, 7] = "DCW-Mitglied";

            if (this.Ver_lfd.Text == "") { return; }

            int Vernum = Convert.ToInt32(this.Ver_lfd.Text);
            dcwDataSetTableAdapters.teilnehmerveranstaltungTableAdapter tta = new dcwDataSetTableAdapters.teilnehmerveranstaltungTableAdapter();
            tta.Fill(this.dcwDataSet.teilnehmerveranstaltung);
            dcwDataSet.teilnehmerveranstaltungDataTable datensatz = tta.GetData();

            dcwDataSetTableAdapters.datenTableAdapter dta = new dcwDataSetTableAdapters.datenTableAdapter();
            dta.Fill(this.dcwDataSet.daten);
            dcwDataSet.datenDataTable daten = dta.GetData();

            progressBar2.Minimum = 0;
            progressBar2.Maximum = datensatz.Rows.Count - 1;
            progressBar2.Value = 0;

            int zeile = 2;
            for (int i = 0; i < datensatz.Rows.Count; i++)
            {
                DataRow tmpRow = datensatz.Rows[i];
                int Teil_Veranstaltunglfd = 0;
                if (tmpRow["Teil_Veranstaltunglfd"] != DBNull.Value)
                {
                    Teil_Veranstaltunglfd = Convert.ToInt32(tmpRow["Teil_Veranstaltunglfd"]);
                }
                
                bool Teil_Rechtzeitig_Abmeldung = false;
                if(tmpRow["Teil_Rechtzeitig_Abmeldung"] != System.DBNull.Value) {
                    Teil_Rechtzeitig_Abmeldung = Convert.ToBoolean(tmpRow["Teil_Rechtzeitig_Abmeldung"]);
                }
                int Teil_TeilnehmerMgl = 0;
                if (tmpRow["Teil_TeilnehmerMgl"] != DBNull.Value)
                {
                    Teil_TeilnehmerMgl = Convert.ToInt32(tmpRow["Teil_TeilnehmerMgl"]);
                }
                if ((Teil_Veranstaltunglfd == Vernum) && (!Teil_Rechtzeitig_Abmeldung))
                {
                    string Four = "";
                    for (int j = 0; j < daten.Rows.Count; j++)
                    {
                        DataRow tmpRow2 = daten.Rows[j];
                        int Daten_Mitgliedsnummer = 0;
                        if (tmpRow2["Daten_Mitgliedsnummer"]!= DBNull.Value)
                        {
                            Daten_Mitgliedsnummer = Convert.ToInt32(tmpRow2["Daten_Mitgliedsnummer"]);
                        }
                        if (Daten_Mitgliedsnummer == Teil_TeilnehmerMgl)
                        {
                            excel.ActiveSheet.Cells[zeile, 1] = Convert.ToInt32(zeile - 1);
                            excel.ActiveSheet.Cells[zeile, 2] = Convert.ToString(tmpRow2["Daten_Nachname"]);
                            excel.ActiveSheet.Cells[zeile, 3] = Convert.ToString(tmpRow2["Daten_Tit_Vor_AP"]);
                            excel.ActiveSheet.Cells[zeile, 4] = Convert.ToString(tmpRow2["Daten_Firma1"]);
                            if (Convert.ToString(tmpRow2["Daten_Firma2"]) != "")
                            {
                                if (Four == "")
                                {
                                    Four = Convert.ToString(tmpRow2["Daten_Firma2"]);
                                }
                                else
                                {
                                    Four += " " + Convert.ToString(tmpRow2["Daten_Firma2"]);
                                }
                                excel.ActiveSheet.Cells[zeile, 4] = Four;
                            }
                            excel.ActiveSheet.Cells[zeile, 5] = Convert.ToString(tmpRow2["Daten_Ort"]);
                            if (Convert.ToBoolean(tmpRow["Teil_Essen"]))
                            {
                                excel.ActiveSheet.Cells[zeile, 6] = "X";
                            }

                            if (Convert.ToString(tmpRow2["Daten_Art_Datensatz"]) == "DCW-Mitglied")
                            {
                                excel.ActiveSheet.Cells[zeile, 7] = "X";
                            }
                            else if (Convert.ToString(tmpRow2["Daten_Art_Datensatz"]) == "DCW-Mitglied 2")
                            {
                                excel.ActiveSheet.Cells[zeile, 7] = "X";
                            }

                            zeile++;
                        }
                        
                    }
                }
                progressBar2.Value = i;
                
            }
            
            //*** 格式设置
            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)excel.Rows[1, Type.Missing];
            myRange.Rows.Insert(Microsoft.Office.Interop.Excel.XlDirection.xlDown, Microsoft.Office.Interop.Excel.XlInsertFormatOrigin.xlFormatFromLeftOrAbove);
            myRange.Rows.Insert(Microsoft.Office.Interop.Excel.XlDirection.xlDown, Microsoft.Office.Interop.Excel.XlInsertFormatOrigin.xlFormatFromLeftOrAbove);

            excel.ActiveSheet.Rows[3].Font.Bold = "True";

            Microsoft.Office.Interop.Excel.Range allRange = excel.Columns;
            allRange.AutoFit();

            excel.ActiveSheet.Cells[1, 1] = "Teilnehmerliste Veranstaltung " + this.ver_TitelTextBox.Text;
            excel.Cells[1, 1].Font.Bold = "True";
            excel.Cells[1, 1].Font.Size = 14;

            excel.ActiveSheet.PageSetup.PrintArea = "$A$1:$G$" + (zeile + 2);
            //excel.ActiveSheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape;
            //excel.ActiveSheet.PageSetup.FitToPagesWide = 1;
            excel.ActiveSheet.PageSetup.PrintTitleRows = "$1:$3";
            //excel.ActiveSheet.PageSetup.PrintGridlines = "True";
            excel.Visible = true; //使Excel可视
            excel = null;
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            this.DataInsert = new Form_InsertVeranstaltungen(this);
            this.ADD.Enabled = false;
            this.DataInsert.ShowDialog();
        }

        private void btn_Namensschilder_Click(object sender, EventArgs e)
        {
            try
            {
                using (DataTable dt = DCWHelper.CreateNamePlate(Convert.ToInt32(this.Ver_lfd.Text)))
                {
                    if (dt == null)
                        return;
                    int rowNum= (int)Math.Ceiling(dt.Rows.Count/2d)*2;


                    Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
                    Microsoft.Office.Interop.Word.Document doc = app.Documents.Add();
                    doc.PageSetup.TopMargin = 1f / 0.035f;
                    doc.PageSetup.BottomMargin = 0.52f / 0.035f;
                    doc.PageSetup.LeftMargin = 2f / 0.035f;
                    doc.PageSetup.RightMargin = 2f / 0.035f;
                    Microsoft.Office.Interop.Word.Table table = doc.Tables.Add(app.Selection.Range, rowNum, 2);
                    table.Columns[1].Width = 236f;
                    table.Columns[2].Width = 236f;
                    
                    //图片地址
                    string fileName = Application.StartupPath + "\\logo1.png";
                    object linkToFile = false;
                    object saveWithDocument = true;

                    progressBar2.Minimum = 0;
                    progressBar2.Maximum = dt.Rows.Count-1;
                    progressBar2.Value = 0;

                    for (int i=0;i<dt.Rows.Count; i++)
                    {
                        DataRow row = dt.Rows[i];
                        string surename = (row["Daten_Nachname"] as string) ?? "";
                        string name = (row["Daten_Tit_Vor_AP"] as string) ?? "";
                        string firm = (row["Daten_Firma1"] as string) ?? "";

                        int indexRow = (int)Math.Floor(i / 2d)*2 + 1;
                        int indexColumn = (i % 2) + 1;


                        table.Cell(indexRow, indexColumn).Select();
                        table.Cell(indexRow, indexColumn).Height = 2f / 0.035f;
                        object range = app.Selection.Range;
                        
                        Microsoft.Office.Interop.Word.InlineShape shape = app.ActiveDocument.InlineShapes.AddPicture(fileName, ref linkToFile, ref saveWithDocument, ref range);
                        shape.Width = 3.76f / 0.035f;//图片宽度
                        shape.Height = 0.96f / 0.035f;//图片高度
                        shape.ConvertToShape().WrapFormat.Type = Microsoft.Office.Interop.Word.WdWrapType.wdWrapInline;//四周环绕的方式
                        app.Selection.Cells.VerticalAlignment = Microsoft.Office.Interop.Word.WdCellVerticalAlignment.wdCellAlignVerticalBottom;//垂直居中
                        app.Selection.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;//水平居中
 


                        table.Cell(indexRow + 1, indexColumn).Range.Text = string.Format("{0},{1}",surename,name);
                        table.Cell(indexRow + 1, indexColumn).Range.InsertParagraphAfter();//插入回车
                        table.Cell(indexRow + 1, indexColumn).Range.InsertAfter(firm);

                        table.Cell(indexRow + 1, indexColumn).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;//左对齐
                        table.Cell(indexRow + 1, indexColumn).Range.Font.Bold = 1;
                        table.Cell(indexRow + 1, indexColumn).Range.Font.Name = "Arial";
                        table.Cell(indexRow + 1, indexColumn).Range.Font.Size = 14;

                        progressBar2.Value = i;
                    }
                    app.Visible = true;
                    return;
                }
       
            }
            catch (Exception ex)
            {
                MessageBox.Show("Close Namensschilder.doc First!" + ex.Message);
            }
        }

        private void btn_Rechnungen_GmbH_Click(object sender, EventArgs e)
        {
            try
            {
                string[] columnNameList = { "Daten_Firma1", "Daten_Firma2", "Daten_Tit_Vor_AP", "Daten_Nachname", "Daten_Strasse", "Daten_PLZ", "Daten_Ort", "Daten_Mitgliedsnummer" };
                //*** NOTICE: Daten_Rechnungsnummer 这个对应数据库的哪个栏位？
                //Replace(doc, "«Daten_Rechnungsnummer»", (row["Daten_Rechnungsnummer"] as string) ?? "");
                DataTable dt =DCWHelper.CreateRechnung(Convert.ToInt32(this.Ver_lfd.Text),columnNameList);
                DCWHelper.CreatePagesWord(Application.StartupPath + "\\Rechnung_Veranstaltung_GmbH.doc", dt, columnNameList,progressBar2);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Close Rechnung_Veranstaltung_GmbH.doc First!" + ex.Message);
            }
        }

        private void btn_Rechnungen_Verein_Click(object sender, EventArgs e)
        {
            try
            {
                //*** NOTICE: Daten_Rechnungsnummer 这个对应数据库的哪个栏位？
                // Replace(wordDoc, "«Daten_Rechnungsnummer»", "");          
                //*** NOTICE: Daten_Rechnungsnummer 这个对应数据库的哪个栏位？
                //Replace(doc, "«Daten_Rechnungsnummer»", (row["Daten_Rechnungsnummer"] as string) ?? "");
                string[] columnNameList = { "Daten_Firma1", "Daten_Firma2", "Daten_Strasse", "Daten_PLZ", "Daten_Ort", "Daten_Mitgliedsnummer", "Daten_Tit_Vor_AP", "Daten_Nachname","Teil_Gesamtbetrag" };
                
                DataTable dt = DCWHelper.CreateRechnung(Convert.ToInt32(this.Ver_lfd.Text), columnNameList);
                DCWHelper.CreatePagesWord(Application.StartupPath + "\\Rechnung_Veranstaltung_Verein.doc", dt, columnNameList,progressBar2);

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Close Rechnung_Veranstaltung_Verein.doc First!" + ex.Message);
            }
        }

        public bool Replace(Microsoft.Office.Interop.Word.Document wordDoc, string strOldText, string strNewText)
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

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Comfirm Delete?", "title", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                this.veranstaltungenBindingSource.RemoveCurrent();
            }
        }

    }
}
