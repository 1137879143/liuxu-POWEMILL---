using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JinYiHelp.MultiThreadHelp;

namespace JYKJDome
{
    public partial class Form_ThreadDown : Form
    {
        public Form_ThreadDown()
        {
            InitializeComponent();
        }

        MultiThreadDownloader down = null;

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            down.Start();
            but_start.Enabled = false;

        }

        private void Form_ThreadDown_Load(object sender, EventArgs e)
        {
            string url = "http://s2.xp666.com/wpsoffice_2018.zip";

            string temDir = Application.StartupPath + @"\temp\";
            if (!Directory.Exists(temDir)) Directory.CreateDirectory(temDir);

            string save = Application.StartupPath + @"\wap.zip";

             down = new MultiThreadDownloader(url, temDir, save, 3);
            down.TotalProgressChanged += Down_TotalProgressChanged;
        }

        private void Down_TotalProgressChanged(object sender, EventArgs e)
        {
            MultiThreadDownloader nowDown = (MultiThreadDownloader)sender;

            pro_down.Value = (int)nowDown.TotalProgress;
            string strSize = Math.Round(nowDown.Size / 1024m / 1024m, 2).ToString() + "Mb";

            double tempSpeed = (double)nowDown.TotalSpeedInBytes / 1024;
            string strSpeed = "";
            if (tempSpeed >= 1024)
            {
               
                strSpeed = Math.Round(tempSpeed / 1024, 2).ToString() + "Mb";
            }
            else
            {
                strSpeed = Math.Round(tempSpeed, 2).ToString() + "Kb";
            }

            
            string strDown = Math.Round(nowDown.TotalBytesReceived / 1024m / 1024, 2).ToString() + "Mb";

            Console.WriteLine($"总大小{strSize} 下载速度:{strSpeed} 已下载{strDown} 进度{nowDown.TotalProgress}%");
        }

        private void but_stop_Click(object sender, EventArgs e)
        {
            down.Pause();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            down.Resume();
        }
    }
}
