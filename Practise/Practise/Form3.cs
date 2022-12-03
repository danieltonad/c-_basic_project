using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practise
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.Hide();   
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
