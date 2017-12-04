using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rft_raktarnyilvantarto
{
    static class Program
    {
        // Itt tárolom azt a terméket, amit fel akarunk vinni a rendszerbe
        public static Termek UjTermek;
        public static bool MenteniKell;

        //Fő felület
        public static Form1 MainForm1 = new Form1();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(MainForm1);
        }
    }
}
