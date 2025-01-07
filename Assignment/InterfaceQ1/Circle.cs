using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.InterfaceQ1
{
    internal class Circle : ICircle
    {
        public double Radius { get; set; }
        public double area { get; set; }

        void ICircle.Circle(double radius)
        {
            radius = Radius;
        }

        public double DisplayShapeInfo()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }


}

