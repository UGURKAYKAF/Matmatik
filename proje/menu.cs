using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace proje
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            linkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            linkLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            linkLabel5.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            linkLabel6.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            linkLabel7.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            linkLabel8.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            linkLabel9.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;

            //picturbox
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            pictureBox1.BorderStyle=BorderStyle.None; 
            pictureBox2.BorderStyle=BorderStyle.None;

            //groupbox
            this.groupBox1.MouseMove += new MouseEventHandler(this.groupBox1_MouseMove);
            this.groupBox2.MouseMove += new MouseEventHandler(this.groupBox2_MouseMove);
        }
        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //  fonk sss = new fonk();
            // sss.Show();
            fakt fkt = new fakt();
            fkt.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ucg ucgen = new ucg();
            ucgen.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            asal asl = new asal();
            asl.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            alan aln = new alan();
            aln.Show();
            this.Hide();
        }

        private void menu_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            kar kr =new kar();  
            kr.Show();
            this.Hide();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            kom kmb =new kom();
            kmb.Show();
            this.Hide();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            kara kr =new kara();
            kr.Show();
            this.Hide();
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ebob eb =new Ebob();
            eb.Show();
            this.Close();

        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            asc ase= new asc();
            ase.Show();
            this.Close();
        }

        private void groupBox1_MouseCaptureChanged(object sender, EventArgs e)
        {
          
        }
        private void groupBox1_MouseMove(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }
        private void groupBox2_MouseMove(object sender, EventArgs e)
        {
            pictureBox1.Visible=false;
            pictureBox2.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            çizim czm=new çizim();
            czm.Show();

        }
    }
}
