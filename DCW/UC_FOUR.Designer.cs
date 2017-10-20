namespace DCW
{
    partial class UC_FOUR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_FOUR));
            this.CT_Beitragsjahr = new System.Windows.Forms.TextBox();
            this.CT_Betrag = new System.Windows.Forms.TextBox();
            this.CT_Datum = new System.Windows.Forms.TextBox();
            this.dcwDataSet = new DCW.dcwDataSet();
            this.teilnehmerveranstaltungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teilnehmerveranstaltungTableAdapter = new DCW.dcwDataSetTableAdapters.teilnehmerveranstaltungTableAdapter();
            this.delete = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.beiträgeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beiträgeTableAdapter = new DCW.dcwDataSetTableAdapters.beiträgeTableAdapter();
            this.CT_lfd = new System.Windows.Forms.TextBox();
            this.ctbeiträgeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ct_beiträgeTableAdapter = new DCW.dcwDataSetTableAdapters.ct_beiträgeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dcwDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teilnehmerveranstaltungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beiträgeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbeiträgeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CT_Beitragsjahr
            // 
            this.CT_Beitragsjahr.Location = new System.Drawing.Point(50, 29);
            this.CT_Beitragsjahr.Name = "CT_Beitragsjahr";
            this.CT_Beitragsjahr.ReadOnly = true;
            this.CT_Beitragsjahr.Size = new System.Drawing.Size(101, 21);
            this.CT_Beitragsjahr.TabIndex = 0;
            // 
            // CT_Betrag
            // 
            this.CT_Betrag.Location = new System.Drawing.Point(177, 26);
            this.CT_Betrag.Name = "CT_Betrag";
            this.CT_Betrag.ReadOnly = true;
            this.CT_Betrag.Size = new System.Drawing.Size(126, 21);
            this.CT_Betrag.TabIndex = 1;
            // 
            // CT_Datum
            // 
            this.CT_Datum.Location = new System.Drawing.Point(349, 25);
            this.CT_Datum.Name = "CT_Datum";
            this.CT_Datum.ReadOnly = true;
            this.CT_Datum.Size = new System.Drawing.Size(163, 21);
            this.CT_Datum.TabIndex = 2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "Für Jahr:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "Betrag:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "gezahlt am:";
            // 
            // beiträgeBindingSource
            // 
            this.beiträgeBindingSource.DataMember = "beiträge";
            this.beiträgeBindingSource.DataSource = this.dcwDataSet;
            // 
            // beiträgeTableAdapter
            // 
            this.beiträgeTableAdapter.ClearBeforeFill = true;
            // 
            // CT_lfd
            // 
            this.CT_lfd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CT_lfd.Location = new System.Drawing.Point(3, 29);
            this.CT_lfd.Name = "CT_lfd";
            this.CT_lfd.Size = new System.Drawing.Size(41, 21);
            this.CT_lfd.TabIndex = 25;
            this.CT_lfd.Visible = false;
            // 
            // ctbeiträgeBindingSource
            // 
            this.ctbeiträgeBindingSource.DataMember = "ct_beiträge";
            this.ctbeiträgeBindingSource.DataSource = this.dcwDataSet;
            // 
            // ct_beiträgeTableAdapter
            // 
            this.ct_beiträgeTableAdapter.ClearBeforeFill = true;
            // 
            // UC_FOUR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.CT_lfd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.CT_Datum);
            this.Controls.Add(this.CT_Betrag);
            this.Controls.Add(this.CT_Beitragsjahr);
            this.Name = "UC_FOUR";
            this.Size = new System.Drawing.Size(542, 60);
            ((System.ComponentModel.ISupportInitialize)(this.dcwDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teilnehmerveranstaltungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beiträgeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbeiträgeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource teilnehmerveranstaltungBindingSource;
        private dcwDataSet dcwDataSet;
        private dcwDataSetTableAdapters.teilnehmerveranstaltungTableAdapter teilnehmerveranstaltungTableAdapter;
        public System.Windows.Forms.TextBox CT_Beitragsjahr;
        public System.Windows.Forms.TextBox CT_Betrag;
        public System.Windows.Forms.TextBox CT_Datum;
        private System.Windows.Forms.Label delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource beiträgeBindingSource;
        private dcwDataSetTableAdapters.beiträgeTableAdapter beiträgeTableAdapter;
        public System.Windows.Forms.TextBox CT_lfd;
        private System.Windows.Forms.BindingSource ctbeiträgeBindingSource;
        private dcwDataSetTableAdapters.ct_beiträgeTableAdapter ct_beiträgeTableAdapter;
    }
}
