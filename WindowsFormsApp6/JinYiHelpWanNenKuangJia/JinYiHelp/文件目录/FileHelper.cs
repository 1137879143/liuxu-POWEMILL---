using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace JinYiHelp.FileHelp
{
   public class FileHelper
    {

        [DllImport("Shell32.dll")]
        public static extern int ILCreateFromPathA(string lpFileName);// 文件定位
        [DllImport("Shell32.dll")]
        public static extern int SHOpenFolderAndSelectItems(int pidlfolder, int cidl, int apidl, int dwFlags);
        [DllImport("shell32.dll")]
        public static extern void ILFree(int lngpidl);

        /// <summary>
        /// 由于precess启动的explorer 有些系统会有权限问题 所以 改成这种吧 只能定位文件 不能定位文件夹
        /// </summary>
        /// <param name="fileName"></param>
        public static bool OpenSelectFile(string fileName)
        {
            if (!File.Exists(fileName)) return false;

            int lngpidl = ILCreateFromPathA(fileName);
            if (lngpidl == 0) return false;

            int lngRet = SHOpenFolderAndSelectItems(lngpidl, 0, 0, 0);
            ILFree(lngRet);
            if (lngRet == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// 打开文件夹 或文件夹 如果是文件 有些电脑上会有权限问题可以使用 OpenSelectFile
        /// </summary>
        /// <param name="dirName"></param>
        /// <returns></returns>
        public static bool OpenDir(string dirName)
        {
           
           // Process.Start("\""+dirName+"\"");//也可以 直接用这种

            System.Diagnostics.ProcessStartInfo processStartInfo = new System.Diagnostics.ProcessStartInfo();
         
            processStartInfo.FileName = "explorer.exe";  //资源管理器
            processStartInfo.Arguments = "/select,\"" + dirName + "\"";

            Process.Start(processStartInfo);

            return true;
        }

    }
}
