using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wages
{
    class temp_solver
    {
        public static void conv_to (TextBox data,char from,char to,TextBox info)
        {
            try
            {
                if (data.Text == "")
                {
                    data.Text = "0";
                }
               
                double temp = Convert.ToDouble(data.Text);
                double sol = 0;
                //
                //cel to ...
                //
                if (from == 'C' && to == 'F')
                {
                    sol = temp * 1.8 + 32;
                    sol = Math.Round(sol, 3);
                }
                else if (from == 'C' && to == 'K')
                {
                    sol = temp + 273.15;
                    sol = Math.Round(sol, 3);
                }
                else if (from == 'C' && to == 'R')
                {
                    sol = temp * 1.8 + 32 + 459.67;
                    sol = Math.Round(sol, 3);
                }
                else if (from == 'C' && to == 'r')
                {
                    sol = temp * 0.8;
                    sol = Math.Round(sol, 3);
                }
                //
                //fah to ...
                //
                else if (from == 'F' && to == 'C')
                {
                    sol = (temp - 32) / 1.8;
                    sol = Math.Round(sol, 3);
                }
                else if (from == 'F' && to == 'K')
                {
                    sol = (temp + 459.67) / 1.8;
                    sol = Math.Round(sol, 3);
                }
                else if (from == 'F' && to == 'R')
                {
                    sol = temp + 459.67;
                    sol = Math.Round(sol, 3);
                }
                else if (from == 'F' && to == 'r')
                {
                    sol = (temp - 32) / 2.25;
                    sol = Math.Round(sol, 3);
                }
                //
                //Rank to ...
                //
                else if (from == 'R' && to == 'C')
                {
                    sol = (temp - 32 - 459.67) / 1.8;
                    sol = Math.Round(sol, 3);
                }
                else if (from == 'R' && to == 'F')
                {
                    sol = temp - 459.67;
                    sol = Math.Round(sol, 3);
                }
                else if (from == 'R' && to == 'K')
                {
                    sol = temp  / 1.8;
                    sol = Math.Round(sol, 3);
                }
                else if (from == 'R' && to == 'r')
                {
                    sol = (temp - 32 - 459.67) / 2.25;
                    sol = Math.Round(sol, 3);
                }
                //
                //rea to ...
                //
                else if (from == 'r' && to == 'C')
                {
                    sol = temp * 1.25;
                    sol = Math.Round(sol, 3);
                }
                else if (from == 'r' && to == 'F')
                {
                    sol = temp * 2.25 + 32;
                    sol = Math.Round(sol, 3);
                }
                else if (from == 'r' && to == 'K')
                {
                    sol = temp * 1.25 + 273.15;
                    sol = Math.Round(sol, 3);
                }
                else if (from == 'r' && to == 'R')
                {
                    sol = temp * 2.25 + 32 + 459.67;
                    sol = Math.Round(sol, 3);
                }
                //
                //kel to ...
                //
                else if (from == 'K' && to == 'C')
                {
                    sol = temp - 273.15;
                    sol = Math.Round(sol, 3);
                }
                else if (from == 'K' && to == 'F')
                {
                    sol = temp * 1.8 - 459.67;
                    sol = Math.Round(sol, 3);
                }
                else if (from == 'K' && to == 'R')
                {
                    sol = temp * 1.8;
                    sol = Math.Round(sol, 3);
                }
                else if (from == 'K' && to == 'r')
                {
                    sol = (temp - 273.15) * 0.8 ;
                    sol = Math.Round(sol, 3);
                }

                info.Text = sol.ToString();
            }

            catch
            {

            }
        }
    }
}
