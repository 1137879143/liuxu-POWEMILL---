using JinYiHelp.API;
using JinYiHelp.DM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JYKJDome
{
    public partial class Form_DM : Form
    {
        public Form_DM()
        {
            InitializeComponent();
            _syncContext = SynchronizationContext.Current;
        }
        SynchronizationContext _syncContext = null;
        private bool is_exit = true;
        CDmSoft _dm = new CDmSoft();
      
        private void Form_DM_Load(object sender, EventArgs e)
        {
            #region 获取句柄ID 跟鼠标坐标
            ThreadPool.UnsafeQueueUserWorkItem(new WaitCallback((object s) =>
            {
                object objx, objy;
                while (is_exit)
                {
                    int dm_ret = _dm.GetCursorPos(out objx,out objy);
                    int hand = _dm.GetMousePointWindow();
                    string point = objx.ToString() + "," + objy.ToString();

                    _syncContext.Post(LabHandText,hand.ToString());

                    _syncContext.Post(LabXyText, point);
                    Thread.Sleep(10);
                }

            }), null);

            #endregion

            #region 注册热键

            ThreadPool.UnsafeQueueUserWorkItem(new WaitCallback((object s)=> {
                while (is_exit)
                {
                    if (_dm.WaitKey(18, 0) + _dm.WaitKey(49, 0) == 2)//alt+1(数字1)
                    {
                        _syncContext.Post(TextInvoke, lab_hand.Text);
                    }
                    Thread.Sleep(10);
                }
            }),null);


            #endregion


        }

        private void TextInvoke(object msg)
        {
           
          txt_hand.Text = msg.ToString();
            
        }

        private void LabXyText(object msg)
        {
          lab_xy.Text = msg.ToString();
        }

        private void LabHandText(object msg)
        {
            lab_hand.Text = msg.ToString();
        }

        int _Hand;
        private void but_bind_Click(object sender, EventArgs e)
        {
            _Hand = Convert.ToInt32(txt_hand.Text);//
            int dm_ret = _dm.BindWindow(_Hand, "normal", "normal", "windows", 0);
            if (dm_ret == 1)
            {
                //dm.DM = new IntPtr(winNum);
                MessageBox.Show("绑定成功!");
            }
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            //var dazi_hand = WinAPI.GetChildHandle((IntPtr)_Hand, IntPtr.Zero, "Edit");//notepad 是这个类名 其它软件 先查找对应的类名
            var dazi_hand = _dm.FindWindowEx((int)_Hand, "Edit",null); 

            ThreadPool.UnsafeQueueUserWorkItem(new WaitCallback((object s) =>
            {
              
                for (int i = 65; i < 91; i++)
                {
                    string msg = Convert.ToString((char)i);

                    _dm.SendString((int)dazi_hand, msg);
                    Thread.Sleep(100);
                }
            }), null);		//线程池--后台打字


        }

        private void btnPic_Click(object sender, EventArgs e)
        {

            #region 找图
            {
                object intX, intY;
                int height = _dm.GetScreenHeight();
                int width = _dm.GetScreenWidth();
                Console.WriteLine("height:" + height.ToString() + " width:" + width.ToString());


                int dm_ret = _dm.FindPic(0, 0, width, height, Application.StartupPath + @"\gong.bmp", "000000", 0.9, 0, out intX, out intY);
                if (dm_ret != 0)
                {
                    MessageBox.Show("没找到");

                    return;
                }
                string msg = String.Format("已发现！坐标是：{0},{1}", intX, intY);
                MessageBox.Show(msg);
            }

            #endregion 

        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            _dm.SetDict(0,"word.txt");

            int height = _dm.GetScreenHeight();
            int width = _dm.GetScreenWidth();
            Console.WriteLine("height:" + height.ToString() + " width:" + width.ToString());

            object intX, intY;
            int dm_ret = _dm.FindStr(0, 0, width, height, "0", "", 0.9, out intX, out intY);
            if (dm_ret < 0)
            {
                MessageBox.Show("没找到");

                return;
            }
            string msg = String.Format("找到“1”了！坐标是：{0},{1}", intX, intY);
            MessageBox.Show(msg);
        }

        private void btnScreenshot_Click(object sender, EventArgs e)
        {
            _dm.SetPath("/");

          
            MessageBox.Show("DM:" + _dm.DM.ToString());

            int dm_ret = _dm.CapturePng(0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, "screenshot.png");
            if (dm_ret == 0)
            {
                MessageBox.Show("失败啊！");
                return;
            }
            string msg = String.Format("成功截图！\n已经保存在{0}\\screenshot.png", Application.StartupPath);
            MessageBox.Show(msg);
            System.Diagnostics.Process.Start("screenshot.png");
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\"打字\"：绑定任意文本框句柄，可实现后台打字母效果。\n\"找字\"：可找指定字库内的文字位置。\n\"找图\"：可找指定的图片位置。\n\"截图\"：可截绑定句柄的窗体，默认未绑定为桌面。");
        }

        private void Form_DM_FormClosing(object sender, FormClosingEventArgs e)
        {
            _dm.UnBindWindow();
        }
    }
}
