using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer
{
    public partial class countdown : Form
    { 
        float timer = 100;
       
        
        
            public countdown()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer = float.Parse(textBox1.Text);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer -= timer1.Interval * 0.001f;
            textBox1.Text = "Time ELapsed" + timer.ToString("0.0");
            if (timer < 0)
            {
                timer1.Enabled = false;
                textBox1.Text = "0.00";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dice form = new dice();
            form.Show();
            this.Close();
        }
    }
}
