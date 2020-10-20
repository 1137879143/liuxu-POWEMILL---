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
using JinYiHelp.API;
using JinYiHelp.HookHelp;

namespace JYKJDome
{
    public partial class Form_Win32 : Form
    {
        public Form_Win32()
        {
            InitializeComponent();
          
        }

        bool is_exit = true;
        IntPtr _Hand;
        private void Form_Win32_Load(object sender, EventArgs e)
        {
            #region 根据坐标获取句柄ID
            ThreadPool.UnsafeQueueUserWorkItem(new WaitCallback((object s) =>
            {
                while (is_exit)
                {
                    var point = WinAPI.GetCursorPosPoint();

                    LabelInvoke(lab_xy, point.X.ToString() + "," + point.Y.ToString());
                  
                    var hand= WinAPI.GetHandle(point);
                    LabelInvoke(lab_hand, hand.ToString());
                  
                    Thread.Sleep(10);
                }

            }), null);

            #endregion 获取句柄 


            //注册热键 也可以直接使用数字来表示。按下 alt+2
            bool is_reg = HookHeper.RegisterHotKey(Handle, 102, HookHeper.KeyModifiers.Alt, Keys.D2);
            Console.WriteLine("注册热键："+is_reg.ToString());

        }

        private void LabelInvoke(Label lab,string msg)
        {
            if (lab.InvokeRequired)
            {
                Action< Label,string> action = new Action<Label, string>(LabelInvoke);
                lab.Invoke(action, lab, msg);
            }
            else
            {
                lab.Text = msg;
            }
        }


        private void Form_Win32_FormClosing(object sender, FormClosingEventArgs e)
        {
            is_exit = false;

            HookHeper.UnregisterHotKey(Handle, 102);
        }

        /// <summary>
        /// 重载 wndProc  方法 获取注册热键事件
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            if(m.WParam.ToInt32()==102)// 按下 alt+2
            {
                txt_hand.Text = lab_hand.Text;
             
            }

            base.WndProc(ref m);

        }

        private void but_bind_Click(object sender, EventArgs e)
        {
            int int_hand;
            Int32.TryParse( txt_hand.Text,out int_hand);

            if (int_hand == 0)
            {
                MessageBox.Show("窗口绑定失败,请先用 alt+2 来获取句柄");
                return;
            }

            _Hand = (IntPtr)int_hand;

            WinAPI.SetWindosActiv(_Hand);//激活 并显示在最前面

            txt_title.Text = WinAPI.GetWindowText(_Hand);
            txt_class.Text = WinAPI.GetClassName(_Hand);

            text_father.Text = WinAPI.GetParent(_Hand).ToString();

         

            var rect = WinAPI.GetWindowRect(_Hand);


            txt_posion.Text = $"x: {rect.X} y: {rect.Y}";
            txt_size.Text = $"宽度:{rect.Width} 高度:{rect.Height}";
            IntPtr processId = IntPtr.Zero;
            WinAPI.GetWindowThreadProcessId(_Hand, ref processId);

            txt_biaoshi.Text = processId.ToString();
            var child_hand = WinAPI.FindWindowE(_Hand, IntPtr.Zero, null);
            txt_child.Text = child_hand.ToString();

            //获取所有子窗口
            var list = WinAPI.FindWindowExList(_Hand,null);

           
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"第({i}) 个子窗口:{list[i].ToString()}"); ;
            }

               

        }

        private void che_activate_CheckedChanged(object sender, EventArgs e)
        {
            if (che_activate.Checked)
            {
                WinAPI.SetWindosActiv(_Hand);
            }
        }

        private void che_settop_CheckedChanged(object sender, EventArgs e)
        {
           
                WinAPI.SetWindowsTop(_Hand, che_settop.Checked);
           
        }

        private void che_close_CheckedChanged(object sender, EventArgs e)
        {
            //0关闭窗口 1=正常大小显示窗口2=最小化窗口3=最大化窗口
            if (che_close.Checked)
            {
                WinAPI.ShowWindowAsync(_Hand,0);
            }

          
        }

        private void che_hyuan_CheckedChanged(object sender, EventArgs e)
        {
            if (che_hyuan.Checked)
            {
                WinAPI.ShowWindowAsync(_Hand, ShowEnum.SW_RESTORE);
            }

        }

        private void che_max_CheckedChanged(object sender, EventArgs e)
        {
            if (che_max.Checked)
            {
                WinAPI.ShowWindowAsync(_Hand, ShowEnum.SW_MAXIMIZE);
            }
            else
            {
                WinAPI.ShowWindowAsync(_Hand, ShowEnum.SW_NORMAL);
            }
        }

        private void che_min_CheckedChanged(object sender, EventArgs e)
        {
            if (che_min.Checked)
            {
                WinAPI.ShowWindowAsync(_Hand, ShowEnum.SW_MINIMIZE);
            }
            else
            {
                WinAPI.ShowWindowAsync(_Hand, ShowEnum.SW_NORMAL);
            }
        }

        private void but_send_Click(object sender, EventArgs e)
        {
            if (_Hand == IntPtr.Zero) return;

            WinAPI.SetWindowText(_Hand, "正在打字中...");
            var dazi_hand= WinAPI.FindWindowE(_Hand,IntPtr.Zero, "Edit");//notepad 是这个类名 其它软件 先查找对应的类名

            if (dazi_hand == IntPtr.Zero) return;
            StringBuilder sb = new StringBuilder();

            for (int i = 65; i < 91; i++)
            {
               string msg= Convert.ToString((char)i);
               
                sb.Append(msg);
                WinAPI.SendMessageA(dazi_hand, sb.ToString());
                Thread.Sleep(100);
            }

           

        }
    }
}
