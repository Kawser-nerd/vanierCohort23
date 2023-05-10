using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoWk4
{
    class studentGrades: student // inheriting in c#; regular classname: the names of the classes you are inherriting
    {
        public double gradeTerm1 { set; get; }
        public double gradeTerm2 { set; get; }
        public double gradeTerm3 { set; get; }
    }
}
