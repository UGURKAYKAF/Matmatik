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
    public partial class kom : Form
    {
        public kom()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           fonk hsp=new fonk();
            hsp.Show();
        }
       double r,n, kombinasyon, fakt, fakt1, fakt2;
        private void button1_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(richTextBox1.Text);
            r = Convert.ToInt32(richTextBox2.Text);
            if (n == 0 || r == 0 || n == r)
            {
                label1.Text = "1";
                MessageBox.Show("Girilen Sayının Formatı n ≥ r ≥ 0 Şeklinde Olmalıdır","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
            fakt = n;
            for (double i = n - 1; i >= 1; i--)
            {
                fakt = fakt * i;
            }
            fakt2 = r;
            for (double i = r - 1; i >= 1; i--)
            {
                fakt2 = fakt2 * i;
            }

            double number;
            number = n - r;
            fakt1 = number;
            for (double i = number - 1; i >= 1; i--)
            {
                fakt1 = fakt1 * i;
            }
            fakt1 = fakt2 * fakt1;
            kombinasyon = fakt / fakt1;
            label1.Text = kombinasyon.ToString();
            }
            
        }
 
        

        private void button3_Click(object sender, EventArgs e)
        {
            menu ms = new menu();
            ms.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
            richTextBox1.Text = "";
            label1.Text = "";
        }

        private void kom_Load(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle= BorderStyle.None; 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kombtnm tnm =new kombtnm();
            tnm.Show();
        }
    }
}
