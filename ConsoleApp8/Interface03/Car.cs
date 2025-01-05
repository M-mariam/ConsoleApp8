using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Interface03
{
    internal class Car : IMovable
    {
        public int Speed { get; set; }

        public void Backward()
        {
            Console.WriteLine("Car IMoveable backward");
        }

        public void Forward()
        {
            Console.WriteLine("Car IMoveable Forward");

        }

        public void Left()
        {
            Console.WriteLine("Car IMoveable Left");

        }

        public void right()
        {
            Console.WriteLine("Car IMoveable right");

        }
    }
}
