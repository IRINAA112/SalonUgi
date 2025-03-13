using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SalonUgi
{
    
    
    public partial class HandForm : Form
    {
        public List<Linie>[] vectorUnghii = new List<Linie>[5];
        ConfigurareUnghie configUnghie = new ConfigurareUnghie();
        public HandForm(string nailtype)
        {
            
            for(int i = 0; i < 5; i++)
            {
                vectorUnghii[i] = new List<Linie>();
            }
            InitializeComponent();
            switch (nailtype)
            {
                case "GraveGrippers":
                    this.panelMana.BackgroundImage = Properties.Resources.grave1;
                    configUnghie.tipUnghie = "M 75.967 123.854 C 76.8029 178.203 63.5614 196.021 42.7398 196.341 C 21.9183 196.662 1.4015 179.363 0.565583 125.014 C 0.0072909 88.715 6.62893 33.6514 17.2919 0.98428 L 55.2266 0.400826 C 66.972 32.7233 75.4087 87.5552 75.967 123.854 Z";
                    configUnghie.tipDeget = "degettest3.png";
                    configUnghie.offsetX = 380;
                    configUnghie.offsetY = 148;
                    configUnghie.imageX = 0;
                    configUnghie.imageY = 0;
                    break;
                case "BrickTips":
                    this.panelMana.BackgroundImage = Properties.Resources.bric1;
                    configUnghie.tipUnghie = "M 77.5634 128.597 C 78.4068 183.308 65.1355 201.245 44.2643 201.567 C 23.3932 201.888 2.82576 184.474 1.98237 129.762 L 0.00543739 1.16502 L 75.5646 0.0036416 L 77.5634 128.597 Z";
                    configUnghie.tipDeget = "Frame 12 (1).png";
                    configUnghie.offsetX = 385;
                    configUnghie.offsetY = 144;
                    configUnghie.imageX = 368;
                    configUnghie.imageY = 138;///BUN
                    break;
                case "CardiB":
                    this.panelMana.BackgroundImage = Properties.Resources.cardib2;
                    configUnghie.tipUnghie = "M 76.0265 484.077 C 76.7682 535.056 63.535 551.771 42.7735 552.073 C 22.012 552.375 1.58414 536.15 0.842471 485.171 C 0.100801 434.192 10.3779 0.613896 31.1394 0.311847 C 51.9009 0.00979811 75.2848 433.098 76.0265 484.077 Z";
                    configUnghie.tipDeget = "Frame 12 (1).png";
                    configUnghie.offsetX = 385;
                    configUnghie.offsetY = 15;
                    configUnghie.imageX = 368;
                    configUnghie.imageY = 356;
                    break;
                case "NuttyTips":
                    this.panelMana.BackgroundImage = Properties.Resources.nuti2;
                    configUnghie.tipUnghie = "M 75.7038 137.28 C 74.8561 186.392 61.0367 202.071 40.1654 201.711 C 19.2942 201.351 -0.72542 185.087 0.122322 135.974 C 0.970063 86.8621 19.2493 0.257764 40.1205 0.618247 C 60.9918 0.97873 76.5516 88.1676 75.7038 137.28 Z";
                    configUnghie.tipDeget = "degettest3.png";
                    configUnghie.offsetX = 385;
                    configUnghie.offsetY = 144;
                    configUnghie.imageX = 0;
                    configUnghie.imageY = 0;///BUN
                    break;
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
            NailDraw form = new NailDraw(configUnghie, vectorUnghii[0]);
            form.FormClosed += (a, b) => { this.Show(); };
            form.Show();
            this.Hide();
        }

        private void HandForm_Load(object sender, EventArgs e)
        {

        }
    }
}
