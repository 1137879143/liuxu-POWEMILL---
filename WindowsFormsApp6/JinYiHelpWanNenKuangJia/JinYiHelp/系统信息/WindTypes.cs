using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinYiHelp.SystemHelp
{
    class WindTypes
    {

        /// <summary>
        /// 判断操作系统是否为Windows98
        /// </summary>
        public bool IsWindows98
        {
            get
            {
                return (Environment.OSVersion.Platform == PlatformID.Win32Windows) && (Environment.OSVersion.Version.Minor == 10) && (Environment.OSVersion.Version.Revision.ToString() != "2222A");
            }
        }
        /// <summary>
        /// 判断操作系统是否为Windows98第二版
        /// </summary>
        public bool IsWindows98Second
        {
            get
            {
                return (Environment.OSVersion.Platform == PlatformID.Win32Windows) && (Environment.OSVersion.Version.Minor == 10) && (Environment.OSVersion.Version.Revision.ToString() == "2222A");
            }
        }

        /// <summary>
        /// 判断操作系统是否为Windows2000
        /// </summary>
        public bool IsWindows2000
        {
            get
            {
                return (Environment.OSVersion.Platform == PlatformID.Win32NT) && (Environment.OSVersion.Version.Major == 5) && (Environment.OSVersion.Version.Minor == 0);
            }
        }
        /// <summary>
        /// 判断操作系统是否为WindowsXP
        /// </summary>
        public bool IsWindowsXP
        {
            get
            {
                return (Environment.OSVersion.Platform == PlatformID.Win32NT) && (Environment.OSVersion.Version.Major == 5) && (Environment.OSVersion.Version.Minor == 1);
            }
        }

        /// <summary>
        /// 判断操作系统是否为Windows2003
        /// </summary>
        public bool IsWindows2003
        {
            get
            {
                return (Environment.OSVersion.Platform == PlatformID.Win32NT) && (Environment.OSVersion.Version.Major == 5) && (Environment.OSVersion.Version.Minor == 2);
            }
        }
        /// <summary>
        /// 判断操作系统是否为WindowsVista
        /// </summary>
        public bool IsWindowsVista
        {
            get
            {
                return (Environment.OSVersion.Platform == PlatformID.Win32NT) && (Environment.OSVersion.Version.Major == 6) && (Environment.OSVersion.Version.Minor == 0);
            }
        }
        /// <summary>
        /// 判断操作系统是否为Windows7
        /// </summary>
        public bool IsWindows7
        {
            get
            {
                return (Environment.OSVersion.Platform == PlatformID.Win32NT) && (Environment.OSVersion.Version.Major == 6) && (Environment.OSVersion.Version.Minor == 1);
            }
        }

        /// <summary>
        /// 判断操作系统是否为Unix
        /// </summary>
        public bool IsUnix
        {
            get
            {
                return Environment.OSVersion.Platform == PlatformID.Unix;
            }
        }

        /// <summary>
        /// 是否是64位 false 为32位
        /// </summary>
        /// <returns></returns>
        public bool Is64System()
        {
            bool type;
            type = Environment.Is64BitOperatingSystem;
            return type;
        }

       

    }
}
