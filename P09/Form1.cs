using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P09
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
            int pocet = 0;
            int cislo2 = 0;
            int[] pole = new int[n];
            for (int i = 0; i<n; i++)
            {
                int cislo = value.Next(1, 11);
                pole[i] = cislo;
            }
            Array.Sort(pole);
            int median = 0;
            foreach (int cislo in pole)
            {
                listBox1.Items.Add(cislo);
            }
            if (n % 2 == 1)
            {
                int cislo = n / 2;
                median = pole[cislo];
                for (int i = 0; i < n; i++)
                {
                    cislo2 = pole[i];
                    if (cislo2 == median)
                    {
                        pocet++;
                    }
                }
                label2.Text = string.Format("Median je cislo {0} a vyskytuje se tam {1}", median, pocet);
            }
            else
            {
                int cislo = n / 2;
                int median1 = pole[cislo];
                int median2 = pole[cislo - 1];
                double podil = ((double)median1 + median2)/2;
                for (int i = 0; i < n; i++)
                {
                    cislo2 = pole[i];
                    if (cislo2 == podil)
                    {
                        pocet++;
                    }
                }
                label2.Text = string.Format("Median cisel je {0} a vyskytuje se tam {1}", podil,pocet);
            }
        }
    }
}
