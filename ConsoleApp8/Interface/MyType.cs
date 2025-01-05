using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Interface
{
    internal class MyType : IMyType
    {
        // Implement not Inhirit

        double IMyType.Salary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Compare(object? obj)
        {
            throw new NotImplementedException();
        }

        void IMyType.MyFun()
        {
            throw new NotImplementedException();
        }
    }
}
