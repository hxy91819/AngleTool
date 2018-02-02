using System.Deployment.Application;

namespace AngleTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnOpti = new System.Windows.Forms.Button();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.linkLabelReduction = new System.Windows.Forms.LinkLabel();
            this.btnGetChromeInstallInfo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpti
            // 
            this.btnOpti.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpti.Location = new System.Drawing.Point(12, 309);
            this.btnOpti.Name = "btnOpti";
            this.btnOpti.Size = new System.Drawing.Size(358, 56);
            this.btnOpti.TabIndex = 0;
            this.btnOpti.Text = "点我优化";
            this.btnOpti.UseVisualStyleBackColor = true;
            this.btnOpti.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.ReadOnly = true;
            this.richTextBoxLog.Size = new System.Drawing.Size(567, 282);
            this.richTextBoxLog.TabIndex = 1;
            this.richTextBoxLog.Text = "";
            this.richTextBoxLog.TextChanged += new System.EventHandler(this.richTextBoxLog_TextChanged);
            // 
            // linkLabelReduction
            // 
            this.linkLabelReduction.AutoSize = true;
            this.linkLabelReduction.Location = new System.Drawing.Point(454, 331);
            this.linkLabelReduction.Name = "linkLabelReduction";
            this.linkLabelReduction.Size = new System.Drawing.Size(67, 15);
            this.linkLabelReduction.TabIndex = 4;
            this.linkLabelReduction.TabStop = true;
            this.linkLabelReduction.Text = "点我还原";
            this.linkLabelReduction.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelReduction_LinkClicked);
            // 
            // btnGetChromeInstallInfo
            // 
            this.btnGetChromeInstallInfo.Location = new System.Drawing.Point(602, 12);
            this.btnGetChromeInstallInfo.Name = "btnGetChromeInstallInfo";
            this.btnGetChromeInstallInfo.Size = new System.Drawing.Size(172, 37);
            this.btnGetChromeInstallInfo.TabIndex = 5;
            this.btnGetChromeInstallInfo.Text = "验证Chrome安装";
            this.btnGetChromeInstallInfo.UseVisualStyleBackColor = true;
            this.btnGetChromeInstallInfo.Click += new System.EventHandler(this.btnGetChromeInstallInfo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(603, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "创建桌面快捷方式";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(603, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "下载Chrome";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(602, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 36);
            this.button3.TabIndex = 8;
            this.button3.Text = "获取Chrome安装路径";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(603, 225);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 37);
            this.button4.TabIndex = 9;
            this.button4.Text = "获取默认浏览器";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(603, 281);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(172, 37);
            this.button5.TabIndex = 10;
            this.button5.Text = "设置Chrome为默认";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(603, 324);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(172, 37);
            this.button6.TabIndex = 11;
            this.button6.Text = "使用默认浏览器打开";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 375);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGetChromeInstallInfo);
            this.Controls.Add(this.linkLabelReduction);
            this.Controls.Add(this.richTextBoxLog);
            this.Controls.Add(this.btnOpti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "天使排班";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpti;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.LinkLabel linkLabelReduction;
        private System.Windows.Forms.Button btnGetChromeInstallInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

