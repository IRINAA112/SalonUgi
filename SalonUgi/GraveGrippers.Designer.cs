namespace SalonUgi
{
    partial class GraveGrippers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraveGrippers));
            this.panGrave = new System.Windows.Forms.Panel();
            this.panManaGrave = new System.Windows.Forms.Panel();
            this.GoBackPnl = new System.Windows.Forms.Panel();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.panGrave.SuspendLayout();
            this.SuspendLayout();
            // 
            // panGrave
            // 
            this.panGrave.BackColor = System.Drawing.Color.Transparent;
            this.panGrave.BackgroundImage = global::SalonUgi.Properties.Resources.prosop_removebg_preview;
            this.panGrave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panGrave.Controls.Add(this.panManaGrave);
            this.panGrave.Dock = System.Windows.Forms.DockStyle.Right;
            this.panGrave.Location = new System.Drawing.Point(547, 0);
            this.panGrave.Name = "panGrave";
            this.panGrave.Size = new System.Drawing.Size(595, 696);
            this.panGrave.TabIndex = 0;
            // 
            // panManaGrave
            // 
            this.panManaGrave.BackgroundImage = global::SalonUgi.Properties.Resources.grave1;
            this.panManaGrave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panManaGrave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panManaGrave.Location = new System.Drawing.Point(0, 132);
            this.panManaGrave.Name = "panManaGrave";
            this.panManaGrave.Size = new System.Drawing.Size(595, 564);
            this.panManaGrave.TabIndex = 0;
            // 
            // GoBackPnl
            // 
            this.GoBackPnl.BackColor = System.Drawing.Color.Transparent;
            this.GoBackPnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GoBackPnl.BackgroundImage")));
            this.GoBackPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GoBackPnl.Location = new System.Drawing.Point(30, 39);
            this.GoBackPnl.Name = "GoBackPnl";
            this.GoBackPnl.Size = new System.Drawing.Size(92, 81);
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
            this.SettingsBtn.Location = new System.Drawing.Point(41, 144);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(70, 70);
            this.SettingsBtn.TabIndex = 4;
            this.SettingsBtn.UseVisualStyleBackColor = false;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // GraveGrippers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::SalonUgi.Properties.Resources.rozovyi_rozovyi_fon_pink_lak_dlia_nogtei_instrumenty_kisti;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1142, 696);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.GoBackPnl);
            this.Controls.Add(this.panGrave);
            this.MinimumSize = new System.Drawing.Size(1160, 730);
            this.Name = "GraveGrippers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panGrave.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panGrave;
        private System.Windows.Forms.Panel panManaGrave;
        private System.Windows.Forms.Panel GoBackPnl;
        private System.Windows.Forms.Button SettingsBtn;
    }
}