using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace proje
{
    
    public partial class fonk : Form
    {
       
        double FirstNumber;
        
        string Operation;

        public fonk()
        {
            InitializeComponent();
        }

        private void fonk_Load(object sender, EventArgs e)
        {
            //textBox1.Enabled = false;
            textBox2.Enabled = false;
            //richTextBox1.Text = "0";
            richTextBox1.Enabled = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            textBox2.Text = "";
        }
     
        private void button6_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "5";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "5";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "1";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "2";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "3";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "3";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "4";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "4";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "6";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "6";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "7";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "8";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "8";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0" && richTextBox1.Text != null)
            {
                richTextBox1.Text = "9";
            }
            else
            {
                richTextBox1.Text = richTextBox1.Text + "9";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "" || richTextBox1.Text == " ")
            {
                MessageBox.Show("Metin Alanı Boş İken İşlem Yapılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
            FirstNumber = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "";
            Operation = "+";
            //textBox1.Text = "+";
            textBox2.Text = FirstNumber.ToString()+"+";
            }
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "" || richTextBox1.Text == " ")
            {
                MessageBox.Show("Metin Alanı Boş İken İşlem Yapılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
            FirstNumber = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "";
            Operation = "-";
            //textBox1.Text = "-";
            textBox2.Text = FirstNumber.ToString() + "-";
            }

            

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text==""||richTextBox1.Text==" ")
            {
                MessageBox.Show("Metin Alanı Boş İken İşlem Yapılamaz","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
            FirstNumber = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "";
            Operation = "*";
            //textBox1.Text = "*";
            textBox2.Text = FirstNumber.ToString() + "*";
            }
           
            
            
           

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "" || richTextBox1.Text == " ")
            {
                MessageBox.Show("Metin Alanı Boş İken İşlem Yapılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
            FirstNumber = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text ="";
            Operation = "/";
            //textBox1.Text = "/";
            textBox2.Text = FirstNumber.ToString() + "/";

            }
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + ",";
        }
        static bool sayiMi_5(string deger)
        {
            try
            {
                int.Parse(deger);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void button18_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            if (richTextBox1.Text == "" || richTextBox1.Text == " ")
            {
                MessageBox.Show("Metin Alanı Boş İken İşlem Yapılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                  SecondNumber = Convert.ToDouble(richTextBox1.Text);

          


            if (Operation == "+")
            {
                textBox2.Text = FirstNumber + "+" + SecondNumber;
                Result = (FirstNumber + SecondNumber);
                
                richTextBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
                //textBox1.Text = "";
                

            }
            if (Operation == "-")
            {
                textBox2.Text = FirstNumber + "-" + SecondNumber;
                Result = (FirstNumber - SecondNumber);
                richTextBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
                // textBox1.Text = "";
                
                

            }
            if (Operation == "*")
            {
               textBox2.Text = FirstNumber + "*" + SecondNumber;
                Result = (FirstNumber * SecondNumber);
                richTextBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
                //textBox1.Text = "";
                

            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    richTextBox1.Text = "0'a Bölemezsiniz";
                    //textBox1.Text = "";
                }
                else
                {
                    textBox2.Text = FirstNumber + "/" + SecondNumber;
                    Result = (FirstNumber / SecondNumber);
                    richTextBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                    //textBox1.Text = "";
                    

                }
            }
            if(Operation=="%")
            {
                if(SecondNumber==0||FirstNumber==0||FirstNumber<SecondNumber)
                {
                    richTextBox1.Text = "0";
                    //textBox1.Text = "";
                }
                else if(FirstNumber<SecondNumber)
                {
                    richTextBox1.Text = "İlk sayı ikinci sayıdan büyük olamaz";
                    //textBox1.Text = "";
                }
                else
                {
                    textBox2.Text = FirstNumber + " Mod " + SecondNumber;
                    Result = (FirstNumber % SecondNumber);
                    richTextBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                    //textBox1.Text = "";
                    

                }
               
            }
                if (Operation=="^")
                {
                    textBox2.Text = FirstNumber + " ^ " + SecondNumber;
                    Result =Math.Pow(FirstNumber,SecondNumber);
                    richTextBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;

                }  
            }
                        
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "" || richTextBox1.Text == " ")
            {
                MessageBox.Show("Metin Alanı Boş İken İşlem Yapılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
            FirstNumber = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            Operation = "%";
            //textBox1.Text = "Mod";
            textBox2.Text = FirstNumber.ToString() + "Mod";
            }
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //if (richTextBox1.Text == "" || richTextBox1.Text == " ")
           // {
               // MessageBox.Show("Metin Alanı Boş İken İşlem Yapılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
           // else
            //{
                if (richTextBox1.Text != string.Empty)
            {
                int txtlength = richTextBox1.Text.Length;
                if (txtlength != 1)
                {
                    richTextBox1.Text = richTextBox1.Text.Remove(txtlength - 1);
                }
                else
                {
                   richTextBox1.Text = 0.ToString();
                }
            }
            //}
            
        }
        
        private void button20_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "" || richTextBox1.Text == " ")
            {
                MessageBox.Show("Metin Alanı Boş İken İşlem Yapılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
            FirstNumber = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Text = "0";
            Operation = "^";
            textBox2.Text = FirstNumber.ToString() + "^";
            }
            
        }
    }
}
