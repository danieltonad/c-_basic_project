using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wages
{
    class validator
    {
        public static void numbers(KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        public static void letters(KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public static void letters_space(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public static void alpha_num(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)  && !char.IsWhiteSpace(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public static void alpha_num_string (KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public static void email(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && !char.IsLower(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public static void lower_case(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLower(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public static void upper_case(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLower(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public static void integer (KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar !=8 )
            {
                e.Handled = true;
            }
        }

        public static void real(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 45 && e.KeyChar != 43)
            {
                e.Handled = true;
            }
        }

        public static void  Double(KeyPressEventArgs e,TextBox box)
        {
            if(e.KeyChar == 46 &&   box.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 45 && e.KeyChar != 43 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        public static void binary(KeyPressEventArgs e)
        {
            if ( e.KeyChar != 48 && e.KeyChar != 49 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        public static void hex(KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar!=65 && e.KeyChar != 66 && e.KeyChar != 67 && e.KeyChar != 68 && e.KeyChar != 69 && e.KeyChar != 70 && e.KeyChar != 97 && e.KeyChar != 98 && e.KeyChar != 99 && e.KeyChar != 100 && e.KeyChar != 101 && e.KeyChar != 102)
            {
                e.Handled = true;
            }
        }

        public static void oct(KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 48 && e.KeyChar != 49 && e.KeyChar != 50 && e.KeyChar != 51 && e.KeyChar != 52 && e.KeyChar != 53 && e.KeyChar != 54 && e.KeyChar != 55)
            {
                e.Handled = true;
            }
        }

        public static void hept(KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 48 && e.KeyChar != 49 && e.KeyChar != 50 && e.KeyChar != 51 && e.KeyChar != 52 && e.KeyChar != 53 && e.KeyChar != 54)
            {
                e.Handled = true;
            }
        }


    }
}
