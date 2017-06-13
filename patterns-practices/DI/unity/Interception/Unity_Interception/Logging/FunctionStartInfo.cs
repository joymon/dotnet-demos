using System.Text;

namespace Unity_Interception
{
    internal class FunctionStartInfo
    {
        public FunctionStartInfo()
        {
        }

        public string Assembly { get; internal set; }
        public string Class { get; internal set; }
        public string InputParams { get; internal set; }
        public string MethodName { get; internal set; }
        public string StartTime { get; internal set; }
        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"{Assembly},{Class}.{ MethodName}(), Start Time: { this.StartTime}, Parameters: {InputParams}";
        }
    }
}