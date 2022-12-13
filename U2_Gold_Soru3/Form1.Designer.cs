
namespace U2_Gold_Soru3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbmat = new System.Windows.Forms.RadioButton();
            this.rbturk = new System.Windows.Forms.RadioButton();
            this.rbnesne = new System.Windows.Forms.RadioButton();
            this.rbrobatik = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNot1 = new System.Windows.Forms.TextBox();
            this.txtNot2 = new System.Windows.Forms.TextBox();
            this.txtNot3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbrobatik);
            this.groupBox1.Controls.Add(this.rbnesne);
            this.groupBox1.Controls.Add(this.rbturk);
            this.groupBox1.Controls.Add(this.rbmat);
            this.groupBox1.Location = new System.Drawing.Point(22, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHesapla);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNot3);
            this.groupBox2.Controls.Add(this.txtNot2);
            this.groupBox2.Controls.Add(this.txtNot1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(236, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 191);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // rbmat
            // 
            this.rbmat.Location = new System.Drawing.Point(14, 23);
            this.rbmat.Name = "rbmat";
            this.rbmat.Size = new System.Drawing.Size(85, 17);
            this.rbmat.TabIndex = 0;
            this.rbmat.TabStop = true;
            this.rbmat.Text = "matematik";
            this.rbmat.UseVisualStyleBackColor = true;
            this.rbmat.CheckedChanged += new System.EventHandler(this.rbmat_CheckedChanged);
            // 
            // rbturk
            // 
            this.rbturk.Location = new System.Drawing.Point(14, 56);
            this.rbturk.Name = "rbturk";
            this.rbturk.Size = new System.Drawing.Size(85, 17);
            this.rbturk.TabIndex = 1;
            this.rbturk.TabStop = true;
            this.rbturk.Text = "Turkce";
            this.rbturk.UseVisualStyleBackColor = true;
            this.rbturk.CheckedChanged += new System.EventHandler(this.rbturk_CheckedChanged);
            // 
            // rbnesne
            // 
            this.rbnesne.Location = new System.Drawing.Point(14, 93);
            this.rbnesne.Name = "rbnesne";
            this.rbnesne.Size = new System.Drawing.Size(125, 17);
            this.rbnesne.TabIndex = 2;
            this.rbnesne.TabStop = true;
            this.rbnesne.Text = "Nesne Tabanlı Prog";
            this.rbnesne.UseVisualStyleBackColor = true;
            this.rbnesne.CheckedChanged += new System.EventHandler(this.rbnesne_CheckedChanged);
            // 
            // rbrobatik
            // 
            this.rbrobatik.Location = new System.Drawing.Point(14, 128);
            this.rbrobatik.Name = "rbrobatik";
            this.rbrobatik.Size = new System.Drawing.Size(125, 17);
            this.rbrobatik.TabIndex = 3;
            this.rbrobatik.TabStop = true;
            this.rbrobatik.Text = "Robatik ve Kodlama";
            this.rbrobatik.UseVisualStyleBackColor = true;
            this.rbrobatik.CheckedChanged += new System.EventHandler(this.rbrobatik_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yazılı 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yazılı 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yazılı 3:";
            // 
            // txtNot1
            // 
            this.txtNot1.Location = new System.Drawing.Point(64, 18);
            this.txtNot1.Name = "txtNot1";
            this.txtNot1.Size = new System.Drawing.Size(100, 20);
            this.txtNot1.TabIndex = 3;
            // 
            // txtNot2
            // 
            this.txtNot2.Location = new System.Drawing.Point(64, 52);
            this.txtNot2.Name = "txtNot2";
            this.txtNot2.Size = new System.Drawing.Size(100, 20);
            this.txtNot2.TabIndex = 4;
            // 
            // txtNot3
            // 
            this.txtNot3.Location = new System.Drawing.Point(64, 91);
            this.txtNot3.Name = "txtNot3";
            this.txtNot3.Size = new System.Drawing.Size(100, 20);
            this.txtNot3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "label5";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(0, 159);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(202, 26);
            this.btnHesapla.TabIndex = 8;
            this.btnHesapla.Text = "ortalama Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 339);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbrobatik;
        private System.Windows.Forms.RadioButton rbnesne;
        private System.Windows.Forms.RadioButton rbturk;
        private System.Windows.Forms.RadioButton rbmat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNot3;
        private System.Windows.Forms.TextBox txtNot2;
        private System.Windows.Forms.TextBox txtNot1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

