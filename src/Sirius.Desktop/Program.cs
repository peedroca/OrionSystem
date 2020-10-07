using Sirius.CrossCutting.Email.Models;
using Sirius.Desktop.Views;
using Sirius.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sirius.Desktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            new Settings(Sirius.Desktop.Properties.Resources.dbPath, new SenderEmail("Sirius"
                , "smtp.gmail.com"
                , 587
                , "orion.sirius.noreply@gmail.com"
                , "4OnrL#TFM4Dz"));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
