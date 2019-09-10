namespace ASPConfigEncryptionMananger
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEnc = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.cmbNetVer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfigSection = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAppDir = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEnc
            // 
            this.btnEnc.Location = new System.Drawing.Point(12, 194);
            this.btnEnc.Name = "btnEnc";
            this.btnEnc.Size = new System.Drawing.Size(76, 42);
            this.btnEnc.TabIndex = 0;
            this.btnEnc.Text = "Encrypt";
            this.btnEnc.UseVisualStyleBackColor = true;
            this.btnEnc.Click += new System.EventHandler(this.BtnEnc_Click);
            // 
            // btnDec
            // 
            this.btnDec.Location = new System.Drawing.Point(98, 194);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(76, 42);
            this.btnDec.TabIndex = 1;
            this.btnDec.Text = "Decrypt";
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.BtnDec_Click);
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(180, 12);
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOut.Size = new System.Drawing.Size(196, 224);
            this.txtOut.TabIndex = 2;
            // 
            // cmbNetVer
            // 
            this.cmbNetVer.FormattingEnabled = true;
            this.cmbNetVer.Location = new System.Drawing.Point(12, 25);
            this.cmbNetVer.Name = "cmbNetVer";
            this.cmbNetVer.Size = new System.Drawing.Size(162, 21);
            this.cmbNetVer.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = ".NET Version";
            // 
            // txtConfigSection
            // 
            this.txtConfigSection.Location = new System.Drawing.Point(12, 72);
            this.txtConfigSection.Name = "txtConfigSection";
            this.txtConfigSection.Size = new System.Drawing.Size(162, 20);
            this.txtConfigSection.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Config Section";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(99, 145);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 22);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Application Directory";
            // 
            // txtAppDir
            // 
            this.txtAppDir.Location = new System.Drawing.Point(12, 119);
            this.txtAppDir.Name = "txtAppDir";
            this.txtAppDir.Size = new System.Drawing.Size(162, 20);
            this.txtAppDir.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 248);
            this.Controls.Add(this.txtAppDir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConfigSection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbNetVer);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.btnEnc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ASP Config Encryption Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnc;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.ComboBox cmbNetVer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfigSection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAppDir;
    }
}

