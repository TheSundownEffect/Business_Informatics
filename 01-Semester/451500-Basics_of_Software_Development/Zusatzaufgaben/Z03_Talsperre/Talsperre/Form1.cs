using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Talsperre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Befülle die Talsperre mit abweisender Schleife" + Environment.NewLine;
            int tage = 0;
            double zulauf1 = Convert.ToDouble(tb_zulauf1.Text);
            double zulauf2 = Convert.ToDouble(tb_zulauf2.Text);
            double zwischenergebnis = 0.00;

            while (zwischenergebnis < 1.00)
            {
                tage = tage + 1;
                zwischenergebnis = zwischenergebnis + Math.Round(zulauf1 + zulauf2, 1);
                textBox1.Text = textBox1.Text + "Füllgrad nach " + tage + " Tagen: " + zwischenergebnis + Environment.NewLine;
            }
            if (zwischenergebnis > 1.00)
            {
                textBox1.Text = textBox1.Text + "Die Talsperre ist nach " + tage + " Tagen ÜBERGELAUFEN!!!" + Environment.NewLine;
            }
            else
            {
                textBox1.Text = textBox1.Text + "Die Talsperre ist nach " + tage + " Tagen voll." + Environment.NewLine;
            }
            textBox1.SelectionStart = textBox1.TextLength;
            textBox1.ScrollToCaret();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "Befülle die Talsperre mit NICHT abweisender Schleife" + Environment.NewLine;
            int tage = 0;
            double zulauf1 = Convert.ToDouble(tb_zulauf1.Text);
            double zulauf2 = Convert.ToDouble(tb_zulauf2.Text);
            double zwischenergebnis = 0.00;

            do
            {
                tage = tage + 1;
                zwischenergebnis = zwischenergebnis + Math.Round(zulauf1 + zulauf2, 1);
                textBox1.Text = textBox1.Text + "Füllgrad nach " + tage + " Tagen: " + zwischenergebnis + Environment.NewLine;
            }
            while (zwischenergebnis < 1.00);

            if (zwischenergebnis > 1.00) {
                textBox1.Text = textBox1.Text + "Die Talsperre ist nach " + tage + " Tagen ÜBERGELAUFEN!!!" + Environment.NewLine;
            } else {
                textBox1.Text = textBox1.Text + "Die Talsperre ist nach " + tage + " Tagen voll." + Environment.NewLine;
            }

            
            textBox1.SelectionStart = textBox1.TextLength;
            textBox1.ScrollToCaret();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            textBox1.ScrollBars = ScrollBars.Vertical;
        }
    }
}
