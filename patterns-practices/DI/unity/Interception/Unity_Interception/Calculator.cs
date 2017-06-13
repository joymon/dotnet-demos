using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity_Interception
{
    class Calculator:ICalculator
    {
        int ICalculator.Add(int a, int b)
        {
            Console.WriteLine("called");
            return 3;
        }
    }
}
