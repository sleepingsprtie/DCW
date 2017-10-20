namespace DCW
{
    partial class UC_THREE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_THREE));
            this.Bei_Beitragsjahr = new System.Windows.Forms.TextBox();
            this.Bei_Betrag = new System.Windows.Forms.TextBox();
            this.Bei_Datum = new System.Windows.Forms.TextBox();
            this.dcwDataSet = new DCW.dcwDataSet();
            this.teilnehmerveranstaltungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teilnehmerveranstaltungTableAdapter = new DCW.dcwDataSetTableAdapters.teilnehmerveranstaltungTableAdapter();
            this.delete = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Bei_lfd = new System.Windows.Forms.TextBox();
            this.beiträgeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beiträgeTableAdapter = new DCW.dcwDataSetTableAdapters.beiträgeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dcwDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teilnehmerveranstaltungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beiträgeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Bei_Beitragsjahr
            // 
            this.Bei_Beitragsjahr.Location = new System.Drawing.Point(50, 29);
            this.Bei_Beitragsjahr.Name = "Bei_Beitragsjahr";
            this.Bei_Beitragsjahr.ReadOnly = true;
            this.Bei_Beitragsjahr.Size = new System.Drawing.Size(101, 21);
            this.Bei_Beitragsjahr.TabIndex = 0;
            // 
            // Bei_Betrag
            // 
            this.Bei_Betrag.Location = new System.Drawing.Point(177, 26);
            this.Bei_Betrag.Name = "Bei_Betrag";
            this.Bei_Betrag.ReadOnly = true;
            this.Bei_Betrag.Size = new System.Drawing.Size(126, 21);
            this.Bei_Betrag.TabIndex = 1;
            // 
            // Bei_Datum
            // 
            this.Bei_Datum.Location = new System.Drawing.Point(349, 25);
            this.Bei_Datum.Name = "Bei_Datum";
            this.Bei_Datum.ReadOnly = true;
            this.Bei_Datum.Size = new System.Drawing.Size(163, 21);
            this.Bei_Datum.TabIndex = 2;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(514, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 25;
            this.label4.Text = "Bei_lfd:";
            // 
            // Bei_lfd
            // 
            this.Bei_lfd.Location = new System.Drawing.Point(557, 25);
            this.Bei_lfd.Name = "Bei_lfd";
            this.Bei_lfd.ReadOnly = true;
            this.Bei_lfd.Size = new System.Drawing.Size(130, 21);
            this.Bei_lfd.TabIndex = 26;
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
            // UC_THREE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Bei_lfd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.Bei_Datum);
            this.Controls.Add(this.Bei_Betrag);
            this.Controls.Add(this.Bei_Beitragsjahr);
            this.Name = "UC_THREE";
            this.Size = new System.Drawing.Size(696, 60);
            ((System.ComponentModel.ISupportInitialize)(this.dcwDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teilnehmerveranstaltungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beiträgeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource teilnehmerveranstaltungBindingSource;
        private dcwDataSet dcwDataSet;
        private dcwDataSetTableAdapters.teilnehmerveranstaltungTableAdapter teilnehmerveranstaltungTableAdapter;
        public System.Windows.Forms.TextBox Bei_Beitragsjahr;
        public System.Windows.Forms.TextBox Bei_Betrag;
        public System.Windows.Forms.TextBox Bei_Datum;
        private System.Windows.Forms.Label delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Bei_lfd;
        private System.Windows.Forms.BindingSource beiträgeBindingSource;
        private dcwDataSetTableAdapters.beiträgeTableAdapter beiträgeTableAdapter;
    }
}
