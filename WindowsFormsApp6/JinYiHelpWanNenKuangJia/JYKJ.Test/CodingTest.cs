using JinYiHelp.CodingHelp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JYKJTest
{
    [TestClass]
   public class CodingTest
    {
      [TestMethod]
      public  void ByteStrinTest()
      {

            byte[] bin=  CodingHelper.StringToByte("bbs");//98,98,115

            string str = CodingHelper.ByteToString(bin);

            Assert.AreEqual(str, "bbs");

      }

        [TestMethod]
        public void StringToUnicodeTest()
        {

           string unicode= CodingHelper.StringToUnicode("精易");
            Assert.AreEqual(unicode, @"\u7CBE\u6613");

        }

        [TestMethod]
        public void UnicodeToStringTest()
        {
            string str = CodingHelper.UnicodeToString(@"\u7CBE\u6613");
            Assert.AreEqual(str, "精易");
        }

       

    }
}
