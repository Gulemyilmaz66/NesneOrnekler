using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_GoldSoru9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sayi;
        int skor;
        private void button1_Click(object sender, EventArgs e)
        {
            skor = 100;
            label3.Text = "Skor : " + skor.ToString();
            btnTahminEt.Enabled = true;
            Random rastgele = new Random();
            sayi = rastgele.Next(101) ;
            MessageBox.Show("Aklımdan Bir Sayı Tuttum.Bulamasın Kİİİİ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                int tahmin = Convert.ToInt32(txtTahmin.Text);

                if (tahmin < sayi)
                {
                    MessageBox.Show("Yukarı");
                    skor = skor - 10;
                }
                else if (tahmin > sayi)
                {
                    MessageBox.Show("Aşağı");
                    skor = skor - 10;
                }
                else
                {
                    MessageBox.Show("Tebrikler.:");
                }

                if (skor == 0)
                {
                    MessageBox.Show("GAME OVER!!!!!");
                    btnTahminEt.Enabled = false;
                }
                lblSkor.Text = "Skor : " + lblSkor.ToString();
                txtTahmin.Clear();
            }

            catch (Exception)
            {
                MessageBox.Show("Lütfen sayı Girinizz");
              
            }
            lblSkor.Text = skor.ToString();
            txtTahmin.Clear();
            txtTahmin.Focus();
        }  
    }
}
