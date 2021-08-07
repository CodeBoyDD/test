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
    public partial class Frm_Clean : Form
    {
        Thread thr1;//清理垃圾线程
        private delegate void SetPos(int ipos);//更新进度列表

        //构造方法
        public Frm_Clean()
        {
            InitializeComponent();
        }

        //进度条值更新函数
        private void SetTextMessage(int ipos)
        {
            if (this.InvokeRequired)
            {
                SetPos setpos = new SetPos(SetTextMessage);
                this.Invoke(setpos, new object[] { ipos });
            }
            else
            {
                this.progressBar1.Value = Convert.ToInt32(ipos);
                if (this.progressBar1.Value == this.progressBar1.Maximum)
                {
                    MessageBox.Show("系统垃圾清理成功", "清理成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //新的线程执行函数==多线程的其他线程
        private void SleepT()
        {
            for (int i = 0; i <= 100; i++)
            {
                System.Threading.Thread.Sleep(1); //Sleep中的时间任意填写，数字越小，进度条的速度越快
                SetTextMessage(100 * i / 100);
            }
        }

        //清理按钮-点击
        private void btn_ConfrimClean_Click(object sender, EventArgs e)
        {
            thr1 = new Thread(new ThreadStart(SleepT)); //创建窗口就开辟一个新线程            
            int checkItemsNum = 0;
            for (int i=0;i<Clean_listView.Items.Count;i++)//遍历垃圾清理选项列表
            {             
                if (Clean_listView.Items[i].Checked == true)//判断列表项是否选中
                {
                    //实现清理
                    checkItemsNum++;
                }
            }
            if (checkItemsNum == 0)
            {
                MessageBox.Show("您没有选择清理项", "选择清理项", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                thr1.Start();
            }
        }

        //窗口加载
        private void Frm_Clean_Load(object sender, EventArgs e)
        {
        }
    }
}
