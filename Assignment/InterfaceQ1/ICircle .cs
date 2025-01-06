using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.InterfaceQ1
{
    internal interface ICircle : IShape
    {

        double Radius { get; set; }

        void Circle(double radius);
       
    }
}
