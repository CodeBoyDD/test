using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SpeedTool
{
    public partial class Frm_Tools_NetWorkTest : Form
    {
        public Frm_Tools_NetWorkTest()
        {
            InitializeComponent();
            Thread thr5 = new Thread(new ThreadStart(GetNetWorkInfo));
            thr5.Start();
            thr5.IsBackground = true;
        }

        public delegate void AddHandler(string up, string down);//委托

        //获取网络上下行
        public void GetNetWorkInfo()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            if (nics == null || nics.Length < 1)
            {
                return;
            }
            long lastSendCount = 0;
            long lastRevCount = 0;
            while (true)
            {
                long sendCount = 0;
                long revCount = 0;
                foreach (NetworkInterface adapter in nics)
                {
                    IPv4InterfaceStatistics ipv4Statistics = adapter.GetIPv4Statistics();
                    sendCount += ipv4Statistics.BytesSent;
                    revCount += ipv4Statistics.BytesReceived;
                }
                string SendSpeed = ((sendCount - lastSendCount) / 1024).ToString();
                string RevSpeed = ((revCount - lastRevCount) / 1024).ToString();
                string SendCount = (sendCount / 1024 / 1024).ToString();
                string RevCount = (revCount / 1024 / 1024).ToString();
                lastRevCount = revCount;
                lastSendCount = sendCount;

                SetText(SendSpeed + " kb/s", RevSpeed + " kb/s");
                Thread.Sleep(1000);
            }
        }

        //委托-跨线程访问UI控件
        private void SetText(string up, string down)
        {
            //Control.InvokeReauqired判断是否是创建控件线程，不是为true，则需要invoke到创建控件的线程，是就为false，直接操作控件
            if (this.InvokeRequired)
            {
                AddHandler ah = new AddHandler(SetText);
                this.Invoke(ah, new object[] { up, down });
            }
            else
            {
                UpLabel.Text = up;
                DownLabel.Text = down;
            }
        }

        private void Frm_Tools_NetWorkTest_Load(object sender, EventArgs e)
        {

        }
    }
}
