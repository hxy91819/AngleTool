using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;

namespace AngleToolHelper
{
    /// <summary>
    /// 浏览器配置工具类
    /// </summary>
    public static class BrowerConfiger
    {
        /// <summary>
        /// 日志工具
        /// </summary>
        private static log4net.ILog logger = log4net.LogManager.GetLogger("BrowerConfiger");

        public const string DEFAULT_BROWSER_OK = "默认浏览器设置成功";

        /// <summary>
        /// 判断是否安装了Chrome
        /// </summary>
        /// <returns></returns>
        public static Boolean hasChromeInstalled()
        {
            try
            {
                RegistryKey rk = Registry.CurrentUser;
                RegistryKey software = rk.OpenSubKey("Software");
                string[] subkeys = software.GetSubKeyNames();
                foreach (string subkey in subkeys)
                {
                    if (subkey.Equals("Google"))
                    {
                        RegistryKey google = software.OpenSubKey("Google");
                        string[] googleSubKeys = google.GetSubKeyNames();
                        foreach (var googleSubKey in googleSubKeys)
                        {
                            if (googleSubKey.Equals("Chrome"))
                            {
                                RegistryKey chrome = google.OpenSubKey("Chrome");
                                RegistryKey blbeacon = chrome.OpenSubKey("BLBeacon");
                                if (!blbeacon.GetValue("version").Equals(string.Empty))
                                {
                                    // 版本字段不为空，则认为已经安装
                                    return true;
                                }
                            }
                        }
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                logger.Error("hasChromeInstalled==>发生异常：", e);
                return false;
            }

            return false;
        }

        /// <summary>
        /// 设置默认浏览器
        /// </summary>
        public static string setDefaultBrower()
        {
            /*
            if (defalutBrowerPath.Contains("chrome.exe") || defalutBrowerPath.Equals(string.Empty))
            {
                logInfo.Info("默认浏览器已经是Chrome");
                // 如果默认默认浏览器是谷歌浏览器，则直接退出
                return "未设置：默认浏览器已经是Chrome";
            }
            */

            string chromeInstallPath = getChromeInstallPath();
            if (chromeInstallPath.Equals(string.Empty))
            {
                logger.Error("获取Chrome安装路径失败，可能未安装Chrome");
                // 如果无法获取谷歌浏览器安装地址，直接退出
                return "未设置：" + "获取Chrome安装路径失败，可能未安装Chrome";
            }

            // 设置谷歌浏览器为默认浏览器
            StringBuilder sb = new StringBuilder();


            try
            {
                RegistryKey root = Registry.ClassesRoot;
                RegistryKey httpCommand = root.OpenSubKey(@"http\shell\open\command\", true);
                if(httpCommand == null)
                {
                    logger.Info("httpCommand未配置");
                } else
                {
                    httpCommand.SetValue(string.Empty, getDefaultBrowerValue(@"http\shell\open\command\", chromeInstallPath, false));
                }

                RegistryKey httpsCommand = root.OpenSubKey(@"https\shell\open\command\", true);
                if(httpsCommand == null)
                {
                    logger.Info("httpsCommand未配置");
                } else
                {
                    httpsCommand.SetValue(string.Empty, getDefaultBrowerValue(@"https\shell\open\command\", chromeInstallPath, false));
                }

                RegistryKey htmlFilecommand = root.OpenSubKey(@"htmlfile\shell\open\command\", true);
                if(htmlFilecommand == null)
                {
                    logger.Info("htmlFilecommand未配置");
                } else
                {
                    htmlFilecommand.SetValue(string.Empty, getDefaultBrowerValue(@"htmlfile\shell\open\command\", chromeInstallPath, false));
                }
            }
            catch (Exception e)
            {
                logger.Error("setDefaultBrower==>设置默认浏览器发生异常：", e);
                return "发生异常";
            }

            return DEFAULT_BROWSER_OK;
        }

        /// <summary>
        /// 根据对应的注册表key，生成设置默认浏览器的value
        /// </summary>
        /// <param name="rootSubKey"></param>
        /// <param name="browerInstallPath"></param>
        /// <returns></returns>
        private static string getDefaultBrowerValue(string rootSubKey, string browerInstallPath)
        {
            // 默认保留原参数
            return getDefaultBrowerValue(rootSubKey, browerInstallPath, true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rootSubKey"></param>
        /// <param name="browerInstallPath"></param>
        /// <param name="keepLastParameters">是否保留原参数</param>
        /// <returns></returns>
        private static string getDefaultBrowerValue(string rootSubKey, string browerInstallPath, Boolean keepLastParameters)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                RegistryKey root = Registry.ClassesRoot;
                RegistryKey command = root.OpenSubKey(rootSubKey);
                string defaultBrowerPath = command.GetValue(string.Empty).ToString();
                string[] paths = defaultBrowerPath.Split('"');

                if (keepLastParameters)
                {
                    for (int i = 0; i < paths.Length; i++)
                    {
                        if (i == 0)
                        {
                            continue;
                        }
                        else if (i == 1)
                        {
                            sb.Append("\"").Append(browerInstallPath);
                        }
                        else
                        {
                            sb.Append("\"").Append(paths[i]);
                        }
                    }
                }
                else
                {
                    // 使用chrome标准的参数配置替换原配置
                    sb.Append("\"").Append(browerInstallPath).Append("\" -- \"%1\"");
                }
            }
            catch (Exception e)
            {
                logger.Error("getDefaultBrowerValue==>发生异常：e：", e);
                return string.Empty;
            }
            return sb.ToString();
        }

        public static string getDefaultBrowerPath()
        {
            string defaultBrowerPath = string.Empty;
            try
            {
                RegistryKey root = Registry.ClassesRoot;
                // 如果对应的key不存在，则RegistryKey应该为null

                // 尝试获取 http 节点下的默认浏览器配置
                RegistryKey httpCommand = root.OpenSubKey(@"http\shell\open\command\");
                if (httpCommand != null)
                {
                    return httpCommand.GetValue(string.Empty).ToString();
                }
                
                // 尝试获取 https 节点下的默认浏览器
                RegistryKey httpsCommand = root.OpenSubKey(@"https\shell\open\command\");
                if (httpsCommand != null)
                {
                    return httpsCommand.GetValue(string.Empty).ToString();
                }

                // 尝试获取 htmlfile 节点下的默认浏览器
                RegistryKey htmlFileCommand = root.OpenSubKey(@"https\shell\open\command\");
                if (htmlFileCommand != null)
                {
                    return httpCommand.GetValue(string.Empty).ToString();
                }

            }
            catch (Exception e)
            {
                logger.Error("getDefaultBrowerPath==>获取默认浏览器发生异常：",e);
                return string.Empty;
            }

            return string.Empty;
        }

        /// <summary>
        /// 获取chrome的安装路径
        /// </summary>
        /// <returns></returns>
        public static string getChromeInstallPath()
        {
            string chromeInstallPath = "";

            try
            {
                // 默认从LocalMachine中获取
                string softName = "chrome";
                string strKeyName = string.Empty;
                string softPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\";
                string subKey = softPath + softName + ".exe";
                RegistryKey regKey = Registry.LocalMachine;
                RegistryKey regSubKey = regKey.OpenSubKey(subKey, false);

                if (regSubKey == null)
                {
                    logger.Info("getChromeInstallPath==>从LocalMachine读取到的注册表键为null，subKey：" + subKey + "；尝试从CurrentUser中获取默认浏览器");

                    // 默认从LocalMachine中获取失败时，尝试从CurrentUser中获取
                    regKey = Registry.CurrentUser;
                    softPath = @"Software\Microsoft\Windows\CurrentVersion\App Paths\";
                    subKey = softPath + softName + ".exe";
                    regSubKey = regKey.OpenSubKey(subKey, false);
                    if (regSubKey == null)
                    {
                        logger.Info("getChromeInstallPath==>从CurrentUser读取到的注册表键为null，subKey：" + subKey);
                        return string.Empty;
                    }

                }

                object objResult = regSubKey.GetValue(strKeyName);
                RegistryValueKind regValueKind = regSubKey.GetValueKind(strKeyName);
                if (regValueKind == RegistryValueKind.String)
                {
                    chromeInstallPath = objResult.ToString();
                }
            }
            catch (Exception e)
            {
                logger.Error("getChromeInstallPath==>获取谷歌安装路径失败，可能是未安装谷歌浏览器：",e);
                return string.Empty;
            }

            return chromeInstallPath;
        }

    }
}
