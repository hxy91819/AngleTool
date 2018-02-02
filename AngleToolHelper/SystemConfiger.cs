using Helpers;
using Microsoft.Win32;
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
        /// 创建日志记录器
        /// </summary>
        private static LogHelper logger = new LogHelper(false);

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

            logger.WriteLog("开始菜单目录path：" + path);

            if (!System.IO.Directory.Exists(path))
            {
                logger.WriteLog("开始菜单目录未找到path：" + path);
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
