﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace C19_Ex01_Ohad_305070831_Tomer_204381487
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FacebookForm());
        }
    }
}
