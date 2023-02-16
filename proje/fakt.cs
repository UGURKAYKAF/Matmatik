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
    public partial class fakt : Form
    {
        public fakt()
        {
            InitializeComponent();
        }

        private void fakt_Load(object sender, EventArgs e)
        {
            richTextBox2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double sayı;
            double fakt = 1;
            sayı = Convert.ToDouble(richTextBox1.Text);
            if (sayı<0)
            {
                MessageBox.Show("-'Li Değer Girilemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
            for (int i = 1; i <=sayı ; i++)
            {
                fakt *= i;
            }   
            richTextBox1.Text = sayı+"!";
            richTextBox2.Text = fakt.ToString();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu ms = new menu();
            ms.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fonk hs = new fonk();
            hs.Show(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fakttanım tnm=new fakttanım();
            tnm.Show();
        }
    }
}
