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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnOpti = new System.Windows.Forms.Button();
            this.richTextBoxAdvance = new System.Windows.Forms.RichTextBox();
            this.btnGetChromeInstallInfo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFlex = new System.Windows.Forms.Button();
            this.linkLabelAdvance = new System.Windows.Forms.LinkLabel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBoxNormal = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelCenter.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.btnOpti.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBoxAdvance
            // 
            this.richTextBoxAdvance.Location = new System.Drawing.Point(12, 153);
            this.richTextBoxAdvance.Name = "richTextBoxAdvance";
            this.richTextBoxAdvance.ReadOnly = true;
            this.richTextBoxAdvance.Size = new System.Drawing.Size(582, 135);
            this.richTextBoxAdvance.TabIndex = 1;
            this.richTextBoxAdvance.Text = "";
            this.richTextBoxAdvance.TextChanged += new System.EventHandler(this.richTextBoxLog_TextChanged);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "创建桌面快捷方式";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "下载Chrome";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(423, 62);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 37);
            this.button3.TabIndex = 8;
            this.button3.Text = "获取Chrome安装路径";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(11, 110);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 37);
            this.button4.TabIndex = 9;
            this.button4.Text = "获取默认浏览器";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(224, 110);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(172, 37);
            this.button5.TabIndex = 10;
            this.button5.Text = "设置Chrome为默认";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(423, 110);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(172, 37);
            this.button6.TabIndex = 11;
            this.button6.Text = "使用默认浏览器打开";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button7.Location = new System.Drawing.Point(224, 14);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(172, 37);
            this.button7.TabIndex = 12;
            this.button7.Text = "Hosts还原";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "请按以下提示信息操作：";
            // 
            // buttonFlex
            // 
            this.buttonFlex.Location = new System.Drawing.Point(423, 16);
            this.buttonFlex.Name = "buttonFlex";
            this.buttonFlex.Size = new System.Drawing.Size(172, 37);
            this.buttonFlex.TabIndex = 14;
            this.buttonFlex.Text = "继续";
            this.buttonFlex.UseVisualStyleBackColor = true;
            this.buttonFlex.Click += new System.EventHandler(this.buttonFlex_Click);
            // 
            // linkLabelAdvance
            // 
            this.linkLabelAdvance.AutoSize = true;
            this.linkLabelAdvance.Location = new System.Drawing.Point(468, 20);
            this.linkLabelAdvance.Name = "linkLabelAdvance";
            this.linkLabelAdvance.Size = new System.Drawing.Size(82, 15);
            this.linkLabelAdvance.TabIndex = 15;
            this.linkLabelAdvance.TabStop = true;
            this.linkLabelAdvance.Text = "开发者模式";
            this.linkLabelAdvance.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAdvance_LinkClicked);
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.richTextBoxNormal);
            this.panelCenter.Controls.Add(this.richTextBoxAdvance);
            this.panelCenter.Controls.Add(this.button7);
            this.panelCenter.Controls.Add(this.btnOpti);
            this.panelCenter.Controls.Add(this.btnGetChromeInstallInfo);
            this.panelCenter.Controls.Add(this.button1);
            this.panelCenter.Controls.Add(this.button2);
            this.panelCenter.Controls.Add(this.button6);
            this.panelCenter.Controls.Add(this.button3);
            this.panelCenter.Controls.Add(this.button5);
            this.panelCenter.Controls.Add(this.button4);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 66);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(603, 298);
            this.panelCenter.TabIndex = 16;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelCenter);
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(603, 418);
            this.panelMain.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabelAdvance);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 364);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 54);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonFlex);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 66);
            this.panel2.TabIndex = 18;
            // 
            // richTextBoxNormal
            // 
            this.richTextBoxNormal.Location = new System.Drawing.Point(283, 99);
            this.richTextBoxNormal.Name = "richTextBoxNormal";
            this.richTextBoxNormal.ReadOnly = true;
            this.richTextBoxNormal.Size = new System.Drawing.Size(39, 36);
            this.richTextBoxNormal.TabIndex = 13;
            this.richTextBoxNormal.Text = "";
            this.richTextBoxNormal.TextChanged += new System.EventHandler(this.richTextBoxLog_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 418);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "天使排班";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.panelCenter.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpti;
        private System.Windows.Forms.RichTextBox richTextBoxAdvance;
        private System.Windows.Forms.Button btnGetChromeInstallInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFlex;
        private System.Windows.Forms.LinkLabel linkLabelAdvance;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBoxNormal;
        private System.Windows.Forms.Timer timer1;
    }
}

