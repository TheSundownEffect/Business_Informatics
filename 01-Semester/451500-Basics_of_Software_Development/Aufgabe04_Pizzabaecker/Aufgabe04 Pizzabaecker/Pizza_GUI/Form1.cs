using System;
using System.Windows.Forms;
using Pizza_Instanz;

namespace Pizza_GUI
{
    // Beispiel GUI-Implementierung des Pizzabäckers. Dabei
    // konnte die Klasse Pizza unverändert (!) wiederver-
    // wendet werden. Mittels Hinzufügen wurde dazu im Pro-
    // jekt ein Verweis auf die Pizza.cs aus dem Projekt
    // Pizza_Instanz angebracht und zusätzlich der Namespace
    // Pizza_Instanz mittels using importiert.
    
    public partial class frmPizzaBaecker : Form
    {
        Pizza p = new Pizza();
        
        public frmPizzaBaecker()
        {
            InitializeComponent();
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            p.durchmesser = Byte.Parse(tbxDurchmesser.Text);
            lblPreis.Text = p.berechnePreis().ToString("C");  // C = Currency

            tbxDurchmesser.Focus();
            tbxDurchmesser.SelectAll();
        }

     }
}
