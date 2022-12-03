using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            nav.Width = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(255, 215, 0);
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = panel1.BackColor;
        }

        private void hide_Click(object sender, EventArgs e)
        {
            hide_timer.Start();

        }

        private void hide_timer_Tick(object sender, EventArgs e)
        {
            nav.Width -= 50;

            if (nav.Width <= 0)
            {
                hide_timer.Stop();
                this.Refresh();
            }
        }

        private void show_Click(object sender, EventArgs e)
        {
            show_timer.Start();
        }

        private void show_timer_Tick(object sender, EventArgs e)
        {
            
            if (nav.Width == 300)
            {
                show_timer.Stop();
                this.Refresh();
            }else
            {
                nav.Width += 50;
            }
        }

        private void show_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vol_Click(object sender, EventArgs e)
        {
            vol.BackColor = Color.FromArgb(255, 128, 0);
            length.BackColor = nav.BackColor;
            time.BackColor = nav.BackColor;
            date.BackColor = nav.BackColor;
            data.BackColor = nav.BackColor;
            speed.BackColor = nav.BackColor;
            wage.BackColor = nav.BackColor;
            gp.BackColor = nav.BackColor;
            temperature.BackColor = nav.BackColor;
            number_base.BackColor = nav.BackColor;
            about.BackColor = nav.BackColor;
            abt_icon.BackColor = nav.BackColor;
        }
        
        private void length_Click(object sender, EventArgs e)
        {
            vol.BackColor = nav.BackColor;
            length.BackColor = Color.FromArgb(255, 128, 0);
            time.BackColor = nav.BackColor;
            date.BackColor = nav.BackColor;
            data.BackColor = nav.BackColor;
            speed.BackColor = nav.BackColor;
            wage.BackColor = nav.BackColor;
            gp.BackColor = nav.BackColor;
            temperature.BackColor = nav.BackColor;
            number_base.BackColor = nav.BackColor;
            about.BackColor = nav.BackColor;
            abt_icon.BackColor = nav.BackColor;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(207, 207, 207);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = nav.BackColor;
        }

        private void show_MouseHover(object sender, EventArgs e)
        {
            show.BackColor = Color.FromArgb(253, 240, 162);
        }

        private void show_MouseLeave(object sender, EventArgs e)
        {
            show.BackColor = main.BackColor;
        }

        private void time_Click(object sender, EventArgs e)
        {
            vol.BackColor = nav.BackColor;
            length.BackColor = nav.BackColor;
            data.BackColor = nav.BackColor;
            date.BackColor = nav.BackColor;
            time.BackColor = Color.FromArgb(255, 128, 0);
            speed.BackColor = nav.BackColor;
            wage.BackColor = nav.BackColor;
            gp.BackColor = nav.BackColor;
            temperature.BackColor = nav.BackColor;
            number_base.BackColor = nav.BackColor;
            about.BackColor = nav.BackColor;
            abt_icon.BackColor = nav.BackColor;
        }

        private void date_Click(object sender, EventArgs e)
        {
            vol.BackColor = nav.BackColor;
            length.BackColor = nav.BackColor;
            time.BackColor = nav.BackColor;
            date.BackColor = Color.FromArgb(255, 128, 0);
            speed.BackColor = nav.BackColor;
            wage.BackColor = nav.BackColor;
            gp.BackColor = nav.BackColor;
            data.BackColor = nav.BackColor;
            temperature.BackColor = nav.BackColor;
            number_base.BackColor = nav.BackColor;
            about.BackColor = nav.BackColor;
            abt_icon.BackColor = nav.BackColor;
        }

        private void data_Click(object sender, EventArgs e)
        {
            vol.BackColor = nav.BackColor;
            length.BackColor = nav.BackColor;
            time.BackColor = nav.BackColor;
            date.BackColor = nav.BackColor;
            data.BackColor = Color.FromArgb(255, 128, 0);
            speed.BackColor = nav.BackColor;
            wage.BackColor = nav.BackColor;
            gp.BackColor = nav.BackColor;
            temperature.BackColor = nav.BackColor;
            number_base.BackColor = nav.BackColor;
            about.BackColor = nav.BackColor;
            abt_icon.BackColor = nav.BackColor;
        }

        private void speed_Click(object sender, EventArgs e)
        {
            vol.BackColor = nav.BackColor;
            length.BackColor = nav.BackColor;
            time.BackColor = nav.BackColor;
            date.BackColor = nav.BackColor;
            data.BackColor = nav.BackColor;
            speed.BackColor = Color.FromArgb(255, 128, 0);
            wage.BackColor = nav.BackColor;
            gp.BackColor = nav.BackColor;
            temperature.BackColor = nav.BackColor;
            number_base.BackColor = nav.BackColor;
            about.BackColor = nav.BackColor;
            abt_icon.BackColor = nav.BackColor;
        }

        private void number_base_Click(object sender, EventArgs e)
        {
            vol.BackColor = nav.BackColor;
            length.BackColor = nav.BackColor;
            time.BackColor = nav.BackColor;
            date.BackColor = nav.BackColor;
            data.BackColor = nav.BackColor;
            speed.BackColor = nav.BackColor;
            wage.BackColor = nav.BackColor;
            gp.BackColor = nav.BackColor;
            temperature.BackColor = nav.BackColor;
            number_base.BackColor = Color.FromArgb(255, 128, 0);
            about.BackColor = nav.BackColor;
            abt_icon.BackColor = nav.BackColor;

            /* switching ucf  */
            number_base1.BringToFront();
            show.BringToFront();
            nav.BringToFront();
            hide_timer.Start();
        }

        private void temperature_Click(object sender, EventArgs e)
        {
            vol.BackColor = nav.BackColor;
            length.BackColor = nav.BackColor;
            time.BackColor = nav.BackColor;
            date.BackColor = nav.BackColor;
            data.BackColor = nav.BackColor;
            speed.BackColor = nav.BackColor;
            wage.BackColor = nav.BackColor;
            gp.BackColor = nav.BackColor;
            temperature.BackColor = Color.FromArgb(255, 128, 0);
            number_base.BackColor = nav.BackColor;
            about.BackColor = nav.BackColor;
            abt_icon.BackColor = nav.BackColor;

            /* switching ucf  */
            temp1.BringToFront();
            show.BringToFront();
            nav.BringToFront();
            hide_timer.Start();
        }

        private void wage_Click(object sender, EventArgs e)
        {
            vol.BackColor = nav.BackColor;
            length.BackColor = nav.BackColor;
            time.BackColor = nav.BackColor;
            date.BackColor = nav.BackColor;
            data.BackColor = nav.BackColor;
            speed.BackColor = nav.BackColor;
            wage.BackColor = Color.FromArgb(255, 128, 0);
            gp.BackColor = nav.BackColor;
            temperature.BackColor = nav.BackColor;
            number_base.BackColor = nav.BackColor;
            about.BackColor = nav.BackColor;
            abt_icon.BackColor = nav.BackColor;
        }

        private void gp_Click(object sender, EventArgs e)
        {
            vol.BackColor = nav.BackColor;
            length.BackColor = nav.BackColor;
            time.BackColor = nav.BackColor;
            date.BackColor = nav.BackColor;
            data.BackColor = nav.BackColor;
            speed.BackColor = nav.BackColor;
            wage.BackColor = nav.BackColor;
            gp.BackColor = Color.FromArgb(255, 128, 0);
            temperature.BackColor = nav.BackColor;
            number_base.BackColor = nav.BackColor;
            about.BackColor = nav.BackColor;
            abt_icon.BackColor = nav.BackColor;
        }

        private void about_Click(object sender, EventArgs e)
        {
            vol.BackColor = nav.BackColor;
            length.BackColor = nav.BackColor;
            time.BackColor = nav.BackColor;
            date.BackColor = nav.BackColor;
            data.BackColor = nav.BackColor;
            speed.BackColor = nav.BackColor;
            wage.BackColor = nav.BackColor;
            gp.BackColor = nav.BackColor;
            temperature.BackColor = nav.BackColor;
            number_base.BackColor = nav.BackColor;
            about.BackColor = Color.FromArgb(255, 128, 0);
            abt_icon.BackColor = Color.FromArgb(255, 128, 0);
        }

        private void nav_Leave(object sender, EventArgs e)
        {
            hide_timer.Start();
        }

        private void nav_Leave(object sender, KeyEventArgs e)
        {
            hide_timer.Start();
        }
    }
}
