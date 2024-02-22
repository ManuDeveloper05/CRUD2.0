
using Microsoft.Extensions.Configuration;
using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD2._0
{
 

    internal static class Program
    {
        internal static IConfiguration Configuration = null;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // Inicia NLog
            LogManager.LoadConfiguration("C:\\Users\\Sandy Connet\\source\\repos\\CRUD2.0\\Data\\Nlog.config");

            Configuration = new ConfigurationBuilder()
             .AddJsonFile("appsettings.json")
             .Build();






            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }
    }
}
