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

namespace PunisherModdingToolGUI
{
    public partial class VPPForm : Form
    {
        public VPPForm()
        {
            InitializeComponent();
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            openVPPFileDialog.Filter = "*.vpp|";
            openVPPFileDialog.FileName = "";
            openVPPFileDialog.ShowDialog();

            if (openVPPFileDialog.FileName != "" && openVPPFileDialog.FileName.Contains(".vpp"))
            {
                fileTextBox.Text = Path.GetFullPath(openVPPFileDialog.FileName);

                using(var file = File.OpenRead(Path.GetFullPath(openVPPFileDialog.FileName)))
                {
                    file.Seek(8, SeekOrigin.Current);
                    using (var reader = new BinaryReader(file))
                    {
                        totalFilesTextBox.Text = reader.ReadUInt32().ToString();
                        packageSizeTextBox.Text = reader.ReadUInt32().ToString() + " Kb";
                        
                        // read files names
                        file.Seek(2048, SeekOrigin.Begin); // file names begin at pos 2048

                        for (var i = 0; i < Convert.ToInt32(totalFilesTextBox.Text); i++)
                        {
                            string name = Encoding.ASCII.GetString(reader.ReadBytes(32)).TrimEnd((Char)0);
                            listOfFIlesVPP.AppendText($"{name}");
                            listOfFIlesVPP.AppendText(";\n");
                        }
                    }
                }
            }
            else if(openVPPFileDialog.FileName != "")
            {
                fileTextBox.Text = "";
                MessageBox.Show($"Wrong file format. Choose different file.");
            }
        }

        private void openDirBtn_Click(object sender, EventArgs e)
        {
            VPPFolderBrowserDialog.ShowDialog();
            dirTextBox.Text = VPPFolderBrowserDialog.SelectedPath;

            if (VPPFolderBrowserDialog.SelectedPath == "") return;

            fileInDirTextBox.Text = Directory.GetFiles(VPPFolderBrowserDialog.SelectedPath).Length.ToString();

            foreach(var path in Directory.GetFiles(VPPFolderBrowserDialog.SelectedPath))
            {
                var fullPath = Path.GetFullPath(path);
                var name = Path.GetFileName(fullPath);
                listOfFilesDir.AppendText(name + "; ");
            }
        }

        private void unpackBtn_Click(object sender, EventArgs e)
        {
            if (openVPPFileDialog.FileName == "") return;

            Process cmd = new Process();

            string cmdArgs = "";
            string toolPath = "";

            if(ovewriteCheckBox.Checked)
            {
                cmdArgs += " -o";
            }

            if (saveOrderCheckBox.Checked)
            {
                cmdArgs += " -s";
            }

            cmdArgs += $" \"{Path.GetFullPath(openVPPFileDialog.FileName)}\"";

            if (File.Exists("Gibbed.Punisher.UnpackVPP.exe"))
            {
                toolPath = "Gibbed.Punisher.UnpackVPP.exe";
            }
            else if (File.Exists("tools\\Gibbed.Punisher.UnpackVPP.exe"))
            {
                toolPath = "tools\\Gibbed.Punisher.UnpackVPP.exe";
            }

            ProcessStartInfo cmdInfo = new ProcessStartInfo(toolPath, cmdArgs);
            cmd.StartInfo = cmdInfo;
            cmd.Start();
        }

        private void packBtn_Click(object sender, EventArgs e)
        {
            if (VPPFolderBrowserDialog.SelectedPath == "") return;

            Process cmd = new Process();

            string cmdArgs = "";
            string toolPath = "";

            if (compressCheckBox.Checked)
            {
                cmdArgs += " -c";
            }

            if (setOrderCheckBox.Checked)
            {
                cmdArgs += " -s";
            }

            cmdArgs += $" \"{VPPFolderBrowserDialog.SelectedPath}\"";

            if (File.Exists("Gibbed.Punisher.PackVPP.exe"))
            {
                toolPath = "Gibbed.Punisher.PackVPP.exe";
            }
            else if (File.Exists("tools\\Gibbed.Punisher.PackVPP.exe"))
            {
                toolPath = "tools\\Gibbed.Punisher.PackVPP.exe";
            }

            ProcessStartInfo cmdInfo = new ProcessStartInfo(toolPath, cmdArgs);
            cmd.StartInfo = cmdInfo;
            cmd.Start();
        }

        private void VPPForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists("Gibbed.Punisher.PackVPP.exe") && !File.Exists("tools\\Gibbed.Punisher.PackVPP.exe") &&
                !File.Exists("Gibbed.Punisher.UnpackVPP.exe") && !File.Exists("tools\\Gibbed.Punisher.UnpackVPP.exe"))
            {
                MessageBox.Show("Couldn't find VPP tools in root directory and tools directory. Please double check that files exist!");
                this.Close();
            };
        }
    }
}
