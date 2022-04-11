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
    public partial class Konfiguracja : Form
    {
        string text=null;
        string[] subs;
        string nick;
        Dictionary<string, string> map = new Dictionary<string, string>();
        Dictionary<int, bool> clicked = new Dictionary<int, bool>();
        List<string> added_marks = new List<string>();
        List<string> added_models = new List<string>();
        List<string> added_engine = new List<string>();
        List<string> added_color = new List<string>();

        string car=null;
        string mark=null;
        string model=null;
        string engine=null;
        string color=null;

        public Konfiguracja(string nick_)
        {
            nick = nick_;
            InitializeComponent();
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

            foreach (string line in File.ReadLines(@"C:\Users\Justyna\source\repos\komis\komis\samochody.txt"))
            {
                text = text + (line + '\n');
            }

            subs = text.Split(' ', '\n');

            for(int i=1; i<=4; i++)
            {
                clicked.Add(i, false);
            }

            
            for (int i = 0; i < subs.Length-1; i ++)
            {

                switch (i % 5)
                {
                    case 0:
                        string temp = subs[i] + "_" + subs[i + 1] + "_" + subs[i + 2] + "_" + subs[i + 3];
                        map.Add(temp, subs[i + 4]);
                        if (!added_marks.Contains(subs[i]))
                        {
                            listBox1.Items.Add(subs[i]);
                            
                            added_marks.Add(subs[i]);
                        }                       
                        break;
                    case 1:
                        if (!added_models.Contains(subs[i]))
                        {
                            listBox2.Items.Add(subs[i]);
                            added_models.Add(subs[i]);
                        }
                        break;
                    case 2:
                        if (!added_engine.Contains(subs[i]))
                        {
                            listBox3.Items.Add(subs[i]);
                            added_engine.Add(subs[i]);
                        }
                         break;
                    case 3:
                        if (!added_color.Contains(subs[i]))
                        {
                            listBox4.Items.Add(subs[i]);
                            added_color.Add(subs[i]);
                        }
                         break;

                }

            }
        }


       

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mark = listBox1.SelectedItem.ToString();

            clicked[1] = true;

            if (clicked[2] == false)
            {
                listBox2.Items.Clear();
            }

            if (clicked[3] == false)
            {
                listBox3.Items.Clear();
            }

            if (clicked[4] == false)
            {
                listBox4.Items.Clear();
            }
            

            for (int i=0; i<subs.Length-1; i+=5)
            {
                if (listBox1.SelectedItem.ToString().Equals(subs[i]) == true && (model == null || model.Equals(subs[i + 1])) && (engine == null || engine.Equals(subs[i + 2])) && (color == null || color.Equals(subs[i + 3])))
                {
                    if (clicked[2] == false)
                    {
                        listBox2.Items.Add(subs[i + 1]);
                    }

                    if (clicked[3] == false)
                    {
                        listBox3.Items.Add(subs[i + 2]);
                    }

                    if (clicked[4] == false)
                    {
                        listBox4.Items.Add(subs[i + 3]);
                    }                   

                }
                //if (!map.ContainsKey(subs[i]))
                //{
                  //  map.Add(subs[i]+"_"+subs[i+1] + "_" + subs[i + 2] + "_" + subs[i + 3], subs[i + 4]);
               // }

            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            model = listBox2.SelectedItem.ToString();

            clicked[2] = true;

            if (clicked[1] == false)
            {
                listBox1.Items.Clear();
            }

            if (clicked[3] == false)
            {
                listBox3.Items.Clear();
            }

            if (clicked[4] == false)
            {
                listBox4.Items.Clear();
            }
            

            for (int i = 1; i < subs.Length-1; i += 5)
            {
                if (listBox2.SelectedItem.ToString().Equals(subs[i]) == true && (mark == null || mark.Equals(subs[i - 1])) && (engine == null || engine.Equals(subs[i + 1])) && (color == null || color.Equals(subs[i + 2])))
                {
                    if (clicked[1] == false)
                    {
                        listBox1.Items.Add(subs[i - 1]);
                    }

                    if (clicked[3] == false)
                    {
                        listBox3.Items.Add(subs[i + 1]);
                    }

                    if (clicked[4] == false)
                    {
                        listBox4.Items.Add(subs[i + 2]);
                    }
                    

                    //if (!map.ContainsKey(subs[i-1]))
                   // {
                     //   map.Add(subs[i-1], subs[i + 3]);
                    //}

                }

            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            engine = listBox3.SelectedItem.ToString();

            clicked[3] = true;

            if (clicked[1] == false)
            {
                listBox1.Items.Clear();
            }

            if (clicked[2] == false)
            {
                listBox2.Items.Clear();
            }

            if (clicked[4] == false)
            {
                listBox4.Items.Clear();
            }
            

            for (int i = 2; i < subs.Length-1; i += 5)
            {
                if (listBox3.SelectedItem.ToString().Equals(subs[i]) == true && (mark==null || mark.Equals(subs[i - 2])) && (model==null || model.Equals(subs[i - 1])) && (color==null || color.Equals(subs[i+1])))
                {
                    if (clicked[1] == false)
                    {
                        listBox1.Items.Add(subs[i - 2]);
                    }

                    if (clicked[2] == false)
                    {
                        listBox2.Items.Add(subs[i - 1]);
                    }

                    if (clicked[4] == false )
                    {
                        listBox4.Items.Add(subs[i + 1]);
                    }
                         

                }

            }
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            color = listBox4.SelectedItem.ToString();

            clicked[4] = true;

            if (clicked[1] == false)
            {
                listBox1.Items.Clear();
            }

            if (clicked[2] == false)
            {
                listBox2.Items.Clear();
            }

            if (clicked[3] == false)
            {
                listBox3.Items.Clear();
            }
            

            for (int i = 3; i < subs.Length-1; i += 5)
            {
                if (listBox4.SelectedItem.ToString().Equals(subs[i]) == true && (mark == null || mark.Equals(subs[i - 3])) && (model == null || model.Equals(subs[i - 2])) && (engine == null || engine.Equals(subs[i - 1])))
                {
                    if (clicked[1] == false)
                    {
                        listBox1.Items.Add(subs[i - 3]);
                    }

                    if (clicked[2] == false)
                    {
                        listBox2.Items.Add(subs[i - 2]);
                    }

                    if (clicked[3] == false)
                    {
                        listBox3.Items.Add(subs[i - 1]);
                    }
                    
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();

            for (int i = 1; i < 5; i++)
            {
                clicked[i] = false;
            }

            added_marks.Clear();
            added_models.Clear();
            added_engine.Clear();
            added_color.Clear();


            car = null;
            mark = null;
            model = null;
            engine = null;
            color = null;

            pictureBox1.BackgroundImage = null;

            for (int i = 0; i < subs.Length - 1; i++)
            {

                switch (i % 5)
                {
                    case 0:
                        if (!added_marks.Contains(subs[i]))
                        {
                            listBox1.Items.Add(subs[i]);

                            added_marks.Add(subs[i]);
                        }
                        break;
                    case 1:
                        if (!added_models.Contains(subs[i]))
                        {
                            listBox2.Items.Add(subs[i]);
                            added_models.Add(subs[i]);
                        }
                        break;
                    case 2:
                        if (!added_engine.Contains(subs[i]))
                        {
                            listBox3.Items.Add(subs[i]);
                            added_engine.Add(subs[i]);
                        }
                        break;
                    case 3:
                        if (!added_color.Contains(subs[i]))
                        {
                            listBox4.Items.Add(subs[i]);
                            added_color.Add(subs[i]);
                        }
                        break;

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            car = mark + "_" + model + "_" + engine + "_" + color;
            string path = map[car];
            if (!path.Equals("brak_zdjecia"))
            {
                pictureBox1.BackgroundImage = Image.FromFile(path);
            }

            using (StreamWriter sw = File.AppendText(@"C:\Users\Justyna\source\repos\komis\komis\rezerwacje.txt"))
            {
                sw.WriteLine(nick + "_" + car + "_nodate");

            }

        }
    }
}
