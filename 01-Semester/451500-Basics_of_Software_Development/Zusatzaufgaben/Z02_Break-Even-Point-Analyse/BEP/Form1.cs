using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BEP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cvtr_fixkosten = Double.Parse(tb_fixkosten.Text);
            double cvtr_varKosten = Double.Parse(tb_varKosten.Text);
            double cvtr_preis = Double.Parse(tb_preis.Text);

            tb_mindestabsatzmenge.Text = Convert.ToString(BEP.mindestabsatzmenge(cvtr_fixkosten, cvtr_varKosten, cvtr_preis));
        }
    }
}
