namespace SalonUgi
{
    partial class CardiB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardiB));
            this.panCardib = new System.Windows.Forms.Panel();
            this.manaCardi = new System.Windows.Forms.Panel();
            this.panMareCardi = new System.Windows.Forms.Panel();
            this.panIndexCardi = new System.Windows.Forms.Panel();
            this.panMijCardi = new System.Windows.Forms.Panel();
            this.panInelCardi = new System.Windows.Forms.Panel();
            this.panMicCardi = new System.Windows.Forms.Panel();
            this.GoBackPnl = new System.Windows.Forms.Panel();
            this.panCardib.SuspendLayout();
            this.manaCardi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panCardib
            // 
            this.panCardib.BackColor = System.Drawing.Color.Transparent;
            this.panCardib.BackgroundImage = global::SalonUgi.Properties.Resources.prosop_removebg_preview;
            this.panCardib.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panCardib.Controls.Add(this.manaCardi);
            this.panCardib.Location = new System.Drawing.Point(498, 12);
            this.panCardib.Name = "panCardib";
            this.panCardib.Size = new System.Drawing.Size(582, 660);
            this.panCardib.TabIndex = 0;
            // 
            // manaCardi
            // 
            this.manaCardi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.manaCardi.BackgroundImage = global::SalonUgi.Properties.Resources.cardib1;
            this.manaCardi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.manaCardi.Controls.Add(this.panMareCardi);
            this.manaCardi.Controls.Add(this.panIndexCardi);
            this.manaCardi.Controls.Add(this.panMijCardi);
            this.manaCardi.Controls.Add(this.panInelCardi);
            this.manaCardi.Controls.Add(this.panMicCardi);
            this.manaCardi.Location = new System.Drawing.Point(-58, 70);
            this.manaCardi.MaximumSize = new System.Drawing.Size(0, 700);
            this.manaCardi.MinimumSize = new System.Drawing.Size(515, 590);
            this.manaCardi.Name = "manaCardi";
            this.manaCardi.Size = new System.Drawing.Size(515, 590);
            this.manaCardi.TabIndex = 0;
            // 
            // panMareCardi
            // 
            this.panMareCardi.Location = new System.Drawing.Point(357, 213);
            this.panMareCardi.Name = "panMareCardi";
            this.panMareCardi.Size = new System.Drawing.Size(86, 110);
            this.panMareCardi.TabIndex = 4;
            // 
            // panIndexCardi
            // 
            this.panIndexCardi.Location = new System.Drawing.Point(309, 57);
            this.panIndexCardi.Name = "panIndexCardi";
            this.panIndexCardi.Size = new System.Drawing.Size(38, 148);
            this.panIndexCardi.TabIndex = 3;
            // 
            // panMijCardi
            // 
            this.panMijCardi.Location = new System.Drawing.Point(252, 38);
            this.panMijCardi.Name = "panMijCardi";
            this.panMijCardi.Size = new System.Drawing.Size(31, 139);
            this.panMijCardi.TabIndex = 2;
            // 
            // panInelCardi
            // 
            this.panInelCardi.Location = new System.Drawing.Point(208, 57);
            this.panInelCardi.Name = "panInelCardi";
            this.panInelCardi.Size = new System.Drawing.Size(38, 148);
            this.panInelCardi.TabIndex = 1;
            // 
            // panMicCardi
            // 
            this.panMicCardi.Location = new System.Drawing.Point(164, 116);
            this.panMicCardi.Name = "panMicCardi";
            this.panMicCardi.Size = new System.Drawing.Size(38, 136);
            this.panMicCardi.TabIndex = 0;
            // 
            // GoBackPnl
            // 
            this.GoBackPnl.BackColor = System.Drawing.Color.Transparent;
            this.GoBackPnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GoBackPnl.BackgroundImage")));
            this.GoBackPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GoBackPnl.Location = new System.Drawing.Point(26, 30);
            this.GoBackPnl.Name = "GoBackPnl";
            this.GoBackPnl.Size = new System.Drawing.Size(85, 78);
            this.GoBackPnl.TabIndex = 3;
            // 
            // CardiB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SalonUgi.Properties.Resources.rozovyi_rozovyi_fon_pink_lak_dlia_nogtei_instrumenty_kisti;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1142, 683);
            this.Controls.Add(this.GoBackPnl);
            this.Controls.Add(this.panCardib);
            this.MaximumSize = new System.Drawing.Size(1160, 730);
            this.MinimumSize = new System.Drawing.Size(1160, 730);
            this.Name = "CardiB";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CardiB_Load);
            this.panCardib.ResumeLayout(false);
            this.manaCardi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panCardib;
        private System.Windows.Forms.Panel manaCardi;
        private System.Windows.Forms.Panel panInelCardi;
        private System.Windows.Forms.Panel panMicCardi;
        private System.Windows.Forms.Panel panMareCardi;
        private System.Windows.Forms.Panel panIndexCardi;
        private System.Windows.Forms.Panel panMijCardi;
        private System.Windows.Forms.Panel GoBackPnl;
    }
}