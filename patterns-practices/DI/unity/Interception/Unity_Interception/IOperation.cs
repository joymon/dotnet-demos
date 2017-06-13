using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity_Interception
{
    public interface IOperation
    {
        void Do(int a, int b);
    }
    public class AddAndWriteToConsoleOperation : IOperation
    {
        void IOperation.Do(int a, int b)
        {
            ICalculator calc = UnityFactory.CreateInstance<ICalculator>();
            
            IWriter writer = UnityFactory.CreateInstance<IWriter>();
            writer.Write($" {a} + {b} = {calc.Add(a, b)}");
        }
    }
}
