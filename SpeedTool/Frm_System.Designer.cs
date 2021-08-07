namespace SpeedTool
{
    partial class Frm_System
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_System));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_CpuInfo = new System.Windows.Forms.ToolStripButton();
            this.tsb_MemInfo = new System.Windows.Forms.ToolStripButton();
            this.tsb_BaseBoardInfo = new System.Windows.Forms.ToolStripButton();
            this.tsb_DiskInfo = new System.Windows.Forms.ToolStripButton();
            this.tsb_OsInfo = new System.Windows.Forms.ToolStripButton();
            this.tsb_DisplayCardInfo = new System.Windows.Forms.ToolStripButton();
            this.tsb_NetWorkInfo = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.InfoText = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 201);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_CpuInfo,
            this.tsb_MemInfo,
            this.tsb_BaseBoardInfo,
            this.tsb_DiskInfo,
            this.tsb_OsInfo,
            this.tsb_DisplayCardInfo,
            this.tsb_NetWorkInfo});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(106, 201);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_CpuInfo
            // 
            this.tsb_CpuInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_CpuInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tsb_CpuInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsb_CpuInfo.Image")));
            this.tsb_CpuInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_CpuInfo.Name = "tsb_CpuInfo";
            this.tsb_CpuInfo.Size = new System.Drawing.Size(104, 25);
            this.tsb_CpuInfo.Text = "CPU信息";
            this.tsb_CpuInfo.Click += new System.EventHandler(this.tsb_CpuInfo_Click);
            // 
            // tsb_MemInfo
            // 
            this.tsb_MemInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_MemInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.tsb_MemInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsb_MemInfo.Image")));
            this.tsb_MemInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_MemInfo.Name = "tsb_MemInfo";
            this.tsb_MemInfo.Size = new System.Drawing.Size(104, 25);
            this.tsb_MemInfo.Text = "内存信息";
            this.tsb_MemInfo.Click += new System.EventHandler(this.tsb_MemInfo_Click);
            // 
            // tsb_BaseBoardInfo
            // 
            this.tsb_BaseBoardInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_BaseBoardInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.tsb_BaseBoardInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsb_BaseBoardInfo.Image")));
            this.tsb_BaseBoardInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_BaseBoardInfo.Name = "tsb_BaseBoardInfo";
            this.tsb_BaseBoardInfo.Size = new System.Drawing.Size(104, 25);
            this.tsb_BaseBoardInfo.Text = "主板信息";
            this.tsb_BaseBoardInfo.Click += new System.EventHandler(this.tsb_BaseBoardInfo_Click);
            // 
            // tsb_DiskInfo
            // 
            this.tsb_DiskInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_DiskInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.tsb_DiskInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsb_DiskInfo.Image")));
            this.tsb_DiskInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_DiskInfo.Name = "tsb_DiskInfo";
            this.tsb_DiskInfo.Size = new System.Drawing.Size(104, 25);
            this.tsb_DiskInfo.Text = "硬盘信息";
            this.tsb_DiskInfo.Click += new System.EventHandler(this.tsb_DiskInfo_Click);
            // 
            // tsb_OsInfo
            // 
            this.tsb_OsInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_OsInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.tsb_OsInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsb_OsInfo.Image")));
            this.tsb_OsInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_OsInfo.Name = "tsb_OsInfo";
            this.tsb_OsInfo.Size = new System.Drawing.Size(104, 25);
            this.tsb_OsInfo.Text = "操作系统信息";
            this.tsb_OsInfo.Click += new System.EventHandler(this.tsb_OsInfo_Click);
            // 
            // tsb_DisplayCardInfo
            // 
            this.tsb_DisplayCardInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_DisplayCardInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.tsb_DisplayCardInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsb_DisplayCardInfo.Image")));
            this.tsb_DisplayCardInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_DisplayCardInfo.Name = "tsb_DisplayCardInfo";
            this.tsb_DisplayCardInfo.Size = new System.Drawing.Size(104, 25);
            this.tsb_DisplayCardInfo.Text = "显卡信息";
            this.tsb_DisplayCardInfo.Click += new System.EventHandler(this.tsb_DisplayCardInfo_Click);
            // 
            // tsb_NetWorkInfo
            // 
            this.tsb_NetWorkInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_NetWorkInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.tsb_NetWorkInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsb_NetWorkInfo.Image")));
            this.tsb_NetWorkInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_NetWorkInfo.Name = "tsb_NetWorkInfo";
            this.tsb_NetWorkInfo.Size = new System.Drawing.Size(104, 25);
            this.tsb_NetWorkInfo.Text = "网络信息";
            this.tsb_NetWorkInfo.Click += new System.EventHandler(this.tsb_NetWorkInfo_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.InfoText);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(106, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 201);
            this.panel2.TabIndex = 0;
            // 
            // InfoText
            // 
            this.InfoText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoText.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InfoText.Location = new System.Drawing.Point(0, 0);
            this.InfoText.Name = "InfoText";
            this.InfoText.Size = new System.Drawing.Size(288, 201);
            this.InfoText.TabIndex = 0;
            // 
            // Frm_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 201);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_System";
            this.Text = "系统检测";
            this.Load += new System.EventHandler(this.Frm_System_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_CpuInfo;
        private System.Windows.Forms.ToolStripButton tsb_MemInfo;
        private System.Windows.Forms.ToolStripButton tsb_BaseBoardInfo;
        private System.Windows.Forms.ToolStripButton tsb_DiskInfo;
        private System.Windows.Forms.ToolStripButton tsb_OsInfo;
        private System.Windows.Forms.ToolStripButton tsb_DisplayCardInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripButton tsb_NetWorkInfo;
        public  System.Windows.Forms.Label InfoText;
    }
}