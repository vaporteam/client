using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cliente
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            while (true)
            {
                getPos();
                Thread.Sleep(100);
            }
            Config.TryLoad();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private static void getPos()
        {
            Point point = new Point();

            bool result = WindowsAPI.GetCursorPos(ref point);

            int x = point.X;
            int y = point.Y;

            Console.WriteLine(x + " " + y);
        }
        public class WindowsAPI
        {
            [DllImport("user32.dll")]
            public static extern bool GetCursorPos(ref Point pt);
        }
    }
}
