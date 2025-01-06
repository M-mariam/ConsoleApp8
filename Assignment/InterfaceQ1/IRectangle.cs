using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.InterfaceQ1
{
    internal interface IRectangle : IShape
    { 
         double Length { get; set; } 
         double Width { get; set; }

        void Rectangle(double length, double width);
    }
}
