namespace DCW
{
    partial class Form_InsertVeranstaltungen
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
            System.Windows.Forms.Label ver_TitelLabel;
            System.Windows.Forms.Label ver_DatumLabel;
            System.Windows.Forms.Label ver_UhrzeitLabel;
            System.Windows.Forms.Label ver_OrtLabel;
            System.Windows.Forms.Label ver_TagungsstätteLabel;
            System.Windows.Forms.Label ver_Preis_MitgliedLabel;
            System.Windows.Forms.Label ver_Preis_NichtmitgliedLabel;
            System.Windows.Forms.Label ver_Veranstalter1Label;
            System.Windows.Forms.Label ver_Veranstalter2Label;
            System.Windows.Forms.Label ver_Rechnung_versandt_amLabel;
            this.veranstaltungenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dcwDataSet = new DCW.dcwDataSet();
            this.veranstaltungenTableAdapter = new DCW.dcwDataSetTableAdapters.veranstaltungenTableAdapter();
            this.tableAdapterManager = new DCW.dcwDataSetTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.add = new System.Windows.Forms.Button();
            this.ver_TagungsstaetteTextBox = new System.Windows.Forms.TextBox();
            this.ver_Preis_NichtmitgliedTextBox = new System.Windows.Forms.TextBox();
            this.ver_DatumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ver_Rechnung_versandt_amDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ver_Veranstalter2TextBox = new System.Windows.Forms.TextBox();
            this.ver_Veranstalter1TextBox = new System.Windows.Forms.TextBox();
            this.ver_Preis_MitgliedTextBox = new System.Windows.Forms.TextBox();
            this.ver_OrtTextBox = new System.Windows.Forms.TextBox();
            this.ver_UhrzeitTextBox = new System.Windows.Forms.TextBox();
            this.ver_TitelTextBox = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            ver_TitelLabel = new System.Windows.Forms.Label();
            ver_DatumLabel = new System.Windows.Forms.Label();
            ver_UhrzeitLabel = new System.Windows.Forms.Label();
            ver_OrtLabel = new System.Windows.Forms.Label();
            ver_TagungsstätteLabel = new System.Windows.Forms.Label();
            ver_Preis_MitgliedLabel = new System.Windows.Forms.Label();
            ver_Preis_NichtmitgliedLabel = new System.Windows.Forms.Label();
            ver_Veranstalter1Label = new System.Windows.Forms.Label();
            ver_Veranstalter2Label = new System.Windows.Forms.Label();
            ver_Rechnung_versandt_amLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.veranstaltungenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dcwDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ver_TitelLabel
            // 
            ver_TitelLabel.AutoSize = true;
            ver_TitelLabel.Location = new System.Drawing.Point(14, 24);
            ver_TitelLabel.Name = "ver_TitelLabel";
            ver_TitelLabel.Size = new System.Drawing.Size(156, 14);
            ver_TitelLabel.TabIndex = 0;
            ver_TitelLabel.Text = "Titel der Veranstaltung:";
            // 
            // ver_DatumLabel
            // 
            ver_DatumLabel.AutoSize = true;
            ver_DatumLabel.Location = new System.Drawing.Point(14, 65);
            ver_DatumLabel.Name = "ver_DatumLabel";
            ver_DatumLabel.Size = new System.Drawing.Size(53, 14);
            ver_DatumLabel.TabIndex = 2;
            ver_DatumLabel.Text = "Datum:";
            // 
            // ver_UhrzeitLabel
            // 
            ver_UhrzeitLabel.AutoSize = true;
            ver_UhrzeitLabel.Location = new System.Drawing.Point(14, 93);
            ver_UhrzeitLabel.Name = "ver_UhrzeitLabel";
            ver_UhrzeitLabel.Size = new System.Drawing.Size(57, 14);
            ver_UhrzeitLabel.TabIndex = 4;
            ver_UhrzeitLabel.Text = "Uhrzeit:";
            // 
            // ver_OrtLabel
            // 
            ver_OrtLabel.AutoSize = true;
            ver_OrtLabel.Location = new System.Drawing.Point(14, 133);
            ver_OrtLabel.Name = "ver_OrtLabel";
            ver_OrtLabel.Size = new System.Drawing.Size(32, 14);
            ver_OrtLabel.TabIndex = 6;
            ver_OrtLabel.Text = "Ort:";
            // 
            // ver_TagungsstätteLabel
            // 
            ver_TagungsstätteLabel.AutoSize = true;
            ver_TagungsstätteLabel.Location = new System.Drawing.Point(14, 161);
            ver_TagungsstätteLabel.Name = "ver_TagungsstätteLabel";
            ver_TagungsstätteLabel.Size = new System.Drawing.Size(104, 14);
            ver_TagungsstätteLabel.TabIndex = 8;
            ver_TagungsstätteLabel.Text = "Tagungsstätte:";
            // 
            // ver_Preis_MitgliedLabel
            // 
            ver_Preis_MitgliedLabel.AutoSize = true;
            ver_Preis_MitgliedLabel.Location = new System.Drawing.Point(14, 200);
            ver_Preis_MitgliedLabel.Name = "ver_Preis_MitgliedLabel";
            ver_Preis_MitgliedLabel.Size = new System.Drawing.Size(129, 14);
            ver_Preis_MitgliedLabel.TabIndex = 10;
            ver_Preis_MitgliedLabel.Text = "Preis für Mitglieder:";
            // 
            // ver_Preis_NichtmitgliedLabel
            // 
            ver_Preis_NichtmitgliedLabel.AutoSize = true;
            ver_Preis_NichtmitgliedLabel.Location = new System.Drawing.Point(14, 228);
            ver_Preis_NichtmitgliedLabel.Name = "ver_Preis_NichtmitgliedLabel";
            ver_Preis_NichtmitgliedLabel.Size = new System.Drawing.Size(161, 14);
            ver_Preis_NichtmitgliedLabel.TabIndex = 12;
            ver_Preis_NichtmitgliedLabel.Text = "Preis für Nichtmitglieder:";
            // 
            // ver_Veranstalter1Label
            // 
            ver_Veranstalter1Label.AutoSize = true;
            ver_Veranstalter1Label.Location = new System.Drawing.Point(14, 270);
            ver_Veranstalter1Label.Name = "ver_Veranstalter1Label";
            ver_Veranstalter1Label.Size = new System.Drawing.Size(127, 14);
            ver_Veranstalter1Label.TabIndex = 14;
            ver_Veranstalter1Label.Text = "Hauptveranstalter:";
            // 
            // ver_Veranstalter2Label
            // 
            ver_Veranstalter2Label.AutoSize = true;
            ver_Veranstalter2Label.Location = new System.Drawing.Point(14, 298);
            ver_Veranstalter2Label.Name = "ver_Veranstalter2Label";
            ver_Veranstalter2Label.Size = new System.Drawing.Size(143, 14);
            ver_Veranstalter2Label.TabIndex = 16;
            ver_Veranstalter2Label.Text = "Kooperationspartner:";
            // 
            // ver_Rechnung_versandt_amLabel
            // 
            ver_Rechnung_versandt_amLabel.AutoSize = true;
            ver_Rechnung_versandt_amLabel.Location = new System.Drawing.Point(512, 270);
            ver_Rechnung_versandt_amLabel.Name = "ver_Rechnung_versandt_amLabel";
            ver_Rechnung_versandt_amLabel.Size = new System.Drawing.Size(173, 14);
            ver_Rechnung_versandt_amLabel.TabIndex = 18;
            ver_Rechnung_versandt_amLabel.Text = "Rechnungen versandt am:";
            // 
            // veranstaltungenBindingSource
            // 
            this.veranstaltungenBindingSource.DataMember = "veranstaltungen";
            this.veranstaltungenBindingSource.DataSource = this.dcwDataSet;
            // 
            // dcwDataSet
            // 
            this.dcwDataSet.DataSetName = "dcwDataSet";
            this.dcwDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // veranstaltungenTableAdapter
            // 
            this.veranstaltungenTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.t_dienstleistungenTableAdapter = null;
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
            this.tableAdapterManager.t_wer_macht_wasTableAdapter = null;
            this.tableAdapterManager.teilnehmerveranstaltungTableAdapter = null;
            this.tableAdapterManager.todoTableAdapter = null;
            this.tableAdapterManager.tote_mailsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DCW.dcwDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.veranstaltungenTableAdapter = this.veranstaltungenTableAdapter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Cancel);
            this.groupBox1.Controls.Add(this.add);
            this.groupBox1.Controls.Add(this.ver_TagungsstaetteTextBox);
            this.groupBox1.Controls.Add(this.ver_Preis_NichtmitgliedTextBox);
            this.groupBox1.Controls.Add(this.ver_DatumDateTimePicker);
            this.groupBox1.Controls.Add(ver_Rechnung_versandt_amLabel);
            this.groupBox1.Controls.Add(this.ver_Rechnung_versandt_amDateTimePicker);
            this.groupBox1.Controls.Add(ver_Veranstalter2Label);
            this.groupBox1.Controls.Add(this.ver_Veranstalter2TextBox);
            this.groupBox1.Controls.Add(ver_Veranstalter1Label);
            this.groupBox1.Controls.Add(this.ver_Veranstalter1TextBox);
            this.groupBox1.Controls.Add(ver_Preis_NichtmitgliedLabel);
            this.groupBox1.Controls.Add(ver_Preis_MitgliedLabel);
            this.groupBox1.Controls.Add(this.ver_Preis_MitgliedTextBox);
            this.groupBox1.Controls.Add(ver_TagungsstätteLabel);
            this.groupBox1.Controls.Add(ver_OrtLabel);
            this.groupBox1.Controls.Add(this.ver_OrtTextBox);
            this.groupBox1.Controls.Add(ver_UhrzeitLabel);
            this.groupBox1.Controls.Add(this.ver_UhrzeitTextBox);
            this.groupBox1.Controls.Add(ver_DatumLabel);
            this.groupBox1.Controls.Add(ver_TitelLabel);
            this.groupBox1.Controls.Add(this.ver_TitelTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 379);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(611, 332);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(104, 32);
            this.add.TabIndex = 23;
            this.add.Text = "OK";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // ver_TagungsstaetteTextBox
            // 
            this.ver_TagungsstaetteTextBox.Location = new System.Drawing.Point(193, 158);
            this.ver_TagungsstaetteTextBox.MaxLength = 50;
            this.ver_TagungsstaetteTextBox.Name = "ver_TagungsstaetteTextBox";
            this.ver_TagungsstaetteTextBox.Size = new System.Drawing.Size(200, 22);
            this.ver_TagungsstaetteTextBox.TabIndex = 22;
            // 
            // ver_Preis_NichtmitgliedTextBox
            // 
            this.ver_Preis_NichtmitgliedTextBox.Location = new System.Drawing.Point(193, 225);
            this.ver_Preis_NichtmitgliedTextBox.Name = "ver_Preis_NichtmitgliedTextBox";
            this.ver_Preis_NichtmitgliedTextBox.Size = new System.Drawing.Size(200, 22);
            this.ver_Preis_NichtmitgliedTextBox.TabIndex = 21;
            // 
            // ver_DatumDateTimePicker
            // 
            this.ver_DatumDateTimePicker.Location = new System.Drawing.Point(193, 62);
            this.ver_DatumDateTimePicker.Name = "ver_DatumDateTimePicker";
            this.ver_DatumDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.ver_DatumDateTimePicker.TabIndex = 20;
            // 
            // ver_Rechnung_versandt_amDateTimePicker
            // 
            this.ver_Rechnung_versandt_amDateTimePicker.Location = new System.Drawing.Point(515, 292);
            this.ver_Rechnung_versandt_amDateTimePicker.Name = "ver_Rechnung_versandt_amDateTimePicker";
            this.ver_Rechnung_versandt_amDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.ver_Rechnung_versandt_amDateTimePicker.TabIndex = 19;
            // 
            // ver_Veranstalter2TextBox
            // 
            this.ver_Veranstalter2TextBox.Location = new System.Drawing.Point(193, 295);
            this.ver_Veranstalter2TextBox.MaxLength = 50;
            this.ver_Veranstalter2TextBox.Name = "ver_Veranstalter2TextBox";
            this.ver_Veranstalter2TextBox.Size = new System.Drawing.Size(200, 22);
            this.ver_Veranstalter2TextBox.TabIndex = 17;
            // 
            // ver_Veranstalter1TextBox
            // 
            this.ver_Veranstalter1TextBox.Location = new System.Drawing.Point(193, 267);
            this.ver_Veranstalter1TextBox.MaxLength = 50;
            this.ver_Veranstalter1TextBox.Name = "ver_Veranstalter1TextBox";
            this.ver_Veranstalter1TextBox.Size = new System.Drawing.Size(200, 22);
            this.ver_Veranstalter1TextBox.TabIndex = 15;
            // 
            // ver_Preis_MitgliedTextBox
            // 
            this.ver_Preis_MitgliedTextBox.Location = new System.Drawing.Point(193, 197);
            this.ver_Preis_MitgliedTextBox.Name = "ver_Preis_MitgliedTextBox";
            this.ver_Preis_MitgliedTextBox.Size = new System.Drawing.Size(200, 22);
            this.ver_Preis_MitgliedTextBox.TabIndex = 11;
            // 
            // ver_OrtTextBox
            // 
            this.ver_OrtTextBox.Location = new System.Drawing.Point(193, 130);
            this.ver_OrtTextBox.MaxLength = 50;
            this.ver_OrtTextBox.Name = "ver_OrtTextBox";
            this.ver_OrtTextBox.Size = new System.Drawing.Size(200, 22);
            this.ver_OrtTextBox.TabIndex = 7;
            // 
            // ver_UhrzeitTextBox
            // 
            this.ver_UhrzeitTextBox.Location = new System.Drawing.Point(193, 90);
            this.ver_UhrzeitTextBox.MaxLength = 50;
            this.ver_UhrzeitTextBox.Name = "ver_UhrzeitTextBox";
            this.ver_UhrzeitTextBox.Size = new System.Drawing.Size(200, 22);
            this.ver_UhrzeitTextBox.TabIndex = 5;
            // 
            // ver_TitelTextBox
            // 
            this.ver_TitelTextBox.Location = new System.Drawing.Point(193, 21);
            this.ver_TitelTextBox.MaxLength = 255;
            this.ver_TitelTextBox.Name = "ver_TitelTextBox";
            this.ver_TitelTextBox.Size = new System.Drawing.Size(400, 22);
            this.ver_TitelTextBox.TabIndex = 1;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(454, 332);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(106, 32);
            this.Cancel.TabIndex = 24;
            this.Cancel.Text = "Abbrechen";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Form_InsertVeranstaltungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 396);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_InsertVeranstaltungen";
            this.Text = "InsertVeranstaltungen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_InsertVeranstaltungen_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.veranstaltungenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dcwDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private dcwDataSet dcwDataSet;
        private System.Windows.Forms.BindingSource veranstaltungenBindingSource;
        private dcwDataSetTableAdapters.veranstaltungenTableAdapter veranstaltungenTableAdapter;
        private dcwDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox ver_TagungsstaetteTextBox;
        private System.Windows.Forms.TextBox ver_Preis_NichtmitgliedTextBox;
        private System.Windows.Forms.DateTimePicker ver_DatumDateTimePicker;
        private System.Windows.Forms.DateTimePicker ver_Rechnung_versandt_amDateTimePicker;
        private System.Windows.Forms.TextBox ver_Veranstalter2TextBox;
        private System.Windows.Forms.TextBox ver_Veranstalter1TextBox;
        private System.Windows.Forms.TextBox ver_Preis_MitgliedTextBox;
        private System.Windows.Forms.TextBox ver_OrtTextBox;
        private System.Windows.Forms.TextBox ver_UhrzeitTextBox;
        private System.Windows.Forms.TextBox ver_TitelTextBox;
        private System.Windows.Forms.Button Cancel;
    }
}