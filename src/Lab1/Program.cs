using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    /// <summary>
    /// Класс Program
    /// основной класс программы, рассчитывающией расстояние Левенштейна
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Метод Main
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
