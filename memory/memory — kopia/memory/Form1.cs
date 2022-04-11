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
    public partial class Form1 : Form
    {
        Setting s;
        float time_start;
        float time_wait;
        int number_of_cards=0;
        string nick;
        public Form1()
        {
            InitializeComponent();
        }

        public int GetTimeStart()
        {
            time_start = s.get_start_time() * 1000;
            return (int)time_start;
        }

        public int GetTimeWait()
        {
            time_wait = s.get_wait_time() * 1000;
            return (int)time_wait;
        }

        public int GetLevel()
        {
            string level = s.get_level();
            switch (level)
            {
                case "hard":
                    number_of_cards = 120; break;
                case "normal":
                    number_of_cards = 84; break;
                case "easy":
                    number_of_cards = 48; break;
            }
            return number_of_cards;
        }

        public string get_nick()
        {
            return nick;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nick = textBox1.Text;
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //time_start = float.Parse(textBox1.Text);
            //time_wait = float.Parse(textBox2.Text);
            //number_of_cards = int.Parse(textBox3.Text);
            //button1.Visible = true;
            s = new Setting();
            s.ShowDialog();
            //time_start = s.get
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
