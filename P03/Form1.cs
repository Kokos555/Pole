using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03
{
    public partial class Form1 : Form
    {
        int[] poleA;
        int[] poleB;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int n = Convert.ToInt32(textBox1.Text);
            poleA = new int[n];
            for (int i = 0; i < n; i++) { 
                int value = rnd.Next(2, 10);
                poleA[i] = value;
            }
            foreach (int prvek in poleA)
            {
                listBox1.Items.Add(prvek);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int m = Convert.ToInt32(textBox2.Text);
            poleB = new int[m];
            for (int k = 0; k < m; k++)
            {
                int value = rnd.Next(2, 10);
                poleB[k] = value;
            }
            foreach(int prvek in poleB)
            {
                listBox2.Items.Add(prvek);
            }
        }
    }
}
