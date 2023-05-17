using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamWinForm
{
    public partial class Form1 : Form
    {
        DateTime date = DateTime.Now;
        Button[] keyboard;
        Button[] play;
        int fail;
        string str1, str4;
        string path;
        public Form1()
        {
            InitializeComponent();

            keyboard = new Button[] {
            button1,button2,button3,button4, button5,button6,button7,button8,button9,button10,
            button11,button12,button13,button14,button15,button16,button17,button18,button19,button20,button21,button22,
            button23,button24,button25,button26,button27,button28,button29,button30,button31,button32,button33,button34,button35,button36,button37,
            button38,button39,button40,button41,button42,button43,button44,button45,button46,button47,button48,button49,button50,button51,button52,
            button53,button54,button55,button56,button57,button58,button59,button60,button61};

            play = new Button[] { button62, button63 };
            str1 = textBox1.Text;
            str4 = textBox4.Text;
            fail = 0;
            path = "Result.txt";
        }

        private void button62_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox4.Clear();
            if (radioButton1.Checked) { textBox4.Text = "qetuo{d184630-+vbnm><? asfgk086321";
                textBox1.Focus();
            }
            else if (radioButton2.Checked) { textBox4.Text = "qy35vkodjsl:15590~++--'b   8456bvcnxxkd";
                textBox1.Focus();
            }
            else if (radioButton3.Checked) { textBox4.Text = "ajklvw8462mm c akdl; >><<<><>?02fk[  199-++---+||[[]zguc";
                textBox1.Focus();
            }
            label4.Text = "00:00";
            date = new DateTime(0, 0);
            timer1.Enabled = true;
            if (!radioButton1.Checked&& !radioButton2.Checked&& !radioButton3.Checked)
            {
                timer1.Stop();
                MessageBox.Show("Выберите сложность для начала игры!");
            }
            
        }
        public void check()
        {
            for (int i = 0; i < Math.Min(str1.Length, str4.Length); i++)
            {
                if (str1[i] != str4[i])
                {
                    fail++;
                }
            }
            fail += Math.Abs(str1.Length - str4.Length);
            textBox3.Text = fail.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date = date.AddSeconds(0.1);
            label4.Text = date.ToString("mm:ss");
        }

        private void button65_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.Write("Ваша запись: "+ textBox1.Text +"\n");
                sw.Write("Скорость: " + textBox2.Text+"\n");
                sw.Write("Кол-во ошибок : " + textBox3.Text+"\n");
                sw.WriteLine("\n");
                sw.Close();
                MessageBox.Show("Результат сохранен в файл");
            }
        }
        private void button64_Click(object sender, EventArgs e)
        {
            if(button64.Enabled)
            {
                button64.Text = "Dark";
                button64.BackColor = Color.Aqua;
                BackColor = Color.Black;
                for(int i=0;i<keyboard.Length;i++)
                {
                    keyboard[i].BackColor = Color.Aqua;
                }
                button56.BackColor = Color.CadetBlue;
                button57.BackColor = Color.CadetBlue;
                button58.BackColor = Color.CadetBlue;
                button59.BackColor = Color.CadetBlue;
                button60.BackColor = Color.CadetBlue;
                button61.BackColor = Color.CadetBlue;
                button32.BackColor = Color.DarkTurquoise;
                button38.BackColor = Color.DarkTurquoise;
                button45.BackColor = Color.DarkTurquoise;
                button37.BackColor = Color.DarkTurquoise;
                button43.BackColor = Color.DarkTurquoise;
                button31.BackColor = Color.DarkTurquoise;
                button65.BackColor = Color.DarkTurquoise;
                for (int i=0;i<play.Length;i++)
                {
                    play[i].BackColor = Color.CadetBlue;
                }
                label4.ForeColor = Color.Aqua;
                label1.ForeColor = Color.Aqua;
                label2.ForeColor = Color.Aqua;
                label3.ForeColor = Color.Aqua;

                radioButton1.ForeColor = Color.Aqua;
                radioButton2.ForeColor = Color.Aqua;
                radioButton3.ForeColor = Color.Aqua;

                textBox1.BackColor = Color.Aquamarine;
                textBox4.BackColor = Color.Aqua;
                textBox2.BackColor = Color.Aquamarine;
                textBox3.BackColor = Color.Aquamarine;
            }
            
            
        }
        private void button63_Click(object sender, EventArgs e)
        {
            string s = label4.Text;
            textBox2.Text = s;
            timer1.Enabled = false;
            label4.Text = "00:00";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            check();
            
        }
    }
}
