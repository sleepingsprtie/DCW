namespace DCW
{
    partial class Form_Beitragszahlung
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Abbrechen = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.dcwDataSet = new DCW.dcwDataSet();
            this.beiträgeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beiträgeTableAdapter = new DCW.dcwDataSetTableAdapters.beiträgeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dcwDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beiträgeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(164, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bei_Datum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bei_Betrag:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 21);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bei_Beitragsjahr:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(164, 141);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 21);
            this.textBox2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // Abbrechen
            // 
            this.Abbrechen.Location = new System.Drawing.Point(91, 186);
            this.Abbrechen.Name = "Abbrechen";
            this.Abbrechen.Size = new System.Drawing.Size(102, 29);
            this.Abbrechen.TabIndex = 7;
            this.Abbrechen.Text = "Abbrechen";
            this.Abbrechen.UseVisualStyleBackColor = true;
            this.Abbrechen.Click += new System.EventHandler(this.Abbrechen_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(238, 186);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(102, 29);
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
            // beiträgeBindingSource
            // 
            this.beiträgeBindingSource.DataMember = "beiträge";
            this.beiträgeBindingSource.DataSource = this.dcwDataSet;
            // 
            // beiträgeTableAdapter
            // 
            this.beiträgeTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Beitragszahlung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 248);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Abbrechen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form_Beitragszahlung";
            this.Text = "Form_Beitragszahlung";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Beitragszahlung_FormClosing);
            this.Load += new System.EventHandler(this.Form_Beitragszahlung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dcwDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beiträgeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Abbrechen;
        private System.Windows.Forms.Button OK;
        private dcwDataSet dcwDataSet;
        private System.Windows.Forms.BindingSource beiträgeBindingSource;
        private dcwDataSetTableAdapters.beiträgeTableAdapter beiträgeTableAdapter;
    }
}