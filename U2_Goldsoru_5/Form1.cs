using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_Goldsoru_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i1, i2;
            i1 = Convert.ToInt32(textBox1.Text);
            i2 = Convert.ToInt32(textBox2.Text);

            if (i1 < i2)
            {
                MessageBox.Show("küçük sayı olarak girin");
            }
            else
            {
                for (int i = 0; i1 < i2; i++)

                {
                    if (i % 2 == 0)
                    {
                        listBox1.Items.Add(i);
                    }
                    else if (i % 3 == 0)
                    {
                        listBox2.Items.Add(i);
                    }
                    else
                    {
                        listBox3.Items.Add(i);
                    }

                }
            }
        }
    }
}
