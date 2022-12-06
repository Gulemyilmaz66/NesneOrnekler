
namespace U2_Uyg33
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.textBox_KullaniciSifresi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Giriş";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kulanıcı Adı: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kulanıcı sifre:";
            // 
            // textBox_KullaniciAdi
            // 
            this.textBox_KullaniciAdi.Location = new System.Drawing.Point(157, 40);
            this.textBox_KullaniciAdi.Name = "textBox_KullaniciAdi";
            this.textBox_KullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.textBox_KullaniciAdi.TabIndex = 3;
            // 
            // textBox_KullaniciSifresi
            // 
            this.textBox_KullaniciSifresi.Location = new System.Drawing.Point(156, 78);
            this.textBox_KullaniciSifresi.Name = "textBox_KullaniciSifresi";
            this.textBox_KullaniciSifresi.Size = new System.Drawing.Size(100, 20);
            this.textBox_KullaniciSifresi.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 186);
            this.Controls.Add(this.textBox_KullaniciSifresi);
            this.Controls.Add(this.textBox_KullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_KullaniciAdi;
        private System.Windows.Forms.TextBox textBox_KullaniciSifresi;
    }
}

