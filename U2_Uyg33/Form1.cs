using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_Uyg33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi;
            long parola;

            try
            {
                kullaniciAdi = textBox_KullaniciAdi.Text.ToString();
                parola = long.Parse(textBox_KullaniciSifresi.Text.ToString());
                MessageBox.Show("Giriş Başarılı.Hoşgeldiniz " + kullaniciAdi);

            }

            catch (Exception)
            {
                MessageBox.Show("Şifreniz Sadece Sayılardan Oluşmalıdır.Tekrar Deneyiniz.");
                textBox_KullaniciSifresi.Text = " ";
            }
            finally
            {
            }
        }
    }
}
