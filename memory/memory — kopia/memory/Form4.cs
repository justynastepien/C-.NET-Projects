using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memory
{
    public partial class Form4 : Form
    {
        Form2 f2;
        int time;
        public Form4(int time_, Form2 ob)
        {
            InitializeComponent();
            f2 = ob;
            this.time = time_;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label4.Text = time.ToString()+" s";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int new_time = int.Parse(textBox1.Text);
            f2.set_new_time_wait(new_time);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            f2.get_timer3().Start();
            this.Close();
        }
    }
}
