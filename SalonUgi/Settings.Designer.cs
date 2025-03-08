namespace SalonUgi
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SetingsGoBackBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SounCheckBox = new System.Windows.Forms.CheckBox();
            this.SoundVolumeLbl = new System.Windows.Forms.Label();
            this.SongDpropDown = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SettingsLbl = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.Pink;
            this.panel1.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel1.Controls.Add(this.SetingsGoBackBtn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.SongDpropDown);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(333, 12);
            this.panel1.MaximumSize = new System.Drawing.Size(500, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(500, 660);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 660);
            this.panel1.TabIndex = 0;
            // 
            // SetingsGoBackBtn
            // 
            this.SetingsGoBackBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SetingsGoBackBtn.BackColor = System.Drawing.Color.Transparent;
            this.SetingsGoBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetingsGoBackBtn.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetingsGoBackBtn.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.SetingsGoBackBtn.Location = new System.Drawing.Point(155, 484);
            this.SetingsGoBackBtn.Name = "SetingsGoBackBtn";
            this.SetingsGoBackBtn.Size = new System.Drawing.Size(191, 61);
            this.SetingsGoBackBtn.TabIndex = 5;
            this.SetingsGoBackBtn.Text = "Go back";
            this.SetingsGoBackBtn.UseVisualStyleBackColor = false;
            this.SetingsGoBackBtn.Click += new System.EventHandler(this.SetingsGoBackBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.trackBar1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.SoundVolumeLbl);
            this.panel3.Location = new System.Drawing.Point(66, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(369, 187);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.SounCheckBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 118);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(369, 69);
            this.panel4.TabIndex = 4;
            // 
            // SounCheckBox
            // 
            this.SounCheckBox.AutoSize = true;
            this.SounCheckBox.Checked = true;
            this.SounCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SounCheckBox.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SounCheckBox.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.SounCheckBox.Location = new System.Drawing.Point(74, 13);
            this.SounCheckBox.Name = "SounCheckBox";
            this.SounCheckBox.Size = new System.Drawing.Size(190, 48);
            this.SounCheckBox.TabIndex = 0;
            this.SounCheckBox.Text = "Sound On";
            this.SounCheckBox.UseVisualStyleBackColor = true;
            this.SounCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SoundVolumeLbl
            // 
            this.SoundVolumeLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SoundVolumeLbl.AutoSize = true;
            this.SoundVolumeLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SoundVolumeLbl.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoundVolumeLbl.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.SoundVolumeLbl.Location = new System.Drawing.Point(46, 13);
            this.SoundVolumeLbl.Name = "SoundVolumeLbl";
            this.SoundVolumeLbl.Size = new System.Drawing.Size(273, 44);
            this.SoundVolumeLbl.TabIndex = 3;
            this.SoundVolumeLbl.Text = "Sound volume : ";
            this.SoundVolumeLbl.Click += new System.EventHandler(this.SoundVolumeLbl_Click);
            // 
            // SongDpropDown
            // 
            this.SongDpropDown.BackColor = System.Drawing.Color.Pink;
            this.SongDpropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SongDpropDown.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongDpropDown.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.SongDpropDown.FormattingEnabled = true;
            this.SongDpropDown.Items.AddRange(new object[] {
            "Manele",
            "Emo",
            "Patriotic",
            "NPC"});
            this.SongDpropDown.Location = new System.Drawing.Point(116, 298);
            this.SongDpropDown.Name = "SongDpropDown";
            this.SongDpropDown.Size = new System.Drawing.Size(275, 52);
            this.SongDpropDown.TabIndex = 1;
            this.SongDpropDown.SelectedIndexChanged += new System.EventHandler(this.SongDpropDown_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SettingsLbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 99);
            this.panel2.TabIndex = 0;
            // 
            // SettingsLbl
            // 
            this.SettingsLbl.AutoSize = true;
            this.SettingsLbl.Font = new System.Drawing.Font("Harrington", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsLbl.ForeColor = System.Drawing.Color.DeepPink;
            this.SettingsLbl.Location = new System.Drawing.Point(152, 20);
            this.SettingsLbl.Name = "SettingsLbl";
            this.SettingsLbl.Size = new System.Drawing.Size(197, 55);
            this.SettingsLbl.TabIndex = 0;
            this.SettingsLbl.Text = "Settings";
            this.SettingsLbl.Click += new System.EventHandler(this.SettingsLbl_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(129, 408);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(306, 49);
            this.axWindowsMediaPlayer1.TabIndex = 6;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(50, 60);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(265, 56);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1142, 683);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1160, 730);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label SettingsLbl;
        private System.Windows.Forms.Label SoundVolumeLbl;
        private System.Windows.Forms.ComboBox SongDpropDown;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button SetingsGoBackBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox SounCheckBox;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}