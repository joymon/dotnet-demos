using Microsoft.Practices.Unity.InterceptionExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity_Interception
{
    
        ///<example>
        ///<code lang="c#">

        ///LogCallHandler logCallHandler=new LogCallHandler();
        /// </code>
        /// </example>
        /// <summary>
        /// Class to represent LogCallHandler 
        /// </summary>

        public class LogCallHandler : ICallHandler
    {

        Logger eventSource;
        /// <summary>
        /// Gets or sets the custom event source.
        /// </summary>
        /// <value>
        /// The custom event source.
        /// </value>
        public Logger Logger
        {
            get { return eventSource; }
            set { eventSource = value; }
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="LogCallHandler"/> class.
        /// </summary>
        public LogCallHandler()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogCallHandler"/> class.
        /// </summary>
        /// <param name="EventSource">The event source.</param>
        public LogCallHandler(Logger EventSource)
        {
            eventSource = EventSource;
        }
        /// <summary>
        /// Implement this method to execute your handler processing.
        /// </summary>
        /// <param name="input">Inputs to the current call to the target.</param>
        /// <param name="getNext">Delegate to execute to get the next delegate in the handler
        /// chain.</param>
        /// <returns>
        /// Return value from the target.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">getNext</exception>
        IMethodReturn ICallHandler.Invoke(IMethodInvocation input, GetNextHandlerDelegate getNext)
        {
            if (input.MethodBase.Name == "Resolve")
            {
                Logger.WriteFunctionStart(GetStartInformation(input));
            }
            else
            {
                Logger.WriteFunctionStart(GetStartInformation(input));
            }

            if (getNext == null)
            {
                throw new ArgumentNullException("getNext");
            }
            IMethodReturn result = getNext()(input, getNext);

            if (result.Exception != null)
            {
                Logger.WriteException(GetExceptionDetails(input, result));
            }

            if (input.MethodBase.Name == "Resolve")
            {
                Logger.WriteFunctionEndInfo(GetEndInformation(input, result));
            }
            else
            {
                Logger.WriteFunctionEndInfo(GetEndInformation(input, result));
            }
            return result;
        }

        int ICallHandler.Order
        {
            get;
            set;
        }

        private static bool IsPrimitive(Type t)
        {
            return new[] {
            typeof(string),
            typeof(char),
            typeof(byte),
            typeof(sbyte),
            typeof(ushort),
            typeof(short),
            typeof(uint),
            typeof(int),
            typeof(ulong),
            typeof(long),
            typeof(float),
            typeof(double),
            typeof(decimal),
            typeof(DateTime),
            }.Contains(t);
        }

        private FunctionStartInfo GetStartInformation(IMethodInvocation input)
        {
            FunctionStartInfo log = new FunctionStartInfo();
            log.MethodName = input.MethodBase.Name;
            log.Assembly = input.MethodBase.Module.ToString();
            log.Class = input.Target.ToString();
            log.InputParams = GetParameters(input);
            log.StartTime = DateTime.Now.ToUniversalTime().ToString();
            return log;
        }

        private FunctionEndInfo GetEndInformation(IMethodInvocation input, IMethodReturn result)
        {
            FunctionEndInfo log = new FunctionEndInfo();
            log.MethodName = input.MethodBase.Name;
            log.Assembly = input.MethodBase.Module.ToString();
            log.Class = input.Target.ToString();
            log.InputParams = GetParameters(input);
            log.EndTime = DateTime.Now.ToUniversalTime().ToString();
            if (IsPrimitive(result.GetType()))
            {
                log.Result = DateTime.Now.ToUniversalTime().ToString();
            }
            return log;
        }

        private ExceptionInfo GetExceptionDetails(IMethodInvocation input, IMethodReturn result)
        {
            ExceptionInfo log = new ExceptionInfo();
            log.MethodName = input.MethodBase.Name;
            log.Assembly = input.MethodBase.Module.ToString();
            log.Class = input.Target.ToString();
            log.InputParams = GetParameters(input);
            log.Error = result.Exception.StackTrace;
            log.Message = result.Exception.Message;

            return log;
        }

        private string GetParameters(IMethodInvocation input)
        {
            StringBuilder parameters = new StringBuilder();
            for (int index = 0; index < input.Arguments.Count; index++)
            {
                parameters.AppendFormat($"({input.Arguments.GetParameterInfo(index).Name},{input.Arguments.GetParameterInfo(index).ParameterType.ToString()},{GetParamValue(input, index)})");
            }
            return parameters.ToString();
        }

        private static string GetParamValue(IMethodInvocation input, int index )
        {
            string paramValue = string.Empty;
            if (IsPrimitive(input.Arguments.GetParameterInfo(index).ParameterType))
            {
                if (input.Arguments[index] != null)
                    paramValue = input.Arguments[index].ToString();
                else
                    paramValue = "null";
            }

            return paramValue;
        }
    }
}
