using System;
using System.Windows.Forms;

// Kleiner Vorgeschmack auf EUI-Veranstaltung im 2. Semester

namespace Pizza_GUI
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPizzaBaecker());
        }
    }
}
