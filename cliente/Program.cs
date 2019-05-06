using Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
            InputLogger k = new InputLogger();

            ThreadPool.QueueUserWorkItem((s) => {
                while (true)
                {
                    Console.WriteLine("Cursor Pos {0}\nKeypress since last: {1}", k.GetCursorPosition(), k.GetKeypressNumber());
                    Thread.Sleep(5 * Duration.Minute);
                }
            });

            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            k.UnHook();
        }
    }
}
