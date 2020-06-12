using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract3_ex1Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Func(int x)
        {
            x = Math.Abs(x);
            if (x < 10)
                throw new Exception("Число однозначное");
            else
                return x / 10 % 10;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            textBox2.Text = Convert.ToString(Func(x));
        }
        int FindFx(int a, int b, int c)
        {
            return  Func(a) + Func(b) - Func(c);
        }
        private void button3_Click(object sender, EventArgs e)
        { 
            int a = Convert.ToInt32(textBox3.Text);
            int b = Convert.ToInt32(textBox4.Text);
            int c = Convert.ToInt32(textBox5.Text);
            textBox6.Text = Convert.ToString(FindFx(a, b, c));
        }
    }
}
