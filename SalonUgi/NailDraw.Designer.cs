namespace SalonUgi
{
    partial class NailDraw
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.sticker_2 = new System.Windows.Forms.Button();
            this.stiker_1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.green_btn = new System.Windows.Forms.Button();
            this.yellow_btn = new System.Windows.Forms.Button();
            this.blue_btn = new System.Windows.Forms.Button();
            this.red_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sticker_2);
            this.panel1.Controls.Add(this.stiker_1);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.green_btn);
            this.panel1.Controls.Add(this.yellow_btn);
            this.panel1.Controls.Add(this.blue_btn);
            this.panel1.Controls.Add(this.red_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 610);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // sticker_2
            // 
            this.sticker_2.Location = new System.Drawing.Point(108, 271);
            this.sticker_2.Name = "sticker_2";
            this.sticker_2.Size = new System.Drawing.Size(75, 23);
            this.sticker_2.TabIndex = 7;
            this.sticker_2.Text = "2";
            this.sticker_2.UseVisualStyleBackColor = true;
            this.sticker_2.Click += new System.EventHandler(this.sticker_2_Click);
            // 
            // stiker_1
            // 
            this.stiker_1.Location = new System.Drawing.Point(13, 271);
            this.stiker_1.Name = "stiker_1";
            this.stiker_1.Size = new System.Drawing.Size(75, 23);
            this.stiker_1.TabIndex = 6;
            this.stiker_1.Text = "1";
            this.stiker_1.UseVisualStyleBackColor = true;
            this.stiker_1.Click += new System.EventHandler(this.stiker_1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(12, 347);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(185, 56);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Value = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // green_btn
            // 
            this.green_btn.BackColor = System.Drawing.Color.Lime;
            this.green_btn.Location = new System.Drawing.Point(45, 201);
            this.green_btn.Name = "green_btn";
            this.green_btn.Size = new System.Drawing.Size(107, 55);
            this.green_btn.TabIndex = 4;
            this.green_btn.UseVisualStyleBackColor = false;
            this.green_btn.Click += new System.EventHandler(this.green_btn_Click);
            // 
            // yellow_btn
            // 
            this.yellow_btn.BackColor = System.Drawing.Color.Yellow;
            this.yellow_btn.Location = new System.Drawing.Point(45, 140);
            this.yellow_btn.Name = "yellow_btn";
            this.yellow_btn.Size = new System.Drawing.Size(107, 55);
            this.yellow_btn.TabIndex = 2;
            this.yellow_btn.UseVisualStyleBackColor = false;
            this.yellow_btn.Click += new System.EventHandler(this.yellow_btn_Click);
            // 
            // blue_btn
            // 
            this.blue_btn.BackColor = System.Drawing.Color.Blue;
            this.blue_btn.Location = new System.Drawing.Point(45, 79);
            this.blue_btn.Name = "blue_btn";
            this.blue_btn.Size = new System.Drawing.Size(107, 55);
            this.blue_btn.TabIndex = 1;
            this.blue_btn.UseVisualStyleBackColor = false;
            this.blue_btn.Click += new System.EventHandler(this.blue_btn_Click);
            // 
            // red_btn
            // 
            this.red_btn.BackColor = System.Drawing.Color.Red;
            this.red_btn.Location = new System.Drawing.Point(45, 18);
            this.red_btn.Name = "red_btn";
            this.red_btn.Size = new System.Drawing.Size(107, 55);
            this.red_btn.TabIndex = 0;
            this.red_btn.UseVisualStyleBackColor = false;
            this.red_btn.Click += new System.EventHandler(this.red_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(206, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(945, 610);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(6, 610);
            this.panel2.TabIndex = 2;
            // 
            // NailDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 610);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "NailDraw";
            this.Text = "NailDraw";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button yellow_btn;
        private System.Windows.Forms.Button blue_btn;
        private System.Windows.Forms.Button red_btn;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button green_btn;
        private System.Windows.Forms.Button sticker_2;
        private System.Windows.Forms.Button stiker_1;
        private System.Windows.Forms.Panel panel2;
    }
}