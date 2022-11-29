using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_Uyg32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayının_karesi;
            try
            {
                sayi1 = Convert.ToInt16(textBox1.Text);
                sayının_karesi = sayi1 * sayi1;
                MessageBox.Show(sayının_karesi.ToString());
            }
            catch
            {
                MessageBox.Show("Hatalı giriş yaptınız!");

            }
            finally
            {

            }
        }
    }
}
