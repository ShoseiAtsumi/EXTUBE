using System;
using System.IO;
using System.Diagnostics;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EXTUBE;

namespace EXTUBE.Utility
{
    public class YoutubeDlUtility
    {
        const string YOUTUBE_DL_PATH = "youtube-dl.exe";
        private string absoluteYoutubeDlPath = Path.Combine(Path.GetTempPath(), YOUTUBE_DL_PATH);
        private string config = "";

        private string url = "";
        private string videoPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);

        public YoutubeDlUtility(string url)
        {
            this.url = url;
        }

        public YoutubeDlUtility(string url, string videoPath)
        {
            this.url = url;
            if (videoPath != string.Empty) this.videoPath = videoPath;
        }

        public YoutubeDlUtility(string url, string videoPath, string option)
        {

        }

            private void CreateConfig(string url, string downloadPath, string option = "")
        {
            config += this.url + " -o \"" + downloadPath + "\\%(title)s-%(id)s.%(ext)s\" " + option;
        }

        public void KickProcess()
        {
            byte[] youtubeDlBin = Properties.Resources.youtube_dl;
            using (FileStream fs = new FileStream(absoluteYoutubeDlPath, FileMode.Create))
                fs.Write(youtubeDlBin, 0, youtubeDlBin.Length);

            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.FileName = absoluteYoutubeDlPath;
            processInfo.Arguments = $"{this.config}";
            Process p = Process.Start(processInfo);
            p.WaitForExit();
            p.Close();
            File.Delete(absoluteYoutubeDlPath);
        }
    }
}
