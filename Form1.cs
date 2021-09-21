using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge.Video;
using AForge.Video.DirectShow;

namespace HWS_Visualizer
{
    public partial class Form1 : Form
    {
        private static System.Timers.Timer timerReconnect;
        private FilterInfoCollection VideoCaptureDevices;
        private VideoCaptureDevice FinalVideo;
        private VideoCapabilities highestRes;
        private Bitmap video;
        private bool running;
        public Form1()
        {
            
            InitializeComponent();
            VideoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            RefreshDevices();

            timerReconnect = new System.Timers.Timer();
            timerReconnect.Interval = 1000;
            timerReconnect.Enabled = false;
            running = false;

        }
        private void RefreshDevices()
        {
            if (FinalVideo != null)
                 FinalVideo.SignalToStop();
            cmbCameras.Items.Clear();
            foreach (FilterInfo VideoCaptureDevice in VideoCaptureDevices)
            {
                
                cmbCameras.Items.Add(VideoCaptureDevice.Name);
                if (VideoCaptureDevice.Name.Contains("AVer"))
                    cmbCameras.Text = VideoCaptureDevice.Name;
                btnGo.Enabled = true;
            }
            
            if (!btnGo.Enabled)
            {
                MessageBox.Show("No video devices are plugged in! \n Please plug in your device and re-open the program.", "HWS App");
                splitContainer1.BackColor = Color.Red;
               
                
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            splitContainer1.Size = new Size(splitContainer1.Size.Width, 30);
            splitContainer1.Panel1MinSize = 10;
            splitContainer1.SplitterDistance = 30;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            if (splitContainer1.BackColor == Color.Red)
                Application.Exit();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (cmbCameras.Text == "")
                return;

            running = true;

            FinalVideo = null;
            FinalVideo = new VideoCaptureDevice(VideoCaptureDevices[cmbCameras.SelectedIndex].MonikerString);
            FinalVideo.NewFrame += new NewFrameEventHandler(FinalVideo_NewFrame);

            highestRes = null;
            int biggestResSoFar = 0;

            for (int i = 0; i < FinalVideo.VideoCapabilities.Length; i++)
            {
                if (FinalVideo.VideoCapabilities[i].FrameSize.Width > biggestResSoFar)
                { 
                    highestRes = FinalVideo.VideoCapabilities[i];
                    biggestResSoFar = FinalVideo.VideoCapabilities[i].FrameSize.Width;
                }
            }
            
            FinalVideo.VideoResolution = highestRes;
            FinalVideo.Start();
            btnGo.Enabled = false;
            btnStop.Enabled = true;
            timerAutoReconnect.Enabled = chkAutoReconnect.Checked;
        }
        void FinalVideo_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (!running)
                return;

            if (video != null)
                video.Dispose();

            video = (Bitmap)eventArgs.Frame.Clone();
            if ( chkMirror.Checked)
            {
                var filter = new AForge.Imaging.Filters.Mirror(false, true);
                filter.ApplyInPlace(video);
            }
            picCam.Image = video;
            picCam.SizeMode = PictureBoxSizeMode.StretchImage;
         


        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            running = false;
            timerAutoReconnect.Enabled = false;
            btnStop.Enabled = false;
            FinalVideo.SignalToStop();
           
            btnGo.Enabled = true;
            btnGo.Text = "Resume";
            btnGo.BackColor = Color.HotPink;
            
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FinalVideo != null)
                FinalVideo.SignalToStop();

            Application.Exit();
        }

        private void picCam_Click(object sender, EventArgs e)
        {

        }

        private void lnkDevices_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RefreshDevices();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkAutoReconnect_CheckedChanged(object sender, EventArgs e)
        {
            timerAutoReconnect.Enabled = chkAutoReconnect.Checked;
        }

        private void timerAutoReconnect_Tick(object sender, EventArgs e)
        {
            try
            {
                if (running)
                {
                    FinalVideo = null;
                    FinalVideo = new VideoCaptureDevice(VideoCaptureDevices[cmbCameras.SelectedIndex].MonikerString);

                    FinalVideo.NewFrame += new NewFrameEventHandler(FinalVideo_NewFrame);

                    FinalVideo.VideoResolution = highestRes;
                    FinalVideo.Start();
                }
            }
            catch (Exception exc) { }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
