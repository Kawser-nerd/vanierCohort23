using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * It's multiline commenting
 * 
 * Name: Kawser Wazed Nafi
 * ID: nafik
 */

    // single line comments
namespace cohortConsoleApp // package name
{
    class Program // class name; here class is by default public
    {
        // this is the scope for global variables or class instances. Class instances are the objects created for each class.
        static void Main(string[] args) // again, by default, the Main() method is public. the Main() should always start with Capital
        {

            /*
             * In this program we are going to take two variables as Console input and add them and print the result to Console 
             */

            // In C#, anything you want to take input from Console or to print anything to Console will be under Console class

            // the supported dataTypes are 
            double num1, num2;

            // to oprint in Console
            Console.WriteLine("Enter two numbers one after another in Console");

            // the values we are going to read from Console will always be String. So we need to convert the input String to double

            num1 = Double.Parse(Console.ReadLine()); // Double.Parse will convert the String to double and Console.ReadLine() will 
            // read the input and move the cursor to the new Line.

            num2 = Double.Parse(Console.ReadLine());

            // now we are going to add two numbers together

            num1 = num1 + num2;

            // Print them back to Console

            Console.WriteLine("The Result is: " + num1);

            // We need to add additional keystroke to see the value in the console, otherwise it will get exited.
            // THe following method will wait to get a keystroke from keyboard so we can see the output in the console
            Console.ReadKey();

        }

        /*
         * Program 1: Take your Name and Student ID from Console and Print them back on the Console
         * 
         * Program 2: Take input two variables, one is integer and the second one is double, multiply them and show the
         * reult on Console
         */






    }
}
