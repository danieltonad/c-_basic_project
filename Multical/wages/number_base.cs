using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wages
{
    public partial class number_base : UserControl
    {
        public number_base()
        {
            InitializeComponent();
        }

        private void dec_TextChanged(object sender, EventArgs e)
        {
            solver.conv_to(bin, dec, 2);
            solver.conv_to(oct, dec, 8);
            solver.conv_to(hepta, dec, 7);
            solver.conv_to_hex(hex, dec, 16);
        }

        private void bin_TextChanged(object sender, EventArgs e)
        {
            solver.conv_from(dec, bin, 2);
        }

        private void oct_TextChanged(object sender, EventArgs e)
        {
            solver.conv_from(dec, oct, 8);
        }

        private void hepta_TextChanged(object sender, EventArgs e)
        {
            solver.conv_from(dec, hepta,7);
        }

        private void hex_TextChanged(object sender, EventArgs e)
        {
            solver.conv_from_hex(dec, hex, 16);
        }

        private void dec_Click(object sender, EventArgs e)
        {
        }

        private void bin_Click(object sender, EventArgs e)
        {
        }

        private void oct_Click(object sender, EventArgs e)
        {
        }

        private void hepta_Click(object sender, EventArgs e)
        {
        }

        private void hex_Click(object sender, EventArgs e)
        {
        }

        private void dec_KeyPress(object sender, KeyPressEventArgs e)
        {
            validator.integer(e);
        }

        private void bin_KeyPress(object sender, KeyPressEventArgs e)
        {
            validator.binary(e);
        }

        private void hex_KeyPress(object sender, KeyPressEventArgs e)
        {
            validator.hex(e);
        }

        private void oct_KeyPress(object sender, KeyPressEventArgs e)
        {
            validator.oct(e);
        }

        private void hepta_KeyPress(object sender, KeyPressEventArgs e)
        {
            validator.hept(e);
        }
    }
}
