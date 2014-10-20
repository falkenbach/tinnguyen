﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace FB
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
            Application.Run(new App_Present.FaceBookManager());
        }
    }
}