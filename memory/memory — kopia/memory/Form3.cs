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
    public partial class Form3 : Form
    {
        List<Label> list = new List<Label>();
        Class1 ob;
        string big_text;
        string nick;
        int wynik;
        int level;
        string all=null;
        bool writen = false;
        public Form3(string nick_, int time_, int errors_, int level_)
        {
            InitializeComponent();
            nick = nick_;
            wynik = time_ + errors_;
            level = level_;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label2.Text = nick + "  " + wynik.ToString();
            list.Add(label4);
            ob = new Class1();

            big_text = ob.read_from_file(level);

            string[] subs = big_text.Split(' ', '\n');

            for(int i=1; i<subs.Length; i += 2)
            {
                if (wynik > int.Parse(subs[i]))
                {                   
                    all = all + nick + " " + wynik.ToString() + "\n";
                    all = all + subs[i - 1] + " " + subs[i] + "\n";
                    writen = true;
                    wynik = 0;
                }
                else
                {
                    all = all + subs[i - 1] + " " + subs[i] + "\n";
                }
            }

            if (writen == false)
            {
                all = all + nick + " " + wynik.ToString() + "\n";
            }

            label4.Text = all;

            ob.write_to_file(all, level);

        }
    }
}
