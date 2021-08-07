using MyStudy.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SpeedTool
{
    public partial class Frm_Start : Form
    {
        //电脑信息固定不变的，类变量
        public static string cpuInfo;
        public static string memInfo;
        public static string baseBoardInfo;
        public static string diskDriveInfo;
        public static string osInfo;
        public static string displayCardInfo;
        public static string netWorkInfo;


        private delegate void SetPos(int ipos);     //更新进度列表
        Thread thr1;//进度条更新线程
        Thread thr2;//获取系统信息线程

        //线程执行方法
        public void reloadInfo()
        {
            HardwareHandler hh = new HardwareHandler();
            cpuInfo = hh.CpuInfo();
            memInfo = hh.MemInfo();
            baseBoardInfo = hh.BaseBoardInfo();
            diskDriveInfo = hh.DiskDriveInfo();
            osInfo = hh.OsInfo();
            displayCardInfo = hh.DisplayControllerConfiguration();
            netWorkInfo = hh.NetWorkInfo();
        }

        //构造方法
        public Frm_Start()
        {
            InitializeComponent();
        }

        //窗口加载
        public void Frm_Start_Load(object sender, EventArgs e)
        {
            thr1 = new Thread(new ThreadStart(SleepT)); //创建窗口就开辟一个新线程
            thr1.Start();
        }

        //进度条值更新函数
        private void SetTextMessage(int ipos)//
        {      
            if (this.InvokeRequired)
            {
                SetPos setpos = new SetPos(SetTextMessage);
                this.Invoke(setpos, new object[] { ipos });
            }
            else
            {
                //this.label1.Text = ipos.ToString() + "/100";
                this.progressBar1.Value = Convert.ToInt32(ipos);
                if (this.progressBar1.Value == 1)
                {
                    thr2 = new Thread(new ThreadStart(reloadInfo));
                    thr2.Start();
                }
                if (this.progressBar1.Value == this.progressBar1.Maximum)
                {
                    this.Hide();
                    Frm_Main frm_main = new Frm_Main();
                    frm_main.Show();
                }
            }
        }

        private void SleepT()
        {
            for (int i = 0; i <= 100; i++)
            {
                System.Threading.Thread.Sleep(1); //Sleep中的时间任意填写，数字越小，进度条的速度越快
                SetTextMessage(100 * i / 100);
            }
        }

    }
}
