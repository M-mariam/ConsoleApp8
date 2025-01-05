using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Interface
{
    internal interface IMyType
    {
        // what can i write inside it?
        // 1. Signature of methode ( name, return type, parameter)
        void MyFun();
        // 2. signature of property 
        double Salary { get; set; } // Automatic property = Signature of property

        // 3. Default Implemented Method (Fully Implemented Method)
        void Print()
        {
            Console.WriteLine();
        }
    }
}
