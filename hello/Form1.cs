using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {


            if(textBox1.Text == "" || textBox2.Text == "") 
            {
                Random rnd = new Random();

                int maxX = panel1.Width ;
                int maxY = panel1.Height;

                int x = rnd.Next(0, maxX);
                int y = rnd.Next(0, maxY);

                button1.Location = new System.Drawing.Point(x, y);

                lblWarning.Visible=true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblWarning.Visible = false;
        }
    }
}
