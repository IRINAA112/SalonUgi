namespace SalonUgi
{
    partial class HandForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HandForm));
            this.panelProsop = new System.Windows.Forms.Panel();
            this.panelMana = new System.Windows.Forms.Panel();
            this.GoBackPnl = new System.Windows.Forms.Panel();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.panelProsop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProsop
            // 
            this.panelProsop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProsop.BackColor = System.Drawing.Color.Transparent;
            this.panelProsop.BackgroundImage = global::SalonUgi.Properties.Resources.prosop_removebg_preview;
            this.panelProsop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelProsop.Controls.Add(this.panelMana);
            this.panelProsop.Location = new System.Drawing.Point(540, 0);
            this.panelProsop.Name = "panelProsop";
            this.panelProsop.Size = new System.Drawing.Size(602, 683);
            this.panelProsop.TabIndex = 0;
            this.panelProsop.UseWaitCursor = true;
            // 
            // panelMana
            // 
            this.panelMana.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMana.BackgroundImage = global::SalonUgi.Properties.Resources.nuti2;
            this.panelMana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelMana.Location = new System.Drawing.Point(0, 133);
            this.panelMana.Name = "panelMana";
            this.panelMana.Size = new System.Drawing.Size(602, 623);
            this.panelMana.TabIndex = 0;
            this.panelMana.UseWaitCursor = true;
            this.panelMana.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelMana_MouseClick);
            // 
            // GoBackPnl
            // 
            this.GoBackPnl.BackColor = System.Drawing.Color.Transparent;
            this.GoBackPnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GoBackPnl.BackgroundImage")));
            this.GoBackPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GoBackPnl.Location = new System.Drawing.Point(31, 29);
            this.GoBackPnl.Name = "GoBackPnl";
            this.GoBackPnl.Size = new System.Drawing.Size(90, 77);
            this.GoBackPnl.TabIndex = 3;
            this.GoBackPnl.UseWaitCursor = true;
            this.GoBackPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.GoBackPnl_Paint);
            this.GoBackPnl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GoBackPnl_MouseClick);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.BackColor = System.Drawing.Color.Pink;
            this.SettingsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingsBtn.BackgroundImage")));
            this.SettingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SettingsBtn.Location = new System.Drawing.Point(41, 132);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(70, 70);
            this.SettingsBtn.TabIndex = 4;
            this.SettingsBtn.UseVisualStyleBackColor = false;
            this.SettingsBtn.UseWaitCursor = true;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // HandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::SalonUgi.Properties.Resources.rozovyi_rozovyi_fon_pink_lak_dlia_nogtei_instrumenty_kisti;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1142, 683);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.GoBackPnl);
            this.Controls.Add(this.panelProsop);
            this.MinimumSize = new System.Drawing.Size(1160, 730);
            this.Name = "HandForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hand Form";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.HandForm_Load);
            this.panelProsop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProsop;
        private System.Windows.Forms.Panel panelMana;
        private System.Windows.Forms.Panel GoBackPnl;
        private System.Windows.Forms.Button SettingsBtn;
    }
}