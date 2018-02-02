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

        /// <summary>
        /// 开发者模式窗口高度
        /// </summary>
        private const int ADVANCE_MODE_FORM_HEIGHT = 622;

        /// <summary>
        /// 常规模式窗口高度
        /// </summary>
        private const int NROMAL_MODE_FORM_HEIGHT = 432;

        /// <summary>
        /// 当前是否是开发者模式
        /// </summary>
        private bool advanceMode = false;

        public FormMain()
        {
            InitializeComponent();

            richTextBoxNormal.Dock = DockStyle.Fill;

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
                advanceLog("创建桌面快捷方式失败！" + "\n" + "异常信息：" + e.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            advanceLog(HostModifier.optiHosts(HospitalCustomizedConfig.hostsForAdd,
                HospitalCustomizedConfig.regionStart, HospitalCustomizedConfig.regionEnd,
                HospitalCustomizedConfig.hostsVersion));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            normalLog("Copyright 2018 广州海鹚网络科技有限公司 All Rights Reserved V " + version + "\n");

            /*
            advanceLog("欢迎使用！请点击“点我优化”，完成网络优化，您可能需要重启计算机后使优化生效。\n");
            string hint = "注意：由于追加的Hosts配置在文件末尾，查看Hosts配置时，请翻到Hosts末尾查看";
            richTextBoxAdvance.AppendText(hint +"\n\n\n");

            string text = richTextBoxAdvance.Text;
            int length = text.IndexOf(hint);

            richTextBoxAdvance.Select(length, length + hint.Length);
            richTextBoxAdvance.SelectionColor = Color.Red;
            richTextBoxAdvance.SelectionFont = new Font("宋体", 9, FontStyle.Bold);
            richTextBoxAdvance.SelectionLength = 0;
            */
            this.Text += " V " + version;

            timer1.Enabled = true;
        }

        private void linkLabelReduction_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnGetChromeInstallInfo_Click(object sender, EventArgs e)
        {
            if (BrowerConfiger.hasChromeInstalled())
            {
                advanceLog("您已经安装了谷歌浏览器");
            }
            else
            {
                advanceLog("您尚未安装谷歌浏览器，建议您使用谷歌浏览器以获得最佳体验");
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
        private void advanceLog(string log)
        {
            richTextBoxAdvance.AppendText(log + "\n");
        }

        private void normalLog(string log)
        {
            richTextBoxNormal.AppendText(log + "\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 打开下载窗口
            FormDownLoadProgressBar formDownLoadProgressBar = new FormDownLoadProgressBar();
            formDownLoadProgressBar.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            advanceLog(BrowerConfiger.getChromeInstallPath());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            advanceLog(BrowerConfiger.getDefaultBrowerPath());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            advanceLog(BrowerConfiger.setDefaultBrower());
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
            richTextBoxAdvance.SelectionStart = richTextBoxAdvance.Text.Length;
            richTextBoxAdvance.ScrollToCaret();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            advanceLog(HostModifier.ReductionHosts());
        }

        private void linkLabelAdvance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (advanceMode)
            {
                richTextBoxNormal.Visible = true;
                advanceMode = false;
            }
            else
            {
                panelCenter.Visible = true;
                richTextBoxNormal.Visible = false;
                advanceMode = true;
            }
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            this.Show();
        }

        private void backgroundWorkerAuto_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void buttonFlex_Click(object sender, EventArgs e)
        {
            buttonFlex.Enabled = false;
            if (buttonFlex.Text.Equals("打开天使排班"))
            {
                Process pro = new Process();
                pro.StartInfo.FileName = "chrome.exe";
                pro.StartInfo.Arguments = @"https://mch.hoswork.com/mch/index.html#/wxlogin";
                pro.Start();
            }
            else
            {
                if (stepAll())
                {
                    normalLog("4/4：优化完成，请点击上方按钮进入天使排班");
                    buttonFlex.Enabled = true;
                    buttonFlex.Text = "打开天使排班";
                }
            }

            buttonFlex.Enabled = true;
        }

        private bool stepSetHosts()
        {
            buttonFlex.Enabled = false;
            normalLog("1/4：准备优化Hosts……");

            string result = HostModifier.optiHosts(HospitalCustomizedConfig.hostsForAdd,
                HospitalCustomizedConfig.regionStart, HospitalCustomizedConfig.regionEnd,
                HospitalCustomizedConfig.hostsVersion);
            if (!result.Equals("设置Hosts成功") && !result.Equals("hosts已经处于优化状态"))
            {
                normalLog("1/4：" + result);
                buttonFlex.Enabled = true;
                return false;

            }
            normalLog("1/4：" + result);
            return true;
        }

        private bool stepInstallChrome()
        {
            normalLog("2/4：检查是否已安装谷歌浏览器……");

            if (!BrowerConfiger.hasChromeInstalled())
            {
                normalLog("2/4：您尚未安装谷歌浏览器，请在弹窗中选择是否下载安装。请于安装后点击按钮继续");
                // 打开下载窗口
                FormDownLoadProgressBar formDownLoadProgressBar = new FormDownLoadProgressBar();
                formDownLoadProgressBar.ShowDialog();
                buttonFlex.Enabled = true;
                return false;
            }

            normalLog("2/4：谷歌浏览器已安装");
            return true;
        }

        private bool stepSetDefaultBrowser()
        {
            buttonFlex.Enabled = false;
            normalLog("3/4：设置谷歌浏览器为默认浏览器……");

            // 判断当前是否是谷歌浏览器
            if (BrowerConfiger.getDefaultBrowerPath().Contains("chrome"))
            {
                normalLog("3/4：当前默认浏览器已经是谷歌浏览器");
                return true;
            }

            string setBrowerResult = BrowerConfiger.setDefaultBrower();
            if (!setBrowerResult.Equals("设置成功"))
            {
                normalLog("3/4：" + setBrowerResult);
                buttonFlex.Enabled = true;
                return false;
            }
            normalLog("3/4：" + setBrowerResult);
            return true;
        }

        private bool stepAll()
        {
            if (!stepSetHosts())
            {
                return false;
            }

            if (!stepInstallChrome())
            {
                return false;
            }

            if (!stepSetDefaultBrowser())
            {
                return false;
            }

            return true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (stepAll())
            {
                normalLog("4/4：优化完成，请点击上方按钮进入天使排班");
                buttonFlex.Enabled = true;
                buttonFlex.Text = "打开天使排班";
            }
            timer1.Enabled = false;
        }
    }
}
