using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;



namespace SalonUgi
{
    
    
    public partial class HandForm : Form
    {
        Bitmap ImagineMana;
        public List<NailData> vectorUnghii = new List<NailData>();
        int width;
        int height;
        List<Region> regions= new List<Region>();
        public HandForm(Mana mana)
        {
            ImagineMana = new Bitmap(mana.imagPNG);
            
            InitializeComponent();
            XmlDocument doc = new XmlDocument();
            doc.Load(mana.imagSVG);
            XmlNodeList nodes = doc.SelectNodes("//*[@id='nails']");
            width = ImagineMana.Width;
            height = ImagineMana.Height;
            XmlElement nailsnode = (XmlElement)nodes[0];
            foreach (XmlNode nailnode in nailsnode.SelectNodes(".//*"))
            {
                string stringpath = nailnode.Attributes["d"].Value;   
                var path = SVGUtils.ConvertSvgPathToRegion(stringpath, 0, 0);
          
                regions.Add(path);
            }
            for (int i = 0; i < regions.Count; i++)
            {
                vectorUnghii.Add(new NailData());
            }
            string[] stickers = Directory.GetFiles("stickers");
            for (int i = 0; i < stickers.Length; i++)
            {
                var newSticker = new Sticker();
                newSticker.nume = Path.GetFileName(stickers[i]).Split('.')[0];
                newSticker.imagine = new Bitmap(stickers[i]);
                stickerList.Add(newSticker);
            }

        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            Settings form = new Settings();
            form.FormClosed += (a, b) => { this.Show(); };
            form.Show();
            this.Hide();
        }


        

        private void GoBackPnl_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }


        

        private void panelMana_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void HandForm_Load(object sender, EventArgs e)
        {

        }

        List<Sticker> stickerList = new List<Sticker>();
        Bitmap findimage(string name)
        {
            for (int i = 0; i < stickerList.Count; i++)
            {
                if (stickerList[i].nume == name)
                    return stickerList[i].imagine;
            }
            return stickerList[0].imagine;
        }



        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawImage(ImagineMana, 0, 0, width, height);
            for(int k = 0; k<regions.Count; k++)
            {
                NailData naildata = vectorUnghii[k];


                g.Clip = regions[k];
                g.FillRectangle(Brushes.Pink, 0, 0, pictureBox1.Width, pictureBox1.Height);
                for (int i = 0; i < naildata.linii.Count; i++)
                {
                    for (int j = 1; j < naildata.linii[i].points.Count; j++)
                    {
                        g.DrawLine(naildata.linii[i].culoare, naildata.linii[i].points[j - 1], naildata.linii[i].points[j]);
                    }
                    
                }
                for (int i = 0; i < naildata.placedStickers.Count; i++)
                {
                    g.DrawImage(findimage(naildata.placedStickers[i].nume), naildata.placedStickers[i].x, naildata.placedStickers[i].y, 10, 10);
                }
            }

            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            PointF clickPoint = new PointF(e.X, e.Y);
            for (int i = 0; i < regions.Count; i++)
            {
                Region path = regions[i];
                if (path.IsVisible(clickPoint))
                {
                    NailDraw form = new NailDraw(regions[i], vectorUnghii[i], ImagineMana, width, height);
                    form.FormClosed += (a, b) => { this.Show(); pictureBox1.Invalidate(); };
                    form.Show();
                    this.Hide();
                    break;
                }
            }
        }
    }
}
