using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practise
{
    class modify
    {
        protected string name =null;
       
        public static void add( params TextBox[] numbers)
        {
            
             int sum = 0;
            
            foreach (var no in numbers)
            {
                sum += Convert.ToInt32(no.Text);
            }
            MessageBox.Show(sum.ToString());
        }

        public static void color(TextBox dif,System.Drawing.Color def , System.Drawing.Color gen,params TextBox[] boxes)
        {

            foreach (var box in boxes)
            {
                box.ForeColor = gen;
            }
            dif.ForeColor = def;

        }


        public void Name(string _name)
        {
            name = _name;
        }

        public string ViewName()
        {
            return name;
        }


    }
}
