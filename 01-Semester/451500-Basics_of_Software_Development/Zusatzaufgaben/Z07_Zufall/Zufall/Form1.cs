using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zufall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            tb_matrix.Text = "";
            tb_result.Text = "";
            int[] arr = new int[1000];
            int[] count = new int[10];
            Random r = new Random();

            for (int i = 0; i < 1000; i++)
            {
                int rand = r.Next(0, 10);
                arr[i] = rand;
                tb_matrix.Text = arr[i] + " " + tb_matrix.Text;
                count[rand]++;
            }

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int n = 0; n < 1000; n++)
            //    {
            //        if (arr[n] == i)
            //        {
            //            count[i]++;
            //        }
            //    }
            //}

            int zahl = 0;
            for (int i = 0; i < 9; i++)
            {
                zahl = zahl + 1;
                tb_result.Text = tb_result.Text + "Zahl " + zahl + " wurde " + count[zahl] + " mal erzeugt." + Environment.NewLine;
            }


    }
    }
}
