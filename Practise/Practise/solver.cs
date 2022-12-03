using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practise
{
    class solver
    {
        public static void conv_to(TextBox ans, TextBox num,TextBox _base)
        {
            int no = Convert.ToInt32(num.Text);
            int b = Convert.ToInt32(_base.Text);
            int r;
            string result = null;
                while(no>0)
            {
                r = no % b;
                result = r.ToString() + result;
                no = no / b;
             }
            ans.Text = result;
        }

        public static void conv_to_hex(TextBox ans, TextBox num, TextBox _base)
        {
            int no = Convert.ToInt32(num.Text);
            int b = Convert.ToInt32(_base.Text);
            int r;
            string result=null,rs = null;
            while (no > 0)
            {
                r = no % b;

                if(r == 10)
                {
                    rs = "A";
                    result = rs + result;
                    no = no / b;
                }
                else if (r == 11)
                {
                    rs = "B";
                    result = rs + result;
                    no = no / b;
                }
                else if (r == 12)
                {
                    rs = "C";
                    result = rs + result;
                    no = no / b;
                }
                else if (r == 13)
                {
                    rs = "D";
                    result = rs + result;
                    no = no / b;
                }
                else if (r == 14)
                {
                    rs = "E";
                    result = rs + result;
                    no = no / b;
                }
                else if (r == 15)
                {
                    rs = "F";
                    result = rs + result;
                    no = no / b;
                }
                else
                {
                    rs = r.ToString();
                    result = rs + result;
                    no = no / b;
                }

                
            }
            ans.Text = result;
        }

        public static void conv_from(TextBox ans, TextBox num, TextBox _base)
        {
            int b = Convert.ToInt32(_base.Text);
            char[] no = num.Text.ToCharArray();
            int lnt = num.TextLength;

            double result = 0;

            for (int i=0;i<lnt;i++)
            {
                result += Convert.ToInt32(int.Parse(no[i].ToString())) * Math.Pow(b,lnt-i-1);
            }
            ans.Text = result.ToString();
        }

        public static void conv_from_hex(TextBox ans, TextBox num, TextBox _base)
        {
            int b = Convert.ToInt32(_base.Text);
            char[] no = num.Text.ToCharArray();
            int lnt = num.TextLength;

            double result = 0;

            for (int i = 0; i < lnt; i++)
            {

                if (no[i] == 'A')
                {

                    result += 10 * Math.Pow(b, lnt - i - 1);
                }
                else if(no[i] == 'B')
                {
                    result += 11 * Math.Pow(b, lnt - i - 1);
                }
                else if (no[i] == 'C')
                {
                    result += 12 * Math.Pow(b, lnt - i - 1);
                }
                else if (no[i] == 'D')
                {
                    result += 13 * Math.Pow(b, lnt - i - 1);
                }
                else if (no[i] == 'E')
                {
                    result += 14 * Math.Pow(b, lnt - i - 1);
                }
                else if (no[i] == 'F')
                {
                    result += 15 * Math.Pow(b, lnt - i - 1);
                }
                else
                {

                    result += Convert.ToInt32(int.Parse(no[i].ToString())) * Math.Pow(b, lnt - i - 1);
                }

            }
            ans.Text = result.ToString();
        }


    }
}
