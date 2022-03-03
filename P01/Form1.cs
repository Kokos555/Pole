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
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            Random value = new Random();
            double max = 0;
            double min = 1000;
            int pozice_max = 0;
            int pozice_min = 0;
            double soucet = 0;
            int n = Convert.ToInt32(textBox1.Text);
            int pocet = n;
            double[] pole = new double[n];
            for (int i = 0; i < n; i++)
            {
                double cislo = value.NextDouble() * (999) + 1;
                pole[i] = cislo;
            }
            foreach (double prvek in pole)
            {
                listBox1.Items.Add(string.Format("{0:F2}", prvek));
            }
            for (int j = 0; j < n; j++)
            {
                if (max < pole[j])
                {
                    max = pole[j];
                    pozice_max = j;
                }
                if (min > pole[j])
                {
                    min = pole[j];
                    pozice_min = j;
                }    
                soucet += pole[j];
            }
            soucet -= max + min;
            pocet -= 2;
            if (pocet > 0)
            {
                double ar = soucet / pocet;
                MessageBox.Show(string.Format("Aritmeticky prumer cisel v poli bez maxima a minima je {0:F2}", ar));
            }
            else
            {
                MessageBox.Show(string.Format("Nelze vypocitat aritmeticky prumer"));
            }
            pole[pozice_max] = min;
            pole[pozice_min] = max;
            for (int o = 0; o < n; o++)
            {
                listBox2.Items.Add(string.Format("{0:F2}", pole[o]));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            Random value = new Random();
            double soucet = 0;
            int n = Convert.ToInt32(textBox1.Text);
            int pocet = n;
            double[] pole = new double[n];
            for (int i = 0; i < n; i++)
            {
                double cislo = value.NextDouble() * (999) + 1;
                pole[i] = cislo;
                soucet += cislo;
            }
            foreach (double prvek in pole)
            {
                listBox1.Items.Add(string.Format("{0:F2}", prvek));
            }
            double max = pole.Max();
            double min = pole.Min();
            int pozice_max = Array.IndexOf(pole,max);
            int pozice_min = Array.IndexOf(pole,min);
            pole[pozice_max] = min;
            pole[pozice_min] = max;
            for (int o = 0; o < n; o++)
            {
                listBox2.Items.Add(string.Format("{0:F2}", pole[o]));
            }
            soucet -= max + min;
            pocet -= 2;
            if (pocet > 0)
            {
                double ar = soucet / pocet;
                MessageBox.Show(string.Format("Aritmeticky prumer cisel v poli bez maxima a minima je {0:F2}", ar));
            }
            else
            {
                MessageBox.Show(string.Format("Nelze vypocitat aritmeticky prumer"));
            }
        }
    }
}
