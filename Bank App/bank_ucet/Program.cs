﻿using System;
using System.Windows.Forms;

namespace bank_ucet
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}
