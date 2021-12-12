using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.DirectX.AudioVideoPlayback;

namespace View
{
    public partial class AdVideoPlayerView : Form
    {
        private Video video;
        private string[] videoPaths;
        private string slnPath;
        private int selectedIndex = 0;
        private Size formSize;
        private Size pnlSize;
        private ListBox lstVideos = new ListBox();
        public AdVideoPlayerView(string slnPath)
        {
            this.slnPath = slnPath;
            InitializeComponent();
        }

        private void adVideoPlayer_Load(object sender, EventArgs e)
        {
            adWindowsMediaPlayer.uiMode = "none";
            adWindowsMediaPlayer.URL= slnPath + "\\Resources\\Mountain.mp4";
            adWindowsMediaPlayer.Ctlcontrols.play();
        }

        private void adWindowsMediaPlayer_Enter(object sender, EventArgs e)
        {

        }

        private void adVideoPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            adWindowsMediaPlayer.close();
        }
    }
}
