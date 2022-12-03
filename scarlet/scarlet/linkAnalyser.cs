using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace scarlet
{
    class linkAnalyser
    {
        public static bool check(TextBox link)
        {
            var raw = link.Text;
            var analysed = false;

            //split link
            var domain = raw.Split('.');
            var len = domain.Length;
            analysed = (len >= 2) ? true : false;



            return analysed;
        }
       
    }
}
