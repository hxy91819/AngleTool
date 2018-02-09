using AngleToolHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AngleTool
{
    public partial class FormDownLoadProgressBar : Form
    {
        /// <summary>
        /// 下载状态：0，未下载完成；1，下载完成；2，用户取消；3，下载失败；4，用户确认安装
        /// </summary>
        private static int downloadStatus = 0;
        public FormDownLoadProgressBar()
        {
            InitializeComponent();
        }

        private void FormDownLoadProgressBar_Load(object sender, EventArgs e)
        {
        }

        private void FormDownLoadProgressBar_Shown(object sender, EventArgs e)
        {
            this.Show();
            backgroundWorkerDownload.RunWorkerAsync();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            cancelDownload();
        }

        /// <summary>
        /// 取消下载
        /// </summary>
        private void cancelDownload()
        {
            // 如果状态已经是2了，则不需要再弹窗确认
            if(downloadStatus == 2 || downloadStatus == 4 || downloadStatus == 3)
            {
                return;
            }

            // 下载完成后，提示用户是否安装
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定要取消下载吗?", "取消确认", messButton);
            if (dr == DialogResult.OK)//如果点击“确定”按钮
            {
                backgroundWorkerDownload.CancelAsync();
                downloadStatus = 2;
                this.Close();
            }
            else//如果点击“取消”按钮
            {

            }
        }

        private void backgroundWorkerDownload_DoWork(object sender, DoWorkEventArgs e)
        {
            DownloadFile(CommonConstant.CHROME_DOWNLOAD_URL,
                CommonConstant.CHROME_LOCAL_SAVE_PATH, backgroundWorkerDownload, e);
        }

        private void backgroundWorkerDownload_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarDownload.Value = e.ProgressPercentage;

            labelDownloadInfo.Text = e.ProgressPercentage.ToString();
        }

        /// <summary>        
        /// c#,.net 下载文件        
        /// </summary>        
        /// <param name="URL">下载文件地址</param>       
        /// 
        public void DownloadFile(string URL, string filename, BackgroundWorker backgroundWorker, DoWorkEventArgs e)
        {
            float percent = 0;
            try
            {
                System.Net.HttpWebRequest Myrq = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(URL);
                System.Net.HttpWebResponse myrp = (System.Net.HttpWebResponse)Myrq.GetResponse();
                long totalBytes = myrp.ContentLength;
                System.IO.Stream st = myrp.GetResponseStream();
                System.IO.Stream so = new System.IO.FileStream(filename, System.IO.FileMode.Create);
                long totalDownloadedByte = 0;
                byte[] by = new byte[1024];
                int osize = st.Read(by, 0, (int)by.Length);
                while (osize > 0)
                {
                    // 终止条件，使得点击了取消按钮之后，能够终止进程
                    if (backgroundWorker.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }

                    totalDownloadedByte = osize + totalDownloadedByte;
                    System.Windows.Forms.Application.DoEvents();
                    so.Write(by, 0, osize);
                    osize = st.Read(by, 0, (int)by.Length);

                    percent = (float)totalDownloadedByte / (float)totalBytes * 100;

                    backgroundWorker.ReportProgress((int)percent);
                    System.Windows.Forms.Application.DoEvents(); //必须加注这句代码，否则label1将因为循环执行太快而来不及显示信息
                }

                downloadStatus = 1;
                so.Close();
                st.Close();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        private void backgroundWorkerDownload_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // 判断谷歌浏览器是否下载完成
            if (downloadStatus == 0)
            {
                // 下载完成后，提示用户是否安装
                MessageBoxButtons messButton = MessageBoxButtons.OK;
                DialogResult dr = MessageBox.Show("谷歌浏览器下载失败，请您稍后再试", "下载失败", messButton);
                if (dr == DialogResult.OK)//如果点击“确定”按钮
                {
                    downloadStatus = 3;
                    this.Close();
                }
            }
            else if(downloadStatus == 1)
            {
                // 下载完成后，提示用户是否安装
                MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                DialogResult dr = MessageBox.Show("谷歌浏览器已经下载完成，是否需要立即安装？（谷歌浏览器会于后台安装，请安装成功之后，再点击主窗口的“点击按钮继续”）", "安装确认", messButton);
                if (dr == DialogResult.OK)//如果点击“确定”按钮
                {
                    Process p = Process.Start(CommonConstant.CHROME_LOCAL_SAVE_PATH);
                    downloadStatus = 4;
                    this.Close();
                }
                else//如果点击“取消”按钮
                {
                    downloadStatus = 2;
                    this.Close();
                }
            }
        }

        private void FormDownLoadProgressBar_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void FormDownLoadProgressBar_FormClosed(object sender, FormClosedEventArgs e)
        {
            cancelDownload();
        }
    }
}
