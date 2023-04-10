using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Othello
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()      //  http://www.codearsenal.net/2012/06/c-sharp-read-excel-and-show-in-wpf.html
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new othello_form());
        }
    }
}