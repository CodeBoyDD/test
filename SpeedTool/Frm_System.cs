using MyStudy.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpeedTool
{
    public partial class Frm_System : Form
    {
        //构造方法
        public Frm_System()
        {
            InitializeComponent();
        }

        //加载窗口
        private void Frm_System_Load(object sender, EventArgs e)
        {

        }

        //按钮获取CPU信息
        public void tsb_CpuInfo_Click(object sender, EventArgs e)
        {      
            InfoText.Text = Frm_Start.cpuInfo;
        }

        //按钮获取Mem信息
        private void tsb_MemInfo_Click(object sender, EventArgs e)
        {
            InfoText.Text = Frm_Start.memInfo;
        }

        ////按钮获取主板信息
        private void tsb_BaseBoardInfo_Click(object sender, EventArgs e)
        {
            InfoText.Text = Frm_Start.baseBoardInfo;
        }

        //按钮获取硬盘信息
        private void tsb_DiskInfo_Click(object sender, EventArgs e)
        {
            InfoText.Text = Frm_Start.diskDriveInfo;
        }

        //按钮获取系统信息
        private void tsb_OsInfo_Click(object sender, EventArgs e)
        {
            InfoText.Text = Frm_Start.osInfo;
        }

        //按钮获取显卡信息
        private void tsb_DisplayCardInfo_Click(object sender, EventArgs e)
        {
            InfoText.Text = Frm_Start.displayCardInfo;
        }

        //按钮获取网络信息
        private void tsb_NetWorkInfo_Click(object sender, EventArgs e)
        {
            InfoText.Text = Frm_Start.netWorkInfo;
        }
    }
}
