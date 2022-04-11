using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string a_ = textBox1.Text;
            string b_ = textBox2.Text;
            string c_ = textBox3.Text;
            float a=float.Parse(a_);
            float b=float.Parse(b_);
            float c=float.Parse(c_);

            float delta = b * b - 4 * a * c;
            if(delta<0)
                MessageBox.Show("Brak miejsc zerowych");
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                MessageBox.Show(x.ToString());
            }
            else
            {
                double x1=(-b + Math.Sqrt(delta)) / (2 * a);
                double x2=(-b - Math.Sqrt(delta)) / (2 * a);
                MessageBox.Show(x1.ToString()+ x2.ToString());

            }
        }
    }
}
