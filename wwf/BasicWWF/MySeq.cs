﻿using System.Activities;
using System.Activities.Statements;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace BasicWWF
{
    [Designer("System.Activities.Core.Presentation.SequenceDesigner, System.Activities.Core.Presentation")]
    public class MySeq : NativeActivity
    {
        private Sequence innerSequence = new Sequence();

        [RequiredArgument]
        public InArgument<string> Arg1 { get; set; }

        [Browsable(false)]
        public Collection<Activity> Activities
        {
            get
            {
                return innerSequence.Activities;
            }
        }

        [Browsable(false)]
        public Collection<Variable> Variables
        {
            get
            {
                return innerSequence.Variables;
            }
        }

        protected override void CacheMetadata(NativeActivityMetadata metadata)
        {
            base.CacheMetadata(metadata);
            metadata.AddImplementationChild(innerSequence);
        }

        protected override void Execute(NativeActivityContext context)
        {
            context.ScheduleActivity(innerSequence);
        }

    }
}
