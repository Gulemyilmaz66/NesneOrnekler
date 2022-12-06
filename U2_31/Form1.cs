using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            /*for (int i = 0; i < listBox1.Items.Count; i++)


            if (listBox1.Items[i].ToString() == ad)
            {
                MessageBox.Show(listBox1.Items[i].ToString() + "   adlı müşteri bulundu!");

                break;
            }*/


            /*int i = 0;
            while (i < listBox1.Items.Count)
            {
                if (ad == listBox1.Items[i].ToString())
                {
                    MessageBox.Show(" adlı müşteri bulunamadı.");
                }
                i++;
            }*/



            int i = 0;
            do (i < listBox1.Items.Count)
            {
                MessageBox.Show(" adlı müşteri bulundu.");
                if (ad  == listBox1.Items[i].ToString())
                {
                    MessageBox.Show("  adlı müşteri bulunamadı.");
                    break;
                }
                i++;

            } while (i < 11);

        }
    }
}
