using System;
using WorkflowLab.Contexts;
using Common.Core.DependencyInjection;

namespace WorkflowLab.Workflows.Activities
{
    [ServiceLocate(typeof(IDisplayMessageActivity))]
    public class DisplayMessageActivity : IDisplayMessageActivity
    {
        public void Execute(MessageContext context)
        {
            Console.WriteLine(context.Message);
        }
    }
}