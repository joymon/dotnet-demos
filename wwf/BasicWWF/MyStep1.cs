using System;
using System.Activities;

namespace BasicWWF
{
    internal class MyStep1 : CodeActivity
    {
        protected override void Execute(CodeActivityContext context)
        {
            var prop = new DynamicActivityProperty
            {
                Name = "Operand1",
                Type = typeof(InArgument<int>)

            };
            InArgument<int> Operand1 = new InArgument<int>();


            object luck = context.GetValue(Operand1);
            Console.WriteLine("Step 1 - Success");
        }
    }
}
