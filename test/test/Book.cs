using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace test
{
    class Book
    {
        public DateTime Birthdate { private get; set; }
        public Book(DateTime bd)
        {
            Birthdate = bd;
        }
        


        public int  Age {

            get
            {
                var timespan = DateTime.Today - Birthdate;
                var age = timespan.Days / 365;
                
                return Convert.ToInt32(age); 

            }

        }

        
      

    }
}
