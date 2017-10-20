namespace DCW
{
    partial class Form_Hauptmenue
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Kartei = new System.Windows.Forms.Button();
            this.btn_Veranstaltungen = new System.Windows.Forms.Button();
            this.btn_AdministratorLogin = new System.Windows.Forms.Button();
            this.btn_SetupVerbindung = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Kartei
            // 
            this.btn_Kartei.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Kartei.Location = new System.Drawing.Point(105, 298);
            this.btn_Kartei.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Kartei.Name = "btn_Kartei";
            this.btn_Kartei.Size = new System.Drawing.Size(573, 60);
            this.btn_Kartei.TabIndex = 0;
            this.btn_Kartei.Text = "Mitgliederkartei";
            this.btn_Kartei.UseVisualStyleBackColor = true;
            this.btn_Kartei.Click += new System.EventHandler(this.btn_Kartei_Click);
            // 
            // btn_Veranstaltungen
            // 
            this.btn_Veranstaltungen.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Veranstaltungen.Location = new System.Drawing.Point(105, 402);
            this.btn_Veranstaltungen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Veranstaltungen.Name = "btn_Veranstaltungen";
            this.btn_Veranstaltungen.Size = new System.Drawing.Size(573, 60);
            this.btn_Veranstaltungen.TabIndex = 0;
            this.btn_Veranstaltungen.Text = "Veranstaltungen";
            this.btn_Veranstaltungen.UseVisualStyleBackColor = true;
            this.btn_Veranstaltungen.Click += new System.EventHandler(this.btn_Veranstaltungen_Click);
            // 
            // btn_AdministratorLogin
            // 
            this.btn_AdministratorLogin.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdministratorLogin.Location = new System.Drawing.Point(105, 498);
            this.btn_AdministratorLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_AdministratorLogin.Name = "btn_AdministratorLogin";
            this.btn_AdministratorLogin.Size = new System.Drawing.Size(573, 60);
            this.btn_AdministratorLogin.TabIndex = 0;
            this.btn_AdministratorLogin.Text = "Administrator Login";
            this.btn_AdministratorLogin.UseVisualStyleBackColor = true;
            this.btn_AdministratorLogin.Click += new System.EventHandler(this.btn_AdministratorLogin_Click);
            // 
            // btn_SetupVerbindung
            // 
            this.btn_SetupVerbindung.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SetupVerbindung.Location = new System.Drawing.Point(105, 602);
            this.btn_SetupVerbindung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SetupVerbindung.Name = "btn_SetupVerbindung";
            this.btn_SetupVerbindung.Size = new System.Drawing.Size(573, 60);
            this.btn_SetupVerbindung.TabIndex = 0;
            this.btn_SetupVerbindung.Text = "Setup Verbindung";
            this.btn_SetupVerbindung.UseVisualStyleBackColor = true;
            this.btn_SetupVerbindung.Click += new System.EventHandler(this.btn_SetupVerbindung_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DCW.Properties.Resources.QQ图片20170526155028;
            this.pictureBox1.Location = new System.Drawing.Point(-22, 107);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(842, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(729, 578);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form_Hauptmenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 702);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_SetupVerbindung);
            this.Controls.Add(this.btn_AdministratorLogin);
            this.Controls.Add(this.btn_Veranstaltungen);
            this.Controls.Add(this.btn_Kartei);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Hauptmenue";
            this.Text = "China-Büro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Kartei;
        private System.Windows.Forms.Button btn_Veranstaltungen;
        private System.Windows.Forms.Button btn_AdministratorLogin;
        private System.Windows.Forms.Button btn_SetupVerbindung;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

