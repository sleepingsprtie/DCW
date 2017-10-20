namespace DCW
{
    partial class Form_Administrator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Administrator));
            this.dcwDataSet = new DCW.dcwDataSet();
            this.t_wer_macht_wasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_wer_macht_wasTableAdapter = new DCW.dcwDataSetTableAdapters.t_wer_macht_wasTableAdapter();
            this.tableAdapterManager = new DCW.dcwDataSetTableAdapters.TableAdapterManager();
            this.t_dienstleistungenTableAdapter = new DCW.dcwDataSetTableAdapters.t_dienstleistungenTableAdapter();
            this.t_wer_macht_wasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.t_wer_macht_wasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.t_wer_macht_wasDataGridView = new System.Windows.Forms.DataGridView();
            this.tdienstleistungenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cb_dienstleistung = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dienstleistung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f_dienstleistung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dcwDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_wer_macht_wasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_wer_macht_wasBindingNavigator)).BeginInit();
            this.t_wer_macht_wasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_wer_macht_wasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdienstleistungenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dcwDataSet
            // 
            this.dcwDataSet.DataSetName = "dcwDataSet";
            this.dcwDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_wer_macht_wasBindingSource
            // 
            this.t_wer_macht_wasBindingSource.DataMember = "t_wer_macht_was";
            this.t_wer_macht_wasBindingSource.DataSource = this.dcwDataSet;
            // 
            // t_wer_macht_wasTableAdapter
            // 
            this.t_wer_macht_wasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.beiträgeTableAdapter = null;
            this.tableAdapterManager.berliner_nummernTableAdapter = null;
            this.tableAdapterManager.berlinerTableAdapter = null;
            this.tableAdapterManager.branchenTableAdapter = null;
            this.tableAdapterManager.bundeslandTableAdapter = null;
            this.tableAdapterManager.china_import_muetter_adressenTableAdapter = null;
            this.tableAdapterManager.china_import_töc_finalTableAdapter = null;
            this.tableAdapterManager.china_toechtermails_importTableAdapter = null;
            this.tableAdapterManager.china_weitere_importTableAdapter = null;
            this.tableAdapterManager.clean_mailsTableAdapter = null;
            this.tableAdapterManager.ct_beiträgeTableAdapter = null;
            this.tableAdapterManager.daten_exportfehlerTableAdapter = null;
            this.tableAdapterManager.daten_sicherheitskopieTableAdapter = null;
            this.tableAdapterManager.datenTableAdapter = null;
            this.tableAdapterManager.dokumenteTableAdapter = null;
            this.tableAdapterManager.einfügefehler_010414TableAdapter = null;
            this.tableAdapterManager.falschemailTableAdapter = null;
            this.tableAdapterManager.gute_mailsTableAdapter = null;
            this.tableAdapterManager.hongTableAdapter = null;
            this.tableAdapterManager.jahresbericht_beraterTableAdapter = null;
            this.tableAdapterManager.jiTableAdapter = null;
            this.tableAdapterManager.jobsTableAdapter = null;
            this.tableAdapterManager.laufTableAdapter = null;
            this.tableAdapterManager.materialTableAdapter = null;
            this.tableAdapterManager.mitglieder_rundmail_verteilerTableAdapter = null;
            this.tableAdapterManager.msyscompacterrorTableAdapter = null;
            this.tableAdapterManager.pressesprecher_oderTableAdapter = null;
            this.tableAdapterManager.q_daten_lfd_mitglied_noTableAdapter = null;
            this.tableAdapterManager.rechnungenctTableAdapter = null;
            this.tableAdapterManager.rechnungenmgbTableAdapter = null;
            this.tableAdapterManager.t_branchenTableAdapter = null;
            this.tableAdapterManager.t_daten_exportTableAdapter = null;
            this.tableAdapterManager.t_dienst_suchprofileTableAdapter = null;
            this.tableAdapterManager.t_dienstleisterTableAdapter = null;
            this.tableAdapterManager.t_dienstleistungenTableAdapter = this.t_dienstleistungenTableAdapter;
            this.tableAdapterManager.t_dienstleistungsgruppenTableAdapter = null;
            this.tableAdapterManager.t_filt_dienst_wasTableAdapter = null;
            this.tableAdapterManager.t_filt_dienst_werTableAdapter = null;
            this.tableAdapterManager.t_jahresbericht_werbung_nicht_mitgliederTableAdapter = null;
            this.tableAdapterManager.t_laender_und_weltregionenTableAdapter = null;
            this.tableAdapterManager.t_no_more_mailsTableAdapter = null;
            this.tableAdapterManager.t_standorteTableAdapter = null;
            this.tableAdapterManager.t_wer_fuer_wenTableAdapter = null;
            this.tableAdapterManager.t_wer_internat_maerkteTableAdapter = null;
            this.tableAdapterManager.t_wer_ist_woTableAdapter = null;
            this.tableAdapterManager.t_wer_macht_wasTableAdapter = this.t_wer_macht_wasTableAdapter;
            this.tableAdapterManager.teilnehmerveranstaltungTableAdapter = null;
            this.tableAdapterManager.todoTableAdapter = null;
            this.tableAdapterManager.tote_mailsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DCW.dcwDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.veranstaltungenTableAdapter = null;
            // 
            // t_dienstleistungenTableAdapter
            // 
            this.t_dienstleistungenTableAdapter.ClearBeforeFill = true;
            // 
            // t_wer_macht_wasBindingNavigator
            // 
            this.t_wer_macht_wasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.t_wer_macht_wasBindingNavigator.BindingSource = this.t_wer_macht_wasBindingSource;
            this.t_wer_macht_wasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.t_wer_macht_wasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.t_wer_macht_wasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.t_wer_macht_wasBindingNavigatorSaveItem});
            this.t_wer_macht_wasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.t_wer_macht_wasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.t_wer_macht_wasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.t_wer_macht_wasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.t_wer_macht_wasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.t_wer_macht_wasBindingNavigator.Name = "t_wer_macht_wasBindingNavigator";
            this.t_wer_macht_wasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.t_wer_macht_wasBindingNavigator.Size = new System.Drawing.Size(734, 25);
            this.t_wer_macht_wasBindingNavigator.TabIndex = 0;
            this.t_wer_macht_wasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新添";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // t_wer_macht_wasBindingNavigatorSaveItem
            // 
            this.t_wer_macht_wasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.t_wer_macht_wasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("t_wer_macht_wasBindingNavigatorSaveItem.Image")));
            this.t_wer_macht_wasBindingNavigatorSaveItem.Name = "t_wer_macht_wasBindingNavigatorSaveItem";
            this.t_wer_macht_wasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.t_wer_macht_wasBindingNavigatorSaveItem.Text = "保存数据";
            this.t_wer_macht_wasBindingNavigatorSaveItem.Click += new System.EventHandler(this.t_wer_macht_wasBindingNavigatorSaveItem_Click);
            // 
            // t_wer_macht_wasDataGridView
            // 
            this.t_wer_macht_wasDataGridView.AutoGenerateColumns = false;
            this.t_wer_macht_wasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.t_wer_macht_wasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Dienstleistung,
            this.f_dienstleistung,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.t_wer_macht_wasDataGridView.DataSource = this.t_wer_macht_wasBindingSource;
            this.t_wer_macht_wasDataGridView.Location = new System.Drawing.Point(210, 99);
            this.t_wer_macht_wasDataGridView.Name = "t_wer_macht_wasDataGridView";
            this.t_wer_macht_wasDataGridView.RowTemplate.Height = 23;
            this.t_wer_macht_wasDataGridView.Size = new System.Drawing.Size(512, 173);
            this.t_wer_macht_wasDataGridView.TabIndex = 1;
            this.t_wer_macht_wasDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.t_wer_macht_wasDataGridView_CellClick);
            this.t_wer_macht_wasDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.t_wer_macht_wasDataGridView_DataBindingComplete);
            // 
            // tdienstleistungenBindingSource
            // 
            this.tdienstleistungenBindingSource.DataMember = "t_dienstleistungen";
            this.tdienstleistungenBindingSource.DataSource = this.dcwDataSet;
            // 
            // cb_dienstleistung
            // 
            this.cb_dienstleistung.DataSource = this.tdienstleistungenBindingSource;
            this.cb_dienstleistung.DisplayMember = "dienstleistung";
            this.cb_dienstleistung.FormattingEnabled = true;
            this.cb_dienstleistung.Location = new System.Drawing.Point(12, 242);
            this.cb_dienstleistung.Name = "cb_dienstleistung";
            this.cb_dienstleistung.Size = new System.Drawing.Size(121, 20);
            this.cb_dienstleistung.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Items.AddRange(new object[] {
            "`t_wer_macht_was`",
            "`t_wer_fuer_wen`",
            "`t_wer_ist_wo`",
            "`t_wer_internat_maerkte`",
            "`t_dienst_suchprofile`",
            "`t_filt_dienst_was`",
            "`t_filt_dienst_wer`"});
            this.listBox1.Location = new System.Drawing.Point(0, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(164, 196);
            this.listBox1.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "wmw_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "wmw_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "f_mitglied";
            this.dataGridViewTextBoxColumn2.HeaderText = "f_mitglied";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Dienstleistung
            // 
            this.Dienstleistung.HeaderText = "Dienstleistung";
            this.Dienstleistung.Name = "Dienstleistung";
            this.Dienstleistung.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Dienstleistung.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // f_dienstleistung
            // 
            this.f_dienstleistung.DataPropertyName = "f_dienstleistung";
            this.f_dienstleistung.HeaderText = "f_dienstleistung";
            this.f_dienstleistung.Name = "f_dienstleistung";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "D_CN";
            this.dataGridViewTextBoxColumn4.HeaderText = "D_CN";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CN_D";
            this.dataGridViewTextBoxColumn5.HeaderText = "CN_D";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Form_Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 526);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cb_dienstleistung);
            this.Controls.Add(this.t_wer_macht_wasDataGridView);
            this.Controls.Add(this.t_wer_macht_wasBindingNavigator);
            this.Name = "Form_Administrator";
            this.Text = "Form_Administrator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Administrator_FormClosing);
            this.Load += new System.EventHandler(this.Form_Administrator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dcwDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_wer_macht_wasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_wer_macht_wasBindingNavigator)).EndInit();
            this.t_wer_macht_wasBindingNavigator.ResumeLayout(false);
            this.t_wer_macht_wasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t_wer_macht_wasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdienstleistungenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dcwDataSet dcwDataSet;
        private System.Windows.Forms.BindingSource t_wer_macht_wasBindingSource;
        private dcwDataSetTableAdapters.t_wer_macht_wasTableAdapter t_wer_macht_wasTableAdapter;
        private dcwDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator t_wer_macht_wasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton t_wer_macht_wasBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView t_wer_macht_wasDataGridView;
        private dcwDataSetTableAdapters.t_dienstleistungenTableAdapter t_dienstleistungenTableAdapter;
        private System.Windows.Forms.BindingSource tdienstleistungenBindingSource;
        private System.Windows.Forms.ComboBox cb_dienstleistung;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dienstleistung;
        private System.Windows.Forms.DataGridViewTextBoxColumn f_dienstleistung;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}