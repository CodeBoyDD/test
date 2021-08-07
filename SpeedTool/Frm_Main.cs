using Microsoft.Win32;
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
    public partial class Frm_Main : Form
    {
        //构造方法
        public Frm_Main()
        {
            InitializeComponent();
        }

        //主程序-窗口预加载
        private void Frm_Main_Shown(object sender, EventArgs e)
        {          
        }

        //主程序-窗口加载
        private void Frm_Main_Load(object sender, EventArgs e)
        {
        }

        //系统检测按钮-点击-系统检测窗口创建
        private void btn_System_Click(object sender, EventArgs e)
        {
            Frm_System systemcheck = new SpeedTool.Frm_System();
            systemcheck.Show();
        }

        //垃圾清理按钮-点击-垃圾清理窗口创建
        private void btn_Clean_Click(object sender, EventArgs e)
        {
            Frm_Clean frm_clean = new Frm_Clean();
            frm_clean.Show();
        }

        //优化加速按钮-点击-优化加速窗口创建
        private void btn_YouHua_Click(object sender, EventArgs e)
        {
            Frm_Optimize optimize = new Frm_Optimize();
            optimize.Show();
        }

        //实用工具按钮-点击-实用工具窗口创建
        private void btn_Tool_Click(object sender, EventArgs e)
        {
            Frm_Tools frm_tools = new SpeedTool.Frm_Tools();
            frm_tools.Show();
        }

        //程序主界面-窗口大小变化-实现系统托盘
        private void Frm_Main_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                //notifyIcon1.Visible = false;//隐藏托盘图标
            }
            else if (this.WindowState == FormWindowState.Minimized)//最小化
            {
                this.Hide();//隐藏当前窗体
                notifyIcon1.Visible = true;//显示托盘图标
            }
        }

        //程序主界面-关闭
        private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        //任务栏图标-双击
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)//当最小化状态
            {
                this.Show();//显示当前窗体
                this.WindowState = FormWindowState.Normal;//还原窗体
            }
        }

        //任务栏-显示主界面
        private void ShowMainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1_MouseDoubleClick(null, null);
        }

        //任务栏-退出
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //任务栏-是否开机自启
        private void startupSelf_CheckedChanged(object sender, EventArgs e)
        {
            if (startupSelf.Checked == true)//勾选开机自启
            {                
                string starupPath = Application.ExecutablePath;//获取程序执行路径
                RegistryKey loca = Registry.CurrentUser;
                RegistryKey run = loca.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                try
                {                   
                    run.SetValue("qidong", starupPath);//SetValue:存储值的名称
                    MessageBox.Show("已启用开机运行!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loca.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else//取消开机自启
            {                
                string starupPath = Application.ExecutablePath;//获取程序执行路径
                RegistryKey loca = Registry.CurrentUser;
                RegistryKey run = loca.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                try
                {              
                    run.DeleteValue("qidong");//SetValue:存储值的名称
                    MessageBox.Show("已停止开机运行!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loca.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message.ToString(), "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
