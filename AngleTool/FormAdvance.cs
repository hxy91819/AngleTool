﻿using AngleToolHelper;
using System;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AngleTool
{
    /// <summary>
    /// 开发者模式窗口
    /// </summary>
    public partial class FormAdvance : Form
    {

        /// <summary>
        /// 满足所有优化状态的时候，按钮显示的文字
        /// </summary>
        private const string BUTTON_FLEX_OPEN_ANGLE_SCHEDULE = "打开天使排班";

        public FormAdvance()
        {
            InitializeComponent();
        }

        private void btnOpti_Click(object sender, EventArgs e)
        {
            advanceLog(HostModifier.optiHosts(HospitalCustomizedConfig.hostsForAdd,
    HospitalCustomizedConfig.regionStart, HospitalCustomizedConfig.regionEnd,
    HospitalCustomizedConfig.hostsVersion));
        }

        private void richTextBoxAdvance_TextChanged(object sender, EventArgs e)
        {
            richTextBoxAdvance.SelectionStart = richTextBoxAdvance.Text.Length;
            richTextBoxAdvance.ScrollToCaret();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void buttonOpenBrowser_Click(object sender, EventArgs e)
        {
            // 使用指定的浏览器打开
            Process pro = new Process();
            pro.StartInfo.FileName = "chrome.exe";
            pro.StartInfo.Arguments = CommonConstant.HIWORK_MCH_LOGIN_PAGE;
            pro.Start();

            // 使用默认浏览器打开
            //System.Diagnostics.Process.Start(CommonConstant.HIWORK_MCH_LOGIN_PAGE);
        }

        private void buttonReduction_Click(object sender, EventArgs e)
        {
            advanceLog(HostModifier.ReductionHosts());
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

        private void buttonSetDesktopShortcut_Click(object sender, EventArgs e)
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

        private void buttonDownloadChrome_Click(object sender, EventArgs e)
        {
            // 打开下载窗口
            FormDownLoadProgressBar formDownLoadProgressBar = new FormDownLoadProgressBar();
            formDownLoadProgressBar.ShowDialog();
        }

        private void buttonGetChromeInstallPath_Click(object sender, EventArgs e)
        {
            advanceLog(BrowerConfiger.getChromeInstallPath());
        }

        private void buttonGetDefaultBrowerPath_Click(object sender, EventArgs e)
        {
            advanceLog(BrowerConfiger.getDefaultBrowerPath());
        }

        private void buttonSetDefaultBrower_Click(object sender, EventArgs e)
        {
            advanceLog(BrowerConfiger.setDefaultBrower());
        }
    }
}
