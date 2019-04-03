using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        VideoCapture capture = null; //create a camera captue
        
        private FilterInfoCollection CaptureDevices;
        private bool capturing = false;


        public Form1()
        {
            InitializeComponent();

            CaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevices)
            {
                dropdown.Items.Add(Device.Name);
            }
            dropdown.SelectedIndex = 0;


            imgVideo.SizeMode = PictureBoxSizeMode.Zoom;


        }



        private void start_capture_Click(object sender, EventArgs e)
        {
            /*
            videoSource = new VideoCaptureDevice(CaptureDevices[dropdown.SelectedIndex].MonikerString);
            Console.WriteLine(dropdown.SelectedIndex);
            Console.WriteLine(CaptureDevices[dropdown.SelectedIndex].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrameEvent);
            Helper.SetSavePath();
            videoSource.Start();
            */

            int cameraRealIndex = dropdown.Items.Count - dropdown.SelectedIndex - 1;
            capture = new VideoCapture(cameraRealIndex);
            capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth, 1000000);
            capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight, 1000000);
            Console.WriteLine(capture.Width);
            Console.WriteLine(capture.Height);

            Application.Idle += saveImagesFromWebcam;
            Console.WriteLine("setup");

        }

        private void Capture_Click(object sender, EventArgs e)
        {
            if (capture != null)
            {
                capturing = true;
                text_Capturing.Text = "Capturing";
            }
        }

        private void Stop_Capture_Click(object sender, EventArgs e)
        {
            capturing = false;
            text_Capturing.Text = "Not Capturing";
        }


        private void btnCapture_Image_Click(object sender, EventArgs e)
        {
            var img = capture.QueryFrame().ToImage<Bgr, byte>();
            var bmp = img.Clone().Bitmap;
            Helper.SaveImageCapture(bmp);
            Console.WriteLine("Took Picture");


        }

        private void VideoSource_NewFrameEvent(object sender, NewFrameEventArgs eventArgs)
        {
            //when using AForge
            imgVideo.Image = (Bitmap)eventArgs.Frame.Clone();
            System.Threading.Thread.Sleep(40);
            Helper.SaveImageCapture(eventArgs.Frame);
        }

        private void saveImagesFromWebcam(object sender, System.EventArgs e)
        {
            var img = capture.QueryFrame().ToImage<Bgr, byte>();
            var bmp = img.Clone().Bitmap;
            imgVideo.Image = bmp;
            if (capturing)
            {
                Helper.SaveImageCapture(bmp);
            }

        }

        private void saveClick(object sender, EventArgs e)
        {
            Helper.SetSavePath();
        }

        private void exit_form_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
