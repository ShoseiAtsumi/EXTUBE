using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using EXTUBE.Utility;
using System.IO;
using System.Text.RegularExpressions;

namespace EXTUBE.Forms
{
    public partial class MainMenuForm : MetroForm
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btn_button_Click(object sender, EventArgs e)
        {
            var url = TextBoxUrlPath.Text;
            YoutubeDlUtility youtubeDlUtility = new YoutubeDlUtility(url);
            youtubeDlUtility.KickProcess();
        }
    }
}
