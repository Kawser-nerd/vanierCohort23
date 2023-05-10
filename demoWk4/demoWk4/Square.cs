using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoWk4
{
    class Square: Shape
    {
        public override double getArea()
        {
            return Length * Length;
        }

        public override double getPerimeter()
        {
            return 4 * Length;
        }
    }
}
