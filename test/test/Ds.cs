using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Ds
    {

        public List<int> data { private get;set; }
        public int view {
            
            get
            {

                foreach (int item in data)
                {
                    Console.WriteLine(item);
                }

                return 0;
            }

        }


        public Ds(params int[] me )
        {
            data = new List<int>();
            
            foreach (var n in me)
            {
               data.Add(n);
            }
        }
            
    }
}
