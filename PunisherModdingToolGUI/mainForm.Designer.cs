namespace PunisherModdingToolGUI
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.vppBtn = new System.Windows.Forms.Button();
            this.cegBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // vppBtn
            // 
            this.vppBtn.BackColor = System.Drawing.Color.DarkRed;
            this.vppBtn.Font = new System.Drawing.Font("Punishment", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vppBtn.ForeColor = System.Drawing.Color.White;
            this.vppBtn.Location = new System.Drawing.Point(13, 13);
            this.vppBtn.Name = "vppBtn";
            this.vppBtn.Size = new System.Drawing.Size(129, 59);
            this.vppBtn.TabIndex = 0;
            this.vppBtn.Text = "VPP Files";
            this.vppBtn.UseVisualStyleBackColor = false;
            this.vppBtn.Click += new System.EventHandler(this.vppBtn_Click);
            // 
            // cegBtn
            // 
            this.cegBtn.BackColor = System.Drawing.Color.DarkRed;
            this.cegBtn.Font = new System.Drawing.Font("Punishment", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cegBtn.ForeColor = System.Drawing.Color.White;
            this.cegBtn.Location = new System.Drawing.Point(13, 92);
            this.cegBtn.Name = "cegBtn";
            this.cegBtn.Size = new System.Drawing.Size(129, 60);
            this.cegBtn.TabIndex = 0;
            this.cegBtn.Text = "CEG Files";
            this.cegBtn.UseVisualStyleBackColor = false;
            this.cegBtn.Click += new System.EventHandler(this.cegBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.DarkRed;
            this.exitBtn.Font = new System.Drawing.Font("Punishment", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(13, 172);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(129, 60);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::PunisherModdingToolGUI.Properties.Resources.pun;
            this.pictureBox1.Location = new System.Drawing.Point(152, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(365, 256);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.cegBtn);
            this.Controls.Add(this.vppBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Punisher Modding Tool";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button vppBtn;
        private System.Windows.Forms.Button cegBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

