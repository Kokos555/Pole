using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P08
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
            listBox2.Items.Clear();
            Random value = new Random();
            int n = Convert.ToInt32(textBox1.Text);
            char[] pole = new char[n];
            for (int i = 0; i < n; i++) {
                pole[i] = (char)(value.Next(48, 67));
            }
            foreach (char znak in pole)
            {
                listBox1.Items.Add(znak);
            }
            char posledni = pole.Last();
            if (posledni >= '0' && posledni <= '9')
            {
                for(int i = 0; i<n; i++)
                {
                    char cislo = pole[i];
                    if (cislo >= '0' && cislo <= '9') { 
                        pole[i] = 'x';
                    }
                }
            }else
            {
                char max = pole.Max();
                int poradi = Array.IndexOf(pole, max);
                pole[poradi] = posledni;
                pole[n-1] = max;

            }
            foreach (char znak in pole)
            {
                listBox2.Items.Add(znak);
            }
        }
    }
}
