using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JinYiHelp.FtpHelp;

namespace JYKJDome
{
    public partial class Form_Ftp : Form
    {
        public Form_Ftp()
        {
            InitializeComponent();
        }

        FtpHelper _ftp = null;
        private string _msg = "";

        private void Form_Ftp_Load(object sender, EventArgs e)
        {
            string serveIP = "192.168.1.108";
            int port = 2121;
            string user = "pc2";
            string pass = "mjkmjk";


            _ftp = new FtpHelper(serveIP,port,user,pass);
        }


        private void but_up_Click(object sender, EventArgs e)
        {
            _msg = "上传";
            Action<int, int> action = new Action<int, int>(DownCall);
            string localName = @"C:\Users\pc2\Desktop\ftptest\baohe_up.zip";
            _ftp.UploadFile("", localName, action);
        }

        private void but_down_Click(object sender, EventArgs e)
        {
            _msg = "下载";
            /// <summary>
            /// 从FTP服务器下载文件，指定本地路径和本地文件名
            /// </summary>
            /// <param name="remoteFileName">远程文件名</param>
            /// <param name="localFileName">保存本地的文件名（包含路径）</param>
            /// <param name="ifCredential">是否启用身份验证（false：表示允许用户匿名下载）</param>
            /// <param name="updateProgress">报告进度的处理(第一个参数：总大小，第二个参数：当前进度)</param>
            string remoteFileName = "baohe.zip";
            string localFileName = @"C:\Users\pc2\Desktop\ftptest\down\baohe_down.zip";
            bool ifCredential = true;
            Action<int, int> action = new Action<int, int>(DownCall);

            _ftp.Download(remoteFileName,localFileName, ifCredential,action);
        }
        //totalBytes, (int)totalDownloadedByte
        /// <summary>
        /// 下载 回调
        /// </summary>
        /// <param name="totalSize">总大小</param>
        /// <param name="totalDownSize">已下载大小</param>
        private void DownCall(int  totalSize,int totalDownSize)
        {
           decimal total = totalSize / 1024M/1024m;

            total= Math.Round(total, 2);

            double jindu = 0;
            if (totalDownSize>0 && totalDownSize > 0)
            {
               var djindu= (double)totalDownSize / (double)totalSize*100;
                jindu = Math.Round(djindu, 2);
            }

          
            pro_up.Value = (int)jindu;

            decimal down = totalDownSize / 1024M;
            string strDown = string.Empty;
            if (down >= 1024m)
            {
              strDown=  Math.Round(down / 1024m, 2).ToString()+"Mb";
            }
            else
            {
                strDown = Math.Round(down, 2).ToString() + "Kb";
            }


            Console.WriteLine($"总大小{total}Mb,{_msg} {strDown} 进度:{ jindu}% ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           var list= _ftp.GetFilesDetails();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
