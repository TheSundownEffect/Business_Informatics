using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstTarif
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double einkommensteuer(double zvE /*zu versteuerndes Einkommen*/, Boolean Splittingtarif) {
            double ergebnis = 0;
            double x, y, z;
            zvE = Math.Floor(zvE);

            if (zvE <= 8820.00) {
                ergebnis = zvE;
            } if ((zvE >= 8821) & (13769 >= zvE)) {
                
            y = (zvE - 8821) / 10000;
            ergebnis = ((1007.27 * y + 1400) * y);
               
            } if (((zvE >= 13770) & (54057 >= zvE))) {
            
            z = (zvE - 13769) / 10000;
            ergebnis = (223.76 * z + 2397) * (z + 939.57);

            } if (((zvE >= 54058) & (256303 >= zvE))) {

            x = zvE;
            ergebnis = (0.42 * x) - 8475.44;


            } if (zvE >= 256304) {
            
            x = zvE;
            ergebnis = 0.45 * x - 16164.53;

            }
            if (Splittingtarif == true) {



                /* was zum fick bin ich sehend */



                return Math.Floor(ergebnis);
            } else {
            return Math.Floor(ergebnis);
            }
            
        }

  


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tb_einkommensteuer.Text = Convert.ToString(einkommensteuer(Convert.ToDouble(textBox1.Text), checkBox1.Checked));
        }
    }
}
