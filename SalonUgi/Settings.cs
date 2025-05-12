using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalonUgi
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void SoundVolumeLbl_Click(object sender, EventArgs e)
        {

        }

        private void SetingsGoBackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        string SelectedSong = "Emo";
        string[] Emo = {"music/uaaaa.wav", "music/rammi.wav" };
        string[] Manele = { "music/buci.wav" };
        string[] NPC = { "music/ew.wav" };
        string[] Patriotic = { "music/imn.wav" };

        private void SoundVolTrackBar_Scroll(object sender, EventArgs e)
        {
            
        }

        private void SongDpropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedSong=this.SongDpropDown.Text;
            if (SounCheckBox.Checked)
            {
                this.PlayNewSong();
            }

        }
         private Random random=new Random();
        private void PlayNewSong()
        {
            switch (SelectedSong)
            {
                case "Emo":
                    Muzica.wmp.URL= Emo[random.Next(0, Emo.Length )];
                    break;
                case "Manele":
                    Muzica.wmp.URL = Manele[random.Next(0, Manele.Length)];
                    break;
                case "Patriotic":
                    Muzica.wmp.URL = Patriotic[random.Next(0, Patriotic.Length)];
                    break;
                case "NPC":
                    Muzica.wmp.URL = NPC[random.Next(0, NPC.Length)];
                    break;
                default:
                    Muzica.wmp.URL = "buci.wav";
                    break;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (SounCheckBox.Checked)
            {
                this.PlayNewSong();
            }
            else
            {
                Muzica.wmp.Ctlcontrols.stop();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SettingsLbl_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            Muzica.wmp.settings.volume = trackBar1.Value;
        }
    }
}
