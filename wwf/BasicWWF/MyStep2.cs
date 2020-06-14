using System;
using System.Activities;

namespace BasicWWF
{
    class MyStep2 : CodeActivity
    {

        protected override void Execute(CodeActivityContext context)
        {
            Console.WriteLine("Step 2 - Success");
        }
    }
}
