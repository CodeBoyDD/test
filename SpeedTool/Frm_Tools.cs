using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;//操作系统注册表


namespace SpeedTool
{
    public partial class Frm_Tools : Form
    {
        //构造方法
        public Frm_Tools()
        {
            InitializeComponent();
        }

        //窗口加载
        private void Frm_Tools_Load(object sender, EventArgs e)
        {
        }

        //DX诊断工具
        private void DX_Tool_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("dxdiag.exe");
        }

        //网络连接
        private void NetWorkConnection_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("ncpa.cpl");
        }

        //程序和功能-->卸载软件
        private void ProgramsFunctions_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("appwiz.cpl");
        }

        //控制面板
        private void ControlPanel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("control.exe");
        }

        //设备管理器
        private void DeviceManager_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("hdwwiz.cpl");           
        }

        //计算机管理
        private void ComputerManager_Click(object sender, EventArgs e)
        {          
            System.Diagnostics.Process.Start("compmgmt.msc");
        }

        //自制CMD
        private void MineCMD_Click(object sender, EventArgs e)
        {
            new Frm_Tools_CMD().Show();
        }

        //服务
        private void Service_Click(object sender, EventArgs e)
        {          
            System.Diagnostics.Process.Start("services.msc");
        }

        //DNS修复
        private void DNSFix_Click(object sender, EventArgs e)
        {

        }

        //网络测速
        private void NetWorkTest_Click(object sender, EventArgs e)
        {
            new Frm_Tools_NetWorkTest().Show();
        }

        //系统信息
        private void Clean_Click(object sender, EventArgs e)
        {          
            System.Diagnostics.Process.Start("msinfo32.exe");
        }

        //刷新DNS缓存
        private void DNSFlush_Click(object sender, EventArgs e)
        {
            string command = "ipconfig /flushdns"; 
            ExecuteCMDMath(command);
            MessageBox.Show("DNS刷新成功", "刷新成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //执行不带返回值的cmd指令方法
        public void ExecuteCMDMath(string command)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", "/S /C " + command)
            {
                CreateNoWindow = true,
                UseShellExecute = true,
                WindowStyle = ProcessWindowStyle.Hidden
            };
            Process.Start(processInfo);
        }

        //执行带返回值的cmd指令方法
        //public string ExecuteCMDWithOutput(string command)
        //{
        //    ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", "/S /C " + command)
        //    {
        //        CreateNoWindow = true,
        //        UseShellExecute = false,
        //        WindowStyle = ProcessWindowStyle.Hidden,
        //        RedirectStandardOutput = true
        //    };

        //    Process process = new Process { StartInfo = processInfo };
        //    process.Start();
        //    string outpup = process.StandardOutput.ReadToEnd();

        //    process.WaitForExit();
        //    return outpup;
        //}
    }
}
