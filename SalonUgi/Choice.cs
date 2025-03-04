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
    public partial class Choice : Form
    {
        public Choice()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ///useless
        }

        private void label7_Click(object sender, EventArgs e)
        {
            ///useless
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            //grave grippers
            GraveGrippers form = new GraveGrippers();
            form.FormClosed += (a, b) => { this.Show(); };
            form.Show();
            this.Hide();
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            //Brick
            BrickTips form = new BrickTips();
            form.FormClosed += (a, b) => { this.Show(); };
            form.Show();
            this.Hide();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //Cardi
            CardiB form = new CardiB();
            form.FormClosed += (a, b) => { this.Show(); };
            form.Show();
            this.Hide();
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            //Nutty
            NuttyTip form = new NuttyTip();
            form.FormClosed += (a, b) => { this.Show(); };
            form.Show();
            this.Hide();
        }

        private void Choice_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
