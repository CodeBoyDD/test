using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

//foreach (var property in mc.Properties) //查找对应属性
//{
//    Console.WriteLine(property.Name + ":" + property.Value);
//}
namespace MyStudy.Utility
{  
    /// 计算机硬件处理类
    public class HardwareHandler
    {
        //枚举硬件
        public enum WMIPath
        {
            // 硬件
            Win32_Processor, // CPU 处理器
            Win32_PhysicalMemory, // 物理内存条
            Win32_Keyboard, // 键盘
            Win32_PointingDevice, // 点输入设备，包括鼠标。
            Win32_FloppyDrive, // 软盘驱动器
            Win32_DiskDrive, // 硬盘驱动器
            Win32_CDROMDrive, // 光盘驱动器
            Win32_BaseBoard, // 主板
            Win32_BIOS, // BIOS 芯片
            Win32_ParallelPort, // 并口
            Win32_SerialPort, // 串口
            Win32_SerialPortConfiguration, // 串口配置
            Win32_SoundDevice, // 多媒体设置，一般指声卡。
            Win32_SystemSlot, // 主板插槽 (ISA & PCI & AGP)
            Win32_USBController, // USB 控制器
            Win32_NetworkAdapter, // 网络适配器
            Win32_NetworkAdapterConfiguration, // 网络适配器设置
            Win32_Printer, // 打印机
            Win32_PrinterConfiguration, // 打印机设置
            Win32_PrintJob, // 打印机任务
            Win32_TCPIPPrinterPort, // 打印机端口
            Win32_POTSModem, // MODEM
            Win32_POTSModemToSerialPort, // MODEM 端口        
            Win32_DesktopMonitor, // 显示器
            Win32_DisplayConfiguration, // 显卡
            Win32_DisplayControllerConfiguration, // 显卡设置-可以是识别双显卡
            Win32_VideoController, // 显卡细节。
            Win32_VideoSettings, // 显卡支持的显示模式。
            // 操作系统
            Win32_TimeZone, // 时区
            Win32_SystemDriver, // 驱动程序
            Win32_DiskPartition, // 磁盘分区
            Win32_LogicalDisk, // 逻辑磁盘
            Win32_LogicalDiskToPartition, // 逻辑磁盘所在分区及始末位置。
            Win32_LogicalMemoryConfiguration, // 逻辑内存配置
            Win32_PageFile, // 系统页文件信息
            Win32_PageFileSetting, // 页文件设置
            Win32_BootConfiguration, // 系统启动配置
            Win32_ComputerSystem, // 计算机信息简要
            Win32_OperatingSystem, // 操作系统信息
            Win32_StartupCommand, // 系统自动启动程序
            Win32_Service, // 系统安装的服务
            Win32_Group, // 系统管理组
            Win32_GroupUser, // 系统组帐号
            Win32_UserAccount, // 用户帐号
            Win32_Process, // 系统进程
            Win32_Thread, // 系统线程
            Win32_Share, // 共享
            Win32_NetworkClient, // 已安装的网络客户端
            Win32_NetworkProtocol, // 已安装的网络协议
        }

        // Cpu信息
        public string CpuInfo()
        {
            try
            {
                ManagementClass mc = new ManagementClass(WMIPath.Win32_Processor.ToString());
                ManagementObjectCollection moc = mc.GetInstances();

                string cpuInfo ="";
                foreach (ManagementObject mo in moc)
                {
                    string name = "CPU:" + mo.Properties["Name"].Value.ToString();
                    string addressWidth = "位数:" + mo.Properties["AddressWidth"].Value.ToString() + "位";
                    string loadPercentage = "占用:" + mo.Properties["LoadPercentage"].Value.ToString() + "%";
                    string manufacturer = "制造商:" + mo.Properties["Manufacturer"].Value.ToString();
                    string maxClockSpee = "基准速率:" + (Convert.ToDouble(mo.Properties["MaxClockSpeed"].Value) / 1024).ToString("F2") + "GHZ";
                    string numberOfCores = "核心数:" + mo.Properties["NumberOfCores"].Value.ToString();
                    string numberOfLogicalProcessors = "逻辑处理器数:" + mo.Properties["NumberOfLogicalProcessors"].Value.ToString();
                    string threadCount = "线程数:" + mo.Properties["ThreadCount"].Value.ToString();
                    string systemName = "主机名称:" + mo.Properties["SystemName"].Value.ToString();
                    cpuInfo = name + '\n' + addressWidth + '\n' + loadPercentage + '\n' + manufacturer + '\n' + maxClockSpee
                        + '\n' + numberOfCores + '\n' + numberOfLogicalProcessors + '\n' + threadCount + '\n' + systemName;
                }
                return cpuInfo;
            }
            catch
            {
                return "CPU信息读取失败！！！";
            }

        }

