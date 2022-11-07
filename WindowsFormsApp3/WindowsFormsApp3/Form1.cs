using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public string Sym;
        public string Num;
        public bool N;
        public Form1()
        {
            N = false;
            InitializeComponent();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
        private void button12_Click(object sender, EventArgs e)
        {
            if(N)
            {
                N = false;
                textBox10.Text = "0";
            }
            Button TEXT=(Button)sender;
            if(textBox10.Text=="0")
                textBox10.Text =TEXT.Text;
            else
                textBox10.Text = textBox10.Text + TEXT.Text;

        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox10.Text = "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Button TEXT = (Button)sender;
            Sym = TEXT.Text;
            Num = textBox10.Text;
            N= true;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double res, res1,res2=0;
            res = Convert.ToDouble(Num);
            res1 = Convert.ToDouble(textBox10.Text);
            if(Sym=="+")
            {
                res2 = res+res1;
            }
            if (Sym == "-")
            {
                res2 = res - res1;
            }
            if (Sym == "*")
            {
                res2 = res * res1;
            }
            if (Sym == "/")
            {
                res2 = res / res1;
            }
            Sym = "=";
            N = true;
            textBox10.Text = res2.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox10.Text = textBox10.Text + ",";
        }
    }
}
