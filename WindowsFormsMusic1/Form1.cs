using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsMusic1
{
    public partial class Form1 : Form
    {
        string[] paths, files;

        public Form1()
        {
            InitializeComponent();
            trackBar1.Value = 50;
            labelVol100.Text = "50%";
        }
        //выбрать песню из треклиста
        private void TrackList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player.URL = paths[TrackList.SelectedIndex];
            Player.Ctlcontrols.play();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.play();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if(TrackList.SelectedIndex < TrackList.Items.Count - 1)
            {
                TrackList.SelectedIndex = TrackList.SelectedIndex + 1;
            }
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if(TrackList.SelectedIndex > 0)
            {
                TrackList.SelectedIndex = TrackList.SelectedIndex - 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                pBar.Maximum = (int)Player.Ctlcontrols.currentItem.duration;
                pBar.Value = (int)Player.Ctlcontrols.currentPosition;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Player.settings.volume = trackBar1.Value;
            labelVol100.Text = trackBar1.Value.ToString() + " %";
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFD.Multiselect = true;
            openFD.Filter = "MP3|*.mp3";
            if(openFD.ShowDialog() == DialogResult.OK)
            {
                files = openFD.FileNames;
                paths = openFD.FileNames;
                //files = Name.Replace();
                for (int i = 0; i < files.Length; i++)
                {
                   TrackList.Items.Add((i + 1).ToString() + " - " + files[i]);
                }
               
            }
        }




    }
}
