using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity_Interception
{
    public interface IWriter
    {
        void Write(string s);
    }
    class ConsoleWriter : IWriter
    {
        void IWriter.Write(string s)
        {
            Console.WriteLine(s);
        }
    }
}
