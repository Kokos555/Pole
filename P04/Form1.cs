using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04
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
            int[] pole = new int[n];
            for (int i = 0; i<n; i++)
            {
                int cislo = value.Next(1, 21);
                pole[i] = cislo;
            }
            int max = pole.Max();
            int poradi = Array.IndexOf(pole, max);
            foreach(int cislo in pole)
            {
                listBox1.Items.Add(cislo);
            }
            pole = pole.Distinct().ToArray();
            foreach(int cislo2 in pole)
            {
                listBox2.Items.Add(cislo2);
            }
           int[] pole1 = pole.Skip(poradi + 1).ToArray();
           int[] pole2 = pole.Take(poradi).ToArray();
            pole = pole1.Concat(pole2).ToArray();
            foreach (int cislo3 in pole)
            {
                listBox3.Items.Add(cislo3);
            }

            label5.Text = string.Format("{0}", max);
            
        }
    }
}
