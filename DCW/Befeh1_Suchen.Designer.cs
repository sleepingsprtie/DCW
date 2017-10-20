namespace DCW
{
    partial class Befeh1_Suchen
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
            this.condition = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dcwDataSet = new DCW.dcwDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.datenTableAdapter = new DCW.dcwDataSetTableAdapters.datenTableAdapter();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.tb_condition = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dcwDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // condition
            // 
            this.condition.Location = new System.Drawing.Point(343, 49);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(221, 21);
            this.condition.TabIndex = 0;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(142, 88);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(322, 88);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(29, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 20);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "=",
            "<",
            ">",
            "<>",
            "like"});
            this.comboBox2.Location = new System.Drawing.Point(263, 49);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(64, 20);
            this.comboBox2.TabIndex = 4;
            // 
            // dcwDataSet
            // 
            this.dcwDataSet.DataSetName = "dcwDataSet";
            this.dcwDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "daten";
            this.bindingSource1.DataSource = this.dcwDataSet;
            // 
            // datenTableAdapter
            // 
            this.datenTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(29, 129);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(228, 20);
            this.comboBox3.TabIndex = 5;
            // 
            // tb_condition
            // 
            this.tb_condition.Location = new System.Drawing.Point(343, 129);
            this.tb_condition.Name = "tb_condition";
            this.tb_condition.Size = new System.Drawing.Size(221, 21);
            this.tb_condition.TabIndex = 6;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(322, 157);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 7;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // Befeh1_Suchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 192);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tb_condition);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.condition);
            this.Name = "Befeh1_Suchen";
            this.Text = "Befeh1_Suchen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Befeh1_Suchen_FormClosing);
            this.Load += new System.EventHandler(this.Befeh1_Suchen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dcwDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox condition;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private dcwDataSet dcwDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private dcwDataSetTableAdapters.datenTableAdapter datenTableAdapter;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox tb_condition;
        private System.Windows.Forms.Button btn_ok;
    }
}