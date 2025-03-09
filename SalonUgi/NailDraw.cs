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
        string tipDeget, tipUnghie;
        public NailDraw( string Deget, string Unghie)
        {
            InitializeComponent();
            tipDeget = Deget;   
            tipUnghie = Unghie;
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
            Bitmap finger = new Bitmap(tipDeget);
            g.DrawImage(finger, 0, 0);
            g.Clip=ConvertSvgPathToRegion(tipUnghie);
            
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
            float offsetX = 385;
            float offsetY = 144;

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
    }
}
