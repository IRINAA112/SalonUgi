namespace SalonUgi
{
    partial class NuttyTip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuttyTip));
            this.panNutty = new System.Windows.Forms.Panel();
            this.panManaNutty = new System.Windows.Forms.Panel();
            this.GoBackPnl = new System.Windows.Forms.Panel();
            this.panNutty.SuspendLayout();
            this.SuspendLayout();
            // 
            // panNutty
            // 
            this.panNutty.BackColor = System.Drawing.Color.Transparent;
            this.panNutty.BackgroundImage = global::SalonUgi.Properties.Resources.prosop_removebg_preview;
            this.panNutty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panNutty.Controls.Add(this.panManaNutty);
            this.panNutty.Location = new System.Drawing.Point(488, 12);
            this.panNutty.Name = "panNutty";
            this.panNutty.Size = new System.Drawing.Size(594, 652);
            this.panNutty.TabIndex = 0;
            this.panNutty.UseWaitCursor = true;
            // 
            // panManaNutty
            // 
            this.panManaNutty.BackgroundImage = global::SalonUgi.Properties.Resources.nuti;
            this.panManaNutty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panManaNutty.Location = new System.Drawing.Point(-202, 102);
            this.panManaNutty.Name = "panManaNutty";
            this.panManaNutty.Size = new System.Drawing.Size(778, 550);
            this.panManaNutty.TabIndex = 0;
            this.panManaNutty.UseWaitCursor = true;
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
            // 
            // NuttyTip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SalonUgi.Properties.Resources.rozovyi_rozovyi_fon_pink_lak_dlia_nogtei_instrumenty_kisti;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1094, 676);
            this.Controls.Add(this.GoBackPnl);
            this.Controls.Add(this.panNutty);
            this.Name = "NuttyTip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "NuttyTip";
            this.UseWaitCursor = true;
            this.panNutty.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panNutty;
        private System.Windows.Forms.Panel panManaNutty;
        private System.Windows.Forms.Panel GoBackPnl;
    }
}