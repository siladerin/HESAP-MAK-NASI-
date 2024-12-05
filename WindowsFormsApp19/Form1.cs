using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")//if texbox1 0 a eşitse 
            {
                textBox1.Text = "";//değeri siler;
            }
            textBox1.Text += "1";//değeri ekler ve yanınada değer eklenmesine izin verir;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";

            }
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";

            }
            textBox1.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";

            }
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";

            }
            textBox1.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";

            }
            textBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";

            }
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";

            }
            textBox1.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";

            }
            textBox1.Text += "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";

            }
            textBox1.Text += "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")//texbox1 boş değilse
            {
                textBox1.Text += ",";//texbox text virgül ekle
            }
            button17.Enabled = false; //sonra etkisiz kılar ;
        }

        private void button18_Click(object sender, EventArgs e)
        {
           textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }
        float sayı1;
        float sayı2;
        float hesap;//double 8,2 9 yapar float tanımlanamlı;
        string matamatik;
        private void button13_Click(object sender, EventArgs e)
        {
            sayı1 = float.Parse(textBox1.Text);
            matamatik = "/";
            textBox1.Text = "";

        }

        private void button14_Click(object sender, EventArgs e)
        {

            sayı1 = float.Parse(textBox1.Text);
            matamatik = "*";
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            sayı1 = float.Parse(textBox1.Text);
            matamatik = "-";
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            sayı1 = float.Parse(textBox1.Text);
            matamatik = "+";
            textBox1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            sayı2 = float.Parse(textBox1.Text);
            if (matamatik == "+")
            {
                hesap = sayı1 + sayı2;
                textBox1.Text = hesap.ToString();

            }
            if (matamatik == "-")
            {
                hesap = sayı1 -sayı2;
                textBox1.Text = hesap.ToString();

            }
            if (matamatik == "*")
            {
                hesap = sayı1 *sayı2;
                textBox1.Text = hesap.ToString();

            }
            if (matamatik == "/")//detaylı ders sonunda incele;
                if (sayı2== 0)
                {
                    textBox1.Text = "uygulanamaz";
                }
                else
                {
                    hesap= sayı1 / sayı2;
                    textBox1.Text = Convert.ToString(hesap);
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    } 
}
