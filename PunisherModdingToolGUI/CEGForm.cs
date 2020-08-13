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
    public partial class CEGForm : Form
    {
        public CEGForm()
        {
            InitializeComponent();
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            openCEGFileDialog.Filter = "*.ceg|";
            openCEGFileDialog.FileName = "";
            openCEGFileDialog.ShowDialog();

            if (openCEGFileDialog.FileName != "" && openCEGFileDialog.FileName.Contains(".ceg"))
            {
                fileTextBox.Text = Path.GetFullPath(openCEGFileDialog.FileName);

                using (var file = File.OpenRead(Path.GetFullPath(openCEGFileDialog.FileName)))
                {
                    file.Seek(24, SeekOrigin.Current);
                    using (var reader = new BinaryReader(file))
                    {
                        totalFilesTextBox.Text = reader.ReadUInt32().ToString();
                        // read ceg files names
                        file.Seek(20, SeekOrigin.Current); // file names begin at pos 48

                        for (var i = 0; i< Convert.ToInt32(totalFilesTextBox.Text); i++)
                        {
                            string name = Encoding.ASCII.GetString(reader.ReadBytes(48)).TrimEnd((Char)0);
                            listOfFIlesCEG.AppendText($"{name}");
                            listOfFIlesCEG.AppendText(";\n");
                        }
                    }
                }
            }
            else if(openCEGFileDialog.FileName != "")
            {
                fileTextBox.Text = "";
                MessageBox.Show($"Wrong file format. Choose different file.");
            }
        }

        private void unpackBtn_Click(object sender, EventArgs e)
        {
            if (openCEGFileDialog.FileName == "") return;

            if (!File.Exists("CEGTool.exe") && !File.Exists("cegtool\\CEGTool.exe")) return;

            callCegTool("unpack");
        }

        private void openDirBtn_Click(object sender, EventArgs e)
        {
            CEGFolderBrowserDialog.ShowDialog();
            dirTextBox.Text = CEGFolderBrowserDialog.SelectedPath;

            if (CEGFolderBrowserDialog.SelectedPath == "") return;

            fileInDirTextBox.Text = Directory.GetFiles(CEGFolderBrowserDialog.SelectedPath).Length.ToString();

            foreach (var path in Directory.GetFiles(CEGFolderBrowserDialog.SelectedPath))
            {
                var fullPath = Path.GetFullPath(path);
                var name = Path.GetFileName(fullPath);
                listOfFilesDir.AppendText(name + "; ");
            }
        }

        private void packBtn_Click(object sender, EventArgs e)
        {
            if (CEGFolderBrowserDialog.SelectedPath == "") return;

            callCegTool("pack");
        }

        private void callCegTool(string action)
        {
            Process cmd = new Process();
            string cmdArgs = "";
            string toolPath = "";

            if (action == "unpack")
            {
                cmdArgs = $" -d \"{Path.GetFullPath(openCEGFileDialog.FileName)}\"";
            }
            else if (action == "pack")
            {
                cmdArgs = $" -c \"{CEGFolderBrowserDialog.SelectedPath}\"";
            }

            if(File.Exists("CEGTool.exe"))
            {
                toolPath = "CEGTool.exe";
            }
            else if(File.Exists("tools\\CEGTool.exe"))
            {
                toolPath = "tools\\CEGTool.exe";
            }

            ProcessStartInfo cmdInfo = new ProcessStartInfo(toolPath, cmdArgs);
            cmd.StartInfo = cmdInfo;
            cmd.Start();
        }

        private void CEGForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists("CEGTool.exe") && !File.Exists("tools\\CEGTool.exe"))
            {
                MessageBox.Show("Couldn't find CEGTool in root directory and tools directory. Please double check that file CEGTool.exe exists!");
                this.Close();
            };
        }
    }
}
