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
    public partial class ucg : Form
    {
        public ucg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text==""||richTextBox2.Text==""||richTextBox4.Text=="")
            {
               label7.Text = "Lütfen Veri Giriniz";
               
            }
            else
            {
                    double a,b,c;
           a = Convert.ToDouble(richTextBox1.Text);
            b = Convert.ToDouble(richTextBox2.Text);
            c = Convert.ToDouble(richTextBox4.Text);

            if ((a+b)>c&&(a+c)>b&&(b+c)>a)
            {
                label7.Text = "Üçgen Oluşur";
                label1.Text = a.ToString();
                label2.Text = b.ToString();
                label3.Text = c.ToString();
                pictureBox2.Visible = false;
                pictureBox1.Visible = true;
            }
            else
            {
                label7.Text = "Üçgen Oluşmaz";
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                //label1.Text = a.ToString();
               // label2.Text = b.ToString();
                //label3.Text = c.ToString();
              
            }
            }
           
        }

        private void ucg_Load(object sender, EventArgs e)
        {
           // label7.Enabled = false;
            pictureBox2.Visible = false;

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            richTextBox4.Text = "";
            label7.Text = "";
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;

           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu ms = new menu();
            ms.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ucg2tnm tnm23=new ucg2tnm();
            tnm23.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            çizim czm=new çizim();
            czm.Show();
        }
    }
}
