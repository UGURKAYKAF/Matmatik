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
    public partial class asc : Form
    {
        public asc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1, i;
            s1 = Convert.ToDouble(richTextBox1.Text);

            for ( i = 2; s1>1 ; i++)
            {
                while (s1%i==0)
                {
                    listBox1.Items.Add(i);
                    s1=s1/i;
                }
            }
            if (richTextBox1.Text=="0")
            {
                DialogResult msg= MessageBox.Show("Bir Daha 0 Girme Aslanım","Hatasız Kul Olmaz",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
                if (msg== DialogResult.Yes)
                {
                    richTextBox1.Text = "Birdaha Olmasın ASLANIM !!!";
                }
                else
                {
                     MessageBox.Show("Uygulaman Elden Gitti !!!");
                    Application.Exit();
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            richTextBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fonk fnk = new fonk();
            fnk.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu mn=new menu();
            mn.Show();
            this.Close();
        }

        private void asc_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            asctanım tnm = new asctanım();
            tnm.Show();
        }
    }
}
