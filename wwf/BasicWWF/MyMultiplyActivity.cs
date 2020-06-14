using System.Activities;

namespace BasicWWF
{
    public class MyMultiplyActivity : CodeActivity
    {
        [RequiredArgument]
        public InArgument<int> Operand1 { get; set; }
        [RequiredArgument]
        public InArgument<int> Operand2 { get; set; }

        [RequiredArgument]
        public OutArgument<int> Product { get; set; }

        [RequiredArgument]
        public OutArgument<int> Sum { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            int a = Operand1.Get(context);
            int b = context.GetValue(Operand2);
            int c = a * b;
            Product.Set(context, c);
            Sum.Set(context, a + b);
        }
    }
}
