using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security.Cryptography;


namespace scarlet
{
    public partial class Main : Form
    {
        public static string data;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,
                int nTopRect,
                int nRightRect,
                int nBottomRect,
                int nWidthEllipse,
                int nHeightEllipse

            );
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        // Mouse drag
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        // end od mouse drag


        public Main()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));

            // settings bar 
            settings.Width = 0;
            settings_cover.Width = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void settingIcon_Click(object sender, EventArgs e)
        {
            settings.Width =  340;
            settings_cover.Width = 600;
        }

        private void link_KeyUp(object sender, KeyEventArgs e)
        {
            var text = link.Text;
            if (text == "h" || text == "t" || text == "ht" || text == "ps" && text != "")
            {
                link.Text = "https://";
            }
            else if (text == "w" || text == "ww" && text != "")
            {
                link.Text = "https://www.";
            }
            else
            {
                
            }

            var link_analyser = new linkAnalyser();
            if(linkAnalyser.check(link))
            {
               link_err.Visible = false;
            } else
            {
                link_err.Visible = true;
            }

        }

        private void settingIconOff_Click(object sender, EventArgs e)
        {
            settings.Width = 0;
            settings_cover.Width = 0;
        
        }

        private void scan_link(object sender, EventArgs e)
        {

        }
    }
}
