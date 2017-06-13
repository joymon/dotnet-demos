using System;
using System.Diagnostics;
using System.Threading;

namespace Unity_Interception
{
    public class Logger
    {
        internal void WriteFunctionStart(FunctionStartInfo v)
        {
            WriteLine(v.ToString());
        }

        internal void WriteFunctionEndInfo(FunctionEndInfo v)
        {
            WriteLine(v.ToString());
        }

        internal void WriteException(ExceptionInfo ei)
        {
            WriteLine(ei.ToString());
        }
        private void WriteLine(string msg)
        {
            Trace.WriteLine($"Thread Id:{Thread.CurrentThread.ManagedThreadId},{msg}");
        }
    }
}