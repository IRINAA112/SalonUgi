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

struct Linie
{
    public Pen culoare;
    public List<Point> points;
    public Linie(Pen culoare)
    {
        this.points = new List<Point>();
        this.culoare = culoare; 
    }
}

namespace SalonUgi
{
    public partial class NailDraw : Form
    {
        public NailDraw()
        {
            InitializeComponent();
        }
        Boolean desenare=new Boolean(); 

        List<Linie> Linii=new List<Linie>();
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
            Bitmap finger = new Bitmap("degettest.png");
            g.DrawImage(finger, 0, 0);
            g.Clip=ConvertSvgPathToRegion("M 53.4807 103.028 C 52.8451 139.853 43.1649 151.621 28.5658 151.369 C 13.9668 151.117 -0.0226613 138.94 0.612988 102.115 C 1.24864 65.2896 14.1101 0.337725 28.7091 0.589875 C 43.3081 0.842025 54.1164 66.2027 53.4807 103.028 Z ");
            ///Region clipRegion = new Region(new Rectangle(0, 0, 300,300));

            // Set clipping region of graphics to region.
            ///g.SetClip(clipRegion, CombineMode.Replace);

            // Fill rectangle to demonstrate clip region.
            g.FillRectangle(new SolidBrush(Color.Black), 0, 0, 500, 300);
            for (int i = 0; i < Linii.Count; i++)
            {
                for (int j = 1; j < Linii[i].points.Count; j++)
                {
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
            this.selectedColor = Pens.Blue;
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


        private Region ConvertSvgPathToRegion(string svgPath)
        {
            GraphicsPath path = new GraphicsPath();
            float offsetX = 291;
            float offsetY = 191;

            float startX = 0, startY = 0; 
            float firstX = 0, firstY = 0; 
            bool hasFirstPoint = false;

            string[] commands = svgPath.Split(' ');

            for (int i = 0; i < commands.Length; i++)
            {
                string cmd = commands[i];

                if (cmd == "M")
                {
                    startX = float.Parse(commands[i + 1], CultureInfo.InvariantCulture)+offsetX;
                    startY = float.Parse(commands[i + 2], CultureInfo.InvariantCulture)+offsetY;
                    

                    if (!hasFirstPoint)
                    {
                        firstX = startX;
                        firstY = startY;
                        hasFirstPoint = true;
                    }

                    i += 2;
                }
                else if (cmd == "C")
                {
                    float cx1 = float.Parse(commands[i + 1], CultureInfo.InvariantCulture) + offsetX;
                    float cy1 = float.Parse(commands[i + 2], CultureInfo.InvariantCulture) + offsetY;
                    float cx2 = float.Parse(commands[i + 3], CultureInfo.InvariantCulture) + offsetX;
                    float cy2 = float.Parse(commands[i + 4], CultureInfo.InvariantCulture) + offsetY;
                    float x = float.Parse(commands[i + 5], CultureInfo.InvariantCulture) + offsetX;
                    float y = float.Parse(commands[i + 6], CultureInfo.InvariantCulture) + offsetY;

                    path.AddBezier(startX, startY, cx1, cy1, cx2, cy2, x, y);

                    startX = x;
                    startY = y;
                    i += 6;
                }
                else if (cmd == "Z" || cmd == "z") 
                {
                    path.CloseFigure(); 
                    startX = firstX;
                    startY = firstY;
                }
            }

            return new Region(path);
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
    }
}
