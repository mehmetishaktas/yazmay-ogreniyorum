using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazmayıogreniyorum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int d = 0;
        int y = 0;
     

        string cevap;

        private void button7_Click(object sender, EventArgs e)
        {                    
                if ( textBox1.Text + ".jpg" == cevap)
                {
                MessageBox.Show("DOĞRU CEVAP","EVET",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                textBox1.Clear();
                d++;
                label1.Text =$"PUAN:\t{d}";
                baslat();
                
                }
                else
                {
                    MessageBox.Show("YANLIŞ CEVAP","YANLIŞ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                y++;
                label3.Text = $"YANLIŞ:\t{y}";

                textBox1.Clear();
                }                                      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text  += button4.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            baslat();
        }

        void baslat()
        {
            Random rnd = new Random();
           
            string resimKlasoruYolu = Environment.CurrentDirectory + "\\resimler";          
            string[] resimler = Directory.GetFiles(resimKlasoruYolu, "*.jpg");
            int seri = rnd.Next(0, resimler.Length);           
            pictureBox1.Image = Image.FromFile(resimler[seri]);
            cevap = resimler[seri].Remove(0, 86);
           
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += button12.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += button13.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += button16.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += button15.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += button14.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += button17.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += button10.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += button18.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("boş", "boş", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
           
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }

        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text += button20.Text;
        }
    
        private void button21_Click(object sender, EventArgs e)
        {
            
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text += button26.Text;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text += button25.Text;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text += button24.Text;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text +=  button23.Text;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text += button22.Text;
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += button21.Text;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            textBox1.Text +=  button31.Text;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox1.Text += button30.Text;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox1.Text += button29.Text;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.Text += button28.Text;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text += button27.Text;
        }
    }
}
