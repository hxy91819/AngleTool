namespace AngleToolForms
{
    partial class FormAdvance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelCenter = new System.Windows.Forms.Panel();
            this.richTextBoxAdvance = new System.Windows.Forms.RichTextBox();
            this.buttonReduction = new System.Windows.Forms.Button();
            this.btnOpti = new System.Windows.Forms.Button();
            this.btnGetChromeInstallInfo = new System.Windows.Forms.Button();
            this.buttonSetDesktopShortcut = new System.Windows.Forms.Button();
            this.buttonDownloadChrome = new System.Windows.Forms.Button();
            this.buttonOpenBrowser = new System.Windows.Forms.Button();
            this.buttonGetChromeInstallPath = new System.Windows.Forms.Button();
            this.buttonSetDefaultBrower = new System.Windows.Forms.Button();
            this.buttonGetDefaultBrowerPath = new System.Windows.Forms.Button();
            this.panelCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.richTextBoxAdvance);
            this.panelCenter.Controls.Add(this.buttonReduction);
            this.panelCenter.Controls.Add(this.btnOpti);
            this.panelCenter.Controls.Add(this.btnGetChromeInstallInfo);
            this.panelCenter.Controls.Add(this.buttonSetDesktopShortcut);
            this.panelCenter.Controls.Add(this.buttonDownloadChrome);
            this.panelCenter.Controls.Add(this.buttonOpenBrowser);
            this.panelCenter.Controls.Add(this.buttonGetChromeInstallPath);
            this.panelCenter.Controls.Add(this.buttonSetDefaultBrower);
            this.panelCenter.Controls.Add(this.buttonGetDefaultBrowerPath);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 0);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(606, 393);
            this.panelCenter.TabIndex = 17;
            // 
            // richTextBoxAdvance
            // 
            this.richTextBoxAdvance.Location = new System.Drawing.Point(12, 153);
            this.richTextBoxAdvance.Name = "richTextBoxAdvance";
            this.richTextBoxAdvance.ReadOnly = true;
            this.richTextBoxAdvance.Size = new System.Drawing.Size(582, 228);
            this.richTextBoxAdvance.TabIndex = 1;
            this.richTextBoxAdvance.Text = "";
            this.richTextBoxAdvance.TextChanged += new System.EventHandler(this.richTextBoxAdvance_TextChanged);
            // 
            // buttonReduction
            // 
            this.buttonReduction.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonReduction.Location = new System.Drawing.Point(224, 14);
            this.buttonReduction.Name = "buttonReduction";
            this.buttonReduction.Size = new System.Drawing.Size(172, 37);
            this.buttonReduction.TabIndex = 12;
            this.buttonReduction.Text = "Hosts还原";
            this.buttonReduction.UseVisualStyleBackColor = true;
            this.buttonReduction.Click += new System.EventHandler(this.buttonReduction_Click);
            // 
            // btnOpti
            // 
            this.btnOpti.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpti.Location = new System.Drawing.Point(12, 14);
            this.btnOpti.Name = "btnOpti";
            this.btnOpti.Size = new System.Drawing.Size(172, 37);
            this.btnOpti.TabIndex = 0;
            this.btnOpti.Text = "Hosts优化";
            this.btnOpti.UseVisualStyleBackColor = true;
            this.btnOpti.Click += new System.EventHandler(this.btnOpti_Click);
            // 
            // btnGetChromeInstallInfo
            // 
            this.btnGetChromeInstallInfo.Location = new System.Drawing.Point(423, 14);
            this.btnGetChromeInstallInfo.Name = "btnGetChromeInstallInfo";
            this.btnGetChromeInstallInfo.Size = new System.Drawing.Size(172, 37);
            this.btnGetChromeInstallInfo.TabIndex = 5;
            this.btnGetChromeInstallInfo.Text = "验证Chrome安装";
            this.btnGetChromeInstallInfo.UseVisualStyleBackColor = true;
            this.btnGetChromeInstallInfo.Click += new System.EventHandler(this.btnGetChromeInstallInfo_Click);
            // 
            // buttonSetDesktopShortcut
            // 
            this.buttonSetDesktopShortcut.Location = new System.Drawing.Point(11, 62);
            this.buttonSetDesktopShortcut.Name = "buttonSetDesktopShortcut";
            this.buttonSetDesktopShortcut.Size = new System.Drawing.Size(172, 37);
            this.buttonSetDesktopShortcut.TabIndex = 6;
            this.buttonSetDesktopShortcut.Text = "创建桌面快捷方式";
            this.buttonSetDesktopShortcut.UseVisualStyleBackColor = true;
            this.buttonSetDesktopShortcut.Click += new System.EventHandler(this.buttonSetDesktopShortcut_Click);
            // 
            // buttonDownloadChrome
            // 
            this.buttonDownloadChrome.Location = new System.Drawing.Point(224, 62);
            this.buttonDownloadChrome.Name = "buttonDownloadChrome";
            this.buttonDownloadChrome.Size = new System.Drawing.Size(172, 37);
            this.buttonDownloadChrome.TabIndex = 7;
            this.buttonDownloadChrome.Text = "下载Chrome";
            this.buttonDownloadChrome.UseVisualStyleBackColor = true;
            this.buttonDownloadChrome.Click += new System.EventHandler(this.buttonDownloadChrome_Click);
            // 
            // buttonOpenBrowser
            // 
            this.buttonOpenBrowser.Location = new System.Drawing.Point(423, 110);
            this.buttonOpenBrowser.Name = "buttonOpenBrowser";
            this.buttonOpenBrowser.Size = new System.Drawing.Size(172, 37);
            this.buttonOpenBrowser.TabIndex = 11;
            this.buttonOpenBrowser.Text = "使用默认浏览器打开";
            this.buttonOpenBrowser.UseVisualStyleBackColor = true;
            this.buttonOpenBrowser.Click += new System.EventHandler(this.buttonOpenBrowser_Click);
            // 
            // buttonGetChromeInstallPath
            // 
            this.buttonGetChromeInstallPath.Location = new System.Drawing.Point(423, 62);
            this.buttonGetChromeInstallPath.Name = "buttonGetChromeInstallPath";
            this.buttonGetChromeInstallPath.Size = new System.Drawing.Size(172, 37);
            this.buttonGetChromeInstallPath.TabIndex = 8;
            this.buttonGetChromeInstallPath.Text = "获取Chrome安装路径";
            this.buttonGetChromeInstallPath.UseVisualStyleBackColor = true;
            this.buttonGetChromeInstallPath.Click += new System.EventHandler(this.buttonGetChromeInstallPath_Click);
            // 
            // buttonSetDefaultBrower
            // 
            this.buttonSetDefaultBrower.Location = new System.Drawing.Point(224, 110);
            this.buttonSetDefaultBrower.Name = "buttonSetDefaultBrower";
            this.buttonSetDefaultBrower.Size = new System.Drawing.Size(172, 37);
            this.buttonSetDefaultBrower.TabIndex = 10;
            this.buttonSetDefaultBrower.Text = "设置Chrome为默认";
            this.buttonSetDefaultBrower.UseVisualStyleBackColor = true;
            this.buttonSetDefaultBrower.Click += new System.EventHandler(this.buttonSetDefaultBrower_Click);
            // 
            // buttonGetDefaultBrowerPath
            // 
            this.buttonGetDefaultBrowerPath.Location = new System.Drawing.Point(11, 110);
            this.buttonGetDefaultBrowerPath.Name = "buttonGetDefaultBrowerPath";
            this.buttonGetDefaultBrowerPath.Size = new System.Drawing.Size(172, 37);
            this.buttonGetDefaultBrowerPath.TabIndex = 9;
            this.buttonGetDefaultBrowerPath.Text = "获取默认浏览器";
            this.buttonGetDefaultBrowerPath.UseVisualStyleBackColor = true;
            this.buttonGetDefaultBrowerPath.Click += new System.EventHandler(this.buttonGetDefaultBrowerPath_Click);
            // 
            // FormAdvance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 393);
            this.Controls.Add(this.panelCenter);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdvance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "开发者模式";
            this.panelCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.RichTextBox richTextBoxAdvance;
        private System.Windows.Forms.Button buttonReduction;
        private System.Windows.Forms.Button btnOpti;
        private System.Windows.Forms.Button btnGetChromeInstallInfo;
        private System.Windows.Forms.Button buttonSetDesktopShortcut;
        private System.Windows.Forms.Button buttonDownloadChrome;
        private System.Windows.Forms.Button buttonOpenBrowser;
        private System.Windows.Forms.Button buttonGetChromeInstallPath;
        private System.Windows.Forms.Button buttonSetDefaultBrower;
        private System.Windows.Forms.Button buttonGetDefaultBrowerPath;
    }
}