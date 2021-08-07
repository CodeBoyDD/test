using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SpeedTool
{
    
    public partial class Frm_Optimize : Form
    {

        public delegate void AddHandler(string cpu,string mem);//委托
        [DllImport("psapi.dll")]
        static extern int EmptyWorkingSet(IntPtr hwProc);//垃圾清理调用
       
        //构造方法
        public Frm_Optimize()
        {
            InitializeComponent();
            Thread thr4 = new Thread(new ThreadStart(GetInfo));
            thr4.Start();
            thr4.IsBackground = true;
        }

        //窗口加载
        private void Frm_Optimize_Load(object sender, EventArgs e)
        {         
        }

        //加速按钮--点击
        private void button1_Click(object sender, EventArgs e)
        {
            ClearMemory();
        }

        //加速内存方法实现
        public static void ClearMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                //对于系统进程会拒绝访问，导致出错，此处对异常不进行处理。
                try
                {
                    EmptyWorkingSet(process.Handle);
                }
                catch
                {
                }
            }
        }

        //动态实时获取CPU,Mem信息
        public void GetInfo()
        {
            string cpu;
            string mem;
            CpuMemInfo cpuMemInfo = new CpuMemInfo();
            while (true)
            {
                Thread.Sleep(1000);
                mem = string.Format("{0:##}%", ((float)cpuMemInfo.MemoryAvailable / (float)cpuMemInfo.PhysicalMemory) * 100);
                cpu = string.Format("{0:##}%", cpuMemInfo.CpuLoad);
                SetText(cpu,mem);
            }
        }

        //委托-跨线程访问UI控件
        private void SetText(string cpu,string mem)
        {
            //Control.InvokeReauqired判断是否是创建控件线程，不是为true，则需要invoke到创建控件的线程，是就为false，直接操作控件
            if (this.InvokeRequired)
            {
                AddHandler ah = new AddHandler(SetText);
                this.Invoke(ah, new object[] { cpu,mem });
            }
            else
            {
                CpuUseage.Text = cpu;
                MemUseage.Text = mem;
            }
        }
    }
}
