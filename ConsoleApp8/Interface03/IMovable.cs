using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Interface03
{
    internal interface IMovable
    {
         int Speed { get; set; }
        void Forward();
        void Backward();
        void Left();
        void right();

    }
}
