using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random value = new Random();
            int n = Convert.ToInt32(textBox1.Text);
            double[] pole = new double[n];
            for (int i = 0; i < n; i++)
            {
                double cislo = value.NextDouble() * (999) + 1;
                pole[i] = cislo;
            }

        }
    }
}
