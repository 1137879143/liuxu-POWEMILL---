using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace JinYiHelp.EasyHTTPClient
{
    public class EasyHTTP
    {

        #region 预定义方变量
        //默认的编码
        private Encoding _encoding = Encoding.Default;
        //Post数据编码
        private Encoding _postencoding = Encoding.Default;
        //HttpWebRequest对象用来发起请求
        private HttpClient _client = null;

        HttpClientHandler _handler = null;
        //设置head头数据
        private HttpRequestMessage _requestHeads = null;
        //这些头数据 不能加在head 中 得加在content.head中
        private static  List<string> _list = new List<string>() { "Content-Disposition".ToLower(), "Content-Encoding".ToLower(), "Content-Language".ToLower(), "Content-Location".ToLower(), "Content-MD5".ToLower(), "Content-Range".ToLower(), "Expires".ToLower(), "LastModified".ToLower() };

        public async Task<HttpResult> GetHtml(HttpItem item)
        {
            string html = string.Empty;
            try
            {

                SetRequest(item);

                try
                {

                    var response = await _client.SendAsync(_requestHeads);

                    if (response.IsSuccessStatusCode)
                    {
                        var result = new HttpResult();
                        result.StatusCode = response.StatusCode;


                        #region base
                        //获取StatusCode

                        //获取StatusDescription
                        result.IsSuccessStatusCode = response.IsSuccessStatusCode;
                        //获取Headers
                        result.Header = response.Content.Headers;


                        //获取set-cookie
                        if (response.Headers.Contains("Set-Cookie"))
                        {
                            var cookies = response.Headers.GetValues("Set-Cookie");
                            string reCook = string.Empty;

                            if (item.AutoHanderCookie)
                            {
                                if(cookies!=null) reCook = CookieHelper.GetSmallCookie(cookies);

                            }
                            else
                            {
                                 reCook = string.Join(";", cookies);
                            }


                            if (item.AutoFixCookie)
                            {
                                result.Cookie = CookieHelper.UpdateMergeCookie(item.Cookie, reCook);
                            }
                            else
                            {
                                result.Cookie = reCook;
                            }



                        }


                        #endregion
                        //获取跳转地址
                        if (response.Headers.Location != null)
                        {
                            result.RedirectUrl = response.Headers.Location.ToString();
                        }

                        if (item.ResultType == ResultType.Byte)
                        {
                            result.ResultByte = await response.Content.ReadAsByteArrayAsync();
                        }
                        else
                        {
                            using (Stream myResponseStream = await response.Content.ReadAsStreamAsync())
                            {
                                using (StreamReader myStreamReader = new StreamReader(myResponseStream, _encoding))
                                {
                                    result.Html = myStreamReader.ReadToEnd();

                                }

                            }


                        }



                        return result;


                    }



                    return new HttpResult() { Cookie = string.Empty, Header = null, Html = "", StatusCode = response.StatusCode, StatusDescription = "服务器响应：" + response.StatusCode };


                }
                catch (Exception ex)
                {
                    return new HttpResult() { Cookie = string.Empty, Header = null, Html = ex.Message, StatusDescription = "请求时出错：" + ex.Message };
                }

               

            }
            catch (Exception ex)
            {

                //配置参数时出错
                return new HttpResult() { Cookie = string.Empty, Header = null, Html = ex.Message, StatusDescription = "配置参数时出错：" + ex.Message };
            }
        }




        /// <summary>
        /// 为请求准备参数
        /// </summary>
        ///<param name="item">参数列表</param>
        private void SetRequest(HttpItem item)
        {

            try
            {
                _handler = new HttpClientHandler();//调用代理的时候 需要

                if (item.URL.StartsWith("https")) System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;

                _requestHeads = new HttpRequestMessage(item.Method, item.URL);


                //设置压缩 解压 方式
                _handler.AutomaticDecompression = item.Decompression;

                //Authorization 认证
                if (!string.IsNullOrEmpty(item.Authorization))
                {
                    _requestHeads.Headers.Authorization = new AuthenticationHeaderValue("Basic", item.Authorization);
                }

                //设置Post数据
                if (item.Method != HttpMethod.Get)
                {
                    SetPostData(item);
                }

                //设置Header参数
                if (item.Header != null && item.Header.Count > 0)
                { 
                    foreach (string key in item.Header.AllKeys)
                    {
                        if (_list.Contains(key.ToLower()))//这些头不能加在请求头里面 得加在 content.head 里面
                        {
                            if (_requestHeads.Content != null)
                            {
                                _requestHeads.Content.Headers.TryAddWithoutValidation(key, item.Header[key]);
                            }

                          
                        }
                        else
                        {

                            _requestHeads.Headers.Add(key, item.Header[key]);
                        }

                    }
                }
                // 设置代理
                SetProxy(item);
                if (item.ProtocolVersion != null) _requestHeads.Version = item.ProtocolVersion;


                if (!string.IsNullOrWhiteSpace(item.Host))
                {
                    _requestHeads.Headers.Host = item.Host;
                }

                //Accept
                //_requestHeads.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(item.Accept));

                _requestHeads.Headers.Add("Accept", item.Accept.Trim());

                if (item.KeepAlive)
                {
                    _requestHeads.Headers.ConnectionClose = false;
                }
                else
                {
                    _requestHeads.Headers.ConnectionClose = true;//非持久连接
                }



                //UserAgent客户端的访问类型，包括浏览器版本和操作系统信息
                _requestHeads.Headers.Add("User-Agent", item.UserAgent);
                // 编码

                if (item.Encoding != null)
                {
                    _encoding = item.Encoding;
                }
              
                //设置安全凭证
                _handler.Credentials = item.ICredentials;
                //设置Cookie
                SetCookie(item);
                //来源地址
               

                if (!string.IsNullOrEmpty(item.Referer)) _requestHeads.Headers.Referrer = new Uri(item.Referer);


                //是否执行跳转功能
                _handler.AllowAutoRedirect = item.Allowautoredirect;
                if (item.MaximumAutomaticRedirections > 0)
                {
                    _handler.MaxAutomaticRedirections = item.MaximumAutomaticRedirections;
                }
               

               
                //最后设置 clinet
                _client = new HttpClient(_handler);
                _client.Timeout = TimeSpan.FromSeconds(item.Timeout);//秒


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }
        }


      

        /// <summary>
        /// 设置Cookie
        /// </summary>
        /// <param name="item">Http参数</param>
        private void SetCookie(HttpItem item)
        {
            if (!string.IsNullOrEmpty(item.Cookie))
            {
                _handler.UseCookies = false;
                _requestHeads.Headers.Add("Cookie", item.Cookie);
            }

        }
        /// <summary>
        /// 设置Post数据
        /// </summary>
        /// <param name="item">Http参数</param>
        private void SetPostData(HttpItem item)
        {

            //验证在得到结果时是否有传入数据
           
                if (item.PostEncoding != null)
                {
                    _postencoding = item.PostEncoding;
                }
                byte[] buffer = null;
                //写入Byte类型
                if (item.PostDataType == PostDataType.Byte && item.PostdataByte != null && item.PostdataByte.Length > 0)
                {
                    //验证在得到结果时是否有传入数据
                    buffer = item.PostdataByte;
                }//写入文件
                else if (item.PostDataType == PostDataType.FilePath && !string.IsNullOrWhiteSpace(item.Postdata))
                {
                    StreamReader r = new StreamReader(item.Postdata, _postencoding);
                    buffer = _postencoding.GetBytes(r.ReadToEnd());
                    r.Close();
                } //写入字符串
                else if (!string.IsNullOrWhiteSpace(item.Postdata))
                {
                    buffer = _postencoding.GetBytes(item.Postdata);
                }
                if (buffer != null)
                {
                   

                    _requestHeads.Content = new ByteArrayContent(buffer, 0, buffer.Length);
                    _requestHeads.Content.Headers.Add("Content-Length", buffer.Length.ToString());

            }
              

                if (_requestHeads.Content != null)
                { 
                    _requestHeads.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(item.ContentType);
                }

              
            
        }
        /// <summary>
        /// 设置代理
        /// </summary>
        /// <param name="item">参数对象</param>
        private void SetProxy(HttpItem item)
        {
            bool isIeProxy = false;
            if (!string.IsNullOrWhiteSpace(item.ProxyIp))
            {
                isIeProxy = item.ProxyIp.ToLower().Contains("ieproxy");
            }
            if (!string.IsNullOrWhiteSpace(item.ProxyIp) && !isIeProxy)
            {
                //设置代理服务器
                if (item.ProxyIp.Contains(":"))
                {
                    string[] plist = item.ProxyIp.Split(':');
                    WebProxy myProxy = new WebProxy(plist[0].Trim(), Convert.ToInt32(plist[1].Trim()));
                    //建议连接
                    myProxy.Credentials = new NetworkCredential(item.ProxyUserName, item.ProxyPwd);
                    //给当前请求对象
                    _handler.UseProxy = true;
                    _handler.Proxy = myProxy;
                }
                else
                {
                    WebProxy myProxy = new WebProxy(item.ProxyIp, false);
                    //建议连接
                    myProxy.Credentials = new NetworkCredential(item.ProxyUserName, item.ProxyPwd);
                    //给当前请求对象
                    _handler.UseProxy = true;
                    _handler.Proxy = myProxy;
                }
            }
            else if (isIeProxy)
            {
                //设置为IE代理
                _handler.UseProxy = true;// defaultProxy 	
                                         // 使用默认（系统）代理时，获取或设置要提交到默认代理服务器进行身份验证的凭据。 只有在 UseProxy 设置为 true 且 Proxy 设置为 null 时才使用默认代理。
            }
            else
            {
                _handler.Proxy = item.WebProxy;
            }
        }



       

        #endregion end class

        /// <summary>
        ///释放资源
        /// </summary>
        ~EasyHTTP()
        {

            if (_handler != null)
            {
                _handler.Dispose();
            }

            if (_requestHeads != null)
            {
                _requestHeads.Dispose();
            }


            if (_client != null)
            {
                _client.Dispose();
            }

        }

    }
}
