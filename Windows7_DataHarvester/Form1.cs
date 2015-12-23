using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows7_DataHarvester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _txtPath.Text = @"C:\Users\hogarth45\Documents\dock";
        }

        private void _btnStart_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(_txtPath.Text))
            {
                MessageBox.Show("Please select a folder to store the information gathered.");
                return;
            }

            if (!Directory.Exists(_txtPath.Text))
            {
                MessageBox.Show("The selected folder does not exist.");
                return;
            }

            CopyFile("Thumbnail cache", @"C:\Users\%username%\AppData\Local\Microsoft\Windows\Explorer", _txtPath.Text);
            CopyFile("Wifi Passwords", @"C:\ProgramData\Microsoft\Wlansvc\Profiles\Interfaces", _txtPath.Text);
            CopyFile("Hibernation File", @"C:\hiberfil.sys", _txtPath.Text);
            CopyFile("Spool Files", @"%SystemRoot%\SYSTEM32\SPOOL\PRINTERS", _txtPath.Text);
            CopyFile("Prefetch", @"%SystemRoot%\Prefetch", _txtPath.Text);
            CopyFile("Firefox", @"%APPDATA%\Mozilla\Firefox\Profiles", _txtPath.Text);
            CopyFile("USB History", @"%SystemRoot%\inf\setupapi.dev.log", _txtPath.Text);
            CopyFile("Hibernation File", @"%SystemRoot%\System32\config\System", _txtPath.Text);
        }

        private void _btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
                _txtPath.Text = folderBrowserDialog1.SelectedPath;
        }

        private void CopyFile(string name, string targetPath, string homePath)
        {
            Message("Attempting to move " + name);
            string[] targetPathParts = targetPath.Split('\\');

            for(int x =0; x<targetPathParts.Length;x++)
            {
                if (targetPathParts[x].Contains('%'))
                    targetPathParts[x] = Environment.GetEnvironmentVariable(targetPathParts[x].Trim('%'));
                else if (targetPathParts[x].Contains(':'))
                    targetPathParts[x] = targetPathParts[x].Insert(targetPathParts[x].IndexOf(':') + 1, "\\");
            }



            if (!Directory.Exists(Path.Combine(targetPathParts)))
            {
                Message("Failed, not normal location");
                //Message("Could not find, " + name + " located at " + targetPath);
                return;
            }

            if (targetPathParts[targetPathParts.Length - 1].Contains('.'))
            {
                Directory.CreateDirectory(Path.Combine(homePath, name));
                File.Copy(Path.Combine(targetPathParts), homePath, true);
            }
            else
            {
                Directory.CreateDirectory(Path.Combine(homePath, name));

                string[] files = System.IO.Directory.GetFiles(Path.Combine(targetPathParts));
                foreach (string s in files)
                {
                    // Use static Path methods to extract only the file name from the path.
                    string fileName = System.IO.Path.GetFileName(s);
                    string destFile = System.IO.Path.Combine(homePath, name, fileName);
                    System.IO.File.Copy(s, destFile, true);
                }
            }
            Message(name + " Successfully moved");
        }

        private void Message(string message)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(message);
            sb.Append('\n');
            _rtbLogs.Text += sb.ToString();
            _rtbLogs.Refresh();
        }
    }
}
