using JinYiHelp.EasyHTTPClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using JinYiHelp.StringHelp;
using JinYiHelp.IniHelp;
using JinYiHelp.LogHelp;
using JinYiHelp.CodingHelp;
using JinYiHelp.CryptHelp;
using JinYiHelp.TimeHelp;
using JinYiHelp.CompressHelp;
using Microsoft.Win32;
using JinYiHelp.SystemHelp;
using JinYiHelp.MediaHelp;
using JinYiHelp.ProcessHelp;
using JinYiHelp.JsonHelp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JYKJDome
{
    public partial class Form_test : Form
    {
        public Form_test()
        {
            InitializeComponent();
        }

       
        private void Form_test_Load(object sender, EventArgs e)
        {

        }

        private async void but_Get_Click(object sender, EventArgs e)
        {
            HttpItem item = new HttpItem()
            {
                URL = "https://www.baidu.com",
                Timeout=5,
                Encoding = Encoding.UTF8,// Encoding.GetEncoding("GB2312")
            };

          
            var result =await item.GetHtml();

            Console.WriteLine(result.Cookie);
            if (result.IsSuccessStatusCode)
            {
                txt_Info.Text = result.Html;
            }
            else
            {
                //MessageBox.Show(result.StatusDescription);
                Console.WriteLine(result.StatusDescription);
            }

          

        }

        private async void but_GetPic_Click(object sender, EventArgs e)
        {
            HttpItem item = new HttpItem()
            {
                URL = "https://tb1.bdstatic.com/tb/r/image/2019-05-22/a5e3c00f38b64d9ff86b2015746e5584.jpg",
                ResultType = ResultType.Byte,
             
            };

            var result = await item.GetHtml();

            if (result.IsSuccessStatusCode)
            {
                MemoryStream ms = new MemoryStream(result.ResultByte);

                pic_img.Image = Image.FromStream(ms);
                ms.Close();
            }
            else
            {
                MessageBox.Show(result.StatusDescription);
            }

        }

        private async void but_Post_Click(object sender, EventArgs e)
        {

            string body = "username=test";
            HttpItem item = new HttpItem()
            {
                URL = "https://passport.baidu.com/v2/api/?login",
                Method = System.Net.Http.HttpMethod.Post,
                Postdata = body,
            };

           var result=await item.GetHtml();

            if (result.IsSuccessStatusCode)
            {
                txt_Info.Text = result.Html;
            }
            else
            {
                MessageBox.Show(result.StatusDescription);
            }

        }

        private void but_Test_Click(object sender, EventArgs e)
        {
          
            //GetSysInfo();

        }
        private void GetSysInfo()
        {

            SystemHelper os = new SystemHelper();
            Console.WriteLine("操作系统:" +os.GetOsVersion());

           
            Console.WriteLine($"硬盘大小:{os.GetDiskSize()}");
            Console.WriteLine($"硬盘系列号:{os.GetDiskSerialNumber()}");

            Console.WriteLine($"Cpu系列号:{os.GetCpuid()}");

            Console.WriteLine($"内存大小:{os.GetPhysicalMemory()}");

            Console.WriteLine($"网卡:{os.GetMacAddress()} IP:{os.GetIpAddress()}");

            Console.WriteLine($"用户名:{os.GetUserName()}");

         

        }


        private void but_win32_Click(object sender, EventArgs e)
        {
            var form32 = new Form_Win32();
            form32.Show();
        }

        private void but_dm_Click(object sender, EventArgs e)
        {
            var form_dm = new Form_DM();
            form_dm.Show();
        }

        private void but_ftp_Click(object sender, EventArgs e)
        {
            new Form_Ftp().Show();
        }

        private void but_thread_Click(object sender, EventArgs e)
        {
            new Form_ThreadDown().Show();
        }

        private void but_socket_Click(object sender, EventArgs e)
        {
            new Form_SocketServer().Show();
        }

        private void but_zip_Click(object sender, EventArgs e)
        {
            //支持多种格式


            string zip_name = @"C:\Users\pc2\Desktop\ftptest\test.rar";
            if (File.Exists(zip_name))
            {

                CompressHelper.Decompress(zip_name);
                Console.WriteLine("解压完成");
            }
            else
            {
                MessageBox.Show("解压文件不存在");
            }

        }

        private void but_img_Click(object sender, EventArgs e)
        {
            new Form_Image().Show();
        }

        private void but_Test_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("可以在这里添加测试方法");

        }
    }
}
