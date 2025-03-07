namespace SalonUgi
{
    partial class BrickTips
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrickTips));
            this.panBrick = new System.Windows.Forms.Panel();
            this.manaBrick = new System.Windows.Forms.Panel();
            this.GoBackPnl = new System.Windows.Forms.Panel();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.panBrick.SuspendLayout();
            this.SuspendLayout();
            // 
            // panBrick
            // 
            this.panBrick.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panBrick.BackColor = System.Drawing.Color.Transparent;
            this.panBrick.BackgroundImage = global::SalonUgi.Properties.Resources.prosop_removebg_preview;
            this.panBrick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panBrick.Controls.Add(this.manaBrick);
            this.panBrick.Dock = System.Windows.Forms.DockStyle.Right;
            this.panBrick.Location = new System.Drawing.Point(538, 0);
            this.panBrick.Name = "panBrick";
            this.panBrick.Size = new System.Drawing.Size(604, 683);
            this.panBrick.TabIndex = 0;
            // 
            // manaBrick
            // 
            this.manaBrick.BackgroundImage = global::SalonUgi.Properties.Resources.bric1;
            this.manaBrick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.manaBrick.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.manaBrick.Location = new System.Drawing.Point(0, 147);
            this.manaBrick.Name = "manaBrick";
            this.manaBrick.Size = new System.Drawing.Size(604, 536);
            this.manaBrick.TabIndex = 0;
            // 
            // GoBackPnl
            // 
            this.GoBackPnl.BackColor = System.Drawing.Color.Transparent;
            this.GoBackPnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GoBackPnl.BackgroundImage")));
            this.GoBackPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GoBackPnl.Location = new System.Drawing.Point(32, 30);
            this.GoBackPnl.Name = "GoBackPnl";
            this.GoBackPnl.Size = new System.Drawing.Size(82, 78);
            this.GoBackPnl.TabIndex = 3;
            this.GoBackPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.GoBackPnl_Paint);
            this.GoBackPnl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GoBackPnl_MouseClick);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.BackColor = System.Drawing.Color.Pink;
            this.SettingsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingsBtn.BackgroundImage")));
            this.SettingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SettingsBtn.Location = new System.Drawing.Point(38, 131);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(70, 70);
            this.SettingsBtn.TabIndex = 4;
            this.SettingsBtn.UseVisualStyleBackColor = false;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // BrickTips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SalonUgi.Properties.Resources.rozovyi_rozovyi_fon_pink_lak_dlia_nogtei_instrumenty_kisti1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1142, 683);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.GoBackPnl);
            this.Controls.Add(this.panBrick);
            this.MinimumSize = new System.Drawing.Size(1160, 730);
            this.Name = "BrickTips";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BrickTips";
            this.panBrick.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panBrick;
        private System.Windows.Forms.Panel manaBrick;
        private System.Windows.Forms.Panel GoBackPnl;
        private System.Windows.Forms.Button SettingsBtn;
    }
}