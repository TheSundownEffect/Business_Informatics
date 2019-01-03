using System;
using System.Windows.Forms;

namespace Laenge_einer_Zahl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butt_rlang_Click(object sender, EventArgs e)
        {
            label_count.Text = Convert.ToString(Laenge_einer_Zahl.RLANG_1(textBox1.Text));
        }

        private void butt_wlang_Click(object sender, EventArgs e)
        {
            label_count.Text = Convert.ToString(Laenge_einer_Zahl.WLANG_1(textBox1.Text));
        }


    }
}
