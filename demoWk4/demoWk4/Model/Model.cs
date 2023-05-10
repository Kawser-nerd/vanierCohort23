using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoWk4.Model
{
    class model
    {
        // we are going to perform all the methods and logical stuffs inside this class
        private double var1;
        private double var2;

        public model(double var1, double var2) // this is constructor. We use it to execute the class whenever its created or instiated
        {
            this.var1 = var1; // these two lines are updating the local class variables
            this.var2 = var2;
        }

        public double addition()
        {
            return (this.var1 + this.var2);
        }

        public double substraction()
        {
            return this.var1 - this.var2;
        }

        public double multiplication()
        {
            return this.var1 * this.var2;
        }

        public double division ()
        {
            try
            {
                return this.var1 / this.var2;
            } catch( DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }
    }
}
