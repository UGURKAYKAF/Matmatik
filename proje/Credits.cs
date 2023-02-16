using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace proje
{
    public partial class Credits : Form
    {
        public Credits()
        {
            InitializeComponent();
        }
        
        private void Credits_Load(object sender, EventArgs e)
        {


            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Video|*.mp4| Tüm Dosyalar |*.*";
            dosya.Title = "Video Çek";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            axWindowsMediaPlayer1.URL = dosyayolu;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
