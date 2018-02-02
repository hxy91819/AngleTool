using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Runtime.InteropServices;
using System.IO;

namespace Helpers
{
    /// <summary>
    /// ConfigSettings
    /// C#最简易的配置文件读写类
    /// 
    /// 修改纪录
    /// 
    ///		2015-02-13 版本：1.0 HXY 创建。
    /// 
    /// 版本：1.1
    /// 
    /// <author>
    ///		<name>HXY</name>
    ///		<date>2015-02-13</date>
    /// </author> 
    /// </summary>
    public class ConfigHelper
    {
        #region 作废，不便于调试的exe.config类配置文件
        ///// <summary>
        ///// 写配置
        ///// </summary>
        ///// <param name="key"></param>
        ///// <param name="value"></param>
        //public static void SetValue(string key, string value)
        //{
        //    //增加的内容写在appSettings段下 <add key="RegCode" value="0"/>  
        //    System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        //    if (config.AppSettings.Settings[key] == null)
        //    {
        //        config.AppSettings.Settings.Add(key, value);
        //    }
        //    else
        //    {
        //        config.AppSettings.Settings[key].Value = value;
        //    }
        //    config.Save(ConfigurationSaveMode.Modified);
        //    ConfigurationManager.RefreshSection("appSettings");//重新加载新的配置文件   
        //}

        ///// <summary>
        ///// 读配置
        ///// </summary>
        ///// <param name="key"></param>
        ///// <returns></returns>
        //public static string GetValue(string key)
        //{
        //    System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        //    if (config.AppSettings.Settings[key] == null)
        //        return "";
        //    else
        //        return config.AppSettings.Settings[key].Value;
        //}   
        #endregion

        /// <summary>
        /// 文件路径
        /// </summary>
        public string iniPath;
        /// <summary>
        /// 构造方法，默认写到ClientConfig.ini里
        /// </summary>
        public ConfigHelper()
        {
            iniPath = System.Environment.CurrentDirectory + "//ClientConfig.ini";
        }
        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="fileName">文件名</param>
        public ConfigHelper(string fileName)
        {
            iniPath = System.Environment.CurrentDirectory + "//" + fileName;
        }
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        /// <summary>
        /// 写入INI文件
        /// </summary>
        /// <param name="Section">项目名称(如 [TypeName] )</param>
        /// <param name="Key">键</param>
        /// <param name="Value">值</param>
        public void IniWriteValue(string Section, string Key, string Value)
        {
            Value = PackValue(Value);
            WritePrivateProfileString(Section, Key, Value, this.iniPath);
        }
        /// <summary>
        /// 读出INI文件
        /// </summary>
        /// <param name="Section">项目名称(如 [TypeName] )</param>
        /// <param name="Key">键</param>
        public string IniReadValue(string Section, string Key)
        {
            StringBuilder temp = new StringBuilder(500);
            int i = GetPrivateProfileString(Section, Key, "", temp, 500, this.iniPath);

            string value = temp.ToString();
            value = unPackValue(value);
            return value;
        }
        /// <summary>
        /// 验证文件是否存在
        /// </summary>
        /// <returns>布尔值</returns>
        public bool ExistINIFile()
        {
            return File.Exists(iniPath);
        }

        /// <summary>
        /// 对传入的字段加包，避免无法读取空格，回车
        /// </summary>
        /// <param name="inputValue"></param>
        /// <returns></returns>
        private string PackValue(string inputValue)
        {
            //替换value中的回车符
            inputValue = inputValue.Replace("\n","<br />");
            return "\"" + inputValue + "\"";
        }
        /// <summary>
        /// 解包
        /// </summary>
        /// <param name="inputValue"></param>
        /// <returns></returns>
        private string unPackValue(string inputValue)
        {
            //还原里面的回车符
            inputValue = inputValue.Replace("<br />","\n");
            return inputValue;
        }
    }
}
