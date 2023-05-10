using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demoWk4.Controller;
using demoWk4.Model;

/*
 * we are going to see a mini calculator
 * 
 * we will see addition, substraction, multiplication and division
 * */


namespace demoWk4
{
    class Program
    {
        // we are going to see MVC structure.. The main method will work as view
        // so , we are going to create model and controller
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter two values");
            double var1 = double.Parse(Console.ReadLine());
            double var2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your choice: \n 1 for Add, \n2 for Minus, \n3 for Multiplication, \n4 for division");
            int choice = int.Parse(Console.ReadLine());

            controller crt = new controller();
            crt.model = new model(var1, var2);// because of having contru
            switch (choice)
            {
                case 1:
                    Console.WriteLine(crt.model.addition());
                    break;

                case 2:
                    Console.WriteLine(crt.model.substraction());
                    break;
                case 3:
                    Console.WriteLine(crt.model.multiplication());
                    break;
                case 4:
                    Console.WriteLine(crt.model.division());
                    break;
            }

            // now we are going to work with model without constructor

            controller crt2 = new controller();
            Console.WriteLine("Enter your choice: \n 1 for Add, \n2 for Minus, \n3 for Multiplication, \n4 for division");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine(crt2.model2.addition(var1, var2));
                    break;

                case 2:
                    Console.WriteLine(crt2.model2.substraction(var1, var2));
                    break;
                case 3:
                    Console.WriteLine(crt2.model2.multiplication(var1, var2));
                    break;
                case 4:
                    Console.WriteLine(crt2.model2.division(var1, var2));
                    break;
            }
            //crt2.model2.addition(var1, var2);
            */
            /*
            studentGrades studentGrades = new studentGrades();
            Console.WriteLine("Name");
            studentGrades.Name = Console.ReadLine();
            Console.WriteLine("ID");
            studentGrades.id = int.Parse(Console.ReadLine());
            Console.WriteLine("Address");
            studentGrades.address = Console.ReadLine();
            Console.WriteLine("Term");
            studentGrades.term = Console.ReadLine();
            Console.WriteLine("GradeTerm1");
            studentGrades.gradeTerm1 = double.Parse(Console.ReadLine());
            Console.WriteLine("GradeTerm2");
            studentGrades.gradeTerm2 = double.Parse( Console.ReadLine());
            Console.WriteLine("GradeTerm3");
            studentGrades.gradeTerm3 = double.Parse(Console.ReadLine());
            */
            /*
             * Create a class shape which will take two values, length and height of any objects
             * 
             * 1. create a class rectangle which will inherit shape class and 
             * calculate the area and perimeter/circumference
             * 
             * 2. create a class square which will inherit shape class and 
             * calculate the area and perimeter/circumference
             * 
             * 3. create a class circle which will inherit the shape class 
             * and calculate the area and perimeter/circumference
             * for radius you can use half of the length, means radius = length/2
             * 
             * 
             */



            Shape shape = new Shape(); // created the instance for the superclass
            Console.WriteLine("Insert value for Length");
            shape.Length = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert value for Height");
            shape.Height = double.Parse(Console.ReadLine());

            // Inheritance

            // Rectangle
            Rectangle rectangle = new Rectangle();
            rectangle.Length = shape.Length;
            rectangle.Height = shape.Height;
            Console.WriteLine("The area of Rectangle");
            Console.WriteLine(rectangle.getArea());

            // Circle
            Circle circle = new Circle();
            circle.Length = shape.Length;
            Console.WriteLine("The area of Circle");
            Console.WriteLine(circle.getArea());

            // Square
            Square square = new Square();
            square.Length = shape.Length;
            square.Height = shape.Height;
            Console.WriteLine("The area of Square");
            Console.WriteLine(square.getArea());

            
            // Rectangle
            
            Console.WriteLine("The perimeter of Rectangle");
            Console.WriteLine(rectangle.getPerimeter());

            // Circle
            
            Console.WriteLine("The area of Circle");
            Console.WriteLine(circle.getPerimeter());

            // Square
            
            Console.WriteLine("The area of Square");
            Console.WriteLine(square.getPerimeter());

            /*
             * PolyMorphism: Using different type/form of the same class or object/instance
             * 
             * That means, you can have same class instance under different type or class
             * 
             * For example, for a circle class instance, you can redefine it with shape class
             * 
             * 
             */

            Circle circle2 = new Circle();

            Shape circle3 = new Circle();

            /*
             * 
             */

            Console.ReadKey();

        }
    }
}
