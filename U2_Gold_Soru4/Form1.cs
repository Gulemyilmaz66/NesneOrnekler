using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_Gold_Soru4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kucuksayi, buyuksayi;

            try
            {
                kucuksayi = Convert.ToInt32(textBox1.Text);
                buyuksayi = Convert.ToInt32(textBox2.Text);

                if (kucuksayi >buyuksayi )
                {
                    MessageBox.Show("Lütfen küçük sayı ,küçük olarak giriniz.küçük küçüklüğünü bilsin");

                }
                else
                {
                    for (int i = 0; i < buyuksayi ; i++)
                    {
                        if (i % 2 ==0)
                        {
                            listBox2.Items.Add(i);
                        }

                        else
                        {
                            listBox1.Items.Add(i);
                        }
                    }
                }

            }
            catch (Exception)
            {

                MessageBox.Show("lütfen  sayı giriniz");
            }
        }
    }
}
