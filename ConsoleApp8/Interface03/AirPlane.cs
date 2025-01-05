using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Interface03
{
    internal class AirPlane : IMovable, IFlyable
    {
        int IFlyable.Speed { get  ; set ; }
        int IMovable.Speed { get; set; }

        void IFlyable.Backward() 
        {
            Console.WriteLine("airplane IFlyable Backward");

        }

        void IMovable.Backward()
        {
            Console.WriteLine("Car IMoveable Backward");
        }

        void IFlyable.Forward()
        {
            Console.WriteLine("airplane IFlyable Forward");

        }

        void IMovable.Forward()
        {
            Console.WriteLine("Car IMovable Forward");

        }

        void IFlyable.Left()
        {
            Console.WriteLine("airplane IFlyable Left");

        }

        void IMovable.Left()
        {
            Console.WriteLine("Car IMovable Left");

        }

        void IFlyable.right()
        {
            Console.WriteLine("airplane IFlyable right");

        }

        void IMovable.right()
        {
            Console.WriteLine("Car IMovable right");

        }
    }
}
