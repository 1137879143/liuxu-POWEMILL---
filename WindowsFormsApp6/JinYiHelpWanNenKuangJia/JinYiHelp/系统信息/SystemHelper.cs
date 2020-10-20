using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace JinYiHelp.SystemHelp
{
   public class SystemHelper
    {

        /// <summary>
        /// 获得CPU编号
        /// </summary>
        /// <returns></returns>
        public string GetCpuid()
        {
            var cpuid = string.Empty;
            var mc = new ManagementClass("Win32_Processor");
            var moc = mc.GetInstances();
            foreach (var o in moc)
            {
                var mo = (ManagementObject)o;
                cpuid = mo.Properties["ProcessorId"].Value.ToString();
            }
            return cpuid;
        }

        /// <summary>
        /// 获取硬盘序列号
        /// </summary>
        /// <returns></returns>
        public string GetDiskSerialNumber()
        {
            //这种模式在插入一个U盘后可能会有不同的结果，如插入我的手机时
            //这名话解决有多个物理盘时产生的问题，只取第一个物理硬盘
          
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
                string strHardDiskID = null;
                foreach (ManagementObject mo in searcher.Get())
                {
                    strHardDiskID = mo["SerialNumber"].ToString().Trim();
                    
                    break;
                }
                return strHardDiskID;
            }
            catch
            {
                return "";
            }

        }


        /// <summary>
        /// 获取硬盘的大小
        /// </summary>
        /// <returns></returns>
        public string GetDiskSize()
        {
                
      
           ManagementClass mc = new ManagementClass("Win32_DiskDrive");
           ManagementObjectCollection moj = mc.GetInstances();
                foreach (ManagementObject m in moj)
                {
                    long.TryParse(m.Properties["Size"].Value.ToString(), out long size);

                if (size > 0)
                {
                    size = size / 1024 / 1024 / 1024;
                    return size.ToString() + " G";
                }

                    return "-1";
                }
                return "-1";
            


        }

        /// <summary>
        /// 获取网卡硬件地址
        /// </summary>
        /// <returns></returns> 
        public string GetMacAddress()
        {
            var mac = "";
            var mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            var moc = mc.GetInstances();
            foreach (var o in moc)
            {
                var mo = (ManagementObject)o;
                if (!(bool)mo["IPEnabled"]) continue;
                mac = mo["MacAddress"].ToString();
                break;
            }
            return mac;
        }

        /// <summary>
        /// 获取IP地址
        /// </summary>
        /// <returns></returns>
        public string GetIpAddress()
        {
            var st = string.Empty;
            var mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            var moc = mc.GetInstances();
            foreach (var o in moc)
            {
                var mo = (ManagementObject)o;
                if (!(bool)mo["IPEnabled"]) continue;
                var ar = (Array)(mo.Properties["IpAddress"].Value);
                st = ar.GetValue(0).ToString();
                break;
            }
            return st;
        }

        /// <summary>
        /// 操作系统的登录用户名
        /// </summary>
        /// <returns></returns> 
        public string GetUserName()
        {
            return Environment.UserName;
        }


        /// <summary>
        /// 获取计算机名
        /// </summary>
        /// <returns></returns>
        public string GetComputerName()
        {
            return Environment.MachineName;
        }

        /// <summary>
        /// 操作系统类型
        /// </summary>
        /// <returns></returns> 
        public string GetSystemType()
        {
            var st = string.Empty;
            var mc = new ManagementClass("Win32_ComputerSystem");
            var moc = mc.GetInstances();
            foreach (var o in moc)
            {
                var mo = (ManagementObject)o;
                st = mo["SystemType"].ToString();
            }
            return st;
        }

        /// <summary>
        /// 物理内存
        /// </summary>
        /// <returns></returns>
        public string GetPhysicalMemory()
        {
            var st = string.Empty;
            var mc = new ManagementClass("Win32_ComputerSystem");
            var moc = mc.GetInstances();
            foreach (var o in moc)
            {
                var mo = (ManagementObject)o;
                st = mo["TotalPhysicalMemory"].ToString();
            }
            return st;
        }

        /// <summary>
        /// 显卡PNPDeviceID
        /// </summary>
        /// <returns></returns>
        public string GetVideoPnpid()
        {
            var st = "";
            var mos = new ManagementObjectSearcher("Select * from Win32_VideoController");
            foreach (var o in mos.Get())
            {
                var mo = (ManagementObject)o;
                st = mo["PNPDeviceID"].ToString();
            }
            return st;
        }

        /// <summary>
        /// 声卡PNPDeviceID
        /// </summary>
        /// <returns></returns>
        public string GetSoundPnpid()
        {
            var st = string.Empty;
            var mos = new ManagementObjectSearcher("Select * from Win32_SoundDevice");
            foreach (var o in mos.Get())
            {
                var mo = (ManagementObject)o;
                st = mo["PNPDeviceID"].ToString();
            }
            return st;
        }

        /// <summary>
        /// CPU版本信息
        /// </summary>
        /// <returns></returns>
        public string GetCpuVersion()
        {
            var st = string.Empty;
            var mos = new ManagementObjectSearcher("Select * from Win32_Processor");
            foreach (var o in mos.Get())
            {
                var mo = (ManagementObject)o;
                st = mo["Version"].ToString();
            }
            return st;
        }

        /// <summary>
        /// CPU名称信息
        /// </summary>
        /// <returns></returns>
        public string GetCpuName()
        {
            var st = string.Empty;
            var driveId = new ManagementObjectSearcher("Select * from Win32_Processor");
            foreach (var o in driveId.Get())
            {
                var mo = (ManagementObject)o;
                st = mo["Name"].ToString();
            }
            return st;
        }

        /// <summary>
        /// CPU制造厂商
        /// </summary>
        /// <returns></returns>
        public string GetCpuManufacturer()
        {
            var st = string.Empty;
            var mos = new ManagementObjectSearcher("Select * from Win32_Processor");
            foreach (var o in mos.Get())
            {
                var mo = (ManagementObject)o;
                st = mo["Manufacturer"].ToString();
            }
            return st;
        }

        /// <summary>
        /// 主板制造厂商
        /// </summary>
        /// <returns></returns>
        public string GetBoardManufacturer()
        {
            var query = new SelectQuery("Select * from Win32_BaseBoard");
            var mos = new ManagementObjectSearcher(query);
            var data = mos.Get().GetEnumerator();
            data.MoveNext();
            var board = data.Current;
            return board.GetPropertyValue("Manufacturer").ToString();
        }

        /// <summary>
        /// 主板编号
        /// </summary>
        /// <returns></returns>
        public string GetBoardId()
        {
            var st = string.Empty;
            var mos = new ManagementObjectSearcher("Select * from Win32_BaseBoard");
            foreach (var o in mos.Get())
            {
                var mo = (ManagementObject)o;
                st = mo["SerialNumber"].ToString();
            }
            return st;
        }

        /// <summary>
        /// 主板型号
        /// </summary>
        /// <returns></returns>
        public string GetBoardType()
        {
            var st = string.Empty;
            var mos = new ManagementObjectSearcher("Select * from Win32_BaseBoard");
            foreach (var o in mos.Get())
            {
                var mo = (ManagementObject)o;
                st = mo["Product"].ToString();
            }
            return st;
        }


        public string GetOsVersion()
        {

            string strQuery = "select *from win32_OperatingSystem";
            SelectQuery queryOS = new SelectQuery(strQuery);
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(queryOS);

            string strClient = "";
            foreach (var os in searcher.Get())
            {
                //Console.WriteLine("操作系统版本号\t{0}", os["Version"]);
                strClient = os["Caption"].ToString();
                break;
                //Console.WriteLine("操作系统标题\t{0}", os["Caption"]);
               // Console.WriteLine("操作系统序列号\t{0}", os["SerialNumber"]);
                //Console.WriteLine("操作系统路径\t{0}", os["SystemDirectory"]);
            }

            return strClient;
        }



        //判断本机是否联网
        [DllImport("wininet.dll", EntryPoint = "InternetGetConnectedState")]
        //判断网络状况的方法,返回值true为连接，false为未连接
        private extern static bool InternetGetConnectedState(out int conState, int reder);



        #region 关机 重启 注销
        [DllImport("user32.dll", EntryPoint = "ExitWindowsEx", CharSet = CharSet.Ansi)]
        private static extern int ExitWindowsEx(int uFlags, int dwReserved);

        /// <summary>
        /// 判断是否联网
        /// </summary>
        /// <returns></returns>
        public static bool IsInternetState()
        {
            int n = 0;
            return InternetGetConnectedState(out n, 0);
            
        }

        /// <summary>
        /// 注销
        /// </summary>
        public static void ExitWindows()
        {
            //注销计算机
            ExitWindowsEx(0, 0);
        }

        /// <summary>
        /// 关机
        /// </summary>
        public static void Shutdown()
        {
            //关机
            System.Diagnostics.Process myProcess = new System.Diagnostics.Process();
            myProcess.StartInfo.FileName = "cmd.exe";//启动cmd命令
            myProcess.StartInfo.UseShellExecute = false;//是否使用系统外壳程序启动进程
            myProcess.StartInfo.RedirectStandardInput = true;//是否从流中读取
            myProcess.StartInfo.RedirectStandardOutput = true;//是否写入流
            myProcess.StartInfo.RedirectStandardError = true;//是否将错误信息写入流
            myProcess.StartInfo.CreateNoWindow = true;//是否在新窗口中启动进程
            myProcess.Start();//启动进程
            myProcess.StandardInput.WriteLine("shutdown -s -t 0");//执行关机命令
        }

        /// <summary>
        /// 重启电脑
        /// </summary>
        public static void Restart()
        {
            //重启
            System.Diagnostics.Process myProcess = new System.Diagnostics.Process();
            myProcess.StartInfo.FileName = "cmd.exe";//启动cmd命令
            myProcess.StartInfo.UseShellExecute = false;//是否使用系统外壳程序启动进程
            myProcess.StartInfo.RedirectStandardInput = true;//是否从流中读取
            myProcess.StartInfo.RedirectStandardOutput = true;//是否写入流
            myProcess.StartInfo.RedirectStandardError = true;//是否将错误信息写入流
            myProcess.StartInfo.CreateNoWindow = true;//是否在新窗口中启动进程
            myProcess.Start();//启动进程
            myProcess.StandardInput.WriteLine("shutdown -r -t 0");//执行重启计算机命令
        }


        #endregion


        #region 更改分辨率
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int ChangeDisplaySettings([In] ref DEVMODE lpDevMode, int dwFlags);

        public enum DMDO
        {
            DEFAULT = 0,
            D90 = 1,
            D180 = 2,
            D270 = 3
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        struct DEVMODE
        {
            public const int DM_DISPLAYFREQUENCY = 0x400000;
            public const int DM_PELSWIDTH = 0x80000;
            public const int DM_PELSHEIGHT = 0x100000;
            public const int DM_BITSPERPEL = 262144;
            private const int CCHDEVICENAME = 32;
            private const int CCHFORMNAME = 32;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CCHDEVICENAME)]
            public string dmDeviceName;
            public short dmSpecVersion;
            public short dmDriverVersion;
            public short dmSize;
            public short dmDriverExtra;
            public int dmFields;
            public int dmPositionX;
            public int dmPositionY;
            public DMDO dmDisplayOrientation;
            public int dmDisplayFixedOutput;
            public short dmColor;
            public short dmDuplex;
            public short dmYResolution;
            public short dmTTOption;
            public short dmCollate;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CCHFORMNAME)]
            public string dmFormName;
            public short dmLogPixels;
            public int dmBitsPerPel;
            public int dmPelsWidth;
            public int dmPelsHeight;
            public int dmDisplayFlags;
            public int dmDisplayFrequency;
            public int dmICMMethod;
            public int dmICMIntent;
            public int dmMediaType;
            public int dmDitherType;
            public int dmReserved1;
            public int dmReserved2;
            public int dmPanningWidth;
            public int dmPanningHeight;
        }


        /// <summary>
        /// 更改分辨率
        /// </summary>
        /// <param name="width">宽度</param>
        /// <param name="height">高度</param>
        /// <param name="displayFrequency">刷新频率 60，75，85，100</param>
        public static void ChangeDisplaySettings(int width,int height,int displayFrequency=60)
        {
            long RetVal = 0;
            DEVMODE dm = new DEVMODE();
            dm.dmSize = (short)Marshal.SizeOf(typeof(DEVMODE));
            dm.dmPelsWidth = width;//宽
            dm.dmPelsHeight = height;//高
            dm.dmDisplayFrequency = displayFrequency;//刷新率
            dm.dmFields = DEVMODE.DM_PELSWIDTH | DEVMODE.DM_PELSHEIGHT | DEVMODE.DM_DISPLAYFREQUENCY | DEVMODE.DM_BITSPERPEL;
            RetVal = ChangeDisplaySettings(ref dm, 0);
        }

        #endregion

        /// <summary>
        /// 判断指定端口号是否被占用 占用返回true
        /// </summary>
        /// <param name="port"></param>
        /// <returns></returns>
        internal static bool IsPort(Int32 port)
        {
            bool result = false;
            try
            {
                System.Net.NetworkInformation.IPGlobalProperties iproperties = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties();
                System.Net.IPEndPoint[] ipEndPoints = iproperties.GetActiveTcpListeners();
                foreach (var item in ipEndPoints)
                {
                    if (item.Port == port)
                    {
                        result = true;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
             
            }
            return result;
        }


    }
}
