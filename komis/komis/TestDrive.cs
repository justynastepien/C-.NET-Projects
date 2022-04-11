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
    public partial class TestDrive : Form
    {
        string text = null;
        string[] subs;
        string nick;
  
        public TestDrive(string nick_)
        {
            InitializeComponent();

            nick = nick_;

            foreach (string line in File.ReadLines(@"C:\Users\Justyna\source\repos\komis\komis\rezerwacje.txt"))
            {
                text = text + (line + '\n');
            }

            subs = text.Split('_', '\n');

            for(int i=0; i < subs.Length - 2; i+=6)
            {
                if(subs[i].Equals(nick) && subs[i+5].Equals("nodate"))
                {
                    listBox1.Items.Add(subs[i + 1] + " " + subs[i + 2] + " " + subs[i + 3] + " " + subs[i + 4]);
                }
                    
                else if (!subs[i+5].Equals("nodate"))
                {
                    listBox2.Items.Add(subs[i + 1] + " " + subs[i + 2] + " " + subs[i + 3] + " " + subs[i + 4] + " " + subs[i + 5]);                    
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string theDate = dateTimePicker1.Value.ToShortDateString();
            string alltext = null;
            string picked = listBox1.SelectedItem.ToString();

            for (int i = 0; i < subs.Length - 1; i += 6)
            {
                string car = subs[i + 1] + "_" + subs[i + 2] + "_" + subs[i + 3] + "_" + subs[i + 4];

                if (subs[i].Equals(nick) && picked.Equals(subs[i + 1] + " " + subs[i + 2] + " " + subs[i + 3] + " " + subs[i + 4]))
                {
                    subs[i + 5] = theDate;
                    
                    alltext = alltext + subs[i] + "_" + car + "_" + subs[i + 5] + "\n";
                    listBox2.Items.Add(car + "_" + subs[i+5]);
                    listBox1.Items.Remove(subs[i + 1] + " " + subs[i + 2] + " " + subs[i + 3] + " " + subs[i + 4]);

                    continue;
                }

                alltext = alltext + car + "_" + subs[i + 5] + "\n";
            }

            File.WriteAllText(@"C:\Users\Justyna\source\repos\komis\komis\rezerwacje.txt", alltext);

            
        }
    }
}
