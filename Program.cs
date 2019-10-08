using mdc.m7.setup.Forms;
using System;
using System.Windows.Forms;

namespace mdc.m7.setup
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BaseSetup());
        }
    }
}


