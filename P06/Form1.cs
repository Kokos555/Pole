using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random value = new Random();
            int n = Convert.ToInt32(textBox1.Text);
            double[] pole = new double[n];
            for (int i = 0; i < n; i++)
            {
                double cislo = value.NextDouble() * (2000) - 1000;
                pole[i] = cislo;
                listBox1.Items.Add(string.Format("{0:F2}", pole[i]));
            }
            double ar = pole.Average();
            label2.Text = string.Format("{0:F2}", ar);
            double max = -1001 ;
            foreach(double cislo in pole)
            {
                if (cislo <= ar && max < cislo)
                {
                    max = cislo;
                }
            }
            MessageBox.Show(string.Format("{0:F2}", max));
        }
    }
}
