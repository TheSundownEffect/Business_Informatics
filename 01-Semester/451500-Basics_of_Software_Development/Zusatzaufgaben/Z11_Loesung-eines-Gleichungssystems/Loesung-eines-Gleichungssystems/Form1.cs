using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loesung_eines_Gleichungssystems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try { // EIGENTLICH ILLEGAL!!!

                // K = Koeffzientenmatrix
                double[][] K = new double[2][];
                K[0] = new double[2] { Convert.ToDouble(tb_lgs1_a.Text), Convert.ToDouble(tb_lgs1_b.Text) };
                K[1] = new double[2] { Convert.ToDouble(tb_lgs2_a.Text), Convert.ToDouble(tb_lgs2_b.Text) };
                // L = Lösungsvektor
                double[] L = { Convert.ToDouble(tb_lgs1_rs.Text), Convert.ToDouble(tb_lgs2_rs.Text) };

                /*** RECHNUNG ***/
                double DET = (K[0][0] * K[1][1]) - (K[1][0] * K[0][1]);     //  DET = Determinante
                double DETA = (K[1][1] * L[0]) - (K[0][1] * L[1]);          // DETA = Determinante A
                double DETB = (K[0][0] * L[1]) - (K[1][0] * L[0]);          // DETB = Determinante B         

                /*** AUSGABE ***/
                if (DET != 0) {
                    label_meldung.Text = "";
                    label_loesung_a.Text = "" + DETA / DET;
                    label_loesung_b.Text = "" + (DETB / DET);
                } else {
                    label_loesung_a.Text = "";
                    label_loesung_b.Text = "";
                    label_meldung.Text = "Keine oder unendlich viele Lösungen!";
                }
            } catch {
                label_loesung_a.Text = "";
                label_loesung_b.Text = "";
                label_meldung.Text = "Es sind nur die Reellenzahlen zulässig!";
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label_meldung.Text = "";
            label_loesung_a.Text = "";
            label_loesung_b.Text = "";
        }
    }
}
