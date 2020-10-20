using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JinYiHelp.TimeHelp;

namespace JYKJTest
{
    [TestClass]
    public class TimeTest
    {
        [TestMethod]
        public void ConvertToTimeStampTest()
        {
            DateTime now_time = new DateTime(2019,5,20);
            long ltime= TimeHelper.ConvertToTimeStamp(now_time);

            Assert.AreEqual(ltime, 1558281600000);
        }

        [TestMethod]
        public void DateDiffTest()
        {
            DateTime old_time = new DateTime(2019, 5, 20, 0, 0, 0);
            DateTime now_time = new DateTime(2019, 5, 20, 12, 0, 0);
            string str = TimeHelper.DateDiff(old_time, now_time);

            Assert.AreEqual(str, "12小时前");
        }


    }
}
