using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace RandoChoose
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            if (args.Length == 1 && int.TryParse(args[0], out int e))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Main());
            }
            else
            {
                Process p = new Process();
                p.StartInfo.FileName = @"RMGUpdater";
                p.StartInfo.Arguments = "RandoChoose";
                p.StartInfo.WorkingDirectory = Path.Combine(Directory.GetCurrentDirectory(), "update");
                p.Start();
                Environment.Exit(0);
            }
        }
    }
}