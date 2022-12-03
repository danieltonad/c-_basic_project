using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculator();

            //Switch();

            // var a = new Ds(1,2,4,5,6,7,5,6,5,5,8,9,0,8,76);
            // Console.WriteLine(a.view);
            //var we = new rename();

            // Console.WriteLine(file.ReadLine(@"C:\Users\USER\Documents\Bluettoth\alfa.txt"));
            // Console.WriteLine(file.ReadAll(@"C:\Users\USER\Documents\Bluettoth\alfa.txt"));
            var raw = "https://www.google.com";
            var domain = raw.Split('.');
            var len = domain.Length;
            var link = (len >= 3 ) ? true : false;

            Console.WriteLine(domain[0]);
        }

        static void Switch()
        {
            try
            {
                Console.WriteLine("Input Day Number");
                int r = Convert.ToInt32(Console.ReadLine());

                switch (r)
                {
                    case 1:
                        Console.WriteLine("Sunday");
                        break;
                    case 2:
                        Console.WriteLine("Monday");
                        break;
                    case 3:
                        Console.WriteLine("Tuesday");
                        break;
                    case 4:
                        Console.WriteLine("Wednessday");
                        break;
                    case 5:
                        Console.WriteLine("Thursday");
                        break;
                    case 6:
                        Console.WriteLine("Friday");
                        break;
                    case 7:
                        Console.WriteLine("Saturday");
                        break;
                    default:
                        Console.WriteLine("You Have inserted an Invalid Number");
                        break;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        static void Calculator()
        {
            Console.Write("Enter number :");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator :");
            string op = Console.ReadLine();

            Console.Write("Enter number :");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else if (op == "^")
            {
                Console.WriteLine(Math.Pow(num1,num2));
            }
            else
            {
                Console.WriteLine("Oops!! Invalid Operator");
            }




        }
    }
}