        //内存信息
        public string MemInfo()
        {
            try
            {
                ManagementClass mc = new ManagementClass(WMIPath.Win32_PhysicalMemory.ToString());
                ManagementObjectCollection moc = mc.GetInstances();
  
                string memInfo = "";
                foreach (ManagementObject mo in moc)
                {
                    string name = "内存类型：" + mo.Properties["Name"].Value.ToString();
                    string manufacturer = "制造商：" + mo.Properties["Manufacturer"].Value.ToString();
                    string capacity = "内存大小：" + (Convert.ToDouble(mo.Properties["Capacity"].Value) / (1024 * 1024 * 1024)).ToString() + "G";
                    string channel = mo.Properties["DeviceLocator"].Value.ToString();
                    string deviceLocator = "";
                    if (channel == "ChannelA-DIMM0")
                    {
                        deviceLocator = "内存通道：" + mo.Properties["DeviceLocator"].Value.ToString() + " 单通道内存";
                    }
                    else
                    {
                        deviceLocator = "内存通道：" + mo.Properties["DeviceLocator"].Value.ToString() + " 双通道内存";
                    }
                    string speed = "内存速度：" + mo.Properties["Speed"].Value.ToString() + "MHZ";
                    memInfo = name +'\n'+ deviceLocator +'\n'+ manufacturer +'\n'+ capacity +'\n'+ speed;                 
                }
                return memInfo;
            }
            catch
            {
                return "内存信息读取失败！！！";
            }
        }

        // 主板信息
        public string BaseBoardInfo()
        {
            try
            {
                ManagementClass mc = new ManagementClass(WMIPath.Win32_BaseBoard.ToString());
                ManagementObjectCollection moc = mc.GetInstances();

                string baseBoardInfo = "";
                foreach (ManagementObject mo in moc)
                {
                    string serialNumber = "主板ID：" + mo.Properties["SerialNumber"].Value.ToString();
                    string manufacturer = "制造商：" + mo.Properties["Manufacturer"].Value.ToString();
                    string product = "型号：" + mo.Properties["Product"].Value.ToString();
                    string version = "版本：" + mo.Properties["Version"].Value.ToString();
                    baseBoardInfo = serialNumber +'\n'+ manufacturer +'\n'+ product +'\n'+ version;
                }
                return baseBoardInfo;
            }
            catch
            {
                return "主板信息读取失败！！！";
            }
        }

        // 硬盘信息
        public string DiskDriveInfo()
        {
            try
            {
                ManagementClass mc = new ManagementClass(WMIPath.Win32_DiskDrive.ToString());
                ManagementObjectCollection moc = mc.GetInstances();

                string diskDriveInfo = "";
                foreach (ManagementObject mo in moc)
                {
                    string serialNumber = "硬盘ID：" + mo.Properties["SerialNumber"].Value.ToString();
                    string interfaceType = "硬盘接口：" + mo.Properties["InterfaceType"].Value.ToString();
                    string description = "硬盘：" + mo.Properties["Description"].Value.ToString();
                    string model = "型号：" + mo.Properties["Model"].Value.ToString();
                    string partitions = "分区数：" + mo.Properties["Partitions"].Value.ToString();
                    string size = "硬盘容量：" + (Convert.ToInt64(mo.Properties["Size"].Value) / (1024 * 1024 * 1024)).ToString() + "G";
                    diskDriveInfo = serialNumber + '\n' + model + '\n' + description + '\n' + model + '\n' + partitions + '\n' + size;
                }
                
                return diskDriveInfo;
            }
            catch
            {
                return "硬盘信息读取失败！！！";
            }

        }

