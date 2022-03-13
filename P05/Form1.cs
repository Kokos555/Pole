using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05
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
            listBox3.Items.Clear();
            int n = Convert.ToInt32(textBox1.Text);
            Random rnd = new Random();
            int[] pole = new int[n];
            for (int i = 0; i < n; i++)
            {
                pole[i] = rnd.Next(0, 21);
            }
            Array.Sort(pole);
            foreach (int cislo in pole)
            {
                listBox1.Items.Add(string.Format("{0}",cislo));
            }
            int b = Convert.ToInt32(textBox2.Text);
            int dp = 0 - 1;
            int dm = n + 1;
            bool f = false;
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] <= b)
                {
                    dp = i;
                }
                if (pole[i] > b)
                {
                    if (!f)
                    {
                        dm = i;
                    }

                    f = true;
                }
            }
            int[] pole1 = pole.Take(dp + 1).ToArray();
            foreach (int cislo in pole1)
            {
                listBox2.Items.Add(string.Format("{0}", cislo));
            }
            int[] pole2 = pole.Skip(dm).ToArray();
            foreach (int cislo in pole2)
            {
                listBox3.Items.Add(string.Format("{0}", cislo));
            }
        }
    }
}
