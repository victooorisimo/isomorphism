﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Isomorphism
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.s
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeApplication());
        }
    }
}
