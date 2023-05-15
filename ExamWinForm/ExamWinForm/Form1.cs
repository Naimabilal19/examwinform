using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamWinForm
{
    public partial class Form1 : Form
    {
        Button[] keyboard;
        Button[] play;
        int speed=0, fail=0;
        char[] znak;
        int h=0, m=0, s=0;
        string str, str1= "QETUO{D184630-+VBNM><? ASFGJK086321", str2= "QY35VKODJSL:15590~++--'B   8456BVCNXXKD", 
            str3= "AJKLDVW8462MM C AKDL; >><<<><>?02Fk[  199-++---+||[[]ZGCUS";
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
            str = textBox1.Text;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            string s = e.KeyCode.ToString();
            for(int i =0;i<Controls.Count;i++)
            {
                if (Controls[i].Text == s) { Controls[i].BackColor = Color.Yellow; }
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            string s = e.KeyCode.ToString();
            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i].Text == s) { Controls[i].BackColor = Color.White; }
            }
        }

        private void button62_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { textBox4.Text = str1;
                textBox1.Focus();
            }
            else if (radioButton2.Checked) { textBox4.Text = str2;
                textBox1.Focus();
            }
            else if (radioButton3.Checked) { textBox4.Text = str3;
                textBox1.Focus();
            }

            timer1.Start();
            if(!radioButton1.Checked&& !radioButton2.Checked&& !radioButton3.Checked)
            {
                timer1.Stop();
                MessageBox.Show("Выберите сложность для начала игры!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s = s- 1;
            if(s==-1)
            {
                m = m-1;
                s = 59;
            }
            if(m==-1)
            {
                h =  0;
                m = 2;
            }
            if(h==0&&m==0&&s==0)
            {
                timer1.Stop();
                MessageBox.Show("Время вышло");
            }

            label4.Text = Convert.ToString(h);
            label5.Text = Convert.ToString(m);
            label6.Text = Convert.ToString(s);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            speed = 0;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, KeyEventArgs e)
        {
            
            
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
                for(int i=0;i<play.Length;i++)
                {
                    play[i].BackColor = Color.CadetBlue;
                }
                label4.ForeColor = Color.Aqua;
                label5.ForeColor = Color.Aqua;
                label6.ForeColor = Color.Aqua;
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
            timer1.Stop();
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
            for (int i = 0; i < textBox4.TextLength; i++)
            {
                for (int j = 0; j < textBox4.TextLength; j++)
                {
                    if (textBox1.Text[i] != textBox4.Text[j])
                        fail++;
                    else
                        fail = 0;
                }
            }
            textBox3.Text = fail.ToString();
            textBox1.Clear();

        }
    }
}
