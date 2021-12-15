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
    public partial class menu : Form
    {
        
        public menu()
        {
            InitializeComponent();
        }

       

      

        

      
        

       

     

       

    

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.Hour.ToString("00")+":" + DateTime.Now.Minute.ToString("00");

        }

     

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           Form1 form = new Form1();
            form.Show();
        }
    }
}
