namespace DCW
{
    partial class Form_SetupVerbindung
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_IP = new System.Windows.Forms.TextBox();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_databaseName = new System.Windows.Forms.TextBox();
            this.btn_DBConnectionTest = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_setLocal = new System.Windows.Forms.Button();
            this.btn_setRemoting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address:";
            // 
            // tb_IP
            // 
            this.tb_IP.Location = new System.Drawing.Point(165, 50);
            this.tb_IP.Name = "tb_IP";
            this.tb_IP.Size = new System.Drawing.Size(200, 21);
            this.tb_IP.TabIndex = 1;
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(165, 77);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(200, 21);
            this.tb_port.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port:";
            // 
            // tb_userName
            // 
            this.tb_userName.Location = new System.Drawing.Point(165, 104);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(200, 21);
            this.tb_userName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "User Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password:";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(165, 131);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(200, 21);
            this.tb_password.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "Database Name:";
            // 
            // tb_databaseName
            // 
            this.tb_databaseName.Location = new System.Drawing.Point(165, 158);
            this.tb_databaseName.Name = "tb_databaseName";
            this.tb_databaseName.Size = new System.Drawing.Size(200, 21);
            this.tb_databaseName.TabIndex = 5;
            // 
            // btn_DBConnectionTest
            // 
            this.btn_DBConnectionTest.Location = new System.Drawing.Point(72, 226);
            this.btn_DBConnectionTest.Name = "btn_DBConnectionTest";
            this.btn_DBConnectionTest.Size = new System.Drawing.Size(115, 23);
            this.btn_DBConnectionTest.TabIndex = 6;
            this.btn_DBConnectionTest.Text = "Verbindungstest";
            this.btn_DBConnectionTest.UseVisualStyleBackColor = true;
            this.btn_DBConnectionTest.Click += new System.EventHandler(this.btn_DBConnectionTest_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.btn_ok.Location = new System.Drawing.Point(253, 226);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 7;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(377, 225);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "kündigen";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "connString";
            // 
            // btn_setLocal
            // 
            this.btn_setLocal.Location = new System.Drawing.Point(377, 282);
            this.btn_setLocal.Name = "btn_setLocal";
            this.btn_setLocal.Size = new System.Drawing.Size(75, 23);
            this.btn_setLocal.TabIndex = 10;
            this.btn_setLocal.Text = "button1";
            this.btn_setLocal.UseVisualStyleBackColor = true;
            this.btn_setLocal.Click += new System.EventHandler(this.btn_setLocal_Click);
            // 
            // btn_setRemoting
            // 
            this.btn_setRemoting.Location = new System.Drawing.Point(377, 312);
            this.btn_setRemoting.Name = "btn_setRemoting";
            this.btn_setRemoting.Size = new System.Drawing.Size(75, 23);
            this.btn_setRemoting.TabIndex = 11;
            this.btn_setRemoting.Text = "button2";
            this.btn_setRemoting.UseVisualStyleBackColor = true;
            this.btn_setRemoting.Click += new System.EventHandler(this.btn_setRemoting_Click);
            // 
            // Form_SetupVerbindung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 388);
            this.Controls.Add(this.btn_setRemoting);
            this.Controls.Add(this.btn_setLocal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_DBConnectionTest);
            this.Controls.Add(this.tb_databaseName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_userName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_IP);
            this.Controls.Add(this.label1);
            this.Name = "Form_SetupVerbindung";
            this.Text = "Setup Verbindung";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_SetupVerbindung_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_IP;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_userName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_databaseName;
        private System.Windows.Forms.Button btn_DBConnectionTest;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_setLocal;
        private System.Windows.Forms.Button btn_setRemoting;
    }
}