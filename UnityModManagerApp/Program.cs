﻿using System;
using System.Windows.Forms;

namespace UnityModManagerNet.Installer
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UnityModManagerForm());
        }
    }
}
