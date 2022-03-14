using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            int[] pole = new int[listBox1.Items.Count];
            int konec = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int cislo = Convert.ToInt32(listBox1.Items[i]);
                if (cislo != 0)
                {
                    pole[i] = cislo;
                }else
                {
                    konec = i;
                    break;
                }
                
            }
            pole = pole.Take(konec).ToArray();
            int prvni_prvek = pole[0];
            double posledni_prvek = pole.Last();
            double podíl = prvni_prvek / posledni_prvek;
            foreach (int cislo1 in pole)
            {
                listBox2.Items.Add(cislo1);
            }
            MessageBox.Show(string.Format("{0:F2}", podíl));
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                int cislo = Convert.ToInt32(listBox2.Items[i]);
                if (cislo < posledni_prvek)
                {
                    listBox3.Items.Add(string.Format("Pole[{0}] = {1}", i+1, pole[i]));
                }
            }
        }
    }
}
