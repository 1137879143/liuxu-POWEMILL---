using JinYiHelp.IpHelp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JYKJTest
{
    [TestClass]
   public class IpTest
    {
       

        [TestMethod]
        public void IsValidIPTest()
        {
            bool is_bool = IpHelper.IsValidIP("127.0.0.1");
            Assert.AreEqual(is_bool, true);
        }

        [TestMethod]
        public void IsValidProxyTeST()
        {
            bool is_bool = IpHelper.IsValidProxy("127.0.0.1:8888");
            Assert.AreEqual(is_bool, true);
        }


    }
}
