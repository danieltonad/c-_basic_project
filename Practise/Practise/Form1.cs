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
    public partial class Form1  : Form
    {
        int nav_width;
        bool hide;

        public Form1()
        {
            InitializeComponent();
            nav_width = nav.Width;
            hide = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 obj = new Form2();
            obj.ShowDialog();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 obj = new Form3();
            obj.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
       
        }

        private void time_Tick(object sender, EventArgs e)
        {

            for (int i=0;i<1000;i++)
            {
                if (time.Interval == i || time.Interval == i+1)
                {
                    progressBar1.Value = i;
            }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            time.Enabled = true;
            //progressBar1.Value = 0;
            bunifuCircleProgressbar1.Value = 13;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if (hide) button5.Text = "hide";
            else button5.Text = "show";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hide)
            {
                nav.Width += 100;
                if (nav.Width >= nav_width)
                {
                    timer1.Stop();
                    hide = false;
                   this.Refresh();
                }
            }
            else
            {
                nav.Width -= 100;
                if (nav.Width <= 0)
                {
                    timer1.Stop();
                    hide = true;
                    this.Refresh();
                }
            }
                
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //solver.conv_from(ans, bin,Base);
            modify.add(Base,bin,ans);
            modify.color(Base, Color.Red, Color.Blue, bin, ans);
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            
            int no = int.Parse(bin.Text);
            int X=0,Y=0;

            for (int i = 0; i < no; i++)
            {
                TextBox text = new TextBox();
                text.Text = (i+1).ToString();
                
                text.Location = new Point(X,Y);
                panel2.Controls.Add(text);
                
                panel2.Show();
                Y += 33;
            }

            panel2.AutoScroll = true;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            var task = new rename();
            MessageBox.Show(task.ViewName());
            
        }

        private void guna2VProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
