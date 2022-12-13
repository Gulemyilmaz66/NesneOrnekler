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
            for (int i = 0; i < listBox1 .Items.Count ; i++)
            {
                if (listBox1 .Items [i].ToString ()=="tek sayı"||listBox2 .Items [i].ToString ()=="cift sayı")
                {
                    listBox1.Items.Add(listBox1.Items[i]);
                }
                else
                {
                    listBox2.Items.Add(listBox1.Items[i]);
                }
            }
        }
    }
}
