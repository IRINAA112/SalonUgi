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
    public partial class BrickTips : Form
    {
        public BrickTips()
        {
            InitializeComponent();
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
    }
}
