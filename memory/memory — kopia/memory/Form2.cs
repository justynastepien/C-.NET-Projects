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
    public partial class Form2 : Form
    {
        int number_of_cards=48;
        Label firstClicked = null;
        Label secondClicked = null;
        int numbers_of_found = 0;
        int time = 0;
        string nick;
        int errors = 0;

        List<Label> found_labels = new List<Label>();

        Random random = new Random();


        List<string> icons_hard = new List<string>()
    {
        "!", "!", "N", "N", ",", ",", "k", "k",
        "b", "b", "v", "v", "w", "w", "z", "z",
        "a", "a", "c", "c", "g", "g", "d", "d",
        "e", "e", "f", "f", "h", "h", "i", "i",
        "j", "j", "l", "l", "m", "m", "n", "n",
        "o", "o", "p", "p", "r", "r", "s", "s",
        "t", "t", "u", "u", "x", "x", "A", "A",
        "B", "B", "C", "C", "D", "D", "E", "E",
        "F", "F", "G", "G", "H", "H", "I", "I",
        "J", "J", "K", "K", "L", "L", "M", "M",
        "O", "O", "P", "P", "R", "R", "S", "S",
        "T", "T", "U", "U", "W", "W", "X", "X",
        "Y", "Y", "Z", "Z", "#", "#", "@", "@",
        "$", "$", "%", "%", "^", "^", "&", "&",
        "*", "*", "(", "(", ")", ")", "+", "+"

    };

        List<string> icons_normal = new List<string>()
    {
        "!", "!", "N", "N", ",", ",", "k", "k",
        "b", "b", "v", "v", "w", "w", "z", "z",
        "a", "a", "c", "c", "g", "g", "d", "d",
        "e", "e", "f", "f", "h", "h", "i", "i",
        "j", "j", "l", "l", "m", "m", "n", "n",
        "o", "o", "p", "p", "r", "r", "s", "s",
        "t", "t", "u", "u", "x", "x", "A", "A",
        "B", "B", "C", "C", "D", "D", "E", "E",
        "F", "F", "G", "G", "H", "H", "I", "I",
        "J", "J", "K", "K", "L", "L", "M", "M",
        "O", "O", "P", "P"
    };

        List<string> icons_easy = new List<string>()
    {
        "!", "!", "N", "N", ",", ",", "k", "k",
        "b", "b", "v", "v", "w", "w", "z", "z",
        "a", "a", "c", "c", "g", "g", "d", "d",
        "e", "e", "f", "f", "h", "h", "i", "i",
        "j", "j", "l", "l", "m", "m", "n", "n",
        "o", "o", "p", "p", "r", "r", "s", "s"

    };

        public Form2(int time_start_, int time_wait_, int num, string nick_)
        {
            InitializeComponent();
            AssignIconsToSquares();
            number_of_cards = num;
            timer1.Interval = time_wait_;
            timer2.Interval = time_start_;
            timer3.Interval = 1000;
            nick = nick_;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Label label in tableLayoutPanel1.Controls)
            {
                label.Click += new System.EventHandler(this.labels_click);
            }
            timer2.Start();           
        }

        public Timer get_timer3()
        {
            return timer3;
        }

        public void set_new_time_wait(int new_time)
        {
            timer1.Interval = new_time*1000;
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void AssignIconsToSquares()
        {
            switch (number_of_cards) { 
                case 48:
                    {
                        int i = 0;
                        foreach (Control control in tableLayoutPanel1.Controls)
                        {
                            Label iconLabel = control as Label;
                            int randomNumber = 0;
                            if (iconLabel != null && i<48)
                            {
                                randomNumber = random.Next(icons_easy.Count);
                                iconLabel.Text = icons_easy[randomNumber];
                                icons_easy.RemoveAt(randomNumber);
                                i++;
                            }
                            else
                            {
                                //iconLabel.Visible = false;
                                iconLabel.BackColor = Color.DarkGoldenrod;

                            }
                        }
                        break;
                    }

                case 84:
                    {
                        int i = 0;
                        foreach (Control control in tableLayoutPanel1.Controls)
                        {
                            Label iconLabel = control as Label;
                            int randomNumber = 0;
                            if (iconLabel != null && i<84)
                            {
                                randomNumber = random.Next(icons_normal.Count);
                                iconLabel.Text = icons_normal[randomNumber];
                                icons_normal.RemoveAt(randomNumber);
                                i++;


                            }
                            else
                            {
                                //iconLabel.Visible = false;
                                iconLabel.BackColor = Color.Black;

                            }
                        }
                        break;
                    }

                case 120:
                    {
                        foreach (Control control in tableLayoutPanel1.Controls)
                        {
                            Label iconLabel = control as Label;
                            int randomNumber = 0;
                            if (iconLabel != null)
                            {
                                randomNumber = random.Next(icons_hard.Count);
                                iconLabel.Text = icons_hard[randomNumber];
                                icons_hard.RemoveAt(randomNumber);
                                
                            }
                            
                        }
                        break;
                    }

            }

            
        }


        private void click_labels(object sender, EventArgs e)
        {

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                clickedLabel.ForeColor = Color.Black;
            }
        }

        private void labels_click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (found_labels.Contains(clickedLabel) == true)
            {
                return;
            }
            if (clickedLabel != null)
            {
               
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                clickedLabel.ForeColor = Color.Black;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    return;
                }

                if(secondClicked == null)
                {
                    secondClicked = clickedLabel;
                    secondClicked.ForeColor = Color.Black;
                    timer1.Start();

                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if (firstClicked.Text.Equals(secondClicked.Text) == true)
            {

                firstClicked.BackColor = Color.Black;
                secondClicked.BackColor = Color.Black;

                firstClicked.ForeColor = firstClicked.BackColor;
                secondClicked.ForeColor = secondClicked.BackColor;

                found_labels.Add(firstClicked);
                found_labels.Add(secondClicked);

                numbers_of_found = found_labels.Count;
                if(numbers_of_found == number_of_cards)
                {
                    timer3.Stop();
                    //koniec
                    Form3 f3 = new Form3(nick,time, errors, 0);
                    f3.ShowDialog();

                }
                firstClicked = null;
                secondClicked = null;
                return;
            }
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            errors += 1;

            firstClicked = null;
            secondClicked = null;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            foreach (Label label in tableLayoutPanel1.Controls)
                label.ForeColor = label.BackColor;

            timer3.Start();
        }

        private void form4_KeyDown (object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                timer3.Stop();
                Form4 f4 = new Form4(time, this);
                f4.ShowDialog();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            time += 1;
        }
    }
}
