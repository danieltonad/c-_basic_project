using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace card_gen
{
    class Program
    {
        static void Main(string[] args)
        {

            string beg;
            int a, b;
            string p1, p2 = null, card = null;

            Console.WriteLine("input first 5");
            beg = Console.ReadLine();

            Console.WriteLine("input first key");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("input second key");
            b = Convert.ToInt32(Console.ReadLine());






            for (int i = 0; i < 5; i++)
            {
                p1 = Gen.phases(a, 5);

                p2 = Gen.phases(b, 5);



                card = beg + " " + p1 + " " + p2;
                Console.WriteLine("----------------------");

                Console.WriteLine(card);
                Console.WriteLine("----------------------");
            }

            Console.ReadLine();


        }

    }   
}
