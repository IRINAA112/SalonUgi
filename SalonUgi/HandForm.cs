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

        string tipDeget, tipUnghie;
        public HandForm(string nailtype)
        {

            InitializeComponent();
            switch (nailtype)
            {
                case "GraveGrippers":
                    this.panelMana.BackgroundImage = Properties.Resources.grave1;
                    tipUnghie = "M 77.5634 128.597 C 78.4068 183.308 65.1355 201.245 44.2643 201.567 C 23.3932 201.888 2.82576 184.474 1.98237 129.762 L 0.00543739 1.16502 L 75.5646 0.0036416 L 77.5634 128.597 Z";
                    tipDeget = "Frame12.png";
                    break;
                case "BrickTips":
                    this.panelMana.BackgroundImage = Properties.Resources.bric1;
                    //tipUnghie = "M 77.5634 128.597 C 78.4068 183.308 65.1355 201.245 44.2643 201.567 C 23.3932 201.888 2.82576 184.474 1.98237 129.762 L 0.00543739 1.16502 L 75.5646 0.0036416 L 77.5634 128.597 Z";
                    //tipDeget = "Frame12.png";
                    break;
                case "CardiB":
                    this.panelMana.BackgroundImage = Properties.Resources.cardib2;
                    //tipUnghie = "M 77.5634 128.597 C 78.4068 183.308 65.1355 201.245 44.2643 201.567 C 23.3932 201.888 2.82576 184.474 1.98237 129.762 L 0.00543739 1.16502 L 75.5646 0.0036416 L 77.5634 128.597 Z";
                    //tipDeget = "Frame12.png";
                    break;
                case "NuttyTips":
                    this.panelMana.BackgroundImage = Properties.Resources.nuti2;
                    tipUnghie = "M 75.7038 137.28 C 74.8561 186.392 61.0367 202.071 40.1654 201.711 C 19.2942 201.351 - 0.72542 185.087 0.122322 135.974 C 0.970063 86.8621 19.2493 0.257764 40.1205 0.618247 C 60.9918 0.97873 76.5516 88.1676 75.7038 137.28 Z";
                    tipDeget = "degettest3.png";
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

        private void GoBackPnl_Paint(object sender, PaintEventArgs e)
        {
           
        }

        

        private void GoBackPnl_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void panManaNutty_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panManaNutty_Click(object sender, EventArgs e)
        {
            //NailDraw form = new NailDraw("degettest3.png", "M 75.7038 137.28 C 74.8561 186.392 61.0367 202.071 40.1654 201.711 C 19.2942 201.351 -0.72542 185.087 0.122322 135.974 C 0.970063 86.8621 19.2493 0.257764 40.1205 0.618247 C 60.9918 0.97873 76.5516 88.1676 75.7038 137.28 Z");
            NailDraw form = new NailDraw(tipDeget, tipUnghie);
            form.FormClosed += (a, b) => { this.Show(); };
            form.Show();
            this.Hide();
        }

        private void HandForm_Load(object sender, EventArgs e)
        {

        }
    }
}
