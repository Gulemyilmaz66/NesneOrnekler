using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_SS_71
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                byte yuzde;
                yuzde = Convert.ToByte(textBox1.Text);
                progressBar1.Value = yuzde;
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen 0-100 ile arası SAYI GİRİNİZ");

            }
            
        }
    }
}
