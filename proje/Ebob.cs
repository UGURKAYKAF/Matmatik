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
    public partial class Ebob : Form
    {
        public Ebob()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            eb.Text = "";
            ek.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            fonk fnk=new fonk();
            fnk.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu mn =new menu();
            mn.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1,s2,max;
            double ebob = 1;
            double ekok = 0;

            //Sayı1 ve 2 tanımlama
            s1 = Convert.ToDouble(richTextBox1.Text);
            s2 = Convert.ToDouble(richTextBox2.Text);

            max = s1 * s2;


            for (double i = 1; i < s1; i++)
            {
                if (s1 % i == 0 && s2 % i == 0)
                {
                    ebob = i;
                }
                //else if (s2 %i !=0 && s1 %i!=0)
                //{
                //    ebob = s1;
                //}
            }

            eb.Text=ebob.ToString();

            for (double i = max; i > 0; i--)
            {
                if (i % s1 == 0 && i % s2 == 0)
                {
                    ekok = i;
                }
            }
           
            ek.Text=ekok.ToString();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            ebobtnm tnm = new ebobtnm();
            tnm.Show();

        }
    }
}
