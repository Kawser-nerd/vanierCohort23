using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoWk4
{
    class Circle: Shape
    {
        //private double radius = Shape.Length / 2;
        //private double pi = 3.1416;
        public override double getArea()
        {
            return  Math.PI * (Length / 2 * Length / 2);
               
        }

        public override double getPerimeter()
        {
            return 2 * Math.PI * (Length / 2);
        }
    }
}
