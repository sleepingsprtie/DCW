namespace DCW
{
    partial class Form_CT_Beitragszahlung
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CT_Betrag = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CT_Beitragsjahr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Abbrechen = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.dcwDataSet = new DCW.dcwDataSet();
            this.ctbeiträgeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ct_beiträgeTableAdapter = new DCW.dcwDataSetTableAdapters.ct_beiträgeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dcwDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbeiträgeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "CT_Betrag:";
            // 
            // CT_Betrag
            // 
            this.CT_Betrag.Location = new System.Drawing.Point(151, 101);
            this.CT_Betrag.Name = "CT_Betrag";
            this.CT_Betrag.Size = new System.Drawing.Size(194, 21);
            this.CT_Betrag.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "CT_Datum:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(149, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // CT_Beitragsjahr
            // 
            this.CT_Beitragsjahr.Location = new System.Drawing.Point(151, 148);
            this.CT_Beitragsjahr.Name = "CT_Beitragsjahr";
            this.CT_Beitragsjahr.Size = new System.Drawing.Size(198, 21);
            this.CT_Beitragsjahr.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "CT_Beitragsjahr:";
            // 
            // Abbrechen
            // 
            this.Abbrechen.Location = new System.Drawing.Point(104, 205);
            this.Abbrechen.Name = "Abbrechen";
            this.Abbrechen.Size = new System.Drawing.Size(90, 30);
            this.Abbrechen.TabIndex = 7;
            this.Abbrechen.Text = "Abbrechen";
            this.Abbrechen.UseVisualStyleBackColor = true;
            this.Abbrechen.Click += new System.EventHandler(this.Abbrechen_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(293, 205);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(90, 30);
            this.OK.TabIndex = 8;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // dcwDataSet
            // 
            this.dcwDataSet.DataSetName = "dcwDataSet";
            this.dcwDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // Form_CT_Beitragszahlung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 259);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Abbrechen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CT_Beitragsjahr);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CT_Betrag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_CT_Beitragszahlung";
            this.Text = "Form_CT_Beitragszahlung";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_CT_Beitragszahlung_FormClosing);
            this.Load += new System.EventHandler(this.Form_CT_Beitragszahlung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dcwDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctbeiträgeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CT_Betrag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox CT_Beitragsjahr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Abbrechen;
        private System.Windows.Forms.Button OK;
        private dcwDataSet dcwDataSet;
        private System.Windows.Forms.BindingSource ctbeiträgeBindingSource;
        private dcwDataSetTableAdapters.ct_beiträgeTableAdapter ct_beiträgeTableAdapter;
    }
}