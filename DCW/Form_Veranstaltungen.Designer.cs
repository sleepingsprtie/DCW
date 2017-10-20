namespace DCW
{
    partial class Form_Veranstaltungen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Veranstaltungen));
            this.tabC_Veranstaltungen = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ADD = new System.Windows.Forms.Button();
            this.Ver_lfd = new System.Windows.Forms.TextBox();
            this.veranstaltungenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dcwDataSet = new DCW.dcwDataSet();
            this.OK = new System.Windows.Forms.Button();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Rechnungen_Verein = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Rechnungen_GmbH = new System.Windows.Forms.Button();
            this.btn_Namensschilder = new System.Windows.Forms.Button();
            this.btn_Teilnehmerliste = new System.Windows.Forms.Button();
            this.veranstaltungenBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.veranstaltungenBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ver_TitelLabel1 = new System.Windows.Forms.Label();
            this.ver_OrtLabel1 = new System.Windows.Forms.Label();
            this.ver_DatumLabel1 = new System.Windows.Forms.Label();
            this.veranstaltungenTableAdapter = new DCW.dcwDataSetTableAdapters.veranstaltungenTableAdapter();
            this.tableAdapterManager = new DCW.dcwDataSetTableAdapters.TableAdapterManager();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
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
            this.tabC_Veranstaltungen.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veranstaltungenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dcwDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veranstaltungenBindingNavigator)).BeginInit();
            this.veranstaltungenBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // ver_TitelLabel
            // 
            ver_TitelLabel.AutoSize = true;
            ver_TitelLabel.Location = new System.Drawing.Point(21, 36);
            ver_TitelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ver_TitelLabel.Name = "ver_TitelLabel";
            ver_TitelLabel.Size = new System.Drawing.Size(223, 22);
            ver_TitelLabel.TabIndex = 0;
            ver_TitelLabel.Text = "Titel der Veranstaltung:";
            // 
            // ver_DatumLabel
            // 
            ver_DatumLabel.AutoSize = true;
            ver_DatumLabel.Location = new System.Drawing.Point(21, 97);
            ver_DatumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ver_DatumLabel.Name = "ver_DatumLabel";
            ver_DatumLabel.Size = new System.Drawing.Size(79, 22);
            ver_DatumLabel.TabIndex = 2;
            ver_DatumLabel.Text = "Datum:";
            // 
            // ver_UhrzeitLabel
            // 
            ver_UhrzeitLabel.AutoSize = true;
            ver_UhrzeitLabel.Location = new System.Drawing.Point(21, 139);
            ver_UhrzeitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ver_UhrzeitLabel.Name = "ver_UhrzeitLabel";
            ver_UhrzeitLabel.Size = new System.Drawing.Size(82, 22);
            ver_UhrzeitLabel.TabIndex = 4;
            ver_UhrzeitLabel.Text = "Uhrzeit:";
            // 
            // ver_OrtLabel
            // 
            ver_OrtLabel.AutoSize = true;
            ver_OrtLabel.Location = new System.Drawing.Point(21, 199);
            ver_OrtLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ver_OrtLabel.Name = "ver_OrtLabel";
            ver_OrtLabel.Size = new System.Drawing.Size(47, 22);
            ver_OrtLabel.TabIndex = 6;
            ver_OrtLabel.Text = "Ort:";
            // 
            // ver_TagungsstätteLabel
            // 
            ver_TagungsstätteLabel.AutoSize = true;
            ver_TagungsstätteLabel.Location = new System.Drawing.Point(21, 241);
            ver_TagungsstätteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ver_TagungsstätteLabel.Name = "ver_TagungsstätteLabel";
            ver_TagungsstätteLabel.Size = new System.Drawing.Size(143, 22);
            ver_TagungsstätteLabel.TabIndex = 8;
            ver_TagungsstätteLabel.Text = "Tagungsstätte:";
            // 
            // ver_Preis_MitgliedLabel
            // 
            ver_Preis_MitgliedLabel.AutoSize = true;
            ver_Preis_MitgliedLabel.Location = new System.Drawing.Point(21, 300);
            ver_Preis_MitgliedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ver_Preis_MitgliedLabel.Name = "ver_Preis_MitgliedLabel";
            ver_Preis_MitgliedLabel.Size = new System.Drawing.Size(188, 22);
            ver_Preis_MitgliedLabel.TabIndex = 10;
            ver_Preis_MitgliedLabel.Text = "Preis für Mitglieder:";
            // 
            // ver_Preis_NichtmitgliedLabel
            // 
            ver_Preis_NichtmitgliedLabel.AutoSize = true;
            ver_Preis_NichtmitgliedLabel.Location = new System.Drawing.Point(21, 342);
            ver_Preis_NichtmitgliedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ver_Preis_NichtmitgliedLabel.Name = "ver_Preis_NichtmitgliedLabel";
            ver_Preis_NichtmitgliedLabel.Size = new System.Drawing.Size(236, 22);
            ver_Preis_NichtmitgliedLabel.TabIndex = 12;
            ver_Preis_NichtmitgliedLabel.Text = "Preis für Nichtmitglieder:";
            // 
            // ver_Veranstalter1Label
            // 
            ver_Veranstalter1Label.AutoSize = true;
            ver_Veranstalter1Label.Location = new System.Drawing.Point(21, 406);
            ver_Veranstalter1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ver_Veranstalter1Label.Name = "ver_Veranstalter1Label";
            ver_Veranstalter1Label.Size = new System.Drawing.Size(182, 22);
            ver_Veranstalter1Label.TabIndex = 14;
            ver_Veranstalter1Label.Text = "Hauptveranstalter:";
            // 
            // ver_Veranstalter2Label
            // 
            ver_Veranstalter2Label.AutoSize = true;
            ver_Veranstalter2Label.Location = new System.Drawing.Point(21, 446);
            ver_Veranstalter2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ver_Veranstalter2Label.Name = "ver_Veranstalter2Label";
            ver_Veranstalter2Label.Size = new System.Drawing.Size(202, 22);
            ver_Veranstalter2Label.TabIndex = 16;
            ver_Veranstalter2Label.Text = "Kooperationspartner:";
            // 
            // ver_Rechnung_versandt_amLabel
            // 
            ver_Rechnung_versandt_amLabel.AutoSize = true;
            ver_Rechnung_versandt_amLabel.Location = new System.Drawing.Point(768, 406);
            ver_Rechnung_versandt_amLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ver_Rechnung_versandt_amLabel.Name = "ver_Rechnung_versandt_amLabel";
            ver_Rechnung_versandt_amLabel.Size = new System.Drawing.Size(248, 22);
            ver_Rechnung_versandt_amLabel.TabIndex = 18;
            ver_Rechnung_versandt_amLabel.Text = "Rechnungen versandt am:";
            // 
            // tabC_Veranstaltungen
            // 
            this.tabC_Veranstaltungen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabC_Veranstaltungen.Controls.Add(this.tabPage1);
            this.tabC_Veranstaltungen.Controls.Add(this.tabPage2);
            this.tabC_Veranstaltungen.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabC_Veranstaltungen.Location = new System.Drawing.Point(18, 95);
            this.tabC_Veranstaltungen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabC_Veranstaltungen.Name = "tabC_Veranstaltungen";
            this.tabC_Veranstaltungen.SelectedIndex = 0;
            this.tabC_Veranstaltungen.Size = new System.Drawing.Size(1197, 610);
            this.tabC_Veranstaltungen.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1189, 575);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Veranstaltungen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ADD);
            this.groupBox1.Controls.Add(this.Ver_lfd);
            this.groupBox1.Controls.Add(this.OK);
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
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1171, 554);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veranstaltungsdaten";
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(717, 498);
            this.ADD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(144, 48);
            this.ADD.TabIndex = 25;
            this.ADD.Text = "Neuer";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // Ver_lfd
            // 
            this.Ver_lfd.BackColor = System.Drawing.SystemColors.Window;
            this.Ver_lfd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Ver_lfd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.veranstaltungenBindingSource, "Ver_lfd", true));
            this.Ver_lfd.ForeColor = System.Drawing.SystemColors.Window;
            this.Ver_lfd.Location = new System.Drawing.Point(289, 498);
            this.Ver_lfd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Ver_lfd.Name = "Ver_lfd";
            this.Ver_lfd.ReadOnly = true;
            this.Ver_lfd.Size = new System.Drawing.Size(207, 22);
            this.Ver_lfd.TabIndex = 24;
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
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(917, 498);
            this.OK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(156, 48);
            this.OK.TabIndex = 23;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // ver_TagungsstaetteTextBox
            // 
            this.ver_TagungsstaetteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.veranstaltungenBindingSource, "Ver_Tagungsstaette", true));
            this.ver_TagungsstaetteTextBox.Location = new System.Drawing.Point(289, 238);
            this.ver_TagungsstaetteTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ver_TagungsstaetteTextBox.MaxLength = 50;
            this.ver_TagungsstaetteTextBox.Name = "ver_TagungsstaetteTextBox";
            this.ver_TagungsstaetteTextBox.Size = new System.Drawing.Size(298, 29);
            this.ver_TagungsstaetteTextBox.TabIndex = 22;
            // 
            // ver_Preis_NichtmitgliedTextBox
            // 
            this.ver_Preis_NichtmitgliedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.veranstaltungenBindingSource, "Ver_Preis_Nichtmitglied", true));
            this.ver_Preis_NichtmitgliedTextBox.Location = new System.Drawing.Point(289, 337);
            this.ver_Preis_NichtmitgliedTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ver_Preis_NichtmitgliedTextBox.Name = "ver_Preis_NichtmitgliedTextBox";
            this.ver_Preis_NichtmitgliedTextBox.Size = new System.Drawing.Size(298, 29);
            this.ver_Preis_NichtmitgliedTextBox.TabIndex = 21;
            // 
            // ver_DatumDateTimePicker
            // 
            this.ver_DatumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.veranstaltungenBindingSource, "Ver_Datum", true));
            this.ver_DatumDateTimePicker.Location = new System.Drawing.Point(289, 94);
            this.ver_DatumDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ver_DatumDateTimePicker.Name = "ver_DatumDateTimePicker";
            this.ver_DatumDateTimePicker.Size = new System.Drawing.Size(298, 29);
            this.ver_DatumDateTimePicker.TabIndex = 20;
            // 
            // ver_Rechnung_versandt_amDateTimePicker
            // 
            this.ver_Rechnung_versandt_amDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.veranstaltungenBindingSource, "Ver_Rechnung_versandt_am", true));
            this.ver_Rechnung_versandt_amDateTimePicker.Location = new System.Drawing.Point(773, 438);
            this.ver_Rechnung_versandt_amDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ver_Rechnung_versandt_amDateTimePicker.Name = "ver_Rechnung_versandt_amDateTimePicker";
            this.ver_Rechnung_versandt_amDateTimePicker.Size = new System.Drawing.Size(298, 29);
            this.ver_Rechnung_versandt_amDateTimePicker.TabIndex = 19;
            // 
            // ver_Veranstalter2TextBox
            // 
            this.ver_Veranstalter2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.veranstaltungenBindingSource, "Ver_Veranstalter2", true));
            this.ver_Veranstalter2TextBox.Location = new System.Drawing.Point(289, 443);
            this.ver_Veranstalter2TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ver_Veranstalter2TextBox.MaxLength = 50;
            this.ver_Veranstalter2TextBox.Name = "ver_Veranstalter2TextBox";
            this.ver_Veranstalter2TextBox.Size = new System.Drawing.Size(298, 29);
            this.ver_Veranstalter2TextBox.TabIndex = 17;
            // 
            // ver_Veranstalter1TextBox
            // 
            this.ver_Veranstalter1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.veranstaltungenBindingSource, "Ver_Veranstalter1", true));
            this.ver_Veranstalter1TextBox.Location = new System.Drawing.Point(289, 401);
            this.ver_Veranstalter1TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ver_Veranstalter1TextBox.MaxLength = 50;
            this.ver_Veranstalter1TextBox.Name = "ver_Veranstalter1TextBox";
            this.ver_Veranstalter1TextBox.Size = new System.Drawing.Size(298, 29);
            this.ver_Veranstalter1TextBox.TabIndex = 15;
            // 
            // ver_Preis_MitgliedTextBox
            // 
            this.ver_Preis_MitgliedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.veranstaltungenBindingSource, "Ver_Preis_Mitglied", true));
            this.ver_Preis_MitgliedTextBox.Location = new System.Drawing.Point(289, 295);
            this.ver_Preis_MitgliedTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ver_Preis_MitgliedTextBox.Name = "ver_Preis_MitgliedTextBox";
            this.ver_Preis_MitgliedTextBox.Size = new System.Drawing.Size(298, 29);
            this.ver_Preis_MitgliedTextBox.TabIndex = 11;
            // 
            // ver_OrtTextBox
            // 
            this.ver_OrtTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.veranstaltungenBindingSource, "Ver_Ort", true));
            this.ver_OrtTextBox.Location = new System.Drawing.Point(289, 194);
            this.ver_OrtTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ver_OrtTextBox.MaxLength = 50;
            this.ver_OrtTextBox.Name = "ver_OrtTextBox";
            this.ver_OrtTextBox.Size = new System.Drawing.Size(298, 29);
            this.ver_OrtTextBox.TabIndex = 7;
            // 
            // ver_UhrzeitTextBox
            // 
            this.ver_UhrzeitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.veranstaltungenBindingSource, "Ver_Uhrzeit", true));
            this.ver_UhrzeitTextBox.Location = new System.Drawing.Point(289, 134);
            this.ver_UhrzeitTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ver_UhrzeitTextBox.MaxLength = 50;
            this.ver_UhrzeitTextBox.Name = "ver_UhrzeitTextBox";
            this.ver_UhrzeitTextBox.Size = new System.Drawing.Size(298, 29);
            this.ver_UhrzeitTextBox.TabIndex = 5;
            // 
            // ver_TitelTextBox
            // 
            this.ver_TitelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.veranstaltungenBindingSource, "Ver_Titel", true));
            this.ver_TitelTextBox.Location = new System.Drawing.Point(289, 31);
            this.ver_TitelTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ver_TitelTextBox.MaxLength = 255;
            this.ver_TitelTextBox.Name = "ver_TitelTextBox";
            this.ver_TitelTextBox.Size = new System.Drawing.Size(598, 29);
            this.ver_TitelTextBox.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1189, 575);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Druckmenü";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btn_Rechnungen_Verein);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.btn_Rechnungen_GmbH);
            this.groupBox2.Controls.Add(this.btn_Namensschilder);
            this.groupBox2.Controls.Add(this.btn_Teilnehmerliste);
            this.groupBox2.Location = new System.Drawing.Point(10, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1166, 550);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Druckdienste für Veranstaltungen";
            // 
            // btn_Rechnungen_Verein
            // 
            this.btn_Rechnungen_Verein.Location = new System.Drawing.Point(183, 306);
            this.btn_Rechnungen_Verein.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Rechnungen_Verein.Name = "btn_Rechnungen_Verein";
            this.btn_Rechnungen_Verein.Size = new System.Drawing.Size(117, 59);
            this.btn_Rechnungen_Verein.TabIndex = 2;
            this.btn_Rechnungen_Verein.Text = "Rechnungen_Verein";
            this.btn_Rechnungen_Verein.UseVisualStyleBackColor = true;
            this.btn_Rechnungen_Verein.Click += new System.EventHandler(this.btn_Rechnungen_Verein_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Yellow;
            this.textBox3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(342, 288);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(721, 88);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "Druckt die Rechnungen für die oben gezeigte Veranstaltung";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Yellow;
            this.textBox2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(342, 175);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(721, 88);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Druckt die Namensschilder für die oben gezeigte Veranstaltung";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Yellow;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(342, 77);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(721, 88);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Druckt die Teilnehmerliste für die oben gezeigte Veranstaltung";
            // 
            // btn_Rechnungen_GmbH
            // 
            this.btn_Rechnungen_GmbH.Location = new System.Drawing.Point(57, 306);
            this.btn_Rechnungen_GmbH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Rechnungen_GmbH.Name = "btn_Rechnungen_GmbH";
            this.btn_Rechnungen_GmbH.Size = new System.Drawing.Size(117, 59);
            this.btn_Rechnungen_GmbH.TabIndex = 0;
            this.btn_Rechnungen_GmbH.Text = "Rechnungen_GmbH";
            this.btn_Rechnungen_GmbH.UseVisualStyleBackColor = true;
            this.btn_Rechnungen_GmbH.Click += new System.EventHandler(this.btn_Rechnungen_GmbH_Click);
            // 
            // btn_Namensschilder
            // 
            this.btn_Namensschilder.Location = new System.Drawing.Point(57, 193);
            this.btn_Namensschilder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Namensschilder.Name = "btn_Namensschilder";
            this.btn_Namensschilder.Size = new System.Drawing.Size(213, 59);
            this.btn_Namensschilder.TabIndex = 0;
            this.btn_Namensschilder.Text = "Namensschilder ";
            this.btn_Namensschilder.UseVisualStyleBackColor = true;
            this.btn_Namensschilder.Click += new System.EventHandler(this.btn_Namensschilder_Click);
            // 
            // btn_Teilnehmerliste
            // 
            this.btn_Teilnehmerliste.Location = new System.Drawing.Point(57, 91);
            this.btn_Teilnehmerliste.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Teilnehmerliste.Name = "btn_Teilnehmerliste";
            this.btn_Teilnehmerliste.Size = new System.Drawing.Size(213, 59);
            this.btn_Teilnehmerliste.TabIndex = 0;
            this.btn_Teilnehmerliste.Text = "Teilnehmerliste";
            this.btn_Teilnehmerliste.UseVisualStyleBackColor = true;
            this.btn_Teilnehmerliste.Click += new System.EventHandler(this.btn_Teilnehmerliste_Click);
            // 
            // veranstaltungenBindingNavigator
            // 
            this.veranstaltungenBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.veranstaltungenBindingNavigator.BindingSource = this.veranstaltungenBindingSource;
            this.veranstaltungenBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.veranstaltungenBindingNavigator.DeleteItem = null;
            this.veranstaltungenBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.veranstaltungenBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.veranstaltungenBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.veranstaltungenBindingNavigatorSaveItem});
            this.veranstaltungenBindingNavigator.Location = new System.Drawing.Point(0, 733);
            this.veranstaltungenBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.veranstaltungenBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.veranstaltungenBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.veranstaltungenBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.veranstaltungenBindingNavigator.Name = "veranstaltungenBindingNavigator";
            this.veranstaltungenBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.veranstaltungenBindingNavigator.Size = new System.Drawing.Size(1233, 30);
            this.veranstaltungenBindingNavigator.TabIndex = 1;
            this.veranstaltungenBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 27);
            this.bindingNavigatorAddNewItem.Text = "新添";
            this.bindingNavigatorAddNewItem.Visible = false;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(46, 27);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 27);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 27);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 30);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 30);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 27);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 27);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 30);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 27);
            this.bindingNavigatorDeleteItem.Text = "删除";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // veranstaltungenBindingNavigatorSaveItem
            // 
            this.veranstaltungenBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.veranstaltungenBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("veranstaltungenBindingNavigatorSaveItem.Image")));
            this.veranstaltungenBindingNavigatorSaveItem.Name = "veranstaltungenBindingNavigatorSaveItem";
            this.veranstaltungenBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 27);
            this.veranstaltungenBindingNavigatorSaveItem.Text = "保存数据";
            this.veranstaltungenBindingNavigatorSaveItem.Click += new System.EventHandler(this.veranstaltungenBindingNavigatorSaveItem_Click);
            // 
            // ver_TitelLabel1
            // 
            this.ver_TitelLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.veranstaltungenBindingSource, "Ver_Titel", true));
            this.ver_TitelLabel1.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ver_TitelLabel1.ForeColor = System.Drawing.Color.Blue;
            this.ver_TitelLabel1.Location = new System.Drawing.Point(17, 37);
            this.ver_TitelLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ver_TitelLabel1.Name = "ver_TitelLabel1";
            this.ver_TitelLabel1.Size = new System.Drawing.Size(395, 35);
            this.ver_TitelLabel1.TabIndex = 3;
            this.ver_TitelLabel1.Text = "Ver_Titel";
            // 
            // ver_OrtLabel1
            // 
            this.ver_OrtLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.veranstaltungenBindingSource, "Ver_Ort", true));
            this.ver_OrtLabel1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ver_OrtLabel1.ForeColor = System.Drawing.Color.Blue;
            this.ver_OrtLabel1.Location = new System.Drawing.Point(482, 37);
            this.ver_OrtLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ver_OrtLabel1.Name = "ver_OrtLabel1";
            this.ver_OrtLabel1.Size = new System.Drawing.Size(249, 35);
            this.ver_OrtLabel1.TabIndex = 4;
            this.ver_OrtLabel1.Text = "Ver_Ort";
            // 
            // ver_DatumLabel1
            // 
            this.ver_DatumLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.veranstaltungenBindingSource, "Ver_Datum", true));
            this.ver_DatumLabel1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ver_DatumLabel1.ForeColor = System.Drawing.Color.Blue;
            this.ver_DatumLabel1.Location = new System.Drawing.Point(924, 37);
            this.ver_DatumLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ver_DatumLabel1.Name = "ver_DatumLabel1";
            this.ver_DatumLabel1.Size = new System.Drawing.Size(244, 35);
            this.ver_DatumLabel1.TabIndex = 5;
            this.ver_DatumLabel1.Text = "Ver_Datum";
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
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(1020, 740);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(213, 23);
            this.progressBar2.TabIndex = 3;
            // 
            // Form_Veranstaltungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 763);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.ver_DatumLabel1);
            this.Controls.Add(this.ver_OrtLabel1);
            this.Controls.Add(this.ver_TitelLabel1);
            this.Controls.Add(this.veranstaltungenBindingNavigator);
            this.Controls.Add(this.tabC_Veranstaltungen);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Veranstaltungen";
            this.Text = "Veranstaltungen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Veranstaltungen_FormClosing);
            this.Load += new System.EventHandler(this.Form_Veranstaltungen_Load);
            this.tabC_Veranstaltungen.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veranstaltungenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dcwDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veranstaltungenBindingNavigator)).EndInit();
            this.veranstaltungenBindingNavigator.ResumeLayout(false);
            this.veranstaltungenBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabC_Veranstaltungen;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private dcwDataSet dcwDataSet;
        private System.Windows.Forms.BindingSource veranstaltungenBindingSource;
        private dcwDataSetTableAdapters.veranstaltungenTableAdapter veranstaltungenTableAdapter;
        private dcwDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator veranstaltungenBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton veranstaltungenBindingNavigatorSaveItem;
        private System.Windows.Forms.Label ver_TitelLabel1;
        private System.Windows.Forms.Label ver_OrtLabel1;
        private System.Windows.Forms.Label ver_DatumLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ver_OrtTextBox;
        private System.Windows.Forms.TextBox ver_UhrzeitTextBox;
        private System.Windows.Forms.TextBox ver_TitelTextBox;
        private System.Windows.Forms.DateTimePicker ver_DatumDateTimePicker;
        private System.Windows.Forms.DateTimePicker ver_Rechnung_versandt_amDateTimePicker;
        private System.Windows.Forms.TextBox ver_Veranstalter2TextBox;
        private System.Windows.Forms.TextBox ver_Veranstalter1TextBox;
        private System.Windows.Forms.TextBox ver_Preis_MitgliedTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Rechnungen_GmbH;
        private System.Windows.Forms.Button btn_Namensschilder;
        private System.Windows.Forms.Button btn_Teilnehmerliste;
        private System.Windows.Forms.TextBox ver_Preis_NichtmitgliedTextBox;
        private System.Windows.Forms.TextBox ver_TagungsstaetteTextBox;
        public System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox Ver_lfd;
        public System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button btn_Rechnungen_Verein;
        private System.Windows.Forms.ProgressBar progressBar2;
    }
}