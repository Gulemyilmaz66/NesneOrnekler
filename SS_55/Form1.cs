using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SS_55
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int boy, kilo, sonuc;
            boy = Convert.ToInt32(textBox1.Text);
            kilo = Convert.ToInt32(textBox2.Text);
            sonuc = boy-(((150 - boy) / 4) + 110);
            if (kilo > sonuc)
            {
                label3.Text = "KİLOLU";
            }
            else 
            {
                label3.Text = "ZAYIF";
            }
        }
    }
}
