using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalonUgi
{
    public partial class HandForm : Form
    {

        string imagine;
        public HandForm(string nailtype)
        {

            InitializeComponent();
            switch (nailtype)
            {
                case "GraveGrippers":
                    this.panManaNutty.BackgroundImage = Properties.Resources.grave1;
                    break;
                case "BrickTips":
                    this.panManaNutty.BackgroundImage = Properties.Resources.bric1;
                    break;
                case "CardiB":
                    this.panManaNutty.BackgroundImage = Properties.Resources.cardib2;
                    break;
                case "NuttyTips":
                    this.panManaNutty.BackgroundImage = Properties.Resources.nuti2;
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

        private void NuttyTip_Load(object sender, EventArgs e)
        {

        }

        private void GoBackPnl_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void panManaNutty_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
