namespace PunisherModdingToolGUI
{
    partial class CEGForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.unpackBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listOfFIlesCEG = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalFilesTextBox = new System.Windows.Forms.TextBox();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.packBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listOfFilesDir = new System.Windows.Forms.RichTextBox();
            this.fileInDirTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openDirBtn = new System.Windows.Forms.Button();
            this.dirTextBox = new System.Windows.Forms.TextBox();
            this.openCEGFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.CEGFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(813, 414);
            this.splitContainer1.SplitterDistance = 193;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.unpackBtn);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.openFileBtn);
            this.groupBox1.Controls.Add(this.fileTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Punishment", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unpack CEG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "File location";
            // 
            // unpackBtn
            // 
            this.unpackBtn.BackColor = System.Drawing.Color.DarkRed;
            this.unpackBtn.Font = new System.Drawing.Font("Punishment", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unpackBtn.Location = new System.Drawing.Point(293, 126);
            this.unpackBtn.Name = "unpackBtn";
            this.unpackBtn.Size = new System.Drawing.Size(153, 40);
            this.unpackBtn.TabIndex = 6;
            this.unpackBtn.Text = "Unpack";
            this.unpackBtn.UseVisualStyleBackColor = false;
            this.unpackBtn.Click += new System.EventHandler(this.unpackBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listOfFIlesCEG);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.totalFilesTextBox);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(454, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 148);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "VPP data";
            // 
            // listOfFIlesCEG
            // 
            this.listOfFIlesCEG.BackColor = System.Drawing.Color.Silver;
            this.listOfFIlesCEG.Font = new System.Drawing.Font("Punishment", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOfFIlesCEG.ForeColor = System.Drawing.Color.Black;
            this.listOfFIlesCEG.Location = new System.Drawing.Point(10, 55);
            this.listOfFIlesCEG.Name = "listOfFIlesCEG";
            this.listOfFIlesCEG.ReadOnly = true;
            this.listOfFIlesCEG.Size = new System.Drawing.Size(318, 84);
            this.listOfFIlesCEG.TabIndex = 3;
            this.listOfFIlesCEG.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Punishment", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amount of files";
            // 
            // totalFilesTextBox
            // 
            this.totalFilesTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.totalFilesTextBox.Font = new System.Drawing.Font("Punishment", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalFilesTextBox.Location = new System.Drawing.Point(106, 23);
            this.totalFilesTextBox.Name = "totalFilesTextBox";
            this.totalFilesTextBox.ReadOnly = true;
            this.totalFilesTextBox.Size = new System.Drawing.Size(222, 26);
            this.totalFilesTextBox.TabIndex = 0;
            this.totalFilesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // openFileBtn
            // 
            this.openFileBtn.BackColor = System.Drawing.Color.DarkRed;
            this.openFileBtn.Font = new System.Drawing.Font("Punishment", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFileBtn.Location = new System.Drawing.Point(9, 126);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(153, 40);
            this.openFileBtn.TabIndex = 1;
            this.openFileBtn.Text = "Open file";
            this.openFileBtn.UseVisualStyleBackColor = false;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // fileTextBox
            // 
            this.fileTextBox.BackColor = System.Drawing.Color.Silver;
            this.fileTextBox.Font = new System.Drawing.Font("Punishment", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileTextBox.ForeColor = System.Drawing.Color.Black;
            this.fileTextBox.Location = new System.Drawing.Point(7, 71);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(439, 26);
            this.fileTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.packBtn);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.openDirBtn);
            this.groupBox2.Controls.Add(this.dirTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Punishment", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(794, 187);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pack CEG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Directory location";
            // 
            // packBtn
            // 
            this.packBtn.BackColor = System.Drawing.Color.DarkRed;
            this.packBtn.Font = new System.Drawing.Font("Punishment", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packBtn.Location = new System.Drawing.Point(296, 141);
            this.packBtn.Name = "packBtn";
            this.packBtn.Size = new System.Drawing.Size(152, 40);
            this.packBtn.TabIndex = 6;
            this.packBtn.Text = "Pack";
            this.packBtn.UseVisualStyleBackColor = false;
            this.packBtn.Click += new System.EventHandler(this.packBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listOfFilesDir);
            this.groupBox4.Controls.Add(this.fileInDirTextBox);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(454, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(334, 163);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Directory data";
            // 
            // listOfFilesDir
            // 
            this.listOfFilesDir.BackColor = System.Drawing.Color.Silver;
            this.listOfFilesDir.Font = new System.Drawing.Font("Punishment", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOfFilesDir.ForeColor = System.Drawing.Color.Black;
            this.listOfFilesDir.Location = new System.Drawing.Point(11, 54);
            this.listOfFilesDir.Name = "listOfFilesDir";
            this.listOfFilesDir.ReadOnly = true;
            this.listOfFilesDir.Size = new System.Drawing.Size(318, 103);
            this.listOfFilesDir.TabIndex = 3;
            this.listOfFilesDir.Text = "";
            // 
            // fileInDirTextBox
            // 
            this.fileInDirTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.fileInDirTextBox.Font = new System.Drawing.Font("Punishment", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileInDirTextBox.Location = new System.Drawing.Point(107, 22);
            this.fileInDirTextBox.Name = "fileInDirTextBox";
            this.fileInDirTextBox.ReadOnly = true;
            this.fileInDirTextBox.Size = new System.Drawing.Size(221, 26);
            this.fileInDirTextBox.TabIndex = 1;
            this.fileInDirTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Punishment", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Amount of files";
            // 
            // openDirBtn
            // 
            this.openDirBtn.BackColor = System.Drawing.Color.DarkRed;
            this.openDirBtn.Font = new System.Drawing.Font("Punishment", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openDirBtn.Location = new System.Drawing.Point(8, 141);
            this.openDirBtn.Name = "openDirBtn";
            this.openDirBtn.Size = new System.Drawing.Size(152, 40);
            this.openDirBtn.TabIndex = 5;
            this.openDirBtn.Text = "Open directory";
            this.openDirBtn.UseVisualStyleBackColor = false;
            this.openDirBtn.Click += new System.EventHandler(this.openDirBtn_Click);
            // 
            // dirTextBox
            // 
            this.dirTextBox.BackColor = System.Drawing.Color.Silver;
            this.dirTextBox.Font = new System.Drawing.Font("Punishment", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dirTextBox.ForeColor = System.Drawing.Color.Black;
            this.dirTextBox.Location = new System.Drawing.Point(9, 91);
            this.dirTextBox.Name = "dirTextBox";
            this.dirTextBox.Size = new System.Drawing.Size(438, 26);
            this.dirTextBox.TabIndex = 4;
            // 
            // CEGForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(813, 414);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CEGForm";
            this.Text = "CEG Pack/Unpack";
            this.Load += new System.EventHandler(this.CEGForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button unpackBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox listOfFIlesCEG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalFilesTextBox;
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button packBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox listOfFilesDir;
        private System.Windows.Forms.TextBox fileInDirTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button openDirBtn;
        private System.Windows.Forms.TextBox dirTextBox;
        private System.Windows.Forms.OpenFileDialog openCEGFileDialog;
        private System.Windows.Forms.FolderBrowserDialog CEGFolderBrowserDialog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}