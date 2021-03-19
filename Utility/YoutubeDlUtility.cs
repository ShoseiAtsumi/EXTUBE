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
        const string YOUTUBE_DL_PATH = @"youtube-dl.exe";
        private string absoluteYoutubeDlDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        private string config = "";

        private string url = "";
        private string videoPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);

        public YoutubeDlUtility(string url)
        {
            this.url = url;
        }
        public YoutubeDlUtility(string url, string downloadPath)
        {
            this.url = url;
            config += this.url + " -o \"" + downloadPath + "\\%(title)s-%(id)s.%(ext)s\"";
        }

            public void Run()
        {
            Task.Run(() => KickProcess());
        }

        private void KickProcess()
        {
            string res = string.Empty;
            string absoluteYoutubeDlPath = Path.Combine(absoluteYoutubeDlDirectory, YOUTUBE_DL_PATH);
            try
            {
                Directory.CreateDirectory(absoluteYoutubeDlDirectory);
                byte[] youtubeDlBin = Properties.Resources.youtube_dl;
                using (FileStream fs = new FileStream(absoluteYoutubeDlPath, FileMode.Create))
                    fs.Write(youtubeDlBin, 0, youtubeDlBin.Length);

                ProcessStartInfo processInfo = new ProcessStartInfo();
                processInfo.FileName = absoluteYoutubeDlPath;
                processInfo.Arguments = $"{this.url} {this.config}";
                using (Process process = Process.Start(processInfo))
                {
                    process.WaitForExit();        
                }

            }
            finally
            {
                File.Delete(absoluteYoutubeDlPath);
                Directory.Delete(absoluteYoutubeDlDirectory);
            }
        }
    }
}
