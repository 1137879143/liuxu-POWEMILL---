using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JinYiHelp.ObjectHelp;

namespace JYKJTest
{
    [TestClass]
   public class ObjectTest
    {
        [TestMethod]
        public void IsNumericTest()
        {
           bool is_bool= ObjectConversion.IsNumeric("456");
            Assert.AreEqual(is_bool,true);
        }

        [TestMethod]
        public void IsDoubleTest()
        {
            bool is_bool = ObjectConversion.IsDouble("456.2");
            Assert.AreEqual(is_bool, true);
        }

        [TestMethod]
        public void IsDateTimeTest()
        {
            DateTime dt = ObjectConversion.ObjectToDateTime("2019-05-15");
            Assert.AreEqual(dt.Year, 2019);
        }

    }
}
