using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memory
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 ob = new Form1();
            Application.Run(ob);
            int time_start = ob.GetTimeStart();
            int time_wait = ob.GetTimeWait();
            int lvl = ob.GetLevel();
            Application.Run(new Form2(time_start, time_wait, lvl, ob.get_nick()));
        }
    }
}
