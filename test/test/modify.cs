using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class modify 
    {
        protected string name =null;
       
        


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
