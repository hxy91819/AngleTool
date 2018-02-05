using AngleToolHelper;
using Helpers;
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
        /// 进入开发者模式点击次数统计
        /// </summary>
        private int advanceModeClickCount = 0;

        /// <summary>
        /// 满足所有优化状态的时候，按钮显示的文字
        /// </summary>
        private const string BUTTON_FLEX_OPEN_ANGLE_SCHEDULE = "打开天使排班";

        /// <summary>
        /// 日志工具
        /// </summary>
        private static LogHelper logger = new LogHelper();


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
                logger.WriteLog("创建桌面快捷方式失败！" + "\n" + "异常信息：" + e.ToString());
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
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

            timerLazyLoad.Enabled = true;
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            this.Show();
        }


        private void buttonFlex_Click(object sender, EventArgs e)
        {
            buttonFlex.Enabled = false;
            if (buttonFlex.Text.Equals(BUTTON_FLEX_OPEN_ANGLE_SCHEDULE))
            {
                Process pro = new Process();
                pro.StartInfo.FileName = "chrome.exe";
                pro.StartInfo.Arguments = CommonConstant.HIWORK_MCH_LOGIN_PAGE;
                pro.Start();
            }
            else
            {
                if (stepAll())
                {
                    buttonFlex.Enabled = true;
                    buttonFlex.Text = BUTTON_FLEX_OPEN_ANGLE_SCHEDULE;
                }
            }

            buttonFlex.Enabled = true;
        }

        private bool stepSetHosts()
        {
            buttonFlex.Enabled = false;

            string result = HostModifier.optiHosts(HospitalCustomizedConfig.hostsForAdd,
                HospitalCustomizedConfig.regionStart, HospitalCustomizedConfig.regionEnd,
                HospitalCustomizedConfig.hostsVersion);
            if (!result.Equals(HostModifier.HOSTS_OK) && !result.Equals(HostModifier.HOSTS_ALREADY_OK))
            {
                buttonFlex.Enabled = true;
                return false;

            }
            return true;
        }

        private bool stepInstallChrome()
        {
            if (!BrowerConfiger.hasChromeInstalled())
            {
                // 下载完成后，提示用户是否安装
                MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                DialogResult dr = MessageBox.Show("您尚未安装谷歌浏览器，点击确认可下载安装。请在安装完毕后，点击主窗口的“点击按钮继续”", "谷歌浏览器未安装", messButton);
                if (dr == DialogResult.OK)//如果点击“确定”按钮
                {
                    // 打开下载窗口
                    FormDownLoadProgressBar formDownLoadProgressBar = new FormDownLoadProgressBar();
                    formDownLoadProgressBar.ShowDialog();
                    buttonFlex.Enabled = true;
                }
                return false;
            }

            return true;
        }

        private bool stepSetDefaultBrowser()
        {
            buttonFlex.Enabled = false;

            // 判断当前是否是谷歌浏览器
            if (BrowerConfiger.getDefaultBrowerPath().Contains("chrome"))
            {
                return true;
            }

            string setBrowerResult = BrowerConfiger.setDefaultBrower();
            if (!setBrowerResult.Equals(BrowerConfiger.DEFAULT_BROWSER_OK))
            {
                buttonFlex.Enabled = true;
                return false;
            }
            return true;
        }

        private bool stepAll()
        {
            if (!stepSetHosts())
            {
                labelHostsInfo.Text = CommonConstant.LABEL_SHOW_FAIL;
                return false;
            }

            labelHostsInfo.Text = CommonConstant.LABEL_SHOW_OK;

            if (!stepInstallChrome())
            {
                labelChromeInsallInfo.Text = CommonConstant.LABEL_SHOW_FAIL;
                return false;
            }
            labelChromeInsallInfo.Text = CommonConstant.LABEL_SHOW_OK;

            if (!stepSetDefaultBrowser())
            {
                labelDefaultBrowserInfo.Text = CommonConstant.LABEL_SHOW_FAIL;
                return false;
            }
            labelDefaultBrowserInfo.Text = CommonConstant.LABEL_SHOW_OK;

            return true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerLazyLoad.Enabled = false;
            if (stepAll())
            {
                buttonFlex.Enabled = true;
                buttonFlex.Text = BUTTON_FLEX_OPEN_ANGLE_SCHEDULE;
            }
        }

        private void labelChromeInstall_Click(object sender, EventArgs e)
        {
            // 如果点击了5次，则打开高级模式
            if(advanceModeClickCount == 5)
            {
                advanceModeClickCount = 0;
                FormAdvance formAdvance = new FormAdvance();
                formAdvance.ShowDialog();
            }
            else
            {
                advanceModeClickCount++;
            }
        }


        /// <summary>
        /// 打开错误报告
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabelOpenErrorLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string logPath = logger.getLogPath();
            System.Diagnostics.Process.Start(logPath);
        }
    }
}
