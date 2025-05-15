using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SalonUgi
{
    
    public partial class NailDraw : Form
    {
        Region region;
        List<Linie> Linii;
        Bitmap imagine;
        float width;
        float height;
        float scale, offsetX, offsetY;
        string selectedSticker = "";
        List<PlacedSticker> placedStickers ;
        List<Sticker> stickerList = new List<Sticker>();

       
        public NailDraw( Region region, NailData naildata, Bitmap imagine, float width, float height)
        {
            InitializeComponent();
            this.region = region;
            this.Linii = naildata.linii;
            this.placedStickers = naildata.placedStickers;
            this.imagine = imagine;
            this.width = width;
            this.height = height;
            string[] stickers = Directory.GetFiles("stickers");
            for (int i = 0; i < stickers.Length; i++)
            {
                var newSticker = new Sticker();
                newSticker.nume = Path.GetFileName(stickers[i]).Split('.')[0];
                newSticker.imagine = new Bitmap(stickers[i]);
                stickerList.Add(newSticker);
            }
            
        }

        Boolean desenare=false; 

        
        Pen selectedColor = Pens.Black;
        int desiredWidth= 1 ;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.placedStickers.Add(new PlacedSticker()
                {
                    nume = selectedSticker,
                    x = Convert.ToInt32(e.Location.X / scale - offsetX - 5),
                    y = Convert.ToInt32(e.Location.Y / scale - offsetY - 5)
                });
                pictureBox1.Invalidate();
                return;
            }
            desenare = true;
            this.Linii.Add(new Linie(new Pen(selectedColor.Color, this.desiredWidth)));
            var linie = this.Linii[Linii.Count - 1];
            linie.points.Add(new Point(Convert.ToInt32(e.Location.X / scale - offsetX), Convert.ToInt32(e.Location.Y/scale - offsetY)));
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
                linie.points.Add(new Point(Convert.ToInt32(e.Location.X/scale - offsetX), Convert.ToInt32(e.Location.Y/scale - offsetY)));

                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            this.scale = 8f;
            g.ScaleTransform(scale, scale);
            RectangleF bounds = region.GetBounds(g);
            float nailW = bounds.Width;
            float nailH = bounds.Height;
            float screenW = pictureBox1.Width / scale;
            float screenH = pictureBox1.Height / scale;
            float nailX = screenW/2 - nailW/2;
            float nailY = screenH / 2 - nailH / 2;
            float oldnailX = bounds.X;
            float oldnailY = bounds.Y;
            this.offsetX = nailX - oldnailX;
            this.offsetY = nailY - oldnailY;
            g.TranslateTransform(offsetX, offsetY);
            g.DrawImage(imagine, 0, 0, width, height);
            g.Clip = region;
            g.FillRectangle(Brushes.LightCoral, 0, 0, pictureBox1.Width, pictureBox1.Height);
            for (int i = 0; i < Linii.Count; i++)
            {
                for (int j = 1; j < Linii[i].points.Count; j++)
                {
                    g.DrawLine(Linii[i].culoare, Linii[i].points[j - 1], Linii[i].points[j]);
                }
            }
            for (int i = 0; i < placedStickers.Count; i++)
            {
                g.DrawImage(findimage(placedStickers[i].nume), placedStickers[i].x, placedStickers[i].y, 10, 10);
            }

        }

        Bitmap findimage(string name)
        {
            for(int i=0; i<stickerList.Count; i++)
            {
                if (stickerList[i].nume==name)
                    return stickerList[i].imagine;
            }
            return stickerList[0].imagine;
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
            this.selectedSticker = (sender as Button).Name;
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.selectedColor = Pens.LightPink;
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
