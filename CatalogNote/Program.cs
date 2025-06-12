using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogNote
{
    internal static class Program
    {
        public static CatalogData Catalog { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Catalog = DataStorage.Load();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ApplicationExit += OnApplicationExit;
            Application.Run(new Form1());
        }

        private static void OnApplicationExit(object sender, EventArgs e)
        {
            DataStorage.Save(Catalog);
        }
    }
}
