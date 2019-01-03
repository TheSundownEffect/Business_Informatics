using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schulden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] schulden = { Convert.ToDouble(tb_p1.Text), Convert.ToDouble(tb_p2.Text), Convert.ToDouble(tb_p3), Convert.ToDouble(tb_p4) };
            string[] namen = { label5.Text, label6.Text, label7.Text, label8.Text };



            label_geliehen = "Das meiste Geld hat sich " + __ + " mit " + __ + " € geliehen.";
            label_verliehen = "Das meiste Geld hat " + __ + " mit " + __ + " € verliehen.";
            label_schuldet = "Den höchsten Betrag schuldet " + __ + " an " + __ + ", und zwar " + __ + " €";

        }
    }
}
