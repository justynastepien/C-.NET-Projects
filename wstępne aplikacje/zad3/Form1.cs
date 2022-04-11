using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            listBox1.Items.Add(text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text1 = textBox1.Text;
            while (listBox1.Items.Contains(text1))
                listBox1.Items.Remove(text1);
        }
    }
}
