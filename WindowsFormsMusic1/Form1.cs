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
        
        OpenFileDialog dialog = new OpenFileDialog();
        List<string> str = new List<string>();

        public Form1()
        {
            InitializeComponent();
            trackBar1.Value = 50;
            labelVol100.Text = "50%";
        }
        //выбрать песню из треклиста
        private void TrackList_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = TrackList.Text;
            buttonAdd.Enabled = true;
            
        }
        private void FavoritList_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = FavoritList.Text;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
           
            Player.Ctlcontrols.stop(); 
        }


        private void buttonPlay_Click(object sender, EventArgs e)
        {
            Player.URL = @TrackList.Text;
            Player.URL = @FavoritList.Text;
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
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            buttonAdd.Enabled = false;
            FavoritList.Items.Add(textBox1.Text);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            StreamWriter Save = new StreamWriter (@"D:\Desktop\Git\WindowsFormsMusic1\WindowsFormsMusic1\Save_favorite\favorite.txt");
            foreach(var item in FavoritList.Items)
            {
                Save.WriteLine(item.ToString());
                this.Refresh();
            }
            MessageBox.Show("Saved");
            Save.Close();
            FavoritList.Items.Clear();

        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(FavoritList.SelectedItems.Count > 0)
            {
                FavoritList.Items.Remove(FavoritList.SelectedItems[0]);
            }
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(@"D:\Desktop\Git\WindowsFormsMusic1\WindowsFormsMusic1\Save_favorite\favorite.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    FavoritList.Items.Add(line);
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                pBar.Maximum = (int)Player.Ctlcontrols.currentItem.duration;
                pBar.Value = (int)Player.Ctlcontrols.currentPosition;
            }
           
                labelStartTrack.Text = Player.Ctlcontrols.currentPositionString;
               
           
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Player.settings.volume = trackBar1.Value;
            labelVol100.Text = trackBar1.Value.ToString() + " %";
        }

        private void pBar_MouseDown(object sender, MouseEventArgs e)
        {
            Player.Ctlcontrols.currentPosition = Player.currentMedia.duration * e.X / pBar.Width;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            dialog.Multiselect = true;
            dialog.Filter = "MP3|*.mp3";
            if (dialog.ShowDialog() == DialogResult.Cancel) return;
            foreach(string s in dialog.SafeFileNames)
            {
                TrackList.Items.Add(Path.GetFileName(s));
                str.Add(s);
            }
            
        }




    }
}
