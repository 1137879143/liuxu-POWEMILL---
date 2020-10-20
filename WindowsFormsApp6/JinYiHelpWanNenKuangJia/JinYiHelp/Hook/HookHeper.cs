﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JinYiHelp.HookHelp
{
    /// <summary>
    /// 更多hook 功能 请使用easyHook
    /// </summary>
   public class HookHeper
    {
        

        /// <summary>
        /// hook 注册热键
        /// </summary>
        /// <param name="hWnd">要定义热键的窗口的句柄</param>
        /// <param name="id">//定义热键ID （不能与其它ID重复）</param>
        /// <param name="fsModifiers">//标识热键是否在按Alt、Ctrl、Shift、Windows等键时才会生效</param>
        /// <param name="vk">// 组后 热键的内容 </param>
        /// <returns></returns>
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool RegisterHotKey( IntPtr hWnd,int id, KeyModifiers fsModifiers, Keys vk);

        /// <summary>
        /// 卸载注册的热键
        /// </summary>
        /// <param name="hWnd">//要取消热键的窗口的句柄</param>
        /// <param name="id">//要取消热键的ID</param>
        /// <returns></returns>
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool UnregisterHotKey( IntPtr hWnd,  int id );

        //定义了辅助键的名称（将数字转变为字符以便于记忆，也可去除此枚举而直接使用数值）
        [Flags()]
        public enum KeyModifiers
        {
            None = 0,
            Alt = 1,
            Ctrl = 2,
            Shift = 4,
            WindowsKey = 8,
          
        }

       

    }
}
