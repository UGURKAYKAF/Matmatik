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
    public partial class kar : Form
    {
        public kar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double fakt1 = 1;
            double fakt2 = 1;  

            double n =Convert.ToDouble(richTextBox1.Text);

            double r = Convert.ToDouble(richTextBox2.Text);
           
            
                  double cevap;
            for (int i = 1; i <= n; i++)
            {
                fakt1 *= i;
            }
            for (int i = 1; i <= n-r; i++)
            {
                fakt2 *= i;
            }
            richTextBox1.Text = n + "!";
            richTextBox2.Text = r + "!";
           
                cevap = fakt1 /fakt2;
            label1.Text = cevap.ToString();
            if (r==0||n<r)
            { 
            MessageBox.Show("Girinlen Sayının Formatı n ≥ r ≥ 0 Şeklinde Olmalıdır","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            label1.Text=cevap.ToString();
            }
            
            
            
        }

        private void kar_Load(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fonk fnk=new fonk();
            fnk.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu ms = new menu();
            ms.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            label1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pertanım tnm =new pertanım();
            tnm.Show();
        }
    }
}
