using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public partial class kara : Form
    {
        public kara()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1,s2,cvp;
            if (richTextBox3.Text=="")
            {
                s2 = 1;
                s1 = Convert.ToDouble(richTextBox1.Text);

                cvp = s2 * Math.Sqrt(s1);
                label2.Text = cvp.ToString();
            }
            else
            {
                s2 = Convert.ToDouble(richTextBox3.Text);
                s1 = Convert.ToDouble(richTextBox1.Text);
                cvp = s2 * Math.Sqrt(s1);
                label2.Text = cvp.ToString();
            }
           


        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu menu=  new menu();
            menu.Show();  
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            label2.Text="";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fonk hsp= new fonk();
            hsp.Show();
        }

        private void kara_Load(object sender, EventArgs e)
        {
            richTextBox2.Enabled = false;
        }
    }
}
