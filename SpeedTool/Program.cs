using Microsoft.Win32;
using MyStudy.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace SpeedTool
{
    static class Program
    {
        // 应用程序的主入口点--主线程
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Start());
        }
    }
}

