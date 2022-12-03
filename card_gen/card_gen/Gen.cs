using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace card_gen
{
    class Gen
    {
        internal static string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "1234567890";
            return new String(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());

        }

        private static string rand(int length)
        {
            Random random = new Random();
            const string chars = "0123456789";
            var pre = new String(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());

            return pre;
        }



        public static string phases(int key, int length)
        {
            string pre = rand(length);
            string num = null;
            char[] test_key = pre.ToCharArray();
            int count = 0;
            int test;

           for (int i=0; i<length;i++)
            {
                test = Convert.ToInt32(int.Parse(test_key[i].ToString()));
                //char cond = Convert.ToChar(key);
                if (test == key)
                {
                    
                    count++;
                }
                else
                {
                    // do nothing;
                    //Console.WriteLine(test.ToString());

                  
                }
            } 
            

            if (count > 0)
            {
               num = pre;
                
                
            }

            else 
            {
                
               num = phases(key, length);
                //Console.WriteLine(pre);

            }

            return num;
        }
    }
}
