using System;
using System.Activities;
using System.Activities.Expressions;
using System.Activities.Statements;
using System.Collections.Generic;

namespace BasicWWF
{
    internal class WWFTest
    {
        internal void TestWorkflow()
        {
            //TestSingleLine();
            //TestWithBuilder();
            SimpleTestVariables();
            //TestVariables();
            //TestDynamicActivity();
            //TestMySeqActivity();
            //WorkflowInvoker invoker = new WorkflowInvoker(GetActivity());
            //invoker.Invoke();

        }

        private void TestMySeqActivity()
        {
            InArgument<int> Operand1 = new InArgument<int>();
            InArgument<int> Operand2 = new InArgument<int>();

            Activity act = new MySeq
            {
                Activities =
                {
                    new MyParameterizedStep1()
                    {
                    }
                },
            };

            WorkflowInvoker.Invoke(act, new Dictionary<string, object>()
            {
                    {"Arg1","runetime"}
            });

        }
        private void SimpleTestVariables()
        {
            //http://msdn.microsoft.com/en-us/library/dd986834(v=vs.110).aspx
            WorkflowInvoker.Invoke(new MyParameterizedStep1(), new Dictionary<string, object>()
            {
                {"Arg1","runetime"}
            });
            IDictionary<string, object> res = WorkflowInvoker.Invoke(new MyMultiplyActivity(), new Dictionary<string, object>()
            {
                { "Operand1", 25 },
                    { "Operand2", 15 }
            });
        }
        private void TestVariables()
        {
            InArgument<int> Operand1 = new InArgument<int>();
            InArgument<int> Operand2 = new InArgument<int>();

            Activity act = new Sequence
            {
                Activities =
                {
                    new MyParameterizedStep1()
                    {
                    }
                },
            };

            WorkflowInvoker.Invoke(act, new Dictionary<string, object>()
                {
                {"Arg1","runetime"}
                });
        }

        private void TestDynamicActivity()
        {
            //http://msdn.microsoft.com/en-us/library/ee358749(v=vs.110).aspx
            InArgument<int> Operand1 = new InArgument<int>();
            InArgument<int> Operand2 = new InArgument<int>();

            DynamicActivity<int> wf = new DynamicActivity<int>
            {
                Properties =
                {
                    new DynamicActivityProperty
                    {
                        Name = "Operand1",
                        Type = typeof(InArgument<int>),
                        Value = Operand1
                    },
                    new DynamicActivityProperty
                    {
                        Name = "Operand2",
                        Type = typeof(InArgument<int>),
                        Value = Operand2
                    }
                },
                Implementation = () => new Sequence
                {
                    Activities =
                    {
                        new MyMultiplyActivity()
                        {
                            Operand1 =new InArgument<int>((env)=>Operand1.Get(env)),
                            Operand2=new InArgument<int>((env)=>Operand2.Get(env)),
                            Product=new ArgumentReference<int>{ ArgumentName = "Result" },
                        }
                        //,
                        //new Assign<int>
                        //{
                        //    To = new ArgumentReference<int> { ArgumentName = "Result" },
                        //    Value = new InArgument<int>((env) => Operand1.Get(env) + Operand2.Get(env))
                        //}
                    }
                }
            };

            int result = WorkflowInvoker.Invoke<int>(wf, new Dictionary<string, object>
                {
                    { "Operand1", 25 },
                    { "Operand2", 15 }
                });
            Console.WriteLine(result);
        }

        private void TestWithBuilder()
        {
            ActivityBuilder builder = new ActivityBuilder();

        }

        private void TestSingleLine()
        {
            WorkflowInvoker.Invoke(
                   new Sequence
                   {
                       Activities =
                {
                    new WriteLine {Text = "Hello"},
                    new Sequence
                    {
                        Activities =
                        {
                                        new WriteLine {Text = "Workflow"},
                                        new WriteLine {Text = "World"}
                        }
                    }
                }
                   },
                   new Dictionary<string, object>()
                {
                    { "Operand1", 25 },
                    { "Operand2", 15 }
                });

        }

        private Activity GetActivity()
        {
            Sequence act = new Sequence()
            {
                Activities = { new MyStep1(), new MyStep2() }
            };

            act.Activities.Add(new WriteLine { Text = "Hello " });
            return act;
        }
    }
}
