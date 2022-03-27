namespace DeadByToolbox
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.labelProxyStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCopyBhvrSession = new System.Windows.Forms.Button();
            this.textBoxBhvrSession = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxCurrencySpoofer = new System.Windows.Forms.CheckBox();
            this.checkBoxInventoryOverride = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonSSLBypassUninstall = new System.Windows.Forms.Button();
            this.buttonSSLBypassInstall = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCurrencyEdit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonStartStop);
            this.groupBox1.Controls.Add(this.labelProxyStatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proxy";
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartStop.Location = new System.Drawing.Point(237, 31);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(91, 31);
            this.buttonStartStop.TabIndex = 1;
            this.buttonStartStop.Text = "Stop";
            this.buttonStartStop.UseVisualStyleBackColor = true;
            this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStop_Click);
            // 
            // labelProxyStatus
            // 
            this.labelProxyStatus.AutoSize = true;
            this.labelProxyStatus.ForeColor = System.Drawing.Color.Green;
            this.labelProxyStatus.Location = new System.Drawing.Point(65, 39);
            this.labelProxyStatus.Name = "labelProxyStatus";
            this.labelProxyStatus.Size = new System.Drawing.Size(52, 15);
            this.labelProxyStatus.TabIndex = 0;
            this.labelProxyStatus.Text = "Running";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonCopyBhvrSession);
            this.groupBox2.Controls.Add(this.textBoxBhvrSession);
            this.groupBox2.Location = new System.Drawing.Point(12, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 64);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cookie Grabber";
            // 
            // buttonCopyBhvrSession
            // 
            this.buttonCopyBhvrSession.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopyBhvrSession.Location = new System.Drawing.Point(261, 22);
            this.buttonCopyBhvrSession.Name = "buttonCopyBhvrSession";
            this.buttonCopyBhvrSession.Size = new System.Drawing.Size(67, 23);
            this.buttonCopyBhvrSession.TabIndex = 2;
            this.buttonCopyBhvrSession.Text = "Copy";
            this.buttonCopyBhvrSession.UseVisualStyleBackColor = true;
            this.buttonCopyBhvrSession.Click += new System.EventHandler(this.buttonCopyBhvrSession_Click);
            // 
            // textBoxBhvrSession
            // 
            this.textBoxBhvrSession.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBhvrSession.Location = new System.Drawing.Point(17, 22);
            this.textBoxBhvrSession.Name = "textBoxBhvrSession";
            this.textBoxBhvrSession.Size = new System.Drawing.Size(238, 23);
            this.textBoxBhvrSession.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.buttonCurrencyEdit);
            this.groupBox3.Controls.Add(this.checkBoxCurrencySpoofer);
            this.groupBox3.Controls.Add(this.checkBoxInventoryOverride);
            this.groupBox3.Location = new System.Drawing.Point(12, 273);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 97);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // checkBoxCurrencySpoofer
            // 
            this.checkBoxCurrencySpoofer.AutoSize = true;
            this.checkBoxCurrencySpoofer.Location = new System.Drawing.Point(17, 50);
            this.checkBoxCurrencySpoofer.Name = "checkBoxCurrencySpoofer";
            this.checkBoxCurrencySpoofer.Size = new System.Drawing.Size(118, 19);
            this.checkBoxCurrencySpoofer.TabIndex = 0;
            this.checkBoxCurrencySpoofer.Text = "Currency Spoofer\r\n";
            this.toolTip.SetToolTip(this.checkBoxCurrencySpoofer, "Uses currencies.json\r\nRestart Proxy if you create or edit the file.");
            this.checkBoxCurrencySpoofer.UseVisualStyleBackColor = true;
            this.checkBoxCurrencySpoofer.CheckedChanged += new System.EventHandler(this.checkBoxCurrencySpoofer_CheckedChanged);
            // 
            // checkBoxInventoryOverride
            // 
            this.checkBoxInventoryOverride.AutoSize = true;
            this.checkBoxInventoryOverride.Location = new System.Drawing.Point(17, 22);
            this.checkBoxInventoryOverride.Name = "checkBoxInventoryOverride";
            this.checkBoxInventoryOverride.Size = new System.Drawing.Size(189, 19);
            this.checkBoxInventoryOverride.TabIndex = 0;
            this.checkBoxInventoryOverride.Text = "Inventory Override (Unlock All)";
            this.toolTip.SetToolTip(this.checkBoxInventoryOverride, "Uses inventory.json\r\nRestart Proxy if you create or edit this file.");
            this.checkBoxInventoryOverride.UseVisualStyleBackColor = true;
            this.checkBoxInventoryOverride.CheckedChanged += new System.EventHandler(this.checkBoxInventoryOverride_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.buttonSSLBypassUninstall);
            this.groupBox4.Controls.Add(this.buttonSSLBypassInstall);
            this.groupBox4.Location = new System.Drawing.Point(12, 175);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(343, 92);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SSL Bypass";
            // 
            // buttonSSLBypassUninstall
            // 
            this.buttonSSLBypassUninstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSSLBypassUninstall.Location = new System.Drawing.Point(193, 32);
            this.buttonSSLBypassUninstall.Name = "buttonSSLBypassUninstall";
            this.buttonSSLBypassUninstall.Size = new System.Drawing.Size(135, 32);
            this.buttonSSLBypassUninstall.TabIndex = 1;
            this.buttonSSLBypassUninstall.Text = "Uninstall";
            this.buttonSSLBypassUninstall.UseVisualStyleBackColor = true;
            this.buttonSSLBypassUninstall.Click += new System.EventHandler(this.buttonSSLBypassUninstall_Click);
            // 
            // buttonSSLBypassInstall
            // 
            this.buttonSSLBypassInstall.Location = new System.Drawing.Point(17, 32);
            this.buttonSSLBypassInstall.Name = "buttonSSLBypassInstall";
            this.buttonSSLBypassInstall.Size = new System.Drawing.Size(135, 32);
            this.buttonSSLBypassInstall.TabIndex = 0;
            this.buttonSSLBypassInstall.Text = "Install";
            this.buttonSSLBypassInstall.UseVisualStyleBackColor = true;
            this.buttonSSLBypassInstall.Click += new System.EventHandler(this.buttonSSLBypassInstall_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Note: Only needed for Steam Version \r\n";
            // 
            // buttonCurrencyEdit
            // 
            this.buttonCurrencyEdit.Location = new System.Drawing.Point(141, 47);
            this.buttonCurrencyEdit.Name = "buttonCurrencyEdit";
            this.buttonCurrencyEdit.Size = new System.Drawing.Size(45, 22);
            this.buttonCurrencyEdit.TabIndex = 1;
            this.buttonCurrencyEdit.Text = "Edit";
            this.buttonCurrencyEdit.UseVisualStyleBackColor = true;
            this.buttonCurrencyEdit.Click += new System.EventHandler(this.buttonCurrencyEdit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 382);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Dead by Toolbox | Created by getBrainError";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonStartStop;
        private System.Windows.Forms.Label labelProxyStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonCopyBhvrSession;
        private System.Windows.Forms.TextBox textBoxBhvrSession;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxCurrencySpoofer;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox checkBoxInventoryOverride;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonSSLBypassInstall;
        private System.Windows.Forms.Button buttonSSLBypassUninstall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCurrencyEdit;
    }
}
