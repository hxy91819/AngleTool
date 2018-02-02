using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;

namespace Helpers
{
    /// <summary>
    /// HTTP请求工具类
    /// </summary>
    public class HttpHelper
    {
        /// <summary>
        /// 发起post请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static string Post(string url, string param)
        {
            string strURL = url;
            System.Net.HttpWebRequest request;
            request = (System.Net.HttpWebRequest)WebRequest.Create(strURL);
            request.Method = "POST";
            request.ContentType = "application/xml;charset=UTF-8";
            string paraUrlCoded = param;
            byte[] payload;
            payload = System.Text.Encoding.UTF8.GetBytes(paraUrlCoded);
            request.ContentLength = payload.Length;
            Stream writer = request.GetRequestStream();
            writer.Write(payload, 0, payload.Length);
            writer.Close();
            System.Net.HttpWebResponse response;
            response = (System.Net.HttpWebResponse)request.GetResponse();
            System.IO.Stream s;
            s = response.GetResponseStream();
            string StrDate = "";
            string strValue = "";
            StreamReader Reader = new StreamReader(s, Encoding.UTF8);
            while ((StrDate = Reader.ReadLine()) != null)
            {
                strValue += StrDate + "\r\n";
            }
            return strValue;
        }

        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="localFile"></param>
        /// <param name="webFile"></param>
        /// <returns></returns>
        public static bool DownloadFile(string localFile, string webFile)
        {
            bool flag = false;
            long SPosition = 0;
            FileStream FStream;
            if (File.Exists(localFile))
            {
                File.Delete(localFile);
                FStream = File.OpenWrite(localFile);
                SPosition = FStream.Length;
                FStream.Seek(SPosition, SeekOrigin.Current);
            }
            else
            {
                FStream = new FileStream(localFile, FileMode.Create);
                SPosition = 0;
            }
            try
            {
                HttpWebRequest myRequest = (HttpWebRequest)HttpWebRequest.Create(webFile);
                if (SPosition > 0)
                    myRequest.AddRange((int)SPosition);
                Stream myStream = myRequest.GetResponse().GetResponseStream();
                byte[] btContent = new byte[512];
                int intSize = 0;
                intSize = myStream.Read(btContent, 0, 512);
                while (intSize > 0)
                {
                    FStream.Write(btContent, 0, intSize);
                    intSize = myStream.Read(btContent, 0, 512);
                }
                FStream.Close();
                myStream.Close();
                flag = true;
            }
            catch (Exception)
            {
                FStream.Close();
                flag = false;
            }
            return flag;
        }

    }
}
