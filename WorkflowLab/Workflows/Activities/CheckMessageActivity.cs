using System;
using Workflow.Core;
using WorkflowLab.Contexts;

namespace WorkflowLab.Workflows.Activities
{
    public class CheckMessageActivity : ConditionActivity<MessageContext>, ICheckMessageActivity
    {
        public CheckMessageActivity(
            Func<MessageContext, bool> condition, 
            IActivity<MessageContext> activity)
            : base(condition, activity)
        {
        }

    }
}
