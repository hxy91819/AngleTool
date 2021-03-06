﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;

namespace AngleToolHelper
{
    /// <summary>
    /// 系统配置工具类
    /// </summary>
    public static class SystemConfiger
    {
        /// <summary>
        /// 日志工具
        /// </summary>
        private static log4net.ILog logger = log4net.LogManager.GetLogger("SystemConfiger");

        /// <summary>
        /// 从ClickOnce的开始菜单创建桌面快捷方式
        /// </summary>
        public static void CreateDesktopShortCut()
        {
            RegistryKey folders;
            folders = OpenRegistryPath(Registry.CurrentUser,
                @"/software/microsoft/windows/currentversion/explorer/shell folders");
            string path = folders.GetValue("Programs").ToString();
            if (!path.EndsWith("\\"))
            {
                path += "\\";
            }

            path += @"海鹚科技";


            if (!System.IO.Directory.Exists(path))
            {
                logger.ErrorFormat("没有找到开始菜单:{1}", path);
                return;
            }

            string desktop = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            if (!desktop.EndsWith("\\"))
            {
                desktop += "\\";
            }

            foreach (String file in System.IO.Directory.GetFiles(path))
            {
                System.IO.FileInfo fi = new System.IO.FileInfo(file);
                if (!System.IO.File.Exists(desktop + fi.Name))
                {
                    fi.CopyTo(desktop + fi.Name);

                }
            }
        }

        /// <summary>
        /// 获取系统注册路径
        /// </summary>
        /// <param name="root"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        private static RegistryKey OpenRegistryPath(RegistryKey root, string s)
        {
            s = s.Remove(0, 1) + @"/";
            while (s.IndexOf(@"/") != -1)
            {
                root = root.OpenSubKey(s.Substring(0, s.IndexOf(@"/")));
                s = s.Remove(0, s.IndexOf(@"/") + 1);
            }
            return root;
        }
    }
}
