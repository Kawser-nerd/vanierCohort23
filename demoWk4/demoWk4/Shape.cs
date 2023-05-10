using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoWk4
{
    class Shape
    {
        public double Length { set; get; }
        public double Height { set; get; }

        public virtual double getArea()
        {
            return Length * Height;
        }

        public virtual double getPerimeter()
        {
            return Length + Height;
        }
    }
}
