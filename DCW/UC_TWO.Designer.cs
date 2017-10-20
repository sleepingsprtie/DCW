namespace DCW
{
    partial class UC_TWO
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_TWO));
            this.Teil_Veranstaltung_Datum = new System.Windows.Forms.TextBox();
            this.Teil_Veranstaltung_Titel = new System.Windows.Forms.TextBox();
            this.Teil_Veranstaltung_Ort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Teil_Anmeldung_Datum = new System.Windows.Forms.TextBox();
            this.Teil_Gebuehr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Teil_Mwst = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Teil_Gesamtbetrag = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Teil_Essen = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Teil_Rechtzeitig_Abmeldung = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Teil_Zahlung_Betrag = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Teil_lfd = new System.Windows.Forms.TextBox();
            this.dcwDataSet = new DCW.dcwDataSet();
            this.teilnehmerveranstaltungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teilnehmerveranstaltungTableAdapter = new DCW.dcwDataSetTableAdapters.teilnehmerveranstaltungTableAdapter();
            this.Teil_Bezahlt_Am = new System.Windows.Forms.DateTimePicker();
            this.delete = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dcwDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teilnehmerveranstaltungBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Teil_Veranstaltung_Datum
            // 
            this.Teil_Veranstaltung_Datum.Location = new System.Drawing.Point(72, 14);
            this.Teil_Veranstaltung_Datum.Name = "Teil_Veranstaltung_Datum";
            this.Teil_Veranstaltung_Datum.ReadOnly = true;
            this.Teil_Veranstaltung_Datum.Size = new System.Drawing.Size(179, 21);
            this.Teil_Veranstaltung_Datum.TabIndex = 0;
            // 
            // Teil_Veranstaltung_Titel
            // 
            this.Teil_Veranstaltung_Titel.Location = new System.Drawing.Point(257, 14);
            this.Teil_Veranstaltung_Titel.Name = "Teil_Veranstaltung_Titel";
            this.Teil_Veranstaltung_Titel.ReadOnly = true;
            this.Teil_Veranstaltung_Titel.Size = new System.Drawing.Size(249, 21);
            this.Teil_Veranstaltung_Titel.TabIndex = 1;
            // 
            // Teil_Veranstaltung_Ort
            // 
            this.Teil_Veranstaltung_Ort.Location = new System.Drawing.Point(512, 14);
            this.Teil_Veranstaltung_Ort.Name = "Teil_Veranstaltung_Ort";
            this.Teil_Veranstaltung_Ort.ReadOnly = true;
            this.Teil_Veranstaltung_Ort.Size = new System.Drawing.Size(126, 21);
            this.Teil_Veranstaltung_Ort.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Angemeldet am:";
            // 
            // Teil_Anmeldung_Datum
            // 
            this.Teil_Anmeldung_Datum.Location = new System.Drawing.Point(37, 67);
            this.Teil_Anmeldung_Datum.Name = "Teil_Anmeldung_Datum";
            this.Teil_Anmeldung_Datum.ReadOnly = true;
            this.Teil_Anmeldung_Datum.Size = new System.Drawing.Size(179, 21);
            this.Teil_Anmeldung_Datum.TabIndex = 4;
            // 
            // Teil_Gebuehr
            // 
            this.Teil_Gebuehr.Location = new System.Drawing.Point(242, 66);
            this.Teil_Gebuehr.Name = "Teil_Gebuehr";
            this.Teil_Gebuehr.ReadOnly = true;
            this.Teil_Gebuehr.Size = new System.Drawing.Size(110, 21);
            this.Teil_Gebuehr.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Teilnahmegebühr:";
            // 
            // Teil_Mwst
            // 
            this.Teil_Mwst.Location = new System.Drawing.Point(359, 67);
            this.Teil_Mwst.Name = "Teil_Mwst";
            this.Teil_Mwst.ReadOnly = true;
            this.Teil_Mwst.Size = new System.Drawing.Size(100, 21);
            this.Teil_Mwst.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mwst:";
            // 
            // Teil_Gesamtbetrag
            // 
            this.Teil_Gesamtbetrag.Location = new System.Drawing.Point(503, 66);
            this.Teil_Gesamtbetrag.Name = "Teil_Gesamtbetrag";
            this.Teil_Gesamtbetrag.Size = new System.Drawing.Size(135, 21);
            this.Teil_Gesamtbetrag.TabIndex = 9;
            this.Teil_Gesamtbetrag.LostFocus += new System.EventHandler(this.Teil_Gesamtbetrag_LostFocus);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "Gesamtbetrag:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "Essen";
            // 
            // Teil_Essen
            // 
            this.Teil_Essen.AutoSize = true;
            this.Teil_Essen.Location = new System.Drawing.Point(58, 107);
            this.Teil_Essen.Name = "Teil_Essen";
            this.Teil_Essen.Size = new System.Drawing.Size(15, 14);
            this.Teil_Essen.TabIndex = 12;
            this.Teil_Essen.UseVisualStyleBackColor = true;
            this.Teil_Essen.LostFocus += new System.EventHandler(this.Teil_Essen_LostFocus);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "rechtzeitig abgemeldet?";
            // 
            // Teil_Rechtzeitig_Abmeldung
            // 
            this.Teil_Rechtzeitig_Abmeldung.AutoSize = true;
            this.Teil_Rechtzeitig_Abmeldung.Location = new System.Drawing.Point(228, 105);
            this.Teil_Rechtzeitig_Abmeldung.Name = "Teil_Rechtzeitig_Abmeldung";
            this.Teil_Rechtzeitig_Abmeldung.Size = new System.Drawing.Size(15, 14);
            this.Teil_Rechtzeitig_Abmeldung.TabIndex = 14;
            this.Teil_Rechtzeitig_Abmeldung.UseVisualStyleBackColor = true;
            this.Teil_Rechtzeitig_Abmeldung.LostFocus += new System.EventHandler(this.Teil_Rechtzeitig_Abmeldung_LostFocus);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "EUR";
            // 
            // Teil_Zahlung_Betrag
            // 
            this.Teil_Zahlung_Betrag.Location = new System.Drawing.Point(267, 102);
            this.Teil_Zahlung_Betrag.Name = "Teil_Zahlung_Betrag";
            this.Teil_Zahlung_Betrag.Size = new System.Drawing.Size(100, 21);
            this.Teil_Zahlung_Betrag.TabIndex = 16;
            this.Teil_Zahlung_Betrag.LostFocus += new System.EventHandler(this.Teil_Zahlung_Betrag_LostFocus);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(373, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "bezahlt am:";
            // 
            // Teil_lfd
            // 
            this.Teil_lfd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Teil_lfd.Location = new System.Drawing.Point(32, 29);
            this.Teil_lfd.Name = "Teil_lfd";
            this.Teil_lfd.Size = new System.Drawing.Size(41, 21);
            this.Teil_lfd.TabIndex = 19;
            this.Teil_lfd.Visible = false;
            // 
            // dcwDataSet
            // 
            this.dcwDataSet.DataSetName = "dcwDataSet";
            this.dcwDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teilnehmerveranstaltungBindingSource
            // 
            this.teilnehmerveranstaltungBindingSource.DataMember = "teilnehmerveranstaltung";
            this.teilnehmerveranstaltungBindingSource.DataSource = this.dcwDataSet;
            // 
            // teilnehmerveranstaltungTableAdapter
            // 
            this.teilnehmerveranstaltungTableAdapter.ClearBeforeFill = true;
            // 
            // Teil_Bezahlt_Am
            // 
            this.Teil_Bezahlt_Am.Location = new System.Drawing.Point(446, 101);
            this.Teil_Bezahlt_Am.Name = "Teil_Bezahlt_Am";
            this.Teil_Bezahlt_Am.Size = new System.Drawing.Size(200, 21);
            this.Teil_Bezahlt_Am.TabIndex = 20;
            this.Teil_Bezahlt_Am.LostFocus += new System.EventHandler(this.Teil_Bezahlt_Am_LostFocus);
            // 
            // delete
            // 
            this.delete.AutoSize = true;
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.Location = new System.Drawing.Point(11, 14);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(17, 12);
            this.delete.TabIndex = 21;
            this.delete.Text = "  ";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // UC_TWO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.delete);
            this.Controls.Add(this.Teil_Bezahlt_Am);
            this.Controls.Add(this.Teil_lfd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Teil_Zahlung_Betrag);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Teil_Rechtzeitig_Abmeldung);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Teil_Essen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Teil_Gesamtbetrag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Teil_Mwst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Teil_Gebuehr);
            this.Controls.Add(this.Teil_Anmeldung_Datum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Teil_Veranstaltung_Ort);
            this.Controls.Add(this.Teil_Veranstaltung_Titel);
            this.Controls.Add(this.Teil_Veranstaltung_Datum);
            this.Name = "UC_TWO";
            this.Size = new System.Drawing.Size(649, 140);
            ((System.ComponentModel.ISupportInitialize)(this.dcwDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teilnehmerveranstaltungBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource teilnehmerveranstaltungBindingSource;
        private dcwDataSet dcwDataSet;
        private dcwDataSetTableAdapters.teilnehmerveranstaltungTableAdapter teilnehmerveranstaltungTableAdapter;
        public System.Windows.Forms.TextBox Teil_Veranstaltung_Datum;
        public System.Windows.Forms.TextBox Teil_Veranstaltung_Titel;
        public System.Windows.Forms.TextBox Teil_Veranstaltung_Ort;
        public System.Windows.Forms.TextBox Teil_Anmeldung_Datum;
        public System.Windows.Forms.TextBox Teil_Gebuehr;
        public System.Windows.Forms.TextBox Teil_Mwst;
        public System.Windows.Forms.TextBox Teil_Gesamtbetrag;
        public System.Windows.Forms.CheckBox Teil_Essen;
        public System.Windows.Forms.CheckBox Teil_Rechtzeitig_Abmeldung;
        public System.Windows.Forms.TextBox Teil_Zahlung_Betrag;
        public System.Windows.Forms.TextBox Teil_lfd;
        private System.Windows.Forms.DateTimePicker Teil_Bezahlt_Am;
        private System.Windows.Forms.Label delete;
    }
}
