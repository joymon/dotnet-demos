using System.Activities;

namespace BasicWWF
{
    public class MyParameterizedStep1 : CodeActivity
    {
        [RequiredArgument]
        public InArgument<string> Arg1 { get; set; }
        //public MyParameterizedStep1(string Arg1)
        //{
        //    this.Arg1 = Arg1;
        //}
        protected override void CacheMetadata(CodeActivityMetadata metadata)
        {

            base.CacheMetadata(metadata);
        }
        protected override void Execute(CodeActivityContext context)
        {

            string output = context.GetValue(Arg1);
            System.Console.WriteLine("Param received" + output);
        }

    }
}
