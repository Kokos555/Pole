using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02
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
            int[] pole = new int[n];
            for(int i = 0; i< n; i++)
            {
                int cislo = value.Next(1, 10);
                pole[i] = cislo;
            }
            foreach (int prvek in pole)
            {
                listBox1.Items.Add(string.Format("{0}", prvek));
            }
        }
    }
}
