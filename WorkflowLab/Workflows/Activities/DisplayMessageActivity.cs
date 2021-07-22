using System;
using WorkflowLab.Contexts;

namespace WorkflowLab.Workflows.Activities
{
    public class DisplayMessageActivity : IDisplayMessageActivity
    {
        public void Execute(MessageContext context)
        {
            Console.WriteLine(context.Message);
        }
    }
}