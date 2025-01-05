using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Interface02
{
    internal class SeriesBtThree : ISeries
    {
        public int Current { get; set; }

        public void Next()
        {
            Current += 3;
        }

        public void Reset()
        {
            Current = 0;
        }
    }
}
