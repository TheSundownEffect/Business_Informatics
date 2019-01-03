using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanIst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cvtr_planmenge = Double.Parse(tb_planmenge.Text);
            double cvtr_planpreis = Double.Parse(tb_planpreis.Text);
            double cvtr_istmenge = Double.Parse(tb_istmenge.Text);
            double cvtr_istpreis = Double.Parse(tb_istpreis.Text);

            tb_gesamtabweichung.Text = Convert.ToString(PlanIst.gesamtabweichung(cvtr_planmenge, cvtr_planpreis, cvtr_istmenge, cvtr_istpreis));
            tb_preisabweichung.Text = Convert.ToString(PlanIst.mengenabweichung(cvtr_planpreis, cvtr_istpreis, cvtr_istmenge));
            tb_mengenabweichung.Text = Convert.ToString(PlanIst.preisabweichung(cvtr_planmenge, cvtr_istmenge, cvtr_planpreis));
        }
    }
}
