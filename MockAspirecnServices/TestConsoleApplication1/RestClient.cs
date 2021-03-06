﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace TestConsoleApplication1
{
    public class RestClient
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="baseUrl"></param>
        public RestClient(string baseUri)
        {
            this.BaseUri = baseUri;
        }

        /// <summary>
        /// 基地址
        /// </summary>
        private string BaseUri;

        /// <summary>
        /// Post调用
        /// </summary>
        /// <param name="data"></param>
        /// <param name="uri"></param>
        /// <returns></returns>
        public string Post(string data, string uri)
        {
            //Web访问对象
            string serviceUrl = string.Format("{0}/{1}", this.BaseUri, uri);
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(serviceUrl);

            //转成网络流
            byte[] buf = UnicodeEncoding.UTF8.GetBytes(data);

            //设置
            myRequest.Method = "POST";
            myRequest.ContentLength = buf.Length;
            myRequest.ContentType = "text/html";

            // 发送请求
            Stream newStream = myRequest.GetRequestStream();
            newStream.Write(buf, 0, buf.Length);
            newStream.Close();

            // 获得接口返回值
            HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
            StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);

            string ReturnXml = HttpUtility.HtmlDecode(reader.ReadToEnd());

            reader.Close();
            myResponse.Close();

            return ReturnXml;
        }

        /// <summary>
        /// Get调用
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        public string Get(string uri)
        {
            //Web访问对象
            string serviceUrl = string.Format("{0}/{1}", this.BaseUri, uri);
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(serviceUrl);

            // 获得接口返回值
            HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
            StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);

            string ReturnXml = HttpUtility.UrlDecode(reader.ReadToEnd());

            reader.Close();
            myResponse.Close();

            return ReturnXml;
        }
    }
}
