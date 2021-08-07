namespace SpeedTool
{
    partial class Frm_Tools
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DNSFlush = new System.Windows.Forms.Button();
            this.DNSFix = new System.Windows.Forms.Button();
            this.SystemInfo = new System.Windows.Forms.Button();
            this.ProgramsFunctions = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Service = new System.Windows.Forms.Button();
            this.MineCMD = new System.Windows.Forms.Button();
            this.DX_Tool = new System.Windows.Forms.Button();
            this.DeviceManager = new System.Windows.Forms.Button();
            this.NetWorkTest = new System.Windows.Forms.Button();
            this.NetWorkConnection = new System.Windows.Forms.Button();
            this.ComputerManager = new System.Windows.Forms.Button();
            this.ControlPanel = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.DNSFlush);
            this.panel1.Controls.Add(this.DNSFix);
            this.panel1.Controls.Add(this.SystemInfo);
            this.panel1.Controls.Add(this.ProgramsFunctions);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Service);
            this.panel1.Controls.Add(this.MineCMD);
            this.panel1.Controls.Add(this.DX_Tool);
            this.panel1.Controls.Add(this.DeviceManager);
            this.panel1.Controls.Add(this.NetWorkTest);
            this.panel1.Controls.Add(this.NetWorkConnection);
            this.panel1.Controls.Add(this.ComputerManager);
            this.panel1.Controls.Add(this.ControlPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 201);
            this.panel1.TabIndex = 0;
            // 
            // DNSFlush
            // 
            this.DNSFlush.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DNSFlush.Location = new System.Drawing.Point(254, 200);
            this.DNSFlush.Name = "DNSFlush";
            this.DNSFlush.Size = new System.Drawing.Size(120, 30);
            this.DNSFlush.TabIndex = 12;
            this.DNSFlush.Text = "清空DNS缓存";
            this.DNSFlush.UseVisualStyleBackColor = true;
            this.DNSFlush.Click += new System.EventHandler(this.DNSFlush_Click);
            // 
            // DNSFix
            // 
            this.DNSFix.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DNSFix.Location = new System.Drawing.Point(254, 159);
            this.DNSFix.Name = "DNSFix";
            this.DNSFix.Size = new System.Drawing.Size(120, 30);
            this.DNSFix.TabIndex = 11;
            this.DNSFix.Text = "未实现";
            this.DNSFix.UseVisualStyleBackColor = true;
            this.DNSFix.Click += new System.EventHandler(this.DNSFix_Click);
            // 
            // SystemInfo
            // 
            this.SystemInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SystemInfo.Location = new System.Drawing.Point(129, 200);
            this.SystemInfo.Name = "SystemInfo";
            this.SystemInfo.Size = new System.Drawing.Size(120, 30);
            this.SystemInfo.TabIndex = 10;
            this.SystemInfo.Text = "系统信息";
            this.SystemInfo.UseVisualStyleBackColor = true;
            this.SystemInfo.Click += new System.EventHandler(this.Clean_Click);
            // 
            // ProgramsFunctions
            // 
            this.ProgramsFunctions.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ProgramsFunctions.Location = new System.Drawing.Point(3, 200);
            this.ProgramsFunctions.Name = "ProgramsFunctions";
            this.ProgramsFunctions.Size = new System.Drawing.Size(120, 30);
            this.ProgramsFunctions.TabIndex = 9;
            this.ProgramsFunctions.Text = "卸载软件";
            this.ProgramsFunctions.UseVisualStyleBackColor = true;
            this.ProgramsFunctions.Click += new System.EventHandler(this.ProgramsFunctions_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(254, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 130);
            this.label1.TabIndex = 8;
            this.label1.Text = "   系统工具\r\n说明：系统工具是调用Windows系统工具,现在开发\r\n常用的系统工具。简单使用。\r\n";
            // 
            // Service
            // 
            this.Service.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Service.Location = new System.Drawing.Point(128, 159);
            this.Service.Name = "Service";
            this.Service.Size = new System.Drawing.Size(120, 30);
            this.Service.TabIndex = 7;
            this.Service.Text = "服务";
            this.Service.UseVisualStyleBackColor = true;
            this.Service.Click += new System.EventHandler(this.Service_Click);
            // 
            // MineCMD
            // 
            this.MineCMD.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MineCMD.Location = new System.Drawing.Point(129, 110);
            this.MineCMD.Name = "MineCMD";
            this.MineCMD.Size = new System.Drawing.Size(120, 30);
            this.MineCMD.TabIndex = 6;
            this.MineCMD.Text = "自制CMD";
            this.MineCMD.UseVisualStyleBackColor = true;
            this.MineCMD.Click += new System.EventHandler(this.MineCMD_Click);
            // 
            // DX_Tool
            // 
            this.DX_Tool.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DX_Tool.Location = new System.Drawing.Point(128, 59);
            this.DX_Tool.Name = "DX_Tool";
            this.DX_Tool.Size = new System.Drawing.Size(120, 30);
            this.DX_Tool.TabIndex = 5;
            this.DX_Tool.Text = "DX诊断工具";
            this.DX_Tool.UseVisualStyleBackColor = true;
            this.DX_Tool.Click += new System.EventHandler(this.DX_Tool_Click);
            // 
            // DeviceManager
            // 
            this.DeviceManager.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DeviceManager.Location = new System.Drawing.Point(129, 12);
            this.DeviceManager.Name = "DeviceManager";
            this.DeviceManager.Size = new System.Drawing.Size(120, 30);
            this.DeviceManager.TabIndex = 4;
            this.DeviceManager.Text = "设备管理器";
            this.DeviceManager.UseVisualStyleBackColor = true;
            this.DeviceManager.Click += new System.EventHandler(this.DeviceManager_Click);
            // 
            // NetWorkTest
            // 
            this.NetWorkTest.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NetWorkTest.Location = new System.Drawing.Point(2, 159);
            this.NetWorkTest.Name = "NetWorkTest";
            this.NetWorkTest.Size = new System.Drawing.Size(120, 30);
            this.NetWorkTest.TabIndex = 3;
            this.NetWorkTest.Text = "网络测速";
            this.NetWorkTest.UseVisualStyleBackColor = true;
            this.NetWorkTest.Click += new System.EventHandler(this.NetWorkTest_Click);
            // 
            // NetWorkConnection
            // 
            this.NetWorkConnection.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NetWorkConnection.Location = new System.Drawing.Point(3, 110);
            this.NetWorkConnection.Name = "NetWorkConnection";
            this.NetWorkConnection.Size = new System.Drawing.Size(120, 30);
            this.NetWorkConnection.TabIndex = 2;
            this.NetWorkConnection.Text = "网络连接";
            this.NetWorkConnection.UseVisualStyleBackColor = true;
            this.NetWorkConnection.Click += new System.EventHandler(this.NetWorkConnection_Click);
            // 
            // ComputerManager
            // 
            this.ComputerManager.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComputerManager.Location = new System.Drawing.Point(3, 59);
            this.ComputerManager.Name = "ComputerManager";
            this.ComputerManager.Size = new System.Drawing.Size(120, 30);
            this.ComputerManager.TabIndex = 1;
            this.ComputerManager.Text = "计算机管理";
            this.ComputerManager.UseVisualStyleBackColor = true;
            this.ComputerManager.Click += new System.EventHandler(this.ComputerManager_Click);
            // 
            // ControlPanel
            // 
            this.ControlPanel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ControlPanel.Location = new System.Drawing.Point(3, 12);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(120, 30);
            this.ControlPanel.TabIndex = 0;
            this.ControlPanel.Text = "控制面板";
            this.ControlPanel.UseVisualStyleBackColor = true;
            this.ControlPanel.Click += new System.EventHandler(this.ControlPanel_Click);
            // 
            // Frm_Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 201);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_Tools";
            this.Text = "系统工具";
            this.Load += new System.EventHandler(this.Frm_Tools_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ControlPanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button ProgramsFunctions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Service;
        private System.Windows.Forms.Button MineCMD;
        private System.Windows.Forms.Button DX_Tool;
        private System.Windows.Forms.Button DeviceManager;
        private System.Windows.Forms.Button NetWorkTest;
        private System.Windows.Forms.Button NetWorkConnection;
        private System.Windows.Forms.Button ComputerManager;
        private System.Windows.Forms.Button DNSFlush;
        private System.Windows.Forms.Button DNSFix;
        private System.Windows.Forms.Button SystemInfo;
    }
}