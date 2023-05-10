using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectwk3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double value1, value2;
            string c;
            do
            {
                Console.WriteLine("Enter Value One");
                value1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Value Two");
                value2 = double.Parse(Console.ReadLine());
               
           
                Console.WriteLine("Enter your Choice:");
                Console.WriteLine("1 to add");
                Console.WriteLine("2 to substract");
                Console.WriteLine("3 to multiply");
                Console.WriteLine("4 to division");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine(Add(value1, value2));
                        break;
                    case 2:
                        Console.WriteLine(Minus(value1, value2));
                        break;
                    case 3:
                        Console.WriteLine(Multiply(value1, value2));
                        break;
                    case 4:
                        Console.WriteLine(Division(value1, value2));
                        break;
                    default:
                        Console.WriteLine("Enter correct choice");
                        break;
                }
                Console.WriteLine("Do you want to enter again??");
                c = Console.ReadLine();
            } while (c != "n" || c != "N");

        }

        // to create any method you need to pass the following syntax

        /*
         * access_modifier return_datatype method_name (arguments list(options))
         * 
         * 
         * access_modifier: public, private or protected
         * 
         * return_datatype: it could be any datatype based on what type of data is being returned by the method
         * itself
         * 
         * i.e. if the method is returning int datatype value at the end, we put int datatype as return_datatype
         * 
         */

        private static double Add(double value1, double value2)
        {
            return value1 + value2;
        }

        private static double Minus(double value1, double value2)
        {
            return value1 - value2;
        }

        private static double Multiply(double value1, double value2)
        {
            return value1 * value2;
        }

        private static double Division(double value1, double value2)
        {
            return value1 / value2;
        }


    }
}
