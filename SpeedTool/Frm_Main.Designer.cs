namespace SpeedTool
{
    partial class Frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btn_System = new System.Windows.Forms.Button();
            this.btn_Clean = new System.Windows.Forms.Button();
            this.btn_YouHua = new System.Windows.Forms.Button();
            this.btn_Tool = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.startupSelf = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMainMenuItem,
            this.startupSelf,
            this.exitMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // showMainMenuItem
            // 
            this.showMainMenuItem.Name = "showMainMenuItem";
            this.showMainMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showMainMenuItem.Text = "显示主界面";
            this.showMainMenuItem.Click += new System.EventHandler(this.ShowMainToolStripMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitMenuItem.Text = "退出";
            this.exitMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "SpeedTool";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // btn_System
            // 
            this.btn_System.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_System.Location = new System.Drawing.Point(262, 12);
            this.btn_System.Name = "btn_System";
            this.btn_System.Size = new System.Drawing.Size(120, 30);
            this.btn_System.TabIndex = 1;
            this.btn_System.Text = "系统检测";
            this.btn_System.UseVisualStyleBackColor = true;
            this.btn_System.Click += new System.EventHandler(this.btn_System_Click);
            // 
            // btn_Clean
            // 
            this.btn_Clean.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Clean.Location = new System.Drawing.Point(262, 62);
            this.btn_Clean.Name = "btn_Clean";
            this.btn_Clean.Size = new System.Drawing.Size(120, 30);
            this.btn_Clean.TabIndex = 2;
            this.btn_Clean.Text = "电脑清理";
            this.btn_Clean.UseVisualStyleBackColor = true;
            this.btn_Clean.Click += new System.EventHandler(this.btn_Clean_Click);
            // 
            // btn_YouHua
            // 
            this.btn_YouHua.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_YouHua.Location = new System.Drawing.Point(262, 112);
            this.btn_YouHua.Name = "btn_YouHua";
            this.btn_YouHua.Size = new System.Drawing.Size(120, 30);
            this.btn_YouHua.TabIndex = 3;
            this.btn_YouHua.Text = "加速优化";
            this.btn_YouHua.UseVisualStyleBackColor = true;
            this.btn_YouHua.Click += new System.EventHandler(this.btn_YouHua_Click);
            // 
            // btn_Tool
            // 
            this.btn_Tool.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Tool.Location = new System.Drawing.Point(262, 162);
            this.btn_Tool.Name = "btn_Tool";
            this.btn_Tool.Size = new System.Drawing.Size(120, 30);
            this.btn_Tool.TabIndex = 4;
            this.btn_Tool.Text = "实用工具";
            this.btn_Tool.UseVisualStyleBackColor = true;
            this.btn_Tool.Click += new System.EventHandler(this.btn_Tool_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 180);
            this.label2.TabIndex = 6;
            this.label2.Text = "                    SpeedTool\r\nSpeedTool是一款简单的优化工具，包含了些简单且实用的小功能。欢迎大家使用。\r\n同时欢迎继续关" +
    "注更新及时白嫖！\r\n\r\n版本：v0.1\r\n作者：DD白给王\r\n邮箱：2568951696@qq.com\r\n";
            // 
            // startupSelf
            // 
            this.startupSelf.CheckOnClick = true;
            this.startupSelf.Name = "startupSelf";
            this.startupSelf.Size = new System.Drawing.Size(180, 22);
            this.startupSelf.Text = "开机自启";
            this.startupSelf.CheckedChanged += new System.EventHandler(this.startupSelf_CheckedChanged);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 201);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Tool);
            this.Controls.Add(this.btn_YouHua);
            this.Controls.Add(this.btn_Clean);
            this.Controls.Add(this.btn_System);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_Main";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpeedTool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Main_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.Shown += new System.EventHandler(this.Frm_Main_Shown);
            this.SizeChanged += new System.EventHandler(this.Frm_Main_SizeChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btn_System;
        private System.Windows.Forms.Button btn_Clean;
        private System.Windows.Forms.Button btn_YouHua;
        private System.Windows.Forms.Button btn_Tool;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem startupSelf;
    }
}

