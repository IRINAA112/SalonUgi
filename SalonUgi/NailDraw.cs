using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SalonUgi
{
    
    public partial class NailDraw : Form
    {
        ConfigurareUnghie configU;
        List<Linie> Linii;
        public NailDraw( ConfigurareUnghie x, List<Linie>y)
        {
            InitializeComponent();
            configU = x;
            Linii = y;
        }

        Boolean desenare=new Boolean(); 

        
        Pen selectedColor = Pens.Black;
        int desiredWidth= 1 ;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            desenare = true;
            this.Linii.Add(new Linie(new Pen(selectedColor.Color, this.desiredWidth)));
            var linie = this.Linii[Linii.Count - 1];
            linie.points.Add(new Point(e.Location.X, e.Location.Y));
            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            desenare = false;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (desenare)
            {
                var linie=this.Linii[Linii.Count-1];
                linie.points.Add(new Point(e.Location.X, e.Location.Y));

                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap finger = new Bitmap(configU.tipDeget);
           
            g.DrawImage(finger, configU.imageX, configU.imageY);
            g.Clip=SVGUtils.ConvertSvgPathToRegion(configU.tipUnghie, configU.offsetX, configU.offsetY);
            g.FillRectangle(Brushes.LightCoral, 0, 0, pictureBox1.Width, pictureBox1.Height);
            for (int i = 0; i < Linii.Count; i++)
            {
                for (int j = 1; j < Linii[i].points.Count; j++)
                {
                    //g.FillEllipse(new SolidBrush(Linii[i].culoare.Color), Linii[i].points[j].X - Linii[i].culoare.Width, Linii[i].points[j].Y - Linii[i].culoare.Width, Convert.ToInt32(1.5*Linii[i].culoare.Width), Convert.ToInt32(1.5 *Linii[i].culoare.Width));
                    g.DrawLine(Linii[i].culoare, Linii[i].points[j - 1], Linii[i].points[j]);
                }
            }

        }

        private void red_btn_Click(object sender, EventArgs e)
        {
            this.selectedColor = Pens.Red;
        }
        private void blue_btn_Click(object sender, EventArgs e)
        {
            this.selectedColor = Pens.Aqua;
        }

        private void yellow_btn_Click(object sender, EventArgs e)
        {
            this.selectedColor = Pens.Yellow;
        }
        private void green_btn_Click(object sender, EventArgs e)
        {
            this.selectedColor = Pens.Green;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.desiredWidth= trackBar1.Value;
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stiker_1_Click(object sender, EventArgs e)
        {

        }

        private void sticker_2_Click(object sender, EventArgs e)
        {

        }

        private void GoBackPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GoBackPnl_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            Settings form = new Settings();
            form.FormClosed += (a, b) => { this.Show(); };
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.selectedColor = Pens.DeepPink;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.selectedColor = Pens.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.selectedColor = Pens.Black;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.selectedColor = Pens.BlueViolet;
        }
    }
}
