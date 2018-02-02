using Helpers;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AngleToolHelper
{
    /// <summary>
    /// Hosts修改工具类
    /// </summary>
    public static class HostModifier
    {

        /// <summary>
        /// 创建日志记录器
        /// </summary>
        private static LogHelper logger = new LogHelper(false);

        /// <summary>
        /// Hosts临时目录文件
        /// </summary>
        private static string tempHostsFileName = CommonConstant.TEMP_HIWORK_PATH + @"\hosts";

        /// <summary>
        /// 备份hosts文件地址
        /// </summary>
        private static string tempHostsBakFileName = tempHostsFileName + ".bak";

        /// <summary>
        /// 系统地址
        /// </summary>
        private static string systemRoot = Environment.GetFolderPath(Environment.SpecialFolder.System);

        /// <summary>
        /// hosts目录
        /// </summary>
        private static string systemHostsPath = systemRoot + @"\drivers\etc";

        /// <summary>
        /// 系统hosts文件地址：%systemroot%\system32\drivers\etc 
        /// </summary>
        private static string systemHostsFileName = systemHostsPath + @"\hosts";

        /// <summary>
        /// 还原Hosts
        /// </summary>
        /// <returns></returns>
        public static String ReductionHosts()
        {
            try
            {
                // 从备份文件中复制，判断有无备份文件
                if (!File.Exists(tempHostsBakFileName))
                {
                    return "备份文件尚不存在，优化后会自动备份您系统原来的hosts配置" + "\n";
                }

                // 从备份文件中读取内容，并写入到临时文件
                string bakFileContents = ReadFile(tempHostsBakFileName);
                string[] lines = { bakFileContents };
                WriteFile(tempHostsFileName, lines);

                // 复制修改过的hosts文件到原目录
                File.Copy(tempHostsFileName, systemHostsFileName, true);
                return "还原系统hosts成功！\n您可以打开目录查看：" + systemHostsFileName + "\n";
            }
            catch (Exception exception)
            {
                return "还原发生异常，请在管理员模式下启动本程序！" + "\n" + "详细信息：" + exception.ToString();
            }
        }

        /// <summary>
        /// 优化Hosts
        /// </summary>
        /// <param name="userHosts">用户自己的hosts</param>
        /// <param name="regionStart">优化的hosts开始节点</param>
        /// <param name="optiHosts">优化的hosts内容</param>
        /// <param name="regionEnd">优化的hosts结束节点</param>
        /// <returns></returns>
        public static String optiHosts(string[] optiHosts, string regionStart, string regionEnd, string hostsVersion)
        {
            if (optiHosts.Length == 0)
            {
                return "待优化hosts为空，系统错误，优化失败";
            }

            try
            {
                // 获取用户当前的hosts配置
                string userHosts = ReadFile(systemHostsFileName);
                // 判断当前的hosts里是否包含程序设定hosts版本
                if (userHosts.Contains(hostsVersion))
                {
                    return "hosts已经处于优化状态";
                }

                // 复制hosts文件到临时目录
                //richTextBoxLog.AppendText("准备复制hosts文件……" + "\n");
                if (!copyHostsToFile(regionStart, regionEnd))
                {
                    return "复制hosts文件失败，请尝试在管理员模式下启动" + "\n";
                }

                //创建一个List
                List<string> tempHosts = new List<string>();
                tempHosts.Add(userHosts);
                foreach (string optiHost in optiHosts)
                {
                    tempHosts.Add(optiHost);
                }

                string[] hostsForModify = tempHosts.ToArray();

                WriteFile(tempHostsFileName, hostsForModify);

                // 复制修改过的hosts文件到原目录
                File.Copy(tempHostsFileName, systemHostsFileName, true);
                return "设置Hosts成功";
            }
            catch (Exception exception)
            {
                return "发生异常，请在管理员模式下启动本程序！" + "\n" + "详细信息：" + exception.ToString();
            }
        }

        /// <summary>
        /// 读取一个文件的内容
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private static String ReadFile(string fileName)
        {
            // Read the file as one string.
            string text = File.ReadAllText(fileName);

            return text;
        }

        private static void WriteFile(string fileName, string[] lines)
        {
            File.WriteAllLines(fileName, lines);
        }


        /// <summary>
        /// 复制hosts文件到临时目录
        /// </summary>
        /// <returns></returns>
        private static Boolean copyHostsToFile(string regionStart, string regionEnd)
        {
            try
            {
                Directory.CreateDirectory(CommonConstant.TEMP_HIWORK_PATH); // 创建目录
                File.Copy(systemHostsFileName, tempHostsFileName, true);
                // 清理hosts中本程序添加的区块（如果有）
                cleanHosts(tempHostsFileName, regionStart, regionEnd);
                // 备份一份清理过的hosts
                File.Copy(tempHostsFileName, tempHostsBakFileName, true);
            }
            catch (Exception)
            {
                // 通常是因为没有启动管理员模式
                return false;
            }
            return true;
        }


        /// <summary>
        /// 清理文件中本程序添加的hosts信息
        /// </summary>
        /// <param name="fileName"></param>
        private static void cleanHosts(string fileName, string regionStart, string regionEnd)
        {
            string fileContent = ReadFile(fileName); // 文件内容

            int startIndex = fileContent.IndexOf(regionStart); // 区块起始index
            int endIndex = fileContent.IndexOf(regionEnd); // 区块结束index

            string cleanedFileContent = fileContent; // 清理过的内容

            // 循环清理所有做了这个配置的数据块
            if (startIndex != -1 && endIndex != -1)
            {
                while (startIndex != -1 && endIndex != -1)
                {
                    string beforeRegionContent = ""; // 区域前的内容
                    string afterRegionContent = ""; // 区域后的内容

                    beforeRegionContent = cleanedFileContent.Substring(0, startIndex);
                    afterRegionContent = cleanedFileContent.Substring(endIndex + regionEnd.Length);

                    cleanedFileContent = beforeRegionContent + afterRegionContent;

                    // 清理之后，重新获取index
                    startIndex = cleanedFileContent.IndexOf(regionStart); // 区块起始index
                    endIndex = cleanedFileContent.IndexOf(regionEnd); // 区块结束index
                }
            }
            else
            {
                cleanedFileContent = fileContent;
            }

            // 将清理过的内容写入到文件中
            string[] lines = { cleanedFileContent };
            WriteFile(fileName, lines);
        }

    }

}
