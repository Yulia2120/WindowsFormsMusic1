using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System.Windows.Forms;

namespace WindowsFormsMusic1
{
    public partial class Form1 : Form
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        private string inputFilePath;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (outputDevice == null)
            {
                outputDevice = new WaveOutEvent();
                outputDevice.PlaybackStopped += OnPlaybackStopped;
            }
            if (audioFile == null)
            {
                audioFile = new AudioFileReader(@"example.mp3");
                outputDevice.Init(audioFile);
            }
            outputDevice.Play();
        }
        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            outputDevice.Dispose();
            outputDevice = null;
            audioFile.Dispose();
            audioFile = null;
            GC.Collect();
        }
       
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            //openFD.Filter = *.mp3 | *.mp3;
            if (openFD.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (saveFD.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            outputDevice?.Stop();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
          
        }


    }
}
