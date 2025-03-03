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
            this.panGrave.SuspendLayout();
            this.SuspendLayout();
            // 
            // panGrave
            // 
            this.panGrave.BackColor = System.Drawing.Color.Transparent;
            this.panGrave.BackgroundImage = global::SalonUgi.Properties.Resources.prosop_removebg_preview;
            this.panGrave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panGrave.Controls.Add(this.panManaGrave);
            this.panGrave.Location = new System.Drawing.Point(494, 12);
            this.panGrave.Name = "panGrave";
            this.panGrave.Size = new System.Drawing.Size(595, 672);
            this.panGrave.TabIndex = 0;
            // 
            // panManaGrave
            // 
            this.panManaGrave.BackgroundImage = global::SalonUgi.Properties.Resources.grave;
            this.panManaGrave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panManaGrave.Location = new System.Drawing.Point(-186, 108);
            this.panManaGrave.Name = "panManaGrave";
            this.panManaGrave.Size = new System.Drawing.Size(758, 564);
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
            // 
            // GraveGrippers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SalonUgi.Properties.Resources.rozovyi_rozovyi_fon_pink_lak_dlia_nogtei_instrumenty_kisti;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1101, 696);
            this.Controls.Add(this.GoBackPnl);
            this.Controls.Add(this.panGrave);
            this.Name = "GraveGrippers";
            this.Text = "Form1";
            this.panGrave.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panGrave;
        private System.Windows.Forms.Panel panManaGrave;
        private System.Windows.Forms.Panel GoBackPnl;
    }
}