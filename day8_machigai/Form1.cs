using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day8_machigai
{
    public partial class Form1 : Form
    {
        private string correct_string = @"萩";
        private string dummy_string = @"荻";
        private double nowTime;
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttons_click(object sender, EventArgs e)
        {
            if(((Button)sender).Text == correct_string)
            {
                timer1.Stop();
            }
            else
            {
                nowTime += 10;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nowTime += 0.02;
            textBox2.Text = nowTime.ToString("0.00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // スタートボタン押下
            int correct_num = 0;
            Random rnd = new Random();
            // 正解の文字を表示
            textBox1.Text = correct_string;
            // 乱数発生
            correct_num = rnd.Next(2, 26);
            // すべてをダミーに
            for (int i=0;i < 25; i++)
            {
                splitContainer1.Panel2.Controls[i].Text = dummy_string;
            }
            // 一つだけ正解に
            splitContainer1.Panel2.Controls[correct_num].Text = correct_string;
            // 時間リセット
            nowTime = 0;
            timer1.Start();

        }
    }
}
