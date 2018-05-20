namespace SSHDeneme
{
    partial class FormSSHMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSSHMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPortNumber = new System.Windows.Forms.TextBox();
            this.lbPortNumber = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.txtHostAdress = new System.Windows.Forms.TextBox();
            this.lbHostAdress = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.txtSSHConsole = new System.Windows.Forms.TextBox();
            this.btnIfconfig = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbPing = new System.Windows.Forms.Label();
            this.lbMac = new System.Windows.Forms.Label();
            this.lbSubnetMask = new System.Windows.Forms.Label();
            this.lbIp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPortNumber);
            this.groupBox1.Controls.Add(this.lbPortNumber);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.lbPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.lbUsername);
            this.groupBox1.Controls.Add(this.txtHostAdress);
            this.groupBox1.Controls.Add(this.lbHostAdress);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SSH Connection Info";
            // 
            // txtPortNumber
            // 
            this.txtPortNumber.Location = new System.Drawing.Point(123, 106);
            this.txtPortNumber.Name = "txtPortNumber";
            this.txtPortNumber.Size = new System.Drawing.Size(192, 20);
            this.txtPortNumber.TabIndex = 8;
            this.txtPortNumber.Text = "22";
            // 
            // lbPortNumber
            // 
            this.lbPortNumber.AutoSize = true;
            this.lbPortNumber.Location = new System.Drawing.Point(17, 106);
            this.lbPortNumber.Name = "lbPortNumber";
            this.lbPortNumber.Size = new System.Drawing.Size(72, 13);
            this.lbPortNumber.TabIndex = 7;
            this.lbPortNumber.Text = "Port Number :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(123, 78);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(192, 20);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Text = "Sefa7106!A";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(17, 82);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(59, 13);
            this.lbPassword.TabIndex = 5;
            this.lbPassword.Text = "Password :";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(123, 52);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(192, 20);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.Text = "test";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(17, 55);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(61, 13);
            this.lbUsername.TabIndex = 3;
            this.lbUsername.Text = "Username :";
            // 
            // txtHostAdress
            // 
            this.txtHostAdress.Location = new System.Drawing.Point(123, 23);
            this.txtHostAdress.Name = "txtHostAdress";
            this.txtHostAdress.Size = new System.Drawing.Size(192, 20);
            this.txtHostAdress.TabIndex = 2;
            this.txtHostAdress.Text = "192.168.1.63";
            this.txtHostAdress.TextChanged += new System.EventHandler(this.txtHostAdress_TextChanged);
            // 
            // lbHostAdress
            // 
            this.lbHostAdress.AutoSize = true;
            this.lbHostAdress.Location = new System.Drawing.Point(17, 30);
            this.lbHostAdress.Name = "lbHostAdress";
            this.lbHostAdress.Size = new System.Drawing.Size(70, 13);
            this.lbHostAdress.TabIndex = 1;
            this.lbHostAdress.Text = "Host Adress :";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(9, 127);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(105, 34);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbStatus);
            this.groupBox2.Controls.Add(this.txtCommand);
            this.groupBox2.Controls.Add(this.txtSSHConsole);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(12, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(743, 296);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SSH Terminal";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbStatus.Location = new System.Drawing.Point(6, 267);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(55, 16);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.Text = "Status:";
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(0, 234);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(737, 29);
            this.txtCommand.TabIndex = 1;
            this.txtCommand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCommand_KeyPress);
            // 
            // txtSSHConsole
            // 
            this.txtSSHConsole.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSSHConsole.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSSHConsole.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSSHConsole.Location = new System.Drawing.Point(0, 19);
            this.txtSSHConsole.Multiline = true;
            this.txtSSHConsole.Name = "txtSSHConsole";
            this.txtSSHConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSSHConsole.Size = new System.Drawing.Size(737, 209);
            this.txtSSHConsole.TabIndex = 0;
            this.txtSSHConsole.TextChanged += new System.EventHandler(this.txtSSHConsole_TextChanged);
            // 
            // btnIfconfig
            // 
            this.btnIfconfig.BackColor = System.Drawing.Color.Gold;
            this.btnIfconfig.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIfconfig.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnIfconfig.Location = new System.Drawing.Point(16, 25);
            this.btnIfconfig.Name = "btnIfconfig";
            this.btnIfconfig.Size = new System.Drawing.Size(128, 31);
            this.btnIfconfig.TabIndex = 2;
            this.btnIfconfig.Text = "ifconfig + Ping";
            this.btnIfconfig.UseVisualStyleBackColor = false;
            this.btnIfconfig.Click += new System.EventHandler(this.btnIfconfig_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbPing);
            this.groupBox3.Controls.Add(this.lbMac);
            this.groupBox3.Controls.Add(this.lbSubnetMask);
            this.groupBox3.Controls.Add(this.lbIp);
            this.groupBox3.Controls.Add(this.btnIfconfig);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Location = new System.Drawing.Point(488, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 168);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Komut";
            // 
            // lbPing
            // 
            this.lbPing.AutoSize = true;
            this.lbPing.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbPing.Location = new System.Drawing.Point(14, 125);
            this.lbPing.Name = "lbPing";
            this.lbPing.Size = new System.Drawing.Size(36, 13);
            this.lbPing.TabIndex = 6;
            this.lbPing.Text = "Ping :";
            // 
            // lbMac
            // 
            this.lbMac.AutoSize = true;
            this.lbMac.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbMac.Location = new System.Drawing.Point(13, 59);
            this.lbMac.Name = "lbMac";
            this.lbMac.Size = new System.Drawing.Size(34, 13);
            this.lbMac.TabIndex = 5;
            this.lbMac.Text = "Mac :";
            // 
            // lbSubnetMask
            // 
            this.lbSubnetMask.AutoSize = true;
            this.lbSubnetMask.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSubnetMask.Location = new System.Drawing.Point(13, 103);
            this.lbSubnetMask.Name = "lbSubnetMask";
            this.lbSubnetMask.Size = new System.Drawing.Size(80, 13);
            this.lbSubnetMask.TabIndex = 4;
            this.lbSubnetMask.Text = "Subnet Mask :";
            this.lbSubnetMask.Click += new System.EventHandler(this.lbSubnetMask_Click);
            // 
            // lbIp
            // 
            this.lbIp.AutoSize = true;
            this.lbIp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbIp.Location = new System.Drawing.Point(13, 81);
            this.lbIp.Name = "lbIp";
            this.lbIp.Size = new System.Drawing.Size(22, 13);
            this.lbIp.TabIndex = 3;
            this.lbIp.Text = "IP :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(866, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // FormSSHMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSSHMain";
            this.Text = "SSH";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSSHMain_FormClosing);
            this.Load += new System.EventHandler(this.FormSSHMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPortNumber;
        private System.Windows.Forms.Label lbPortNumber;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox txtHostAdress;
        private System.Windows.Forms.Label lbHostAdress;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.TextBox txtSSHConsole;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Button btnIfconfig;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbIp;
        private System.Windows.Forms.Label lbSubnetMask;
        private System.Windows.Forms.Label lbMac;
        private System.Windows.Forms.Label lbPing;
        private System.Windows.Forms.Label label1;
    }
}