        // 操作系统信息
        public string OsInfo()
        {
            try
            {
                ManagementClass mc = new ManagementClass(WMIPath.Win32_OperatingSystem.ToString());
                ManagementObjectCollection moc = mc.GetInstances();
                string osInfo = "";
                foreach (ManagementObject mo in moc)
                {
                    string name = "操作系统：" + mo.Properties["Name"].Value.ToString();
                    string version = "版本：" + mo.Properties["Version"].Value.ToString();
                    string bootDevice = "引导设备：" + mo.Properties["BootDevice"].Value.ToString();
                    string OSArchitecture = "系统架构：" + mo.Properties["OSArchitecture"].Value.ToString();
                    string systemDirectory = "系统目录：" + mo.Properties["SystemDirectory"].Value.ToString();
                    osInfo = name +'\n'+ version + '\n'+ bootDevice + '\n'+ OSArchitecture + '\n'+ systemDirectory;
                }
                return osInfo;
            }
            catch
            {
                return "操作系统信息读取失败！！！";
            }
        }

        //显卡信息       
        public string DisplayControllerConfiguration()
        {
            ManagementClass mc = new ManagementClass(WMIPath.Win32_VideoController.ToString());
            ManagementObjectCollection moc = mc.GetInstances();

            try
            {
                string displayControllerConfiguration = "";
                List<string> videoInfo = new List<string>();
                foreach (ManagementObject mo in moc)
                {
                    videoInfo.Add("设备名称：" + mo.Properties["Name"].Value.ToString());
                    videoInfo.Add("显卡类型：" + mo.Properties["AdapterCompatibility"].Value.ToString());
                    videoInfo.Add("显示内存：" + (Convert.ToDouble(mo.Properties["AdapterRAM"].Value) / (1024 * 1024 * 1024)).ToString("F2") + "GB");
                    videoInfo.Add("驱动版本：" + mo.Properties["DriverVersion"].Value.ToString());
                    string st = mo.Properties["Status"].Value.ToString();
                    if (st == "OK")
                    {
                        videoInfo.Add("显卡状态：已开启");
                    }
                    else
                    {
                        videoInfo.Add("显卡状态：已关闭");
                    }
                }
                for (int i = 0; i < videoInfo.Count; i++)
                {
                    displayControllerConfiguration = displayControllerConfiguration + videoInfo[i].ToString() + '\n';
                }
                return displayControllerConfiguration;
            }
            catch
            {
                return "显卡信息读取失败！！！";
            }
        }

        //网络信息
        public string NetWorkInfo()
        {
            try
            {
                string stringMAC = "";
                string stringIP = "";
                string stringName = "";
                string netWorkInfo = "";
                ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection moc = mc.GetInstances();

                foreach (ManagementObject mo in moc)
                {
                    if ((bool)mo["IPEnabled"] == true)
                    {
                        stringMAC += mo["MACAddress"].ToString(); //stringMAC = stringMAC + mo["MACAddress"].ToString();
                        string[] IPAddresses = (string[])mo["IPAddress"];//字符串数组保持强制类型转化的ipaddress
                        stringName += mo["Caption"].ToString();
                        if (IPAddresses.Length > 0)
                        {
                            stringIP = "IP地址：" + IPAddresses[0];
                        }
                    }           
                }
                netWorkInfo = "网卡：" + stringName +'\n'+ stringIP +'\n'+ "MAC地址："+ stringMAC;
                return netWorkInfo;
            }
            catch
            {
                return "网络信息读取失败！！！";
            }
        }
    }

}

