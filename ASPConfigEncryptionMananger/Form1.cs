using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ASPConfigEncryptionMananger
{
    public partial class Form1 : Form
    {
        string NetFWDir = string.Format(@"{0}\Microsoft.NET\Framework\", Environment.GetEnvironmentVariable("windir"));
        public Form1()
        {
            InitializeComponent();
            txtConfigSection.Text = "connectionStrings";
            if (Directory.Exists(NetFWDir))
            {
                foreach (string d in Directory.GetDirectories(NetFWDir))
                {
                    if (d.ToLower().Contains(@"framework\v"))
                        cmbNetVer.Items.Add(d.Substring(d.LastIndexOf('\\')).Replace("\\", ""));
                }
                cmbNetVer.SelectedIndex = cmbNetVer.Items.Count - 1;
            }
            else
                MessageBox.Show("Unable to locate .NET Framework install in windows directory.");
        }

        private void BtnEnc_Click(object sender, EventArgs e)
        {
            log(Environment.NewLine);
            log("###################");
            log("Started Encrypt");
            log("###################");
            if (!string.IsNullOrEmpty(txtConfigSection.Text) && !string.IsNullOrEmpty(txtAppDir.Text) && cmbNetVer.SelectedIndex > -1)
            {
                string cmd = string.Format("aspnet_regiis.exe -pef \"{0}\" \"{1}\"", txtConfigSection.Text, txtAppDir.Text);
                RunCMD(cmd);
            }
            else
                log("ERROR : Please fill in all fields");
        }

        private void BtnDec_Click(object sender, EventArgs e)
        {
            log(Environment.NewLine); 
            log("###################");
            log("Started Decrypt");
            log("###################");
            if (!string.IsNullOrEmpty(txtConfigSection.Text) && !string.IsNullOrEmpty(txtAppDir.Text) && cmbNetVer.SelectedIndex > -1)
            {
                string cmd = string.Format("aspnet_regiis.exe -pdf \"{0}\" \"{1}\"", txtConfigSection.Text, txtAppDir.Text);
                RunCMD(cmd);
            }
            else
                log("ERROR : Please fill in all fields");
        }

        void RunCMD(string cmd)
        {
            try
            {
                string cd = string.Format("cd \"{0}\"", NetFWDir + cmbNetVer.SelectedItem);
                string tempCMD = Path.Combine(Environment.CurrentDirectory, "temp.cmd");

                //check if file exists.
                if (File.Exists(tempCMD))
                    File.Delete(tempCMD);

                //create new file.
                var fi = new FileInfo(tempCMD);
                var fileStream = fi.Create();
                fileStream.Close();

                //write commands to file.
                using (TextWriter writer = new StreamWriter(tempCMD))
                {
                    writer.WriteLine(cd);
                    writer.WriteLine(cmd);
                    writer.WriteLine("exit");
                }

                Process p = new Process();
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.FileName = tempCMD;
                p.Start();
                string output = p.StandardOutput.ReadToEnd();
                log(output);
                p.WaitForExit();

                //clean up
                File.Delete(tempCMD);

                if (output.ToLower().Contains("succeeded!"))
                {
                    log(Environment.NewLine);
                    log("Completed Successfully.");
                }
            }
            catch (Exception e)
            {
                log(e.ToString());
            }
        }

        void log(string log)
        {
            if(!string.IsNullOrEmpty(txtOut.Text))
                txtOut.Text += Environment.NewLine;
            txtOut.Text += log;
            txtOut.SelectionStart = txtOut.TextLength;
            txtOut.ScrollToCaret();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                txtAppDir.Text = folderBrowserDialog1.SelectedPath;
        }
    }
}
