using AngleToolHelper;
using System;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AngleTool
{
    public partial class FormMain : Form
    {
        

        /// <summary>
        /// 程序发布版本：默认为Debug
        /// </summary>
        private string version = "Debug";

        public FormMain()
        {
            InitializeComponent();

            /* 2018-02-02 使用ClickOne发布，无法用管理员模式启动。使用Process方法开启管理员后，此方法将无法获取版本。
            try
            {
                // 获取当前部署
                ApplicationDeployment appd = ApplicationDeployment.CurrentDeployment;
                // 取得版本号
                version = appd.CurrentVersion.ToString();
            }
            catch(InvalidDeploymentException)
            {
                // 调试模式下启动，会报异常，将此异常抛出
                richTextBoxLog.AppendText("【您是在调试模式下启动本程序】" + "\n");
            }
            */
            version = HospitalCustomizedConfig.version;

            try
            {
                // 创建桌面快捷方式
                SystemConfiger.CreateDesktopShortCut();
            }
            catch (Exception e)
            {
                richTextBoxLog.AppendText("创建桌面快捷方式失败！" + "\n" + "异常信息：" + e.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBoxLog.AppendText(HostModifier.optiHosts(HospitalCustomizedConfig.hostsForAdd, 
                HospitalCustomizedConfig.regionStart, HospitalCustomizedConfig.regionEnd));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBoxLog.AppendText("Copyright 2018 广州海鹚网络科技有限公司 All Rights Reserved V " + version + "\n\n");
            richTextBoxLog.AppendText("欢迎使用！请点击“点我优化”，完成网络优化，您可能需要重启计算机后使优化生效。\n" + "\n");

            string hint = "注意：由于追加的Hosts配置在文件末尾，查看Hosts配置时，请翻到Hosts末尾查看";
            richTextBoxLog.AppendText(hint +"\n\n\n");

            string text = richTextBoxLog.Text;
            int length = text.IndexOf(hint);

            richTextBoxLog.Select(length, length + hint.Length);
            richTextBoxLog.SelectionColor = Color.Red;
            richTextBoxLog.SelectionFont = new Font("宋体", 9, FontStyle.Bold);
            richTextBoxLog.SelectionLength = 0;
            this.Text += " V " + version;
        }

        private void linkLabelReduction_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            richTextBoxLog.AppendText(HostModifier.ReductionHosts());
        }

        private void btnGetChromeInstallInfo_Click(object sender, EventArgs e)
        {
            if (BrowerConfiger.hasChromeInstalled())
            {
                formLog("您已经安装了谷歌浏览器");
            } else
            {
                formLog("您尚未安装谷歌浏览器，建议您使用谷歌浏览器以获得最佳体验");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SystemConfiger.CreateDesktopShortCut();
        }

        /// <summary>
        ///  
        /// 窗口内打印日志
        ///
        /// </summary>
        /// <param name="log"></param>
        private void formLog(string log)
        {
            richTextBoxLog.AppendText(log + "\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 打开下载窗口
            FormDownLoadProgressBar formDownLoadProgressBar = new FormDownLoadProgressBar();
            formDownLoadProgressBar.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formLog(BrowerConfiger.getChromeInstallPath());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formLog(BrowerConfiger.getDefaultBrowerPath());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            formLog(BrowerConfiger.setDefaultBrower());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process pro = new Process();
            pro.StartInfo.FileName = "chrome.exe";
            pro.StartInfo.Arguments = @"https://mch.hoswork.com/mch/index.html#/wxlogin";
            pro.Start();

            //System.Diagnostics.Process.Start(@"https://mch.hoswork.com/mch/index.html#/wxlogin");
        }

        private void richTextBoxLog_TextChanged(object sender, EventArgs e)
        {
            richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
            richTextBoxLog.ScrollToCaret();
        }
    }
}
