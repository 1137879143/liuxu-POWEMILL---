using JinYiHelp.IniHelp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JYKJTest
{
    [TestClass]
    public class IniTest
    {
       
        [TestMethod]
        public void IniWriteReadTest()
        {
            string _path = Directory.GetCurrentDirectory() + @"\config.ini";

            IniHelper ini = new IniHelper(_path);

            ini.WriteValue("soft", "user", "12345");

            string user= ini.ReadValue("soft","user");
            Assert.AreEqual(user, "12345");

        }
    }
}
