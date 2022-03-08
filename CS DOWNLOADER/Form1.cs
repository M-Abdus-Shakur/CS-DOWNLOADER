using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace CS_DOWNLOADER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void download()
        {
            WebClient wc = new WebClient();
            wc.DownloadProgressChanged += Wc_DownloadProgressChanged;
            wc.DownloadFileCompleted += Wc_DownloadFileCompleted;
            wc.DownloadFileAsync(new Uri("https://discord.com/api/downloads/distributions/app/installers/latest?channel=ptb&platform=win&arch=x86"),"file.exe");
        }


        private void Wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytes = double.Parse(e.BytesReceived.ToString());
            double byteTotal = double.Parse(e.TotalBytesToReceive.ToString());
            double percent = bytes / byteTotal * 100;
            mb_label.Text ="Downloaded : " + string.Format(" {0} MB / {1} MB",
                (e.BytesReceived / 1024d /1024d).ToString("0.00"),
                (e.TotalBytesToReceive /1024d/1024d).ToString("0.00"));

            progressBar1.Value = int.Parse(Math.Truncate(percent).ToString());
            p_value.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void Wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            mb_label.Text = "Download Finished";
        }

        private void Download_BTN_Click(object sender, EventArgs e)
        {
            download();
        }
    }
}
