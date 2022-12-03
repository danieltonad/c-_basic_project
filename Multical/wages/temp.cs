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
    public partial class temp : UserControl
    {
        public temp()
        {
            InitializeComponent();
        }

        private void cel_KeyPress(object sender, KeyPressEventArgs e)
        {
            validator.Double(e,cel);
            //
        }

        private void cel_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void fah_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void kel_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void rank_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rea_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void fah_KeyPress(object sender, KeyPressEventArgs e)
        {
            validator.Double(e, fah);
            //
        }

        private void kel_KeyPress(object sender, KeyPressEventArgs e)
        {
            validator.Double(e, kel);
            //
           
        }

        private void rank_KeyPress(object sender, KeyPressEventArgs e)
        {
            validator.Double(e, rank);
            //
        }

        private void rea_KeyPress(object sender, KeyPressEventArgs e)
        {
            validator.Double(e, rea);
            //
            
        }

        private void cel_KeyUp(object sender, KeyEventArgs e)
        {

            temp_solver.conv_to(cel, 'C', 'F', fah);
            temp_solver.conv_to(cel, 'C', 'K', kel);
            temp_solver.conv_to(cel, 'C', 'R', rank);
            temp_solver.conv_to(cel, 'C', 'r', rea);
        }

        private void fah_KeyUp(object sender, KeyEventArgs e)
        {

            temp_solver.conv_to(fah, 'F', 'C', cel);
            temp_solver.conv_to(fah, 'F', 'K', kel);
            temp_solver.conv_to(fah, 'F', 'R', rank);
            temp_solver.conv_to(fah, 'F', 'r', rea);
        }

        private void kel_KeyUp(object sender, KeyEventArgs e)
        {
            temp_solver.conv_to(kel, 'K', 'C', cel);
            temp_solver.conv_to(kel, 'K', 'F', fah);
            temp_solver.conv_to(kel, 'K', 'R', rank);
            temp_solver.conv_to(kel, 'K', 'r', rea);
        }

        private void rank_KeyUp(object sender, KeyEventArgs e)
        {

            temp_solver.conv_to(rank, 'R', 'C', cel);
            temp_solver.conv_to(rank, 'R', 'F', fah);
            temp_solver.conv_to(rank, 'R', 'K', kel);
            temp_solver.conv_to(rank, 'R', 'r', rea);
        }

        private void rea_KeyUp(object sender, KeyEventArgs e)
        {
            temp_solver.conv_to(rea, 'r', 'C', cel);
            temp_solver.conv_to(rea, 'r', 'F', fah);
            temp_solver.conv_to(rea, 'r', 'K', kel);
            temp_solver.conv_to(rea, 'r', 'R', rank);
        }

      
    }
}
