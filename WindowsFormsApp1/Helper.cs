using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    class Helper
    {
        static string savePath = null;
        public static void SaveImageCapture(System.Drawing.Image image)
        {
            if (savePath == null)
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    savePath = fbd.SelectedPath;
                    Console.WriteLine(savePath);
                }
            }
            //time format is "hours.minutest.seconds.milliseconds"
            string imageName = DateTime.Now.ToString("hh.mm.ss.fff");
            string imagePath = savePath + "\\" + imageName + ".jpg";
            Console.WriteLine(imagePath);
            
            FileStream fstream = new FileStream(imagePath, FileMode.Create);
            image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
            fstream.Close();

        }

        public static void SetSavePath()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                savePath = fbd.SelectedPath;
                Console.WriteLine(savePath);
            }
        }
    }
}
