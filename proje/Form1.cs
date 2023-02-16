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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            menu asd = new menu();
            asd.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Credits cd=new Credits();
            cd.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
