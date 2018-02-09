using System.Deployment.Application;

namespace AngleToolForms
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonFlex = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.linkLabelOpenErrorLog = new System.Windows.Forms.LinkLabel();
            this.labelChromeInsallInfo = new System.Windows.Forms.Label();
            this.labelDefaultBrowserInfo = new System.Windows.Forms.Label();
            this.labelHostsInfo = new System.Windows.Forms.Label();
            this.labelChromeInstall = new System.Windows.Forms.Label();
            this.labelDefaultBrowser = new System.Windows.Forms.Label();
            this.labelHosts = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timerLazyLoad = new System.Windows.Forms.Timer(this.components);
            this.panelMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonFlex
            // 
            this.buttonFlex.Location = new System.Drawing.Point(12, 16);
            this.buttonFlex.Name = "buttonFlex";
            this.buttonFlex.Size = new System.Drawing.Size(415, 58);
            this.buttonFlex.TabIndex = 14;
            this.buttonFlex.Text = "点击按钮继续";
            this.buttonFlex.UseVisualStyleBackColor = true;
            this.buttonFlex.Click += new System.EventHandler(this.buttonFlex_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.linkLabelOpenErrorLog);
            this.panelMain.Controls.Add(this.labelChromeInsallInfo);
            this.panelMain.Controls.Add(this.labelDefaultBrowserInfo);
            this.panelMain.Controls.Add(this.labelHostsInfo);
            this.panelMain.Controls.Add(this.labelChromeInstall);
            this.panelMain.Controls.Add(this.labelDefaultBrowser);
            this.panelMain.Controls.Add(this.labelHosts);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(438, 157);
            this.panelMain.TabIndex = 17;
            // 
            // linkLabelOpenErrorLog
            // 
            this.linkLabelOpenErrorLog.AutoSize = true;
            this.linkLabelOpenErrorLog.Location = new System.Drawing.Point(327, 19);
            this.linkLabelOpenErrorLog.Name = "linkLabelOpenErrorLog";
            this.linkLabelOpenErrorLog.Size = new System.Drawing.Size(97, 15);
            this.linkLabelOpenErrorLog.TabIndex = 7;
            this.linkLabelOpenErrorLog.TabStop = true;
            this.linkLabelOpenErrorLog.Text = "打开错误报告";
            this.linkLabelOpenErrorLog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelOpenErrorLog_LinkClicked);
            // 
            // labelChromeInsallInfo
            // 
            this.labelChromeInsallInfo.AutoSize = true;
            this.labelChromeInsallInfo.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelChromeInsallInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelChromeInsallInfo.Location = new System.Drawing.Point(255, 70);
            this.labelChromeInsallInfo.Name = "labelChromeInsallInfo";
            this.labelChromeInsallInfo.Size = new System.Drawing.Size(23, 15);
            this.labelChromeInsallInfo.TabIndex = 6;
            this.labelChromeInsallInfo.Text = "×";
            // 
            // labelDefaultBrowserInfo
            // 
            this.labelDefaultBrowserInfo.AutoSize = true;
            this.labelDefaultBrowserInfo.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelDefaultBrowserInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelDefaultBrowserInfo.Location = new System.Drawing.Point(255, 121);
            this.labelDefaultBrowserInfo.Name = "labelDefaultBrowserInfo";
            this.labelDefaultBrowserInfo.Size = new System.Drawing.Size(23, 15);
            this.labelDefaultBrowserInfo.TabIndex = 5;
            this.labelDefaultBrowserInfo.Text = "×";
            // 
            // labelHostsInfo
            // 
            this.labelHostsInfo.AutoSize = true;
            this.labelHostsInfo.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelHostsInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelHostsInfo.Location = new System.Drawing.Point(255, 19);
            this.labelHostsInfo.Name = "labelHostsInfo";
            this.labelHostsInfo.Size = new System.Drawing.Size(23, 15);
            this.labelHostsInfo.TabIndex = 4;
            this.labelHostsInfo.Text = "×";
            // 
            // labelChromeInstall
            // 
            this.labelChromeInstall.AutoSize = true;
            this.labelChromeInstall.Location = new System.Drawing.Point(56, 70);
            this.labelChromeInstall.Name = "labelChromeInstall";
            this.labelChromeInstall.Size = new System.Drawing.Size(157, 15);
            this.labelChromeInstall.TabIndex = 2;
            this.labelChromeInstall.Text = "是否已安装谷歌浏览器";
            this.labelChromeInstall.Click += new System.EventHandler(this.labelChromeInstall_Click);
            // 
            // labelDefaultBrowser
            // 
            this.labelDefaultBrowser.AutoSize = true;
            this.labelDefaultBrowser.Location = new System.Drawing.Point(57, 121);
            this.labelDefaultBrowser.Name = "labelDefaultBrowser";
            this.labelDefaultBrowser.Size = new System.Drawing.Size(157, 15);
            this.labelDefaultBrowser.TabIndex = 1;
            this.labelDefaultBrowser.Text = "是否已设置默认浏览器";
            // 
            // labelHosts
            // 
            this.labelHosts.AutoSize = true;
            this.labelHosts.Location = new System.Drawing.Point(57, 19);
            this.labelHosts.Name = "labelHosts";
            this.labelHosts.Size = new System.Drawing.Size(142, 15);
            this.labelHosts.TabIndex = 0;
            this.labelHosts.Text = "是否已完成网络优化";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonFlex);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 92);
            this.panel2.TabIndex = 18;
            // 
            // timerLazyLoad
            // 
            this.timerLazyLoad.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 249);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "天使排班";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonFlex;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timerLazyLoad;
        private System.Windows.Forms.Label labelChromeInstall;
        private System.Windows.Forms.Label labelDefaultBrowser;
        private System.Windows.Forms.Label labelHosts;
        private System.Windows.Forms.Label labelChromeInsallInfo;
        private System.Windows.Forms.Label labelDefaultBrowserInfo;
        private System.Windows.Forms.Label labelHostsInfo;
        private System.Windows.Forms.LinkLabel linkLabelOpenErrorLog;
    }
}

