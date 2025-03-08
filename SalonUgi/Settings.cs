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

        SoundPlayer player=new SoundPlayer();
        string SelectedSong = "Emo";
        string[] Emo = {"uaaaa.wav", "rammi.wav"};
        string[] Manele = { "buci.wav" };
        string[] NPC = { "ew.wav"};
        string[] Patriotic = { "imn.wav" };

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
                    axWindowsMediaPlayer1.URL= Emo[random.Next(0, Emo.Length )];
                    break;
                case "Manele":
                    axWindowsMediaPlayer1.URL = Manele[random.Next(0, Manele.Length)];
                    break;
                case "Patriotic":
                    axWindowsMediaPlayer1.URL = Patriotic[random.Next(0, Patriotic.Length)];
                    break;
                case "NPC":
                    axWindowsMediaPlayer1.URL = NPC[random.Next(0, NPC.Length)];
                    break;
                default:
                    axWindowsMediaPlayer1.URL = "buci.wav";
                    break;
            }
            player.PlayLooping();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (SounCheckBox.Checked)
            {
                this.PlayNewSong();
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
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
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
        }
    }
}
