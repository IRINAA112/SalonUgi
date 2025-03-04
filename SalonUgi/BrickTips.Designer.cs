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
            this.panBrick.SuspendLayout();
            this.SuspendLayout();
            // 
            // panBrick
            // 
            this.panBrick.BackColor = System.Drawing.Color.Transparent;
            this.panBrick.BackgroundImage = global::SalonUgi.Properties.Resources.prosop_removebg_preview;
            this.panBrick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panBrick.Controls.Add(this.manaBrick);
            this.panBrick.Location = new System.Drawing.Point(516, 7);
            this.panBrick.Name = "panBrick";
            this.panBrick.Size = new System.Drawing.Size(559, 641);
            this.panBrick.TabIndex = 0;
            // 
            // manaBrick
            // 
            this.manaBrick.BackgroundImage = global::SalonUgi.Properties.Resources.bric;
            this.manaBrick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.manaBrick.Location = new System.Drawing.Point(-201, 102);
            this.manaBrick.Name = "manaBrick";
            this.manaBrick.Size = new System.Drawing.Size(701, 536);
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
            // 
            // BrickTips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SalonUgi.Properties.Resources.rozovyi_rozovyi_fon_pink_lak_dlia_nogtei_instrumenty_kisti1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1142, 683);
            this.Controls.Add(this.GoBackPnl);
            this.Controls.Add(this.panBrick);
            this.MinimumSize = new System.Drawing.Size(1160, 730);
            this.Name = "BrickTips";
            this.Text = "BrickTips";
            this.panBrick.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panBrick;
        private System.Windows.Forms.Panel manaBrick;
        private System.Windows.Forms.Panel GoBackPnl;
    }
}