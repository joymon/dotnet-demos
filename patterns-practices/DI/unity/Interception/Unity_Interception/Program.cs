using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity_Interception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Started");
            IOperation op = UnityFactory.CreateInstance<IOperation>();
            op.Do(2,3);
            Console.WriteLine("Completed. Press any key to exit...");
            Console.ReadLine();
        }
    }
}
