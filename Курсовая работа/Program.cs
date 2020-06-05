using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_работа
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DB dB = new DB();
            User user = new User();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
         
            if (dB.users != null)
            {
                Application.Run(new Form4(dB));
            }
            else
            {
                Application.Run(new Form1(user));
            }
        }
    }
}
