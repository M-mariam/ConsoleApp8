using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.InterfaceQ1
{
    internal class Rectangle : IRectangle
    {
        public double Length { get ; set; }
        public double Width { get; set; }
        public double area { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double DisplayShapeInfo()
        {
            return Length * Width;

        }

        void IRectangle.Rectangle(double length, double width)
        {
            length = Length;
            width = Width;
        }
    }
}
