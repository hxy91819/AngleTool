using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AngleToolForms
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 本工程只保存公共调用的窗体，不做启动工程使用。
            //            Application.Run(new Form1());
        }
    }
}
