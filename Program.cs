using HealthClinic.Forms;
using HealthClinic.Forms__Views_;
using System;
using System.Windows.Forms;

namespace HealthClinic
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //necesar pentru conectarea la baza de date
            HealthClinicEntities _ctx = new HealthClinicEntities();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(_ctx));
        }
    }
}
