using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JinYiHelp.JsHelp;

namespace JYKJTest
{
    [TestClass]
    public class JsTest
    {
        [TestMethod]
        public void EvalMethodTest()
        {
            string js_str = "function js_add(str1,str2){ return str1 + str2;}";

            JsHelper js = new JsHelper();
            string para = "'bbs','125'";
            string result = js.EvalMethod(js_str, "js_add", para);
            Assert.AreEqual(result, "bbs125");

        }

        [TestMethod]
        public void V8Test()
        {
            string js_str = "function js_add(str1,str2){ return str1 + str2;}";
            string para = "'bbs','125'";

            string result = JsHelper.V8Method(js_str, "js_add", para);
            Assert.AreEqual(result, "bbs125");

        }

    }
}
