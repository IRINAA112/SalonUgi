﻿using System;
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
            HandForm form = new HandForm("GraveGrippers");
            form.FormClosed += (a, b) => { this.Show(); };
            form.Show();
            this.Hide();
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            //Brick
            HandForm form = new HandForm("BrickTips");
            form.FormClosed += (a, b) => { this.Show(); };
            form.Show();
            this.Hide();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //Cardi
            HandForm form = new HandForm("CardiB");
            form.FormClosed += (a, b) => { this.Show(); };
            form.Show();
            this.Hide();
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            //Nutty
            HandForm form = new HandForm("NuttyTips");
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

        private void GoBackPnl_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
