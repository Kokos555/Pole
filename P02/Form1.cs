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
            for (int i = 0; i < n; i++)
            {
                int cislo = value.Next(1, 10);
                pole[i] = cislo;
            }
            foreach (int prvek in pole)
            {
                listBox1.Items.Add(string.Format("{0}", prvek));
            }
            Array.Sort(pole);
            //2,2,3,5,6,7,7
            int min = pole[0];
            int max = pole[pole.Length - 1];
            int index_posledni_minímum = Array.LastIndexOf(pole, min);
            int druhe_min = pole[index_posledni_minímum + 1];
            int index_posledniho_maxima = Array.IndexOf(pole, max);
            int druhe_max = pole[index_posledniho_maxima- 1];


            if (radioButton1.Checked == true)
            {
                Array.Reverse(pole);
              

            }
          
            
            foreach (int cislo1 in pole)
            {
               listBox2.Items.Add(string.Format("{0}", cislo1));
            }
            label1.Text = string.Format("Druhé maximum je {0} a druhé minimun je {1}", druhe_max, druhe_min);
        }
    }
}
