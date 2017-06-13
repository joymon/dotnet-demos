using System.Text;

namespace Unity_Interception
{
    internal class FunctionEndInfo
    {
        public string Assembly { get; internal set; }
        public string Class { get; internal set; }
        public string EndTime { get; internal set; }
        public string InputParams { get; internal set; }
        public string MethodName { get; internal set; }
        public string Result { get; internal set; }
        public override string ToString()
        {
            return $"{Assembly}, {Class}.{ MethodName}(), End Time: { this.EndTime}, Parameters: {InputParams}, Result {Result}";
        }
    }
}