using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinYiHelp.SystemHelp
{
    /// <summary>
    /// Adsl 拨号相关
    /// </summary>
    public  class AdslHelper
    {
        /// <summary>
        /// 断线 + 重连（必须是拨号的才可以，接路由神马的就算了吧）
        /// </summary>
        /// <param name="Kd_NetName">宽带名字</param>
        /// <param name="Kd_UserName">账号</param>
        /// <param name="Kd_UserPsd">密码</param>
        public void ResetNet(string Kd_NetName, string Kd_UserName, string Kd_UserPsd)
        {
            //这句代码执行断开连接
            Execute("rasdial.exe  /disconnect ", 0);
            //这句代码执行清理Cookie
            Execute("del " + "C:/Documents and Settings/hyuqin/Cookies/*.*" + "/Q ", 0);
            //这句代码执行重新连接宽带 - 请设置好参数再进行调试
            Execute("rasdial.exe  " + Kd_NetName + " " + Kd_UserName + " " + Kd_UserPsd, 0);
        }

        /// <summary>
        /// 断线 （必须是拨号的才可以，接路由神马的就算了吧）
        /// </summary>
        public void CloseNet()
        {
            //这句代码执行断开连接
            Execute("rasdial.exe  /disconnect ", 0);
            //这句代码执行清理Cookie
            Execute("del " + "C:/Documents and Settings/hyuqin/Cookies/*.*" + "/Q ", 0);
        }

        /// <summary>
        /// 重连 （必须是拨号的才可以，接路由神马的就算了吧）
        /// </summary>
        /// <param name="Kd_NetName">宽带名字</param>
        /// <param name="Kd_UserName">账号</param>
        /// <param name="Kd_UserPsd">密码</param>
        public void SetNet(string Kd_NetName, string Kd_UserName, string Kd_UserPsd)
        {
            //这句代码执行重新连接宽带 - 请设置好参数再进行调试
            Execute("rasdial.exe  " + Kd_NetName + " " + Kd_UserName + " " + Kd_UserPsd, 0);
        }

        /// <summary>
        /// 执行DOS命令，返回DOS命令的输出
        /// </summary>
        /// <param name="dosCommand">dos命令</param>
        /// <param name="milliseconds">等待命令执行的时间（单位：毫秒），
        /// 如果设定为0，则无限等待</param>
        /// <returns>返回DOS命令的输出</returns>
        public static string Execute(string command, int seconds)
        {
            string output = ""; //输出字符串
            if (command != null && !command.Equals(""))
            {
                Process process = new Process();//创建进程对象
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "cmd.exe";//设定需要执行的命令
                startInfo.Arguments = "/C " + command;//“/C”表示执行完命令后马上退出
                startInfo.UseShellExecute = false;//不使用系统外壳程序启动
                startInfo.RedirectStandardInput = false;//不重定向输入
                startInfo.RedirectStandardOutput = true; //重定向输出
                startInfo.CreateNoWindow = true;//不创建窗口
                process.StartInfo = startInfo;
                try
                {
                    if (process.Start())//开始进程
                    {
                        if (seconds == 0)
                        {
                            process.WaitForExit();//这里无限等待进程结束
                        }
                        else
                        {
                            process.WaitForExit(seconds); //等待进程结束，等待时间为指定的毫秒
                        }
                        output = process.StandardOutput.ReadToEnd();//读取进程的输出
                    }
                }
                catch
                {
                }
                finally
                {
                    if (process != null)
                        process.Close();
                }
            }
            return output;
        }

        

    }
}
