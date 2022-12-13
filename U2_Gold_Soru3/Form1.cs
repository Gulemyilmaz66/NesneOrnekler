using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_Gold_Soru3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbmat_CheckedChanged(object sender, EventArgs e)
        {
            
            txtNot1.Text = "";
            txtNot2.Text = "";
            txtNot3.Text = "";
            label4.Text = "Matamatik ortalaması";
        }

        private void rbturk_CheckedChanged(object sender, EventArgs e)
        {
            txtNot1.Text = "";
            txtNot2.Text = "";
            txtNot3.Text = "";
            label4.Text = "Türkce  ortalaması";
        }

        private void rbnesne_CheckedChanged(object sender, EventArgs e)
        {
            txtNot1.Text = "";
            txtNot2.Text = "";
            txtNot3.Text = "";
            label4.Text = "Nesne ortalaması";
        }

        private void rbrobatik_CheckedChanged(object sender, EventArgs e)
        {
            txtNot1.Text = "";
            txtNot2.Text = "";
            txtNot3.Text = "";
            label4.Text = "Robatik ortalaması";
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int Not1, Not2, Not3, ort;

            try
            {
                Not1 = Convert.ToInt32(txtNot1.Text);
                Not2 = Convert.ToInt32(txtNot2.Text);
                Not3 = Convert.ToInt32(txtNot3.Text);



                if (Not1 > 100 || Not1 < 0 || Not2 > 100 || Not2 < 0 || Not3 > 100 || Not3 < 0)
                {
                    MessageBox.Show("Lütfen 0-100 arasında rakam giriniz");
                }
                else
                {
                    ort = (Not1 + Not2 + Not3) / 3;
                    label5.Text = ort.ToString();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("lütfen sayı giriniz");
            }

   
        }
    }
}
