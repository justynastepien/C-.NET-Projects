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
    public partial class Setting : Form
    {
        int start_time = 15;
        int wait_time = 1;
        string level = "hard";

        public Setting()
        {
            InitializeComponent();

            textBox1.Text = "15";
            textBox2.Text = "1";
            listBox1.Items.Add("easy");
            listBox1.Items.Add("normal");
            listBox1.Items.Add("hard");
        }

        public int get_start_time()
        {
            return start_time;
        }

        public int get_wait_time()
        {
            return wait_time;
        }

        public string get_level()
        {
            return level;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "15";
            textBox2.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            start_time = int.Parse(textBox1.Text);
            wait_time = int.Parse(textBox2.Text);
            level = listBox1.Text;
            this.Close();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
        }
    }
}
