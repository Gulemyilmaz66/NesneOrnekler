using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_66_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayac = 1, toplam = 0;

            while (sayac <=20)
            {
                toplam = toplam + sayac;
                listBox1.Items.Add(toplam);
                sayac++;
            }
        }
    }
}
