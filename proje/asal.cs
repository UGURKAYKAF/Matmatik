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
    public partial class asal : Form
    {
        public asal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı;
            int kontrol = 0;
            sayı = Convert.ToInt32(richTextBox1.Text);

            if (sayı==1)
            {
                label1.Text = "Sayı Asal Değildir";
            }
            else if (sayı==2)
            {
            label1.Text = "Sayı Asalır : "+sayı;
            }
            else if (sayı<1)
            {
                label1.Text = "Sayı Tanımsızır";
            }
            for (int i = 2; i < sayı; i++)
            {
                label1.Text="";
                if ((sayı % i == 0&&sayı!=i))
                {
                    // label1.Text = "Sayı asal değildir : "+sayı;
                    kontrol++;
                }
                //else
               // {
                //    label1.Text = "Sayı Asaldır : "+sayı;
               // }      
            }
            if (kontrol!=0)
            {
                label1.Text = "Sayı Asal Değildir : "+sayı;
            }
            else
            {
                label1.Text = "Sayı Asaldır : "+sayı;
            }
            

        }

        private void asal_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           menu mn=new menu();
            mn.Show();
            this.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            asalsytnm tntm=new asalsytnm();
            tntm.Show();
        }
    }
}
