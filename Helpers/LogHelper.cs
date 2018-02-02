using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;

namespace Helpers
{
    /// <summary>
    /// 日志记录
    /// </summary>
    public class LogHelper
    {
        private Boolean showLog;

        /// <summary>
        /// 无参数的构造方法
        /// </summary>
        public LogHelper()
        {
            showLog = true;
        }

        /// <summary>
        /// 设置显示日志的构造方法
        /// </summary>
        /// <param name="showLog">是否打印日志</param>
        public LogHelper(Boolean showLog)
        {
            this.showLog = showLog;
        }

        //private static ConfigHelper logConfig = new ConfigHelper("logConfig.ini");
        /// <summary>
        /// 日志类型
        /// </summary>
        public enum LOGTYPE
        {
            /// <summary>
            /// 常规
            /// </summary>
            NORMAL = 0,
            /// <summary>
            /// 警告
            /// </summary>
            WARNNING = 1,
            /// <summary>
            /// 异常
            /// </summary>
            EXCEPTION = 2
        }
        /// <summary>
        /// 常规记录日志
        /// </summary>
        /// <param name="strLog">日志内容</param>
        public void WriteLog(string strLog)
        {
            if (!showLog)
                return;

            string logFileName = DateTime.Now.ToString("yyyyMMdd") + ".log";
            string fullFilePath = System.IO.Directory.GetCurrentDirectory() + @"/Log/";
            string fullFileName = fullFilePath + logFileName;
            try
            {
                if (!Directory.Exists(fullFilePath))
                    Directory.CreateDirectory(fullFilePath);

                if (File.Exists(fullFileName))
                {
                    using (StreamWriter sw = File.AppendText(fullFileName))
                    {
                        sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                        sw.WriteLine(strLog);
                        sw.Flush();
                        sw.Close();
                    }
                }
                else
                {
                    using (StreamWriter sw = File.CreateText(fullFileName))
                    {
                        sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                        sw.WriteLine(strLog);
                        sw.Flush();
                        sw.Close();
                    }
                }
            }
            catch
            {
                return;
            }
        }
        /// <summary>
        /// 记录日志
        /// </summary>
        /// <param name="strLog">日志内容</param>
        /// <param name="logType">日志类型：0-NORMAL，1-WARNNING，2-EXCEPTION</param>
        /// <param name="haveSource">是否记录日志位置，默认false</param>
        public void WriteLog(string strLog, int logType = 0, bool haveSource = false)
        {
            if (!showLog)
                return;

            string logFileName = DateTime.Now.ToString("yyyyMMdd") + ".log";
            string fullFilePath = System.IO.Directory.GetCurrentDirectory() + @"/Log/";
            string fullFileName = fullFilePath + logFileName;
            #region 设置日志头
            string logHead = "";
            switch (logType)
            {
                case (int)LOGTYPE.WARNNING:
                    logHead = "[" + Convert.ToString(LOGTYPE.WARNNING) + "]";
                    break;
                case (int)LOGTYPE.EXCEPTION:
                    logHead = "[" + Convert.ToString(LOGTYPE.EXCEPTION) + "]";
                    break;
                case (int)LOGTYPE.NORMAL:
                default:
                    logHead = "[" + Convert.ToString(LOGTYPE.NORMAL) + "  ]";
                    break;
            } 
            #endregion
            try
            {
                if (!Directory.Exists(fullFilePath))
                    Directory.CreateDirectory(fullFilePath);

                StreamWriter sw = null;
                #region 当日日志则为追加，次日则创建文件
                if (File.Exists(fullFileName))
                {
                    sw = File.AppendText(fullFileName);
                }
                else
                {
                    sw = File.CreateText(fullFileName);
                } 
                #endregion
                using (sw)
                {
                    sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));//时间，精确到毫秒
                    if(haveSource)
                    {
                        sw.WriteLine("[LOCATION]" + GetMethodInfo());//日志位置
                    }
                    sw.WriteLine(logHead+strLog);//日志主体
                    sw.Flush();
                    sw.Close();
                }
            }
            catch
            {
                return;
            }
        }
        /// <summary>
        /// 记录异常日志
        /// </summary>
        /// <param name="error">异常Exception</param>
        public void WriteLog(Exception error)
        {
            if (!showLog)
                return;

            StringBuilder sb = new StringBuilder();
            sb.Append("【Message】");
            sb.Append("\r\n");
            sb.Append(error.Message);
            sb.Append("\r\n");
            sb.Append("【Source】");
            sb.Append(error.Source);
            sb.Append("\r\n");
            sb.Append("【StackTrace】");
            sb.Append(error.StackTrace);

            WriteLog(sb.ToString());
        }
        /// <summary>
        /// 获取方法信息
        /// </summary>
        /// <returns></returns>
        private string GetMethodInfo()
        {
            string str = "";
            ////取得当前方法命名空间
            //str += "命名空间名:" + System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Namespace + "\n";
            ////取得当前方法类全名
            //str += "类名:" + System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName + "\n";
            ////取得当前方法名
            //str += "方法名:" + System.Reflection.MethodBase.GetCurrentMethod().Name + "\n";
            //str += "\n";

            StackTrace ss = new StackTrace(true);
            MethodBase mb = ss.GetFrame(2).GetMethod();
            ////取得父方法命名空间
            //str += mb.DeclaringType.Namespace + "\n";
            ////取得父方法类名
            //str += mb.DeclaringType.Name + "\n";
            ////取得父方法类全名
            //str += mb.DeclaringType.FullName + "\n";
            ////取得父方法名
            //str += mb.Name + "\n";
            str += mb.DeclaringType.FullName + "." + mb.Name;
            return str;
        }
    }
}
