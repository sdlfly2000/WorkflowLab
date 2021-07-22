using System;
using WorkflowLab.Contexts;

namespace WorkflowLab.Workflows.Activities
{
    public class DisplayReferenceActivity : IDisplayReferenceActivity
    {
        public void Execute(MessageContext context)
        {
            Console.WriteLine(context.Reference);
        }
    }
}
