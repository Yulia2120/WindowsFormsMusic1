using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsMusic1
{
    public partial class Form1 : Form
    {
        public class MediaFile
        {
            public string FileName { get; set; }
            public string Path { get; set; }
        }
        //string[] paths, files;

        public Form1()
        {
            InitializeComponent();
            trackBar1.Value = 50;
            labelVol100.Text = "50%";
        }
        //выбрать песню из треклиста
        private void TrackList_SelectedIndexChanged(object sender, EventArgs e)
        {
            MediaFile file = TrackList.SelectedItem as MediaFile;
            if (file != null)
            {
                Player.URL = file.Path;
                Player.Ctlcontrols.play();
            }
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
            using (OpenFileDialog openFD = new OpenFileDialog() { Multiselect = true, ValidateNames = true, Filter = "MP3|*.mp3" }) 
            {
                var index = 0;
                openFD.Multiselect = true;
                openFD.Filter = "MP3|*.mp3";
                if (openFD.ShowDialog() == DialogResult.OK)
                {
                    List<MediaFile> files = new List<MediaFile>();
                    foreach (string fileName in openFD.FileNames)
                    {
                      
                        FileInfo fi = new FileInfo(fileName);
                        index++;
                        files.Add(new MediaFile() { FileName = Path.GetFileName(fi.FullName), Path = fi.FullName});
                       
                    }
                    
                    TrackList.DataSource = files;
                    TrackList.ValueMember = "Path";
                    TrackList.DisplayMember = "FileName";
                

                }
            }
            
        }




    }
}
