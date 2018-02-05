using System;
using System.Collections.Generic;
using System.Text;

namespace AngleToolHelper
{
    public static class CommonConstant
    {
        /// <summary>
        /// Hiwork 临时目录
        /// </summary>
        public static string TEMP_HIWORK_PATH = @"C:\hiwork_temp";

        /// <summary>
        /// Chrome下载地址
        /// </summary>
        public static string CHROME_DOWNLOAD_URL = @"http://p0xytndy5.bkt.clouddn.com/%E5%A4%A9%E4%BD%BF%E6%8E%92%E7%8F%AD%E4%B8%93%E5%B1%9E%20google-chrome%20%E6%B5%8F%E8%A7%88%E5%99%A8.exe";

        /// <summary>
        /// Chrome本地下载路径
        /// </summary>
        public static string CHROME_LOCAL_SAVE_PATH = TEMP_HIWORK_PATH + @"\google-chrome.exe";

        /// <summary>
        /// Hiwork后台网站登录页地址
        /// </summary>
        public static string HIWORK_MCH_LOGIN_PAGE = @"https://mch.hoswork.com/mch/index.html#/wxlogin";
    }
}
