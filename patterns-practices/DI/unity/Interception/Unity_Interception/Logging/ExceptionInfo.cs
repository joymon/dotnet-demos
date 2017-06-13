using System.Text;

namespace Unity_Interception
{
    internal class ExceptionInfo
    {
        public ExceptionInfo()
        {
        }

        public string Assembly { get; internal set; }
        public string Class { get; internal set; }
        public string Error { get; internal set; }
        public string InputParams { get; internal set; }
        public string Message { get; internal set; }
        public string MethodName { get; internal set; }
        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            StringBuilder expression = new StringBuilder();
            expression.AppendLine(string.Format("Assembly: {0}", Assembly));
            expression.AppendLine(string.Format("Class: {0}", Class));
            expression.AppendLine(string.Format("Method: {0}", MethodName));
            expression.AppendLine(string.Format("Parameters: {0}", InputParams));
            expression.AppendLine(string.Format("Message: {0}", Message));
            expression.AppendLine(string.Format("Error: {0}", Error));

            return expression.ToString();
        }
    }
}