using System;
using System.Windows.Forms;

namespace CaesarCipher
{
    static class Program
    {
        /// <summary>
        /// Основная точка входа в программу
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormWork());
        }
    }
}
