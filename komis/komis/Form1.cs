using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace komis
{
    public partial class Form1 : Form
    {
        string nick;
        public Form1()
        {
            InitializeComponent();
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Konfiguracja konf = new Konfiguracja(nick);
            konf.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCar ac = new AddCar();
            ac.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            nick = textBox1.Text;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TestDrive td = new TestDrive(nick);
            td.ShowDialog();
        }
    }
}
