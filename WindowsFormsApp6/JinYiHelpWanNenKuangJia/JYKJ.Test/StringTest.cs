using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JinYiHelp.StringHelp;

namespace JYKJTest
{
    [TestClass]
    public class StringTest
    {
        string html = "我是中间文本";

        [TestMethod]
        public void BetweenTest()
        {
           
           string str= html.Between("我", "本");

            Assert.AreEqual(str, "是中间文");
        }

        [TestMethod]
        public void GetRightTest()
        {
            string str = html.GetRight("中间");
            Assert.AreEqual(str,"文本");
        }

        [TestMethod]
        public void GetLeftTest()
        {
            string str = html.GetLeft("中");
            Assert.AreEqual(str, "我是");
        }

        [TestMethod]
        public void RegMatchTest()
        {
            string text = "a link='www.125.la'>";

            string reg_str = "link='(?<url>.*?)'";//c# 正则标签 ?<标签>

            string str=  StringHelper.RegMatch(reg_str,text,"url");

            Assert.AreEqual(str, "www.125.la");


        }

        [TestMethod]
        public void IsJsonTest()
        {
            string js_str = "{nub:1}";//只会判断 是否是 {} 或者 []
            bool is_bool= StringHelper.IsJson(js_str);

            Assert.AreEqual(is_bool, true);

        }

        [TestMethod]
        public void IsNullTest()
        {
            string str = "   ";
            bool is_bool = StringHelper.IsNull(str);
            Assert.AreEqual(is_bool, true);

        }



        [TestMethod]
        public void IsUpperTest()
        {
            string str = "AABB";
            bool is_bool= StringHelper.IsUpper(str);
            Assert.AreEqual(is_bool,true);

        }

        [TestMethod]
        public void IsLowerTest()
        {
            string str = "bbs";
            bool is_bool=StringHelper.IsLower(str);
            Assert.AreEqual(is_bool, true);
        }

        [TestMethod]
        public void IsIntTest()
        {
            string str = "12453";
            bool is_bool = StringHelper.IsInt(str);
            Assert.AreEqual(is_bool, true);

        }

    }
}
