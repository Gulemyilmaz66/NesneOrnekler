using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U2_SS_70
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* for (int i = 1; i < 10; i=i+1)*/
            {

                for (int i = 1; i < 10; i=i+2)
                {
                    listBox1.Items.Add(i);
                    if (i>=4)
                    {
                        continue;
                    }


                }
            }
        }
    }
}
