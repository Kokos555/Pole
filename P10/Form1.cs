using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P10
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
            char[] pole = new char[textBox1.Text.Length];
            int pocet = 1;
            char vetsi = 'A';
            int max = 0;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                pole[i] = textBox1.Text[i];
            }
            Array.Sort(pole);
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                listBox1.Items.Add(pole[i]);
            }
            for (int i = 1; i < textBox1.Text.Length; i++)
            {
                char pismeno = pole[i-1];
                if (pismeno == pole[i])
                {
                    pocet++;
                    if (pocet > max)
                    {
                        max = pocet;
                        vetsi = pole[i];
                    }
                }
                else
                {
                    pocet = 1;
                }
            }
            label1.Text = string.Format("{0}: {1}", vetsi, max);
        }
    }
}
