using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinYiHelp.EasyHTTPClient
{
   public class Html_info
    {
        public bool Is_bool { get; set; }//成功为true 
        public string Html { get; set; }//成功后的 返回数据
        public string J_code { get; set; }//其它数据
        public byte[] Img { get; set; }//图片数据
        public Html_info()
        {
            this.Is_bool = false;
            this.Html = string.Empty;
            this.J_code = string.Empty;
            this.Img = null;
        }

    }
}
