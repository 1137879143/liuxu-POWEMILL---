using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using v8sharp;

namespace JinYiHelp.JsHelp
{
   public class JsHelper
    {

        private static readonly object Lock_v8 = new object();//V8 需要加锁

        /// <summary>
        /// 执行js Eval方法 支持多线程
        /// </summary>
        /// <param name="reString">Js代码</param>
        /// <param name="para">方法名称</param>
        /// <param name="MethodName">参数字符串(使用逗号分隔)</param>
        public string EvalMethod(string reString, string MethodName, string para="")
        {
            try
            {
                Type obj = Type.GetTypeFromProgID("ScriptControl");
                if (obj == null) return "";
                object ScriptControl = Activator.CreateInstance(obj);
                obj.InvokeMember("Language", BindingFlags.SetProperty, null, ScriptControl, new object[] { "JavaScript" });
                obj.InvokeMember("AddCode", BindingFlags.InvokeMethod, null, ScriptControl, new object[] { reString });
                return obj.InvokeMember("Eval", BindingFlags.InvokeMethod, null, ScriptControl, new object[] { string.Format("{0}({1})", MethodName, para) }).ToString();//执行结果 

            }
            catch (Exception ex)
            {
                string ErrorInfo = string.Format("执行JS出现错误:   \r\n 错误描述: {0} \r\n 错误原因: {1} \r\n 错误来源:{2}", ex.Message, ex.InnerException.Message, ex.InnerException.Source);//异常信息
                return ErrorInfo; //  ErrorInfo  异常信息
            }
        }

        /// <summary>
        /// V8 执行js 不支持多线程 所以得加锁(内部已加锁无需重复加)
        /// </summary>
        /// <param name="reString">加载的js文本</param>
        /// <param name="MethodName">方法名称</param>
        /// <param name="para">参数字符串(使用逗号分隔)</param>
        /// <returns></returns>
        public static string V8Method(string reString, string MethodName, string para)
        {
            lock (Lock_v8)
            {
                V8Engine engine = V8Engine.Create();//创建V8对象
                V8Script script = engine.Compile(reString);//编译
                try
                {
                    engine.Execute(script);//将编译的脚本加载到V8引擎中
                    return engine.Execute(string.Format("{0}({1})", MethodName, para)).ToString();//执行结果
                }
                catch (Exception ex)
                {
                    return ex.Message;//异常信息
                }
            }


        }



    }
}
