using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace komis
{
    public partial class AddCar : Form
    {
        public AddCar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string temp = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + textBox4.Text + " brak_zdjecia";

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            using (StreamWriter sw = File.AppendText(@"C:\Users\Justyna\source\repos\komis\komis\samochody.txt"))
            {
                sw.WriteLine(temp);
                
            }

            //ShowDialog("Dodano samochód do komisu");
            MessageBox.Show("Dodano samochód do komisu");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
