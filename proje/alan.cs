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
    public partial class alan : Form
    {
        public alan()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void alan_Load(object sender, EventArgs e)
        {
            tabPage1.Text = "Üçgen";
            tabPage2.Text = "Küp";
            //pictur box
            pictureBox1.Visible = false;   
            pictureBox2.Visible = false;    
            

            //Üçgen
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
            richTextBox3.Visible = false;
            richTextBox4.Visible = false;
            button1.Visible = false;

            //Küp
            label10.Visible = false;
            richTextBox8.Visible = false;

            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked==true)
            {
                label3.Visible = false;
                richTextBox4.Visible = false;

                richTextBox1.Visible = true;
                label2.Visible = false;
                richTextBox2.Visible = true;
                richTextBox3.Visible = true;
                label2.Visible = true;
                label4.Visible = true;
                label1.Visible = true;
                button1.Visible = true;

                pictureBox2.Visible=false;
                pictureBox1.Visible = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                richTextBox2.Visible = false;
                richTextBox3.Visible = false;
                label2.Visible = false;
                label4.Visible = false;

                label1.Visible = true;
                label3.Visible = true;
                richTextBox4.Visible = true;
                richTextBox1.Visible = true;
                button1.Visible = true;

                pictureBox1.Visible = false;
                pictureBox2.Visible = true;

            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           double alan, cevre,k1,k2,k3,h;

        
            if (radioButton1.Checked==true)
            {
               
            k1 = Convert.ToDouble(richTextBox1.Text);

            h = Convert.ToDouble(richTextBox4.Text);
            alan = (k1 * h) / 2;
            label5.Text = "Cevap : "+alan;

                richTextBox1.Text = "";
                richTextBox2.Text = "";
                richTextBox3.Text = "";
                richTextBox4.Text = "";
                label6.Text = "";
            }
   
            if (radioButton2.Checked==true)
            {
              label5.Text = "";

             k1 = Convert.ToDouble(richTextBox1.Text);
             k2 = Convert.ToDouble(richTextBox2.Text);
             k3 = Convert.ToDouble(richTextBox3.Text);
             cevre = k1 + k2 + k3;
            label6.Text = "Cevap : " + cevre;

                richTextBox1.Text = "";
                richTextBox2.Text = "";
                richTextBox3.Text = "";
                richTextBox4.Text = "";
              
            } 

            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                
                label8.Text = "";
                double alan, b;

                b = Convert.ToDouble(richTextBox8.Text);
                alan = 6 * (b*b);

                label7.Text = "Alan = "+alan;
                richTextBox8.Text = "";
            }
          if (radioButton3.Checked)
            {
                label7.Text = "";
               

                double a,cevre;
                a = Convert.ToDouble(richTextBox8.Text);
                cevre = 12 * a;

                label8.Text = "Çevre = " + cevre;
                richTextBox8.Text = "";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label10.Visible = true;
            richTextBox8.Visible = true;
           
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label10.Visible = true;
            richTextBox8.Visible = true;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu menu=new menu();
            menu.Show();
            this.Close();
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            richTextBox3.Text = "";
            richTextBox4.Text = "";
            label5.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ucgtanım tnm=new ucgtanım();
            tnm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kuptanım tanım=new kuptanım();
            tanım.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            çizim czm=new çizim();
            czm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            çizim czm = new çizim();
            czm.Show();
        }
    }
}
