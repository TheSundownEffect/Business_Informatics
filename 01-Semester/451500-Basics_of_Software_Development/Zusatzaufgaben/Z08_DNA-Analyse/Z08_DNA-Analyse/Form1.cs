using System;
using System.Linq;
using System.Windows.Forms;

namespace Z08_DNA_Analyse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dna = tb_dna.Text;
            int dna_laenge = dna.Length;
            int dna1 = dna.Count(c => c == 'A');
            dna.Count();
            int dna2 = dna.Count(c => c == 'T');
            int dna3 = dna.Count(c => c == 'G');
            int dna4 = dna.Count(c => c == 'C');

            // BERECHNUNG
            double dna_a = Math.Round(Convert.ToDouble(dna1) / dna_laenge * 100);
            double dna_t = Math.Round(Convert.ToDouble(dna2) / dna_laenge * 100);
            double dna_g = Math.Round(Convert.ToDouble(dna3) / dna_laenge * 100);
            double dna_c = Math.Round(Convert.ToDouble(dna4) / dna_laenge * 100);
            double dna_other = 100 - (dna_a + dna_t + dna_g + dna_c);

            // AUSGABE
            label_a.Text = Convert.ToString(dna_a + " %");
            label_t.Text = Convert.ToString(dna_t + " %");
            label_g.Text = Convert.ToString(dna_g + " %");
            label_c.Text = Convert.ToString(dna_c + " %");
            //double dna5;
            label_other.Text = dna_other + " %";

            //UWE = Unten Wirds Eklig
            
        }
    }
}
