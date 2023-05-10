using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoWk4
{
    class Rectangle: Shape
    {
        
        public override double getArea()
        {
            return Length * Height;
        }

        public override double getPerimeter()
        {
            return 2 * (Length + Height);
        }
    }
}
