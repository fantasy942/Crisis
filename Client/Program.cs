﻿using System;
using System.Windows.Forms;
using Crisis.View;

namespace Crisis
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());
            Application.Run(new CrisisContext());
        }
    }
}
